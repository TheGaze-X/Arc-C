using System;
using System.Collections;
using Il2CppDummyDll;
using U8.SDK;

namespace HGSDK.V2
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public class HGSDKPluginV2Mock : HGSDKPluginV2
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1028DC0", Offset = "0x10279C0", VA = "0x181028DC0")]
		public HGSDKPluginV2Mock(HGSDKV2 sdk)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1028740", Offset = "0x1027340", VA = "0x181028740", Slot = "17")]
		public override void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1028880", Offset = "0x1027480", VA = "0x181028880", Slot = "18")]
		public override void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1028C80", Offset = "0x1027880", VA = "0x181028C80", Slot = "19")]
		public override void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1028D10", Offset = "0x1027910", VA = "0x181028D10")]
		private IEnumerator _MockLoginCoroutine(ExternalPluginLoginParams args)
		{
			return null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x10288A0", Offset = "0x10274A0", VA = "0x1810288A0")]
		public static void MockPayImpl(ExternalPluginPayParams args)
		{
		}

		// Token: 0x0200016D RID: 365
		[Token(Token = "0x200016D")]
		private class PayRequest
		{
			// Token: 0x060005A6 RID: 1446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayRequest()
			{
			}

			// Token: 0x04000740 RID: 1856
			[Token(Token = "0x4000740")]
			[FieldOffset(Offset = "0x10")]
			public string orderId;

			// Token: 0x04000741 RID: 1857
			[Token(Token = "0x4000741")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04000742 RID: 1858
			[Token(Token = "0x4000742")]
			[FieldOffset(Offset = "0x20")]
			public int worldId;

			// Token: 0x04000743 RID: 1859
			[Token(Token = "0x4000743")]
			[FieldOffset(Offset = "0x24")]
			public int storeId;

			// Token: 0x04000744 RID: 1860
			[Token(Token = "0x4000744")]
			[FieldOffset(Offset = "0x28")]
			public string productId;

			// Token: 0x04000745 RID: 1861
			[Token(Token = "0x4000745")]
			[FieldOffset(Offset = "0x30")]
			public string productName;

			// Token: 0x04000746 RID: 1862
			[Token(Token = "0x4000746")]
			[FieldOffset(Offset = "0x38")]
			public int amount;

			// Token: 0x04000747 RID: 1863
			[Token(Token = "0x4000747")]
			[FieldOffset(Offset = "0x40")]
			public string extraData;

			// Token: 0x04000748 RID: 1864
			[Token(Token = "0x4000748")]
			[FieldOffset(Offset = "0x48")]
			public long payTime;
		}

		// Token: 0x0200016E RID: 366
		[Token(Token = "0x200016E")]
		private class PayResponse
		{
			// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PayResponse()
			{
			}

			// Token: 0x04000749 RID: 1865
			[Token(Token = "0x4000749")]
			[FieldOffset(Offset = "0x10")]
			public int result;
		}
	}
}
