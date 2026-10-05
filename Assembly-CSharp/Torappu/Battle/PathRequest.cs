using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200237C RID: 9084
	[Token(Token = "0x200237C")]
	public struct PathRequest
	{
		// Token: 0x0400FDE5 RID: 64997
		[Token(Token = "0x400FDE5")]
		[FieldOffset(Offset = "0x0")]
		public GridPosition targetPos;

		// Token: 0x0400FDE6 RID: 64998
		[Token(Token = "0x400FDE6")]
		[FieldOffset(Offset = "0x8")]
		public MotionMode motionMode;

		// Token: 0x0400FDE7 RID: 64999
		[Token(Token = "0x400FDE7")]
		[FieldOffset(Offset = "0xC")]
		public bool allowDiagonalMove;
	}
}
