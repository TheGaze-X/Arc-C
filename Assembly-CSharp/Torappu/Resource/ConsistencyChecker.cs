using System;
using System.IO;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x02001702 RID: 5890
	[Token(Token = "0x2001702")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ConsistencyChecker
	{
		// Token: 0x060094F9 RID: 38137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094F9")]
		[Address(RVA = "0x3102D90", Offset = "0x3101990", VA = "0x183102D90")]
		public static WaitForAsyncTask<ConsistencyChecker.CheckResult> CheckConsistencyAndModifyAsync(ConsistencyChecker.Options options)
		{
			return null;
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x0003A200 File Offset: 0x00038400
		[Token(Token = "0x60094FA")]
		[Address(RVA = "0x3102EF0", Offset = "0x3101AF0", VA = "0x183102EF0")]
		public static bool CheckConsistencyAndModify(ConsistencyChecker.Options options, out int errorCnt)
		{
			return default(bool);
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x0003A218 File Offset: 0x00038418
		[Token(Token = "0x60094FB")]
		[Address(RVA = "0x3102FA0", Offset = "0x3101BA0", VA = "0x183102FA0")]
		private static bool _CheckConsistencyAndModifyThreadSafe(ConsistencyChecker.Options options, string resFolder, out int errorCnt)
		{
			return default(bool);
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x0003A230 File Offset: 0x00038430
		[Token(Token = "0x60094FC")]
		[Address(RVA = "0x31032A0", Offset = "0x3101EA0", VA = "0x1831032A0")]
		private static bool _CheckFileConsistencyThreadSafe(FileInfo fileInfo, HotUpdateInfo.ABInfo abInfo)
		{
			return default(bool);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x0003A248 File Offset: 0x00038448
		[Token(Token = "0x60094FD")]
		[Address(RVA = "0x31033A0", Offset = "0x3101FA0", VA = "0x1831033A0")]
		private static bool _CheckIfResMatch(ConsistencyChecker.CheckType checkType, ResLifetimeCategory category)
		{
			return default(bool);
		}

		// Token: 0x04008B16 RID: 35606
		[Token(Token = "0x4008B16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckConsistencyAndModifyAsync;

		// Token: 0x04008B17 RID: 35607
		[Token(Token = "0x4008B17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckConsistencyAndModify;

		// Token: 0x04008B18 RID: 35608
		[Token(Token = "0x4008B18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckConsistencyAndModifyThreadSafe;

		// Token: 0x04008B19 RID: 35609
		[Token(Token = "0x4008B19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckFileConsistencyThreadSafe;

		// Token: 0x04008B1A RID: 35610
		[Token(Token = "0x4008B1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfResMatch;

		// Token: 0x02001703 RID: 5891
		[Token(Token = "0x2001703")]
		public enum CheckType
		{
			// Token: 0x04008B1C RID: 35612
			[Token(Token = "0x4008B1C")]
			ALL,
			// Token: 0x04008B1D RID: 35613
			[Token(Token = "0x4008B1D")]
			INIT_ONLY,
			// Token: 0x04008B1E RID: 35614
			[Token(Token = "0x4008B1E")]
			PRE_MAIN,
			// Token: 0x04008B1F RID: 35615
			[Token(Token = "0x4008B1F")]
			MAIN_ONLY
		}

		// Token: 0x02001704 RID: 5892
		[Token(Token = "0x2001704")]
		public struct Options
		{
			// Token: 0x04008B20 RID: 35616
			[Token(Token = "0x4008B20")]
			[FieldOffset(Offset = "0x0")]
			public PersistentResInfo persistentResInfo;

			// Token: 0x04008B21 RID: 35617
			[Token(Token = "0x4008B21")]
			[FieldOffset(Offset = "0x8")]
			public ConsistencyChecker.CheckType checkType;

			// Token: 0x04008B22 RID: 35618
			[Token(Token = "0x4008B22")]
			[FieldOffset(Offset = "0xC")]
			public bool dontModify;

			// Token: 0x04008B23 RID: 35619
			[Token(Token = "0x4008B23")]
			[FieldOffset(Offset = "0x10")]
			public ConsistencyChecker.Progress progress;

			// Token: 0x04008B24 RID: 35620
			[Token(Token = "0x4008B24")]
			[FieldOffset(Offset = "0x18")]
			public ConsistencyChecker.Cancellation cancellation;
		}

		// Token: 0x02001705 RID: 5893
		[Token(Token = "0x2001705")]
		public class Cancellation
		{
			// Token: 0x060094FE RID: 38142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60094FE")]
			[Address(RVA = "0x3102C90", Offset = "0x3101890", VA = "0x183102C90")]
			public void Cancel()
			{
			}

			// Token: 0x060094FF RID: 38143 RVA: 0x0003A260 File Offset: 0x00038460
			[Token(Token = "0x60094FF")]
			[Address(RVA = "0x3102CB0", Offset = "0x31018B0", VA = "0x183102CB0")]
			public bool IsCancelled()
			{
				return default(bool);
			}

			// Token: 0x06009500 RID: 38144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009500")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Cancellation()
			{
			}

			// Token: 0x04008B25 RID: 35621
			[Token(Token = "0x4008B25")]
			[FieldOffset(Offset = "0x10")]
			private bool m_cancel;
		}

		// Token: 0x02001706 RID: 5894
		[Token(Token = "0x2001706")]
		public class Progress
		{
			// Token: 0x06009501 RID: 38145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009501")]
			[Address(RVA = "0x3113D80", Offset = "0x3112980", VA = "0x183113D80")]
			public void LockSet(int pChecked, int pTotal)
			{
			}

			// Token: 0x06009502 RID: 38146 RVA: 0x0003A278 File Offset: 0x00038478
			[Token(Token = "0x6009502")]
			[Address(RVA = "0x3113C90", Offset = "0x3112890", VA = "0x183113C90")]
			public float LockGetFloatValue()
			{
				return 0f;
			}

			// Token: 0x06009503 RID: 38147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009503")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Progress()
			{
			}

			// Token: 0x04008B26 RID: 35622
			[Token(Token = "0x4008B26")]
			[FieldOffset(Offset = "0x10")]
			public int totalCnt;

			// Token: 0x04008B27 RID: 35623
			[Token(Token = "0x4008B27")]
			[FieldOffset(Offset = "0x14")]
			public int checkedCnt;
		}

		// Token: 0x02001707 RID: 5895
		[Token(Token = "0x2001707")]
		public class CheckResult
		{
			// Token: 0x06009504 RID: 38148 RVA: 0x0003A290 File Offset: 0x00038490
			[Token(Token = "0x6009504")]
			[Address(RVA = "0x3102D30", Offset = "0x3101930", VA = "0x183102D30")]
			public bool AllFilesValid()
			{
				return default(bool);
			}

			// Token: 0x06009505 RID: 38149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009505")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CheckResult()
			{
			}

			// Token: 0x04008B28 RID: 35624
			[Token(Token = "0x4008B28")]
			[FieldOffset(Offset = "0x10")]
			public int errorCnt;
		}
	}
}
