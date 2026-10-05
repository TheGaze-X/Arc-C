using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Flags]
	[System.Serializable]
	public enum CspProviderFlags
	{
		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		NoFlags = 0,
		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		UseMachineKeyStore = 1,
		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		UseDefaultKeyContainer = 2,
		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		UseNonExportableKey = 4,
		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		UseExistingKey = 8,
		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		UseArchivableKey = 16,
		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		UseUserProtectedKey = 32,
		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		NoPrompt = 64,
		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000DBE")]
		CreateEphemeralKey = 128
	}
}
