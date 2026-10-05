using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D0E RID: 32014
	[Token(Token = "0x2007D0E")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/vibrance.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Vibrance")]
	public class Vibrance : BaseEffect
	{
		// Token: 0x0602CA65 RID: 182885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA65")]
		[Address(RVA = "0x2883480", Offset = "0x2882080", VA = "0x182883480", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA66 RID: 182886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA66")]
		[Address(RVA = "0x2883450", Offset = "0x2882050", VA = "0x182883450", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA67 RID: 182887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA67")]
		[Address(RVA = "0x2883670", Offset = "0x2882270", VA = "0x182883670")]
		public Vibrance()
		{
		}

		// Token: 0x0404055F RID: 263519
		[Token(Token = "0x404055F")]
		[FieldOffset(Offset = "0x28")]
		[Range(-100f, 100f)]
		[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
		public float Amount;

		// Token: 0x04040560 RID: 263520
		[Token(Token = "0x4040560")]
		[FieldOffset(Offset = "0x2C")]
		[Range(-5f, 5f)]
		public float RedChannel;

		// Token: 0x04040561 RID: 263521
		[Token(Token = "0x4040561")]
		[FieldOffset(Offset = "0x30")]
		[Range(-5f, 5f)]
		public float GreenChannel;

		// Token: 0x04040562 RID: 263522
		[Token(Token = "0x4040562")]
		[FieldOffset(Offset = "0x34")]
		[Range(-5f, 5f)]
		public float BlueChannel;

		// Token: 0x04040563 RID: 263523
		[Token(Token = "0x4040563")]
		[FieldOffset(Offset = "0x38")]
		public bool AdvancedMode;
	}
}
