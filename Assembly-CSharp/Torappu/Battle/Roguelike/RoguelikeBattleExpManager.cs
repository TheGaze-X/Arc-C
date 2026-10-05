using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200291B RID: 10523
	[Token(Token = "0x200291B")]
	public class RoguelikeBattleExpManager : IHotfixable
	{
		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x06011729 RID: 71465 RVA: 0x0006B520 File Offset: 0x00069720
		[Token(Token = "0x17002691")]
		public int totalExp
		{
			[Token(Token = "0x6011729")]
			[Address(RVA = "0x946E70", Offset = "0x945A70", VA = "0x180946E70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601172A RID: 71466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601172A")]
		[Address(RVA = "0x9461D0", Offset = "0x944DD0", VA = "0x1809461D0")]
		public void Init(RoguelikeInput input)
		{
		}

		// Token: 0x0601172B RID: 71467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601172B")]
		[Address(RVA = "0x946420", Offset = "0x945020", VA = "0x180946420")]
		public void LogEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x0601172C RID: 71468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601172C")]
		[Address(RVA = "0x946610", Offset = "0x945210", VA = "0x180946610")]
		public void LogTrapGainedExp(string trapId, int exp)
		{
		}

		// Token: 0x0601172D RID: 71469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601172D")]
		[Address(RVA = "0x946B50", Offset = "0x945750", VA = "0x180946B50")]
		private void _LogEnemyKilledCnt(int levelType)
		{
		}

		// Token: 0x0601172E RID: 71470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601172E")]
		[Address(RVA = "0x946820", Offset = "0x945420", VA = "0x180946820")]
		private void _AddToTotalExpAndLog(int exp)
		{
		}

		// Token: 0x0601172F RID: 71471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601172F")]
		[Address(RVA = "0x946C10", Offset = "0x945810", VA = "0x180946C10")]
		private void _LogTrapExp(string trapId, int exp)
		{
		}

		// Token: 0x06011730 RID: 71472 RVA: 0x0006B538 File Offset: 0x00069738
		[Token(Token = "0x6011730")]
		[Address(RVA = "0x9468D0", Offset = "0x9454D0", VA = "0x1809468D0")]
		private bool _CheckValidEnemyKill(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x06011731 RID: 71473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011731")]
		[Address(RVA = "0x946990", Offset = "0x945590", VA = "0x180946990")]
		private void _InitLogStrs()
		{
		}

		// Token: 0x06011732 RID: 71474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011732")]
		[Address(RVA = "0x946D90", Offset = "0x945990", VA = "0x180946D90")]
		public RoguelikeBattleExpManager()
		{
		}

		// Token: 0x040137C7 RID: 79815
		[Token(Token = "0x40137C7")]
		private const string ROGUELIKE_BATTLE_EXP_HEAD = "ROGUELIKE_EXP";

		// Token: 0x040137C8 RID: 79816
		[Token(Token = "0x40137C8")]
		private const string ROGUELIKE_BATTLE_EXP_ENEMY_KILLED = "ENEMY_KILLED";

		// Token: 0x040137C9 RID: 79817
		[Token(Token = "0x40137C9")]
		private const string ROGUELIKE_BATTLE_EXP_TRAP_EXP = "TRAP_EXP";

		// Token: 0x040137CA RID: 79818
		[Token(Token = "0x40137CA")]
		private const string ROGUELIKE_BATTLE_EXP_SUM = "SUM";

		// Token: 0x040137CB RID: 79819
		[Token(Token = "0x40137CB")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeInput m_input;

		// Token: 0x040137CC RID: 79820
		[Token(Token = "0x40137CC")]
		[FieldOffset(Offset = "0x18")]
		private int[] m_enemyExpPattern;

		// Token: 0x040137CD RID: 79821
		[Token(Token = "0x40137CD")]
		[FieldOffset(Offset = "0x20")]
		private int m_totalExp;

		// Token: 0x040137CE RID: 79822
		[Token(Token = "0x40137CE")]
		[FieldOffset(Offset = "0x28")]
		private string[] m_enemyKillCntLogKeys;

		// Token: 0x040137CF RID: 79823
		[Token(Token = "0x40137CF")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> m_trapExpLogStrs;

		// Token: 0x040137D0 RID: 79824
		[Token(Token = "0x40137D0")]
		[FieldOffset(Offset = "0x38")]
		private string m_totalExpLogKey;

		// Token: 0x040137D1 RID: 79825
		[Token(Token = "0x40137D1")]
		[FieldOffset(Offset = "0x40")]
		private bool m_initialized;

		// Token: 0x040137D2 RID: 79826
		[Token(Token = "0x40137D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalExp;

		// Token: 0x040137D3 RID: 79827
		[Token(Token = "0x40137D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040137D4 RID: 79828
		[Token(Token = "0x40137D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LogEnemyKilled;

		// Token: 0x040137D5 RID: 79829
		[Token(Token = "0x40137D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LogTrapGainedExp;

		// Token: 0x040137D6 RID: 79830
		[Token(Token = "0x40137D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LogEnemyKilledCnt;

		// Token: 0x040137D7 RID: 79831
		[Token(Token = "0x40137D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddToTotalExpAndLog;

		// Token: 0x040137D8 RID: 79832
		[Token(Token = "0x40137D8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LogTrapExp;

		// Token: 0x040137D9 RID: 79833
		[Token(Token = "0x40137D9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckValidEnemyKill;

		// Token: 0x040137DA RID: 79834
		[Token(Token = "0x40137DA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitLogStrs;

		// Token: 0x040137DB RID: 79835
		[Token(Token = "0x40137DB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
