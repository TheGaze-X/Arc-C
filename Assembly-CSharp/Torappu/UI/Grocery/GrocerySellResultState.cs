using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D12 RID: 19730
	[Token(Token = "0x2004D12")]
	public class GrocerySellResultState : State, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601D905 RID: 121093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D905")]
		[Address(RVA = "0x17192C0", Offset = "0x1717EC0", VA = "0x1817192C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D906 RID: 121094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D906")]
		[Address(RVA = "0x1719320", Offset = "0x1717F20", VA = "0x181719320", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D907 RID: 121095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D907")]
		[Address(RVA = "0x1719710", Offset = "0x1718310", VA = "0x181719710", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601D908 RID: 121096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D908")]
		[Address(RVA = "0x1719B60", Offset = "0x1718760", VA = "0x181719B60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D909 RID: 121097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D909")]
		[Address(RVA = "0x171A050", Offset = "0x1718C50", VA = "0x18171A050")]
		private void _OnNextClick()
		{
		}

		// Token: 0x0601D90A RID: 121098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D90A")]
		[Address(RVA = "0x1719D70", Offset = "0x1718970", VA = "0x181719D70")]
		private void _OnCloseIncomingPanelClick()
		{
		}

		// Token: 0x0601D90B RID: 121099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D90B")]
		[Address(RVA = "0x17197D0", Offset = "0x17183D0", VA = "0x1817197D0")]
		private void _HandleSettleResponse(GrocerySaleSettleResponse response)
		{
		}

		// Token: 0x0601D90C RID: 121100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D90C")]
		[Address(RVA = "0x171A5D0", Offset = "0x17191D0", VA = "0x18171A5D0")]
		private IEnumerator _TryDismissSelf()
		{
			return null;
		}

		// Token: 0x0601D90D RID: 121101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D90D")]
		[Address(RVA = "0x171A3C0", Offset = "0x1718FC0", VA = "0x18171A3C0")]
		private IEnumerator _PlayDiagramTween()
		{
			return null;
		}

		// Token: 0x0601D90E RID: 121102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D90E")]
		[Address(RVA = "0x171A470", Offset = "0x1719070", VA = "0x18171A470")]
		private IEnumerator _PlayIncomeTextTween()
		{
			return null;
		}

		// Token: 0x0601D90F RID: 121103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D90F")]
		[Address(RVA = "0x171A520", Offset = "0x1719120", VA = "0x18171A520")]
		private IEnumerator _PlayIncomingLogPanelTextTweenWithDelay()
		{
			return null;
		}

		// Token: 0x0601D910 RID: 121104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D910")]
		[Address(RVA = "0x171A680", Offset = "0x1719280", VA = "0x18171A680")]
		public GrocerySellResultState()
		{
		}

		// Token: 0x0601D911 RID: 121105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D911")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402709A RID: 159898
		[Token(Token = "0x402709A")]
		[NonSerialized]
		public const int ON_MSG_NEXT_BUTTON_CLICKED = 1;

		// Token: 0x0402709B RID: 159899
		[Token(Token = "0x402709B")]
		[NonSerialized]
		public const int ON_MSG_CLOCK_LOG_PANEL_BUTTON_CLICKED = 2;

		// Token: 0x0402709C RID: 159900
		[Token(Token = "0x402709C")]
		private const string STATE_ENTER_ANIM_NAME = "grocery_sell_result_entry";

		// Token: 0x0402709D RID: 159901
		[Token(Token = "0x402709D")]
		private const string INCOMING_LOG_ENTER_ANIM_NAME = "grocery_incoming_log_entry";

		// Token: 0x0402709E RID: 159902
		[Token(Token = "0x402709E")]
		private const float DIAGRAM_TWEEN_DURATION = 1.5f;

		// Token: 0x0402709F RID: 159903
		[Token(Token = "0x402709F")]
		private const float DIAGRAM_TWEEN_DELAY = 0.4f;

		// Token: 0x040270A0 RID: 159904
		[Token(Token = "0x40270A0")]
		private const float DIAGRAM_TWEEN_APPEAR_DELAY = 0.2f;

		// Token: 0x040270A1 RID: 159905
		[Token(Token = "0x40270A1")]
		private const float INCOME_TWEEN_DURATION = 1f;

		// Token: 0x040270A2 RID: 159906
		[Token(Token = "0x40270A2")]
		private const float INCOME_TWEEN_DELAY = 1.5f;

		// Token: 0x040270A3 RID: 159907
		[Token(Token = "0x40270A3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GrocerySellResultView _sellResultView;

		// Token: 0x040270A4 RID: 159908
		[Token(Token = "0x40270A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GrocerySellIncomingLogView _incomingLogPanelViewPrefab;

		// Token: 0x040270A5 RID: 159909
		[Token(Token = "0x40270A5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _incomingLogParent;

		// Token: 0x040270A6 RID: 159910
		[Token(Token = "0x40270A6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _stateEnterAnim;

		// Token: 0x040270A7 RID: 159911
		[Token(Token = "0x40270A7")]
		[FieldOffset(Offset = "0x70")]
		private GrocerySellResultStateBean m_stateBean;

		// Token: 0x040270A8 RID: 159912
		[Token(Token = "0x40270A8")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x040270A9 RID: 159913
		[Token(Token = "0x40270A9")]
		[FieldOffset(Offset = "0x80")]
		private string m_actId;

		// Token: 0x040270AA RID: 159914
		[Token(Token = "0x40270AA")]
		[FieldOffset(Offset = "0x88")]
		private PlayerActivity.PlayerAct27SideActivity.SellGoodState m_sellGoodState;

		// Token: 0x040270AB RID: 159915
		[Token(Token = "0x40270AB")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_stateEnterTween;

		// Token: 0x040270AC RID: 159916
		[Token(Token = "0x40270AC")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_incomingLogEnterTween;

		// Token: 0x040270AD RID: 159917
		[Token(Token = "0x40270AD")]
		[FieldOffset(Offset = "0xA0")]
		private GrocerySellIncomingLogView m_incomingLogPanelView;

		// Token: 0x040270AE RID: 159918
		[Token(Token = "0x40270AE")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationWrapper m_incomingLogEnterAnim;

		// Token: 0x040270AF RID: 159919
		[Token(Token = "0x40270AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040270B0 RID: 159920
		[Token(Token = "0x40270B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040270B1 RID: 159921
		[Token(Token = "0x40270B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040270B2 RID: 159922
		[Token(Token = "0x40270B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040270B3 RID: 159923
		[Token(Token = "0x40270B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnNextClick;

		// Token: 0x040270B4 RID: 159924
		[Token(Token = "0x40270B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCloseIncomingPanelClick;

		// Token: 0x040270B5 RID: 159925
		[Token(Token = "0x40270B5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleSettleResponse;

		// Token: 0x040270B6 RID: 159926
		[Token(Token = "0x40270B6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryDismissSelf;

		// Token: 0x040270B7 RID: 159927
		[Token(Token = "0x40270B7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayDiagramTween;

		// Token: 0x040270B8 RID: 159928
		[Token(Token = "0x40270B8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayIncomeTextTween;

		// Token: 0x040270B9 RID: 159929
		[Token(Token = "0x40270B9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayIncomingLogPanelTextTweenWithDelay;

		// Token: 0x040270BA RID: 159930
		[Token(Token = "0x40270BA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
