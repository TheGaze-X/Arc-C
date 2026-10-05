using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02001289 RID: 4745
	[Token(Token = "0x2001289")]
	[Serializable]
	public class SandboxV2MapConfig
	{
		// Token: 0x060071FF RID: 29183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2MapConfig()
		{
		}

		// Token: 0x040068A0 RID: 26784
		[Token(Token = "0x40068A0")]
		[FieldOffset(Offset = "0x0")]
		public static SandboxV2MapConfig DEFAULT;

		// Token: 0x040068A1 RID: 26785
		[Token(Token = "0x40068A1")]
		[FieldOffset(Offset = "0x8")]
		public static SandboxV2MapConfig RIFT_DEFAULT;

		// Token: 0x040068A2 RID: 26786
		[Token(Token = "0x40068A2")]
		[FieldOffset(Offset = "0x10")]
		public bool isRift;

		// Token: 0x040068A3 RID: 26787
		[Token(Token = "0x40068A3")]
		[FieldOffset(Offset = "0x11")]
		public bool isGuide;

		// Token: 0x040068A4 RID: 26788
		[Token(Token = "0x40068A4")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 cameraBoundMin;

		// Token: 0x040068A5 RID: 26789
		[Token(Token = "0x40068A5")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 cameraBoundMax;

		// Token: 0x040068A6 RID: 26790
		[Token(Token = "0x40068A6")]
		[FieldOffset(Offset = "0x24")]
		public float cameraMaxNormalizedZoom;

		// Token: 0x040068A7 RID: 26791
		[Token(Token = "0x40068A7")]
		[FieldOffset(Offset = "0x28")]
		public string backgroundId;
	}
}
