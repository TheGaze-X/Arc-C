using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF1 RID: 31985
	[Token(Token = "0x2007CF1")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/letterbox.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Letterbox")]
	public class Letterbox : BaseEffect
	{
		// Token: 0x0602CA14 RID: 182804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA14")]
		[Address(RVA = "0x287EAB0", Offset = "0x287D6B0", VA = "0x18287EAB0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA15 RID: 182805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA15")]
		[Address(RVA = "0x287EA80", Offset = "0x287D680", VA = "0x18287EA80", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA16 RID: 182806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA16")]
		[Address(RVA = "0x287ECF0", Offset = "0x287D8F0", VA = "0x18287ECF0")]
		public Letterbox()
		{
		}

		// Token: 0x040404CA RID: 263370
		[Token(Token = "0x40404CA")]
		[FieldOffset(Offset = "0x28")]
		[ColorMin(0f)]
		[Tooltip("Crop the screen to the given aspect ratio.")]
		public float Aspect;

		// Token: 0x040404CB RID: 263371
		[Token(Token = "0x40404CB")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Letter/Pillar box color. Alpha is transparency.")]
		public Color FillColor;
	}
}
