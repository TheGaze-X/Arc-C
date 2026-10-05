using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[Serializable]
	public class CriFsConfig
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x36F63F0", Offset = "0x36F4FF0", VA = "0x1836F63F0")]
		public CriFsConfig()
		{
		}

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		public const int defaultAndroidDeviceReadBitrate = 50000000;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x10")]
		public int numberOfLoaders;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x14")]
		public int numberOfBinders;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x18")]
		public int numberOfInstallers;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x1C")]
		public int installBufferSize;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x20")]
		public int maxPath;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x28")]
		public string userAgentString;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x30")]
		public bool minimizeFileDescriptorUsage;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x31")]
		public bool enableCrcCheck;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x34")]
		public int androidDeviceReadBitrate;
	}
}
