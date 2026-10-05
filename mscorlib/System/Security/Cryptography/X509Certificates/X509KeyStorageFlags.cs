using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000346 RID: 838
	[Token(Token = "0x2000346")]
	[System.Flags]
	public enum X509KeyStorageFlags
	{
		// Token: 0x04000EF2 RID: 3826
		[Token(Token = "0x4000EF2")]
		DefaultKeySet = 0,
		// Token: 0x04000EF3 RID: 3827
		[Token(Token = "0x4000EF3")]
		UserKeySet = 1,
		// Token: 0x04000EF4 RID: 3828
		[Token(Token = "0x4000EF4")]
		MachineKeySet = 2,
		// Token: 0x04000EF5 RID: 3829
		[Token(Token = "0x4000EF5")]
		Exportable = 4,
		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		UserProtected = 8,
		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		PersistKeySet = 16,
		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		EphemeralKeySet = 32
	}
}
