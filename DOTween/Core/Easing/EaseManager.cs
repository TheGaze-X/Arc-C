using System;
using Il2CppDummyDll;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public static class EaseManager
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x375B9A0", Offset = "0x375A5A0", VA = "0x18375B9A0")]
		public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period)
		{
			return 0f;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x375ABA0", Offset = "0x37597A0", VA = "0x18375ABA0")]
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
		{
			return 0f;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x375BA00", Offset = "0x375A600", VA = "0x18375BA00")]
		public static EaseFunction ToEaseFunction(Ease ease)
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x375B9F0", Offset = "0x375A5F0", VA = "0x18375B9F0")]
		internal static bool IsFlashEase(Ease ease)
		{
			return default(bool);
		}

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		private const float _PiOver2 = 1.5707964f;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		private const float _TwoPi = 6.2831855f;
	}
}
