using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D0C RID: 32012
	[Token(Token = "0x2007D0C")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/threshold.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Threshold")]
	public class Threshold : BaseEffect
	{
		// Token: 0x0602CA5F RID: 182879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA5F")]
		[Address(RVA = "0x28832B0", Offset = "0x2881EB0", VA = "0x1828832B0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA60 RID: 182880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA60")]
		[Address(RVA = "0x2883280", Offset = "0x2881E80", VA = "0x182883280", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA61 RID: 182881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA61")]
		[Address(RVA = "0x28833D0", Offset = "0x2881FD0", VA = "0x1828833D0")]
		public Threshold()
		{
		}

		// Token: 0x0404055A RID: 263514
		[Token(Token = "0x404055A")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 255f)]
		[Tooltip("Luminosity threshold.")]
		public float Value;

		// Token: 0x0404055B RID: 263515
		[Token(Token = "0x404055B")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 128f)]
		[Tooltip("Aomunt of randomization.")]
		public float NoiseRange;

		// Token: 0x0404055C RID: 263516
		[Token(Token = "0x404055C")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Adds some randomization to the threshold value.")]
		public bool UseNoise;
	}
}
