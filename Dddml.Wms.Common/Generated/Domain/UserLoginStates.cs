﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public class UserLoginStates : IUserLoginStates
    {
        
		protected IUserLoginStateDao UserLoginStateDao
		{
			get
			{
				return ApplicationContext.Current["UserLoginStateDao"] as IUserLoginStateDao;
			}
		}

		private Dictionary<UserLoginId, IUserLoginState> _loadedUserLoginStates = new Dictionary<UserLoginId, IUserLoginState>();

		private Dictionary<UserLoginId, IUserLoginState> _removedUserLoginStates = new Dictionary<UserLoginId, IUserLoginState>();

		protected virtual IEnumerable<IUserLoginState> LoadedUserLoginStates {
			get {
				return this._loadedUserLoginStates.Values;
			}
		}

        private IUserState _userState;

        private IEnumerable<IUserLoginState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return UserLoginStateDao.FindByUserId(_userState.UserId);
                }
                else
                {
                    return _loadedUserLoginStates.Values.Where(s => !(_removedUserLoginStates.ContainsKey(s.GlobalId) && s.Deleted));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public UserLoginStates(UserState outerState)
        {
            this._userState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<IUserLoginState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IUserLoginState state)
        {
            this._removedUserLoginStates.Add(state.GlobalId, state);
        }

        public virtual IUserLoginState Get(LoginKey loginKey)
		{
			return Get(loginKey, false);
		}

        public virtual IUserLoginState Get(LoginKey loginKey, bool forCreation)
		{
			UserLoginId globalId = new UserLoginId(_userState.UserId, loginKey);
            if (_loadedUserLoginStates.ContainsKey(globalId)) {
                return _loadedUserLoginStates[globalId];
            }
            if (forCreation || ForReapplying)
            {
                var state = new UserLoginState(ForReapplying);
                state.UserLoginId = globalId;
			    _loadedUserLoginStates.Add(globalId, state);
			    return state;
            }
            else
            {
                var state = UserLoginStateDao.Get(globalId);
			    _loadedUserLoginStates.Add(globalId, state);
			    return state;
            }
		}

        public virtual void AddToSave(IUserLoginState state)
        {
            this._loadedUserLoginStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IUserLoginState s in this.LoadedUserLoginStates) {
                UserLoginStateDao.Save(s);
			}
            foreach(IUserLoginState s in this._removedUserLoginStates.Values)
            {
                UserLoginStateDao.Delete(s);
            }
		}

		#endregion


    }



}


