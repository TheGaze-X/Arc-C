using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CFC RID: 23804
	[Token(Token = "0x2005CFC")]
	public class ClimbTowerEntryState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06022768 RID: 141160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022768")]
		[Address(RVA = "0x1D057C0", Offset = "0x1D043C0", VA = "0x181D057C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022769 RID: 141161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022769")]
		[Address(RVA = "0x1D04460", Offset = "0x1D03060", VA = "0x181D04460", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602276A RID: 141162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602276A")]
		[Address(RVA = "0x1D04BC0", Offset = "0x1D037C0", VA = "0x181D04BC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602276B RID: 141163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602276B")]
		[Address(RVA = "0x1D05110", Offset = "0x1D03D10", VA = "0x181D05110", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602276C RID: 141164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602276C")]
		[Address(RVA = "0x1D050A0", Offset = "0x1D03CA0", VA = "0x181D050A0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0602276D RID: 141165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602276D")]
		[Address(RVA = "0x1D04F60", Offset = "0x1D03B60", VA = "0x181D04F60", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602276E RID: 141166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602276E")]
		[Address(RVA = "0x1D05560", Offset = "0x1D04160", VA = "0x181D05560", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602276F RID: 141167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602276F")]
		[Address(RVA = "0x1D06750", Offset = "0x1D05350", VA = "0x181D06750")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x06022770 RID: 141168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022770")]
		[Address(RVA = "0x1D06800", Offset = "0x1D05400", VA = "0x181D06800")]
		private void _RouteToSweepEndingState(IStateBean sb)
		{
		}

		// Token: 0x06022771 RID: 141169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022771")]
		[Address(RVA = "0x1D06A50", Offset = "0x1D05650", VA = "0x181D06A50")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x06022772 RID: 141170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022772")]
		[Address(RVA = "0x1D069A0", Offset = "0x1D055A0", VA = "0x181D069A0")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x06022773 RID: 141171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022773")]
		[Address(RVA = "0x1D06B80", Offset = "0x1D05780", VA = "0x181D06B80")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x06022774 RID: 141172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022774")]
		[Address(RVA = "0x1D04FE0", Offset = "0x1D03BE0", VA = "0x181D04FE0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022775 RID: 141173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022775")]
		[Address(RVA = "0x1D04AF0", Offset = "0x1D036F0", VA = "0x181D04AF0")]
		public void OnBtnRewardClicked()
		{
		}

		// Token: 0x06022776 RID: 141174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022776")]
		[Address(RVA = "0x1D04A20", Offset = "0x1D03620", VA = "0x181D04A20")]
		public void OnBtnLevelPreviewClicked()
		{
		}

		// Token: 0x06022777 RID: 141175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022777")]
		[Address(RVA = "0x1D044C0", Offset = "0x1D030C0", VA = "0x181D044C0")]
		public void OnBtnCreateGameClicked()
		{
		}

		// Token: 0x06022778 RID: 141176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022778")]
		[Address(RVA = "0x1D05AB0", Offset = "0x1D046B0", VA = "0x181D05AB0")]
		private void _OnBtnCancelSweep()
		{
		}

		// Token: 0x06022779 RID: 141177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022779")]
		[Address(RVA = "0x1D05C80", Offset = "0x1D04880", VA = "0x181D05C80")]
		private void _OnBtnStartSweep()
		{
		}

		// Token: 0x0602277A RID: 141178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602277A")]
		[Address(RVA = "0x1D061F0", Offset = "0x1D04DF0", VA = "0x181D061F0")]
		private void _OnSwitchMode()
		{
		}

		// Token: 0x0602277B RID: 141179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602277B")]
		[Address(RVA = "0x1D06490", Offset = "0x1D05090", VA = "0x181D06490")]
		private void _OnSwitchSweep()
		{
		}

		// Token: 0x0602277C RID: 141180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602277C")]
		[Address(RVA = "0x1D068E0", Offset = "0x1D054E0", VA = "0x181D068E0")]
		private void _ShowRewardDetail()
		{
		}

		// Token: 0x0602277D RID: 141181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602277D")]
		[Address(RVA = "0x1D06C30", Offset = "0x1D05830", VA = "0x181D06C30")]
		public ClimbTowerEntryState()
		{
		}

		// Token: 0x0602277F RID: 141183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602277F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022780 RID: 141184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022780")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06022781 RID: 141185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022781")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06022782 RID: 141186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022782")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06022783 RID: 141187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022783")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F607 RID: 194055
		[Token(Token = "0x402F607")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerTowerEntryView _towerEntryView;

		// Token: 0x0402F608 RID: 194056
		[Token(Token = "0x402F608")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402F609 RID: 194057
		[Token(Token = "0x402F609")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Reward")]
		private RectTransform _transRewardHolder;

		// Token: 0x0402F60A RID: 194058
		[Token(Token = "0x402F60A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Reward")]
		private ClimbTowerItemRewardView _rewardPrefab;

		// Token: 0x0402F60B RID: 194059
		[Token(Token = "0x402F60B")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0402F60C RID: 194060
		[Token(Token = "0x402F60C")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerMenuAdapter m_menuAdapter;

		// Token: 0x0402F60D RID: 194061
		[Token(Token = "0x402F60D")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402F60E RID: 194062
		[Token(Token = "0x402F60E")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerItemRewardView m_rewardView;

		// Token: 0x0402F60F RID: 194063
		[Token(Token = "0x402F60F")]
		[FieldOffset(Offset = "0xB0")]
		private ClimbTowerSweepResponse m_cachedSweepRes;

		// Token: 0x0402F610 RID: 194064
		[Token(Token = "0x402F610")]
		[NonSerialized]
		public const int START_SWEEP = 0;

		// Token: 0x0402F611 RID: 194065
		[Token(Token = "0x402F611")]
		[NonSerialized]
		public const int CANCEL_SWEEP = 1;

		// Token: 0x0402F612 RID: 194066
		[Token(Token = "0x402F612")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F613 RID: 194067
		[Token(Token = "0x402F613")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F614 RID: 194068
		[Token(Token = "0x402F614")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F615 RID: 194069
		[Token(Token = "0x402F615")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0402F616 RID: 194070
		[Token(Token = "0x402F616")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F617 RID: 194071
		[Token(Token = "0x402F617")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402F618 RID: 194072
		[Token(Token = "0x402F618")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F619 RID: 194073
		[Token(Token = "0x402F619")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x0402F61A RID: 194074
		[Token(Token = "0x402F61A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RouteToSweepEndingState;

		// Token: 0x0402F61B RID: 194075
		[Token(Token = "0x402F61B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402F61C RID: 194076
		[Token(Token = "0x402F61C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402F61D RID: 194077
		[Token(Token = "0x402F61D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0402F61E RID: 194078
		[Token(Token = "0x402F61E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402F61F RID: 194079
		[Token(Token = "0x402F61F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBtnRewardClicked;

		// Token: 0x0402F620 RID: 194080
		[Token(Token = "0x402F620")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBtnLevelPreviewClicked;

		// Token: 0x0402F621 RID: 194081
		[Token(Token = "0x402F621")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBtnCreateGameClicked;

		// Token: 0x0402F622 RID: 194082
		[Token(Token = "0x402F622")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnBtnCancelSweep;

		// Token: 0x0402F623 RID: 194083
		[Token(Token = "0x402F623")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBtnStartSweep;

		// Token: 0x0402F624 RID: 194084
		[Token(Token = "0x402F624")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSwitchMode;

		// Token: 0x0402F625 RID: 194085
		[Token(Token = "0x402F625")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnSwitchSweep;

		// Token: 0x0402F626 RID: 194086
		[Token(Token = "0x402F626")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ShowRewardDetail;

		// Token: 0x0402F627 RID: 194087
		[Token(Token = "0x402F627")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
