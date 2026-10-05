using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004810 RID: 18448
	[Token(Token = "0x2004810")]
	public class MonopolyGameState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0601BE4A RID: 114250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BE4A")]
		[Address(RVA = "0x153B2D0", Offset = "0x1539ED0", VA = "0x18153B2D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BE4B RID: 114251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE4B")]
		[Address(RVA = "0x153B770", Offset = "0x153A370", VA = "0x18153B770", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BE4C RID: 114252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE4C")]
		[Address(RVA = "0x153BE80", Offset = "0x153AA80", VA = "0x18153BE80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601BE4D RID: 114253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE4D")]
		[Address(RVA = "0x153CF00", Offset = "0x153BB00", VA = "0x18153CF00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BE4E RID: 114254 RVA: 0x000A6908 File Offset: 0x000A4B08
		[Token(Token = "0x601BE4E")]
		[Address(RVA = "0x153E190", Offset = "0x153CD90", VA = "0x18153E190")]
		private bool _TriggerTutorialAVG()
		{
			return default(bool);
		}

		// Token: 0x0601BE4F RID: 114255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE4F")]
		[Address(RVA = "0x153D120", Offset = "0x153BD20", VA = "0x18153D120")]
		private void _OnExitClick()
		{
		}

		// Token: 0x0601BE50 RID: 114256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE50")]
		[Address(RVA = "0x153BBB0", Offset = "0x153A7B0", VA = "0x18153BBB0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601BE51 RID: 114257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE51")]
		[Address(RVA = "0x153C1A0", Offset = "0x153ADA0", VA = "0x18153C1A0")]
		private void _EventOnCardClick(long intVal)
		{
		}

		// Token: 0x0601BE52 RID: 114258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE52")]
		[Address(RVA = "0x153C870", Offset = "0x153B470", VA = "0x18153C870")]
		private void _EventOnMoveBtnClick()
		{
		}

		// Token: 0x0601BE53 RID: 114259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE53")]
		[Address(RVA = "0x153C5C0", Offset = "0x153B1C0", VA = "0x18153C5C0")]
		private void _EventOnMiningBtnClick()
		{
		}

		// Token: 0x0601BE54 RID: 114260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE54")]
		[Address(RVA = "0x153D940", Offset = "0x153C540", VA = "0x18153D940")]
		private void _RefreshWithUpdateAnim(MonopolyEventType eventType, MonopolyCommonGameEventResponse response)
		{
		}

		// Token: 0x0601BE55 RID: 114261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BE55")]
		[Address(RVA = "0x153D060", Offset = "0x153BC60", VA = "0x18153D060")]
		private IEnumerator _LockEventForSeconds(float second)
		{
			return null;
		}

		// Token: 0x0601BE56 RID: 114262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE56")]
		[Address(RVA = "0x153C3E0", Offset = "0x153AFE0", VA = "0x18153C3E0")]
		private void _EventOnEndRoundBtnClick()
		{
		}

		// Token: 0x0601BE57 RID: 114263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE57")]
		[Address(RVA = "0x153DCD0", Offset = "0x153C8D0", VA = "0x18153DCD0")]
		private void _SendEndRoundRequest()
		{
		}

		// Token: 0x0601BE58 RID: 114264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE58")]
		[Address(RVA = "0x153DF30", Offset = "0x153CB30", VA = "0x18153DF30")]
		private void _SendSettleRequest()
		{
		}

		// Token: 0x0601BE59 RID: 114265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE59")]
		[Address(RVA = "0x153D240", Offset = "0x153BE40", VA = "0x18153D240")]
		private void _OnSettleProceed(MonopolySettleGameResponse resp)
		{
		}

		// Token: 0x0601BE5A RID: 114266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE5A")]
		[Address(RVA = "0x153D420", Offset = "0x153C020", VA = "0x18153D420")]
		private void _OpenEndRoundConfirmDialog()
		{
		}

		// Token: 0x0601BE5B RID: 114267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE5B")]
		[Address(RVA = "0x153D6B0", Offset = "0x153C2B0", VA = "0x18153D6B0")]
		private void _OpenSettleConfirmDialog()
		{
		}

		// Token: 0x0601BE5C RID: 114268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE5C")]
		[Address(RVA = "0x153B330", Offset = "0x1539F30", VA = "0x18153B330", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601BE5D RID: 114269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BE5D")]
		[Address(RVA = "0x153CE50", Offset = "0x153BA50", VA = "0x18153CE50")]
		private IEnumerator _ExitWhenStable()
		{
			return null;
		}

		// Token: 0x0601BE5E RID: 114270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE5E")]
		[Address(RVA = "0x153CBD0", Offset = "0x153B7D0", VA = "0x18153CBD0")]
		private void _EventOnNotifyCannotMove()
		{
		}

		// Token: 0x0601BE5F RID: 114271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE5F")]
		[Address(RVA = "0x153CB20", Offset = "0x153B720", VA = "0x18153CB20")]
		private void _EventOnNotifyCannotMining(long intVal)
		{
		}

		// Token: 0x0601BE60 RID: 114272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE60")]
		[Address(RVA = "0x153CC50", Offset = "0x153B850", VA = "0x18153CC50")]
		private void _EventOnTopBuffClick()
		{
		}

		// Token: 0x0601BE61 RID: 114273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE61")]
		[Address(RVA = "0x153E2B0", Offset = "0x153CEB0", VA = "0x18153E2B0")]
		public MonopolyGameState()
		{
		}

		// Token: 0x0601BE65 RID: 114277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE65")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601BE66 RID: 114278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE66")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040245B0 RID: 148912
		[Token(Token = "0x40245B0")]
		private const string MONOPOLY_GAME_TUTORIAL_KEY = "monopoly_{0}";

		// Token: 0x040245B1 RID: 148913
		[Token(Token = "0x40245B1")]
		[NonSerialized]
		public const int EVENT_ON_CARD_CLICK = 0;

		// Token: 0x040245B2 RID: 148914
		[Token(Token = "0x40245B2")]
		[NonSerialized]
		public const int EVENT_ON_MOVE_BTN_CLICK = 1;

		// Token: 0x040245B3 RID: 148915
		[Token(Token = "0x40245B3")]
		[NonSerialized]
		public const int EVENT_ON_MINING_BTN_CLICK = 2;

		// Token: 0x040245B4 RID: 148916
		[Token(Token = "0x40245B4")]
		[NonSerialized]
		public const int EVENT_ON_END_ROUND_BTN_CLICK = 3;

		// Token: 0x040245B5 RID: 148917
		[Token(Token = "0x40245B5")]
		[NonSerialized]
		public const int EVENT_ON_UNSELECT_CARD = 4;

		// Token: 0x040245B6 RID: 148918
		[Token(Token = "0x40245B6")]
		[NonSerialized]
		public const int EVENT_ON_NOTIFY_CANNOT_MOVE = 5;

		// Token: 0x040245B7 RID: 148919
		[Token(Token = "0x40245B7")]
		[NonSerialized]
		public const int EVENT_ON_NOTIFY_CANNOT_MINING = 6;

		// Token: 0x040245B8 RID: 148920
		[Token(Token = "0x40245B8")]
		[NonSerialized]
		public const int EVENT_ON_TOP_BUFF_CLICK = 10;

		// Token: 0x040245B9 RID: 148921
		[Token(Token = "0x40245B9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MonopolyGameView _view;

		// Token: 0x040245BA RID: 148922
		[Token(Token = "0x40245BA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040245BB RID: 148923
		[Token(Token = "0x40245BB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MonopolyCommonTopMenu _topMenuPrefab;

		// Token: 0x040245BC RID: 148924
		[Token(Token = "0x40245BC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _lockTimeAfterPlayerAction;

		// Token: 0x040245BD RID: 148925
		[Token(Token = "0x40245BD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040245BE RID: 148926
		[Token(Token = "0x40245BE")]
		[FieldOffset(Offset = "0xA0")]
		private MonopolyGameStateBean m_stateBean;

		// Token: 0x040245BF RID: 148927
		[Token(Token = "0x40245BF")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x040245C0 RID: 148928
		[Token(Token = "0x40245C0")]
		[FieldOffset(Offset = "0xB0")]
		private string m_actId;

		// Token: 0x040245C1 RID: 148929
		[Token(Token = "0x40245C1")]
		[FieldOffset(Offset = "0xB8")]
		private int m_endRoundConfirmDialogInstId;

		// Token: 0x040245C2 RID: 148930
		[Token(Token = "0x40245C2")]
		[FieldOffset(Offset = "0xBC")]
		private int m_settleConfirmDialogInstId;

		// Token: 0x040245C3 RID: 148931
		[Token(Token = "0x40245C3")]
		[FieldOffset(Offset = "0xC0")]
		private int m_settleDialogInstId;

		// Token: 0x040245C4 RID: 148932
		[Token(Token = "0x40245C4")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_clickLock;

		// Token: 0x040245C5 RID: 148933
		[Token(Token = "0x40245C5")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_enterAnimTween;

		// Token: 0x040245C6 RID: 148934
		[Token(Token = "0x40245C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040245C7 RID: 148935
		[Token(Token = "0x40245C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040245C8 RID: 148936
		[Token(Token = "0x40245C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040245C9 RID: 148937
		[Token(Token = "0x40245C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040245CA RID: 148938
		[Token(Token = "0x40245CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x040245CB RID: 148939
		[Token(Token = "0x40245CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnExitClick;

		// Token: 0x040245CC RID: 148940
		[Token(Token = "0x40245CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040245CD RID: 148941
		[Token(Token = "0x40245CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnCardClick;

		// Token: 0x040245CE RID: 148942
		[Token(Token = "0x40245CE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnMoveBtnClick;

		// Token: 0x040245CF RID: 148943
		[Token(Token = "0x40245CF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnMiningBtnClick;

		// Token: 0x040245D0 RID: 148944
		[Token(Token = "0x40245D0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshWithUpdateAnim;

		// Token: 0x040245D1 RID: 148945
		[Token(Token = "0x40245D1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LockEventForSeconds;

		// Token: 0x040245D2 RID: 148946
		[Token(Token = "0x40245D2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnEndRoundBtnClick;

		// Token: 0x040245D3 RID: 148947
		[Token(Token = "0x40245D3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SendEndRoundRequest;

		// Token: 0x040245D4 RID: 148948
		[Token(Token = "0x40245D4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SendSettleRequest;

		// Token: 0x040245D5 RID: 148949
		[Token(Token = "0x40245D5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSettleProceed;

		// Token: 0x040245D6 RID: 148950
		[Token(Token = "0x40245D6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OpenEndRoundConfirmDialog;

		// Token: 0x040245D7 RID: 148951
		[Token(Token = "0x40245D7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OpenSettleConfirmDialog;

		// Token: 0x040245D8 RID: 148952
		[Token(Token = "0x40245D8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040245D9 RID: 148953
		[Token(Token = "0x40245D9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ExitWhenStable;

		// Token: 0x040245DA RID: 148954
		[Token(Token = "0x40245DA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnNotifyCannotMove;

		// Token: 0x040245DB RID: 148955
		[Token(Token = "0x40245DB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnNotifyCannotMining;

		// Token: 0x040245DC RID: 148956
		[Token(Token = "0x40245DC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnTopBuffClick;

		// Token: 0x040245DD RID: 148957
		[Token(Token = "0x40245DD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
