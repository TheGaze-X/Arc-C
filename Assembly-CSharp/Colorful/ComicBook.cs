using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD2 RID: 31954
	[Token(Token = "0x2007CD2")]
	[AddComponentMenu("Colorful FX/Artistic Effects/Comic Book")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/comic-book.html")]
	[ExecuteInEditMode]
	public class ComicBook : BaseEffect
	{
		// Token: 0x0602C9C1 RID: 182721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C1")]
		[Address(RVA = "0x287A420", Offset = "0x2879020", VA = "0x18287A420", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9C2 RID: 182722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9C2")]
		[Address(RVA = "0x287A3F0", Offset = "0x2878FF0", VA = "0x18287A3F0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9C3 RID: 182723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C3")]
		[Address(RVA = "0x287A760", Offset = "0x2879360", VA = "0x18287A760")]
		public ComicBook()
		{
		}

		// Token: 0x0404042C RID: 263212
		[Token(Token = "0x404042C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Strip orientation in radians.")]
		public float StripAngle;

		// Token: 0x0404042D RID: 263213
		[Token(Token = "0x404042D")]
		[FieldOffset(Offset = "0x2C")]
		[ColorMin(0f)]
		[Tooltip("Amount of strips to draw.")]
		public float StripDensity;

		// Token: 0x0404042E RID: 263214
		[Token(Token = "0x404042E")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Thickness of the inner strip fill.")]
		public float StripThickness;

		// Token: 0x0404042F RID: 263215
		[Token(Token = "0x404042F")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 StripLimits;

		// Token: 0x04040430 RID: 263216
		[Token(Token = "0x4040430")]
		[FieldOffset(Offset = "0x3C")]
		[ColorUsage(false)]
		public Color StripInnerColor;

		// Token: 0x04040431 RID: 263217
		[Token(Token = "0x4040431")]
		[FieldOffset(Offset = "0x4C")]
		[ColorUsage(false)]
		public Color StripOuterColor;

		// Token: 0x04040432 RID: 263218
		[Token(Token = "0x4040432")]
		[FieldOffset(Offset = "0x5C")]
		[ColorUsage(false)]
		public Color FillColor;

		// Token: 0x04040433 RID: 263219
		[Token(Token = "0x4040433")]
		[FieldOffset(Offset = "0x6C")]
		[ColorUsage(false)]
		public Color BackgroundColor;

		// Token: 0x04040434 RID: 263220
		[Token(Token = "0x4040434")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("Toggle edge detection (slower).")]
		public bool EdgeDetection;

		// Token: 0x04040435 RID: 263221
		[Token(Token = "0x4040435")]
		[FieldOffset(Offset = "0x80")]
		[ColorMin(0.01f)]
		[Tooltip("Edge detection threshold. Use lower values for more visible edges.")]
		public float EdgeThreshold;

		// Token: 0x04040436 RID: 263222
		[Token(Token = "0x4040436")]
		[FieldOffset(Offset = "0x84")]
		[ColorUsage(false)]
		public Color EdgeColor;

		// Token: 0x04040437 RID: 263223
		[Token(Token = "0x4040437")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
