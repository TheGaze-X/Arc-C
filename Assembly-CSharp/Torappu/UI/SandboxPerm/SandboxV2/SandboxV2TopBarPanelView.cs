using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200420A RID: 16906
	[Token(Token = "0x200420A")]
	public class SandboxV2TopBarPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A157 RID: 106839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A157")]
		[Address(RVA = "0x12F7800", Offset = "0x12F6400", VA = "0x1812F7800")]
		public void Render(SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A158 RID: 106840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A158")]
		[Address(RVA = "0x12F7CA0", Offset = "0x12F68A0", VA = "0x1812F7CA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A159 RID: 106841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A159")]
		[Address(RVA = "0x12F8050", Offset = "0x12F6C50", VA = "0x1812F8050")]
		private void _RenderButtons(SandboxV2DungeonMiscViewModel miscViewModel)
		{
		}

		// Token: 0x0601A15A RID: 106842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A15A")]
		[Address(RVA = "0x12F8330", Offset = "0x12F6F30", VA = "0x1812F8330")]
		private void _RenderRiftEffectsView(SandboxV2DungeonMiscViewModel miscViewModel)
		{
		}

		// Token: 0x0601A15B RID: 106843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A15B")]
		[Address(RVA = "0x12F8280", Offset = "0x12F6E80", VA = "0x1812F8280")]
		private void _RenderPrimaryRes(SandboxV2DungeonMiscViewModel miscViewModel)
		{
		}

		// Token: 0x0601A15C RID: 106844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A15C")]
		[Address(RVA = "0x12F8400", Offset = "0x12F7000", VA = "0x1812F8400")]
		private void _RenderSphere(SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A15D RID: 106845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A15D")]
		[Address(RVA = "0x12F7F40", Offset = "0x12F6B40", VA = "0x1812F7F40")]
		private void _OnSphereClick()
		{
		}

		// Token: 0x0601A15E RID: 106846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A15E")]
		[Address(RVA = "0x12F7760", Offset = "0x12F6360", VA = "0x1812F7760")]
		public void OnBtnDiscardApClicked()
		{
		}

		// Token: 0x0601A15F RID: 106847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A15F")]
		[Address(RVA = "0x12F7BE0", Offset = "0x12F67E0", VA = "0x1812F7BE0")]
		public GameObject TutorialOnly_GetSphereBtnGo()
		{
			return null;
		}

		// Token: 0x0601A160 RID: 106848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A160")]
		[Address(RVA = "0x12F7B20", Offset = "0x12F6720", VA = "0x1812F7B20")]
		public GameObject TutorialOnly_GetCrossDayBtnGo()
		{
			return null;
		}

		// Token: 0x0601A161 RID: 106849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A161")]
		[Address(RVA = "0x12F84A0", Offset = "0x12F70A0", VA = "0x1812F84A0")]
		public SandboxV2TopBarPanelView()
		{
		}

		// Token: 0x04020DFB RID: 134651
		[Token(Token = "0x4020DFB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2TopBarResItemView _goldItemView;

		// Token: 0x04020DFC RID: 134652
		[Token(Token = "0x4020DFC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2TopBarResItemView _moneyItemView;

		// Token: 0x04020DFD RID: 134653
		[Token(Token = "0x4020DFD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlButtons;

		// Token: 0x04020DFE RID: 134654
		[Token(Token = "0x4020DFE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _expeditionBtn;

		// Token: 0x04020DFF RID: 134655
		[Token(Token = "0x4020DFF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _eventEffectBtn;

		// Token: 0x04020E00 RID: 134656
		[Token(Token = "0x4020E00")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _logisticsEffectBtn;

		// Token: 0x04020E01 RID: 134657
		[Token(Token = "0x4020E01")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_topMenuFloatPanelView")]
		[SerializeField]
		private SandboxV2TopBarFloatPanelView _topBarFloatPanelView;

		// Token: 0x04020E02 RID: 134658
		[Token(Token = "0x4020E02")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _split;

		// Token: 0x04020E03 RID: 134659
		[Token(Token = "0x4020E03")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _secondMatLayout;

		// Token: 0x04020E04 RID: 134660
		[Token(Token = "0x4020E04")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2TopBarSphereView _sphereViewPrefab;

		// Token: 0x04020E05 RID: 134661
		[Token(Token = "0x4020E05")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _sphereViewContainer;

		// Token: 0x04020E06 RID: 134662
		[Token(Token = "0x4020E06")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2TopBarRiftEffectsView _topBarRiftEffectsView;

		// Token: 0x04020E07 RID: 134663
		[Token(Token = "0x4020E07")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIBlendRTImage _bkgBlur;

		// Token: 0x04020E08 RID: 134664
		[Token(Token = "0x4020E08")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _bkgColor;

		// Token: 0x04020E09 RID: 134665
		[Token(Token = "0x4020E09")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2TopBarPanelView.SandboxV2TopBarMaterialAdapter m_materialAdapter;

		// Token: 0x04020E0A RID: 134666
		[Token(Token = "0x4020E0A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04020E0B RID: 134667
		[Token(Token = "0x4020E0B")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020E0C RID: 134668
		[Token(Token = "0x4020E0C")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2DungeonViewConfig m_cachedCfg;

		// Token: 0x04020E0D RID: 134669
		[Token(Token = "0x4020E0D")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2TopBarSphereView m_sphereView;

		// Token: 0x04020E0E RID: 134670
		[Token(Token = "0x4020E0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E0F RID: 134671
		[Token(Token = "0x4020E0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020E10 RID: 134672
		[Token(Token = "0x4020E10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderButtons;

		// Token: 0x04020E11 RID: 134673
		[Token(Token = "0x4020E11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderRiftEffectsView;

		// Token: 0x04020E12 RID: 134674
		[Token(Token = "0x4020E12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderPrimaryRes;

		// Token: 0x04020E13 RID: 134675
		[Token(Token = "0x4020E13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSphere;

		// Token: 0x04020E14 RID: 134676
		[Token(Token = "0x4020E14")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSphereClick;

		// Token: 0x04020E15 RID: 134677
		[Token(Token = "0x4020E15")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnDiscardApClicked;

		// Token: 0x04020E16 RID: 134678
		[Token(Token = "0x4020E16")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetSphereBtnGo;

		// Token: 0x04020E17 RID: 134679
		[Token(Token = "0x4020E17")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetCrossDayBtnGo;

		// Token: 0x04020E18 RID: 134680
		[Token(Token = "0x4020E18")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200420B RID: 16907
		[Token(Token = "0x200420B")]
		public class SandboxV2TopBarMaterialAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E15 RID: 15893
			// (get) Token: 0x0601A162 RID: 106850 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601A163 RID: 106851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003E15")]
			public ListDict<string, UIItemViewModel> dataSet
			{
				[Token(Token = "0x601A162")]
				[Address(RVA = "0x12F7680", Offset = "0x12F6280", VA = "0x1812F7680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601A163")]
				[Address(RVA = "0x12F76E0", Offset = "0x12F62E0", VA = "0x1812F76E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003E16 RID: 15894
			// (get) Token: 0x0601A164 RID: 106852 RVA: 0x000A03E0 File Offset: 0x0009E5E0
			[Token(Token = "0x17003E16")]
			public override int count
			{
				[Token(Token = "0x601A164")]
				[Address(RVA = "0x12F75C0", Offset = "0x12F61C0", VA = "0x1812F75C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A165 RID: 106853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A165")]
			[Address(RVA = "0x12F7350", Offset = "0x12F5F50", VA = "0x1812F7350", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A166 RID: 106854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A166")]
			[Address(RVA = "0x12F7560", Offset = "0x12F6160", VA = "0x1812F7560")]
			public SandboxV2TopBarMaterialAdapter()
			{
			}

			// Token: 0x04020E1A RID: 134682
			[Token(Token = "0x4020E1A")]
			[FieldOffset(Offset = "0x28")]
			public string topicId;

			// Token: 0x04020E1B RID: 134683
			[Token(Token = "0x4020E1B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04020E1C RID: 134684
			[Token(Token = "0x4020E1C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04020E1D RID: 134685
			[Token(Token = "0x4020E1D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020E1E RID: 134686
			[Token(Token = "0x4020E1E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04020E1F RID: 134687
			[Token(Token = "0x4020E1F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
