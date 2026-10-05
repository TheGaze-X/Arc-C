using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C7 RID: 25287
	[Token(Token = "0x20062C7")]
	public class AutoChessModeChoiceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060246EF RID: 149231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246EF")]
		[Address(RVA = "0x1F40900", Offset = "0x1F3F500", VA = "0x181F40900")]
		public void Render(AutoChessModeChoiceItemViewModel viewModel)
		{
		}

		// Token: 0x060246F0 RID: 149232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F0")]
		[Address(RVA = "0x1F409A0", Offset = "0x1F3F5A0", VA = "0x181F409A0")]
		private void _InitIfNot(AutoChessModeChoiceItemViewModel viewModel)
		{
		}

		// Token: 0x060246F1 RID: 149233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F1")]
		[Address(RVA = "0x1F41B20", Offset = "0x1F40720", VA = "0x181F41B20")]
		private void _SelectItem(bool isUnlocked, bool isSelect)
		{
		}

		// Token: 0x060246F2 RID: 149234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F2")]
		[Address(RVA = "0x1F41970", Offset = "0x1F40570", VA = "0x181F41970")]
		private void _RenderTrackPoint()
		{
		}

		// Token: 0x060246F3 RID: 149235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F3")]
		[Address(RVA = "0x1F41020", Offset = "0x1F3FC20", VA = "0x181F41020")]
		private void _RenderInfo()
		{
		}

		// Token: 0x060246F4 RID: 149236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F4")]
		[Address(RVA = "0x1F41BF0", Offset = "0x1F407F0", VA = "0x181F41BF0")]
		private void _TryTickByLockTime()
		{
		}

		// Token: 0x060246F5 RID: 149237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F5")]
		[Address(RVA = "0x1F41570", Offset = "0x1F40170", VA = "0x181F41570")]
		private void _RenderLockInfo()
		{
		}

		// Token: 0x060246F6 RID: 149238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F6")]
		[Address(RVA = "0x1F40EB0", Offset = "0x1F3FAB0", VA = "0x181F40EB0")]
		private void _OnUnlockTimeTick()
		{
		}

		// Token: 0x060246F7 RID: 149239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F7")]
		[Address(RVA = "0x1F406A0", Offset = "0x1F3F2A0", VA = "0x181F406A0")]
		public void EventOnClickItem()
		{
		}

		// Token: 0x060246F8 RID: 149240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F8")]
		[Address(RVA = "0x1F41D60", Offset = "0x1F40960", VA = "0x181F41D60")]
		public AutoChessModeChoiceItemView()
		{
		}

		// Token: 0x04032B80 RID: 207744
		[Token(Token = "0x4032B80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04032B81 RID: 207745
		[Token(Token = "0x4032B81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hotSpotObj;

		// Token: 0x04032B82 RID: 207746
		[Token(Token = "0x4032B82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasLockedBtn;

		// Token: 0x04032B83 RID: 207747
		[Token(Token = "0x4032B83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _modeDescText;

		// Token: 0x04032B84 RID: 207748
		[Token(Token = "0x4032B84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Text _modeNameText;

		// Token: 0x04032B85 RID: 207749
		[Token(Token = "0x4032B85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _modeUnlockHintText;

		// Token: 0x04032B86 RID: 207750
		[Token(Token = "0x4032B86")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgModeIcon;

		// Token: 0x04032B87 RID: 207751
		[Token(Token = "0x4032B87")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _effectDesc;

		// Token: 0x04032B88 RID: 207752
		[Token(Token = "0x4032B88")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04032B89 RID: 207753
		[Token(Token = "0x4032B89")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _unselectAnim;

		// Token: 0x04032B8A RID: 207754
		[Token(Token = "0x4032B8A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _alphaLockedBtn;

		// Token: 0x04032B8B RID: 207755
		[Token(Token = "0x4032B8B")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _alphaUnlockBtn;

		// Token: 0x04032B8C RID: 207756
		[Token(Token = "0x4032B8C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x04032B8D RID: 207757
		[Token(Token = "0x4032B8D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x04032B8E RID: 207758
		[Token(Token = "0x4032B8E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _selectBgGlow;

		// Token: 0x04032B8F RID: 207759
		[Token(Token = "0x4032B8F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _selectBg;

		// Token: 0x04032B90 RID: 207760
		[Token(Token = "0x4032B90")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _selectIconBg;

		// Token: 0x04032B91 RID: 207761
		[Token(Token = "0x4032B91")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _objLockKeyIcon;

		// Token: 0x04032B92 RID: 207762
		[Token(Token = "0x4032B92")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _objLockTimeIcon;

		// Token: 0x04032B93 RID: 207763
		[Token(Token = "0x4032B93")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04032B94 RID: 207764
		[Token(Token = "0x4032B94")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032B95 RID: 207765
		[Token(Token = "0x4032B95")]
		[FieldOffset(Offset = "0xD0")]
		private UIBiAnimClipSwitchTween m_selectSwitchTween;

		// Token: 0x04032B96 RID: 207766
		[Token(Token = "0x4032B96")]
		[FieldOffset(Offset = "0xD8")]
		private AutoChessModeChoiceItemViewModel m_cachedViewModel;

		// Token: 0x04032B97 RID: 207767
		[Token(Token = "0x4032B97")]
		[FieldOffset(Offset = "0xE0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032B98 RID: 207768
		[Token(Token = "0x4032B98")]
		[FieldOffset(Offset = "0xF0")]
		private GameObject m_trackPointObj;

		// Token: 0x04032B99 RID: 207769
		[Token(Token = "0x4032B99")]
		[FieldOffset(Offset = "0xF8")]
		private long m_unlockUntilTime;

		// Token: 0x04032B9A RID: 207770
		[Token(Token = "0x4032B9A")]
		[FieldOffset(Offset = "0x100")]
		private int m_timerId;

		// Token: 0x04032B9B RID: 207771
		[Token(Token = "0x4032B9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032B9C RID: 207772
		[Token(Token = "0x4032B9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032B9D RID: 207773
		[Token(Token = "0x4032B9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x04032B9E RID: 207774
		[Token(Token = "0x4032B9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderTrackPoint;

		// Token: 0x04032B9F RID: 207775
		[Token(Token = "0x4032B9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderInfo;

		// Token: 0x04032BA0 RID: 207776
		[Token(Token = "0x4032BA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTickByLockTime;

		// Token: 0x04032BA1 RID: 207777
		[Token(Token = "0x4032BA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderLockInfo;

		// Token: 0x04032BA2 RID: 207778
		[Token(Token = "0x4032BA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUnlockTimeTick;

		// Token: 0x04032BA3 RID: 207779
		[Token(Token = "0x4032BA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClickItem;

		// Token: 0x04032BA4 RID: 207780
		[Token(Token = "0x4032BA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
