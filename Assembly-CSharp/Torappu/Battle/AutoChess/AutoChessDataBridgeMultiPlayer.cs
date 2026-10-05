using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200273C RID: 10044
	[Token(Token = "0x200273C")]
	public class AutoChessDataBridgeMultiPlayer : AutoChessDataBridge
	{
		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x060104FB RID: 66811 RVA: 0x000637E0 File Offset: 0x000619E0
		[Token(Token = "0x17002399")]
		public override DateTime currentTime
		{
			[Token(Token = "0x60104FB")]
			[Address(RVA = "0x803230", Offset = "0x801E30", VA = "0x180803230", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x060104FC RID: 66812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104FC")]
		[Address(RVA = "0x800E20", Offset = "0x7FFA20", VA = "0x180800E20", Slot = "6")]
		public override void Start()
		{
		}

		// Token: 0x060104FD RID: 66813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104FD")]
		[Address(RVA = "0x7FEA70", Offset = "0x7FD670", VA = "0x1807FEA70", Slot = "7")]
		public override void Finish()
		{
		}

		// Token: 0x060104FE RID: 66814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104FE")]
		[Address(RVA = "0x801610", Offset = "0x800210", VA = "0x180801610")]
		private void _InitData()
		{
		}

		// Token: 0x060104FF RID: 66815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104FF")]
		[Address(RVA = "0x801840", Offset = "0x800440", VA = "0x180801840")]
		private void _OnServerDataChanged(object arg)
		{
		}

		// Token: 0x06010500 RID: 66816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010500")]
		[Address(RVA = "0x802D90", Offset = "0x801990", VA = "0x180802D90")]
		private void _UpdateData()
		{
		}

		// Token: 0x06010501 RID: 66817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010501")]
		[Address(RVA = "0x8017B0", Offset = "0x8003B0", VA = "0x1808017B0")]
		private void _OnServerChat(object arg)
		{
		}

		// Token: 0x06010502 RID: 66818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010502")]
		[Address(RVA = "0x8018B0", Offset = "0x8004B0", VA = "0x1808018B0")]
		private void _OnServerLost(object arg)
		{
		}

		// Token: 0x06010503 RID: 66819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010503")]
		[Address(RVA = "0x7FF0C0", Offset = "0x7FDCC0", VA = "0x1807FF0C0", Slot = "8")]
		public override void ReqBuyChess(int slotId, bool isSpecial, Action sucAction)
		{
		}

		// Token: 0x06010504 RID: 66820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010504")]
		[Address(RVA = "0x801720", Offset = "0x800320", VA = "0x180801720")]
		private void _OnServerBroadcast(object arg)
		{
		}

		// Token: 0x06010505 RID: 66821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010505")]
		[Address(RVA = "0x800850", Offset = "0x7FF450", VA = "0x180800850", Slot = "9")]
		public override void ReqShopFrozen(bool isFrozen)
		{
		}

		// Token: 0x06010506 RID: 66822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010506")]
		[Address(RVA = "0x8009B0", Offset = "0x7FF5B0", VA = "0x1808009B0", Slot = "10")]
		public override void ReqShopUpgrade()
		{
		}

		// Token: 0x06010507 RID: 66823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010507")]
		[Address(RVA = "0x800910", Offset = "0x7FF510", VA = "0x180800910", Slot = "11")]
		public override void ReqShopRefresh()
		{
		}

		// Token: 0x06010508 RID: 66824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010508")]
		[Address(RVA = "0x7FFA50", Offset = "0x7FE650", VA = "0x1807FFA50", Slot = "12")]
		public override void ReqMoveChess()
		{
		}

		// Token: 0x06010509 RID: 66825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010509")]
		[Address(RVA = "0x800B20", Offset = "0x7FF720", VA = "0x180800B20", Slot = "13")]
		public override void ReqUseMagic(int instId)
		{
		}

		// Token: 0x0601050A RID: 66826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601050A")]
		[Address(RVA = "0x801290", Offset = "0x7FFE90", VA = "0x180801290")]
		private AutoChessBattleChessPosUnitInfo _ConvertChessInst(ChessInst chessInst)
		{
			return null;
		}

		// Token: 0x0601050B RID: 66827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601050B")]
		[Address(RVA = "0x7FF910", Offset = "0x7FE510", VA = "0x1807FF910", Slot = "5")]
		public override void ReqLoadReady()
		{
		}

		// Token: 0x0601050C RID: 66828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601050C")]
		[Address(RVA = "0x801F20", Offset = "0x800B20", VA = "0x180801F20")]
		private void _ReqLoadingReadyUp()
		{
		}

		// Token: 0x0601050D RID: 66829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601050D")]
		[Address(RVA = "0x7FF5E0", Offset = "0x7FE1E0", VA = "0x1807FF5E0", Slot = "14")]
		public override void ReqEquipItem(int equipInst, int targetInst, int replacedEquipInstId)
		{
		}

		// Token: 0x0601050E RID: 66830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601050E")]
		[Address(RVA = "0x800590", Offset = "0x7FF190", VA = "0x180800590", Slot = "15")]
		public override void ReqSellOrDestroy(GridPosition gridPosition)
		{
		}

		// Token: 0x0601050F RID: 66831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601050F")]
		[Address(RVA = "0x7FEF50", Offset = "0x7FDB50", VA = "0x1807FEF50", Slot = "16")]
		public override void ReqBattleFinish(BattleController.GameResult result)
		{
		}

		// Token: 0x06010510 RID: 66832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010510")]
		[Address(RVA = "0x7FFD40", Offset = "0x7FE940", VA = "0x1807FFD40")]
		public void ReqNormalBattleFinish()
		{
		}

		// Token: 0x06010511 RID: 66833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010511")]
		[Address(RVA = "0x8022F0", Offset = "0x800EF0", VA = "0x1808022F0")]
		private void _ReqSelfBattleFinish(bool fromRejoin, int round)
		{
		}

		// Token: 0x06010512 RID: 66834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010512")]
		[Address(RVA = "0x802A70", Offset = "0x801670", VA = "0x180802A70")]
		private void _TakeCharBattleStatus(List<AutoChessBattleCharBattleStatus> charBattleStatusList)
		{
		}

		// Token: 0x06010513 RID: 66835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010513")]
		[Address(RVA = "0x802770", Offset = "0x801370", VA = "0x180802770")]
		private void _TakeCharBattleInfo(List<AutoChessBattleProtocol.AutoChessBattleInfoCheckMeta> battleInfoList)
		{
		}

		// Token: 0x06010514 RID: 66836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010514")]
		[Address(RVA = "0x801950", Offset = "0x800550", VA = "0x180801950")]
		private void _ReqHelpBattleFinish(bool fromRejoin, int round)
		{
		}

		// Token: 0x06010515 RID: 66837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010515")]
		[Address(RVA = "0x801470", Offset = "0x800070", VA = "0x180801470")]
		private AutoChessBattleEscapedEnemyInfo _ConvertEscapedEnemyInfo(EscapedEnemyInfo info)
		{
			return null;
		}

		// Token: 0x06010516 RID: 66838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010516")]
		[Address(RVA = "0x7FFFE0", Offset = "0x7FEBE0", VA = "0x1807FFFE0", Slot = "17")]
		public override void ReqPrepareReady(bool isReady)
		{
		}

		// Token: 0x06010517 RID: 66839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010517")]
		[Address(RVA = "0x800120", Offset = "0x7FED20", VA = "0x180800120", Slot = "18")]
		public override void ReqSelfBattleEnemyEscape(int enemyInstId, bool isToken)
		{
		}

		// Token: 0x06010518 RID: 66840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010518")]
		[Address(RVA = "0x8001E0", Offset = "0x7FEDE0", VA = "0x1808001E0", Slot = "19")]
		public override void ReqSelfBattleEnemyKilled(BattleEnemyKilledInfo killedInfo)
		{
		}

		// Token: 0x06010519 RID: 66841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010519")]
		[Address(RVA = "0x8002D0", Offset = "0x7FEED0", VA = "0x1808002D0", Slot = "20")]
		public override void ReqSelfBattleInfoUp()
		{
		}

		// Token: 0x0601051A RID: 66842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601051A")]
		[Address(RVA = "0x7FF750", Offset = "0x7FE350", VA = "0x1807FF750", Slot = "21")]
		public override void ReqHelpBattleEnemyEscape(int enemyInstId, bool isToken)
		{
		}

		// Token: 0x0601051B RID: 66843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601051B")]
		[Address(RVA = "0x7FF810", Offset = "0x7FE410", VA = "0x1807FF810", Slot = "22")]
		public override void ReqHelpBattleEnemyKilled(HelpBattleEnemyKilledInfo killedInfo)
		{
		}

		// Token: 0x0601051C RID: 66844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601051C")]
		[Address(RVA = "0x801540", Offset = "0x800140", VA = "0x180801540")]
		private AutoChessBattleProtocol.AutoChessSelfBattleKillRecord _ConvertToKillRecord(BattleEnemyKilledInfo killedInfo)
		{
			return null;
		}

		// Token: 0x0601051D RID: 66845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601051D")]
		[Address(RVA = "0x7FECB0", Offset = "0x7FD8B0", VA = "0x1807FECB0", Slot = "23")]
		public override void ReqAddBondStackCount(int charInstId, List<string> bondIds, int count)
		{
		}

		// Token: 0x0601051E RID: 66846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601051E")]
		[Address(RVA = "0x7FFE50", Offset = "0x7FEA50", VA = "0x1807FFE50", Slot = "24")]
		public override void ReqObOtherPlayer(int playerIndex)
		{
		}

		// Token: 0x0601051F RID: 66847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601051F")]
		[Address(RVA = "0x7FF2B0", Offset = "0x7FDEB0", VA = "0x1807FF2B0", Slot = "25")]
		public override void ReqCancelOb()
		{
		}

		// Token: 0x06010520 RID: 66848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010520")]
		[Address(RVA = "0x7FF350", Offset = "0x7FDF50", VA = "0x1807FF350", Slot = "26")]
		public override void ReqDeadAutoOb()
		{
		}

		// Token: 0x06010521 RID: 66849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010521")]
		[Address(RVA = "0x800A50", Offset = "0x7FF650", VA = "0x180800A50", Slot = "27")]
		public override void ReqSpPrepareSelect(int slotId)
		{
		}

		// Token: 0x06010522 RID: 66850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010522")]
		[Address(RVA = "0x8004C0", Offset = "0x7FF0C0", VA = "0x1808004C0", Slot = "28")]
		public override void ReqSelfChoiceSelect(int slotId)
		{
		}

		// Token: 0x06010523 RID: 66851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010523")]
		[Address(RVA = "0x800760", Offset = "0x7FF360", VA = "0x180800760", Slot = "29")]
		public override void ReqSendEmoji(string grp, string id)
		{
		}

		// Token: 0x06010524 RID: 66852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010524")]
		[Address(RVA = "0x800650", Offset = "0x7FF250", VA = "0x180800650", Slot = "30")]
		public override void ReqSendBroadcast(int playerIdx, string id, IList<string> param)
		{
		}

		// Token: 0x06010525 RID: 66853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010525")]
		[Address(RVA = "0x7FF6B0", Offset = "0x7FE2B0", VA = "0x1807FF6B0", Slot = "31")]
		public override void ReqGiveUp()
		{
		}

		// Token: 0x06010526 RID: 66854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010526")]
		[Address(RVA = "0x7FFF10", Offset = "0x7FEB10", VA = "0x1807FFF10", Slot = "33")]
		public override void ReqPauseSingleMode()
		{
		}

		// Token: 0x06010527 RID: 66855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010527")]
		[Address(RVA = "0x8000A0", Offset = "0x7FECA0", VA = "0x1808000A0", Slot = "34")]
		public override void ReqResumeSingleMode()
		{
		}

		// Token: 0x06010528 RID: 66856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010528")]
		[Address(RVA = "0x7FEFD0", Offset = "0x7FDBD0", VA = "0x1807FEFD0", Slot = "32")]
		public override void ReqBattleSceneActionUp(int seq, List<AutoChessBattleStepActionData> actions)
		{
		}

		// Token: 0x06010529 RID: 66857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010529")]
		[Address(RVA = "0x803190", Offset = "0x801D90", VA = "0x180803190")]
		public AutoChessDataBridgeMultiPlayer()
		{
		}

		// Token: 0x040123D6 RID: 74710
		[Token(Token = "0x40123D6")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessDataBridgeMultiPlayer.ReqAutoResender m_reqAutoResender;

		// Token: 0x040123D7 RID: 74711
		[Token(Token = "0x40123D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x040123D8 RID: 74712
		[Token(Token = "0x40123D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040123D9 RID: 74713
		[Token(Token = "0x40123D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Finish;

		// Token: 0x040123DA RID: 74714
		[Token(Token = "0x40123DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x040123DB RID: 74715
		[Token(Token = "0x40123DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnServerDataChanged;

		// Token: 0x040123DC RID: 74716
		[Token(Token = "0x40123DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040123DD RID: 74717
		[Token(Token = "0x40123DD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnServerChat;

		// Token: 0x040123DE RID: 74718
		[Token(Token = "0x40123DE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnServerLost;

		// Token: 0x040123DF RID: 74719
		[Token(Token = "0x40123DF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ReqBuyChess;

		// Token: 0x040123E0 RID: 74720
		[Token(Token = "0x40123E0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnServerBroadcast;

		// Token: 0x040123E1 RID: 74721
		[Token(Token = "0x40123E1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReqShopFrozen;

		// Token: 0x040123E2 RID: 74722
		[Token(Token = "0x40123E2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ReqShopUpgrade;

		// Token: 0x040123E3 RID: 74723
		[Token(Token = "0x40123E3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ReqShopRefresh;

		// Token: 0x040123E4 RID: 74724
		[Token(Token = "0x40123E4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ReqMoveChess;

		// Token: 0x040123E5 RID: 74725
		[Token(Token = "0x40123E5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ReqUseMagic;

		// Token: 0x040123E6 RID: 74726
		[Token(Token = "0x40123E6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ConvertChessInst;

		// Token: 0x040123E7 RID: 74727
		[Token(Token = "0x40123E7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ReqLoadReady;

		// Token: 0x040123E8 RID: 74728
		[Token(Token = "0x40123E8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ReqLoadingReadyUp;

		// Token: 0x040123E9 RID: 74729
		[Token(Token = "0x40123E9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ReqEquipItem;

		// Token: 0x040123EA RID: 74730
		[Token(Token = "0x40123EA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReqSellOrDestroy;

		// Token: 0x040123EB RID: 74731
		[Token(Token = "0x40123EB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ReqBattleFinish;

		// Token: 0x040123EC RID: 74732
		[Token(Token = "0x40123EC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ReqNormalBattleFinish;

		// Token: 0x040123ED RID: 74733
		[Token(Token = "0x40123ED")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ReqSelfBattleFinish;

		// Token: 0x040123EE RID: 74734
		[Token(Token = "0x40123EE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TakeCharBattleStatus;

		// Token: 0x040123EF RID: 74735
		[Token(Token = "0x40123EF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TakeCharBattleInfo;

		// Token: 0x040123F0 RID: 74736
		[Token(Token = "0x40123F0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ReqHelpBattleFinish;

		// Token: 0x040123F1 RID: 74737
		[Token(Token = "0x40123F1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ConvertEscapedEnemyInfo;

		// Token: 0x040123F2 RID: 74738
		[Token(Token = "0x40123F2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ReqPrepareReady;

		// Token: 0x040123F3 RID: 74739
		[Token(Token = "0x40123F3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleEnemyEscape;

		// Token: 0x040123F4 RID: 74740
		[Token(Token = "0x40123F4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleEnemyKilled;

		// Token: 0x040123F5 RID: 74741
		[Token(Token = "0x40123F5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleInfoUp;

		// Token: 0x040123F6 RID: 74742
		[Token(Token = "0x40123F6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ReqHelpBattleEnemyEscape;

		// Token: 0x040123F7 RID: 74743
		[Token(Token = "0x40123F7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ReqHelpBattleEnemyKilled;

		// Token: 0x040123F8 RID: 74744
		[Token(Token = "0x40123F8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ConvertToKillRecord;

		// Token: 0x040123F9 RID: 74745
		[Token(Token = "0x40123F9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ReqAddBondStackCount;

		// Token: 0x040123FA RID: 74746
		[Token(Token = "0x40123FA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ReqObOtherPlayer;

		// Token: 0x040123FB RID: 74747
		[Token(Token = "0x40123FB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ReqCancelOb;

		// Token: 0x040123FC RID: 74748
		[Token(Token = "0x40123FC")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ReqDeadAutoOb;

		// Token: 0x040123FD RID: 74749
		[Token(Token = "0x40123FD")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_ReqSpPrepareSelect;

		// Token: 0x040123FE RID: 74750
		[Token(Token = "0x40123FE")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ReqSelfChoiceSelect;

		// Token: 0x040123FF RID: 74751
		[Token(Token = "0x40123FF")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ReqSendEmoji;

		// Token: 0x04012400 RID: 74752
		[Token(Token = "0x4012400")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_ReqSendBroadcast;

		// Token: 0x04012401 RID: 74753
		[Token(Token = "0x4012401")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ReqGiveUp;

		// Token: 0x04012402 RID: 74754
		[Token(Token = "0x4012402")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ReqPauseSingleMode;

		// Token: 0x04012403 RID: 74755
		[Token(Token = "0x4012403")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ReqResumeSingleMode;

		// Token: 0x04012404 RID: 74756
		[Token(Token = "0x4012404")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_ReqBattleSceneActionUp;

		// Token: 0x04012405 RID: 74757
		[Token(Token = "0x4012405")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200273D RID: 10045
		[Token(Token = "0x200273D")]
		private class ReqAutoResender : IHotfixable
		{
			// Token: 0x0601052A RID: 66858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601052A")]
			[Address(RVA = "0x80AC10", Offset = "0x809810", VA = "0x18080AC10")]
			public ReqAutoResender(AutoChessDataBridgeMultiPlayer dataBridge)
			{
			}

			// Token: 0x0601052B RID: 66859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601052B")]
			[Address(RVA = "0x80AA30", Offset = "0x809630", VA = "0x18080AA30")]
			public void Start()
			{
			}

			// Token: 0x0601052C RID: 66860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601052C")]
			[Address(RVA = "0x80A7F0", Offset = "0x8093F0", VA = "0x18080A7F0")]
			public void Finish()
			{
			}

			// Token: 0x0601052D RID: 66861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601052D")]
			[Address(RVA = "0x80A9C0", Offset = "0x8095C0", VA = "0x18080A9C0")]
			public void SetDesiredPlayerState(AutoChessPlayerGameStateType state)
			{
			}

			// Token: 0x0601052E RID: 66862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601052E")]
			[Address(RVA = "0x80A890", Offset = "0x809490", VA = "0x18080A890")]
			public void Refresh(AutoChessDataCenter dataCenter)
			{
			}

			// Token: 0x0601052F RID: 66863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601052F")]
			[Address(RVA = "0x80AB60", Offset = "0x809760", VA = "0x18080AB60")]
			private IEnumerator _AutoResendReqViaState()
			{
				return null;
			}

			// Token: 0x04012406 RID: 74758
			[Token(Token = "0x4012406")]
			private const float AUTO_RESEND_REQ_TICK = 3f;

			// Token: 0x04012407 RID: 74759
			[Token(Token = "0x4012407")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessDataBridgeMultiPlayer m_dataBridge;

			// Token: 0x04012408 RID: 74760
			[Token(Token = "0x4012408")]
			[FieldOffset(Offset = "0x18")]
			private IEnumerator m_coroutine;

			// Token: 0x04012409 RID: 74761
			[Token(Token = "0x4012409")]
			[FieldOffset(Offset = "0x20")]
			private bool m_needResend;

			// Token: 0x0401240A RID: 74762
			[Token(Token = "0x401240A")]
			[FieldOffset(Offset = "0x24")]
			private AutoChessPlayerGameStateType m_desiredPlayerState;

			// Token: 0x0401240B RID: 74763
			[Token(Token = "0x401240B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401240C RID: 74764
			[Token(Token = "0x401240C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Start;

			// Token: 0x0401240D RID: 74765
			[Token(Token = "0x401240D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Finish;

			// Token: 0x0401240E RID: 74766
			[Token(Token = "0x401240E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetDesiredPlayerState;

			// Token: 0x0401240F RID: 74767
			[Token(Token = "0x401240F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Refresh;

			// Token: 0x04012410 RID: 74768
			[Token(Token = "0x4012410")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__AutoResendReqViaState;
		}
	}
}
