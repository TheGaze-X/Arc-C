using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002654 RID: 9812
	[Token(Token = "0x2002654")]
	public static class SideTypes
	{
		// Token: 0x04011D8A RID: 73098
		[Token(Token = "0x4011D8A")]
		[FieldOffset(Offset = "0x0")]
		public static SideType ALL_SIDE_MASK;

		// Token: 0x04011D8B RID: 73099
		[Token(Token = "0x4011D8B")]
		[FieldOffset(Offset = "0x4")]
		public static SideType BOTH_ALLY_AND_ENEMY;

		// Token: 0x04011D8C RID: 73100
		[Token(Token = "0x4011D8C")]
		[FieldOffset(Offset = "0x8")]
		private static SideType ALLY_TO_SAME;

		// Token: 0x04011D8D RID: 73101
		[Token(Token = "0x4011D8D")]
		[FieldOffset(Offset = "0xC")]
		private static SideType ALLY_TO_OPPOSITE;

		// Token: 0x04011D8E RID: 73102
		[Token(Token = "0x4011D8E")]
		[FieldOffset(Offset = "0x10")]
		private static SideType ENEMY_TO_SAME;

		// Token: 0x04011D8F RID: 73103
		[Token(Token = "0x4011D8F")]
		[FieldOffset(Offset = "0x14")]
		private static SideType ENEMY_TO_OPPOSITE;

		// Token: 0x04011D90 RID: 73104
		[Token(Token = "0x4011D90")]
		[FieldOffset(Offset = "0x18")]
		private static SideType NEUTRAL_TO_SAME;

		// Token: 0x04011D91 RID: 73105
		[Token(Token = "0x4011D91")]
		[FieldOffset(Offset = "0x1C")]
		private static SideType NEUTRAL_TO_OPPOSITE;

		// Token: 0x04011D92 RID: 73106
		[Token(Token = "0x4011D92")]
		[FieldOffset(Offset = "0x20")]
		public static readonly SideType[] SAME_SIDES;

		// Token: 0x04011D93 RID: 73107
		[Token(Token = "0x4011D93")]
		[FieldOffset(Offset = "0x28")]
		public static readonly SideType[] OPPOSITE_SIDES;
	}
}
