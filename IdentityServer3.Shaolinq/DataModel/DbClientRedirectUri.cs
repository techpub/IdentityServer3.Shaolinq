using System;
using IdentityServer3.Core.Models;
using Platform.Validation;
using Shaolinq;

namespace IdentityServer3.Shaolinq.DataModel
{
	[DataAccessObject(Name = "ClientRedirectUri")]
	public abstract class DbClientRedirectUri : DataAccessObject<Guid>
	{
		[PersistedMember]
		[ValueRequired]
		[SizeConstraint(MaximumLength = 2000)]
		public abstract string Uri { get; set; }

		[BackReference]
		public abstract DbClient Client { get; set; }
	}
}