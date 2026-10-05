using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CC9 RID: 31945
	[Token(Token = "0x2007CC9")]
	[AddComponentMenu("Colorful FX/Color Correction/Bleach Bypass")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/bleach-bypass.html")]
	[ExecuteInEditMode]
	public class BleachBypass : BaseEffect
	{
		// Token: 0x0602C9AB RID: 182699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9AB")]
		[Address(RVA = "0x2879520", Offset = "0x2878120", VA = "0x182879520", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9AC RID: 182700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9AC")]
		[Address(RVA = "0x28794F0", Offset = "0x28780F0", VA = "0x1828794F0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9AD RID: 182701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9AD")]
		[Address(RVA = "0x2879610", Offset = "0x2878210", VA = "0x182879610")]
		public BleachBypass()
		{
		}

		// Token: 0x040403FB RID: 263163
		[Token(Token = "0x40403FB")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
