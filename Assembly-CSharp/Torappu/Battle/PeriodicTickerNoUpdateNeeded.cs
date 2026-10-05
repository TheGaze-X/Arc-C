using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020023B7 RID: 9143
	[Token(Token = "0x20023B7")]
	public class PeriodicTickerNoUpdateNeeded : IPeriodicTicker
	{
		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x0600E874 RID: 59508 RVA: 0x00054D50 File Offset: 0x00052F50
		[Token(Token = "0x17001D54")]
		public bool isReady
		{
			[Token(Token = "0x600E874")]
			[Address(RVA = "0x5DB550", Offset = "0x5DA150", VA = "0x1805DB550", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x0600E875 RID: 59509 RVA: 0x00054D68 File Offset: 0x00052F68
		[Token(Token = "0x17001D55")]
		public int remainingTick
		{
			[Token(Token = "0x600E875")]
			[Address(RVA = "0x5DB630", Offset = "0x5DA230", VA = "0x1805DB630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E876 RID: 59510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E876")]
		[Address(RVA = "0x5DB5A0", Offset = "0x5DA1A0", VA = "0x1805DB5A0")]
		public PeriodicTickerNoUpdateNeeded(int period, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x0600E877 RID: 59511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E877")]
		[Address(RVA = "0x5DB460", Offset = "0x5DA060", VA = "0x1805DB460", Slot = "5")]
		public void Reset(bool waitFirstPeriod = false)
		{
		}

		// Token: 0x0600E878 RID: 59512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E878")]
		[Address(RVA = "0x5DB4D0", Offset = "0x5DA0D0", VA = "0x1805DB4D0", Slot = "6")]
		public void Reset(int newPeriod, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x0600E879 RID: 59513 RVA: 0x00054D80 File Offset: 0x00052F80
		[Token(Token = "0x600E879")]
		[Address(RVA = "0x5DB3C0", Offset = "0x5D9FC0", VA = "0x1805DB3C0", Slot = "8")]
		public bool Next()
		{
			return default(bool);
		}

		// Token: 0x0600E87A RID: 59514 RVA: 0x00054D98 File Offset: 0x00052F98
		[Token(Token = "0x600E87A")]
		[Address(RVA = "0x5DB550", Offset = "0x5DA150", VA = "0x1805DB550", Slot = "7")]
		public bool Tick()
		{
			return default(bool);
		}

		// Token: 0x04010017 RID: 65559
		[Token(Token = "0x4010017")]
		[FieldOffset(Offset = "0x10")]
		private uint m_tickPeriod;

		// Token: 0x04010018 RID: 65560
		[Token(Token = "0x4010018")]
		[FieldOffset(Offset = "0x14")]
		private uint m_nextReadyFrame;
	}
}
