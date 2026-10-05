using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YoStar.SDK.Util;

namespace YoStar.SDK.Component
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	public class SteamComponent : BaseComponent
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x5CBFA30", Offset = "0x5CBE630", VA = "0x185CBFA30")]
		public static void Auth(CallbackGlobal<Dictionary<string, object>> callback)
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x5CBFB30", Offset = "0x5CBE730", VA = "0x185CBFB30")]
		public static Dictionary<string, object> DealParam([Optional] Dictionary<string, object> thirdAuthInfo)
		{
			return null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SteamComponent()
		{
		}
	}
}
