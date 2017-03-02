package org.dddml.wms.domain;

import org.dddml.wms.domain.*;
import java.util.*;
import org.dddml.wms.specialization.*;

public class OrganizationStructureTypeStateEventIdFlattenedDtoFormatter extends AbstractIdFlattenedDtoFormatter<OrganizationStructureTypeStateEventIdFlattenedDto>
{


    @Override
    protected OrganizationStructureTypeStateEventIdFlattenedDto newDto() {
        return new OrganizationStructureTypeStateEventIdFlattenedDto();
    }

    @Override
    protected String[] getFieldNames() {
        return OrganizationStructureTypeStateEventIdFlattenedDto.propertyNames;
    }

    @Override
    protected void setFieldStringValue(OrganizationStructureTypeStateEventIdFlattenedDto dto, String fieldName, String fieldValue) {
        Class clazz = getFieldClass(fieldName);
        Object objVal = ApplicationContext.current.getTypeConverter().convertFromString(clazz, fieldValue);
        if ("id".equals(fieldName)) {
            dto.setId((String) objVal);
            return;
        }
        if ("version".equals(fieldName)) {
            dto.setVersion((Long) objVal);
            return;
        }
    }

    @Override
    protected String getFieldStringValue(OrganizationStructureTypeStateEventIdFlattenedDto dto, String fieldName) {
        Class clazz = getFieldClass(fieldName);
        if ("id".equals(fieldName)) {
            Object objVal = dto.getId();
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
        String type = OrganizationStructureTypeStateEventIdFlattenedDto.propertyTypeMap.get(fieldName);
        if(type == null) {
            throw new IllegalArgumentException(String.format("The field name \"%1$s\" is NOT right.", fieldName));
        }
        Class clazz = ReflectUtils.CLASS_MAP.get(type);
        return clazz;
    }

}

