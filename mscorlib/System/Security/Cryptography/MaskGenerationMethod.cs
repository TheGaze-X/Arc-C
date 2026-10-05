using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class MaskGenerationMethod
	{
		// Token: 0x06001986 RID: 6534
		[Token(Token = "0x6001986")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public abstract byte[] GenerateMask(byte[] rgbSeed, int cbReturn);

		// Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MaskGenerationMethod()
		{
		}
	}
}
