using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security.Authentication.ExtendedProtection
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[MonoTODO]
	[TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
	[Serializable]
	public class ExtendedProtectionPolicy : ISerializable
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		[MonoTODO("Not implemented.")]
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x5107C90", Offset = "0x5106890", VA = "0x185107C90")]
		protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00", Slot = "3")]
		[MonoTODO]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x5107C40", Offset = "0x5106840", VA = "0x185107C40", Slot = "4")]
		private void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
