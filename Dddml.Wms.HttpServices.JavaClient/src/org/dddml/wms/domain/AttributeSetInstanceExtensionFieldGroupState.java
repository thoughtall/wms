package org.dddml.wms.domain;

import java.util.Set;
import java.util.Date;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.AttributeSetInstanceExtensionFieldGroupStateEvent.*;

public interface AttributeSetInstanceExtensionFieldGroupState
{
    String getId();

    void setId(String id);

    String getFieldType();

    void setFieldType(String fieldType);

    Integer getFieldLength();

    void setFieldLength(Integer fieldLength);

    Integer getFieldCount();

    void setFieldCount(Integer fieldCount);

    String getNameFormat();

    void setNameFormat(String nameFormat);

    String getDescription();

    void setDescription(String description);

    Long getVersion();

    void setVersion(Long version);

    Boolean getActive();

    void setActive(Boolean active);


    boolean isStateUnsaved();

    AttributeSetInstanceExtensionFieldStates getFields();


    void when(AttributeSetInstanceExtensionFieldGroupStateCreated e);

    void when(AttributeSetInstanceExtensionFieldGroupStateMergePatched e);

    void when(AttributeSetInstanceExtensionFieldGroupStateDeleted e);

    void mutate(Event e);

    
}
