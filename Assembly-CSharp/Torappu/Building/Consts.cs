using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x020017B9 RID: 6073
	[Token(Token = "0x20017B9")]
	public static class Consts
	{
		// Token: 0x04008FB3 RID: 36787
		[Token(Token = "0x4008FB3")]
		public const int HEIGHT_PER_STOREY = 2;

		// Token: 0x04008FB4 RID: 36788
		[Token(Token = "0x4008FB4")]
		public const int MANUFACT_COST_SLOTS = 3;

		// Token: 0x04008FB5 RID: 36789
		[Token(Token = "0x4008FB5")]
		public const int SHOP_STOCK_SLOTS = 3;

		// Token: 0x04008FB6 RID: 36790
		[Token(Token = "0x4008FB6")]
		public const int WORKSHOP_COST_SLOTS = 3;

		// Token: 0x04008FB7 RID: 36791
		[Token(Token = "0x4008FB7")]
		public const int MANUFACT_MAX_TARGET = 99;

		// Token: 0x04008FB8 RID: 36792
		[Token(Token = "0x4008FB8")]
		public const int DORM_RECOVER_AP_FACTOR = 1000;

		// Token: 0x04008FB9 RID: 36793
		[Token(Token = "0x4008FB9")]
		public const string STATIC_BATCH_EXCLUSIVE_TAG = "StaticBatchExclusive";

		// Token: 0x04008FBA RID: 36794
		[Token(Token = "0x4008FBA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color BASE_BUFF_VAL_TAG_BKG_COLOR;

		// Token: 0x04008FBB RID: 36795
		[Token(Token = "0x4008FBB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Color BASE_BUFF_VAL_TAG_TEXT_COLOR;

		// Token: 0x04008FBC RID: 36796
		[Token(Token = "0x4008FBC")]
		public const int MAX_FURNITURE_STORAGE = 99;

		// Token: 0x04008FBD RID: 36797
		[Token(Token = "0x4008FBD")]
		public const float GRID_HALF_SIZE = 0.5f;

		// Token: 0x04008FBE RID: 36798
		[Token(Token = "0x4008FBE")]
		public const string TAG_ROOM_OBJECT = "BuildingRoomObject";

		// Token: 0x04008FBF RID: 36799
		[Token(Token = "0x4008FBF")]
		public const string DORMITORY_ADD_NUMBER_COLOR_STRING = "#009900";

		// Token: 0x04008FC0 RID: 36800
		[Token(Token = "0x4008FC0")]
		public const int ROOM_LOD_EDGE = 20;

		// Token: 0x04008FC1 RID: 36801
		[Token(Token = "0x4008FC1")]
		public const int CAMERA_MIN_LOD_VALUE = 20;

		// Token: 0x04008FC2 RID: 36802
		[Token(Token = "0x4008FC2")]
		public const int CAMERA_MAX_LOD_VALUE = 100;

		// Token: 0x020017BA RID: 6074
		[Token(Token = "0x20017BA")]
		public static class Blueprint
		{
			// Token: 0x04008FC3 RID: 36803
			[Token(Token = "0x4008FC3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector2 ROOM_UNIT;

			// Token: 0x04008FC4 RID: 36804
			[Token(Token = "0x4008FC4")]
			[FieldOffset(Offset = "0x8")]
			public static readonly Vector2 LAYOUT_PADDING;
		}

		// Token: 0x020017BB RID: 6075
		[Token(Token = "0x20017BB")]
		public static class Vault
		{
			// Token: 0x04008FC5 RID: 36805
			[Token(Token = "0x4008FC5")]
			public const float FURNITURE_INTERACT_TELEPORT_DURATION = 0.2f;

			// Token: 0x04008FC6 RID: 36806
			[Token(Token = "0x4008FC6")]
			public const float DEFAULT_CHARACTER_ANIMATION_CROSSFADE = 0.2f;

			// Token: 0x04008FC7 RID: 36807
			[Token(Token = "0x4008FC7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector3 ROOM_UNIT;

			// Token: 0x04008FC8 RID: 36808
			[Token(Token = "0x4008FC8")]
			[FieldOffset(Offset = "0xC")]
			public static readonly Vector3 CUSTOMIZABLE_ROOM_INTERNAL_GRID_SIZE;

			// Token: 0x04008FC9 RID: 36809
			[Token(Token = "0x4008FC9")]
			[FieldOffset(Offset = "0x18")]
			public static readonly Vector3 CUSTOMIZABLE_ROOM_UNIT;

			// Token: 0x04008FCA RID: 36810
			[Token(Token = "0x4008FCA")]
			[FieldOffset(Offset = "0x24")]
			public static readonly float DEFAULT_DOOR_DEPTH;
		}

		// Token: 0x020017BC RID: 6076
		[Token(Token = "0x20017BC")]
		public static class Animation
		{
			// Token: 0x04008FCB RID: 36811
			[Token(Token = "0x4008FCB")]
			[FieldOffset(Offset = "0x0")]
			public static string IDLE_KEY;

			// Token: 0x04008FCC RID: 36812
			[Token(Token = "0x4008FCC")]
			[FieldOffset(Offset = "0x8")]
			public static string MOVE_KEY;

			// Token: 0x04008FCD RID: 36813
			[Token(Token = "0x4008FCD")]
			[FieldOffset(Offset = "0x10")]
			public static string INTERACT_KEY;

			// Token: 0x04008FCE RID: 36814
			[Token(Token = "0x4008FCE")]
			[FieldOffset(Offset = "0x18")]
			public static string SPECIAL_KEY;

			// Token: 0x04008FCF RID: 36815
			[Token(Token = "0x4008FCF")]
			public const string BEGIN_ANIM_KEY = "Begin";

			// Token: 0x04008FD0 RID: 36816
			[Token(Token = "0x4008FD0")]
			public const string END_ANIM_KEY = "End";
		}

		// Token: 0x020017BD RID: 6077
		[Token(Token = "0x20017BD")]
		public static class Navigation
		{
			// Token: 0x04008FD1 RID: 36817
			[Token(Token = "0x4008FD1")]
			public const float MIN_OBSTACLE_AVOID_INFLUENCE_FACTOR = 0.5f;

			// Token: 0x04008FD2 RID: 36818
			[Token(Token = "0x4008FD2")]
			public const float OBSTACLE_AVOID_FORCE_FACTOR = 3f;

			// Token: 0x04008FD3 RID: 36819
			[Token(Token = "0x4008FD3")]
			public const float GRID_NEAR_THRESHOLD = 0.25f;

			// Token: 0x04008FD4 RID: 36820
			[Token(Token = "0x4008FD4")]
			public const float INTERMEDIATE_NODE_REACH_DISTANCE = 0.5f;

			// Token: 0x04008FD5 RID: 36821
			[Token(Token = "0x4008FD5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector2 RANDOM_OFFSET;
		}

		// Token: 0x020017BE RID: 6078
		[Token(Token = "0x20017BE")]
		public static class Layers
		{
			// Token: 0x04008FD6 RID: 36822
			[Token(Token = "0x4008FD6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int LAYER_INDEX_BLUEPRINT;

			// Token: 0x04008FD7 RID: 36823
			[Token(Token = "0x4008FD7")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int LAYER_INDEX_VAULT;

			// Token: 0x04008FD8 RID: 36824
			[Token(Token = "0x4008FD8")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int LAYER_MASK_BLUEPRINT;

			// Token: 0x04008FD9 RID: 36825
			[Token(Token = "0x4008FD9")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int LAYER_MASK_VAULT;
		}

		// Token: 0x020017BF RID: 6079
		[Token(Token = "0x20017BF")]
		public static class AnimatorNames
		{
			// Token: 0x04008FDA RID: 36826
			[Token(Token = "0x4008FDA")]
			public const string BOOL_IS_WORKING = "isWorking";

			// Token: 0x04008FDB RID: 36827
			[Token(Token = "0x4008FDB")]
			public const string TRIGGER_ON_INTERACT = "onInteract";

			// Token: 0x04008FDC RID: 36828
			[Token(Token = "0x4008FDC")]
			public const string BOOL_FORCE_STOP = "forceStop";
		}
	}
}
