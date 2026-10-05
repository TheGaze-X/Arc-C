using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu;

namespace HGSDK
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[Obsolete("Now full native iOS SDK has been applied and HGStoreKit would be legacy.")]
	public class HGStoreKit : Singleton<HGStoreKit>, IHotfixable
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x10343C0", Offset = "0x1032FC0", VA = "0x1810343C0")]
		private HGStoreKit()
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
		[Obsolete]
		public void InitIfNot(HGStoreKit.HGStoreKitHandler handler)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1034390", Offset = "0x1032F90", VA = "0x181034390")]
		private void _ErrorAndHalt(string errorInfo)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1034380", Offset = "0x1032F80", VA = "0x181034380")]
		private bool _CheckIfComponentValid()
		{
			return default(bool);
		}

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		private const int DEFAULT_PRODUCT_QUALITY = 1;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isInited;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x18")]
		private HGStoreKit.HGStoreKitHandler m_handler;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x20")]
		private HGStoreKit.HGStorePayRequest m_payRequest;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x28")]
		private List<HGStoreKit.RefreshReceiptCallback> m_refreshReceiptCallbacks;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isErrorHalted;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isFetchingProducts;

		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000E8")]
		public class RefreshReceiptCallback
		{
			// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RefreshReceiptCallback()
			{
			}

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[FieldOffset(Offset = "0x10")]
			public Action onSucceeded;

			// Token: 0x04000498 RID: 1176
			[Token(Token = "0x4000498")]
			[FieldOffset(Offset = "0x18")]
			public Action onFailed;
		}

		// Token: 0x020000E9 RID: 233
		[Token(Token = "0x20000E9")]
		public class HGStoreKitHandler
		{
			// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HGStoreKitHandler()
			{
			}

			// Token: 0x04000499 RID: 1177
			[Token(Token = "0x4000499")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> onError;
		}

		// Token: 0x020000EA RID: 234
		[Token(Token = "0x20000EA")]
		public class HGStorePayRequest
		{
			// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HGStorePayRequest()
			{
			}

			// Token: 0x0400049A RID: 1178
			[Token(Token = "0x400049A")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0400049B RID: 1179
			[Token(Token = "0x400049B")]
			[FieldOffset(Offset = "0x18")]
			public string orderId;

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			[FieldOffset(Offset = "0x20")]
			public string productId;

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[FieldOffset(Offset = "0x28")]
			public string transactionId;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0x30")]
			public HGStoreKit.HGStorePayHandler handler;
		}

		// Token: 0x020000EB RID: 235
		[Token(Token = "0x20000EB")]
		public class HGStorePayHandler
		{
			// Token: 0x060003BE RID: 958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HGStorePayHandler()
			{
			}

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			[FieldOffset(Offset = "0x10")]
			public Action onSucceeded;

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[FieldOffset(Offset = "0x18")]
			public Action onCancelled;

			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			[FieldOffset(Offset = "0x20")]
			public Action<string> onFailed;
		}
	}
}
