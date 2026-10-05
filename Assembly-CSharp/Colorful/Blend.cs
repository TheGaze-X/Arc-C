using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CCA RID: 31946
	[Token(Token = "0x2007CCA")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/blend.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Blend")]
	public class Blend : BaseEffect
	{
		// Token: 0x0602C9AE RID: 182702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9AE")]
		[Address(RVA = "0x2879650", Offset = "0x2878250", VA = "0x182879650", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9AF RID: 182703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9AF")]
		[Address(RVA = "0x2879620", Offset = "0x2878220", VA = "0x182879620", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9B0 RID: 182704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B0")]
		[Address(RVA = "0xFD3E40", Offset = "0xFD2A40", VA = "0x180FD3E40")]
		public Blend()
		{
		}

		// Token: 0x040403FC RID: 263164
		[Token(Token = "0x40403FC")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The Texture2D, RenderTexture or MovieTexture to blend.")]
		public Texture Texture;

		// Token: 0x040403FD RID: 263165
		[Token(Token = "0x40403FD")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		// Token: 0x040403FE RID: 263166
		[Token(Token = "0x40403FE")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Blending mode.")]
		public Blend.BlendingMode Mode;

		// Token: 0x02007CCB RID: 31947
		[Token(Token = "0x2007CCB")]
		public enum BlendingMode
		{
			// Token: 0x04040400 RID: 263168
			[Token(Token = "0x4040400")]
			Darken,
			// Token: 0x04040401 RID: 263169
			[Token(Token = "0x4040401")]
			Multiply,
			// Token: 0x04040402 RID: 263170
			[Token(Token = "0x4040402")]
			ColorBurn,
			// Token: 0x04040403 RID: 263171
			[Token(Token = "0x4040403")]
			LinearBurn,
			// Token: 0x04040404 RID: 263172
			[Token(Token = "0x4040404")]
			DarkerColor,
			// Token: 0x04040405 RID: 263173
			[Token(Token = "0x4040405")]
			Lighten = 6,
			// Token: 0x04040406 RID: 263174
			[Token(Token = "0x4040406")]
			Screen,
			// Token: 0x04040407 RID: 263175
			[Token(Token = "0x4040407")]
			ColorDodge,
			// Token: 0x04040408 RID: 263176
			[Token(Token = "0x4040408")]
			LinearDodge,
			// Token: 0x04040409 RID: 263177
			[Token(Token = "0x4040409")]
			LighterColor,
			// Token: 0x0404040A RID: 263178
			[Token(Token = "0x404040A")]
			Overlay = 12,
			// Token: 0x0404040B RID: 263179
			[Token(Token = "0x404040B")]
			SoftLight,
			// Token: 0x0404040C RID: 263180
			[Token(Token = "0x404040C")]
			HardLight,
			// Token: 0x0404040D RID: 263181
			[Token(Token = "0x404040D")]
			VividLight,
			// Token: 0x0404040E RID: 263182
			[Token(Token = "0x404040E")]
			LinearLight,
			// Token: 0x0404040F RID: 263183
			[Token(Token = "0x404040F")]
			PinLight,
			// Token: 0x04040410 RID: 263184
			[Token(Token = "0x4040410")]
			HardMix,
			// Token: 0x04040411 RID: 263185
			[Token(Token = "0x4040411")]
			Difference = 20,
			// Token: 0x04040412 RID: 263186
			[Token(Token = "0x4040412")]
			Exclusion,
			// Token: 0x04040413 RID: 263187
			[Token(Token = "0x4040413")]
			Subtract,
			// Token: 0x04040414 RID: 263188
			[Token(Token = "0x4040414")]
			Divide
		}
	}
}
