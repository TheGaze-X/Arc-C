using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CFF RID: 31999
	[Token(Token = "0x2007CFF")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/posterize.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Posterize")]
	public class Posterize : BaseEffect
	{
		// Token: 0x0602CA3F RID: 182847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA3F")]
		[Address(RVA = "0x28817A0", Offset = "0x28803A0", VA = "0x1828817A0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA40 RID: 182848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA40")]
		[Address(RVA = "0x2881770", Offset = "0x2880370", VA = "0x182881770", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA41 RID: 182849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA41")]
		[Address(RVA = "0x28818B0", Offset = "0x28804B0", VA = "0x1828818B0")]
		public Posterize()
		{
		}

		// Token: 0x0404051E RID: 263454
		[Token(Token = "0x404051E")]
		[FieldOffset(Offset = "0x28")]
		[Range(2f, 255f)]
		[Tooltip("Number of tonal levels (brightness values) for each channel.")]
		public int Levels;

		// Token: 0x0404051F RID: 263455
		[Token(Token = "0x404051F")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		// Token: 0x04040520 RID: 263456
		[Token(Token = "0x4040520")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Only affects luminosity. Use this if you don't want any hue shifting or color changes.")]
		public bool LuminosityOnly;
	}
}
