using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020AF RID: 8367
	[Token(Token = "0x20020AF")]
	public struct GameModeMeta
	{
		// Token: 0x0400D94E RID: 55630
		[Token(Token = "0x400D94E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GameModeMeta DEFAULT;

		// Token: 0x0400D94F RID: 55631
		[Token(Token = "0x400D94F")]
		[FieldOffset(Offset = "0x0")]
		public GameModeMeta.GameModeType modeType;

		// Token: 0x0400D950 RID: 55632
		[Token(Token = "0x400D950")]
		[FieldOffset(Offset = "0x1")]
		public bool isDeterministic;

		// Token: 0x0400D951 RID: 55633
		[Token(Token = "0x400D951")]
		[FieldOffset(Offset = "0x2")]
		public bool allowManualTick;

		// Token: 0x0400D952 RID: 55634
		[Token(Token = "0x400D952")]
		[FieldOffset(Offset = "0x4")]
		public PlayerSide playerSide;

		// Token: 0x0400D953 RID: 55635
		[Token(Token = "0x400D953")]
		[FieldOffset(Offset = "0x8")]
		public object extraData;

		// Token: 0x020020B0 RID: 8368
		[Token(Token = "0x20020B0")]
		public enum GameModeType : byte
		{
			// Token: 0x0400D955 RID: 55637
			[Token(Token = "0x400D955")]
			DEFAULT,
			// Token: 0x0400D956 RID: 55638
			[Token(Token = "0x400D956")]
			ROGUELIKE,
			// Token: 0x0400D957 RID: 55639
			[Token(Token = "0x400D957")]
			MULTIPLAYER,
			// Token: 0x0400D958 RID: 55640
			[Token(Token = "0x400D958")]
			DANMAKU,
			// Token: 0x0400D959 RID: 55641
			[Token(Token = "0x400D959")]
			LEGION,
			// Token: 0x0400D95A RID: 55642
			[Token(Token = "0x400D95A")]
			BOSSRUSH,
			// Token: 0x0400D95B RID: 55643
			[Token(Token = "0x400D95B")]
			ACT_20_SIDE,
			// Token: 0x0400D95C RID: 55644
			[Token(Token = "0x400D95C")]
			SANDBOX,
			// Token: 0x0400D95D RID: 55645
			[Token(Token = "0x400D95D")]
			FUNLIVE,
			// Token: 0x0400D95E RID: 55646
			[Token(Token = "0x400D95E")]
			ACT_27_SIDE,
			// Token: 0x0400D95F RID: 55647
			[Token(Token = "0x400D95F")]
			STRIFE,
			// Token: 0x0400D960 RID: 55648
			[Token(Token = "0x400D960")]
			ACT_5_FUN,
			// Token: 0x0400D961 RID: 55649
			[Token(Token = "0x400D961")]
			RACING,
			// Token: 0x0400D962 RID: 55650
			[Token(Token = "0x400D962")]
			COOPERATE,
			// Token: 0x0400D963 RID: 55651
			[Token(Token = "0x400D963")]
			ROGUELIKE_DUEL,
			// Token: 0x0400D964 RID: 55652
			[Token(Token = "0x400D964")]
			AUTOCHESS,
			// Token: 0x0400D965 RID: 55653
			[Token(Token = "0x400D965")]
			GAME_CITY,
			// Token: 0x0400D966 RID: 55654
			[Token(Token = "0x400D966")]
			ACT_6_FUN,
			// Token: 0x0400D967 RID: 55655
			[Token(Token = "0x400D967")]
			ENEMY_DUEL,
			// Token: 0x0400D968 RID: 55656
			[Token(Token = "0x400D968")]
			HALF_IDLE,
			// Token: 0x0400D969 RID: 55657
			[Token(Token = "0x400D969")]
			ROGUELIKE_DEIFY,
			// Token: 0x0400D96A RID: 55658
			[Token(Token = "0x400D96A")]
			ACT_7_FUN
		}
	}
}
