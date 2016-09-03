package org.dddml.wms.domain;

import java.util.*;
import org.dddml.wms.specialization.*;

public class InOutLineIdFlattenedDtoFormatter extends AbstractIdFlattenedDtoFormatter<InOutLineIdFlattenedDto>
{


    @Override
    protected InOutLineIdFlattenedDto newDto() {
        return new InOutLineIdFlattenedDto();
    }

    @Override
    protected String[] getFieldNames() {
        return InOutLineIdFlattenedDto.propertyNames;
    }

    @Override
    protected void setFieldStringValue(InOutLineIdFlattenedDto dto, String fieldName, String fieldValue) {
        Class clazz = getFieldClass(fieldName);
        Object objVal = ApplicationContext.current.getTypeConverter().convertFromString(clazz, fieldValue);
        if ("inOutDocumentNumber".equals(fieldName)) {
            dto.setInOutDocumentNumber((String) objVal);
            return;
        }
        if ("skuIdProductId".equals(fieldName)) {
            dto.setSkuIdProductId((String) objVal);
            return;
        }
        if ("skuIdAttributeSetInstanceId".equals(fieldName)) {
            dto.setSkuIdAttributeSetInstanceId((String) objVal);
            return;
        }
    }

    @Override
    protected String getFieldStringValue(InOutLineIdFlattenedDto dto, String fieldName) {
        Class clazz = getFieldClass(fieldName);
        if ("inOutDocumentNumber".equals(fieldName)) {
            Object objVal = dto.getInOutDocumentNumber();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        if ("skuIdProductId".equals(fieldName)) {
            Object objVal = dto.getSkuIdProductId();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        if ("skuIdAttributeSetInstanceId".equals(fieldName)) {
            Object objVal = dto.getSkuIdAttributeSetInstanceId();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        return null;
    }

    protected Class getFieldClass(String fieldName) {
        String type = InOutLineIdFlattenedDto.propertyTypeMap.get(fieldName);
        if(type == null) {
            throw new IllegalArgumentException(String.format("The field name \"%1$s\" is NOT right.", fieldName));
        }
        Class clazz = ReflectUtils.CLASS_MAP.get(type);
        return clazz;
    }

}

