using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000568")]
	public class TimeSyncPeriodicTimer
	{
		// Token: 0x06005B65 RID: 23397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x1AFD130", Offset = "0x1AFBD30", VA = "0x181AFD130")]
		public TimeSyncPeriodicTimer(FP periodTime, bool waitFirstPeriod, Func<FP> getTimeFunc)
		{
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x0002EE00 File Offset: 0x0002D000
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x1AFD030", Offset = "0x1AFBC30", VA = "0x181AFD030")]
		public bool Update(out int updateDeltaCnt)
		{
			return default(bool);
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x0002EE18 File Offset: 0x0002D018
		[Token(Token = "0x6005B67")]
		[Address(RVA = "0x1AFCFE0", Offset = "0x1AFBBE0", VA = "0x181AFCFE0")]
		public bool UpdateAndNext(out int updateDeltaCnt)
		{
			return default(bool);
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x0002EE30 File Offset: 0x0002D030
		[Token(Token = "0x6005B68")]
		[Address(RVA = "0x1AFCF90", Offset = "0x1AFBB90", VA = "0x181AFCF90")]
		public bool TryNext(int updateDeltaCnt, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x0002EE48 File Offset: 0x0002D048
		[Token(Token = "0x6005B69")]
		[Address(RVA = "0x1AFD080", Offset = "0x1AFBC80", VA = "0x181AFD080")]
		private int _GetSyncCnt()
		{
			return 0;
		}

		// Token: 0x040020F8 RID: 8440
		[Token(Token = "0x40020F8")]
		[FieldOffset(Offset = "0x10")]
		private FP m_periodTime;

		// Token: 0x040020F9 RID: 8441
		[Token(Token = "0x40020F9")]
		[FieldOffset(Offset = "0x18")]
		private Func<FP> m_getTimeFunc;

		// Token: 0x040020FA RID: 8442
		[Token(Token = "0x40020FA")]
		[FieldOffset(Offset = "0x20")]
		private int m_lastSyncCnt;
	}
}
