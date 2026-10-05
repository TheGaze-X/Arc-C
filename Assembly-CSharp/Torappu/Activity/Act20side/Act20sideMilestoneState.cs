using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007670 RID: 30320
	[Token(Token = "0x2007670")]
	public class Act20sideMilestoneState : PopupFadeState
	{
		// Token: 0x0602AA5F RID: 174687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA5F")]
		[Address(RVA = "0x2677350", Offset = "0x2675F50", VA = "0x182677350", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA60 RID: 174688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA60")]
		[Address(RVA = "0x26777E0", Offset = "0x26763E0", VA = "0x1826777E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA61 RID: 174689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA61")]
		[Address(RVA = "0x2677B50", Offset = "0x2676750", VA = "0x182677B50", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AA62 RID: 174690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA62")]
		[Address(RVA = "0x2677780", Offset = "0x2676380", VA = "0x182677780")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602AA63 RID: 174691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA63")]
		[Address(RVA = "0x2677FC0", Offset = "0x2676BC0", VA = "0x182677FC0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AA64 RID: 174692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA64")]
		[Address(RVA = "0x26786A0", Offset = "0x26772A0", VA = "0x1826786A0")]
		private void _OnJumpToCollectionState(IStateBean stateBean)
		{
		}

		// Token: 0x0602AA65 RID: 174693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA65")]
		[Address(RVA = "0x2677BD0", Offset = "0x26767D0", VA = "0x182677BD0")]
		private void Refresh(bool packClaimed = false)
		{
		}

		// Token: 0x0602AA66 RID: 174694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA66")]
		[Address(RVA = "0x2678340", Offset = "0x2676F40", VA = "0x182678340")]
		private void _BlockDuringClaim(bool isToBlock)
		{
		}

		// Token: 0x0602AA67 RID: 174695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA67")]
		[Address(RVA = "0x26773B0", Offset = "0x2675FB0", VA = "0x1826773B0")]
		private void OnClaimClicked()
		{
		}

		// Token: 0x0602AA68 RID: 174696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA68")]
		[Address(RVA = "0x26776D0", Offset = "0x26762D0", VA = "0x1826776D0")]
		private void OnCollectionClicked()
		{
		}

		// Token: 0x0602AA69 RID: 174697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA69")]
		[Address(RVA = "0x2677A10", Offset = "0x2676610", VA = "0x182677A10")]
		private void OnRecycleClicked()
		{
		}

		// Token: 0x0602AA6A RID: 174698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA6A")]
		[Address(RVA = "0x2678460", Offset = "0x2677060", VA = "0x182678460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA6B RID: 174699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA6B")]
		[Address(RVA = "0x2678870", Offset = "0x2677470", VA = "0x182678870")]
		private void _ReceiveItems(List<RewardItemModel> rewardL)
		{
		}

		// Token: 0x0602AA6C RID: 174700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA6C")]
		[Address(RVA = "0x2678790", Offset = "0x2677390", VA = "0x182678790")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602AA6D RID: 174701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA6D")]
		[Address(RVA = "0x2678A40", Offset = "0x2677640", VA = "0x182678A40")]
		private void _TweenMoveAdapter(int col, float duration)
		{
		}

		// Token: 0x0602AA6E RID: 174702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA6E")]
		[Address(RVA = "0x2678D90", Offset = "0x2677990", VA = "0x182678D90")]
		public Act20sideMilestoneState()
		{
		}

		// Token: 0x0602AA73 RID: 174707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA73")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AA74 RID: 174708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA74")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602AA75 RID: 174709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA75")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403D6BF RID: 251583
		[Token(Token = "0x403D6BF")]
		private const string PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x0403D6C0 RID: 251584
		[Token(Token = "0x403D6C0")]
		private const string ANIM_STATE_NAME = "car_get_parts";

		// Token: 0x0403D6C1 RID: 251585
		[Token(Token = "0x403D6C1")]
		private const float MILESTONE_LIST_ANIM_DUATION = 2f;

		// Token: 0x0403D6C2 RID: 251586
		[Token(Token = "0x403D6C2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("mileStone")]
		private Button _claimMilestoneBtn;

		// Token: 0x0403D6C3 RID: 251587
		[Token(Token = "0x403D6C3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("recycle")]
		private Button _recycleBtn;

		// Token: 0x0403D6C4 RID: 251588
		[Token(Token = "0x403D6C4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("collect")]
		private Button _collectionBtn;

		// Token: 0x0403D6C5 RID: 251589
		[Token(Token = "0x403D6C5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("collect")]
		private Text _collectionProgressText;

		// Token: 0x0403D6C6 RID: 251590
		[Token(Token = "0x403D6C6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("mileStone")]
		private Text _claimCountText;

		// Token: 0x0403D6C7 RID: 251591
		[Token(Token = "0x403D6C7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("mileStone")]
		private Text _pointProgressNumText;

		// Token: 0x0403D6C8 RID: 251592
		[Token(Token = "0x403D6C8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("mileStone")]
		private Text _itemRandomRangeTipText;

		// Token: 0x0403D6C9 RID: 251593
		[Token(Token = "0x403D6C9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("mileStone")]
		private FillProgressBar _bar;

		// Token: 0x0403D6CA RID: 251594
		[Token(Token = "0x403D6CA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("recycle")]
		private UICommonTrackPoint _recycleTrackPoint;

		// Token: 0x0403D6CB RID: 251595
		[Token(Token = "0x403D6CB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x0403D6CC RID: 251596
		[Token(Token = "0x403D6CC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AnimationWrapper _claimAnimWrap;

		// Token: 0x0403D6CD RID: 251597
		[Token(Token = "0x403D6CD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleList;

		// Token: 0x0403D6CE RID: 251598
		[Token(Token = "0x403D6CE")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x0403D6CF RID: 251599
		[Token(Token = "0x403D6CF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Act20sideMilestoneLoopItemView _loopItemPrefab;

		// Token: 0x0403D6D0 RID: 251600
		[Token(Token = "0x403D6D0")]
		[FieldOffset(Offset = "0xE0")]
		private Act20sideMilestoneLoopItemAdapter m_adapter;

		// Token: 0x0403D6D1 RID: 251601
		[Token(Token = "0x403D6D1")]
		[FieldOffset(Offset = "0xE8")]
		private Act20sideRecycleView m_recycleView;

		// Token: 0x0403D6D2 RID: 251602
		[Token(Token = "0x403D6D2")]
		[FieldOffset(Offset = "0xF0")]
		private Sequence m_seq;

		// Token: 0x0403D6D3 RID: 251603
		[Token(Token = "0x403D6D3")]
		[FieldOffset(Offset = "0xF8")]
		private Act20sideMilestoneStateBean m_statebean;

		// Token: 0x0403D6D4 RID: 251604
		[Token(Token = "0x403D6D4")]
		[FieldOffset(Offset = "0x100")]
		private TrackPointViewProperty m_trackProperty;

		// Token: 0x0403D6D5 RID: 251605
		[Token(Token = "0x403D6D5")]
		[FieldOffset(Offset = "0x108")]
		private TrackPointViewProperty m_recycleProperty;

		// Token: 0x0403D6D6 RID: 251606
		[Token(Token = "0x403D6D6")]
		[FieldOffset(Offset = "0x110")]
		private bool m_hasInited;

		// Token: 0x0403D6D7 RID: 251607
		[Token(Token = "0x403D6D7")]
		[FieldOffset(Offset = "0x111")]
		private bool m_isClaiming;

		// Token: 0x0403D6D8 RID: 251608
		[Token(Token = "0x403D6D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D6D9 RID: 251609
		[Token(Token = "0x403D6D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D6DA RID: 251610
		[Token(Token = "0x403D6DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403D6DB RID: 251611
		[Token(Token = "0x403D6DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403D6DC RID: 251612
		[Token(Token = "0x403D6DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403D6DD RID: 251613
		[Token(Token = "0x403D6DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToCollectionState;

		// Token: 0x0403D6DE RID: 251614
		[Token(Token = "0x403D6DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403D6DF RID: 251615
		[Token(Token = "0x403D6DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BlockDuringClaim;

		// Token: 0x0403D6E0 RID: 251616
		[Token(Token = "0x403D6E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClaimClicked;

		// Token: 0x0403D6E1 RID: 251617
		[Token(Token = "0x403D6E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCollectionClicked;

		// Token: 0x0403D6E2 RID: 251618
		[Token(Token = "0x403D6E2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRecycleClicked;

		// Token: 0x0403D6E3 RID: 251619
		[Token(Token = "0x403D6E3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D6E4 RID: 251620
		[Token(Token = "0x403D6E4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ReceiveItems;

		// Token: 0x0403D6E5 RID: 251621
		[Token(Token = "0x403D6E5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403D6E6 RID: 251622
		[Token(Token = "0x403D6E6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TweenMoveAdapter;

		// Token: 0x0403D6E7 RID: 251623
		[Token(Token = "0x403D6E7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
