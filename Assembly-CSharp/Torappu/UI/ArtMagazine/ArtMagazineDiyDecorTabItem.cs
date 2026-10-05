using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006567 RID: 25959
	[Token(Token = "0x2006567")]
	public class ArtMagazineDiyDecorTabItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x0602553F RID: 152895 RVA: 0x000C7740 File Offset: 0x000C5940
		[Token(Token = "0x1700581B")]
		public ArtMagazineDiyDecorTabType tabType
		{
			[Token(Token = "0x602553F")]
			[Address(RVA = "0x2046D50", Offset = "0x2045950", VA = "0x182046D50")]
			get
			{
				return ArtMagazineDiyDecorTabType.NONE;
			}
		}

		// Token: 0x06025540 RID: 152896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025540")]
		[Address(RVA = "0x2046930", Offset = "0x2045530", VA = "0x182046930")]
		public void Render(bool isSelected, bool fastMode, bool isValid)
		{
		}

		// Token: 0x06025541 RID: 152897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025541")]
		[Address(RVA = "0x2046C00", Offset = "0x2045800", VA = "0x182046C00")]
		private void _SetSwitchTween(bool isShow, bool fastMode)
		{
		}

		// Token: 0x06025542 RID: 152898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025542")]
		[Address(RVA = "0x2046AA0", Offset = "0x20456A0", VA = "0x182046AA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025543 RID: 152899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025543")]
		[Address(RVA = "0x2046850", Offset = "0x2045450", VA = "0x182046850")]
		public void EventOpenTab()
		{
		}

		// Token: 0x06025544 RID: 152900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025544")]
		[Address(RVA = "0x2046CF0", Offset = "0x20458F0", VA = "0x182046CF0")]
		public ArtMagazineDiyDecorTabItem()
		{
		}

		// Token: 0x040345F3 RID: 214515
		[Token(Token = "0x40345F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtMagazineDiyDecorTabType _tabType;

		// Token: 0x040345F4 RID: 214516
		[Token(Token = "0x40345F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x040345F5 RID: 214517
		[Token(Token = "0x40345F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040345F6 RID: 214518
		[Token(Token = "0x40345F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x040345F7 RID: 214519
		[Token(Token = "0x40345F7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _inactiveRootAlpha;

		// Token: 0x040345F8 RID: 214520
		[Token(Token = "0x40345F8")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_switchTween;

		// Token: 0x040345F9 RID: 214521
		[Token(Token = "0x40345F9")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x040345FA RID: 214522
		[Token(Token = "0x40345FA")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040345FB RID: 214523
		[Token(Token = "0x40345FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tabType;

		// Token: 0x040345FC RID: 214524
		[Token(Token = "0x40345FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040345FD RID: 214525
		[Token(Token = "0x40345FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetSwitchTween;

		// Token: 0x040345FE RID: 214526
		[Token(Token = "0x40345FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040345FF RID: 214527
		[Token(Token = "0x40345FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOpenTab;

		// Token: 0x04034600 RID: 214528
		[Token(Token = "0x4034600")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
