using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200608D RID: 24717
	[Token(Token = "0x200608D")]
	public class CarvingMainShopGoodCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023BFA RID: 146426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BFA")]
		[Address(RVA = "0x1E63C30", Offset = "0x1E62830", VA = "0x181E63C30")]
		public void Render(CarvingMainShopGoodCardItemModel model, bool isEnough)
		{
		}

		// Token: 0x06023BFB RID: 146427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BFB")]
		[Address(RVA = "0x1E64060", Offset = "0x1E62C60", VA = "0x181E64060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023BFC RID: 146428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BFC")]
		[Address(RVA = "0x1E63B50", Offset = "0x1E62750", VA = "0x181E63B50")]
		public void OnClickSelectItemBtn()
		{
		}

		// Token: 0x06023BFD RID: 146429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BFD")]
		[Address(RVA = "0x1E64210", Offset = "0x1E62E10", VA = "0x181E64210")]
		public CarvingMainShopGoodCardView()
		{
		}

		// Token: 0x040318CC RID: 202956
		[Token(Token = "0x40318CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _notEnoughSelectTextColor;

		// Token: 0x040318CD RID: 202957
		[Token(Token = "0x40318CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _notEnoughNotSelectTextColor;

		// Token: 0x040318CE RID: 202958
		[Token(Token = "0x40318CE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _enoughSelectTextColor;

		// Token: 0x040318CF RID: 202959
		[Token(Token = "0x40318CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _enoughNotSelectTextColor;

		// Token: 0x040318D0 RID: 202960
		[Token(Token = "0x40318D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _priceTxt;

		// Token: 0x040318D1 RID: 202961
		[Token(Token = "0x40318D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _priceBgEnough;

		// Token: 0x040318D2 RID: 202962
		[Token(Token = "0x40318D2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _priceBgNotEnough;

		// Token: 0x040318D3 RID: 202963
		[Token(Token = "0x40318D3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _cardGroup;

		// Token: 0x040318D4 RID: 202964
		[Token(Token = "0x40318D4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _cardContent;

		// Token: 0x040318D5 RID: 202965
		[Token(Token = "0x40318D5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CarvingMainCardView _cardViewPrefab;

		// Token: 0x040318D6 RID: 202966
		[Token(Token = "0x40318D6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _cardScaler;

		// Token: 0x040318D7 RID: 202967
		[Token(Token = "0x40318D7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040318D8 RID: 202968
		[Token(Token = "0x40318D8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x040318D9 RID: 202969
		[Token(Token = "0x40318D9")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x040318DA RID: 202970
		[Token(Token = "0x40318DA")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040318DB RID: 202971
		[Token(Token = "0x40318DB")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedPos;

		// Token: 0x040318DC RID: 202972
		[Token(Token = "0x40318DC")]
		[FieldOffset(Offset = "0xC0")]
		private CarvingMainCardView m_cardView;

		// Token: 0x040318DD RID: 202973
		[Token(Token = "0x40318DD")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x040318DE RID: 202974
		[Token(Token = "0x40318DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040318DF RID: 202975
		[Token(Token = "0x40318DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040318E0 RID: 202976
		[Token(Token = "0x40318E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickSelectItemBtn;

		// Token: 0x040318E1 RID: 202977
		[Token(Token = "0x40318E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
