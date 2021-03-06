package org.dddml.wms.domain.inout;

import org.dddml.wms.domain.*;
import java.util.*;
import org.dddml.wms.specialization.*;

public class InOutStateEventIdFlattenedDtoFormatter extends AbstractIdFlattenedDtoFormatter<InOutStateEventIdFlattenedDto>
{


    @Override
    protected InOutStateEventIdFlattenedDto newDto() {
        return new InOutStateEventIdFlattenedDto();
    }

    @Override
    protected String[] getFieldNames() {
        return InOutStateEventIdFlattenedDto.propertyNames;
    }

    @Override
    protected void setFieldStringValue(InOutStateEventIdFlattenedDto dto, String fieldName, String fieldValue) {
        Class clazz = getFieldClass(fieldName);
        Object objVal = ApplicationContext.current.getTypeConverter().convertFromString(clazz, fieldValue);
        if ("documentNumber".equals(fieldName)) {
            dto.setDocumentNumber((String) objVal);
            return;
        }
        if ("version".equals(fieldName)) {
            dto.setVersion((Long) objVal);
            return;
        }
    }

    @Override
    protected String getFieldStringValue(InOutStateEventIdFlattenedDto dto, String fieldName) {
        Class clazz = getFieldClass(fieldName);
        if ("documentNumber".equals(fieldName)) {
            Object objVal = dto.getDocumentNumber();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        if ("version".equals(fieldName)) {
            Object objVal = dto.getVersion();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        return null;
    }

    protected Class getFieldClass(String fieldName) {
        String type = InOutStateEventIdFlattenedDto.propertyTypeMap.get(fieldName);
        if(type == null) {
            throw new IllegalArgumentException(String.format("The field name \"%1$s\" is NOT right.", fieldName));
        }
        Class clazz = ReflectUtils.CLASS_MAP.get(type);
        return clazz;
    }

}

