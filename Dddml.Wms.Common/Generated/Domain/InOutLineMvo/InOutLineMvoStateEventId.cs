﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using NodaMoney;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

	public class InOutLineMvoStateEventId
	{

		private InOutLineId _inOutLineId = new InOutLineId();

		public virtual InOutLineId InOutLineId { 
			get { return this._inOutLineId; } 
			internal set { _inOutLineId = value; } 
		}

		private long _inOutVersion;

		public virtual long InOutVersion { 
			get { return this._inOutVersion; } 
			internal set { _inOutVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string InOutLineIdInOutDocumentNumber {
			get { return InOutLineId.InOutDocumentNumber; }
			internal set { InOutLineId.InOutDocumentNumber = value; }
		}

		public virtual long InOutLineIdLineNumber {
			get { return InOutLineId.LineNumber; }
			internal set { InOutLineId.LineNumber = value; }
		}

        #endregion

		internal InOutLineMvoStateEventId ()
		{
		}

		public InOutLineMvoStateEventId (InOutLineId inOutLineId, long inOutVersion)
		{
			this._inOutLineId = inOutLineId;
			this._inOutVersion = inOutVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InOutLineMvoStateEventId other = obj as InOutLineMvoStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InOutLineId, other.InOutLineId)
				&& Object.Equals (this.InOutVersion, other.InOutVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InOutLineId != null) {
				hash += 13 * this.InOutLineId.GetHashCode ();
			}
			if (this.InOutVersion != null) {
				hash += 13 * this.InOutVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InOutLineMvoStateEventId obj1, InOutLineMvoStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InOutLineMvoStateEventId obj1, InOutLineMvoStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


