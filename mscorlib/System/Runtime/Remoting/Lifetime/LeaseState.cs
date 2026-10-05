using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public enum LeaseState
	{
		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		Null,
		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		Initial,
		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		Active,
		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		Renewing,
		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		Expired
	}
}
