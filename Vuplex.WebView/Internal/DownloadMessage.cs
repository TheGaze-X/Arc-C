using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[Serializable]
	public class DownloadMessage
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x5BCBB60", Offset = "0x5BCA760", VA = "0x185BCBB60")]
		public static DownloadMessage FromJson(string json)
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5BCBBA0", Offset = "0x5BCA7A0", VA = "0x185BCBBA0")]
		public DownloadChangedEventArgs ToEventArgs()
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DownloadMessage()
		{
		}

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x10")]
		public string ContentType;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x18")]
		public string FilePath;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x20")]
		public string Id;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x28")]
		public float Progress;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x2C")]
		public int Type;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x30")]
		public string Url;
	}
}
