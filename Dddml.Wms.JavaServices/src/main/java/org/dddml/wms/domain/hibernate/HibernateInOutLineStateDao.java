package org.dddml.wms.domain.hibernate;

import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import java.util.*;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateInOutLineStateDao implements InOutLineStateDao
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    private static final Set<String> readOnlyPropertyPascalCaseNames = new HashSet<String>(Arrays.asList("SkuId", "LineNumber", "Description", "LocatorId", "Product", "UomId", "MovementQuantity", "ConfirmedQuantity", "ScrappedQuantity", "TargetQuantity", "PickedQuantity", "IsInvoiced", "AttributeSetInstanceId", "IsDescription", "Processed", "QuantityEntered", "RmaLineNumber", "ReversalLineNumber", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "InOutDocumentNumber"));
    
    private ReadOnlyProxyGenerator readOnlyProxyGenerator;
    
    public ReadOnlyProxyGenerator getReadOnlyProxyGenerator() {
        return readOnlyProxyGenerator;
    }

    public void setReadOnlyProxyGenerator(ReadOnlyProxyGenerator readOnlyProxyGenerator) {
        this.readOnlyProxyGenerator = readOnlyProxyGenerator;
    }

    @Transactional(readOnly = true)
    @Override
    public InOutLineState get(InOutLineId id)
    {
        return get(id, false);
    }

    @Transactional(readOnly = true)
    @Override
    public InOutLineState get(InOutLineId id, boolean nullAllowed)
    {
        InOutLineState state = (InOutLineState) getCurrentSession().get(AbstractInOutLineState.SimpleInOutLineState.class, id);
        if (!nullAllowed && state == null) {
            state = new AbstractInOutLineState.SimpleInOutLineState();
            state.setInOutLineId(id);
        }
        if (getReadOnlyProxyGenerator() != null && state != null) {
            return (InOutLineState) getReadOnlyProxyGenerator().createProxy(state, new Class[]{InOutLineState.class}, "getStateReadOnly", readOnlyPropertyPascalCaseNames);
        }
        return state;
    }

    @Override
    public void save(InOutLineState state)
    {
        InOutLineState s = state;
        if (getReadOnlyProxyGenerator() != null) {
            s = (InOutLineState) getReadOnlyProxyGenerator().getTarget(state);
        }
        if(s.getVersion() == null) {
            getCurrentSession().save(s);
        }else {
            getCurrentSession().update(s);
        }

        if (s instanceof Saveable)
        {
            Saveable saveable = (Saveable) s;
            saveable.save();
        }
    }

    @Transactional(readOnly = true)
    @Override
    public Iterable<InOutLineState> findByInOutDocumentNumber(String inOutDocumentNumber)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractInOutLineState.SimpleInOutLineState.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("inOutLineId.inOutDocumentNumber", inOutDocumentNumber))
            ;
        return criteria.add(partIdCondition).list();
    }

    @Override
    public void delete(InOutLineState state)
    {
        InOutLineState s = state;
        if (getReadOnlyProxyGenerator() != null) {
            s = (InOutLineState) getReadOnlyProxyGenerator().getTarget(state);
        }
        if (s instanceof Saveable)
        {
            Saveable saveable = (Saveable) s;
            saveable.save();
        }
        getCurrentSession().delete(s);
    }

}

