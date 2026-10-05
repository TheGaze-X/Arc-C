using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	[Serializable]
	public sealed class ColorGradingCurve
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x54222F0", Offset = "0x5420EF0", VA = "0x1854222F0")]
		public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x5422060", Offset = "0x5420C60", VA = "0x185422060")]
		public void Cache()
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5422270", Offset = "0x5420E70", VA = "0x185422270")]
		public float Evaluate(float t)
		{
			return 0f;
		}

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Range;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x28")]
		private AnimationCurve m_InternalLoopingCurve;
	}
}
