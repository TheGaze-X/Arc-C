using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	public class LoginPlatformFactory
	{
		// Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x5CBC320", Offset = "0x5CBAF20", VA = "0x185CBC320")]
		public static string GetPlatformString(LoginPlatform loginPlatform)
		{
			return null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginPlatformFactory()
		{
		}

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<LoginPlatform, LoginPlatformHandler> handlerMap;
	}
}
