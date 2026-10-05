using System;
using System.Collections.Generic;
using System.Security.Claims;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	[System.Serializable]
	public class GenericIdentity : System.Security.Claims.ClaimsIdentity
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x4B5EBA0", Offset = "0x4B5D7A0", VA = "0x184B5EBA0")]
		public GenericIdentity(string name, string type)
		{
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x4B55960", Offset = "0x4B54560", VA = "0x184B55960")]
		private GenericIdentity()
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x4B5EB40", Offset = "0x4B5D740", VA = "0x184B5EB40")]
		protected GenericIdentity(GenericIdentity identity)
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x4B5EAB0", Offset = "0x4B5D6B0", VA = "0x184B5EAB0", Slot = "9")]
		public override System.Security.Claims.ClaimsIdentity Clone()
		{
			return null;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000320")]
		public override System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> Claims
		{
			[Token(Token = "0x6001BFD")]
			[Address(RVA = "0x4B564F0", Offset = "0x4B550F0", VA = "0x184B564F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000321")]
		public override string Name
		{
			[Token(Token = "0x6001BFE")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000322")]
		public override string AuthenticationType
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x4B5E960", Offset = "0x4B5D560", VA = "0x184B5E960")]
		private void AddNameClaim()
		{
		}

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x78")]
		private readonly string m_name;

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		[FieldOffset(Offset = "0x80")]
		private readonly string m_type;
	}
}
