using System;
using Il2CppDummyDll;
using U8.SDK;

namespace XDSDK
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public class U8PluginDefault : U8Plugin
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x513DF0", Offset = "0x5129F0", VA = "0x180513DF0")]
		public U8PluginDefault(XDSDK sdk, XDSDK.SDKOptions options)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x513E50", Offset = "0x512A50", VA = "0x180513E50", Slot = "21")]
		protected override void PayImplement(ExternalPluginPayParams pluginParam, Action<XDSDK.PayResult> callback)
		{
		}

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		private class PayRequest
		{
			// Token: 0x06000308 RID: 776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayRequest()
			{
			}

			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x10")]
			public string orderId;

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[FieldOffset(Offset = "0x20")]
			public int worldId;

			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			[FieldOffset(Offset = "0x24")]
			public int storeId;

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x28")]
			public string productId;

			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			[FieldOffset(Offset = "0x30")]
			public string productName;

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			[FieldOffset(Offset = "0x38")]
			public int amount;

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x40")]
			public string extraData;

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x48")]
			public long payTime;
		}

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		private class PayResponse
		{
			// Token: 0x06000309 RID: 777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayResponse()
			{
			}

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x10")]
			public int result;
		}
	}
}
