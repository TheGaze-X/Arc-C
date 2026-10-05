using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.GraphicEffect.Reflection
{
	// Token: 0x0200162C RID: 5676
	[Token(Token = "0x200162C")]
	[Serializable]
	public class HGReflectionShaderMapping
	{
		// Token: 0x060080C4 RID: 32964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGReflectionShaderMapping()
		{
		}

		// Token: 0x04008225 RID: 33317
		[Token(Token = "0x4008225")]
		[FieldOffset(Offset = "0x10")]
		public string fromShaderName;

		// Token: 0x04008226 RID: 33318
		[Token(Token = "0x4008226")]
		[FieldOffset(Offset = "0x18")]
		public Shader toShader;
	}
}
