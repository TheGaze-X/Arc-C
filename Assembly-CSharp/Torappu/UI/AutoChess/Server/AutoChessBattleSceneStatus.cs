using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200641E RID: 25630
	[Token(Token = "0x200641E")]
	public class AutoChessBattleSceneStatus : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E99 RID: 151193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E99")]
		[Address(RVA = "0x1FB36A0", Offset = "0x1FB22A0", VA = "0x181FB36A0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E9A RID: 151194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E9A")]
		[Address(RVA = "0x1FB39A0", Offset = "0x1FB25A0", VA = "0x181FB39A0")]
		public AutoChessBattleSceneStatus()
		{
		}

		// Token: 0x040339CD RID: 211405
		[Token(Token = "0x40339CD")]
		[FieldOffset(Offset = "0x10")]
		public int obUidIndex;

		// Token: 0x040339CE RID: 211406
		[Token(Token = "0x40339CE")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessGameStateType state;

		// Token: 0x040339CF RID: 211407
		[Token(Token = "0x40339CF")]
		[FieldOffset(Offset = "0x18")]
		public int round;

		// Token: 0x040339D0 RID: 211408
		[Token(Token = "0x40339D0")]
		[FieldOffset(Offset = "0x20")]
		public long forceEndTs;

		// Token: 0x040339D1 RID: 211409
		[Token(Token = "0x40339D1")]
		[FieldOffset(Offset = "0x28")]
		public List<AutoChessBattlePlayerRuntimeInfo> runtimePlayers;

		// Token: 0x040339D2 RID: 211410
		[Token(Token = "0x40339D2")]
		[FieldOffset(Offset = "0x30")]
		public List<AutoChessBattleRoundEnemyInfo> roundEnemies;

		// Token: 0x040339D3 RID: 211411
		[Token(Token = "0x40339D3")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessBattleSpPreparationInfo specialPreparation;

		// Token: 0x040339D4 RID: 211412
		[Token(Token = "0x40339D4")]
		[FieldOffset(Offset = "0x40")]
		public AutoChessBattlePreparationStatus preparationStatus;

		// Token: 0x040339D5 RID: 211413
		[Token(Token = "0x40339D5")]
		[FieldOffset(Offset = "0x48")]
		public AutoChessBattleBossRoundInfo bossRoundDetail;

		// Token: 0x040339D6 RID: 211414
		[Token(Token = "0x40339D6")]
		[FieldOffset(Offset = "0x50")]
		public AutoChessBattleSelfBattleInfo selfBattleInfo;

		// Token: 0x040339D7 RID: 211415
		[Token(Token = "0x40339D7")]
		[FieldOffset(Offset = "0x58")]
		public AutoChessBattleHelpBattleInfo helpBattleInfo;

		// Token: 0x040339D8 RID: 211416
		[Token(Token = "0x40339D8")]
		[FieldOffset(Offset = "0x60")]
		public AutoChessBattleBossBattleInfo bossBattleInfo;

		// Token: 0x040339D9 RID: 211417
		[Token(Token = "0x40339D9")]
		[FieldOffset(Offset = "0x68")]
		public List<AutoChessBattleSpecialEffect> specialEffects;

		// Token: 0x040339DA RID: 211418
		[Token(Token = "0x40339DA")]
		[FieldOffset(Offset = "0x70")]
		public List<AutoChessBattlePlayerLastBattleResult> lastBattleResult;

		// Token: 0x040339DB RID: 211419
		[Token(Token = "0x40339DB")]
		[FieldOffset(Offset = "0x78")]
		public AutoChessBattleSettleInfo settleBattleResult;

		// Token: 0x040339DC RID: 211420
		[Token(Token = "0x40339DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339DD RID: 211421
		[Token(Token = "0x40339DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
