using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F43 RID: 8003
	[Token(Token = "0x2001F43")]
	public struct CharSpriteConfig
	{
		// Token: 0x0400CCA0 RID: 52384
		[Token(Token = "0x400CCA0")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 faceOffset;

		// Token: 0x0400CCA1 RID: 52385
		[Token(Token = "0x400CCA1")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 faceScale;

		// Token: 0x0400CCA2 RID: 52386
		[Token(Token = "0x400CCA2")]
		[FieldOffset(Offset = "0x10")]
		public float blackStart;

		// Token: 0x0400CCA3 RID: 52387
		[Token(Token = "0x400CCA3")]
		[FieldOffset(Offset = "0x14")]
		public float blackEnd;

		// Token: 0x0400CCA4 RID: 52388
		[Token(Token = "0x400CCA4")]
		[FieldOffset(Offset = "0x18")]
		public bool blackMaskInverse;

		// Token: 0x0400CCA5 RID: 52389
		[Token(Token = "0x400CCA5")]
		[FieldOffset(Offset = "0x19")]
		public bool enableGlitch;

		// Token: 0x0400CCA6 RID: 52390
		[Token(Token = "0x400CCA6")]
		[FieldOffset(Offset = "0x20")]
		public string settingName;
	}
}
