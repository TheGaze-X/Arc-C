using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CE8 RID: 31976
	[Token(Token = "0x2007CE8")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/halftone.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Halftone")]
	public class Halftone : BaseEffect
	{
		// Token: 0x0602CA00 RID: 182784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA00")]
		[Address(RVA = "0x287DA70", Offset = "0x287C670", VA = "0x18287DA70", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA01 RID: 182785 RVA: 0x000E1108 File Offset: 0x000DF308
		[Token(Token = "0x602CA01")]
		[Address(RVA = "0x287D9E0", Offset = "0x287C5E0", VA = "0x18287D9E0")]
		private Vector4 CMYKRot(float angle)
		{
			return default(Vector4);
		}

		// Token: 0x0602CA02 RID: 182786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA02")]
		[Address(RVA = "0x287DA40", Offset = "0x287C640", VA = "0x18287DA40", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA03 RID: 182787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA03")]
		[Address(RVA = "0x287DE30", Offset = "0x287CA30", VA = "0x18287DE30")]
		public Halftone()
		{
		}

		// Token: 0x04040496 RID: 263318
		[Token(Token = "0x4040496")]
		[FieldOffset(Offset = "0x28")]
		[ColorMin(0f)]
		[Tooltip("Global haltfoning scale.")]
		public float Scale;

		// Token: 0x04040497 RID: 263319
		[Token(Token = "0x4040497")]
		[FieldOffset(Offset = "0x2C")]
		[ColorMin(0f)]
		[Tooltip("Individual dot size.")]
		public float DotSize;

		// Token: 0x04040498 RID: 263320
		[Token(Token = "0x4040498")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Rotates the dot placement according to the Center point.")]
		public float Angle;

		// Token: 0x04040499 RID: 263321
		[Token(Token = "0x4040499")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Dots antialiasing")]
		public float Smoothness;

		// Token: 0x0404049A RID: 263322
		[Token(Token = "0x404049A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Center point to use for the rotation.")]
		public Vector2 Center;

		// Token: 0x0404049B RID: 263323
		[Token(Token = "0x404049B")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Turns the effect black & white.")]
		public bool Desaturate;
	}
}
