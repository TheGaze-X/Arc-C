using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200608E RID: 24718
	[Token(Token = "0x200608E")]
	public class CarvingMainShopGoodSlotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023BFE RID: 146430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BFE")]
		[Address(RVA = "0x1E64330", Offset = "0x1E62F30", VA = "0x181E64330")]
		public void Render(CarvingMainShopGoodSlotItemModel model, bool isEnough)
		{
		}

		// Token: 0x06023BFF RID: 146431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BFF")]
		[Address(RVA = "0x1E647A0", Offset = "0x1E633A0", VA = "0x181E647A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023C00 RID: 146432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C00")]
		[Address(RVA = "0x1E642A0", Offset = "0x1E62EA0", VA = "0x181E642A0")]
		public void OnClickSelectItemBtn()
		{
		}

		// Token: 0x06023C01 RID: 146433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C01")]
		[Address(RVA = "0x1E64950", Offset = "0x1E63550", VA = "0x181E64950")]
		public CarvingMainShopGoodSlotView()
		{
		}

		// Token: 0x040318E2 RID: 202978
		[Token(Token = "0x40318E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _notEnoughSelectTextColor;

		// Token: 0x040318E3 RID: 202979
		[Token(Token = "0x40318E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _notEnoughNotSelectTextColor;

		// Token: 0x040318E4 RID: 202980
		[Token(Token = "0x40318E4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _enoughSelectTextColor;

		// Token: 0x040318E5 RID: 202981
		[Token(Token = "0x40318E5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _enoughNotSelectTextColor;

		// Token: 0x040318E6 RID: 202982
		[Token(Token = "0x40318E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _priceTxt;

		// Token: 0x040318E7 RID: 202983
		[Token(Token = "0x40318E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _priceBgEnough;

		// Token: 0x040318E8 RID: 202984
		[Token(Token = "0x40318E8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _priceBgNotEnough;

		// Token: 0x040318E9 RID: 202985
		[Token(Token = "0x40318E9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _slotGroup;

		// Token: 0x040318EA RID: 202986
		[Token(Token = "0x40318EA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _unlockCntTxt;

		// Token: 0x040318EB RID: 202987
		[Token(Token = "0x40318EB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _selectAnimLocation;

		// Token: 0x040318EC RID: 202988
		[Token(Token = "0x40318EC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x040318ED RID: 202989
		[Token(Token = "0x40318ED")]
		[FieldOffset(Offset = "0x98")]
		private AnimationSwitchTween m_selectAnimSwitchTween;

		// Token: 0x040318EE RID: 202990
		[Token(Token = "0x40318EE")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x040318EF RID: 202991
		[Token(Token = "0x40318EF")]
		[FieldOffset(Offset = "0xA8")]
		private int m_buySeqNum;

		// Token: 0x040318F0 RID: 202992
		[Token(Token = "0x40318F0")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_isInited;

		// Token: 0x040318F1 RID: 202993
		[Token(Token = "0x40318F1")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040318F2 RID: 202994
		[Token(Token = "0x40318F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040318F3 RID: 202995
		[Token(Token = "0x40318F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040318F4 RID: 202996
		[Token(Token = "0x40318F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickSelectItemBtn;

		// Token: 0x040318F5 RID: 202997
		[Token(Token = "0x40318F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
