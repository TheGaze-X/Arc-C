using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000565 RID: 1381
	[Token(Token = "0x2000565")]
	public class PeriodicTicker : IPeriodicTicker
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06005B47 RID: 23367 RVA: 0x0002EC80 File Offset: 0x0002CE80
		[Token(Token = "0x17000CA2")]
		public bool isReady
		{
			[Token(Token = "0x6005B47")]
			[Address(RVA = "0x1329570", Offset = "0x1328170", VA = "0x181329570", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0x1AF66E0", Offset = "0x1AF52E0", VA = "0x181AF66E0")]
		public PeriodicTicker(int period, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x1AF6680", Offset = "0x1AF5280", VA = "0x181AF6680", Slot = "5")]
		public void Reset(bool waitFirstPeriod = false)
		{
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x1AF66B0", Offset = "0x1AF52B0", VA = "0x181AF66B0", Slot = "6")]
		public void Reset(int newPeriod, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x0002EC98 File Offset: 0x0002CE98
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0x1AF66C0", Offset = "0x1AF52C0", VA = "0x181AF66C0", Slot = "7")]
		public bool Tick()
		{
			return default(bool);
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0x1AF6660", Offset = "0x1AF5260", VA = "0x181AF6660", Slot = "8")]
		public bool Next()
		{
			return default(bool);
		}

		// Token: 0x040020F4 RID: 8436
		[Token(Token = "0x40020F4")]
		[FieldOffset(Offset = "0x10")]
		private int m_tickPeriod;

		// Token: 0x040020F5 RID: 8437
		[Token(Token = "0x40020F5")]
		[FieldOffset(Offset = "0x14")]
		private int m_tickCount;
	}
}
