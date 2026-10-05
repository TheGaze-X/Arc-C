using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	[Serializable]
	public class CriManaConfig
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x36FEA90", Offset = "0x36FD690", VA = "0x1836FEA90")]
		public CriManaConfig()
		{
		}

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x10")]
		public int numberOfDecoders;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x14")]
		public int numberOfMaxEntries;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool graphicsMultiThreaded;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x19")]
		public bool useStreamerManager;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x20")]
		public CriManaConfig.PCH264PlaybackConfig pcH264PlaybackConfig;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x28")]
		public CriManaConfig.VitaH264PlaybackConfig vitaH264PlaybackConfig;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x30")]
		public CriManaConfig.WebGLConfig webglConfig;

		// Token: 0x020000FB RID: 251
		[Token(Token = "0x20000FB")]
		[Serializable]
		public class PCH264PlaybackConfig
		{
			// Token: 0x060007C9 RID: 1993 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1E9AB00", Offset = "0x1E99700", VA = "0x181E9AB00")]
			public PCH264PlaybackConfig()
			{
			}

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			[FieldOffset(Offset = "0x10")]
			public bool useH264Playback;
		}

		// Token: 0x020000FC RID: 252
		[Token(Token = "0x20000FC")]
		[Serializable]
		public class VitaH264PlaybackConfig
		{
			// Token: 0x060007CA RID: 1994 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x3708DC0", Offset = "0x37079C0", VA = "0x183708DC0")]
			public VitaH264PlaybackConfig()
			{
			}

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			[FieldOffset(Offset = "0x10")]
			public bool useH264Playback;

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			[FieldOffset(Offset = "0x14")]
			public int maxWidth;

			// Token: 0x0400048C RID: 1164
			[Token(Token = "0x400048C")]
			[FieldOffset(Offset = "0x18")]
			public int maxHeight;

			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x400048D")]
			[FieldOffset(Offset = "0x1C")]
			public bool getMemoryFromTexture;
		}

		// Token: 0x020000FD RID: 253
		[Token(Token = "0x20000FD")]
		[Serializable]
		public class WebGLConfig
		{
			// Token: 0x060007CB RID: 1995 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x3708DF0", Offset = "0x37079F0", VA = "0x183708DF0")]
			public WebGLConfig()
			{
			}

			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x400048E")]
			[FieldOffset(Offset = "0x10")]
			public string webworkerPath;

			// Token: 0x0400048F RID: 1167
			[Token(Token = "0x400048F")]
			[FieldOffset(Offset = "0x18")]
			public int heapSize;
		}
	}
}
