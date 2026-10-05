using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002745 RID: 10053
	[Token(Token = "0x2002745")]
	public class AutoChessGameStatus : IHotfixable
	{
		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x060105D7 RID: 67031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023A7")]
		public static AutoChessGameStatus instanceOrNull
		{
			[Token(Token = "0x60105D7")]
			[Address(RVA = "0x8186E0", Offset = "0x8172E0", VA = "0x1808186E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x060105D8 RID: 67032 RVA: 0x000639A8 File Offset: 0x00061BA8
		[Token(Token = "0x170023A8")]
		public bool inLoadingState
		{
			[Token(Token = "0x60105D8")]
			[Address(RVA = "0x818290", Offset = "0x816E90", VA = "0x180818290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x060105D9 RID: 67033 RVA: 0x000639C0 File Offset: 0x00061BC0
		[Token(Token = "0x170023A9")]
		public bool inBattleState
		{
			[Token(Token = "0x60105D9")]
			[Address(RVA = "0x817DA0", Offset = "0x8169A0", VA = "0x180817DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x060105DA RID: 67034 RVA: 0x000639D8 File Offset: 0x00061BD8
		[Token(Token = "0x170023AA")]
		public bool inBattleMainState
		{
			[Token(Token = "0x60105DA")]
			[Address(RVA = "0x817D30", Offset = "0x816930", VA = "0x180817D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x060105DB RID: 67035 RVA: 0x000639F0 File Offset: 0x00061BF0
		[Token(Token = "0x170023AB")]
		public bool inSelfBattleState
		{
			[Token(Token = "0x60105DB")]
			[Address(RVA = "0x8184F0", Offset = "0x8170F0", VA = "0x1808184F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x060105DC RID: 67036 RVA: 0x00063A08 File Offset: 0x00061C08
		[Token(Token = "0x170023AC")]
		public bool inHelpBattleState
		{
			[Token(Token = "0x60105DC")]
			[Address(RVA = "0x818160", Offset = "0x816D60", VA = "0x180818160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x060105DD RID: 67037 RVA: 0x00063A20 File Offset: 0x00061C20
		[Token(Token = "0x170023AD")]
		public bool inBossBattleState
		{
			[Token(Token = "0x60105DD")]
			[Address(RVA = "0x817EE0", Offset = "0x816AE0", VA = "0x180817EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x060105DE RID: 67038 RVA: 0x00063A38 File Offset: 0x00061C38
		[Token(Token = "0x170023AE")]
		public bool inBossPrepareWaiting
		{
			[Token(Token = "0x60105DE")]
			[Address(RVA = "0x817FA0", Offset = "0x816BA0", VA = "0x180817FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x060105DF RID: 67039 RVA: 0x00063A50 File Offset: 0x00061C50
		[Token(Token = "0x170023AF")]
		public bool inPrepareState
		{
			[Token(Token = "0x60105DF")]
			[Address(RVA = "0x818430", Offset = "0x817030", VA = "0x180818430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x060105E0 RID: 67040 RVA: 0x00063A68 File Offset: 0x00061C68
		[Token(Token = "0x170023B0")]
		public bool inSpPrepareState
		{
			[Token(Token = "0x60105E0")]
			[Address(RVA = "0x8185B0", Offset = "0x8171B0", VA = "0x1808185B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x060105E1 RID: 67041 RVA: 0x00063A80 File Offset: 0x00061C80
		[Token(Token = "0x170023B1")]
		public bool inMainPrepareState
		{
			[Token(Token = "0x60105E1")]
			[Address(RVA = "0x818350", Offset = "0x816F50", VA = "0x180818350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x060105E2 RID: 67042 RVA: 0x00063A98 File Offset: 0x00061C98
		[Token(Token = "0x170023B2")]
		public AutoChessGameStateType lastState
		{
			[Token(Token = "0x60105E2")]
			[Address(RVA = "0x818960", Offset = "0x817560", VA = "0x180818960")]
			get
			{
				return AutoChessGameStateType.NONE;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x060105E3 RID: 67043 RVA: 0x00063AB0 File Offset: 0x00061CB0
		[Token(Token = "0x170023B3")]
		public AutoChessGameStateType currentState
		{
			[Token(Token = "0x60105E3")]
			[Address(RVA = "0x817BD0", Offset = "0x8167D0", VA = "0x180817BD0")]
			get
			{
				return AutoChessGameStateType.NONE;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x060105E4 RID: 67044 RVA: 0x00063AC8 File Offset: 0x00061CC8
		[Token(Token = "0x170023B4")]
		public AutoChessGameStateType nextState
		{
			[Token(Token = "0x60105E4")]
			[Address(RVA = "0x818A40", Offset = "0x817640", VA = "0x180818A40")]
			get
			{
				return AutoChessGameStateType.NONE;
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x060105E5 RID: 67045 RVA: 0x00063AE0 File Offset: 0x00061CE0
		[Token(Token = "0x170023B5")]
		public AutoChessGameStatus.SubState currentSubState
		{
			[Token(Token = "0x60105E5")]
			[Address(RVA = "0x817C40", Offset = "0x816840", VA = "0x180817C40")]
			get
			{
				return AutoChessGameStatus.SubState.NONE;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x060105E6 RID: 67046 RVA: 0x00063AF8 File Offset: 0x00061CF8
		[Token(Token = "0x170023B6")]
		public bool inMainSubState
		{
			[Token(Token = "0x60105E6")]
			[Address(RVA = "0x8183C0", Offset = "0x816FC0", VA = "0x1808183C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x060105E7 RID: 67047 RVA: 0x00063B10 File Offset: 0x00061D10
		[Token(Token = "0x170023B7")]
		public bool inEndSubState
		{
			[Token(Token = "0x60105E7")]
			[Address(RVA = "0x818060", Offset = "0x816C60", VA = "0x180818060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x060105E8 RID: 67048 RVA: 0x00063B28 File Offset: 0x00061D28
		[Token(Token = "0x170023B8")]
		public bool inBattleWaiting
		{
			[Token(Token = "0x60105E8")]
			[Address(RVA = "0x817E20", Offset = "0x816A20", VA = "0x180817E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x060105E9 RID: 67049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023B9")]
		public AutoChessGameStatus.AutoChessGameStateMachine stateMachine
		{
			[Token(Token = "0x60105E9")]
			[Address(RVA = "0x818E40", Offset = "0x817A40", VA = "0x180818E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x060105EA RID: 67050 RVA: 0x00063B40 File Offset: 0x00061D40
		[Token(Token = "0x170023BA")]
		public bool shopOpened
		{
			[Token(Token = "0x60105EA")]
			[Address(RVA = "0x818BC0", Offset = "0x8177C0", VA = "0x180818BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x060105EB RID: 67051 RVA: 0x00063B58 File Offset: 0x00061D58
		[Token(Token = "0x170023BB")]
		public bool shopValid
		{
			[Token(Token = "0x60105EB")]
			[Address(RVA = "0x818DC0", Offset = "0x8179C0", VA = "0x180818DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x060105EC RID: 67052 RVA: 0x00063B70 File Offset: 0x00061D70
		[Token(Token = "0x170023BC")]
		public bool inUserInteract
		{
			[Token(Token = "0x60105EC")]
			[Address(RVA = "0x818670", Offset = "0x817270", VA = "0x180818670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x060105ED RID: 67053 RVA: 0x00063B88 File Offset: 0x00061D88
		[Token(Token = "0x170023BD")]
		public bool canDisplayAvatar
		{
			[Token(Token = "0x60105ED")]
			[Address(RVA = "0x817AD0", Offset = "0x8166D0", VA = "0x180817AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x060105EE RID: 67054 RVA: 0x00063BA0 File Offset: 0x00061DA0
		[Token(Token = "0x170023BE")]
		public bool characterMenuShowed
		{
			[Token(Token = "0x60105EE")]
			[Address(RVA = "0x817B60", Offset = "0x816760", VA = "0x180817B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x060105EF RID: 67055 RVA: 0x00063BB8 File Offset: 0x00061DB8
		[Token(Token = "0x170023BF")]
		public int replaceEquipCharInstId
		{
			[Token(Token = "0x60105EF")]
			[Address(RVA = "0x818AE0", Offset = "0x8176E0", VA = "0x180818AE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x060105F0 RID: 67056 RVA: 0x00063BD0 File Offset: 0x00061DD0
		[Token(Token = "0x170023C0")]
		public int replaceEquipInstId
		{
			[Token(Token = "0x60105F0")]
			[Address(RVA = "0x818B50", Offset = "0x817750", VA = "0x180818B50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x060105F1 RID: 67057 RVA: 0x00063BE8 File Offset: 0x00061DE8
		[Token(Token = "0x170023C1")]
		public bool isReqReplaceEquip
		{
			[Token(Token = "0x60105F1")]
			[Address(RVA = "0x818810", Offset = "0x817410", VA = "0x180818810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x060105F2 RID: 67058 RVA: 0x00063C00 File Offset: 0x00061E00
		[Token(Token = "0x170023C2")]
		public bool inEnemyPreview
		{
			[Token(Token = "0x60105F2")]
			[Address(RVA = "0x8180E0", Offset = "0x816CE0", VA = "0x1808180E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x060105F3 RID: 67059 RVA: 0x00063C18 File Offset: 0x00061E18
		[Token(Token = "0x170023C3")]
		public bool inHudTipDisplay
		{
			[Token(Token = "0x60105F3")]
			[Address(RVA = "0x818220", Offset = "0x816E20", VA = "0x180818220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x060105F4 RID: 67060 RVA: 0x00063C30 File Offset: 0x00061E30
		[Token(Token = "0x170023C4")]
		public AutoChessGameStatus.AutoChessHUDTipDisplay hudTipDisplay
		{
			[Token(Token = "0x60105F4")]
			[Address(RVA = "0x817CB0", Offset = "0x8168B0", VA = "0x180817CB0")]
			get
			{
				return AutoChessGameStatus.AutoChessHUDTipDisplay.NONE;
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x060105F5 RID: 67061 RVA: 0x00063C48 File Offset: 0x00061E48
		[Token(Token = "0x170023C5")]
		public AutoChessGameStatus.AutoChessBattleMapLayer battleMapLayer
		{
			[Token(Token = "0x60105F5")]
			[Address(RVA = "0x817A60", Offset = "0x816660", VA = "0x180817A60")]
			get
			{
				return AutoChessGameStatus.AutoChessBattleMapLayer.START;
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x060105F6 RID: 67062 RVA: 0x00063C60 File Offset: 0x00061E60
		[Token(Token = "0x170023C6")]
		public bool isLeftMapLayer
		{
			[Token(Token = "0x60105F6")]
			[Address(RVA = "0x818750", Offset = "0x817350", VA = "0x180818750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x060105F7 RID: 67063 RVA: 0x00063C78 File Offset: 0x00061E78
		[Token(Token = "0x170023C7")]
		public bool isRightMapLayer
		{
			[Token(Token = "0x60105F7")]
			[Address(RVA = "0x8188A0", Offset = "0x8174A0", VA = "0x1808188A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x060105F8 RID: 67064 RVA: 0x00063C90 File Offset: 0x00061E90
		[Token(Token = "0x170023C8")]
		public AutoChessBattleShopSlot shopSelectedSlotId
		{
			[Token(Token = "0x60105F8")]
			[Address(RVA = "0x818D50", Offset = "0x817950", VA = "0x180818D50")]
			get
			{
				return default(AutoChessBattleShopSlot);
			}
		}

		// Token: 0x060105F9 RID: 67065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105F9")]
		[Address(RVA = "0x817590", Offset = "0x816190", VA = "0x180817590")]
		public void Start()
		{
		}

		// Token: 0x060105FA RID: 67066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105FA")]
		[Address(RVA = "0x816A30", Offset = "0x815630", VA = "0x180816A30")]
		public void Dispose()
		{
		}

		// Token: 0x060105FB RID: 67067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105FB")]
		[Address(RVA = "0x816C90", Offset = "0x815890", VA = "0x180816C90")]
		public void OnTick()
		{
		}

		// Token: 0x060105FC RID: 67068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105FC")]
		[Address(RVA = "0x817640", Offset = "0x816240", VA = "0x180817640")]
		public void UpdateState(AutoChessGameStateType state)
		{
		}

		// Token: 0x060105FD RID: 67069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105FD")]
		[Address(RVA = "0x816AE0", Offset = "0x8156E0", VA = "0x180816AE0")]
		public void MoveToNext()
		{
		}

		// Token: 0x060105FE RID: 67070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105FE")]
		[Address(RVA = "0x817340", Offset = "0x815F40", VA = "0x180817340")]
		public void ResetUIState()
		{
		}

		// Token: 0x060105FF RID: 67071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105FF")]
		[Address(RVA = "0x8172B0", Offset = "0x815EB0", VA = "0x1808172B0")]
		public void ResetUIStateKeepMapLayer()
		{
		}

		// Token: 0x06010600 RID: 67072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010600")]
		[Address(RVA = "0x8173B0", Offset = "0x815FB0", VA = "0x1808173B0")]
		public void SetCharacterMenuShowed(bool enable)
		{
		}

		// Token: 0x06010601 RID: 67073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010601")]
		[Address(RVA = "0x8174A0", Offset = "0x8160A0", VA = "0x1808174A0")]
		public void SetInUserInteract(bool enable)
		{
		}

		// Token: 0x06010602 RID: 67074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010602")]
		[Address(RVA = "0x8171C0", Offset = "0x815DC0", VA = "0x1808171C0")]
		public void ReqSelfReady(bool ready)
		{
		}

		// Token: 0x06010603 RID: 67075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010603")]
		[Address(RVA = "0x816FA0", Offset = "0x815BA0", VA = "0x180816FA0")]
		public void ReqOpenShop(bool isOpen)
		{
		}

		// Token: 0x06010604 RID: 67076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010604")]
		[Address(RVA = "0x816D90", Offset = "0x815990", VA = "0x180816D90")]
		public void ReqChangeShopSelectedSlot(AutoChessBattleShopSlot slotId)
		{
		}

		// Token: 0x06010605 RID: 67077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010605")]
		[Address(RVA = "0x816D00", Offset = "0x815900", VA = "0x180816D00")]
		public void ReqChangeBattleMapLayer(AutoChessGameStatus.AutoChessBattleMapLayer mapLayer)
		{
		}

		// Token: 0x06010606 RID: 67078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010606")]
		[Address(RVA = "0x817110", Offset = "0x815D10", VA = "0x180817110")]
		public void ReqReplaceEquip(int equipInstId, int charInstId)
		{
		}

		// Token: 0x06010607 RID: 67079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010607")]
		[Address(RVA = "0x817090", Offset = "0x815C90", VA = "0x180817090")]
		public void ReqReplaceEquipFinish()
		{
		}

		// Token: 0x06010608 RID: 67080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010608")]
		[Address(RVA = "0x816EB0", Offset = "0x815AB0", VA = "0x180816EB0")]
		public void ReqInEnemyPreview(bool enable)
		{
		}

		// Token: 0x06010609 RID: 67081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010609")]
		[Address(RVA = "0x816E20", Offset = "0x815A20", VA = "0x180816E20")]
		public void ReqHUDTipDisplay(AutoChessGameStatus.AutoChessHUDTipDisplay tipDisplay)
		{
		}

		// Token: 0x0601060A RID: 67082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601060A")]
		[Address(RVA = "0x8176F0", Offset = "0x8162F0", VA = "0x1808176F0")]
		private void _RefreshCoupledState()
		{
		}

		// Token: 0x0601060B RID: 67083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601060B")]
		[Address(RVA = "0x817930", Offset = "0x816530", VA = "0x180817930")]
		public AutoChessGameStatus()
		{
		}

		// Token: 0x040124C8 RID: 74952
		[Token(Token = "0x40124C8")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessGameStatus.AutoChessGameStateModel m_stateModel;

		// Token: 0x040124C9 RID: 74953
		[Token(Token = "0x40124C9")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessGameStatus.AutoChessUIStateModel m_uiStateModel;

		// Token: 0x040124CA RID: 74954
		[Token(Token = "0x40124CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instanceOrNull;

		// Token: 0x040124CB RID: 74955
		[Token(Token = "0x40124CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inLoadingState;

		// Token: 0x040124CC RID: 74956
		[Token(Token = "0x40124CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_inBattleState;

		// Token: 0x040124CD RID: 74957
		[Token(Token = "0x40124CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_inBattleMainState;

		// Token: 0x040124CE RID: 74958
		[Token(Token = "0x40124CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inSelfBattleState;

		// Token: 0x040124CF RID: 74959
		[Token(Token = "0x40124CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_inHelpBattleState;

		// Token: 0x040124D0 RID: 74960
		[Token(Token = "0x40124D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_inBossBattleState;

		// Token: 0x040124D1 RID: 74961
		[Token(Token = "0x40124D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_inBossPrepareWaiting;

		// Token: 0x040124D2 RID: 74962
		[Token(Token = "0x40124D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_inPrepareState;

		// Token: 0x040124D3 RID: 74963
		[Token(Token = "0x40124D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_inSpPrepareState;

		// Token: 0x040124D4 RID: 74964
		[Token(Token = "0x40124D4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_inMainPrepareState;

		// Token: 0x040124D5 RID: 74965
		[Token(Token = "0x40124D5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_lastState;

		// Token: 0x040124D6 RID: 74966
		[Token(Token = "0x40124D6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x040124D7 RID: 74967
		[Token(Token = "0x40124D7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_nextState;

		// Token: 0x040124D8 RID: 74968
		[Token(Token = "0x40124D8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_currentSubState;

		// Token: 0x040124D9 RID: 74969
		[Token(Token = "0x40124D9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_inMainSubState;

		// Token: 0x040124DA RID: 74970
		[Token(Token = "0x40124DA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_inEndSubState;

		// Token: 0x040124DB RID: 74971
		[Token(Token = "0x40124DB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_inBattleWaiting;

		// Token: 0x040124DC RID: 74972
		[Token(Token = "0x40124DC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_stateMachine;

		// Token: 0x040124DD RID: 74973
		[Token(Token = "0x40124DD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_shopOpened;

		// Token: 0x040124DE RID: 74974
		[Token(Token = "0x40124DE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_shopValid;

		// Token: 0x040124DF RID: 74975
		[Token(Token = "0x40124DF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_inUserInteract;

		// Token: 0x040124E0 RID: 74976
		[Token(Token = "0x40124E0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_canDisplayAvatar;

		// Token: 0x040124E1 RID: 74977
		[Token(Token = "0x40124E1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_characterMenuShowed;

		// Token: 0x040124E2 RID: 74978
		[Token(Token = "0x40124E2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_replaceEquipCharInstId;

		// Token: 0x040124E3 RID: 74979
		[Token(Token = "0x40124E3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_replaceEquipInstId;

		// Token: 0x040124E4 RID: 74980
		[Token(Token = "0x40124E4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_isReqReplaceEquip;

		// Token: 0x040124E5 RID: 74981
		[Token(Token = "0x40124E5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_inEnemyPreview;

		// Token: 0x040124E6 RID: 74982
		[Token(Token = "0x40124E6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_inHudTipDisplay;

		// Token: 0x040124E7 RID: 74983
		[Token(Token = "0x40124E7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_hudTipDisplay;

		// Token: 0x040124E8 RID: 74984
		[Token(Token = "0x40124E8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_battleMapLayer;

		// Token: 0x040124E9 RID: 74985
		[Token(Token = "0x40124E9")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_isLeftMapLayer;

		// Token: 0x040124EA RID: 74986
		[Token(Token = "0x40124EA")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isRightMapLayer;

		// Token: 0x040124EB RID: 74987
		[Token(Token = "0x40124EB")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_shopSelectedSlotId;

		// Token: 0x040124EC RID: 74988
		[Token(Token = "0x40124EC")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040124ED RID: 74989
		[Token(Token = "0x40124ED")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x040124EE RID: 74990
		[Token(Token = "0x40124EE")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040124EF RID: 74991
		[Token(Token = "0x40124EF")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040124F0 RID: 74992
		[Token(Token = "0x40124F0")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_MoveToNext;

		// Token: 0x040124F1 RID: 74993
		[Token(Token = "0x40124F1")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ResetUIState;

		// Token: 0x040124F2 RID: 74994
		[Token(Token = "0x40124F2")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ResetUIStateKeepMapLayer;

		// Token: 0x040124F3 RID: 74995
		[Token(Token = "0x40124F3")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_SetCharacterMenuShowed;

		// Token: 0x040124F4 RID: 74996
		[Token(Token = "0x40124F4")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_SetInUserInteract;

		// Token: 0x040124F5 RID: 74997
		[Token(Token = "0x40124F5")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ReqSelfReady;

		// Token: 0x040124F6 RID: 74998
		[Token(Token = "0x40124F6")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ReqOpenShop;

		// Token: 0x040124F7 RID: 74999
		[Token(Token = "0x40124F7")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_ReqChangeShopSelectedSlot;

		// Token: 0x040124F8 RID: 75000
		[Token(Token = "0x40124F8")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_ReqChangeBattleMapLayer;

		// Token: 0x040124F9 RID: 75001
		[Token(Token = "0x40124F9")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_ReqReplaceEquip;

		// Token: 0x040124FA RID: 75002
		[Token(Token = "0x40124FA")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_ReqReplaceEquipFinish;

		// Token: 0x040124FB RID: 75003
		[Token(Token = "0x40124FB")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ReqInEnemyPreview;

		// Token: 0x040124FC RID: 75004
		[Token(Token = "0x40124FC")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_ReqHUDTipDisplay;

		// Token: 0x040124FD RID: 75005
		[Token(Token = "0x40124FD")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__RefreshCoupledState;

		// Token: 0x040124FE RID: 75006
		[Token(Token = "0x40124FE")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002746 RID: 10054
		[Token(Token = "0x2002746")]
		public enum SubState
		{
			// Token: 0x04012500 RID: 75008
			[Token(Token = "0x4012500")]
			NONE,
			// Token: 0x04012501 RID: 75009
			[Token(Token = "0x4012501")]
			PRELOAD,
			// Token: 0x04012502 RID: 75010
			[Token(Token = "0x4012502")]
			BEGIN,
			// Token: 0x04012503 RID: 75011
			[Token(Token = "0x4012503")]
			MAIN,
			// Token: 0x04012504 RID: 75012
			[Token(Token = "0x4012504")]
			END,
			// Token: 0x04012505 RID: 75013
			[Token(Token = "0x4012505")]
			START = 1,
			// Token: 0x04012506 RID: 75014
			[Token(Token = "0x4012506")]
			FINISH = 4
		}

		// Token: 0x02002747 RID: 10055
		[Token(Token = "0x2002747")]
		public class GameStateChecker : IHotfixable
		{
			// Token: 0x0601060C RID: 67084 RVA: 0x00063CA8 File Offset: 0x00061EA8
			[Token(Token = "0x601060C")]
			[Address(RVA = "0x825670", Offset = "0x824270", VA = "0x180825670")]
			public bool IsDirty()
			{
				return default(bool);
			}

			// Token: 0x0601060D RID: 67085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601060D")]
			[Address(RVA = "0x8256F0", Offset = "0x8242F0", VA = "0x1808256F0")]
			public GameStateChecker()
			{
			}

			// Token: 0x04012507 RID: 75015
			[Token(Token = "0x4012507")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessDataCenter.DataChecker m_dataChecker;

			// Token: 0x04012508 RID: 75016
			[Token(Token = "0x4012508")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsDirty;

			// Token: 0x04012509 RID: 75017
			[Token(Token = "0x4012509")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002748 RID: 10056
		[Token(Token = "0x2002748")]
		public class AutoChessGameStateModel : AutoChessDataCenter.AutoChessDataModelBase
		{
			// Token: 0x170023C9 RID: 9161
			// (get) Token: 0x0601060E RID: 67086 RVA: 0x00063CC0 File Offset: 0x00061EC0
			[Token(Token = "0x170023C9")]
			public AutoChessGameStateType lastState
			{
				[Token(Token = "0x601060E")]
				[Address(RVA = "0x816160", Offset = "0x814D60", VA = "0x180816160")]
				get
				{
					return AutoChessGameStateType.NONE;
				}
			}

			// Token: 0x170023CA RID: 9162
			// (get) Token: 0x0601060F RID: 67087 RVA: 0x00063CD8 File Offset: 0x00061ED8
			[Token(Token = "0x170023CA")]
			public AutoChessGameStateType currentState
			{
				[Token(Token = "0x601060F")]
				[Address(RVA = "0x815F40", Offset = "0x814B40", VA = "0x180815F40")]
				get
				{
					return AutoChessGameStateType.NONE;
				}
			}

			// Token: 0x170023CB RID: 9163
			// (get) Token: 0x06010610 RID: 67088 RVA: 0x00063CF0 File Offset: 0x00061EF0
			[Token(Token = "0x170023CB")]
			public AutoChessGameStateType nextState
			{
				[Token(Token = "0x6010610")]
				[Address(RVA = "0x816200", Offset = "0x814E00", VA = "0x180816200")]
				get
				{
					return AutoChessGameStateType.NONE;
				}
			}

			// Token: 0x170023CC RID: 9164
			// (get) Token: 0x06010611 RID: 67089 RVA: 0x00063D08 File Offset: 0x00061F08
			[Token(Token = "0x170023CC")]
			public AutoChessGameStatus.SubState currentSubState
			{
				[Token(Token = "0x6010611")]
				[Address(RVA = "0x815FE0", Offset = "0x814BE0", VA = "0x180815FE0")]
				get
				{
					return AutoChessGameStatus.SubState.NONE;
				}
			}

			// Token: 0x170023CD RID: 9165
			// (get) Token: 0x06010612 RID: 67090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170023CD")]
			public AutoChessGameStatus.AutoChessGameStateMachine stateMachine
			{
				[Token(Token = "0x6010612")]
				[Address(RVA = "0x816260", Offset = "0x814E60", VA = "0x180816260")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010613 RID: 67091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010613")]
			[Address(RVA = "0x815600", Offset = "0x814200", VA = "0x180815600")]
			public AutoChessGameStateModel()
			{
			}

			// Token: 0x06010614 RID: 67092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010614")]
			[Address(RVA = "0x814FA0", Offset = "0x813BA0", VA = "0x180814FA0")]
			public void OnTick()
			{
			}

			// Token: 0x06010615 RID: 67093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010615")]
			[Address(RVA = "0x815340", Offset = "0x813F40", VA = "0x180815340")]
			public void Start()
			{
			}

			// Token: 0x06010616 RID: 67094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010616")]
			[Address(RVA = "0x8153B0", Offset = "0x813FB0", VA = "0x1808153B0")]
			public void Stop()
			{
			}

			// Token: 0x06010617 RID: 67095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010617")]
			[Address(RVA = "0x815590", Offset = "0x814190", VA = "0x180815590")]
			public void TrySwitchToState(AutoChessGameStateType state)
			{
			}

			// Token: 0x06010618 RID: 67096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010618")]
			[Address(RVA = "0x815420", Offset = "0x814020", VA = "0x180815420")]
			public void TrySwitchSubState()
			{
			}

			// Token: 0x0401250A RID: 75018
			[Token(Token = "0x401250A")]
			[FieldOffset(Offset = "0x18")]
			private AutoChessGameStatus.AutoChessGameStateMachine m_stateMachine;

			// Token: 0x0401250B RID: 75019
			[Token(Token = "0x401250B")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessGameStateType m_nextState;

			// Token: 0x0401250C RID: 75020
			[Token(Token = "0x401250C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_lastState;

			// Token: 0x0401250D RID: 75021
			[Token(Token = "0x401250D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_currentState;

			// Token: 0x0401250E RID: 75022
			[Token(Token = "0x401250E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_nextState;

			// Token: 0x0401250F RID: 75023
			[Token(Token = "0x401250F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_currentSubState;

			// Token: 0x04012510 RID: 75024
			[Token(Token = "0x4012510")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_stateMachine;

			// Token: 0x04012511 RID: 75025
			[Token(Token = "0x4012511")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012512 RID: 75026
			[Token(Token = "0x4012512")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04012513 RID: 75027
			[Token(Token = "0x4012513")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_Start;

			// Token: 0x04012514 RID: 75028
			[Token(Token = "0x4012514")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Stop;

			// Token: 0x04012515 RID: 75029
			[Token(Token = "0x4012515")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_TrySwitchToState;

			// Token: 0x04012516 RID: 75030
			[Token(Token = "0x4012516")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_TrySwitchSubState;
		}

		// Token: 0x02002749 RID: 10057
		[Token(Token = "0x2002749")]
		public class AutoChessGameStateMachine : EnumStateMachine<AutoChessGameStateType>, IHotfixable
		{
			// Token: 0x170023CE RID: 9166
			// (get) Token: 0x06010619 RID: 67097 RVA: 0x00063D20 File Offset: 0x00061F20
			// (set) Token: 0x0601061A RID: 67098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170023CE")]
			public AutoChessGameStateType gameLastStateId
			{
				[Token(Token = "0x6010619")]
				[Address(RVA = "0x814D00", Offset = "0x813900", VA = "0x180814D00")]
				[CompilerGenerated]
				get
				{
					return AutoChessGameStateType.NONE;
				}
				[Token(Token = "0x601061A")]
				[Address(RVA = "0x814F30", Offset = "0x813B30", VA = "0x180814F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170023CF RID: 9167
			// (get) Token: 0x0601061B RID: 67099 RVA: 0x00063D38 File Offset: 0x00061F38
			// (set) Token: 0x0601061C RID: 67100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170023CF")]
			public AutoChessGameStateType gameCurrentStateId
			{
				[Token(Token = "0x601061B")]
				[Address(RVA = "0x814C40", Offset = "0x813840", VA = "0x180814C40")]
				[CompilerGenerated]
				get
				{
					return AutoChessGameStateType.NONE;
				}
				[Token(Token = "0x601061C")]
				[Address(RVA = "0x814E40", Offset = "0x813A40", VA = "0x180814E40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170023D0 RID: 9168
			// (get) Token: 0x0601061D RID: 67101 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601061E RID: 67102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170023D0")]
			public AutoChessGameStatus.AutoChessGameState gameCurrentState
			{
				[Token(Token = "0x601061D")]
				[Address(RVA = "0x814CA0", Offset = "0x8138A0", VA = "0x180814CA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601061E")]
				[Address(RVA = "0x814EB0", Offset = "0x813AB0", VA = "0x180814EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170023D1 RID: 9169
			// (get) Token: 0x0601061F RID: 67103 RVA: 0x00063D50 File Offset: 0x00061F50
			[Token(Token = "0x170023D1")]
			public bool markFinished
			{
				[Token(Token = "0x601061F")]
				[Address(RVA = "0x814D60", Offset = "0x813960", VA = "0x180814D60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170023D2 RID: 9170
			// (get) Token: 0x06010620 RID: 67104 RVA: 0x00063D68 File Offset: 0x00061F68
			[Token(Token = "0x170023D2")]
			public AutoChessGameStatus.SubState currentSubState
			{
				[Token(Token = "0x6010620")]
				[Address(RVA = "0x814B00", Offset = "0x813700", VA = "0x180814B00")]
				get
				{
					return AutoChessGameStatus.SubState.NONE;
				}
			}

			// Token: 0x06010621 RID: 67105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010621")]
			[Address(RVA = "0x814790", Offset = "0x813390", VA = "0x180814790", Slot = "6")]
			protected override void OnStateChanged(int newStateId, int oldStateId)
			{
			}

			// Token: 0x06010622 RID: 67106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010622")]
			[Address(RVA = "0x814A90", Offset = "0x813690", VA = "0x180814A90")]
			public AutoChessGameStateMachine()
			{
			}

			// Token: 0x06010623 RID: 67107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010623")]
			[Address(RVA = "0x814A80", Offset = "0x813680", VA = "0x180814A80")]
			private void <>xLuaBaseProxy_OnStateChanged(int P0, int P1)
			{
			}

			// Token: 0x0401251A RID: 75034
			[Token(Token = "0x401251A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_gameLastStateId;

			// Token: 0x0401251B RID: 75035
			[Token(Token = "0x401251B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_gameLastStateId;

			// Token: 0x0401251C RID: 75036
			[Token(Token = "0x401251C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_gameCurrentStateId;

			// Token: 0x0401251D RID: 75037
			[Token(Token = "0x401251D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_gameCurrentStateId;

			// Token: 0x0401251E RID: 75038
			[Token(Token = "0x401251E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_gameCurrentState;

			// Token: 0x0401251F RID: 75039
			[Token(Token = "0x401251F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_gameCurrentState;

			// Token: 0x04012520 RID: 75040
			[Token(Token = "0x4012520")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_markFinished;

			// Token: 0x04012521 RID: 75041
			[Token(Token = "0x4012521")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_currentSubState;

			// Token: 0x04012522 RID: 75042
			[Token(Token = "0x4012522")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnStateChanged;

			// Token: 0x04012523 RID: 75043
			[Token(Token = "0x4012523")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200274A RID: 10058
		[Token(Token = "0x200274A")]
		public class AutoChessGameState : StateMachine.IStateNode, IHotfixable
		{
			// Token: 0x170023D3 RID: 9171
			// (get) Token: 0x06010624 RID: 67108 RVA: 0x00063D80 File Offset: 0x00061F80
			[Token(Token = "0x170023D3")]
			public bool isFinished
			{
				[Token(Token = "0x6010624")]
				[Address(RVA = "0x816970", Offset = "0x815570", VA = "0x180816970")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170023D4 RID: 9172
			// (get) Token: 0x06010625 RID: 67109 RVA: 0x00063D98 File Offset: 0x00061F98
			[Token(Token = "0x170023D4")]
			public bool isActiveNode
			{
				[Token(Token = "0x6010625")]
				[Address(RVA = "0x816890", Offset = "0x815490", VA = "0x180816890", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170023D5 RID: 9173
			// (get) Token: 0x06010626 RID: 67110 RVA: 0x00063DB0 File Offset: 0x00061FB0
			[Token(Token = "0x170023D5")]
			public bool markFinished
			{
				[Token(Token = "0x6010626")]
				[Address(RVA = "0x8169D0", Offset = "0x8155D0", VA = "0x1808169D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170023D6 RID: 9174
			// (get) Token: 0x06010627 RID: 67111 RVA: 0x00063DC8 File Offset: 0x00061FC8
			[Token(Token = "0x170023D6")]
			public bool canInterrupt
			{
				[Token(Token = "0x6010627")]
				[Address(RVA = "0x8167D0", Offset = "0x8153D0", VA = "0x1808167D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170023D7 RID: 9175
			// (get) Token: 0x06010628 RID: 67112 RVA: 0x00063DE0 File Offset: 0x00061FE0
			[Token(Token = "0x170023D7")]
			public AutoChessGameStatus.SubState currentSubState
			{
				[Token(Token = "0x6010628")]
				[Address(RVA = "0x816830", Offset = "0x815430", VA = "0x180816830")]
				get
				{
					return AutoChessGameStatus.SubState.NONE;
				}
			}

			// Token: 0x06010629 RID: 67113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010629")]
			[Address(RVA = "0x8163F0", Offset = "0x814FF0", VA = "0x1808163F0", Slot = "5")]
			public void OnEnter(int lastState)
			{
			}

			// Token: 0x0601062A RID: 67114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601062A")]
			[Address(RVA = "0x8164B0", Offset = "0x8150B0", VA = "0x1808164B0")]
			public void OnRealEnter(AutoChessGameStateType state)
			{
			}

			// Token: 0x0601062B RID: 67115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601062B")]
			[Address(RVA = "0x816540", Offset = "0x815140", VA = "0x180816540", Slot = "7")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0601062C RID: 67116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601062C")]
			[Address(RVA = "0x816450", Offset = "0x815050", VA = "0x180816450", Slot = "6")]
			public void OnExit(int nextState)
			{
			}

			// Token: 0x0601062D RID: 67117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601062D")]
			[Address(RVA = "0x8166F0", Offset = "0x8152F0", VA = "0x1808166F0")]
			private void _SwitchSubState(AutoChessGameStatus.SubState subState)
			{
			}

			// Token: 0x0601062E RID: 67118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601062E")]
			[Address(RVA = "0x816330", Offset = "0x814F30", VA = "0x180816330")]
			public void MarkFinished()
			{
			}

			// Token: 0x0601062F RID: 67119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601062F")]
			[Address(RVA = "0x8165A0", Offset = "0x8151A0", VA = "0x1808165A0")]
			public void TrySwitchSubState()
			{
			}

			// Token: 0x06010630 RID: 67120 RVA: 0x00063DF8 File Offset: 0x00061FF8
			[Token(Token = "0x6010630")]
			[Address(RVA = "0x8162C0", Offset = "0x814EC0", VA = "0x1808162C0", Slot = "8")]
			public bool CheckSwitchOut(int nextState)
			{
				return default(bool);
			}

			// Token: 0x06010631 RID: 67121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010631")]
			[Address(RVA = "0x816670", Offset = "0x815270", VA = "0x180816670")]
			private void _MarkDirty()
			{
			}

			// Token: 0x06010632 RID: 67122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010632")]
			[Address(RVA = "0x816770", Offset = "0x815370", VA = "0x180816770")]
			public AutoChessGameState()
			{
			}

			// Token: 0x04012524 RID: 75044
			[Token(Token = "0x4012524")]
			[FieldOffset(Offset = "0x10")]
			private bool m_finished;

			// Token: 0x04012525 RID: 75045
			[Token(Token = "0x4012525")]
			[FieldOffset(Offset = "0x11")]
			private bool m_markFinished;

			// Token: 0x04012526 RID: 75046
			[Token(Token = "0x4012526")]
			[FieldOffset(Offset = "0x14")]
			private AutoChessGameStateType m_state;

			// Token: 0x04012527 RID: 75047
			[Token(Token = "0x4012527")]
			[FieldOffset(Offset = "0x18")]
			private AutoChessGameStatus.SubState m_currentSubStateId;

			// Token: 0x04012528 RID: 75048
			[Token(Token = "0x4012528")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isFinished;

			// Token: 0x04012529 RID: 75049
			[Token(Token = "0x4012529")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isActiveNode;

			// Token: 0x0401252A RID: 75050
			[Token(Token = "0x401252A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_markFinished;

			// Token: 0x0401252B RID: 75051
			[Token(Token = "0x401252B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_canInterrupt;

			// Token: 0x0401252C RID: 75052
			[Token(Token = "0x401252C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_currentSubState;

			// Token: 0x0401252D RID: 75053
			[Token(Token = "0x401252D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x0401252E RID: 75054
			[Token(Token = "0x401252E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnRealEnter;

			// Token: 0x0401252F RID: 75055
			[Token(Token = "0x401252F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04012530 RID: 75056
			[Token(Token = "0x4012530")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnExit;

			// Token: 0x04012531 RID: 75057
			[Token(Token = "0x4012531")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__SwitchSubState;

			// Token: 0x04012532 RID: 75058
			[Token(Token = "0x4012532")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_MarkFinished;

			// Token: 0x04012533 RID: 75059
			[Token(Token = "0x4012533")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_TrySwitchSubState;

			// Token: 0x04012534 RID: 75060
			[Token(Token = "0x4012534")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_CheckSwitchOut;

			// Token: 0x04012535 RID: 75061
			[Token(Token = "0x4012535")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__MarkDirty;

			// Token: 0x04012536 RID: 75062
			[Token(Token = "0x4012536")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200274B RID: 10059
		[Token(Token = "0x200274B")]
		public enum AutoChessHUDTipDisplay
		{
			// Token: 0x04012538 RID: 75064
			[Token(Token = "0x4012538")]
			NONE,
			// Token: 0x04012539 RID: 75065
			[Token(Token = "0x4012539")]
			PLAYER_INFO_TIP,
			// Token: 0x0401253A RID: 75066
			[Token(Token = "0x401253A")]
			BOND_DETAIL_TIP
		}

		// Token: 0x0200274C RID: 10060
		[Token(Token = "0x200274C")]
		public enum AutoChessBattleMapLayer
		{
			// Token: 0x0401253C RID: 75068
			[Token(Token = "0x401253C")]
			START,
			// Token: 0x0401253D RID: 75069
			[Token(Token = "0x401253D")]
			LEFT = 0,
			// Token: 0x0401253E RID: 75070
			[Token(Token = "0x401253E")]
			MID,
			// Token: 0x0401253F RID: 75071
			[Token(Token = "0x401253F")]
			RIGHT,
			// Token: 0x04012540 RID: 75072
			[Token(Token = "0x4012540")]
			END = 2
		}

		// Token: 0x0200274D RID: 10061
		[Token(Token = "0x200274D")]
		public class UIStateChecker : IHotfixable
		{
			// Token: 0x06010633 RID: 67123 RVA: 0x00063E10 File Offset: 0x00062010
			[Token(Token = "0x6010633")]
			[Address(RVA = "0x825960", Offset = "0x824560", VA = "0x180825960")]
			public bool IsDirty()
			{
				return default(bool);
			}

			// Token: 0x06010634 RID: 67124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010634")]
			[Address(RVA = "0x8259E0", Offset = "0x8245E0", VA = "0x1808259E0")]
			public UIStateChecker()
			{
			}

			// Token: 0x04012541 RID: 75073
			[Token(Token = "0x4012541")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessDataCenter.DataChecker m_dataChecker;

			// Token: 0x04012542 RID: 75074
			[Token(Token = "0x4012542")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsDirty;

			// Token: 0x04012543 RID: 75075
			[Token(Token = "0x4012543")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200274E RID: 10062
		[Token(Token = "0x200274E")]
		public class AutoChessUIStateModel : AutoChessDataCenter.AutoChessDataModelBase
		{
			// Token: 0x06010635 RID: 67125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010635")]
			[Address(RVA = "0x822500", Offset = "0x821100", VA = "0x180822500")]
			public void ReqSelfReady(bool ready)
			{
			}

			// Token: 0x06010636 RID: 67126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010636")]
			[Address(RVA = "0x8223E0", Offset = "0x820FE0", VA = "0x1808223E0")]
			public void ReqOpenShop(bool isOpen)
			{
			}

			// Token: 0x06010637 RID: 67127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010637")]
			[Address(RVA = "0x8221B0", Offset = "0x820DB0", VA = "0x1808221B0")]
			public void ReqChangeBattleMapLayer(AutoChessGameStatus.AutoChessBattleMapLayer mapLayer)
			{
			}

			// Token: 0x06010638 RID: 67128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010638")]
			[Address(RVA = "0x822460", Offset = "0x821060", VA = "0x180822460")]
			public void ReqReplaceEquip(int equipInstId, int charInstId)
			{
			}

			// Token: 0x06010639 RID: 67129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010639")]
			[Address(RVA = "0x822360", Offset = "0x820F60", VA = "0x180822360")]
			public void ReqInEnemyPreview(bool enable)
			{
			}

			// Token: 0x0601063A RID: 67130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601063A")]
			[Address(RVA = "0x8222E0", Offset = "0x820EE0", VA = "0x1808222E0")]
			public void ReqHUDTipDisplay(AutoChessGameStatus.AutoChessHUDTipDisplay tipDisplay)
			{
			}

			// Token: 0x0601063B RID: 67131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601063B")]
			[Address(RVA = "0x822230", Offset = "0x820E30", VA = "0x180822230")]
			public void ReqChangeShopSelectedSlot(AutoChessBattleShopSlot slotId)
			{
			}

			// Token: 0x0601063C RID: 67132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601063C")]
			[Address(RVA = "0x822630", Offset = "0x821230", VA = "0x180822630")]
			public void SetCharacterMenuShowed(bool enable)
			{
			}

			// Token: 0x0601063D RID: 67133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601063D")]
			[Address(RVA = "0x8226B0", Offset = "0x8212B0", VA = "0x1808226B0")]
			public void SetInUserInteract(bool enable)
			{
			}

			// Token: 0x0601063E RID: 67134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601063E")]
			[Address(RVA = "0x822580", Offset = "0x821180", VA = "0x180822580")]
			public void Reset()
			{
			}

			// Token: 0x0601063F RID: 67135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601063F")]
			[Address(RVA = "0x822730", Offset = "0x821330", VA = "0x180822730")]
			public AutoChessUIStateModel()
			{
			}

			// Token: 0x04012544 RID: 75076
			[Token(Token = "0x4012544")]
			[FieldOffset(Offset = "0x18")]
			public bool shopOpened;

			// Token: 0x04012545 RID: 75077
			[Token(Token = "0x4012545")]
			[FieldOffset(Offset = "0x19")]
			public bool inEnemyPreview;

			// Token: 0x04012546 RID: 75078
			[Token(Token = "0x4012546")]
			[FieldOffset(Offset = "0x1A")]
			public bool inUserInteract;

			// Token: 0x04012547 RID: 75079
			[Token(Token = "0x4012547")]
			[FieldOffset(Offset = "0x1B")]
			public bool characterMenuShowed;

			// Token: 0x04012548 RID: 75080
			[Token(Token = "0x4012548")]
			[FieldOffset(Offset = "0x1C")]
			public int replaceEquipCharInstId;

			// Token: 0x04012549 RID: 75081
			[Token(Token = "0x4012549")]
			[FieldOffset(Offset = "0x20")]
			public int replaceEquipInstId;

			// Token: 0x0401254A RID: 75082
			[Token(Token = "0x401254A")]
			[FieldOffset(Offset = "0x24")]
			public AutoChessBattleShopSlot shopSelectedSlotId;

			// Token: 0x0401254B RID: 75083
			[Token(Token = "0x401254B")]
			[FieldOffset(Offset = "0x28")]
			public AutoChessGameStatus.AutoChessHUDTipDisplay hudTipDisplay;

			// Token: 0x0401254C RID: 75084
			[Token(Token = "0x401254C")]
			[FieldOffset(Offset = "0x2C")]
			public AutoChessGameStatus.AutoChessBattleMapLayer battleMapLayer;

			// Token: 0x0401254D RID: 75085
			[Token(Token = "0x401254D")]
			[FieldOffset(Offset = "0x30")]
			public bool selfReady;

			// Token: 0x0401254E RID: 75086
			[Token(Token = "0x401254E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ReqSelfReady;

			// Token: 0x0401254F RID: 75087
			[Token(Token = "0x401254F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ReqOpenShop;

			// Token: 0x04012550 RID: 75088
			[Token(Token = "0x4012550")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ReqChangeBattleMapLayer;

			// Token: 0x04012551 RID: 75089
			[Token(Token = "0x4012551")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ReqReplaceEquip;

			// Token: 0x04012552 RID: 75090
			[Token(Token = "0x4012552")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ReqInEnemyPreview;

			// Token: 0x04012553 RID: 75091
			[Token(Token = "0x4012553")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ReqHUDTipDisplay;

			// Token: 0x04012554 RID: 75092
			[Token(Token = "0x4012554")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ReqChangeShopSelectedSlot;

			// Token: 0x04012555 RID: 75093
			[Token(Token = "0x4012555")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetCharacterMenuShowed;

			// Token: 0x04012556 RID: 75094
			[Token(Token = "0x4012556")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_SetInUserInteract;

			// Token: 0x04012557 RID: 75095
			[Token(Token = "0x4012557")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x04012558 RID: 75096
			[Token(Token = "0x4012558")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
