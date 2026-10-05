using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class EaseCurve
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public EaseCurve(AnimationCurve animCurve)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x375AAF0", Offset = "0x37596F0", VA = "0x18375AAF0")]
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
		{
			return 0f;
		}

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x10")]
		private readonly AnimationCurve _animCurve;
	}
}
