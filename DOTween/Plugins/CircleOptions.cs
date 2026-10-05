using System;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public struct CircleOptions : IPlugOptions
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x371F020", Offset = "0x371DC20", VA = "0x18371F020", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x371EEF0", Offset = "0x371DAF0", VA = "0x18371EEF0")]
		public void Initialize(Vector2 startValue, Vector2 endValue)
		{
		}

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x0")]
		public float endValueDegrees;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x4")]
		public bool relativeCenter;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x5")]
		public bool snapping;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x8")]
		internal Vector2 center;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x10")]
		internal float radius;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x14")]
		internal float startValueDegrees;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x18")]
		internal bool initialized;
	}
}
