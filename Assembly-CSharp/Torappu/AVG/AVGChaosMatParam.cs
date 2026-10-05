using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F0A RID: 7946
	[Token(Token = "0x2001F0A")]
	public struct AVGChaosMatParam
	{
		// Token: 0x0600C530 RID: 50480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C530")]
		[Address(RVA = "0x341DD00", Offset = "0x341C900", VA = "0x18341DD00")]
		public void Lerp(AVGChaosMatParam from, AVGChaosMatParam to, float amount)
		{
		}

		// Token: 0x0600C531 RID: 50481 RVA: 0x00048468 File Offset: 0x00046668
		[Token(Token = "0x600C531")]
		[Address(RVA = "0x341DC40", Offset = "0x341C840", VA = "0x18341DC40")]
		public AVGChaosMatParam GetLerp(AVGChaosMatParam from, AVGChaosMatParam to, float amount)
		{
			return default(AVGChaosMatParam);
		}

		// Token: 0x0600C532 RID: 50482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C532")]
		[Address(RVA = "0x341D960", Offset = "0x341C560", VA = "0x18341D960")]
		public void ApplyToMat(Material colorMat, Material blurMat)
		{
		}

		// Token: 0x0400C9C2 RID: 51650
		[Token(Token = "0x400C9C2")]
		[FieldOffset(Offset = "0x0")]
		public float weight;

		// Token: 0x0400C9C3 RID: 51651
		[Token(Token = "0x400C9C3")]
		[FieldOffset(Offset = "0x4")]
		public float blurRange;

		// Token: 0x0400C9C4 RID: 51652
		[Token(Token = "0x400C9C4")]
		[FieldOffset(Offset = "0x8")]
		public float chaosRange;

		// Token: 0x0400C9C5 RID: 51653
		[Token(Token = "0x400C9C5")]
		[FieldOffset(Offset = "0xC")]
		public float maskRadius;

		// Token: 0x0400C9C6 RID: 51654
		[Token(Token = "0x400C9C6")]
		[FieldOffset(Offset = "0x10")]
		public float maskSmoothness;

		// Token: 0x0400C9C7 RID: 51655
		[Token(Token = "0x400C9C7")]
		[FieldOffset(Offset = "0x14")]
		public Color chaosColor1;

		// Token: 0x0400C9C8 RID: 51656
		[Token(Token = "0x400C9C8")]
		[FieldOffset(Offset = "0x24")]
		public Color chaosColor2;

		// Token: 0x0400C9C9 RID: 51657
		[Token(Token = "0x400C9C9")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 maskCenter;
	}
}
