using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class DownloadChangedEventArgs : EventArgs
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x5BB5220", Offset = "0x5BB3E20", VA = "0x185BB5220")]
		public DownloadChangedEventArgs(string contentType, string filePath, string id, float progress, ProgressChangeType type, string url)
		{
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		public readonly string ContentType;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public readonly string FilePath;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		public readonly string Id;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		public readonly float Progress;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x2C")]
		public readonly ProgressChangeType Type;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		public readonly string Url;
	}
}
