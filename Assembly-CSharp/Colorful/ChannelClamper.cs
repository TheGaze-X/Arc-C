using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CCD RID: 31949
	[Token(Token = "0x2007CCD")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/channel-clamper.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Channel Clamper")]
	public class ChannelClamper : BaseEffect
	{
		// Token: 0x0602C9B4 RID: 182708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B4")]
		[Address(RVA = "0x2879AA0", Offset = "0x28786A0", VA = "0x182879AA0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9B5 RID: 182709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9B5")]
		[Address(RVA = "0x2879A70", Offset = "0x2878670", VA = "0x182879A70", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9B6 RID: 182710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B6")]
		[Address(RVA = "0x2879C40", Offset = "0x2878840", VA = "0x182879C40")]
		public ChannelClamper()
		{
		}

		// Token: 0x04040419 RID: 263193
		[Token(Token = "0x4040419")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 Red;

		// Token: 0x0404041A RID: 263194
		[Token(Token = "0x404041A")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 Green;

		// Token: 0x0404041B RID: 263195
		[Token(Token = "0x404041B")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 Blue;
	}
}
