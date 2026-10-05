using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	public struct ScaledStopwatch
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x5500E70", Offset = "0x54FFA70", VA = "0x185500E70")]
		public void Reset()
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x5500E30", Offset = "0x54FFA30", VA = "0x185500E30")]
		public void ResetWithSeconds(double initTotalSeconds)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x5500DF0", Offset = "0x54FF9F0", VA = "0x185500DF0")]
		public static ScaledStopwatch Create(double initTotalSecs = 0.0)
		{
			return default(ScaledStopwatch);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x5500EB0", Offset = "0x54FFAB0", VA = "0x185500EB0")]
		public double Tick(float timeScale = 1f)
		{
			return 0.0;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000057EC File Offset: 0x000039EC
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x5500E90", Offset = "0x54FFA90", VA = "0x185500E90")]
		public float TickWithSeconds(float timeScale)
		{
			return 0f;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x5500F30", Offset = "0x54FFB30", VA = "0x185500F30")]
		public float TotalSeconds()
		{
			return 0f;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000581C File Offset: 0x00003A1C
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4007440", Offset = "0x4006040", VA = "0x184007440")]
		public double TotalMilliSeconds()
		{
			return 0.0;
		}

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		private const double TICKS_PER_SECOND = 1000.0;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x0")]
		private int m_lastTick;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x8")]
		private double m_accumulateTick;
	}
}
