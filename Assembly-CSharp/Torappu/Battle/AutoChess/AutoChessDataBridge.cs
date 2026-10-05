using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002736 RID: 10038
	[Token(Token = "0x2002736")]
	public abstract class AutoChessDataBridge : IHotfixable
	{
		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0601048E RID: 66702
		[Token(Token = "0x17002395")]
		public abstract DateTime currentTime { [Token(Token = "0x601048E")] get; }

		// Token: 0x0601048F RID: 66703
		[Token(Token = "0x601048F")]
		public abstract void ReqLoadReady();

		// Token: 0x06010490 RID: 66704
		[Token(Token = "0x6010490")]
		public abstract void Start();

		// Token: 0x06010491 RID: 66705
		[Token(Token = "0x6010491")]
		public abstract void Finish();

		// Token: 0x06010492 RID: 66706
		[Token(Token = "0x6010492")]
		public abstract void ReqBuyChess(int slotId, bool isSpecial, Action sucAction);

		// Token: 0x06010493 RID: 66707
		[Token(Token = "0x6010493")]
		public abstract void ReqShopFrozen(bool isFrozen);

		// Token: 0x06010494 RID: 66708
		[Token(Token = "0x6010494")]
		public abstract void ReqShopUpgrade();

		// Token: 0x06010495 RID: 66709
		[Token(Token = "0x6010495")]
		public abstract void ReqShopRefresh();

		// Token: 0x06010496 RID: 66710
		[Token(Token = "0x6010496")]
		public abstract void ReqMoveChess();

		// Token: 0x06010497 RID: 66711
		[Token(Token = "0x6010497")]
		public abstract void ReqUseMagic(int instId);

		// Token: 0x06010498 RID: 66712
		[Token(Token = "0x6010498")]
		public abstract void ReqEquipItem(int equipInst, int targetInst, int replacedEquipInstId);

		// Token: 0x06010499 RID: 66713
		[Token(Token = "0x6010499")]
		public abstract void ReqSellOrDestroy(GridPosition gridPosition);

		// Token: 0x0601049A RID: 66714
		[Token(Token = "0x601049A")]
		public abstract void ReqBattleFinish(BattleController.GameResult gameResult);

		// Token: 0x0601049B RID: 66715
		[Token(Token = "0x601049B")]
		public abstract void ReqPrepareReady(bool isReady);

		// Token: 0x0601049C RID: 66716
		[Token(Token = "0x601049C")]
		public abstract void ReqSelfBattleEnemyEscape(int enemyInstId, bool isToken);

		// Token: 0x0601049D RID: 66717
		[Token(Token = "0x601049D")]
		public abstract void ReqSelfBattleEnemyKilled(BattleEnemyKilledInfo killedInfo);

		// Token: 0x0601049E RID: 66718
		[Token(Token = "0x601049E")]
		public abstract void ReqSelfBattleInfoUp();

		// Token: 0x0601049F RID: 66719
		[Token(Token = "0x601049F")]
		public abstract void ReqHelpBattleEnemyEscape(int enemyInstId, bool isToken);

		// Token: 0x060104A0 RID: 66720
		[Token(Token = "0x60104A0")]
		public abstract void ReqHelpBattleEnemyKilled(HelpBattleEnemyKilledInfo killedInfo);

		// Token: 0x060104A1 RID: 66721
		[Token(Token = "0x60104A1")]
		public abstract void ReqAddBondStackCount(int charInstId, List<string> bondIds, int count);

		// Token: 0x060104A2 RID: 66722
		[Token(Token = "0x60104A2")]
		public abstract void ReqObOtherPlayer(int playerIndex);

		// Token: 0x060104A3 RID: 66723
		[Token(Token = "0x60104A3")]
		public abstract void ReqCancelOb();

		// Token: 0x060104A4 RID: 66724
		[Token(Token = "0x60104A4")]
		public abstract void ReqDeadAutoOb();

		// Token: 0x060104A5 RID: 66725
		[Token(Token = "0x60104A5")]
		public abstract void ReqSpPrepareSelect(int slotId);

		// Token: 0x060104A6 RID: 66726
		[Token(Token = "0x60104A6")]
		public abstract void ReqSelfChoiceSelect(int slotId);

		// Token: 0x060104A7 RID: 66727
		[Token(Token = "0x60104A7")]
		public abstract void ReqSendEmoji(string grp, string id);

		// Token: 0x060104A8 RID: 66728
		[Token(Token = "0x60104A8")]
		public abstract void ReqSendBroadcast(int playerIndex, string id, IList<string> param);

		// Token: 0x060104A9 RID: 66729
		[Token(Token = "0x60104A9")]
		public abstract void ReqGiveUp();

		// Token: 0x060104AA RID: 66730
		[Token(Token = "0x60104AA")]
		public abstract void ReqBattleSceneActionUp(int seq, List<AutoChessBattleStepActionData> actions);

		// Token: 0x060104AB RID: 66731
		[Token(Token = "0x60104AB")]
		public abstract void ReqPauseSingleMode();

		// Token: 0x060104AC RID: 66732
		[Token(Token = "0x60104AC")]
		public abstract void ReqResumeSingleMode();

		// Token: 0x060104AD RID: 66733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104AD")]
		[Address(RVA = "0x8032E0", Offset = "0x801EE0", VA = "0x1808032E0")]
		protected AutoChessDataBridge()
		{
		}

		// Token: 0x0401236C RID: 74604
		[Token(Token = "0x401236C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
