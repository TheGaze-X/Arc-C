using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public static class SteamVideo
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x4F18D90", Offset = "0x4F17990", VA = "0x184F18D90")]
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00007D54 File Offset: 0x00005F54
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x4F18E50", Offset = "0x4F17A50", VA = "0x184F18E50")]
		public static bool IsBroadcasting(out int pnNumViewers)
		{
			return default(bool);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4F18B60", Offset = "0x4F17760", VA = "0x184F18B60")]
		public static void GetOPFSettings(AppId_t unVideoAppID)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00007D6C File Offset: 0x00005F6C
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4F18C20", Offset = "0x4F17820", VA = "0x184F18C20")]
		public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			return default(bool);
		}
	}
}
