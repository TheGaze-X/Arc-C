using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD6 RID: 31958
	[Token(Token = "0x2007CD6")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/cross-stitch.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Cross Stitch")]
	public class CrossStitch : BaseEffect
	{
		// Token: 0x0602C9CD RID: 182733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9CD")]
		[Address(RVA = "0x287B000", Offset = "0x2879C00", VA = "0x18287B000", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9CE RID: 182734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9CE")]
		[Address(RVA = "0x287AFD0", Offset = "0x2879BD0", VA = "0x18287AFD0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9CF RID: 182735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9CF")]
		[Address(RVA = "0x287B230", Offset = "0x2879E30", VA = "0x18287B230")]
		public CrossStitch()
		{
		}

		// Token: 0x04040444 RID: 263236
		[Token(Token = "0x4040444")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 128f)]
		[Tooltip("Works best with power of two values.")]
		public int Size;

		// Token: 0x04040445 RID: 263237
		[Token(Token = "0x4040445")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		[Tooltip("Brightness adjustment. Cross-stitching tends to lower the overall brightness, use this to compensate.")]
		public float Brightness;

		// Token: 0x04040446 RID: 263238
		[Token(Token = "0x4040446")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Inverts the cross-stiching pattern.")]
		public bool Invert;

		// Token: 0x04040447 RID: 263239
		[Token(Token = "0x4040447")]
		[FieldOffset(Offset = "0x31")]
		[Tooltip("Should the original render be pixelized ?")]
		public bool Pixelize;
	}
}
