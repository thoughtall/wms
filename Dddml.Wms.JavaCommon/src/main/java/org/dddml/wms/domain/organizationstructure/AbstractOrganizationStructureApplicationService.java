package org.dddml.wms.domain.organizationstructure;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import org.dddml.wms.domain.*;
import java.util.Date;
import org.dddml.wms.specialization.*;

public abstract class AbstractOrganizationStructureApplicationService implements OrganizationStructureApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private OrganizationStructureStateRepository stateRepository;

    protected OrganizationStructureStateRepository getStateRepository() {
        return stateRepository;
    }

    private OrganizationStructureStateQueryRepository stateQueryRepository;

    protected OrganizationStructureStateQueryRepository getStateQueryRepository() {
        return stateQueryRepository;
    }

    public AbstractOrganizationStructureApplicationService(EventStore eventStore, OrganizationStructureStateRepository stateRepository, OrganizationStructureStateQueryRepository stateQueryRepository) {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
        this.stateQueryRepository = stateQueryRepository;
    }

    public void when(OrganizationStructureCommand.CreateOrganizationStructure c) {
        update(c, ar -> ar.create(c));
    }

    public void when(OrganizationStructureCommand.MergePatchOrganizationStructure c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(OrganizationStructureCommand.DeleteOrganizationStructure c) {
        update(c, ar -> ar.delete(c));
    }

    public OrganizationStructureState get(OrganizationStructureId id) {
        OrganizationStructureState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<OrganizationStructureState> getAll(Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getAll(firstResult, maxResults);
    }

    public Iterable<OrganizationStructureState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<OrganizationStructureState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<OrganizationStructureState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public OrganizationStructureStateEvent getStateEvent(OrganizationStructureId id, long version) {
        OrganizationStructureStateEvent e = (OrganizationStructureStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(id), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(id, 0);
        }
        return e;
    }

    public OrganizationStructureState getHistoryState(OrganizationStructureId id, long version) {
        EventStream eventStream = getEventStore().loadEventStream(AbstractOrganizationStructureStateEvent.class, toEventStoreAggregateId(id), version - 1);
        return new AbstractOrganizationStructureState.SimpleOrganizationStructureState(eventStream.getEvents());
    }


    public OrganizationStructureAggregate getOrganizationStructureAggregate(OrganizationStructureState state)
    {
        return new AbstractOrganizationStructureAggregate.SimpleOrganizationStructureAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(OrganizationStructureId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(OrganizationStructureCommand c, Consumer<OrganizationStructureAggregate> action)
    {
        OrganizationStructureId aggregateId = c.getId();
        OrganizationStructureState state = getStateRepository().get(aggregateId, false);
        OrganizationStructureAggregate aggregate = getOrganizationStructureAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });

    }

    protected boolean isRepeatedCommand(OrganizationStructureCommand command, EventStoreAggregateId eventStoreAggregateId, OrganizationStructureState state)
    {
        boolean repeated = false;
        if (command.getVersion() == null) { command.setVersion(OrganizationStructureState.VERSION_NULL); }
        if (state.getVersion() != null && state.getVersion() > command.getVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractOrganizationStructureStateEvent.class, eventStoreAggregateId, command.getVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleOrganizationStructureApplicationService extends AbstractOrganizationStructureApplicationService 
    {
        public SimpleOrganizationStructureApplicationService(EventStore eventStore, OrganizationStructureStateRepository stateRepository, OrganizationStructureStateQueryRepository stateQueryRepository)
        {
            super(eventStore, stateRepository, stateQueryRepository);
        }
    }

}

