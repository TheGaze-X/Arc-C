using System;
using System.Net;
using System.Net.Cache;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D1")]
		private static XmlDownloadManager DownloadManager
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x4FF9940", Offset = "0x4FF8540", VA = "0x184FF9940")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public XmlUrlResolver()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x4FF96C0", Offset = "0x4FF82C0", VA = "0x184FF96C0", Slot = "4")]
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return null;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x4FF9930", Offset = "0x4FF8530", VA = "0x184FF9930", Slot = "5")]
		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x4FF9570", Offset = "0x4FF8170", VA = "0x184FF9570", Slot = "7")]
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return null;
		}

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x0")]
		private static object s_DownloadManager;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x10")]
		private ICredentials _credentials;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x18")]
		private IWebProxy _proxy;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x20")]
		private RequestCachePolicy _cachePolicy;
	}
}
