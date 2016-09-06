package org.dddml.wms.restful.provider;

import org.dddml.wms.restful.exception.AuthenticateException;
import org.dddml.wms.restful.exception.WebApiApplicationException;
import org.dddml.wms.specialization.DomainError;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import javax.validation.ConstraintViolation;
import javax.validation.ConstraintViolationException;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.Response.Status;
import javax.ws.rs.ext.ExceptionMapper;
import java.util.Iterator;
import java.util.Locale;

public class CustomExceptionMapper implements ExceptionMapper<Exception> {

    private Logger log = LoggerFactory.getLogger(CustomExceptionMapper.class);

    @Override
    public Response toResponse(Exception e) {
        if (e instanceof AuthenticateException) {
            return Response.status(Status.FORBIDDEN).encoding("UTF-8").language(Locale.SIMPLIFIED_CHINESE)
                    .type(MediaType.TEXT_PLAIN).entity(e.getMessage()).build();
        } else if (e instanceof WebApiApplicationException || e instanceof DomainError) {
            return Response.status(Status.INTERNAL_SERVER_ERROR).encoding("UTF-8").language(Locale.SIMPLIFIED_CHINESE)
                    .type(MediaType.TEXT_PLAIN).entity(e.getMessage()).build();

        } else if (e instanceof ConstraintViolationException) {/** 参数验证失败异常 */
            ConstraintViolationException exception = (ConstraintViolationException) e;
            StringBuilder sbHint = new StringBuilder("参数错误");
            StringBuilder errorLog = new StringBuilder("\r\n");
            if (exception.getConstraintViolations() != null && exception.getConstraintViolations().size() > 0) {
                sbHint.append(":\r\n");
                int i = 1;
                Iterator<ConstraintViolation<?>> itertor = exception.getConstraintViolations().iterator();
                while (itertor.hasNext()) {
                    ConstraintViolation<?> violation = itertor.next();
                    if (i == 1) {
                        try {
                            String rootBeanClassName = violation.getRootBeanClass().getName();
                            String[] paths = rootBeanClassName.split("\\.");
                            if (paths != null && paths.length > 0) {
                                String shortBeanName = paths[paths.length - 1];
                                errorLog.append("接口类：").append(shortBeanName);
                            }
                            try {
                                String methodName = violation.getPropertyPath().iterator().next().getName();
                                errorLog.append("->").append("方法名：").append(methodName);
                            } catch (Exception x) {
                            }
                            errorLog.append("\r\n");
                        } catch (Exception ex) {
                        }
                    }
                    sbHint.append("    ");
                    sbHint.append(String.valueOf(i)).append("、").append(violation.getMessage());
                    try {
                        sbHint.append("，实际值[").append(violation.getExecutableParameters()[i - 1]);
                    } catch (Exception a) {
                    } finally {
                        sbHint.append("]");
                    }
                    if (i < exception.getConstraintViolations().size()) {
                        sbHint.append("\r\n");
                    }
                    i++;
                }
            }
            String error = errorLog.append(sbHint).append("\r\n").toString();
            this.log.error(error);
            String info = sbHint.toString().replaceAll("，实际值\\[.*\\]", "");
            return Response.status(Status.BAD_REQUEST).encoding("UTF-8").type(MediaType.TEXT_PLAIN)
                    .language(Locale.SIMPLIFIED_CHINESE).entity(error).build();
        }
        log.error(e.getMessage(), e);
        return Response.status(Status.INTERNAL_SERVER_ERROR).encoding("UTF-8").language(Locale.SIMPLIFIED_CHINESE)
                .type(MediaType.TEXT_PLAIN).entity("服务器错误").build();
    }

}
