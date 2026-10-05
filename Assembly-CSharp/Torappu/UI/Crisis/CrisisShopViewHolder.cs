using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A12 RID: 23058
	[Token(Token = "0x2005A12")]
	public class CrisisShopViewHolder : DataBinder<CrisisShopInfoProperty>
	{
		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x06021979 RID: 137593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EE7")]
		public ScrollRect scrollRect
		{
			[Token(Token = "0x6021979")]
			[Address(RVA = "0x1C0C0A0", Offset = "0x1C0ACA0", VA = "0x181C0C0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x0602197A RID: 137594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EE8")]
		public CanvasGroup canvasGroup
		{
			[Token(Token = "0x602197A")]
			[Address(RVA = "0x1C0C040", Offset = "0x1C0AC40", VA = "0x181C0C040")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602197B RID: 137595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602197B")]
		[Address(RVA = "0x1C0BC00", Offset = "0x1C0A800", VA = "0x181C0BC00", Slot = "7")]
		public override void OnValueChanged(CrisisShopInfoProperty property)
		{
		}

		// Token: 0x0602197C RID: 137596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602197C")]
		[Address(RVA = "0x1C0BFD0", Offset = "0x1C0ABD0", VA = "0x181C0BFD0")]
		public CrisisShopViewHolder()
		{
		}

		// Token: 0x0402DEA2 RID: 188066
		[Token(Token = "0x402DEA2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisLongTermShopView _longTermView;

		// Token: 0x0402DEA3 RID: 188067
		[Token(Token = "0x402DEA3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrisisSeasonShopView _seasonView;

		// Token: 0x0402DEA4 RID: 188068
		[Token(Token = "0x402DEA4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _shopTitle;

		// Token: 0x0402DEA5 RID: 188069
		[Token(Token = "0x402DEA5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402DEA6 RID: 188070
		[Token(Token = "0x402DEA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402DEA7 RID: 188071
		[Token(Token = "0x402DEA7")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public CrisisShopEvent clickEvent;

		// Token: 0x0402DEA8 RID: 188072
		[Token(Token = "0x402DEA8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _crisisV1Title;

		// Token: 0x0402DEA9 RID: 188073
		[Token(Token = "0x402DEA9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _crisisV2Title;

		// Token: 0x0402DEAA RID: 188074
		[Token(Token = "0x402DEAA")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_finder;

		// Token: 0x0402DEAB RID: 188075
		[Token(Token = "0x402DEAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scrollRect;

		// Token: 0x0402DEAC RID: 188076
		[Token(Token = "0x402DEAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0402DEAD RID: 188077
		[Token(Token = "0x402DEAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DEAE RID: 188078
		[Token(Token = "0x402DEAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
