using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CFC RID: 31996
	[Token(Token = "0x2007CFC")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/pixelate.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Pixelate")]
	public class Pixelate : BaseEffect
	{
		// Token: 0x0602CA39 RID: 182841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA39")]
		[Address(RVA = "0x2881580", Offset = "0x2880180", VA = "0x182881580", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA3A RID: 182842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA3A")]
		[Address(RVA = "0x2881550", Offset = "0x2880150", VA = "0x182881550", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA3B RID: 182843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA3B")]
		[Address(RVA = "0x2881750", Offset = "0x2880350", VA = "0x182881750")]
		public Pixelate()
		{
		}

		// Token: 0x04040514 RID: 263444
		[Token(Token = "0x4040514")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 1024f)]
		[Tooltip("Scale of an individual pixel. Depends on the Mode used.")]
		public float Scale;

		// Token: 0x04040515 RID: 263445
		[Token(Token = "0x4040515")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Turn this on to automatically compute the aspect ratio needed for squared pixels.")]
		public bool AutomaticRatio;

		// Token: 0x04040516 RID: 263446
		[Token(Token = "0x4040516")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Custom aspect ratio.")]
		public float Ratio;

		// Token: 0x04040517 RID: 263447
		[Token(Token = "0x4040517")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Used for the Scale field.")]
		public Pixelate.SizeMode Mode;

		// Token: 0x02007CFD RID: 31997
		[Token(Token = "0x2007CFD")]
		public enum SizeMode
		{
			// Token: 0x04040519 RID: 263449
			[Token(Token = "0x4040519")]
			ResolutionIndependent,
			// Token: 0x0404051A RID: 263450
			[Token(Token = "0x404051A")]
			PixelPerfect
		}
	}
}
