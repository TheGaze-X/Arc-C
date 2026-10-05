using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02001288 RID: 4744
	[Token(Token = "0x2001288")]
	public class SandboxV2MapZoneData
	{
		// Token: 0x060071FB RID: 29179 RVA: 0x00032BC8 File Offset: 0x00030DC8
		[Token(Token = "0x60071FB")]
		[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
		public bool ShouldSerializecenter()
		{
			return default(bool);
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x00032BE0 File Offset: 0x00030DE0
		[Token(Token = "0x60071FC")]
		[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
		public bool ShouldSerializevertices()
		{
			return default(bool);
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00032BF8 File Offset: 0x00030DF8
		[Token(Token = "0x60071FD")]
		[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
		public bool ShouldSerializetriangles()
		{
			return default(bool);
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2MapZoneData()
		{
		}

		// Token: 0x0400689B RID: 26779
		[Token(Token = "0x400689B")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x0400689C RID: 26780
		[Token(Token = "0x400689C")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 center;

		// Token: 0x0400689D RID: 26781
		[Token(Token = "0x400689D")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector2> vertices;

		// Token: 0x0400689E RID: 26782
		[Token(Token = "0x400689E")]
		[FieldOffset(Offset = "0x28")]
		public List<List<int>> triangles;

		// Token: 0x0400689F RID: 26783
		[Token(Token = "0x400689F")]
		[FieldOffset(Offset = "0x30")]
		public bool hasBorder;
	}
}
