using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020023B8 RID: 9144
	[Token(Token = "0x20023B8")]
	public class CompoundPeriodicTicker : IPeriodicTicker
	{
		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600E87B RID: 59515 RVA: 0x00054DB0 File Offset: 0x00052FB0
		[Token(Token = "0x17001D56")]
		public bool isReady
		{
			[Token(Token = "0x600E87B")]
			[Address(RVA = "0x5CF2F0", Offset = "0x5CDEF0", VA = "0x1805CF2F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E87C RID: 59516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E87C")]
		[Address(RVA = "0x5CF220", Offset = "0x5CDE20", VA = "0x1805CF220")]
		public CompoundPeriodicTicker(int period, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x0600E87D RID: 59517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E87D")]
		[Address(RVA = "0x5CF1C0", Offset = "0x5CDDC0", VA = "0x1805CF1C0")]
		public CompoundPeriodicTicker(int period, bool isDeterministic, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x0600E87E RID: 59518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E87E")]
		[Address(RVA = "0x5CEEB0", Offset = "0x5CDAB0", VA = "0x1805CEEB0", Slot = "5")]
		public void Reset(bool waitFirstPeriod)
		{
		}

		// Token: 0x0600E87F RID: 59519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E87F")]
		[Address(RVA = "0x5CEC60", Offset = "0x5CD860", VA = "0x1805CEC60", Slot = "6")]
		public void Reset(int period, bool waitFirstPeriod)
		{
		}

		// Token: 0x0600E880 RID: 59520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E880")]
		[Address(RVA = "0x5CEEF0", Offset = "0x5CDAF0", VA = "0x1805CEEF0")]
		public void Reset(bool isDeterministic, int period, bool waitFirstPeriod)
		{
		}

		// Token: 0x0600E881 RID: 59521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E881")]
		[Address(RVA = "0x5CEDB0", Offset = "0x5CD9B0", VA = "0x1805CEDB0")]
		public void Reset(bool isDeterministic, bool waitFirstPeriod)
		{
		}

		// Token: 0x0600E882 RID: 59522 RVA: 0x00054DC8 File Offset: 0x00052FC8
		[Token(Token = "0x600E882")]
		[Address(RVA = "0x5CF010", Offset = "0x5CDC10", VA = "0x1805CF010", Slot = "7")]
		public bool Tick()
		{
			return default(bool);
		}

		// Token: 0x0600E883 RID: 59523 RVA: 0x00054DE0 File Offset: 0x00052FE0
		[Token(Token = "0x600E883")]
		[Address(RVA = "0x5CEC10", Offset = "0x5CD810", VA = "0x1805CEC10", Slot = "8")]
		public bool Next()
		{
			return default(bool);
		}

		// Token: 0x0600E884 RID: 59524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E884")]
		[Address(RVA = "0x5CF060", Offset = "0x5CDC60", VA = "0x1805CF060")]
		private void _InitIfNot(bool isDeterministic, bool waitFirstPeriod)
		{
		}

		// Token: 0x04010019 RID: 65561
		[Token(Token = "0x4010019")]
		[FieldOffset(Offset = "0x10")]
		private PeriodicTicker m_tranditionalFindTargetTicker;

		// Token: 0x0401001A RID: 65562
		[Token(Token = "0x401001A")]
		[FieldOffset(Offset = "0x18")]
		private PeriodicTickerNoUpdateNeeded m_deterministicFindTargetTicker;

		// Token: 0x0401001B RID: 65563
		[Token(Token = "0x401001B")]
		[FieldOffset(Offset = "0x20")]
		private IPeriodicTicker m_findTargetTicker;

		// Token: 0x0401001C RID: 65564
		[Token(Token = "0x401001C")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedPeriod;
	}
}
