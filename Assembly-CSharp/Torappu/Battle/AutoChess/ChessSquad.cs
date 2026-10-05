using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002787 RID: 10119
	[Token(Token = "0x2002787")]
	public class ChessSquad
	{
		// Token: 0x0601082E RID: 67630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601082E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChessSquad()
		{
		}

		// Token: 0x0401285F RID: 75871
		[Token(Token = "0x401285F")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x04012860 RID: 75872
		[Token(Token = "0x4012860")]
		[FieldOffset(Offset = "0x18")]
		public ChessBasicInfo basicInfo;

		// Token: 0x04012861 RID: 75873
		[Token(Token = "0x4012861")]
		[FieldOffset(Offset = "0x38")]
		public AdvancedCharacterInst inst;

		// Token: 0x04012862 RID: 75874
		[Token(Token = "0x4012862")]
		[FieldOffset(Offset = "0x40")]
		public string cultivateEffectId;

		// Token: 0x04012863 RID: 75875
		[Token(Token = "0x4012863")]
		[FieldOffset(Offset = "0x48")]
		public CharSkinData skinData;

		// Token: 0x04012864 RID: 75876
		[Token(Token = "0x4012864")]
		[FieldOffset(Offset = "0x50")]
		public bool preloadAsCharacter;

		// Token: 0x04012865 RID: 75877
		[Token(Token = "0x4012865")]
		[FieldOffset(Offset = "0x54")]
		public ProfessionCategory profession;

		// Token: 0x04012866 RID: 75878
		[Token(Token = "0x4012866")]
		[FieldOffset(Offset = "0x58")]
		public ActAutoChessData.ActAutoChessShopCharChessInfoData shopCharChessInfo;

		// Token: 0x04012867 RID: 75879
		[Token(Token = "0x4012867")]
		[FieldOffset(Offset = "0x60")]
		public ChessBackupCharDiff diff;

		// Token: 0x04012868 RID: 75880
		[Token(Token = "0x4012868")]
		[FieldOffset(Offset = "0x64")]
		public PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType type;
	}
}
