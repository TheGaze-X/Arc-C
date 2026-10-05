using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061F9 RID: 25081
	[Token(Token = "0x20061F9")]
	public class BattleInfoViewModel : IHotfixable
	{
		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x06024323 RID: 148259 RVA: 0x000C3660 File Offset: 0x000C1860
		[Token(Token = "0x17005561")]
		public bool isHardStageAndCompleted
		{
			[Token(Token = "0x6024323")]
			[Address(RVA = "0x1EDBC40", Offset = "0x1EDA840", VA = "0x181EDBC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x06024324 RID: 148260 RVA: 0x000C3678 File Offset: 0x000C1878
		[Token(Token = "0x17005562")]
		public bool isSixStarStageAndCompleted
		{
			[Token(Token = "0x6024324")]
			[Address(RVA = "0x1EDBCA0", Offset = "0x1EDA8A0", VA = "0x181EDBCA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06024325 RID: 148261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024325")]
		[Address(RVA = "0x1EDBBE0", Offset = "0x1EDA7E0", VA = "0x181EDBBE0")]
		public BattleInfoViewModel()
		{
		}

		// Token: 0x04032502 RID: 206082
		[Token(Token = "0x4032502")]
		[FieldOffset(Offset = "0x10")]
		public StageType stageType;

		// Token: 0x04032503 RID: 206083
		[Token(Token = "0x4032503")]
		[FieldOffset(Offset = "0x18")]
		public string stageCode;

		// Token: 0x04032504 RID: 206084
		[Token(Token = "0x4032504")]
		[FieldOffset(Offset = "0x20")]
		public string stageName;

		// Token: 0x04032505 RID: 206085
		[Token(Token = "0x4032505")]
		[FieldOffset(Offset = "0x28")]
		public PlayerBattleRank battleRank;

		// Token: 0x04032506 RID: 206086
		[Token(Token = "0x4032506")]
		[FieldOffset(Offset = "0x2C")]
		public LevelData.Difficulty difficulty;

		// Token: 0x04032507 RID: 206087
		[Token(Token = "0x4032507")]
		[FieldOffset(Offset = "0x30")]
		public StageDiffGroup diffGroup;

		// Token: 0x04032508 RID: 206088
		[Token(Token = "0x4032508")]
		[FieldOffset(Offset = "0x34")]
		public bool hasFavor;

		// Token: 0x04032509 RID: 206089
		[Token(Token = "0x4032509")]
		[FieldOffset(Offset = "0x35")]
		public bool isCampaign;

		// Token: 0x0403250A RID: 206090
		[Token(Token = "0x403250A")]
		[FieldOffset(Offset = "0x36")]
		public bool isMultipleBattle;

		// Token: 0x0403250B RID: 206091
		[Token(Token = "0x403250B")]
		[FieldOffset(Offset = "0x38")]
		public int curMultipleTimes;

		// Token: 0x0403250C RID: 206092
		[Token(Token = "0x403250C")]
		[FieldOffset(Offset = "0x3C")]
		public bool isAutoReplayOn;

		// Token: 0x0403250D RID: 206093
		[Token(Token = "0x403250D")]
		[FieldOffset(Offset = "0x3D")]
		public bool isSpecialNormalStageForFourStarVoice;

		// Token: 0x0403250E RID: 206094
		[Token(Token = "0x403250E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isHardStageAndCompleted;

		// Token: 0x0403250F RID: 206095
		[Token(Token = "0x403250F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSixStarStageAndCompleted;

		// Token: 0x04032510 RID: 206096
		[Token(Token = "0x4032510")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
