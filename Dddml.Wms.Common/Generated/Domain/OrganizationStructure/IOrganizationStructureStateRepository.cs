﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructure;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrganizationStructure
{
	public partial interface IOrganizationStructureStateRepository
	{

        IOrganizationStructureState Get(OrganizationStructureId id, bool nullAllowed);
        
        void Save(IOrganizationStructureState state);
        
	}

}

