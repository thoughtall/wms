package org.dddml.wms.domain.inoutlinemvo.hibernate;

import java.io.Serializable;
import java.util.*;
import org.dddml.wms.domain.inout.*;
import java.math.BigDecimal;
import java.util.Date;
import org.joda.money.Money;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.inoutlinemvo.*;

public class HibernateInOutLineMvoEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new InOutLineMvoStateEventId((InOutLineId) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedStateEventType()
    {
        return AbstractInOutLineMvoStateEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractInOutLineMvoStateEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        InOutLineId idObj = (InOutLineId) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractInOutLineMvoStateEvent.class);
        criteria.add(Restrictions.eq("stateEventId.inOutLineIdInOutDocumentNumber", idObj.getInOutDocumentNumber()));
        criteria.add(Restrictions.eq("stateEventId.inOutLineIdLineNumber", idObj.getLineNumber()));
        criteria.add(Restrictions.le("stateEventId.inOutVersion", version));
        criteria.addOrder(Order.asc("stateEventId.inOutVersion"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractInOutLineMvoStateEvent) e).setStateEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractInOutLineMvoStateEvent) es.get(es.size() - 1)).getStateEventId().getInOutVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

