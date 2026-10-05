using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004029 RID: 16425
	[Token(Token = "0x2004029")]
	public class SandboxAdminCharSelectShuffleView : SandboxV2AdminCharAbstractShuffleView
	{
		// Token: 0x060196C6 RID: 104134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C6")]
		[Address(RVA = "0x1214AA0", Offset = "0x12136A0", VA = "0x181214AA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060196C7 RID: 104135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C7")]
		[Address(RVA = "0x1214010", Offset = "0x1212C10", VA = "0x181214010", Slot = "4")]
		public override void OnApplyShuffleViewModel(SandboxV2CharListViewModel viewModel)
		{
		}

		// Token: 0x060196C8 RID: 104136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C8")]
		[Address(RVA = "0x1214910", Offset = "0x1213510", VA = "0x181214910")]
		private void _HandleFilterStatusWhenNeeded(SandboxV2ShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x060196C9 RID: 104137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C9")]
		[Address(RVA = "0x1214780", Offset = "0x1213380", VA = "0x181214780")]
		public void OnOpenStateShuffleView()
		{
		}

		// Token: 0x060196CA RID: 104138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196CA")]
		[Address(RVA = "0x1214640", Offset = "0x1213240", VA = "0x181214640")]
		public void OnCloseStateShuffleView()
		{
		}

		// Token: 0x060196CB RID: 104139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196CB")]
		[Address(RVA = "0x12144A0", Offset = "0x12130A0", VA = "0x1812144A0")]
		public void OnChangeStateShuffleView(SandboxV2CharFilter status)
		{
		}

		// Token: 0x060196CC RID: 104140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196CC")]
		[Address(RVA = "0x12146E0", Offset = "0x12132E0", VA = "0x1812146E0")]
		public void OnOpenProfShuffleView()
		{
		}

		// Token: 0x060196CD RID: 104141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196CD")]
		[Address(RVA = "0x12145A0", Offset = "0x12131A0", VA = "0x1812145A0")]
		public void OnCloseProfShuffleView()
		{
		}

		// Token: 0x060196CE RID: 104142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196CE")]
		[Address(RVA = "0x12143A0", Offset = "0x1212FA0", VA = "0x1812143A0")]
		public void OnChangeProfShuffleView(ProfessionCategory prof)
		{
		}

		// Token: 0x060196CF RID: 104143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196CF")]
		[Address(RVA = "0x1214820", Offset = "0x1213420", VA = "0x181214820")]
		public void OnSelectProfAllShuffle()
		{
		}

		// Token: 0x060196D0 RID: 104144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196D0")]
		[Address(RVA = "0x1214E10", Offset = "0x1213A10", VA = "0x181214E10")]
		public SandboxAdminCharSelectShuffleView()
		{
		}

		// Token: 0x0401FA4A RID: 129610
		[Token(Token = "0x401FA4A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _filterProfHideGo;

		// Token: 0x0401FA4B RID: 129611
		[Token(Token = "0x401FA4B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _filterProfShowGo;

		// Token: 0x0401FA4C RID: 129612
		[Token(Token = "0x401FA4C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _filterProfDetailPartGo;

		// Token: 0x0401FA4D RID: 129613
		[Token(Token = "0x401FA4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _filterProfNonePartGo;

		// Token: 0x0401FA4E RID: 129614
		[Token(Token = "0x401FA4E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textFilterProfDetail;

		// Token: 0x0401FA4F RID: 129615
		[Token(Token = "0x401FA4F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _filterStatusHideGo;

		// Token: 0x0401FA50 RID: 129616
		[Token(Token = "0x401FA50")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _filterStatusShowGo;

		// Token: 0x0401FA51 RID: 129617
		[Token(Token = "0x401FA51")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _professionFilterAlphaHandler;

		// Token: 0x0401FA52 RID: 129618
		[Token(Token = "0x401FA52")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _professionFilterSwitchDuration;

		// Token: 0x0401FA53 RID: 129619
		[Token(Token = "0x401FA53")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _statusFilterAlphaHandler;

		// Token: 0x0401FA54 RID: 129620
		[Token(Token = "0x401FA54")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _statusFilterSwitchDuration;

		// Token: 0x0401FA55 RID: 129621
		[Token(Token = "0x401FA55")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _professionFilterList;

		// Token: 0x0401FA56 RID: 129622
		[Token(Token = "0x401FA56")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _statusFilterList;

		// Token: 0x0401FA57 RID: 129623
		[Token(Token = "0x401FA57")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textProfessionAll;

		// Token: 0x0401FA58 RID: 129624
		[Token(Token = "0x401FA58")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorFilterAllUnselect;

		// Token: 0x0401FA59 RID: 129625
		[Token(Token = "0x401FA59")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorFilterAllSelect;

		// Token: 0x0401FA5A RID: 129626
		[Token(Token = "0x401FA5A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textSelectStatus;

		// Token: 0x0401FA5B RID: 129627
		[Token(Token = "0x401FA5B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelBtnFilterStatus;

		// Token: 0x0401FA5C RID: 129628
		[Token(Token = "0x401FA5C")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_professionFilterSwitchTween;

		// Token: 0x0401FA5D RID: 129629
		[Token(Token = "0x401FA5D")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_statusFilterSwitchTween;

		// Token: 0x0401FA5E RID: 129630
		[Token(Token = "0x401FA5E")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxCharShuffleProfessionListAdapter m_sandboxCharShuffleProfessionListAdapter;

		// Token: 0x0401FA5F RID: 129631
		[Token(Token = "0x401FA5F")]
		[FieldOffset(Offset = "0xD0")]
		private SandboxShuffleStatusListAdapter m_sandboxShuffleStatusListAdapter;

		// Token: 0x0401FA60 RID: 129632
		[Token(Token = "0x401FA60")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FA61 RID: 129633
		[Token(Token = "0x401FA61")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x0401FA62 RID: 129634
		[Token(Token = "0x401FA62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FA63 RID: 129635
		[Token(Token = "0x401FA63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyShuffleViewModel;

		// Token: 0x0401FA64 RID: 129636
		[Token(Token = "0x401FA64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleFilterStatusWhenNeeded;

		// Token: 0x0401FA65 RID: 129637
		[Token(Token = "0x401FA65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenStateShuffleView;

		// Token: 0x0401FA66 RID: 129638
		[Token(Token = "0x401FA66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCloseStateShuffleView;

		// Token: 0x0401FA67 RID: 129639
		[Token(Token = "0x401FA67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnChangeStateShuffleView;

		// Token: 0x0401FA68 RID: 129640
		[Token(Token = "0x401FA68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnOpenProfShuffleView;

		// Token: 0x0401FA69 RID: 129641
		[Token(Token = "0x401FA69")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCloseProfShuffleView;

		// Token: 0x0401FA6A RID: 129642
		[Token(Token = "0x401FA6A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnChangeProfShuffleView;

		// Token: 0x0401FA6B RID: 129643
		[Token(Token = "0x401FA6B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSelectProfAllShuffle;

		// Token: 0x0401FA6C RID: 129644
		[Token(Token = "0x401FA6C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
