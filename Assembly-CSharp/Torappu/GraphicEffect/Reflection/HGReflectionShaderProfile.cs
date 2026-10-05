using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.GraphicEffect.Reflection
{
	// Token: 0x0200162D RID: 5677
	[Token(Token = "0x200162D")]
	[CreateAssetMenu(menuName = "HG/ReflectionShaderProfile")]
	public class HGReflectionShaderProfile : ScriptableObject
	{
		// Token: 0x060080C5 RID: 32965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C5")]
		[Address(RVA = "0x2887040", Offset = "0x2885C40", VA = "0x182887040")]
		public HGReflectionShaderProfile()
		{
		}

		// Token: 0x04008227 RID: 33319
		[Token(Token = "0x4008227")]
		[FieldOffset(Offset = "0x18")]
		public Shader reflectionPlaneShader;

		// Token: 0x04008228 RID: 33320
		[Token(Token = "0x4008228")]
		[FieldOffset(Offset = "0x20")]
		public List<HGReflectionShaderMapping> commonShaderMapping;
	}
}
