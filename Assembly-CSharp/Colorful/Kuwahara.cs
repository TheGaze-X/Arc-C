using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CEC RID: 31980
	[Token(Token = "0x2007CEC")]
	[AddComponentMenu("Colorful FX/Artistic Effects/Kuwahara")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/kuwahara.html")]
	[ExecuteInEditMode]
	public class Kuwahara : BaseEffect
	{
		// Token: 0x0602CA0B RID: 182795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA0B")]
		[Address(RVA = "0x287E530", Offset = "0x287D130", VA = "0x18287E530", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA0C RID: 182796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA0C")]
		[Address(RVA = "0x287E500", Offset = "0x287D100", VA = "0x18287E500", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA0D RID: 182797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA0D")]
		[Address(RVA = "0x287E6E0", Offset = "0x287D2E0", VA = "0x18287E6E0")]
		public Kuwahara()
		{
		}

		// Token: 0x040404B6 RID: 263350
		[Token(Token = "0x40404B6")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		[Tooltip("Larger radius will give a more abstract look but will lower performances.")]
		public int Radius;
	}
}
