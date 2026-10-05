using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	public class PinchUpdateData
	{
		// Token: 0x06004B1B RID: 19227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PinchUpdateData()
		{
		}

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pinchCenter;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x1C")]
		public float pinchDistance;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x20")]
		public float pinchStartDistance;

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		[FieldOffset(Offset = "0x24")]
		public float pinchAngleDelta;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x28")]
		public float pinchAngleDeltaNormalized;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x2C")]
		public float pinchTiltDelta;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x30")]
		public float pinchTotalFingerMovement;
	}
}
