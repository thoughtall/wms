package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.*;

public interface AttributeSetInstanceExtensionFieldStateEventDao
{
    void save(AttributeSetInstanceExtensionFieldStateEvent e);

    Iterable<AttributeSetInstanceExtensionFieldStateEvent> findByAttributeSetInstanceExtensionFieldGroupStateEventId(AttributeSetInstanceExtensionFieldGroupStateEventId attributeSetInstanceExtensionFieldGroupStateEventId);

}

