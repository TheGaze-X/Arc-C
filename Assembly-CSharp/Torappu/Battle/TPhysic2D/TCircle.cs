using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.TPhysic2D
{
	// Token: 0x02002698 RID: 9880
	[Token(Token = "0x2002698")]
	public struct TCircle
	{
		// Token: 0x04011FCB RID: 73675
		[Token(Token = "0x4011FCB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TCircle BLOCK_CIRCLE;

		// Token: 0x04011FCC RID: 73676
		[Token(Token = "0x4011FCC")]
		[FieldOffset(Offset = "0xC")]
		public static readonly TCircle BLOCK_LARGE_CIRCLE;

		// Token: 0x04011FCD RID: 73677
		[Token(Token = "0x4011FCD")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 center;

		// Token: 0x04011FCE RID: 73678
		[Token(Token = "0x4011FCE")]
		[FieldOffset(Offset = "0x8")]
		public float radius;
	}
}
