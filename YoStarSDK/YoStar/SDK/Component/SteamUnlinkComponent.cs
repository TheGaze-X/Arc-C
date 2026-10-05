using System;
using Il2CppDummyDll;
using YoStar.SDK.Util;

namespace YoStar.SDK.Component
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	public class SteamUnlinkComponent : SteamComponent
	{
		// Token: 0x06000FA8 RID: 4008 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x5CC1520", Offset = "0x5CC0120", VA = "0x185CC1520")]
		public static void Unlink(CallbackGlobal<UnLinkRet> callback)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SteamUnlinkComponent()
		{
		}
	}
}
