using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public struct QuaternionOptions : IPlugOptions
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x3750730", Offset = "0x374F330", VA = "0x183750730", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x0")]
		public RotateMode rotateMode;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x4")]
		public AxisConstraint axisConstraint;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 up;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x14")]
		public bool dynamicLookAt;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 dynamicLookAtWorldPosition;
	}
}
