﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;
using NodaMoney;

namespace Dddml.Wms.Domain.InOut
{

	public class InOutLineIdDtoWrapper : InOutLineIdDto
	{

        private InOutLineId _value = new InOutLineId();

		public InOutLineIdDtoWrapper()
		{
		}

		public InOutLineIdDtoWrapper(InOutLineId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override InOutLineId ToInOutLineId()
        {
            return this._value;
        }

		public override string InOutDocumentNumber { 
			get { return _value.InOutDocumentNumber; } 
			set { _value.InOutDocumentNumber = value; } 
		}

		public override long LineNumber { 
			get { return _value.LineNumber; } 
			set { _value.LineNumber = value; } 
		}


	}

}


