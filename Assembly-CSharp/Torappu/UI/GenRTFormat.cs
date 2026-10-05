using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200374B RID: 14155
	[Token(Token = "0x200374B")]
	[Serializable]
	public struct GenRTFormat
	{
		// Token: 0x0401B17B RID: 110971
		[Token(Token = "0x401B17B")]
		[FieldOffset(Offset = "0x0")]
		public RenderTextureFormat textureFormat;

		// Token: 0x0401B17C RID: 110972
		[Token(Token = "0x401B17C")]
		[FieldOffset(Offset = "0x4")]
		public int overrideWidth;

		// Token: 0x0401B17D RID: 110973
		[Token(Token = "0x401B17D")]
		[FieldOffset(Offset = "0x8")]
		public int overrideHeight;

		// Token: 0x0401B17E RID: 110974
		[Token(Token = "0x401B17E")]
		[FieldOffset(Offset = "0xC")]
		public int depthBuffer;
	}
}
