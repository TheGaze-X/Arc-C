using System;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020020BF RID: 8383
	[Token(Token = "0x20020BF")]
	public static class Defaults
	{
		// Token: 0x0400DA42 RID: 55874
		[Token(Token = "0x400DA42")]
		public const float WITHDRAW_COST_RECOVER_RATIO = 0.5f;

		// Token: 0x0400DA43 RID: 55875
		[Token(Token = "0x400DA43")]
		public const float MAX_WITHDRAW_COST_RATIO_OF_RAW_COST = 1f;

		// Token: 0x0400DA44 RID: 55876
		[Token(Token = "0x400DA44")]
		public const int UNIT_SP_REDUCE_DELTA = 1;

		// Token: 0x0400DA45 RID: 55877
		[Token(Token = "0x400DA45")]
		public const SharedConsts.Direction UNIT_FOUR_DIRECTION = SharedConsts.Direction.LEFT;

		// Token: 0x0400DA46 RID: 55878
		[Token(Token = "0x400DA46")]
		public const SharedConsts.Direction UNIT_L_OR_R_DIRECTION = SharedConsts.Direction.LEFT;

		// Token: 0x0400DA47 RID: 55879
		[Token(Token = "0x400DA47")]
		public const SharedConsts.Direction SPINE_STANDARD_FACE = SharedConsts.Direction.RIGHT;

		// Token: 0x0400DA48 RID: 55880
		[Token(Token = "0x400DA48")]
		public const SharedConsts.Direction PROJECTILE_MAIN_DIRECTION = SharedConsts.Direction.RIGHT;

		// Token: 0x0400DA49 RID: 55881
		[Token(Token = "0x400DA49")]
		public const SharedConsts.Direction MESH_STANDARD_DIRECTION = SharedConsts.Direction.UP;

		// Token: 0x0400DA4A RID: 55882
		[Token(Token = "0x400DA4A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3 EFFECT_DIRECTION;

		// Token: 0x0400DA4B RID: 55883
		[Token(Token = "0x400DA4B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionNode[] EMPTY_ACTION_ARRAY;

		// Token: 0x0400DA4C RID: 55884
		[Token(Token = "0x400DA4C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string[] EMPTY_STRING_ARRAY;

		// Token: 0x0400DA4D RID: 55885
		[Token(Token = "0x400DA4D")]
		public const float UNIT_COLOR_TWEEN_DURATION = 0.3f;

		// Token: 0x0400DA4E RID: 55886
		[Token(Token = "0x400DA4E")]
		public const float RANGE_RADIUS = -1f;

		// Token: 0x0400DA4F RID: 55887
		[Token(Token = "0x400DA4F")]
		public const float HIGHLAND_HEIGHT = 0.4f;

		// Token: 0x0400DA50 RID: 55888
		[Token(Token = "0x400DA50")]
		public const float LAYER_HEIGHT = 9f;
	}
}
