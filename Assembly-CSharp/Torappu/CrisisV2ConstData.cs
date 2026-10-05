using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FBF RID: 4031
	[Token(Token = "0x2000FBF")]
	public class CrisisV2ConstData
	{
		// Token: 0x06006D06 RID: 27910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D06")]
		[Address(RVA = "0x10344C0", Offset = "0x10330C0", VA = "0x1810344C0")]
		public CrisisV2ConstData()
		{
		}

		// Token: 0x0400558E RID: 21902
		[Token(Token = "0x400558E")]
		[FieldOffset(Offset = "0x10")]
		public long sysStartTime;

		// Token: 0x0400558F RID: 21903
		[Token(Token = "0x400558F")]
		[FieldOffset(Offset = "0x18")]
		public int blackScoreThreshold;

		// Token: 0x04005590 RID: 21904
		[Token(Token = "0x4005590")]
		[FieldOffset(Offset = "0x1C")]
		public int redScoreThreshold;

		// Token: 0x04005591 RID: 21905
		[Token(Token = "0x4005591")]
		[FieldOffset(Offset = "0x20")]
		public int detailBkgRedThreshold;

		// Token: 0x04005592 RID: 21906
		[Token(Token = "0x4005592")]
		[FieldOffset(Offset = "0x24")]
		public int voiceGrade;

		// Token: 0x04005593 RID: 21907
		[Token(Token = "0x4005593")]
		[FieldOffset(Offset = "0x28")]
		public long seasonButtonUnlockInfo;

		// Token: 0x04005594 RID: 21908
		[Token(Token = "0x4005594")]
		[FieldOffset(Offset = "0x30")]
		public string shopCoinId;

		// Token: 0x04005595 RID: 21909
		[Token(Token = "0x4005595")]
		[FieldOffset(Offset = "0x38")]
		public int hardBgmSwitchScore;

		// Token: 0x04005596 RID: 21910
		[Token(Token = "0x4005596")]
		[FieldOffset(Offset = "0x40")]
		public string stageId;

		// Token: 0x04005597 RID: 21911
		[Token(Token = "0x4005597")]
		[FieldOffset(Offset = "0x48")]
		public bool hideTodoWhenStageFinish;
	}
}
