using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042F3 RID: 17139
	[Token(Token = "0x20042F3")]
	public class SandboxV2DungeonPathLineViewModel : IHotfixable
	{
		// Token: 0x0601A56C RID: 107884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A56C")]
		[Address(RVA = "0x1344140", Offset = "0x1342D40", VA = "0x181344140")]
		public SandboxV2DungeonPathLineViewModel()
		{
		}

		// Token: 0x040216B7 RID: 136887
		[Token(Token = "0x40216B7")]
		public const float LENGTH_PER_CYCLE = 500f;

		// Token: 0x040216B8 RID: 136888
		[Token(Token = "0x40216B8")]
		[FieldOffset(Offset = "0x10")]
		public string lineId;

		// Token: 0x040216B9 RID: 136889
		[Token(Token = "0x40216B9")]
		[FieldOffset(Offset = "0x18")]
		public string concernedId;

		// Token: 0x040216BA RID: 136890
		[Token(Token = "0x40216BA")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 srcPos;

		// Token: 0x040216BB RID: 136891
		[Token(Token = "0x40216BB")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 dstPos;

		// Token: 0x040216BC RID: 136892
		[Token(Token = "0x40216BC")]
		[FieldOffset(Offset = "0x30")]
		public float delay;

		// Token: 0x040216BD RID: 136893
		[Token(Token = "0x40216BD")]
		[FieldOffset(Offset = "0x34")]
		public float cycleSpan;

		// Token: 0x040216BE RID: 136894
		[Token(Token = "0x40216BE")]
		[FieldOffset(Offset = "0x38")]
		public int focusDistanceIndex;

		// Token: 0x040216BF RID: 136895
		[Token(Token = "0x40216BF")]
		[FieldOffset(Offset = "0x3C")]
		public float centerMinDistance;

		// Token: 0x040216C0 RID: 136896
		[Token(Token = "0x40216C0")]
		[FieldOffset(Offset = "0x40")]
		public bool isReversed;

		// Token: 0x040216C1 RID: 136897
		[Token(Token = "0x40216C1")]
		[FieldOffset(Offset = "0x44")]
		public SandboxV2DungeonPathLineViewModel.PathType pathType;

		// Token: 0x040216C2 RID: 136898
		[Token(Token = "0x40216C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042F4 RID: 17140
		[Token(Token = "0x20042F4")]
		public enum PathType
		{
			// Token: 0x040216C4 RID: 136900
			[Token(Token = "0x40216C4")]
			NONE,
			// Token: 0x040216C5 RID: 136901
			[Token(Token = "0x40216C5")]
			ENEMY_RUSH,
			// Token: 0x040216C6 RID: 136902
			[Token(Token = "0x40216C6")]
			MESSENGER
		}
	}
}
