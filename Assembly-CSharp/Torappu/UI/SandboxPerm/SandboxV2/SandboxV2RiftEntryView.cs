using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004391 RID: 17297
	[Token(Token = "0x2004391")]
	public class SandboxV2RiftEntryView : DataBinder<SandboxV2RiftEntryProperty>
	{
		// Token: 0x0601A8F0 RID: 108784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F0")]
		[Address(RVA = "0x13B6D10", Offset = "0x13B5910", VA = "0x1813B6D10", Slot = "7")]
		public override void OnValueChanged(SandboxV2RiftEntryProperty property)
		{
		}

		// Token: 0x0601A8F1 RID: 108785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F1")]
		[Address(RVA = "0x13B7480", Offset = "0x13B6080", VA = "0x1813B7480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A8F2 RID: 108786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F2")]
		[Address(RVA = "0x13B6BD0", Offset = "0x13B57D0", VA = "0x1813B6BD0")]
		public void CreateRift()
		{
		}

		// Token: 0x0601A8F3 RID: 108787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F3")]
		[Address(RVA = "0x13B6C70", Offset = "0x13B5870", VA = "0x1813B6C70")]
		public void ExitRiftReservePage()
		{
		}

		// Token: 0x0601A8F4 RID: 108788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F4")]
		[Address(RVA = "0x13B72B0", Offset = "0x13B5EB0", VA = "0x1813B72B0")]
		public void OpenDifficultyDetailPanel()
		{
		}

		// Token: 0x0601A8F5 RID: 108789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F5")]
		[Address(RVA = "0x13B6B40", Offset = "0x13B5740", VA = "0x1813B6B40")]
		public void CloseDifficultyDetailPanel()
		{
		}

		// Token: 0x0601A8F6 RID: 108790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F6")]
		[Address(RVA = "0x13B73E0", Offset = "0x13B5FE0", VA = "0x1813B73E0")]
		public void OpenRiftTeamState()
		{
		}

		// Token: 0x0601A8F7 RID: 108791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F7")]
		[Address(RVA = "0x13B7340", Offset = "0x13B5F40", VA = "0x1813B7340")]
		public void OpenRiftDifficultyState()
		{
		}

		// Token: 0x0601A8F8 RID: 108792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8F8")]
		[Address(RVA = "0x13B7840", Offset = "0x13B6440", VA = "0x1813B7840")]
		public SandboxV2RiftEntryView()
		{
		}

		// Token: 0x04021D05 RID: 138501
		[Token(Token = "0x4021D05")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SandboxV2ItemCard.Option REWARD_ITEM_CARD_OPTION;

		// Token: 0x04021D06 RID: 138502
		[Token(Token = "0x4021D06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Group Title")]
		private Text _mainTargetTitle;

		// Token: 0x04021D07 RID: 138503
		[Token(Token = "0x4021D07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Group Title")]
		private Text _mainTargetDesc;

		// Token: 0x04021D08 RID: 138504
		[Token(Token = "0x4021D08")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Group Lower Left")]
		private Text _mainTargetDayCount;

		// Token: 0x04021D09 RID: 138505
		[Token(Token = "0x4021D09")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Group Lower Left")]
		private SandboxV2RiftEntryParamItem _climateParam;

		// Token: 0x04021D0A RID: 138506
		[Token(Token = "0x4021D0A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Group Lower Left")]
		private SandboxV2RiftEntryParamItem _terrainParam;

		// Token: 0x04021D0B RID: 138507
		[Token(Token = "0x4021D0B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Group Lower Left")]
		private SandboxV2RiftEntryParamItem _enemyParam;

		// Token: 0x04021D0C RID: 138508
		[Token(Token = "0x4021D0C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Group Lower Left")]
		private GameObject _globalEffectGo;

		// Token: 0x04021D0D RID: 138509
		[Token(Token = "0x4021D0D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Group Lower Left")]
		private Text _globalEffectDesc;

		// Token: 0x04021D0E RID: 138510
		[Token(Token = "0x4021D0E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Group Lower Left")]
		private GameObject _subTargetGo;

		// Token: 0x04021D0F RID: 138511
		[Token(Token = "0x4021D0F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Group Lower Left")]
		private Text _subTargetDesc;

		// Token: 0x04021D10 RID: 138512
		[Token(Token = "0x4021D10")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Group Lower Left")]
		private Text _rewardDescText;

		// Token: 0x04021D11 RID: 138513
		[Token(Token = "0x4021D11")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Group Lower Left")]
		private GameObject _rewardEmptyPanel;

		// Token: 0x04021D12 RID: 138514
		[Token(Token = "0x4021D12")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Group Lower Left")]
		private GameObject _rewardContentPanel;

		// Token: 0x04021D13 RID: 138515
		[Token(Token = "0x4021D13")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Group Lower Left")]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04021D14 RID: 138516
		[Token(Token = "0x4021D14")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Group Lower Left")]
		private ScrollRect _rewardRect;

		// Token: 0x04021D15 RID: 138517
		[Token(Token = "0x4021D15")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Group Lower Right")]
		private UIAnimationLocation _difficultyPanelSwitchAnim;

		// Token: 0x04021D16 RID: 138518
		[Token(Token = "0x4021D16")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Group Lower Right")]
		private TwoStateToggle _difficultyPanelToggle;

		// Token: 0x04021D17 RID: 138519
		[Token(Token = "0x4021D17")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Group Lower Right")]
		private TwoStateToggle _difficultyDescToggle;

		// Token: 0x04021D18 RID: 138520
		[Token(Token = "0x4021D18")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Group Lower Right")]
		private Text _difficultyLevel;

		// Token: 0x04021D19 RID: 138521
		[Token(Token = "0x4021D19")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Group Lower Right")]
		private SimpleLayoutContent _difficultyDetailDesc;

		// Token: 0x04021D1A RID: 138522
		[Token(Token = "0x4021D1A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Group Lower Right")]
		private TwoStateToggle _teamToggle;

		// Token: 0x04021D1B RID: 138523
		[Token(Token = "0x4021D1B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Group Lower Right")]
		private Image _teamSmallIcon;

		// Token: 0x04021D1C RID: 138524
		[Token(Token = "0x4021D1C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Group Lower Right")]
		private Text _teamLevel;

		// Token: 0x04021D1D RID: 138525
		[Token(Token = "0x4021D1D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Group Lower Right")]
		private Text _teamName;

		// Token: 0x04021D1E RID: 138526
		[Token(Token = "0x4021D1E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Panel Confirm")]
		private TwoStateToggle _riftStartToggle;

		// Token: 0x04021D1F RID: 138527
		[Token(Token = "0x4021D1F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Panel Confirm")]
		private Text _riftStartRemainTimeText;

		// Token: 0x04021D20 RID: 138528
		[Token(Token = "0x4021D20")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _backPressArea;

		// Token: 0x04021D21 RID: 138529
		[Token(Token = "0x4021D21")]
		[FieldOffset(Offset = "0x100")]
		private bool m_hasInited;

		// Token: 0x04021D22 RID: 138530
		[Token(Token = "0x4021D22")]
		[FieldOffset(Offset = "0x108")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021D23 RID: 138531
		[Token(Token = "0x4021D23")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021D24 RID: 138532
		[Token(Token = "0x4021D24")]
		[FieldOffset(Offset = "0x128")]
		private List<UIItemViewModel> m_cachedRewards;

		// Token: 0x04021D25 RID: 138533
		[Token(Token = "0x4021D25")]
		[FieldOffset(Offset = "0x130")]
		private List<string> m_cachedDifficultyDesc;

		// Token: 0x04021D26 RID: 138534
		[Token(Token = "0x4021D26")]
		[FieldOffset(Offset = "0x138")]
		private int m_cachedDifficultyLevel;

		// Token: 0x04021D27 RID: 138535
		[Token(Token = "0x4021D27")]
		[FieldOffset(Offset = "0x140")]
		private SandboxV2RiftEntryView.RewardAdapter m_rewardAdapter;

		// Token: 0x04021D28 RID: 138536
		[Token(Token = "0x4021D28")]
		[FieldOffset(Offset = "0x148")]
		private SandboxV2RiftEntryView.DifficultyDescAdapter m_difficultyDescAdapter;

		// Token: 0x04021D29 RID: 138537
		[Token(Token = "0x4021D29")]
		[FieldOffset(Offset = "0x150")]
		private AnimationSwitchTween m_difficultyPanelSwitchTween;

		// Token: 0x04021D2A RID: 138538
		[Token(Token = "0x4021D2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021D2B RID: 138539
		[Token(Token = "0x4021D2B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021D2C RID: 138540
		[Token(Token = "0x4021D2C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateRift;

		// Token: 0x04021D2D RID: 138541
		[Token(Token = "0x4021D2D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ExitRiftReservePage;

		// Token: 0x04021D2E RID: 138542
		[Token(Token = "0x4021D2E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OpenDifficultyDetailPanel;

		// Token: 0x04021D2F RID: 138543
		[Token(Token = "0x4021D2F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CloseDifficultyDetailPanel;

		// Token: 0x04021D30 RID: 138544
		[Token(Token = "0x4021D30")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OpenRiftTeamState;

		// Token: 0x04021D31 RID: 138545
		[Token(Token = "0x4021D31")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OpenRiftDifficultyState;

		// Token: 0x04021D32 RID: 138546
		[Token(Token = "0x4021D32")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004392 RID: 17298
		[Token(Token = "0x2004392")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A8FA RID: 108794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8FA")]
			[Address(RVA = "0x13A7CF0", Offset = "0x13A68F0", VA = "0x1813A7CF0")]
			public RewardAdapter(SandboxV2RiftEntryView closure)
			{
			}

			// Token: 0x17003EF9 RID: 16121
			// (get) Token: 0x0601A8FB RID: 108795 RVA: 0x000A25A0 File Offset: 0x000A07A0
			[Token(Token = "0x17003EF9")]
			public override int count
			{
				[Token(Token = "0x601A8FB")]
				[Address(RVA = "0x13A7DF0", Offset = "0x13A69F0", VA = "0x1813A7DF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A8FC RID: 108796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A8FC")]
			[Address(RVA = "0x13A7810", Offset = "0x13A6410", VA = "0x1813A7810", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A8FD RID: 108797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8FD")]
			[Address(RVA = "0x13A7BD0", Offset = "0x13A67D0", VA = "0x1813A7BD0")]
			private void _OnItemClick(int index)
			{
			}

			// Token: 0x04021D33 RID: 138547
			[Token(Token = "0x4021D33")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RiftEntryView m_closure;

			// Token: 0x04021D34 RID: 138548
			[Token(Token = "0x4021D34")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021D35 RID: 138549
			[Token(Token = "0x4021D35")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021D36 RID: 138550
			[Token(Token = "0x4021D36")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04021D37 RID: 138551
			[Token(Token = "0x4021D37")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__OnItemClick;
		}

		// Token: 0x02004393 RID: 17299
		[Token(Token = "0x2004393")]
		private class DifficultyDescAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A8FE RID: 108798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8FE")]
			[Address(RVA = "0x13A72C0", Offset = "0x13A5EC0", VA = "0x1813A72C0")]
			public DifficultyDescAdapter(SandboxV2RiftEntryView closure)
			{
			}

			// Token: 0x17003EFA RID: 16122
			// (get) Token: 0x0601A8FF RID: 108799 RVA: 0x000A25B8 File Offset: 0x000A07B8
			[Token(Token = "0x17003EFA")]
			public override int count
			{
				[Token(Token = "0x601A8FF")]
				[Address(RVA = "0x13A7340", Offset = "0x13A5F40", VA = "0x1813A7340", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A900 RID: 108800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A900")]
			[Address(RVA = "0x13A70E0", Offset = "0x13A5CE0", VA = "0x1813A70E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021D38 RID: 138552
			[Token(Token = "0x4021D38")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RiftEntryView m_closure;

			// Token: 0x04021D39 RID: 138553
			[Token(Token = "0x4021D39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021D3A RID: 138554
			[Token(Token = "0x4021D3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021D3B RID: 138555
			[Token(Token = "0x4021D3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
