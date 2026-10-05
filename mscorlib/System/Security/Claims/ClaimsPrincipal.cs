using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using Il2CppDummyDll;

namespace System.Security.Claims
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ClaimsPrincipal : System.Security.Principal.IPrincipal
	{
		// Token: 0x06001C48 RID: 7240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x4B56DD0", Offset = "0x4B559D0", VA = "0x184B56DD0")]
		private static ClaimsIdentity SelectPrimaryIdentity(System.Collections.Generic.IEnumerable<ClaimsIdentity> identities)
		{
			return null;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000332")]
		public static System.Func<ClaimsPrincipal> ClaimsPrincipalSelector
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x4B57B30", Offset = "0x4B56730", VA = "0x184B57B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x4B57A80", Offset = "0x4B56680", VA = "0x184B57A80")]
		public ClaimsPrincipal()
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x4B57880", Offset = "0x4B56480", VA = "0x184B57880")]
		protected ClaimsPrincipal(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x4B56D70", Offset = "0x4B55970", VA = "0x184B56D70")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializingMethod(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x4B56D00", Offset = "0x4B55900", VA = "0x184B56D00")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x4B56BA0", Offset = "0x4B557A0", VA = "0x184B56BA0")]
		private void Deserialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x4B56690", Offset = "0x4B55290", VA = "0x184B56690")]
		private void DeserializeIdentities(string identities)
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x4B57090", Offset = "0x4B55C90", VA = "0x184B57090")]
		private string SerializeIdentities()
		{
			return null;
		}

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_version;

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_serializedClaimsIdentities;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private System.Collections.Generic.List<ClaimsIdentity> m_identities;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private static System.Func<System.Collections.Generic.IEnumerable<ClaimsIdentity>, ClaimsIdentity> s_identitySelector;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[System.NonSerialized]
		private static System.Func<ClaimsPrincipal> s_principalSelector;
	}
}
