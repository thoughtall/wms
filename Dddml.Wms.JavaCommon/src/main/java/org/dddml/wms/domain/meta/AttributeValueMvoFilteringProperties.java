package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class AttributeValueMvoFilteringProperties
{

    private AttributeValueMvoFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "name",
            "description",
            "referenceId",
            "version",
            "createdBy",
            "createdAt",
            "updatedBy",
            "updatedAt",
            "active",
            "deleted",
            "attributeName",
            "attributeOrganizationId",
            "attributeDescription",
            "attributeIsMandatory",
            "attributeIsInstanceAttribute",
            "attributeAttributeValueType",
            "attributeAttributeValueLength",
            "attributeIsList",
            "attributeFieldName",
            "attributeReferenceId",
            "attributeVersion",
            "attributeCreatedBy",
            "attributeCreatedAt",
            "attributeUpdatedBy",
            "attributeUpdatedAt",
            "attributeActive",
            "attributeDeleted",
            "attributeValueId.attributeId",
            "attributeValueId.value",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
            "Boolean",
            "Boolean",
            "String",
            "Integer",
            "Boolean",
            "String",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
    };

    public static final Map<String, String> propertyTypeMap;

    public static final Map<String, String> aliasMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        initPropertyTypeMap();
        aliasMap = new HashMap<String, String>();
        initAliasMap();
    }

    private static  void initAliasMap() {
        aliasMap.put("name", "name");
        aliasMap.put("Name", "name");
        aliasMap.put("description", "description");
        aliasMap.put("Description", "description");
        aliasMap.put("referenceId", "referenceId");
        aliasMap.put("ReferenceId", "referenceId");
        aliasMap.put("version", "version");
        aliasMap.put("Version", "version");
        aliasMap.put("createdBy", "createdBy");
        aliasMap.put("CreatedBy", "createdBy");
        aliasMap.put("createdAt", "createdAt");
        aliasMap.put("CreatedAt", "createdAt");
        aliasMap.put("updatedBy", "updatedBy");
        aliasMap.put("UpdatedBy", "updatedBy");
        aliasMap.put("updatedAt", "updatedAt");
        aliasMap.put("UpdatedAt", "updatedAt");
        aliasMap.put("active", "active");
        aliasMap.put("Active", "active");
        aliasMap.put("deleted", "deleted");
        aliasMap.put("Deleted", "deleted");
        aliasMap.put("attributeName", "attributeName");
        aliasMap.put("AttributeName", "attributeName");
        aliasMap.put("attributeOrganizationId", "attributeOrganizationId");
        aliasMap.put("AttributeOrganizationId", "attributeOrganizationId");
        aliasMap.put("attributeDescription", "attributeDescription");
        aliasMap.put("AttributeDescription", "attributeDescription");
        aliasMap.put("attributeIsMandatory", "attributeIsMandatory");
        aliasMap.put("AttributeIsMandatory", "attributeIsMandatory");
        aliasMap.put("attributeIsInstanceAttribute", "attributeIsInstanceAttribute");
        aliasMap.put("AttributeIsInstanceAttribute", "attributeIsInstanceAttribute");
        aliasMap.put("attributeAttributeValueType", "attributeAttributeValueType");
        aliasMap.put("AttributeAttributeValueType", "attributeAttributeValueType");
        aliasMap.put("attributeAttributeValueLength", "attributeAttributeValueLength");
        aliasMap.put("AttributeAttributeValueLength", "attributeAttributeValueLength");
        aliasMap.put("attributeIsList", "attributeIsList");
        aliasMap.put("AttributeIsList", "attributeIsList");
        aliasMap.put("attributeFieldName", "attributeFieldName");
        aliasMap.put("AttributeFieldName", "attributeFieldName");
        aliasMap.put("attributeReferenceId", "attributeReferenceId");
        aliasMap.put("AttributeReferenceId", "attributeReferenceId");
        aliasMap.put("attributeVersion", "attributeVersion");
        aliasMap.put("AttributeVersion", "attributeVersion");
        aliasMap.put("attributeCreatedBy", "attributeCreatedBy");
        aliasMap.put("AttributeCreatedBy", "attributeCreatedBy");
        aliasMap.put("attributeCreatedAt", "attributeCreatedAt");
        aliasMap.put("AttributeCreatedAt", "attributeCreatedAt");
        aliasMap.put("attributeUpdatedBy", "attributeUpdatedBy");
        aliasMap.put("AttributeUpdatedBy", "attributeUpdatedBy");
        aliasMap.put("attributeUpdatedAt", "attributeUpdatedAt");
        aliasMap.put("AttributeUpdatedAt", "attributeUpdatedAt");
        aliasMap.put("attributeActive", "attributeActive");
        aliasMap.put("AttributeActive", "attributeActive");
        aliasMap.put("attributeDeleted", "attributeDeleted");
        aliasMap.put("AttributeDeleted", "attributeDeleted");
        aliasMap.put("attributeValueId.attributeId", "attributeValueId.attributeId");
        aliasMap.put("AttributeValueId.AttributeId", "attributeValueId.attributeId");
        aliasMap.put("attributeValueId.value", "attributeValueId.value");
        aliasMap.put("AttributeValueId.Value", "attributeValueId.value");
    }

    private static void initPropertyTypeMap() {
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}

