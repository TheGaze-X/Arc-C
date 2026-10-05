using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Flags]
	[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.", false)]
	public enum ParticleSystemVertexStreams
	{
		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		Position = 1,
		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		Normal = 2,
		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		Tangent = 4,
		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		Color = 8,
		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		UV = 16,
		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		UV2BlendAndFrame = 32,
		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		CenterAndVertexID = 64,
		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		Size = 128,
		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		Rotation = 256,
		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		Velocity = 512,
		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		Lifetime = 1024,
		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		Custom1 = 2048,
		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		Custom2 = 4096,
		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		Random = 8192,
		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		None = 0,
		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		All = 2147483647
	}
}
