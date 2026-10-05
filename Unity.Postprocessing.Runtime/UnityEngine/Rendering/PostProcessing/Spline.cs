using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[Serializable]
	public sealed class Spline
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x584E340", Offset = "0x584CF40", VA = "0x18584E340")]
		public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x584DF80", Offset = "0x584CB80", VA = "0x18584DF80")]
		public void Cache(int frame)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x584E2B0", Offset = "0x584CEB0", VA = "0x18584E2B0")]
		public float Evaluate(float t, int length)
		{
			return 0f;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x584E240", Offset = "0x584CE40", VA = "0x18584E240")]
		public float Evaluate(float t)
		{
			return 0f;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x584E2F0", Offset = "0x584CEF0", VA = "0x18584E2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		public const int k_Precision = 128;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		public const float k_Step = 0.0078125f;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Range;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x28")]
		private AnimationCurve m_InternalLoopingCurve;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x30")]
		private int frameCount;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x38")]
		public float[] cachedData;
	}
}
