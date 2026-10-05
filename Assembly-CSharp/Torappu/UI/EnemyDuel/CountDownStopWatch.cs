using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FCC RID: 20428
	[Token(Token = "0x2004FCC")]
	public class CountDownStopWatch : IHotfixable
	{
		// Token: 0x0601E566 RID: 124262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E566")]
		[Address(RVA = "0x180EC30", Offset = "0x180D830", VA = "0x18180EC30")]
		public void Reset(float countdownRemainTime)
		{
		}

		// Token: 0x0601E567 RID: 124263 RVA: 0x000AE330 File Offset: 0x000AC530
		[Token(Token = "0x601E567")]
		[Address(RVA = "0x180EBA0", Offset = "0x180D7A0", VA = "0x18180EBA0")]
		public float GetCurrRemainTime()
		{
			return 0f;
		}

		// Token: 0x0601E568 RID: 124264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E568")]
		[Address(RVA = "0x180ECC0", Offset = "0x180D8C0", VA = "0x18180ECC0")]
		public CountDownStopWatch()
		{
		}

		// Token: 0x04028898 RID: 166040
		[Token(Token = "0x4028898")]
		[FieldOffset(Offset = "0x10")]
		private float m_countdownRemainTime;

		// Token: 0x04028899 RID: 166041
		[Token(Token = "0x4028899")]
		[FieldOffset(Offset = "0x18")]
		private ScaledStopwatch m_stopWatch;

		// Token: 0x0402889A RID: 166042
		[Token(Token = "0x402889A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402889B RID: 166043
		[Token(Token = "0x402889B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCurrRemainTime;

		// Token: 0x0402889C RID: 166044
		[Token(Token = "0x402889C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
