using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002055 RID: 8277
	[Token(Token = "0x2002055")]
	[Serializable]
	public class HGSceneHighlightProfile : ScriptableObject
	{
		// Token: 0x0600CBF8 RID: 52216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBF8")]
		[Address(RVA = "0x34D0EA0", Offset = "0x34CFAA0", VA = "0x1834D0EA0")]
		public HGSceneHighlightProfile()
		{
		}

		// Token: 0x0400D67B RID: 54907
		[Token(Token = "0x400D67B")]
		[FieldOffset(Offset = "0x18")]
		[Range(64f, 1024f)]
		[Tooltip("power of 2")]
		public int highlightMapSize;

		// Token: 0x0400D67C RID: 54908
		[Token(Token = "0x400D67C")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 2f)]
		[Tooltip("0,16,32")]
		public int depthSize;

		// Token: 0x0400D67D RID: 54909
		[Token(Token = "0x400D67D")]
		[FieldOffset(Offset = "0x20")]
		public Shader highlightShader;

		// Token: 0x0400D67E RID: 54910
		[Token(Token = "0x400D67E")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public string highlightTileGUID;
	}
}
