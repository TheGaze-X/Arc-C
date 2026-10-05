using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020AB RID: 8363
	[Token(Token = "0x20020AB")]
	public struct BattleStageMeta
	{
		// Token: 0x0600CD9E RID: 52638 RVA: 0x0004A298 File Offset: 0x00048498
		[Token(Token = "0x600CD9E")]
		[Address(RVA = "0x34FA960", Offset = "0x34F9560", VA = "0x1834FA960")]
		public bool DontSaveBattleLog()
		{
			return default(bool);
		}

		// Token: 0x0400D92B RID: 55595
		[Token(Token = "0x400D92B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BattleStageMeta DEFAULT;

		// Token: 0x0400D92C RID: 55596
		[Token(Token = "0x400D92C")]
		[FieldOffset(Offset = "0x0")]
		public BattleStageMeta.BusinessType type;

		// Token: 0x020020AC RID: 8364
		[Token(Token = "0x20020AC")]
		public enum BusinessType
		{
			// Token: 0x0400D92E RID: 55598
			[Token(Token = "0x400D92E")]
			DEFAULT,
			// Token: 0x0400D92F RID: 55599
			[Token(Token = "0x400D92F")]
			CRISIS,
			// Token: 0x0400D930 RID: 55600
			[Token(Token = "0x400D930")]
			HANDBOOK,
			// Token: 0x0400D931 RID: 55601
			[Token(Token = "0x400D931")]
			DEEPSEA,
			// Token: 0x0400D932 RID: 55602
			[Token(Token = "0x400D932")]
			CLIMBTOWER,
			// Token: 0x0400D933 RID: 55603
			[Token(Token = "0x400D933")]
			BOSSRUSH,
			// Token: 0x0400D934 RID: 55604
			[Token(Token = "0x400D934")]
			ACTCART,
			// Token: 0x0400D935 RID: 55605
			[Token(Token = "0x400D935")]
			SIRACUSAMAP,
			// Token: 0x0400D936 RID: 55606
			[Token(Token = "0x400D936")]
			SANDBOX,
			// Token: 0x0400D937 RID: 55607
			[Token(Token = "0x400D937")]
			ACT24SIDE,
			// Token: 0x0400D938 RID: 55608
			[Token(Token = "0x400D938")]
			ACT42D0,
			// Token: 0x0400D939 RID: 55609
			[Token(Token = "0x400D939")]
			CRISIS_V2,
			// Token: 0x0400D93A RID: 55610
			[Token(Token = "0x400D93A")]
			SANDBOX_V2,
			// Token: 0x0400D93B RID: 55611
			[Token(Token = "0x400D93B")]
			SANDBOX_V2_RACING,
			// Token: 0x0400D93C RID: 55612
			[Token(Token = "0x400D93C")]
			TRAINING_CAMP,
			// Token: 0x0400D93D RID: 55613
			[Token(Token = "0x400D93D")]
			VEC_BREAK_OFFENSE,
			// Token: 0x0400D93E RID: 55614
			[Token(Token = "0x400D93E")]
			VEC_BREAK_DEFENSE,
			// Token: 0x0400D93F RID: 55615
			[Token(Token = "0x400D93F")]
			AUTOCHESS,
			// Token: 0x0400D940 RID: 55616
			[Token(Token = "0x400D940")]
			ACTARCADE,
			// Token: 0x0400D941 RID: 55617
			[Token(Token = "0x400D941")]
			ACT_MULTI_V3,
			// Token: 0x0400D942 RID: 55618
			[Token(Token = "0x400D942")]
			VEC_BREAK_OFFENSE_V2,
			// Token: 0x0400D943 RID: 55619
			[Token(Token = "0x400D943")]
			VEC_BREAK_DEFENSE_V2,
			// Token: 0x0400D944 RID: 55620
			[Token(Token = "0x400D944")]
			SIX_STAR,
			// Token: 0x0400D945 RID: 55621
			[Token(Token = "0x400D945")]
			ENEMY_DUEL,
			// Token: 0x0400D946 RID: 55622
			[Token(Token = "0x400D946")]
			RECAL_RUNE,
			// Token: 0x0400D947 RID: 55623
			[Token(Token = "0x400D947")]
			ACT_HALFIDLE_VERIFY1
		}
	}
}
