using System;
using System.Runtime.InteropServices;
using System.Security.Claims;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class GenericPrincipal : System.Security.Claims.ClaimsPrincipal
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x4B5EDF0", Offset = "0x4B5D9F0", VA = "0x184B5EDF0")]
		public GenericPrincipal(IIdentity identity, string[] roles)
		{
		}

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IIdentity m_identity;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] m_roles;
	}
}
