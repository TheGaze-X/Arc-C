using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005057 RID: 20567
	[Token(Token = "0x2005057")]
	public class EnemyDuelRoomState : UIPopupState, IValueMsgReceiver, IPopupCustomActive
	{
		// Token: 0x0601E7C3 RID: 124867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E7C3")]
		[Address(RVA = "0x1831010", Offset = "0x182FC10", VA = "0x181831010", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E7C4 RID: 124868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7C4")]
		[Address(RVA = "0x1831300", Offset = "0x182FF00", VA = "0x181831300", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E7C5 RID: 124869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E7C5")]
		[Address(RVA = "0x1831D70", Offset = "0x1830970", VA = "0x181831D70", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E7C6 RID: 124870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E7C6")]
		[Address(RVA = "0x1831070", Offset = "0x182FC70", VA = "0x181831070", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E7C7 RID: 124871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7C7")]
		[Address(RVA = "0x1831EB0", Offset = "0x1830AB0", VA = "0x181831EB0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E7C8 RID: 124872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7C8")]
		[Address(RVA = "0x18311B0", Offset = "0x182FDB0", VA = "0x1818311B0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E7C9 RID: 124873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7C9")]
		[Address(RVA = "0x18318C0", Offset = "0x18304C0", VA = "0x1818318C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601E7CA RID: 124874 RVA: 0x000AE948 File Offset: 0x000ACB48
		[Token(Token = "0x601E7CA")]
		[Address(RVA = "0x18306C0", Offset = "0x182F2C0", VA = "0x1818306C0", Slot = "30")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601E7CB RID: 124875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7CB")]
		[Address(RVA = "0x1832050", Offset = "0x1830C50", VA = "0x181832050")]
		private void Update()
		{
		}

		// Token: 0x0601E7CC RID: 124876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7CC")]
		[Address(RVA = "0x18312A0", Offset = "0x182FEA0", VA = "0x1818312A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601E7CD RID: 124877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7CD")]
		[Address(RVA = "0x1833350", Offset = "0x1831F50", VA = "0x181833350")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E7CE RID: 124878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7CE")]
		[Address(RVA = "0x18337B0", Offset = "0x18323B0", VA = "0x1818337B0")]
		private void _UpdatePingStr(int ping, List<ActivityEnemyDuelConstData.PingCond> pingConds)
		{
		}

		// Token: 0x0601E7CF RID: 124879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7CF")]
		[Address(RVA = "0x1833470", Offset = "0x1832070", VA = "0x181833470")]
		private void _RegisterEventIfNeed()
		{
		}

		// Token: 0x0601E7D0 RID: 124880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D0")]
		[Address(RVA = "0x1833610", Offset = "0x1832210", VA = "0x181833610")]
		private void _ReleaseEventIfNeed()
		{
		}

		// Token: 0x0601E7D1 RID: 124881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D1")]
		[Address(RVA = "0x1832FE0", Offset = "0x1831BE0", VA = "0x181832FE0")]
		private void _HandleTeamChanged(object arg)
		{
		}

		// Token: 0x0601E7D2 RID: 124882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D2")]
		[Address(RVA = "0x1832C70", Offset = "0x1831870", VA = "0x181832C70")]
		private void _HandleGetNameCard(object arg)
		{
		}

		// Token: 0x0601E7D3 RID: 124883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D3")]
		[Address(RVA = "0x18332C0", Offset = "0x1831EC0", VA = "0x1818332C0")]
		private void _HandleTeamLeave(object arg)
		{
		}

		// Token: 0x0601E7D4 RID: 124884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D4")]
		[Address(RVA = "0x1833200", Offset = "0x1831E00", VA = "0x181833200")]
		private void _HandleTeamDisconnectException(object arg)
		{
		}

		// Token: 0x0601E7D5 RID: 124885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E7D5")]
		[Address(RVA = "0x1832300", Offset = "0x1830F00", VA = "0x181832300")]
		private IEnumerator _EnsureBackToRoomCoroutine(bool thenGotoBattleCd)
		{
			return null;
		}

		// Token: 0x0601E7D6 RID: 124886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D6")]
		[Address(RVA = "0x1830E60", Offset = "0x182FA60", VA = "0x181830E60")]
		public void EventOnStartBattle()
		{
		}

		// Token: 0x0601E7D7 RID: 124887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D7")]
		[Address(RVA = "0x1830B60", Offset = "0x182F760", VA = "0x181830B60")]
		public void EventOnLeave()
		{
		}

		// Token: 0x0601E7D8 RID: 124888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D8")]
		[Address(RVA = "0x1830980", Offset = "0x182F580", VA = "0x181830980")]
		public void EventOnCopyTeamID()
		{
		}

		// Token: 0x0601E7D9 RID: 124889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7D9")]
		[Address(RVA = "0x1830730", Offset = "0x182F330", VA = "0x181830730")]
		public void EventOnClickBlank()
		{
		}

		// Token: 0x0601E7DA RID: 124890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7DA")]
		[Address(RVA = "0x18307F0", Offset = "0x182F3F0", VA = "0x1818307F0")]
		public void EventOnClickNpcToggle()
		{
		}

		// Token: 0x0601E7DB RID: 124891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7DB")]
		[Address(RVA = "0x1831920", Offset = "0x1830520", VA = "0x181831920", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E7DC RID: 124892 RVA: 0x000AE960 File Offset: 0x000ACB60
		[Token(Token = "0x601E7DC")]
		[Address(RVA = "0x18338E0", Offset = "0x18324E0", VA = "0x1818338E0")]
		private bool _ValidatePlayerCardOption(int idx, out EnemyDuelPrepareRoomPlayerCardViewModel playerCardViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601E7DD RID: 124893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7DD")]
		[Address(RVA = "0x18326C0", Offset = "0x18312C0", VA = "0x1818326C0")]
		private void _EventOnCheckAvatar(int idx)
		{
		}

		// Token: 0x0601E7DE RID: 124894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7DE")]
		[Address(RVA = "0x18328B0", Offset = "0x18314B0", VA = "0x1818328B0")]
		private void _EventOnCheckNameCard(int idx)
		{
		}

		// Token: 0x0601E7DF RID: 124895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7DF")]
		[Address(RVA = "0x18323C0", Offset = "0x1830FC0", VA = "0x1818323C0")]
		private void _EventOnAddFriend(int idx)
		{
		}

		// Token: 0x0601E7E0 RID: 124896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7E0")]
		[Address(RVA = "0x1832A70", Offset = "0x1831670", VA = "0x181832A70")]
		private void _EventOnKick(int idx)
		{
		}

		// Token: 0x0601E7E1 RID: 124897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7E1")]
		[Address(RVA = "0x1833A20", Offset = "0x1832620", VA = "0x181833A20")]
		public EnemyDuelRoomState()
		{
		}

		// Token: 0x0601E7E3 RID: 124899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7E3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E7E4 RID: 124900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7E4")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04028D58 RID: 167256
		[Token(Token = "0x4028D58")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EnemyDuelPrepareRoomView _view;

		// Token: 0x04028D59 RID: 167257
		[Token(Token = "0x4028D59")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _ping;

		// Token: 0x04028D5A RID: 167258
		[Token(Token = "0x4028D5A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x04028D5B RID: 167259
		[Token(Token = "0x4028D5B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _lostConnectionPanel;

		// Token: 0x04028D5C RID: 167260
		[Token(Token = "0x4028D5C")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04028D5D RID: 167261
		[Token(Token = "0x4028D5D")]
		[FieldOffset(Offset = "0x81")]
		private bool m_eventRegistered;

		// Token: 0x04028D5E RID: 167262
		[Token(Token = "0x4028D5E")]
		[FieldOffset(Offset = "0x82")]
		private bool m_hasAlertDisconnect;

		// Token: 0x04028D5F RID: 167263
		[Token(Token = "0x4028D5F")]
		[FieldOffset(Offset = "0x84")]
		private int m_entranceDialogInst;

		// Token: 0x04028D60 RID: 167264
		[Token(Token = "0x4028D60")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_lostConnectionFade;

		// Token: 0x04028D61 RID: 167265
		[Token(Token = "0x4028D61")]
		[FieldOffset(Offset = "0x90")]
		private EnemyDuelTeamDisconnectReason m_cachedReason;

		// Token: 0x04028D62 RID: 167266
		[Token(Token = "0x4028D62")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelPrepareRoomStateBean m_stateBean;

		// Token: 0x04028D63 RID: 167267
		[Token(Token = "0x4028D63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028D64 RID: 167268
		[Token(Token = "0x4028D64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028D65 RID: 167269
		[Token(Token = "0x4028D65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04028D66 RID: 167270
		[Token(Token = "0x4028D66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04028D67 RID: 167271
		[Token(Token = "0x4028D67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04028D68 RID: 167272
		[Token(Token = "0x4028D68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04028D69 RID: 167273
		[Token(Token = "0x4028D69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04028D6A RID: 167274
		[Token(Token = "0x4028D6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04028D6B RID: 167275
		[Token(Token = "0x4028D6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04028D6C RID: 167276
		[Token(Token = "0x4028D6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04028D6D RID: 167277
		[Token(Token = "0x4028D6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028D6E RID: 167278
		[Token(Token = "0x4028D6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdatePingStr;

		// Token: 0x04028D6F RID: 167279
		[Token(Token = "0x4028D6F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RegisterEventIfNeed;

		// Token: 0x04028D70 RID: 167280
		[Token(Token = "0x4028D70")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReleaseEventIfNeed;

		// Token: 0x04028D71 RID: 167281
		[Token(Token = "0x4028D71")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleTeamChanged;

		// Token: 0x04028D72 RID: 167282
		[Token(Token = "0x4028D72")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleGetNameCard;

		// Token: 0x04028D73 RID: 167283
		[Token(Token = "0x4028D73")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleTeamLeave;

		// Token: 0x04028D74 RID: 167284
		[Token(Token = "0x4028D74")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleTeamDisconnectException;

		// Token: 0x04028D75 RID: 167285
		[Token(Token = "0x4028D75")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EnsureBackToRoomCoroutine;

		// Token: 0x04028D76 RID: 167286
		[Token(Token = "0x4028D76")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnStartBattle;

		// Token: 0x04028D77 RID: 167287
		[Token(Token = "0x4028D77")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnLeave;

		// Token: 0x04028D78 RID: 167288
		[Token(Token = "0x4028D78")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnCopyTeamID;

		// Token: 0x04028D79 RID: 167289
		[Token(Token = "0x4028D79")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnClickBlank;

		// Token: 0x04028D7A RID: 167290
		[Token(Token = "0x4028D7A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnClickNpcToggle;

		// Token: 0x04028D7B RID: 167291
		[Token(Token = "0x4028D7B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028D7C RID: 167292
		[Token(Token = "0x4028D7C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ValidatePlayerCardOption;

		// Token: 0x04028D7D RID: 167293
		[Token(Token = "0x4028D7D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EventOnCheckAvatar;

		// Token: 0x04028D7E RID: 167294
		[Token(Token = "0x4028D7E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__EventOnCheckNameCard;

		// Token: 0x04028D7F RID: 167295
		[Token(Token = "0x4028D7F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EventOnAddFriend;

		// Token: 0x04028D80 RID: 167296
		[Token(Token = "0x4028D80")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__EventOnKick;

		// Token: 0x04028D81 RID: 167297
		[Token(Token = "0x4028D81")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005058 RID: 20568
		[Token(Token = "0x2005058")]
		public static class Event
		{
			// Token: 0x04028D82 RID: 167298
			[Token(Token = "0x4028D82")]
			public const int CHECK_AVATAR = 1;

			// Token: 0x04028D83 RID: 167299
			[Token(Token = "0x4028D83")]
			public const int CHECK_NAMECARD = 2;

			// Token: 0x04028D84 RID: 167300
			[Token(Token = "0x4028D84")]
			public const int ADD_FRIEND = 3;

			// Token: 0x04028D85 RID: 167301
			[Token(Token = "0x4028D85")]
			public const int KICK = 4;
		}
	}
}
