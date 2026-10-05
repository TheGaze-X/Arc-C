using System;
using Il2CppDummyDll;
using U8.SDK;

namespace YostarSDKV2
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public class YostarSDKV2MockPlugin : YostarSDKV2Plugin
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x51B7B0", Offset = "0x51A3B0", VA = "0x18051B7B0")]
		public YostarSDKV2MockPlugin(YostarSDKV2 sdk)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x51B110", Offset = "0x519D10", VA = "0x18051B110", Slot = "17")]
		public override void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x51B390", Offset = "0x519F90", VA = "0x18051B390", Slot = "18")]
		public override void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x51B370", Offset = "0x519F70", VA = "0x18051B370", Slot = "19")]
		public override void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		private class PayRequest
		{
			// Token: 0x0600025F RID: 607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayRequest()
			{
			}

			// Token: 0x040002D0 RID: 720
			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x10")]
			public string orderId;

			// Token: 0x040002D1 RID: 721
			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x040002D2 RID: 722
			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x20")]
			public int worldId;

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x24")]
			public int storeId;

			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x28")]
			public string productId;

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x30")]
			public string productName;

			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x38")]
			public int amount;

			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			[FieldOffset(Offset = "0x40")]
			public string extraData;

			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			[FieldOffset(Offset = "0x48")]
			public long payTime;
		}

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		private class PayResponse
		{
			// Token: 0x06000260 RID: 608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayResponse()
			{
			}

			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			[FieldOffset(Offset = "0x10")]
			public int result;
		}
	}
}
