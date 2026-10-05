using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public struct TMP_Vertex
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000024")]
		public static TMP_Vertex zero
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x58A37D0", Offset = "0x58A23D0", VA = "0x1858A37D0")]
			get
			{
				return default(TMP_Vertex);
			}
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 uv;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 uv2;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 uv4;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x24")]
		public Color32 color;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_Vertex k_Zero;
	}
}
