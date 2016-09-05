package org.dddml.wms.domain;

import java.util.Set;
import java.util.Date;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.YearPlanMvoStateEvent.*;

public interface YearPlanMvoState
{
    Long VERSION_ZERO = 0L;

    Long VERSION_NULL = VERSION_ZERO - 1;

    YearPlanId getYearPlanId();

    void setYearPlanId(YearPlanId yearPlanId);

    String getDescription();

    void setDescription(String description);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    String getUpdatedBy();

    void setUpdatedBy(String updatedBy);

    Long getVersion();

    void setVersion(Long version);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    Date getUpdatedAt();

    void setUpdatedAt(Date updatedAt);

    Boolean getActive();

    void setActive(Boolean active);

    Boolean getDeleted();

    void setDeleted(Boolean deleted);

    Date getPersonBirthDate();

    void setPersonBirthDate(Date personBirthDate);

    PersonalName getPersonLoves();

    void setPersonLoves(PersonalName personLoves);

    Contact getPersonEmergencyContact();

    void setPersonEmergencyContact(Contact personEmergencyContact);

    String getPersonCreatedBy();

    void setPersonCreatedBy(String personCreatedBy);

    String getPersonUpdatedBy();

    void setPersonUpdatedBy(String personUpdatedBy);

    Long getPersonVersion();

    void setPersonVersion(Long personVersion);

    Date getPersonCreatedAt();

    void setPersonCreatedAt(Date personCreatedAt);

    Date getPersonUpdatedAt();

    void setPersonUpdatedAt(Date personUpdatedAt);

    Boolean getPersonActive();

    void setPersonActive(Boolean personActive);

    Boolean getPersonDeleted();

    void setPersonDeleted(Boolean personDeleted);


    boolean isStateUnsaved();


    void mutate(Event e);

    void when(YearPlanMvoStateCreated e);

    void when(YearPlanMvoStateMergePatched e);

    void when(YearPlanMvoStateDeleted e);
    
}
