using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071CA RID: 29130
	[Token(Token = "0x20071CA")]
	public class Act6FunZoneMapStagePreviewInfoPanel : StagePreviewInfoBasicPanel
	{
		// Token: 0x0602955F RID: 169311 RVA: 0x000D55B8 File Offset: 0x000D37B8
		[Token(Token = "0x602955F")]
		[Address(RVA = "0x24B59F0", Offset = "0x24B45F0", VA = "0x1824B59F0", Slot = "6")]
		protected override bool OnZoneViewChanged(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06029560 RID: 169312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029560")]
		[Address(RVA = "0x24B5FE0", Offset = "0x24B4BE0", VA = "0x1824B5FE0", Slot = "5")]
		protected override void RefreshView(IStageSelectHandler zoneModel, StageViewModel selectedStage)
		{
		}

		// Token: 0x06029561 RID: 169313 RVA: 0x000D55D0 File Offset: 0x000D37D0
		[Token(Token = "0x6029561")]
		[Address(RVA = "0x24B6080", Offset = "0x24B4C80", VA = "0x1824B6080", Slot = "7")]
		protected override bool SelectStageViewModel(IStageSelectHandler zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06029562 RID: 169314 RVA: 0x000D55E8 File Offset: 0x000D37E8
		[Token(Token = "0x6029562")]
		[Address(RVA = "0x24B58F0", Offset = "0x24B44F0", VA = "0x1824B58F0", Slot = "8")]
		protected override bool CheckToShow(IStageSelectHandler zoneModel)
		{
			return default(bool);
		}

		// Token: 0x06029563 RID: 169315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029563")]
		[Address(RVA = "0x24B5960", Offset = "0x24B4560", VA = "0x1824B5960")]
		public void EventOnCharPreviewItemClick()
		{
		}

		// Token: 0x06029564 RID: 169316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029564")]
		[Address(RVA = "0x24B6160", Offset = "0x24B4D60", VA = "0x1824B6160")]
		private void _InitPanelIfNot()
		{
		}

		// Token: 0x06029565 RID: 169317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029565")]
		[Address(RVA = "0x24B63E0", Offset = "0x24B4FE0", VA = "0x1824B63E0")]
		public Act6FunZoneMapStagePreviewInfoPanel()
		{
		}

		// Token: 0x06029566 RID: 169318 RVA: 0x000D5600 File Offset: 0x000D3800
		[Token(Token = "0x6029566")]
		[Address(RVA = "0x214F1A0", Offset = "0x214DDA0", VA = "0x18214F1A0")]
		private bool <>xLuaBaseProxy_OnZoneViewChanged(IStageSelectHandler P0, StageViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x06029567 RID: 169319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029567")]
		[Address(RVA = "0x24B6150", Offset = "0x24B4D50", VA = "0x1824B6150")]
		private void <>xLuaBaseProxy_RefreshView(IStageSelectHandler P0, StageViewModel P1)
		{
		}

		// Token: 0x0403B08F RID: 241807
		[Token(Token = "0x403B08F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Text _txtPassTime;

		// Token: 0x0403B090 RID: 241808
		[Token(Token = "0x403B090")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private SimpleLayoutContent _starList;

		// Token: 0x0403B091 RID: 241809
		[Token(Token = "0x403B091")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private SimpleLayoutContent _descList;

		// Token: 0x0403B092 RID: 241810
		[Token(Token = "0x403B092")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x0403B093 RID: 241811
		[Token(Token = "0x403B093")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Text _txtNpcDialog;

		// Token: 0x0403B094 RID: 241812
		[Token(Token = "0x403B094")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0403B095 RID: 241813
		[Token(Token = "0x403B095")]
		[FieldOffset(Offset = "0x190")]
		private bool m_hasInited;

		// Token: 0x0403B096 RID: 241814
		[Token(Token = "0x403B096")]
		[FieldOffset(Offset = "0x198")]
		private string m_cachedStageId;

		// Token: 0x0403B097 RID: 241815
		[Token(Token = "0x403B097")]
		[FieldOffset(Offset = "0x1A0")]
		private Act6FunZoneMapStagePreviewPluginViewModel m_stagePreviewPluginViewModel;

		// Token: 0x0403B098 RID: 241816
		[Token(Token = "0x403B098")]
		[FieldOffset(Offset = "0x1A8")]
		private Act6FunZoneMapStagePreviewInfoPanel.AchieveStarItemListAdapter m_starAdapter;

		// Token: 0x0403B099 RID: 241817
		[Token(Token = "0x403B099")]
		[FieldOffset(Offset = "0x1B0")]
		private Act6FunZoneMapStagePreviewInfoPanel.AchieveDescItemAdapter m_descAdapter;

		// Token: 0x0403B09A RID: 241818
		[Token(Token = "0x403B09A")]
		[FieldOffset(Offset = "0x1B8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403B09B RID: 241819
		[Token(Token = "0x403B09B")]
		[FieldOffset(Offset = "0x1C8")]
		private AnimationSwitchTween m_showTween;

		// Token: 0x0403B09C RID: 241820
		[Token(Token = "0x403B09C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x0403B09D RID: 241821
		[Token(Token = "0x403B09D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x0403B09E RID: 241822
		[Token(Token = "0x403B09E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x0403B09F RID: 241823
		[Token(Token = "0x403B09F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckToShow;

		// Token: 0x0403B0A0 RID: 241824
		[Token(Token = "0x403B0A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCharPreviewItemClick;

		// Token: 0x0403B0A1 RID: 241825
		[Token(Token = "0x403B0A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitPanelIfNot;

		// Token: 0x0403B0A2 RID: 241826
		[Token(Token = "0x403B0A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020071CB RID: 29131
		[Token(Token = "0x20071CB")]
		private class AchieveStarItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06029568 RID: 169320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029568")]
			[Address(RVA = "0x24A8790", Offset = "0x24A7390", VA = "0x1824A8790")]
			public AchieveStarItemListAdapter(Act6FunZoneMapStagePreviewInfoPanel clousre)
			{
			}

			// Token: 0x170061E1 RID: 25057
			// (get) Token: 0x06029569 RID: 169321 RVA: 0x000D5618 File Offset: 0x000D3818
			[Token(Token = "0x170061E1")]
			public override int count
			{
				[Token(Token = "0x6029569")]
				[Address(RVA = "0x24A8810", Offset = "0x24A7410", VA = "0x1824A8810", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602956A RID: 169322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602956A")]
			[Address(RVA = "0x24A8520", Offset = "0x24A7120", VA = "0x1824A8520", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B0A3 RID: 241827
			[Token(Token = "0x403B0A3")]
			[FieldOffset(Offset = "0x20")]
			private Act6FunZoneMapStagePreviewInfoPanel m_closure;

			// Token: 0x0403B0A4 RID: 241828
			[Token(Token = "0x403B0A4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B0A5 RID: 241829
			[Token(Token = "0x403B0A5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B0A6 RID: 241830
			[Token(Token = "0x403B0A6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020071CC RID: 29132
		[Token(Token = "0x20071CC")]
		private class AchieveDescItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602956B RID: 169323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602956B")]
			[Address(RVA = "0x24A83B0", Offset = "0x24A6FB0", VA = "0x1824A83B0")]
			public AchieveDescItemAdapter(Act6FunZoneMapStagePreviewInfoPanel clousre)
			{
			}

			// Token: 0x170061E2 RID: 25058
			// (get) Token: 0x0602956C RID: 169324 RVA: 0x000D5630 File Offset: 0x000D3830
			[Token(Token = "0x170061E2")]
			public override int count
			{
				[Token(Token = "0x602956C")]
				[Address(RVA = "0x24A8430", Offset = "0x24A7030", VA = "0x1824A8430", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602956D RID: 169325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602956D")]
			[Address(RVA = "0x24A8100", Offset = "0x24A6D00", VA = "0x1824A8100", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B0A7 RID: 241831
			[Token(Token = "0x403B0A7")]
			[FieldOffset(Offset = "0x20")]
			private Act6FunZoneMapStagePreviewInfoPanel m_closure;

			// Token: 0x0403B0A8 RID: 241832
			[Token(Token = "0x403B0A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B0A9 RID: 241833
			[Token(Token = "0x403B0A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B0AA RID: 241834
			[Token(Token = "0x403B0AA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
