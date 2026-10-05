using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu;
using XLua;

namespace XDSDK
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class XDStoreKit : Singleton<XDStoreKit>, IHotfixable
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x51A010", Offset = "0x518C10", VA = "0x18051A010")]
		private XDStoreKit()
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x519EA0", Offset = "0x518AA0", VA = "0x180519EA0")]
		public void InitIfNot(XDStoreKit.XDStoreKitHandler handler)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x519F80", Offset = "0x518B80", VA = "0x180519F80")]
		private void _ErrorAndHalt(string errorInfo)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x519F20", Offset = "0x518B20", VA = "0x180519F20")]
		private bool _CheckIfComponentValid()
		{
			return default(bool);
		}

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		private const int DEFAULT_PRODUCT_QUALITY = 1;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isInited;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x18")]
		private XDStoreKit.XDStoreKitHandler m_handler;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x20")]
		private XDStoreKit.XDStorePayRequest m_payRequest;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x28")]
		private List<XDStoreKit.RefreshReceiptCallback> m_refreshReceiptCallbacks;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isErrorHalted;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isFetchingProducts;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ErrorAndHalt;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfComponentValid;

		// Token: 0x020000A5 RID: 165
		[Token(Token = "0x20000A5")]
		public class RefreshReceiptCallback
		{
			// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RefreshReceiptCallback()
			{
			}

			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0x10")]
			public Action onSucceeded;

			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			[FieldOffset(Offset = "0x18")]
			public Action onFailed;
		}

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		public class XDStoreKitHandler
		{
			// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public XDStoreKitHandler()
			{
			}

			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> onError;
		}

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		public class XDStorePayRequest
		{
			// Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public XDStorePayRequest()
			{
			}

			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			[FieldOffset(Offset = "0x18")]
			public string orderId;

			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			[FieldOffset(Offset = "0x20")]
			public string productId;

			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			[FieldOffset(Offset = "0x28")]
			public string transactionId;

			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			[FieldOffset(Offset = "0x30")]
			public XDStoreKit.XDStorePayHandler handler;
		}

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		public class XDStorePayHandler
		{
			// Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public XDStorePayHandler()
			{
			}

			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			[FieldOffset(Offset = "0x10")]
			public Action onSucceeded;

			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			[FieldOffset(Offset = "0x18")]
			public Action onCancelled;

			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			[FieldOffset(Offset = "0x20")]
			public Action<string> onFailed;
		}
	}
}
