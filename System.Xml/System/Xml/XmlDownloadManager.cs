using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	internal class XmlDownloadManager
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x4FF5780", Offset = "0x4FF4380", VA = "0x184FF5780")]
		internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			return null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x4FF4F70", Offset = "0x4FF3B70", VA = "0x184FF4F70")]
		private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			return null;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x4FF5890", Offset = "0x4FF4490", VA = "0x184FF5890")]
		internal void Remove(string host)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x4FF54F0", Offset = "0x4FF40F0", VA = "0x184FF54F0")]
		internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			return null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x4FF4E00", Offset = "0x4FF3A00", VA = "0x184FF4E00")]
		private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			return null;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public XmlDownloadManager()
		{
		}

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x10")]
		private Hashtable connections;
	}
}
