using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006750 RID: 26448
	[Token(Token = "0x2006750")]
	public class HalfIdleUIBattleEquipThumbnailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025F47 RID: 155463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F47")]
		[Address(RVA = "0x20F4B10", Offset = "0x20F3710", VA = "0x1820F4B10")]
		public void Render(HalfIdleUIBattleEquipThumbnailViewModel vm)
		{
		}

		// Token: 0x06025F48 RID: 155464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F48")]
		[Address(RVA = "0x20F51D0", Offset = "0x20F3DD0", VA = "0x1820F51D0")]
		public void _InitIfNot(HalfIdleUIBattleEquipThumbnailViewModel vm)
		{
		}

		// Token: 0x06025F49 RID: 155465 RVA: 0x000C98E8 File Offset: 0x000C7AE8
		[Token(Token = "0x6025F49")]
		[Address(RVA = "0x20F5100", Offset = "0x20F3D00", VA = "0x1820F5100")]
		private Color _GetEquipLevelColor(int level)
		{
			return default(Color);
		}

		// Token: 0x06025F4A RID: 155466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F4A")]
		[Address(RVA = "0x20F4A50", Offset = "0x20F3650", VA = "0x1820F4A50")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x06025F4B RID: 155467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F4B")]
		[Address(RVA = "0x20F4910", Offset = "0x20F3510", VA = "0x1820F4910")]
		public void EventOnClick()
		{
		}

		// Token: 0x06025F4C RID: 155468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F4C")]
		[Address(RVA = "0x20F5490", Offset = "0x20F4090", VA = "0x1820F5490")]
		public HalfIdleUIBattleEquipThumbnailView()
		{
		}

		// Token: 0x0403561C RID: 218652
		[Token(Token = "0x403561C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HalfIdleUIBattleEquipIconView _equipIconView;

		// Token: 0x0403561D RID: 218653
		[Token(Token = "0x403561D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyMode;

		// Token: 0x0403561E RID: 218654
		[Token(Token = "0x403561E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _emptyEquipIcon;

		// Token: 0x0403561F RID: 218655
		[Token(Token = "0x403561F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _filledMode;

		// Token: 0x04035620 RID: 218656
		[Token(Token = "0x4035620")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _ableToEquipMode;

		// Token: 0x04035621 RID: 218657
		[Token(Token = "0x4035621")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _ableToEquipIcon;

		// Token: 0x04035622 RID: 218658
		[Token(Token = "0x4035622")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _ableToEquipAnim;

		// Token: 0x04035623 RID: 218659
		[Token(Token = "0x4035623")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _tipRoot;

		// Token: 0x04035624 RID: 218660
		[Token(Token = "0x4035624")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _tipIcon;

		// Token: 0x04035625 RID: 218661
		[Token(Token = "0x4035625")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _tipIconGlowBack;

		// Token: 0x04035626 RID: 218662
		[Token(Token = "0x4035626")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _tipIconGlowFront;

		// Token: 0x04035627 RID: 218663
		[Token(Token = "0x4035627")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _newEquipTipAnim;

		// Token: 0x04035628 RID: 218664
		[Token(Token = "0x4035628")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _upgradeEquipAnim;

		// Token: 0x04035629 RID: 218665
		[Token(Token = "0x4035629")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _selectedHighlightGo;

		// Token: 0x0403562A RID: 218666
		[Token(Token = "0x403562A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _selectedAnim;

		// Token: 0x0403562B RID: 218667
		[Token(Token = "0x403562B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButton _unfoldButton;

		// Token: 0x0403562C RID: 218668
		[Token(Token = "0x403562C")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403562D RID: 218669
		[Token(Token = "0x403562D")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_inited;

		// Token: 0x0403562E RID: 218670
		[Token(Token = "0x403562E")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_cachedSelected;

		// Token: 0x0403562F RID: 218671
		[Token(Token = "0x403562F")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_selectTween;

		// Token: 0x04035630 RID: 218672
		[Token(Token = "0x4035630")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_autoUpgradeTween;

		// Token: 0x04035631 RID: 218673
		[Token(Token = "0x4035631")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_tipTween;

		// Token: 0x04035632 RID: 218674
		[Token(Token = "0x4035632")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_ableToEquipTween;

		// Token: 0x04035633 RID: 218675
		[Token(Token = "0x4035633")]
		[FieldOffset(Offset = "0xF0")]
		private uint m_cachedNewEquipUid;

		// Token: 0x04035634 RID: 218676
		[Token(Token = "0x4035634")]
		[FieldOffset(Offset = "0xF4")]
		private Act1VHalfIdleEquipType m_cachedType;

		// Token: 0x04035635 RID: 218677
		[Token(Token = "0x4035635")]
		[FieldOffset(Offset = "0xF8")]
		private int m_cachedAutoUpgradeSeqNum;

		// Token: 0x04035636 RID: 218678
		[Token(Token = "0x4035636")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035637 RID: 218679
		[Token(Token = "0x4035637")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035638 RID: 218680
		[Token(Token = "0x4035638")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetEquipLevelColor;

		// Token: 0x04035639 RID: 218681
		[Token(Token = "0x4035639")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403563A RID: 218682
		[Token(Token = "0x403563A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403563B RID: 218683
		[Token(Token = "0x403563B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
