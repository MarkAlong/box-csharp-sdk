﻿using BoxSync.Core.Statuses;

namespace BoxSync.Core.Primitives
{
	/// <summary>
	/// Represents response from 'AuthenticateUser' method
	/// </summary>
	public sealed class AuthenticateUserResponse : ResponseBase<AuthenticationStatus>
	{
		/// <summary>
		/// Authenticated user information
		/// </summary>
		public User AuthenticatedUser
		{
			get;
			internal set;
		}

		/// <summary>
		/// The authentication token used to access and apply operations to a user's account.
		/// </summary>
		public string Token
		{
			get; 
			internal set;
		}
	}
}
