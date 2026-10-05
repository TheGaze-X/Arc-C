using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C4 RID: 18628
	[Token(Token = "0x20048C4")]
	public class MiniActTrialItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x0601C19B RID: 115099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C19C RID: 115100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042B3")]
		public Action<string> onChapterClick
		{
			[Token(Token = "0x601C19B")]
			[Address(RVA = "0x1599D10", Offset = "0x1598910", VA = "0x181599D10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C19C")]
			[Address(RVA = "0x1599DD0", Offset = "0x15989D0", VA = "0x181599DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x0601C19D RID: 115101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C19E RID: 115102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042B4")]
		public Action<string, List<string>> onTrialCollect
		{
			[Token(Token = "0x601C19D")]
			[Address(RVA = "0x1599D70", Offset = "0x1598970", VA = "0x181599D70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C19E")]
			[Address(RVA = "0x1599E50", Offset = "0x1598A50", VA = "0x181599E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601C19F RID: 115103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C19F")]
		[Address(RVA = "0x15986B0", Offset = "0x15972B0", VA = "0x1815986B0")]
		public void BindNestedScroll(IDragHandler scroll)
		{
		}

		// Token: 0x0601C1A0 RID: 115104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A0")]
		[Address(RVA = "0x1598B70", Offset = "0x1597770", VA = "0x181598B70")]
		public void Render(MiniActTrialItemModel itemModel)
		{
		}

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A1")]
		[Address(RVA = "0x15990A0", Offset = "0x1597CA0", VA = "0x1815990A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C1A2 RID: 115106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A2")]
		[Address(RVA = "0x1599280", Offset = "0x1597E80", VA = "0x181599280")]
		private void _RenderCloseView(MiniActTrialItemModel itemModel)
		{
		}

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A3")]
		[Address(RVA = "0x15993F0", Offset = "0x1597FF0", VA = "0x1815993F0")]
		private void _RenderCommingView(MiniActTrialItemModel itemModel)
		{
		}

		// Token: 0x0601C1A4 RID: 115108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A4")]
		[Address(RVA = "0x1599520", Offset = "0x1598120", VA = "0x181599520")]
		private void _RenderOpenView(MiniActTrialItemModel itemModel)
		{
		}

		// Token: 0x0601C1A5 RID: 115109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A5")]
		[Address(RVA = "0x1598A00", Offset = "0x1597600", VA = "0x181598A00")]
		public void OnBtnNavToStory()
		{
		}

		// Token: 0x0601C1A6 RID: 115110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A6")]
		[Address(RVA = "0x1598740", Offset = "0x1597340", VA = "0x181598740")]
		public void OnBtnCollectAll()
		{
		}

		// Token: 0x0601C1A7 RID: 115111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1A7")]
		[Address(RVA = "0x1599CB0", Offset = "0x15988B0", VA = "0x181599CB0")]
		public MiniActTrialItemView()
		{
		}

		// Token: 0x04024B9A RID: 150426
		[Token(Token = "0x4024B9A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Close Part")]
		private GameObject _closePartGo;

		// Token: 0x04024B9B RID: 150427
		[Token(Token = "0x4024B9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Close Part")]
		private Image _imgStoryBg;

		// Token: 0x04024B9C RID: 150428
		[Token(Token = "0x4024B9C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Comming Part")]
		private GameObject _commingPartGo;

		// Token: 0x04024B9D RID: 150429
		[Token(Token = "0x4024B9D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Comming Part")]
		private Text _textCountDown;

		// Token: 0x04024B9E RID: 150430
		[Token(Token = "0x4024B9E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Locked Part")]
		private GameObject _lockedPartGo;

		// Token: 0x04024B9F RID: 150431
		[Token(Token = "0x4024B9F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _openPartGo;

		// Token: 0x04024BA0 RID: 150432
		[Token(Token = "0x4024BA0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Open Part")]
		private Image _imgTrialTitle;

		// Token: 0x04024BA1 RID: 150433
		[Token(Token = "0x4024BA1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _rewardCollectGo;

		// Token: 0x04024BA2 RID: 150434
		[Token(Token = "0x4024BA2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _rewardCompleteGo;

		// Token: 0x04024BA3 RID: 150435
		[Token(Token = "0x4024BA3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Open Part")]
		private Image _imgRewardCollectBg;

		// Token: 0x04024BA4 RID: 150436
		[Token(Token = "0x4024BA4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Open Part")]
		private Text _textCollectReward;

		// Token: 0x04024BA5 RID: 150437
		[Token(Token = "0x4024BA5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Open Part")]
		private Text _textTotalReward;

		// Token: 0x04024BA6 RID: 150438
		[Token(Token = "0x4024BA6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Open Part")]
		private Text _textUnlockStory;

		// Token: 0x04024BA7 RID: 150439
		[Token(Token = "0x4024BA7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Open Part")]
		private Text _textTotalStory;

		// Token: 0x04024BA8 RID: 150440
		[Token(Token = "0x4024BA8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _btnCollectAllGo;

		// Token: 0x04024BA9 RID: 150441
		[Token(Token = "0x4024BA9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _btnNavStoryGo;

		// Token: 0x04024BAA RID: 150442
		[Token(Token = "0x4024BAA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _storyUnlockStatusGo;

		// Token: 0x04024BAB RID: 150443
		[Token(Token = "0x4024BAB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Open Part")]
		private Text _textNavCaption;

		// Token: 0x04024BAC RID: 150444
		[Token(Token = "0x4024BAC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Open Part")]
		private SimpleLayoutContent _rewardListContent;

		// Token: 0x04024BAD RID: 150445
		[Token(Token = "0x4024BAD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Open Part")]
		private GameObject _newTrackPointGo;

		// Token: 0x04024BAE RID: 150446
		[Token(Token = "0x4024BAE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Open Part")]
		private UIWrappedScrollRect _rewardScroll;

		// Token: 0x04024BAF RID: 150447
		[Token(Token = "0x4024BAF")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_hasInited;

		// Token: 0x04024BB0 RID: 150448
		[Token(Token = "0x4024BB0")]
		[FieldOffset(Offset = "0xC8")]
		private MiniActTrialItemModel m_itemModel;

		// Token: 0x04024BB1 RID: 150449
		[Token(Token = "0x4024BB1")]
		[FieldOffset(Offset = "0xD0")]
		private MiniActTrialItemView.RewardListAdpater m_rewardListAdapter;

		// Token: 0x04024BB4 RID: 150452
		[Token(Token = "0x4024BB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onChapterClick;

		// Token: 0x04024BB5 RID: 150453
		[Token(Token = "0x4024BB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onChapterClick;

		// Token: 0x04024BB6 RID: 150454
		[Token(Token = "0x4024BB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onTrialCollect;

		// Token: 0x04024BB7 RID: 150455
		[Token(Token = "0x4024BB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onTrialCollect;

		// Token: 0x04024BB8 RID: 150456
		[Token(Token = "0x4024BB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindNestedScroll;

		// Token: 0x04024BB9 RID: 150457
		[Token(Token = "0x4024BB9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024BBA RID: 150458
		[Token(Token = "0x4024BBA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024BBB RID: 150459
		[Token(Token = "0x4024BBB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderCloseView;

		// Token: 0x04024BBC RID: 150460
		[Token(Token = "0x4024BBC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCommingView;

		// Token: 0x04024BBD RID: 150461
		[Token(Token = "0x4024BBD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderOpenView;

		// Token: 0x04024BBE RID: 150462
		[Token(Token = "0x4024BBE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnNavToStory;

		// Token: 0x04024BBF RID: 150463
		[Token(Token = "0x4024BBF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnCollectAll;

		// Token: 0x04024BC0 RID: 150464
		[Token(Token = "0x4024BC0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048C5 RID: 18629
		[Token(Token = "0x20048C5")]
		public class RewardListAdpater : SimpleLayoutAdapter
		{
			// Token: 0x0601C1A8 RID: 115112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C1A8")]
			[Address(RVA = "0x15A28B0", Offset = "0x15A14B0", VA = "0x1815A28B0")]
			public void SetData(List<MiniActTrialRewardItemModel> rewardList)
			{
			}

			// Token: 0x170042B5 RID: 17077
			// (get) Token: 0x0601C1A9 RID: 115113 RVA: 0x000A7328 File Offset: 0x000A5528
			[Token(Token = "0x170042B5")]
			public override int count
			{
				[Token(Token = "0x601C1A9")]
				[Address(RVA = "0x15A2990", Offset = "0x15A1590", VA = "0x1815A2990", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170042B6 RID: 17078
			// (get) Token: 0x0601C1AA RID: 115114 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601C1AB RID: 115115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170042B6")]
			public Action<string, List<string>> onTrialCollect
			{
				[Token(Token = "0x601C1AA")]
				[Address(RVA = "0x15A2A00", Offset = "0x15A1600", VA = "0x1815A2A00")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601C1AB")]
				[Address(RVA = "0x15A2A60", Offset = "0x15A1660", VA = "0x1815A2A60")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601C1AC RID: 115116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C1AC")]
			[Address(RVA = "0x15A2690", Offset = "0x15A1290", VA = "0x1815A2690", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601C1AD RID: 115117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C1AD")]
			[Address(RVA = "0x15A2930", Offset = "0x15A1530", VA = "0x1815A2930")]
			public RewardListAdpater()
			{
			}

			// Token: 0x04024BC1 RID: 150465
			[Token(Token = "0x4024BC1")]
			[FieldOffset(Offset = "0x20")]
			private List<MiniActTrialRewardItemModel> m_rewardList;

			// Token: 0x04024BC3 RID: 150467
			[Token(Token = "0x4024BC3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04024BC4 RID: 150468
			[Token(Token = "0x4024BC4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024BC5 RID: 150469
			[Token(Token = "0x4024BC5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_onTrialCollect;

			// Token: 0x04024BC6 RID: 150470
			[Token(Token = "0x4024BC6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_onTrialCollect;

			// Token: 0x04024BC7 RID: 150471
			[Token(Token = "0x4024BC7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04024BC8 RID: 150472
			[Token(Token = "0x4024BC8")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
