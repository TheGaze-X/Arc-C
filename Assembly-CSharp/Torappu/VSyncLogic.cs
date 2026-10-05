using System;
using Il2CppDummyDll;
using Torappu.Grading;
using XLua;

namespace Torappu
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class VSyncLogic
	{
		// Token: 0x06004DF3 RID: 19955 RVA: 0x0002DD38 File Offset: 0x0002BF38
		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x18968F0", Offset = "0x18954F0", VA = "0x1818968F0")]
		public static VSyncLogic.Output Calc(VSyncLogic.Input input)
		{
			return default(VSyncLogic.Output);
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x0002DD50 File Offset: 0x0002BF50
		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x18969E0", Offset = "0x18955E0", VA = "0x1818969E0")]
		private static int _CalculateFpsTarget(VSyncLogic.Input input)
		{
			return 0;
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x0002DD68 File Offset: 0x0002BF68
		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x1896C80", Offset = "0x1895880", VA = "0x181896C80")]
		private static int _GetTargetFpsMobile(FpsController.FpsMode mode)
		{
			return 0;
		}

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int[] MAX_FPS_STRATEGY_MAP;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		private const int TARGET_FPS_60 = 60;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Calc;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalculateFpsTarget;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTargetFpsMobile;

		// Token: 0x020004DD RID: 1245
		[Token(Token = "0x20004DD")]
		public struct Input
		{
			// Token: 0x0400120F RID: 4623
			[Token(Token = "0x400120F")]
			[FieldOffset(Offset = "0x0")]
			public int instId;

			// Token: 0x04001210 RID: 4624
			[Token(Token = "0x4001210")]
			[FieldOffset(Offset = "0x4")]
			public bool enableVSync;

			// Token: 0x04001211 RID: 4625
			[Token(Token = "0x4001211")]
			[FieldOffset(Offset = "0x5")]
			public bool lockFps;

			// Token: 0x04001212 RID: 4626
			[Token(Token = "0x4001212")]
			[FieldOffset(Offset = "0x6")]
			public bool notStandalone;

			// Token: 0x04001213 RID: 4627
			[Token(Token = "0x4001213")]
			[FieldOffset(Offset = "0x8")]
			public FpsController.FpsMode fpsMode;

			// Token: 0x04001214 RID: 4628
			[Token(Token = "0x4001214")]
			[FieldOffset(Offset = "0xC")]
			public GradingController.FpsStrategyType fpsStrategy;

			// Token: 0x04001215 RID: 4629
			[Token(Token = "0x4001215")]
			[FieldOffset(Offset = "0x10")]
			public bool isProxyBattle;
		}

		// Token: 0x020004DE RID: 1246
		[Token(Token = "0x20004DE")]
		public struct Output
		{
			// Token: 0x04001216 RID: 4630
			[Token(Token = "0x4001216")]
			[FieldOffset(Offset = "0x0")]
			public int vSyncCount;

			// Token: 0x04001217 RID: 4631
			[Token(Token = "0x4001217")]
			[FieldOffset(Offset = "0x4")]
			public int targetFps;
		}
	}
}
