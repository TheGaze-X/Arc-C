using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public enum TMP_VertexDataUpdateFlags
	{
		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		None,
		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		Vertices,
		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		Uv0,
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		Uv2 = 4,
		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		Uv4 = 8,
		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		Colors32 = 16,
		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		All = 255
	}
}
