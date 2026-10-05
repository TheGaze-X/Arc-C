using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B71 RID: 23409
	[Token(Token = "0x2005B71")]
	public class SocialShopRedPointTrackViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x06021FC7 RID: 139207 RVA: 0x000BC1F0 File Offset: 0x000BA3F0
		[Token(Token = "0x17004F9D")]
		public bool isShow
		{
			[Token(Token = "0x6021FC7")]
			[Address(RVA = "0x1C82930", Offset = "0x1C81530", VA = "0x181C82930", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06021FC8 RID: 139208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FC8")]
		[Address(RVA = "0x1C82820", Offset = "0x1C81420", VA = "0x181C82820", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06021FC9 RID: 139209 RVA: 0x000BC208 File Offset: 0x000BA408
		[Token(Token = "0x6021FC9")]
		[Address(RVA = "0x1C82780", Offset = "0x1C81380", VA = "0x181C82780")]
		public static bool CheckIfShowTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x06021FCA RID: 139210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FCA")]
		[Address(RVA = "0x1C828D0", Offset = "0x1C814D0", VA = "0x181C828D0")]
		public SocialShopRedPointTrackViewModel()
		{
		}

		// Token: 0x0402E94C RID: 190796
		[Token(Token = "0x402E94C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isSocialShopActive;

		// Token: 0x0402E94D RID: 190797
		[Token(Token = "0x402E94D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402E94E RID: 190798
		[Token(Token = "0x402E94E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402E94F RID: 190799
		[Token(Token = "0x402E94F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfShowTrackPoint;

		// Token: 0x0402E950 RID: 190800
		[Token(Token = "0x402E950")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
