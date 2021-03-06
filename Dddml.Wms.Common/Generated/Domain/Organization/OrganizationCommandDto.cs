﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Organization;

namespace Dddml.Wms.Domain.Organization
{

	public abstract class OrganizationCommandDtoBase : ICommandDto, ICreateOrganization, IMergePatchOrganization, IDeleteOrganization
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteOrganization)this).OrganizationId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string OrganizationId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual string Type { get; set; }

		public virtual bool? IsSummary { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchOrganization.IsPropertyNameRemoved
        {
            get
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchOrganization.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyTypeRemoved { get; set; }

        bool IMergePatchOrganization.IsPropertyTypeRemoved
        {
            get
            {
                var b = this.IsPropertyTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsSummaryRemoved { get; set; }

        bool IMergePatchOrganization.IsPropertyIsSummaryRemoved
        {
            get
            {
                var b = this.IsPropertyIsSummaryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsSummaryRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchOrganization.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteOrganizationDto : OrganizationCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateOrganizationDto : CreateOrMergePatchOrDeleteOrganizationDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchOrganizationDto : CreateOrMergePatchOrDeleteOrganizationDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteOrganizationDto : CreateOrMergePatchOrDeleteOrganizationDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class OrganizationCommandDtos
    {

    }

}

