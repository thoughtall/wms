package org.dddml.wms.domain;

import java.util.Date;


public class MonthPlanStateDto
{

    private Integer month;

    public Integer getMonth()
    {
        return this.month;
    }

    public void setMonth(Integer month)
    {
        this.month = month;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private PersonalNameDto personalName;

    public PersonalNameDto getPersonalName()
    {
        return this.personalName;
    }

    public void setPersonalName(PersonalNameDto personalName)
    {
        this.personalName = personalName;
    }

    private Integer year;

    public Integer getYear()
    {
        return this.year;
    }

    public void setYear(Integer year)
    {
        this.year = year;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private String updatedBy;

    public String getUpdatedBy()
    {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy)
    {
        this.updatedBy = updatedBy;
    }

    private Date updatedAt;

    public Date getUpdatedAt()
    {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt)
    {
        this.updatedAt = updatedAt;
    }


    private DayPlanStateDto[] dayPlans;

    public DayPlanStateDto[] getDayPlans()
    {
        return this.dayPlans;
    }	

    public void setDayPlans(DayPlanStateDto[] dayPlans)
    {
        this.dayPlans = dayPlans;
    }


}

