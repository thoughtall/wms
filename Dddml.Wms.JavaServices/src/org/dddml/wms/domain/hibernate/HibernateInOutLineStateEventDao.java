package org.dddml.wms.domain.hibernate;

import java.math.BigDecimal;
import java.util.Date;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class HibernateInOutLineStateEventDao implements InOutLineStateEventDao
{
    public SessionFactory sessionFactory;

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    @Override
    public void save(InOutLineStateEvent e)
    {
        getCurrentSession().save(e);
        if (e instanceof Saveable)
        {
            Saveable saveable = (Saveable) e;
            saveable.save();
        }
    }


    //[Transaction(ReadOnly = true)]
    @Override
    public Iterable<InOutLineStateEvent> findByInOutStateEventId(InOutStateEventId inOutStateEventId)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractInOutLineStateEvent.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("stateEventId.inOutDocumentNumber", inOutStateEventId.getDocumentNumber()))
            .add(Restrictions.eq("stateEventId.inOutVersion", inOutStateEventId.getVersion()))
            ;
        return criteria.add(partIdCondition).list();
    }

}

