using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002738 RID: 10040
	[Token(Token = "0x2002738")]
	public class AutoChessDataBridgeLocalPlayer : AutoChessDataBridge
	{
		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x060104AF RID: 66735 RVA: 0x000637B0 File Offset: 0x000619B0
		[Token(Token = "0x17002396")]
		public override DateTime currentTime
		{
			[Token(Token = "0x60104AF")]
			[Address(RVA = "0x7FE9F0", Offset = "0x7FD5F0", VA = "0x1807FE9F0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x060104B0 RID: 66736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B0")]
		[Address(RVA = "0x7FE570", Offset = "0x7FD170", VA = "0x1807FE570")]
		public AutoChessDataBridgeLocalPlayer()
		{
		}

		// Token: 0x060104B1 RID: 66737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B1")]
		[Address(RVA = "0x7F8D30", Offset = "0x7F7930", VA = "0x1807F8D30", Slot = "5")]
		public override void ReqLoadReady()
		{
		}

		// Token: 0x060104B2 RID: 66738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B2")]
		[Address(RVA = "0x7FA040", Offset = "0x7F8C40", VA = "0x1807FA040", Slot = "6")]
		public override void Start()
		{
		}

		// Token: 0x060104B3 RID: 66739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B3")]
		[Address(RVA = "0x7F76E0", Offset = "0x7F62E0", VA = "0x1807F76E0", Slot = "7")]
		public override void Finish()
		{
		}

		// Token: 0x060104B4 RID: 66740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B4")]
		[Address(RVA = "0x7F8730", Offset = "0x7F7330", VA = "0x1807F8730", Slot = "8")]
		public override void ReqBuyChess(int slotId, bool isSpecial, Action sucAction)
		{
		}

		// Token: 0x060104B5 RID: 66741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B5")]
		[Address(RVA = "0x7F9920", Offset = "0x7F8520", VA = "0x1807F9920", Slot = "9")]
		public override void ReqShopFrozen(bool isFrozen)
		{
		}

		// Token: 0x060104B6 RID: 66742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B6")]
		[Address(RVA = "0x7F9C10", Offset = "0x7F8810", VA = "0x1807F9C10", Slot = "10")]
		public override void ReqShopUpgrade()
		{
		}

		// Token: 0x060104B7 RID: 66743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B7")]
		[Address(RVA = "0x7F9A80", Offset = "0x7F8680", VA = "0x1807F9A80", Slot = "11")]
		public override void ReqShopRefresh()
		{
		}

		// Token: 0x060104B8 RID: 66744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B8")]
		[Address(RVA = "0x7F8D90", Offset = "0x7F7990", VA = "0x1807F8D90", Slot = "12")]
		public override void ReqMoveChess()
		{
		}

		// Token: 0x060104B9 RID: 66745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104B9")]
		[Address(RVA = "0x7F9FE0", Offset = "0x7F8BE0", VA = "0x1807F9FE0", Slot = "13")]
		public override void ReqUseMagic(int instId)
		{
		}

		// Token: 0x060104BA RID: 66746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104BA")]
		[Address(RVA = "0x7F8AD0", Offset = "0x7F76D0", VA = "0x1807F8AD0", Slot = "14")]
		public override void ReqEquipItem(int equipInst, int targetInst, int replacedEquipInstId)
		{
		}

		// Token: 0x060104BB RID: 66747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104BB")]
		[Address(RVA = "0x7F91A0", Offset = "0x7F7DA0", VA = "0x1807F91A0", Slot = "17")]
		public override void ReqPrepareReady(bool isReady)
		{
		}

		// Token: 0x060104BC RID: 66748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104BC")]
		[Address(RVA = "0x7F82F0", Offset = "0x7F6EF0", VA = "0x1807F82F0", Slot = "23")]
		public override void ReqAddBondStackCount(int charInstId, List<string> bondIds, int count)
		{
		}

		// Token: 0x060104BD RID: 66749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104BD")]
		[Address(RVA = "0x7F8C30", Offset = "0x7F7830", VA = "0x1807F8C30", Slot = "21")]
		public override void ReqHelpBattleEnemyEscape(int enemyInstId, bool isToken)
		{
		}

		// Token: 0x060104BE RID: 66750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104BE")]
		[Address(RVA = "0x7F9550", Offset = "0x7F8150", VA = "0x1807F9550", Slot = "20")]
		public override void ReqSelfBattleInfoUp()
		{
		}

		// Token: 0x060104BF RID: 66751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104BF")]
		[Address(RVA = "0x7F9280", Offset = "0x7F7E80", VA = "0x1807F9280", Slot = "18")]
		public override void ReqSelfBattleEnemyEscape(int enemyInstId, bool isToken)
		{
		}

		// Token: 0x060104C0 RID: 66752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C0")]
		[Address(RVA = "0x7F94D0", Offset = "0x7F80D0", VA = "0x1807F94D0", Slot = "19")]
		public override void ReqSelfBattleEnemyKilled(BattleEnemyKilledInfo killedInfo)
		{
		}

		// Token: 0x060104C1 RID: 66753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C1")]
		[Address(RVA = "0x7F8CB0", Offset = "0x7F78B0", VA = "0x1807F8CB0", Slot = "22")]
		public override void ReqHelpBattleEnemyKilled(HelpBattleEnemyKilledInfo killedInfo)
		{
		}

		// Token: 0x060104C2 RID: 66754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C2")]
		[Address(RVA = "0x7F90E0", Offset = "0x7F7CE0", VA = "0x1807F90E0", Slot = "24")]
		public override void ReqObOtherPlayer(int playerIndex)
		{
		}

		// Token: 0x060104C3 RID: 66755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C3")]
		[Address(RVA = "0x7F8A10", Offset = "0x7F7610", VA = "0x1807F8A10", Slot = "25")]
		public override void ReqCancelOb()
		{
		}

		// Token: 0x060104C4 RID: 66756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C4")]
		[Address(RVA = "0x7F8A70", Offset = "0x7F7670", VA = "0x1807F8A70", Slot = "26")]
		public override void ReqDeadAutoOb()
		{
		}

		// Token: 0x060104C5 RID: 66757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C5")]
		[Address(RVA = "0x7F9D00", Offset = "0x7F8900", VA = "0x1807F9D00", Slot = "27")]
		public override void ReqSpPrepareSelect(int slotId)
		{
		}

		// Token: 0x060104C6 RID: 66758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C6")]
		[Address(RVA = "0x7F9610", Offset = "0x7F8210", VA = "0x1807F9610", Slot = "15")]
		public override void ReqSellOrDestroy(GridPosition gridPosition)
		{
		}

		// Token: 0x060104C7 RID: 66759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C7")]
		[Address(RVA = "0x7F8380", Offset = "0x7F6F80", VA = "0x1807F8380", Slot = "16")]
		public override void ReqBattleFinish(BattleController.GameResult result)
		{
		}

		// Token: 0x060104C8 RID: 66760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C8")]
		[Address(RVA = "0x7F95B0", Offset = "0x7F81B0", VA = "0x1807F95B0", Slot = "28")]
		public override void ReqSelfChoiceSelect(int slotId)
		{
		}

		// Token: 0x060104C9 RID: 66761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104C9")]
		[Address(RVA = "0x7F98A0", Offset = "0x7F84A0", VA = "0x1807F98A0", Slot = "29")]
		public override void ReqSendEmoji(string grp, string id)
		{
		}

		// Token: 0x060104CA RID: 66762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104CA")]
		[Address(RVA = "0x7F9810", Offset = "0x7F8410", VA = "0x1807F9810", Slot = "30")]
		public override void ReqSendBroadcast(int playerIdx, string id, IList<string> param)
		{
		}

		// Token: 0x060104CB RID: 66763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104CB")]
		[Address(RVA = "0x7F8BA0", Offset = "0x7F77A0", VA = "0x1807F8BA0", Slot = "31")]
		public override void ReqGiveUp()
		{
		}

		// Token: 0x060104CC RID: 66764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104CC")]
		[Address(RVA = "0x7F86B0", Offset = "0x7F72B0", VA = "0x1807F86B0", Slot = "32")]
		public override void ReqBattleSceneActionUp(int seq, List<AutoChessBattleStepActionData> actions)
		{
		}

		// Token: 0x060104CD RID: 66765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104CD")]
		[Address(RVA = "0x7F9140", Offset = "0x7F7D40", VA = "0x1807F9140", Slot = "33")]
		public override void ReqPauseSingleMode()
		{
		}

		// Token: 0x060104CE RID: 66766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104CE")]
		[Address(RVA = "0x7F9220", Offset = "0x7F7E20", VA = "0x1807F9220", Slot = "34")]
		public override void ReqResumeSingleMode()
		{
		}

		// Token: 0x060104CF RID: 66767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104CF")]
		[Address(RVA = "0x7FE210", Offset = "0x7FCE10", VA = "0x1807FE210")]
		private void _StartBattle()
		{
		}

		// Token: 0x060104D0 RID: 66768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D0")]
		[Address(RVA = "0x7FE3E0", Offset = "0x7FCFE0", VA = "0x1807FE3E0")]
		private void _UpdateAllPlayerState(AutoChessPlayerGameStateType state)
		{
		}

		// Token: 0x060104D1 RID: 66769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D1")]
		[Address(RVA = "0x7FBD00", Offset = "0x7FA900", VA = "0x1807FBD00")]
		private void _HandleTutorialLockDrag(object arg)
		{
		}

		// Token: 0x060104D2 RID: 66770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D2")]
		[Address(RVA = "0x7FBD70", Offset = "0x7FA970", VA = "0x1807FBD70")]
		private void _HandleTutorialUnlockDrag(object arg)
		{
		}

		// Token: 0x060104D3 RID: 66771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D3")]
		[Address(RVA = "0x7F77E0", Offset = "0x7F63E0", VA = "0x1807F77E0", Slot = "35")]
		protected virtual void GenerateLocalSave()
		{
		}

		// Token: 0x060104D4 RID: 66772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D4")]
		[Address(RVA = "0x7FC590", Offset = "0x7FB190", VA = "0x1807FC590")]
		private void _LoadSelfStaticData(ActAutoChessData.ActAutoChessConstData actConstData)
		{
		}

		// Token: 0x060104D5 RID: 66773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D5")]
		[Address(RVA = "0x7FBDE0", Offset = "0x7FA9E0", VA = "0x1807FBDE0")]
		private void _LoadNpcStaticData(AutoChessBattleMiscConfig miscConfig)
		{
		}

		// Token: 0x060104D6 RID: 66774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D6")]
		[Address(RVA = "0x7FC180", Offset = "0x7FAD80", VA = "0x1807FC180")]
		private void _LoadRunTimeData(ActAutoChessData.ActAutoChessConstData actConstData, AutoChessBattleMiscConfig miscConfig)
		{
		}

		// Token: 0x060104D7 RID: 66775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60104D7")]
		[Address(RVA = "0x7F7630", Offset = "0x7F6230", VA = "0x1807F7630", Slot = "36")]
		protected virtual IEnumerator FinishLoading()
		{
			return null;
		}

		// Token: 0x060104D8 RID: 66776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60104D8")]
		[Address(RVA = "0x7F7A90", Offset = "0x7F6690", VA = "0x1807F7A90", Slot = "37")]
		protected virtual List<SquadSlot> GetSquadSlots()
		{
			return null;
		}

		// Token: 0x060104D9 RID: 66777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104D9")]
		[Address(RVA = "0x7FCE80", Offset = "0x7FBA80", VA = "0x1807FCE80")]
		private void _RefreshRoundData(int round)
		{
		}

		// Token: 0x060104DA RID: 66778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60104DA")]
		[Address(RVA = "0x7FB830", Offset = "0x7FA430", VA = "0x1807FB830")]
		private SpPrepareStateData _GeneSpPrepareStateDataFromRoundInfo(SpPrepareStateData roundSpPrepData)
		{
			return null;
		}

		// Token: 0x060104DB RID: 66779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104DB")]
		[Address(RVA = "0x7FD4A0", Offset = "0x7FC0A0", VA = "0x1807FD4A0")]
		private void _RefreshShopData()
		{
		}

		// Token: 0x060104DC RID: 66780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60104DC")]
		[Address(RVA = "0x7FBB00", Offset = "0x7FA700", VA = "0x1807FBB00")]
		private AutoChessBattleMiscConfig.TrainingShopInfo _GetRandomShopItem(List<AutoChessBattleMiscConfig.TrainingShopInfo> shopInfo)
		{
			return null;
		}

		// Token: 0x060104DD RID: 66781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104DD")]
		[Address(RVA = "0x7FAE80", Offset = "0x7F9A80", VA = "0x1807FAE80")]
		private void _EquipItem(int equipInst, int targetInst)
		{
		}

		// Token: 0x060104DE RID: 66782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104DE")]
		[Address(RVA = "0x7FDE20", Offset = "0x7FCA20", VA = "0x1807FDE20")]
		private void _ReplaceEquipItem(int equipInst, int targetInst, int replacedEquipInstId)
		{
		}

		// Token: 0x060104DF RID: 66783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104DF")]
		[Address(RVA = "0x7FA220", Offset = "0x7F8E20", VA = "0x1807FA220")]
		private void _AddOwnedChess(PlayerBattleData data, string chessId)
		{
		}

		// Token: 0x060104E0 RID: 66784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E0")]
		[Address(RVA = "0x7FA720", Offset = "0x7F9320", VA = "0x1807FA720")]
		private void _BonusWhenOwnedCharChess(PlayerBattleData data, string chessId)
		{
		}

		// Token: 0x060104E1 RID: 66785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E1")]
		[Address(RVA = "0x7FC8E0", Offset = "0x7FB4E0", VA = "0x1807FC8E0")]
		private void _RefreshBonusShop()
		{
		}

		// Token: 0x060104E2 RID: 66786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E2")]
		[Address(RVA = "0x7FAC00", Offset = "0x7F9800", VA = "0x1807FAC00")]
		private void _BonusWhenOwnedEquipChess(PlayerBattleData data, string chessId)
		{
		}

		// Token: 0x060104E3 RID: 66787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E3")]
		[Address(RVA = "0x7FDB40", Offset = "0x7FC740", VA = "0x1807FDB40")]
		private void _RemoveOwnedChess(PlayerBattleData data, int instId)
		{
		}

		// Token: 0x060104E4 RID: 66788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E4")]
		[Address(RVA = "0x7F80B0", Offset = "0x7F6CB0", VA = "0x1807F80B0")]
		public void OnMessage()
		{
		}

		// Token: 0x060104E5 RID: 66789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E5")]
		[Address(RVA = "0x7FC7B0", Offset = "0x7FB3B0", VA = "0x1807FC7B0")]
		private void _MoveToNextRound()
		{
		}

		// Token: 0x060104E6 RID: 66790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E6")]
		[Address(RVA = "0x7FB560", Offset = "0x7FA160", VA = "0x1807FB560")]
		private void _GatherSelfBattleEnemy()
		{
		}

		// Token: 0x060104E7 RID: 66791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E7")]
		[Address(RVA = "0x7FB230", Offset = "0x7F9E30", VA = "0x1807FB230")]
		private void _GatherBossBattleEnemy()
		{
		}

		// Token: 0x060104E8 RID: 66792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E8")]
		[Address(RVA = "0x7F7EE0", Offset = "0x7F6AE0", VA = "0x1807F7EE0")]
		public void OnBossBattleEnemyRegistered(Enemy enemy)
		{
		}

		// Token: 0x060104E9 RID: 66793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104E9")]
		[Address(RVA = "0x7F7DC0", Offset = "0x7F69C0", VA = "0x1807F7DC0")]
		public void OnBossBattleEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x060104EA RID: 66794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104EA")]
		[Address(RVA = "0x7F7E50", Offset = "0x7F6A50", VA = "0x1807F7E50")]
		public void OnBossBattleEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x04012379 RID: 74617
		[Token(Token = "0x4012379")]
		private const int LOCAL_ID_START = 10000;

		// Token: 0x0401237A RID: 74618
		[Token(Token = "0x401237A")]
		private const int BONUS_SHOP_ITEM_COUNT = 3;

		// Token: 0x0401237B RID: 74619
		[Token(Token = "0x401237B")]
		private const int CHAR_BONUS_COUNT = 3;

		// Token: 0x0401237C RID: 74620
		[Token(Token = "0x401237C")]
		private const int EQUIP_BONUS_COUNT = 2;

		// Token: 0x0401237D RID: 74621
		[Token(Token = "0x401237D")]
		[FieldOffset(Offset = "0x10")]
		private int m_generateId;

		// Token: 0x0401237E RID: 74622
		[Token(Token = "0x401237E")]
		[FieldOffset(Offset = "0x18")]
		protected LocalSave m_localSave;

		// Token: 0x0401237F RID: 74623
		[Token(Token = "0x401237F")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, ActAutoChessData.ActAutoChessShopLevelData> m_shopLevelConfig;

		// Token: 0x04012380 RID: 74624
		[Token(Token = "0x4012380")]
		[FieldOffset(Offset = "0x28")]
		protected AutoChessDataBridgeLocalPlayer.MockGarrisonManager m_mockGarrisonManager;

		// Token: 0x04012381 RID: 74625
		[Token(Token = "0x4012381")]
		[FieldOffset(Offset = "0x30")]
		protected AutoChessDataBridgeLocalPlayer.MockBossBattleManager m_mockBossBattleManager;

		// Token: 0x04012382 RID: 74626
		[Token(Token = "0x4012382")]
		[FieldOffset(Offset = "0x38")]
		private List<EscapedEnemyInfo> m_escapedEnemyInfos;

		// Token: 0x04012383 RID: 74627
		[Token(Token = "0x4012383")]
		[FieldOffset(Offset = "0x40")]
		private int m_selfPlayerIndex;

		// Token: 0x04012384 RID: 74628
		[Token(Token = "0x4012384")]
		[FieldOffset(Offset = "0x48")]
		private List<ChessGoods> m_cachedGoods;

		// Token: 0x04012385 RID: 74629
		[Token(Token = "0x4012385")]
		[FieldOffset(Offset = "0x50")]
		private int m_maxShopLevel;

		// Token: 0x04012386 RID: 74630
		[Token(Token = "0x4012386")]
		[FieldOffset(Offset = "0x54")]
		private bool m_dragLocked;

		// Token: 0x04012387 RID: 74631
		[Token(Token = "0x4012387")]
		[FieldOffset(Offset = "0x58")]
		private List<AutoChessBattleMiscConfig.TrainingShopInfo> m_bonusShopInfo;

		// Token: 0x04012388 RID: 74632
		[Token(Token = "0x4012388")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04012389 RID: 74633
		[Token(Token = "0x4012389")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401238A RID: 74634
		[Token(Token = "0x401238A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReqLoadReady;

		// Token: 0x0401238B RID: 74635
		[Token(Token = "0x401238B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401238C RID: 74636
		[Token(Token = "0x401238C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Finish;

		// Token: 0x0401238D RID: 74637
		[Token(Token = "0x401238D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReqBuyChess;

		// Token: 0x0401238E RID: 74638
		[Token(Token = "0x401238E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReqShopFrozen;

		// Token: 0x0401238F RID: 74639
		[Token(Token = "0x401238F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReqShopUpgrade;

		// Token: 0x04012390 RID: 74640
		[Token(Token = "0x4012390")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ReqShopRefresh;

		// Token: 0x04012391 RID: 74641
		[Token(Token = "0x4012391")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ReqMoveChess;

		// Token: 0x04012392 RID: 74642
		[Token(Token = "0x4012392")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReqUseMagic;

		// Token: 0x04012393 RID: 74643
		[Token(Token = "0x4012393")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ReqEquipItem;

		// Token: 0x04012394 RID: 74644
		[Token(Token = "0x4012394")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ReqPrepareReady;

		// Token: 0x04012395 RID: 74645
		[Token(Token = "0x4012395")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ReqAddBondStackCount;

		// Token: 0x04012396 RID: 74646
		[Token(Token = "0x4012396")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ReqHelpBattleEnemyEscape;

		// Token: 0x04012397 RID: 74647
		[Token(Token = "0x4012397")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleInfoUp;

		// Token: 0x04012398 RID: 74648
		[Token(Token = "0x4012398")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleEnemyEscape;

		// Token: 0x04012399 RID: 74649
		[Token(Token = "0x4012399")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleEnemyKilled;

		// Token: 0x0401239A RID: 74650
		[Token(Token = "0x401239A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ReqHelpBattleEnemyKilled;

		// Token: 0x0401239B RID: 74651
		[Token(Token = "0x401239B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReqObOtherPlayer;

		// Token: 0x0401239C RID: 74652
		[Token(Token = "0x401239C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ReqCancelOb;

		// Token: 0x0401239D RID: 74653
		[Token(Token = "0x401239D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ReqDeadAutoOb;

		// Token: 0x0401239E RID: 74654
		[Token(Token = "0x401239E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ReqSpPrepareSelect;

		// Token: 0x0401239F RID: 74655
		[Token(Token = "0x401239F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ReqSellOrDestroy;

		// Token: 0x040123A0 RID: 74656
		[Token(Token = "0x40123A0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ReqBattleFinish;

		// Token: 0x040123A1 RID: 74657
		[Token(Token = "0x40123A1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ReqSelfChoiceSelect;

		// Token: 0x040123A2 RID: 74658
		[Token(Token = "0x40123A2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ReqSendEmoji;

		// Token: 0x040123A3 RID: 74659
		[Token(Token = "0x40123A3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ReqSendBroadcast;

		// Token: 0x040123A4 RID: 74660
		[Token(Token = "0x40123A4")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ReqGiveUp;

		// Token: 0x040123A5 RID: 74661
		[Token(Token = "0x40123A5")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ReqBattleSceneActionUp;

		// Token: 0x040123A6 RID: 74662
		[Token(Token = "0x40123A6")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_ReqPauseSingleMode;

		// Token: 0x040123A7 RID: 74663
		[Token(Token = "0x40123A7")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ReqResumeSingleMode;

		// Token: 0x040123A8 RID: 74664
		[Token(Token = "0x40123A8")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__StartBattle;

		// Token: 0x040123A9 RID: 74665
		[Token(Token = "0x40123A9")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UpdateAllPlayerState;

		// Token: 0x040123AA RID: 74666
		[Token(Token = "0x40123AA")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__HandleTutorialLockDrag;

		// Token: 0x040123AB RID: 74667
		[Token(Token = "0x40123AB")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__HandleTutorialUnlockDrag;

		// Token: 0x040123AC RID: 74668
		[Token(Token = "0x40123AC")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GenerateLocalSave;

		// Token: 0x040123AD RID: 74669
		[Token(Token = "0x40123AD")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__LoadSelfStaticData;

		// Token: 0x040123AE RID: 74670
		[Token(Token = "0x40123AE")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__LoadNpcStaticData;

		// Token: 0x040123AF RID: 74671
		[Token(Token = "0x40123AF")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__LoadRunTimeData;

		// Token: 0x040123B0 RID: 74672
		[Token(Token = "0x40123B0")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_FinishLoading;

		// Token: 0x040123B1 RID: 74673
		[Token(Token = "0x40123B1")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetSquadSlots;

		// Token: 0x040123B2 RID: 74674
		[Token(Token = "0x40123B2")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__RefreshRoundData;

		// Token: 0x040123B3 RID: 74675
		[Token(Token = "0x40123B3")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__GeneSpPrepareStateDataFromRoundInfo;

		// Token: 0x040123B4 RID: 74676
		[Token(Token = "0x40123B4")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__RefreshShopData;

		// Token: 0x040123B5 RID: 74677
		[Token(Token = "0x40123B5")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GetRandomShopItem;

		// Token: 0x040123B6 RID: 74678
		[Token(Token = "0x40123B6")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__EquipItem;

		// Token: 0x040123B7 RID: 74679
		[Token(Token = "0x40123B7")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__ReplaceEquipItem;

		// Token: 0x040123B8 RID: 74680
		[Token(Token = "0x40123B8")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__AddOwnedChess;

		// Token: 0x040123B9 RID: 74681
		[Token(Token = "0x40123B9")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__BonusWhenOwnedCharChess;

		// Token: 0x040123BA RID: 74682
		[Token(Token = "0x40123BA")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__RefreshBonusShop;

		// Token: 0x040123BB RID: 74683
		[Token(Token = "0x40123BB")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__BonusWhenOwnedEquipChess;

		// Token: 0x040123BC RID: 74684
		[Token(Token = "0x40123BC")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__RemoveOwnedChess;

		// Token: 0x040123BD RID: 74685
		[Token(Token = "0x40123BD")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040123BE RID: 74686
		[Token(Token = "0x40123BE")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__MoveToNextRound;

		// Token: 0x040123BF RID: 74687
		[Token(Token = "0x40123BF")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__GatherSelfBattleEnemy;

		// Token: 0x040123C0 RID: 74688
		[Token(Token = "0x40123C0")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__GatherBossBattleEnemy;

		// Token: 0x040123C1 RID: 74689
		[Token(Token = "0x40123C1")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_OnBossBattleEnemyRegistered;

		// Token: 0x040123C2 RID: 74690
		[Token(Token = "0x40123C2")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_OnBossBattleEnemyKilled;

		// Token: 0x040123C3 RID: 74691
		[Token(Token = "0x40123C3")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_OnBossBattleEnemyReachExit;

		// Token: 0x02002739 RID: 10041
		[Token(Token = "0x2002739")]
		public class MockBossBattleManager : IHotfixable
		{
			// Token: 0x060104EB RID: 66795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104EB")]
			[Address(RVA = "0x808DB0", Offset = "0x8079B0", VA = "0x180808DB0")]
			public void Start()
			{
			}

			// Token: 0x060104EC RID: 66796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104EC")]
			[Address(RVA = "0x808C40", Offset = "0x807840", VA = "0x180808C40")]
			public void OnBossBattleEnemyRegistered(Enemy enemy)
			{
			}

			// Token: 0x060104ED RID: 66797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104ED")]
			[Address(RVA = "0x8088A0", Offset = "0x8074A0", VA = "0x1808088A0")]
			public void OnBossBattleEnemyKilled(Enemy enemy)
			{
			}

			// Token: 0x060104EE RID: 66798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104EE")]
			[Address(RVA = "0x808A50", Offset = "0x807650", VA = "0x180808A50")]
			public void OnBossBattleEnemyReachExit(Enemy enemy)
			{
			}

			// Token: 0x060104EF RID: 66799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104EF")]
			[Address(RVA = "0x808E60", Offset = "0x807A60", VA = "0x180808E60")]
			private void _OnAfterBossEnemyTakeDamage(object arg)
			{
			}

			// Token: 0x060104F0 RID: 66800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104F0")]
			[Address(RVA = "0x8091B0", Offset = "0x807DB0", VA = "0x1808091B0")]
			public MockBossBattleManager()
			{
			}

			// Token: 0x040123C4 RID: 74692
			[Token(Token = "0x40123C4")]
			[FieldOffset(Offset = "0x10")]
			private ObjectPtr<Enemy> m_bossEnemy;

			// Token: 0x040123C5 RID: 74693
			[Token(Token = "0x40123C5")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<int, int> m_enemyEscapeCountDict;

			// Token: 0x040123C6 RID: 74694
			[Token(Token = "0x40123C6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Start;

			// Token: 0x040123C7 RID: 74695
			[Token(Token = "0x40123C7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnBossBattleEnemyRegistered;

			// Token: 0x040123C8 RID: 74696
			[Token(Token = "0x40123C8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnBossBattleEnemyKilled;

			// Token: 0x040123C9 RID: 74697
			[Token(Token = "0x40123C9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnBossBattleEnemyReachExit;

			// Token: 0x040123CA RID: 74698
			[Token(Token = "0x40123CA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__OnAfterBossEnemyTakeDamage;

			// Token: 0x040123CB RID: 74699
			[Token(Token = "0x40123CB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200273A RID: 10042
		[Token(Token = "0x200273A")]
		public class MockGarrisonManager : IHotfixable
		{
			// Token: 0x060104F1 RID: 66801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104F1")]
			[Address(RVA = "0x809940", Offset = "0x808540", VA = "0x180809940")]
			public void Refresh()
			{
			}

			// Token: 0x060104F2 RID: 66802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104F2")]
			[Address(RVA = "0x809260", Offset = "0x807E60", VA = "0x180809260")]
			public void RefreshBondsInfo()
			{
			}

			// Token: 0x060104F3 RID: 66803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104F3")]
			[Address(RVA = "0x809C90", Offset = "0x808890", VA = "0x180809C90")]
			public void _RefreshCurrentCharBondInfos()
			{
			}

			// Token: 0x060104F4 RID: 66804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60104F4")]
			[Address(RVA = "0x80A170", Offset = "0x808D70", VA = "0x18080A170")]
			public MockGarrisonManager()
			{
			}

			// Token: 0x040123CC RID: 74700
			[Token(Token = "0x40123CC")]
			[FieldOffset(Offset = "0x10")]
			private HashSet<string> m_activedBondKeys;

			// Token: 0x040123CD RID: 74701
			[Token(Token = "0x40123CD")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, List<ChessInst>> m_charBondInfo;

			// Token: 0x040123CE RID: 74702
			[Token(Token = "0x40123CE")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, int> m_charBondCountInfo;

			// Token: 0x040123CF RID: 74703
			[Token(Token = "0x40123CF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Refresh;

			// Token: 0x040123D0 RID: 74704
			[Token(Token = "0x40123D0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RefreshBondsInfo;

			// Token: 0x040123D1 RID: 74705
			[Token(Token = "0x40123D1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__RefreshCurrentCharBondInfos;

			// Token: 0x040123D2 RID: 74706
			[Token(Token = "0x40123D2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
