using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Assets.AiriSDK.API.Source.Steam.pay
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	internal class SteamTimeoutHelper
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5BE3310", Offset = "0x5BE1F10", VA = "0x185BE3310")]
		private SteamTimeoutHelper()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5BE2C60", Offset = "0x5BE1860", VA = "0x185BE2C60")]
		public static SteamTimeoutHelper Instance()
		{
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5BE31A0", Offset = "0x5BE1DA0", VA = "0x185BE31A0")]
		public void StartTimeout(int seconds, Action action)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5BE2E80", Offset = "0x5BE1A80", VA = "0x185BE2E80")]
		public void StartPurchaseWithTimeout(string orderId, string strExtraData, Dictionary<string, object> eventParams, SteamPayResponse<Dictionary<string, object>> callBack)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5BE2A20", Offset = "0x5BE1620", VA = "0x185BE2A20")]
		public bool CompletePurchase(string orderId, out string extraData, out Dictionary<string, object> eventParams)
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5BE33A0", Offset = "0x5BE1FA0", VA = "0x185BE33A0")]
		private void logPurchaseTasks(string str)
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object lockObj;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		private static SteamTimeoutHelper m_Instance;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, PurchaseTask> purchaseTasks;
	}
}
