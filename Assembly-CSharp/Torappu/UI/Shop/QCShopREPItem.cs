using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B1A RID: 23322
	[Token(Token = "0x2005B1A")]
	public class QCShopREPItem : QCBaseGoodItem, IHotfixable
	{
		// Token: 0x06021DF9 RID: 138745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DF9")]
		[Address(RVA = "0x1C5E750", Offset = "0x1C5D350", VA = "0x181C5E750")]
		public void ApplyNormalData(QCShopREPGood good, SpriteHub hub)
		{
		}

		// Token: 0x06021DFA RID: 138746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DFA")]
		[Address(RVA = "0x1C5E9A0", Offset = "0x1C5D5A0", VA = "0x181C5E9A0")]
		public void TryOpenDetail()
		{
		}

		// Token: 0x06021DFB RID: 138747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DFB")]
		[Address(RVA = "0x1C5E8F0", Offset = "0x1C5D4F0", VA = "0x181C5E8F0")]
		public void OnClick()
		{
		}

		// Token: 0x06021DFC RID: 138748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DFC")]
		[Address(RVA = "0x1C5EA00", Offset = "0x1C5D600", VA = "0x181C5EA00")]
		public QCShopREPItem()
		{
		}

		// Token: 0x0402E68C RID: 190092
		[Token(Token = "0x402E68C")]
		[FieldOffset(Offset = "0xA8")]
		private QCShopREPGood m_cacheGood;

		// Token: 0x0402E68D RID: 190093
		[Token(Token = "0x402E68D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyNormalData;

		// Token: 0x0402E68E RID: 190094
		[Token(Token = "0x402E68E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryOpenDetail;

		// Token: 0x0402E68F RID: 190095
		[Token(Token = "0x402E68F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E690 RID: 190096
		[Token(Token = "0x402E690")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
