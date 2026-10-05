using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD5 RID: 31957
	[Token(Token = "0x2007CD5")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/convolution-3x3.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Convolution Matrix 3x3")]
	public class Convolution3x3 : BaseEffect
	{
		// Token: 0x0602C9CA RID: 182730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9CA")]
		[Address(RVA = "0x287AB50", Offset = "0x2879750", VA = "0x18287AB50", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9CB RID: 182731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9CB")]
		[Address(RVA = "0x287AB20", Offset = "0x2879720", VA = "0x18287AB20", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9CC RID: 182732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9CC")]
		[Address(RVA = "0x287AEF0", Offset = "0x2879AF0", VA = "0x18287AEF0")]
		public Convolution3x3()
		{
		}

		// Token: 0x0404043F RID: 263231
		[Token(Token = "0x404043F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 KernelTop;

		// Token: 0x04040440 RID: 263232
		[Token(Token = "0x4040440")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 KernelMiddle;

		// Token: 0x04040441 RID: 263233
		[Token(Token = "0x4040441")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 KernelBottom;

		// Token: 0x04040442 RID: 263234
		[Token(Token = "0x4040442")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Used to normalize the kernel.")]
		public float Divisor;

		// Token: 0x04040443 RID: 263235
		[Token(Token = "0x4040443")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
