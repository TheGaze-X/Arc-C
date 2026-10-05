using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare.CriMana
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	[Serializable]
	[StructLayout(0)]
	public class MovieInfo
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x000046AC File Offset: 0x000028AC
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BA")]
		public bool hasAlpha
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x20086C0", Offset = "0x20072C0", VA = "0x1820086C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x3710BD0", Offset = "0x370F7D0", VA = "0x183710BD0")]
			internal set
			{
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MovieInfo()
		{
		}

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint _reserved1;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint numAlphaStreams;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint width;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint height;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint dispWidth;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint dispHeight;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint framerateN;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint framerateD;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint totalFrames;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CodecType codecType;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CodecType alphaCodecType;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint numAudioStreams;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioInfo[] audioPrm;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public uint numSubtitleChannels;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint maxSubtitleSize;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public uint maxChunkSize;
	}
}
