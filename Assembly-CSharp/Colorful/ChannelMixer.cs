using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CCE RID: 31950
	[Token(Token = "0x2007CCE")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/channel-mixer.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Channel Mixer")]
	public class ChannelMixer : BaseEffect
	{
		// Token: 0x0602C9B7 RID: 182711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B7")]
		[Address(RVA = "0x2879CA0", Offset = "0x28788A0", VA = "0x182879CA0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9B8 RID: 182712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9B8")]
		[Address(RVA = "0x2879C70", Offset = "0x2878870", VA = "0x182879C70", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9B9 RID: 182713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9B9")]
		[Address(RVA = "0x2879EE0", Offset = "0x2878AE0", VA = "0x182879EE0")]
		public ChannelMixer()
		{
		}

		// Token: 0x0404041C RID: 263196
		[Token(Token = "0x404041C")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 Red;

		// Token: 0x0404041D RID: 263197
		[Token(Token = "0x404041D")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 Green;

		// Token: 0x0404041E RID: 263198
		[Token(Token = "0x404041E")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 Blue;

		// Token: 0x0404041F RID: 263199
		[Token(Token = "0x404041F")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 Constant;
	}
}
