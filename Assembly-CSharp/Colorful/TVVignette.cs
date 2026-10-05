using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D0D RID: 32013
	[Token(Token = "0x2007D0D")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/tv-vignette.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/TV Vignette")]
	public class TVVignette : BaseEffect
	{
		// Token: 0x0602CA62 RID: 182882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA62")]
		[Address(RVA = "0x2882ED0", Offset = "0x2881AD0", VA = "0x182882ED0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA63 RID: 182883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA63")]
		[Address(RVA = "0x2882EA0", Offset = "0x2881AA0", VA = "0x182882EA0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA64 RID: 182884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA64")]
		[Address(RVA = "0x2882FF0", Offset = "0x2881BF0", VA = "0x182882FF0")]
		public TVVignette()
		{
		}

		// Token: 0x0404055D RID: 263517
		[Token(Token = "0x404055D")]
		[FieldOffset(Offset = "0x28")]
		[ColorMin(0f)]
		public float Size;

		// Token: 0x0404055E RID: 263518
		[Token(Token = "0x404055E")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float Offset;
	}
}
