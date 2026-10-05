using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006758 RID: 26456
	[Token(Token = "0x2006758")]
	public class HalfIdleUITopStatusViewModel : IHotfixable
	{
		// Token: 0x06025F75 RID: 155509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F75")]
		[Address(RVA = "0x20F9510", Offset = "0x20F8110", VA = "0x1820F9510")]
		public void UpdateData()
		{
		}

		// Token: 0x06025F76 RID: 155510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F76")]
		[Address(RVA = "0x20F9650", Offset = "0x20F8250", VA = "0x1820F9650")]
		public HalfIdleUITopStatusViewModel()
		{
		}

		// Token: 0x04035678 RID: 218744
		[Token(Token = "0x4035678")]
		[FieldOffset(Offset = "0x10")]
		public int maxEnemyCapacity;

		// Token: 0x04035679 RID: 218745
		[Token(Token = "0x4035679")]
		[FieldOffset(Offset = "0x14")]
		public int enemyCapacity;

		// Token: 0x0403567A RID: 218746
		[Token(Token = "0x403567A")]
		[FieldOffset(Offset = "0x18")]
		public bool isEnemyOverload;

		// Token: 0x0403567B RID: 218747
		[Token(Token = "0x403567B")]
		[FieldOffset(Offset = "0x20")]
		public FP lossLifeCountdown;

		// Token: 0x0403567C RID: 218748
		[Token(Token = "0x403567C")]
		[FieldOffset(Offset = "0x28")]
		public FP playTime;

		// Token: 0x0403567D RID: 218749
		[Token(Token = "0x403567D")]
		[FieldOffset(Offset = "0x30")]
		public int currentLifePoint;

		// Token: 0x0403567E RID: 218750
		[Token(Token = "0x403567E")]
		[FieldOffset(Offset = "0x34")]
		public int lostLifePointByEnemyOverload;

		// Token: 0x0403567F RID: 218751
		[Token(Token = "0x403567F")]
		[FieldOffset(Offset = "0x38")]
		public int lostLifePointByOthers;

		// Token: 0x04035680 RID: 218752
		[Token(Token = "0x4035680")]
		[FieldOffset(Offset = "0x40")]
		public FP maxPlayTime;

		// Token: 0x04035681 RID: 218753
		[Token(Token = "0x4035681")]
		[FieldOffset(Offset = "0x48")]
		public List<FP> enemyRushTimeList;

		// Token: 0x04035682 RID: 218754
		[Token(Token = "0x4035682")]
		[FieldOffset(Offset = "0x50")]
		public FP bossAppearTime;

		// Token: 0x04035683 RID: 218755
		[Token(Token = "0x4035683")]
		[FieldOffset(Offset = "0x58")]
		public bool isBattleCountdown;

		// Token: 0x04035684 RID: 218756
		[Token(Token = "0x4035684")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04035685 RID: 218757
		[Token(Token = "0x4035685")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
