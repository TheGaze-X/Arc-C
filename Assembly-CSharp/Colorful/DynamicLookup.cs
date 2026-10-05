using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CDB RID: 31963
	[Token(Token = "0x2007CDB")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/dynamic-lookup.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Dynamic Lookup")]
	public class DynamicLookup : BaseEffect
	{
		// Token: 0x0602C9D9 RID: 182745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D9")]
		[Address(RVA = "0x287B930", Offset = "0x287A530", VA = "0x18287B930", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9DA RID: 182746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9DA")]
		[Address(RVA = "0x287B900", Offset = "0x287A500", VA = "0x18287B900", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9DB RID: 182747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9DB")]
		[Address(RVA = "0x287BC10", Offset = "0x287A810", VA = "0x18287BC10")]
		public DynamicLookup()
		{
		}

		// Token: 0x0404045A RID: 263258
		[Token(Token = "0x404045A")]
		[FieldOffset(Offset = "0x28")]
		[ColorUsage(false)]
		public Color White;

		// Token: 0x0404045B RID: 263259
		[Token(Token = "0x404045B")]
		[FieldOffset(Offset = "0x38")]
		[ColorUsage(false)]
		public Color Black;

		// Token: 0x0404045C RID: 263260
		[Token(Token = "0x404045C")]
		[FieldOffset(Offset = "0x48")]
		[ColorUsage(false)]
		public Color Red;

		// Token: 0x0404045D RID: 263261
		[Token(Token = "0x404045D")]
		[FieldOffset(Offset = "0x58")]
		[ColorUsage(false)]
		public Color Green;

		// Token: 0x0404045E RID: 263262
		[Token(Token = "0x404045E")]
		[FieldOffset(Offset = "0x68")]
		[ColorUsage(false)]
		public Color Blue;

		// Token: 0x0404045F RID: 263263
		[Token(Token = "0x404045F")]
		[FieldOffset(Offset = "0x78")]
		[ColorUsage(false)]
		public Color Yellow;

		// Token: 0x04040460 RID: 263264
		[Token(Token = "0x4040460")]
		[FieldOffset(Offset = "0x88")]
		[ColorUsage(false)]
		public Color Magenta;

		// Token: 0x04040461 RID: 263265
		[Token(Token = "0x4040461")]
		[FieldOffset(Offset = "0x98")]
		[ColorUsage(false)]
		public Color Cyan;

		// Token: 0x04040462 RID: 263266
		[Token(Token = "0x4040462")]
		[FieldOffset(Offset = "0xA8")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
