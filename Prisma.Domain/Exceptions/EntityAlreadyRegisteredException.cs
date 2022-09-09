using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Exceptions
{

	[Serializable]
	public class EntityAlreadyRegisteredException : Exception
	{
		public EntityAlreadyRegisteredException() { }
		public EntityAlreadyRegisteredException(string message) : base(message) { }
		public EntityAlreadyRegisteredException(string message, Exception inner) : base(message, inner) { }
		protected EntityAlreadyRegisteredException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
