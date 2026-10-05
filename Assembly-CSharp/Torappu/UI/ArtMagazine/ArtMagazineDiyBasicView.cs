using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006564 RID: 25956
	[Token(Token = "0x2006564")]
	public class ArtMagazineDiyBasicView : DataBinder<ArtMagazineDiyHomeProperty>
	{
		// Token: 0x06025536 RID: 152886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025536")]
		[Address(RVA = "0x2042080", Offset = "0x2040C80", VA = "0x182042080", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyHomeProperty property)
		{
		}

		// Token: 0x06025537 RID: 152887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025537")]
		[Address(RVA = "0x2042460", Offset = "0x2041060", VA = "0x182042460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025538 RID: 152888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025538")]
		[Address(RVA = "0x2041FA0", Offset = "0x2040BA0", VA = "0x182041FA0")]
		public void OnUnselectTypeClick()
		{
		}

		// Token: 0x06025539 RID: 152889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025539")]
		[Address(RVA = "0x2042720", Offset = "0x2041320", VA = "0x182042720")]
		public ArtMagazineDiyBasicView()
		{
		}

		// Token: 0x040345D0 RID: 214480
		[Token(Token = "0x40345D0")]
		private const string SKIN_NAME_FORMAT = "<b>{0}</b>/{1}";

		// Token: 0x040345D1 RID: 214481
		[Token(Token = "0x40345D1")]
		private const string LEAF_TYPE_FORMAT = "//.{0}";

		// Token: 0x040345D2 RID: 214482
		[Token(Token = "0x40345D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _sizeSwitchAnim;

		// Token: 0x040345D3 RID: 214483
		[Token(Token = "0x40345D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _pitchHintCanvasGroup;

		// Token: 0x040345D4 RID: 214484
		[Token(Token = "0x40345D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _editingItemCanvasGroup;

		// Token: 0x040345D5 RID: 214485
		[Token(Token = "0x40345D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _editingItemName;

		// Token: 0x040345D6 RID: 214486
		[Token(Token = "0x40345D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _editingItemDesc;

		// Token: 0x040345D7 RID: 214487
		[Token(Token = "0x40345D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _commonFadeDuration;

		// Token: 0x040345D8 RID: 214488
		[Token(Token = "0x40345D8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _leafViewHolder;

		// Token: 0x040345D9 RID: 214489
		[Token(Token = "0x40345D9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _topDragAndPinchView;

		// Token: 0x040345DA RID: 214490
		[Token(Token = "0x40345DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _rightPanelShadowCanvasGroup;

		// Token: 0x040345DB RID: 214491
		[Token(Token = "0x40345DB")]
		[FieldOffset(Offset = "0x70")]
		private int m_enterSeqNum;

		// Token: 0x040345DC RID: 214492
		[Token(Token = "0x40345DC")]
		[FieldOffset(Offset = "0x74")]
		private bool m_hasInited;

		// Token: 0x040345DD RID: 214493
		[Token(Token = "0x40345DD")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_switchTween;

		// Token: 0x040345DE RID: 214494
		[Token(Token = "0x40345DE")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_pinchHintSwitchTween;

		// Token: 0x040345DF RID: 214495
		[Token(Token = "0x40345DF")]
		[FieldOffset(Offset = "0x88")]
		private UISwitchTween m_editingItemSwitchTween;

		// Token: 0x040345E0 RID: 214496
		[Token(Token = "0x40345E0")]
		[FieldOffset(Offset = "0x90")]
		private UISwitchTween m_rightPanelShadowSwitchTween;

		// Token: 0x040345E1 RID: 214497
		[Token(Token = "0x40345E1")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040345E2 RID: 214498
		[Token(Token = "0x40345E2")]
		[FieldOffset(Offset = "0xA8")]
		private ItemType m_cacheEditingItemType;

		// Token: 0x040345E3 RID: 214499
		[Token(Token = "0x40345E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040345E4 RID: 214500
		[Token(Token = "0x40345E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040345E5 RID: 214501
		[Token(Token = "0x40345E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUnselectTypeClick;

		// Token: 0x040345E6 RID: 214502
		[Token(Token = "0x40345E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
