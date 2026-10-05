using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007002 RID: 28674
	[Token(Token = "0x2007002")]
	public class ActMultiV3StageListState : ActMultiV3StageListViewState
	{
		// Token: 0x06028B49 RID: 166729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B49")]
		[Address(RVA = "0x24121C0", Offset = "0x2410DC0", VA = "0x1824121C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B4A RID: 166730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B4A")]
		[Address(RVA = "0x24116E0", Offset = "0x24102E0", VA = "0x1824116E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028B4B RID: 166731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B4B")]
		[Address(RVA = "0x2411CF0", Offset = "0x24108F0", VA = "0x182411CF0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06028B4C RID: 166732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B4C")]
		[Address(RVA = "0x2411A10", Offset = "0x2410610", VA = "0x182411A10", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06028B4D RID: 166733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B4D")]
		[Address(RVA = "0x2411A80", Offset = "0x2410680", VA = "0x182411A80", Slot = "34")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028B4E RID: 166734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B4E")]
		[Address(RVA = "0x2411370", Offset = "0x240FF70", VA = "0x182411370", Slot = "35")]
		public override void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06028B4F RID: 166735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B4F")]
		[Address(RVA = "0x2411DE0", Offset = "0x24109E0", VA = "0x182411DE0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028B50 RID: 166736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B50")]
		[Address(RVA = "0x2412570", Offset = "0x2411170", VA = "0x182412570")]
		private void _OnJumpToStageListDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x06028B51 RID: 166737 RVA: 0x000D2B70 File Offset: 0x000D0D70
		[Token(Token = "0x6028B51")]
		[Address(RVA = "0x2411F40", Offset = "0x2410B40", VA = "0x182411F40")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x06028B52 RID: 166738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B52")]
		[Address(RVA = "0x2412910", Offset = "0x2411510", VA = "0x182412910")]
		private void _OnTabClicked(long msg)
		{
		}

		// Token: 0x06028B53 RID: 166739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B53")]
		[Address(RVA = "0x2412730", Offset = "0x2411330", VA = "0x182412730")]
		private void _OnStageClicked(string stageId)
		{
		}

		// Token: 0x06028B54 RID: 166740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B54")]
		[Address(RVA = "0x2412390", Offset = "0x2410F90", VA = "0x182412390")]
		private void _OnBtnInfoClicked()
		{
		}

		// Token: 0x06028B55 RID: 166741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B55")]
		[Address(RVA = "0x2412000", Offset = "0x2410C00", VA = "0x182412000")]
		private void _ClearStageNewTrackpoint()
		{
		}

		// Token: 0x06028B56 RID: 166742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B56")]
		[Address(RVA = "0x2411310", Offset = "0x240FF10", VA = "0x182411310", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028B57 RID: 166743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B57")]
		[Address(RVA = "0x2411400", Offset = "0x2410000", VA = "0x182411400")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06028B58 RID: 166744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B58")]
		[Address(RVA = "0x2411500", Offset = "0x2410100", VA = "0x182411500")]
		public void OnBtnRewardClicked()
		{
		}

		// Token: 0x06028B59 RID: 166745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B59")]
		[Address(RVA = "0x2412A80", Offset = "0x2411680", VA = "0x182412A80")]
		public ActMultiV3StageListState()
		{
		}

		// Token: 0x06028B5A RID: 166746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B5A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028B5B RID: 166747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B5B")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06028B5C RID: 166748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B5C")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06028B5D RID: 166749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B5D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403A055 RID: 237653
		[Token(Token = "0x403A055")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x0403A056 RID: 237654
		[Token(Token = "0x403A056")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403A057 RID: 237655
		[Token(Token = "0x403A057")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActMultiV3StageListView _viewPrefab;

		// Token: 0x0403A058 RID: 237656
		[Token(Token = "0x403A058")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgToken;

		// Token: 0x0403A059 RID: 237657
		[Token(Token = "0x403A059")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0403A05A RID: 237658
		[Token(Token = "0x403A05A")]
		[FieldOffset(Offset = "0x98")]
		private ActMultiV3StageListView m_view;

		// Token: 0x0403A05B RID: 237659
		[Token(Token = "0x403A05B")]
		[FieldOffset(Offset = "0xA0")]
		private ActMultiV3StageListState.StateBean m_stateBean;

		// Token: 0x0403A05C RID: 237660
		[Token(Token = "0x403A05C")]
		[FieldOffset(Offset = "0xA8")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403A05D RID: 237661
		[Token(Token = "0x403A05D")]
		[FieldOffset(Offset = "0xB0")]
		private int m_infoDialogInst;

		// Token: 0x0403A05E RID: 237662
		[Token(Token = "0x403A05E")]
		[FieldOffset(Offset = "0xB4")]
		private int m_rewardDialogInst;

		// Token: 0x0403A05F RID: 237663
		[Token(Token = "0x403A05F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A060 RID: 237664
		[Token(Token = "0x403A060")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A061 RID: 237665
		[Token(Token = "0x403A061")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403A062 RID: 237666
		[Token(Token = "0x403A062")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403A063 RID: 237667
		[Token(Token = "0x403A063")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403A064 RID: 237668
		[Token(Token = "0x403A064")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403A065 RID: 237669
		[Token(Token = "0x403A065")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403A066 RID: 237670
		[Token(Token = "0x403A066")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToStageListDetailState;

		// Token: 0x0403A067 RID: 237671
		[Token(Token = "0x403A067")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x0403A068 RID: 237672
		[Token(Token = "0x403A068")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTabClicked;

		// Token: 0x0403A069 RID: 237673
		[Token(Token = "0x403A069")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnStageClicked;

		// Token: 0x0403A06A RID: 237674
		[Token(Token = "0x403A06A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBtnInfoClicked;

		// Token: 0x0403A06B RID: 237675
		[Token(Token = "0x403A06B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearStageNewTrackpoint;

		// Token: 0x0403A06C RID: 237676
		[Token(Token = "0x403A06C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403A06D RID: 237677
		[Token(Token = "0x403A06D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0403A06E RID: 237678
		[Token(Token = "0x403A06E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBtnRewardClicked;

		// Token: 0x0403A06F RID: 237679
		[Token(Token = "0x403A06F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007003 RID: 28675
		[Token(Token = "0x2007003")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x06028B5E RID: 166750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B5E")]
			[Address(RVA = "0x2419BC0", Offset = "0x24187C0", VA = "0x182419BC0")]
			public StateBean()
			{
			}

			// Token: 0x0403A070 RID: 237680
			[Token(Token = "0x403A070")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3StageListProperty property;

			// Token: 0x0403A071 RID: 237681
			[Token(Token = "0x403A071")]
			[FieldOffset(Offset = "0x18")]
			public string currStageId;

			// Token: 0x0403A072 RID: 237682
			[Token(Token = "0x403A072")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
