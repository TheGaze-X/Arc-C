using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042F2 RID: 17138
	[Token(Token = "0x20042F2")]
	public class SandboxV2DungeonLineViewModel : IHotfixable
	{
		// Token: 0x0601A56B RID: 107883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A56B")]
		[Address(RVA = "0x13440E0", Offset = "0x1342CE0", VA = "0x1813440E0")]
		public SandboxV2DungeonLineViewModel()
		{
		}

		// Token: 0x040216B1 RID: 136881
		[Token(Token = "0x40216B1")]
		[FieldOffset(Offset = "0x10")]
		public string lineId;

		// Token: 0x040216B2 RID: 136882
		[Token(Token = "0x40216B2")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 srcPos;

		// Token: 0x040216B3 RID: 136883
		[Token(Token = "0x40216B3")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 dstPos;

		// Token: 0x040216B4 RID: 136884
		[Token(Token = "0x40216B4")]
		[FieldOffset(Offset = "0x28")]
		public int focusDistanceIndex;

		// Token: 0x040216B5 RID: 136885
		[Token(Token = "0x40216B5")]
		[FieldOffset(Offset = "0x2C")]
		public float centerMinDistance;

		// Token: 0x040216B6 RID: 136886
		[Token(Token = "0x40216B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
