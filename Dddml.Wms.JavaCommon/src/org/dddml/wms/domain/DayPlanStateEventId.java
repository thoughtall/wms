package org.dddml.wms.domain;

import java.io.Serializable;

public class DayPlanStateEventId implements Serializable
{
    private PersonalName personalName = new PersonalName();

    public PersonalName getPersonalName()
    {
        return this.personalName;
    }

    public void setPersonalName(PersonalName personalName)
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

    private Integer month;

    public Integer getMonth()
    {
        return this.month;
    }

    public void setMonth(Integer month)
    {
        this.month = month;
    }

    private Integer day;

    public Integer getDay()
    {
        return this.day;
    }

    public void setDay(Integer day)
    {
        this.day = day;
    }

    private Long personVersion;

    public Long getPersonVersion()
    {
        return this.personVersion;
    }

    public void setPersonVersion(Long personVersion)
    {
        this.personVersion = personVersion;
    }

    public String getPersonalNameFirstName()
    {
        return getPersonalName().getFirstName();
    }

    public void setPersonalNameFirstName(String personalNameFirstName)
    {
        getPersonalName().setFirstName(personalNameFirstName);
    }

    public String getPersonalNameLastName()
    {
        return getPersonalName().getLastName();
    }

    public void setPersonalNameLastName(String personalNameLastName)
    {
        getPersonalName().setLastName(personalNameLastName);
    }

    public DayPlanStateEventId()
    {
    }

    public DayPlanStateEventId(PersonalName personalName, Integer year, Integer month, Integer day, Long personVersion)
    {
        this.personalName = personalName;
        this.year = year;
        this.month = month;
        this.day = day;
        this.personVersion = personVersion;
    }

    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }

        DayPlanStateEventId other = (DayPlanStateEventId)obj;
        return true 
            && (personalName == other.personalName || (personalName != null && personalName.equals(other.personalName)))
            && (year == other.year || (year != null && year.equals(other.year)))
            && (month == other.month || (month != null && month.equals(other.month)))
            && (day == other.day || (day != null && day.equals(other.day)))
            && (personVersion == other.personVersion || (personVersion != null && personVersion.equals(other.personVersion)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.personalName != null) {
            hash += 13 * this.personalName.hashCode();
        }
        if (this.year != null) {
            hash += 13 * this.year.hashCode();
        }
        if (this.month != null) {
            hash += 13 * this.month.hashCode();
        }
        if (this.day != null) {
            hash += 13 * this.day.hashCode();
        }
        if (this.personVersion != null) {
            hash += 13 * this.personVersion.hashCode();
        }
        return hash;
    }

}

