using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CCF RID: 31951
	[Token(Token = "0x2007CCF")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/channel-swapper.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Channel Swapper")]
	public class ChannelSwapper : BaseEffect
	{
		// Token: 0x0602C9BA RID: 182714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9BA")]
		[Address(RVA = "0x2879FA0", Offset = "0x2878BA0", VA = "0x182879FA0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9BB RID: 182715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9BB")]
		[Address(RVA = "0x2879F70", Offset = "0x2878B70", VA = "0x182879F70", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9BC RID: 182716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9BC")]
		[Address(RVA = "0x287A240", Offset = "0x2878E40", VA = "0x18287A240")]
		public ChannelSwapper()
		{
		}

		// Token: 0x04040420 RID: 263200
		[Token(Token = "0x4040420")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Source channel to use for the output red channel.")]
		public ChannelSwapper.Channel RedSource;

		// Token: 0x04040421 RID: 263201
		[Token(Token = "0x4040421")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Source channel to use for the output green channel.")]
		public ChannelSwapper.Channel GreenSource;

		// Token: 0x04040422 RID: 263202
		[Token(Token = "0x4040422")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Source channel to use for the output blue channel.")]
		public ChannelSwapper.Channel BlueSource;

		// Token: 0x04040423 RID: 263203
		[Token(Token = "0x4040423")]
		[FieldOffset(Offset = "0x0")]
		private static Vector4[] m_Channels;

		// Token: 0x02007CD0 RID: 31952
		[Token(Token = "0x2007CD0")]
		public enum Channel
		{
			// Token: 0x04040425 RID: 263205
			[Token(Token = "0x4040425")]
			Red,
			// Token: 0x04040426 RID: 263206
			[Token(Token = "0x4040426")]
			Green,
			// Token: 0x04040427 RID: 263207
			[Token(Token = "0x4040427")]
			Blue
		}
	}
}
