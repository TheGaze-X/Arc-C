using System;
using Il2CppDummyDll;

namespace DG.Tweening.Core
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public abstract class ABSSequentiable
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ABSSequentiable()
		{
		}

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x10")]
		internal TweenType tweenType;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x14")]
		internal float sequencedPosition;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x18")]
		internal float sequencedEndPosition;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x20")]
		internal TweenCallback onStart;
	}
}
