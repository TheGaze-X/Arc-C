using System;
using Il2CppDummyDll;
using U8.SDK;

namespace HGSDK
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	public class U8PluginDefault : U8Plugin
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x103E090", Offset = "0x103CC90", VA = "0x18103E090")]
		public U8PluginDefault(HGSDK sdk, HGSDK.SDKOptions options)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x103E0F0", Offset = "0x103CCF0", VA = "0x18103E0F0", Slot = "21")]
		protected override void PayImplement(ExternalPluginPayParams pluginParam, Action<HGSDK.PayResult> callback)
		{
		}

		// Token: 0x020000F2 RID: 242
		[Token(Token = "0x20000F2")]
		private class PayRequest
		{
			// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayRequest()
			{
			}

			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			[FieldOffset(Offset = "0x10")]
			public string orderId;

			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40004B1")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			[FieldOffset(Offset = "0x20")]
			public int worldId;

			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			[FieldOffset(Offset = "0x24")]
			public int storeId;

			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			[FieldOffset(Offset = "0x28")]
			public string productId;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			[FieldOffset(Offset = "0x30")]
			public string productName;

			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40004B6")]
			[FieldOffset(Offset = "0x38")]
			public int amount;

			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			[FieldOffset(Offset = "0x40")]
			public string extraData;

			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			[FieldOffset(Offset = "0x48")]
			public long payTime;
		}

		// Token: 0x020000F3 RID: 243
		[Token(Token = "0x20000F3")]
		private class PayResponse
		{
			// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayResponse()
			{
			}

			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			[FieldOffset(Offset = "0x10")]
			public int result;
		}
	}
}
