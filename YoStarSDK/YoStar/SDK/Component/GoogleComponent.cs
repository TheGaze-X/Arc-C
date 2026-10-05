using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YoStar.SDK.Util;

namespace YoStar.SDK.Component
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	public class GoogleComponent : BaseComponent
	{
		// Token: 0x06000E95 RID: 3733 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x5CA0330", Offset = "0x5C9EF30", VA = "0x185CA0330")]
		public static void Link(CallbackGlobal<LinkRet> callback)
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x5CA03F0", Offset = "0x5C9EFF0", VA = "0x185CA03F0")]
		public static void Unlink(CallbackGlobal<UnLinkRet> callback)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void Login()
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x5C9FFA0", Offset = "0x5C9EBA0", VA = "0x185C9FFA0")]
		private static void Auth(CallbackGlobal<ThirdAuthRet> callbackGlobal)
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x5CA00A0", Offset = "0x5C9ECA0", VA = "0x185CA00A0")]
		private static Dictionary<string, object> DealParamData(Dictionary<string, object> thirdAuthInfo)
		{
			return null;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GoogleComponent()
		{
		}
	}
}
