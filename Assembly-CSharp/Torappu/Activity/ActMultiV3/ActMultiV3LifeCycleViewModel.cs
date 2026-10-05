using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F27 RID: 28455
	[Token(Token = "0x2006F27")]
	public class ActMultiV3LifeCycleViewModel : IHotfixable
	{
		// Token: 0x060286D0 RID: 165584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D0")]
		[Address(RVA = "0x23B97F0", Offset = "0x23B83F0", VA = "0x1823B97F0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060286D1 RID: 165585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D1")]
		[Address(RVA = "0x23B9990", Offset = "0x23B8590", VA = "0x1823B9990")]
		public ActMultiV3LifeCycleViewModel()
		{
		}

		// Token: 0x040397DC RID: 235484
		[Token(Token = "0x40397DC")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3LifeCycleViewModel.ActState state;

		// Token: 0x040397DD RID: 235485
		[Token(Token = "0x40397DD")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x040397DE RID: 235486
		[Token(Token = "0x40397DE")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x040397DF RID: 235487
		[Token(Token = "0x40397DF")]
		[FieldOffset(Offset = "0x28")]
		public long rewardEndTime;

		// Token: 0x040397E0 RID: 235488
		[Token(Token = "0x40397E0")]
		[FieldOffset(Offset = "0x30")]
		public long nextTime;

		// Token: 0x040397E1 RID: 235489
		[Token(Token = "0x40397E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040397E2 RID: 235490
		[Token(Token = "0x40397E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F28 RID: 28456
		[Token(Token = "0x2006F28")]
		public enum ActState
		{
			// Token: 0x040397E4 RID: 235492
			[Token(Token = "0x40397E4")]
			NOT_OPEN,
			// Token: 0x040397E5 RID: 235493
			[Token(Token = "0x40397E5")]
			ON_ACT,
			// Token: 0x040397E6 RID: 235494
			[Token(Token = "0x40397E6")]
			ON_REWARD,
			// Token: 0x040397E7 RID: 235495
			[Token(Token = "0x40397E7")]
			ON_CLOSE
		}
	}
}
