using System;
using Il2CppDummyDll;

namespace UDatasdk
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	internal class BaseRet
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BaseRet()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		public CommonRet commonRet;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		public string ts;
	}
}
