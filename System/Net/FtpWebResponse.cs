using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	public class FtpWebResponse : WebResponse, IDisposable
	{
		// Token: 0x060012FA RID: 4858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x51AB5E0", Offset = "0x51AA1E0", VA = "0x1851AB5E0")]
		internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x51AB5A0", Offset = "0x51AA1A0", VA = "0x1851AB5A0")]
		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x51AB400", Offset = "0x51AA000", VA = "0x1851AB400", Slot = "12")]
		public override Stream GetResponseStream()
		{
			return null;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x51AB500", Offset = "0x51AA100", VA = "0x1851AB500")]
		internal void SetResponseStream(Stream stream)
		{
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x51AB260", Offset = "0x51A9E60", VA = "0x1851AB260", Slot = "9")]
		public override void Close()
		{
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003ED")]
		public override WebHeaderCollection Headers
		{
			[Token(Token = "0x60012FF")]
			[Address(RVA = "0x51AB790", Offset = "0x51AA390", VA = "0x1851AB790", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EE")]
		public override Uri ResponseUri
		{
			[Token(Token = "0x6001300")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x170003EF")]
		public FtpStatusCode StatusCode
		{
			[Token(Token = "0x6001301")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return FtpStatusCode.Undefined;
			}
		}

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x20")]
		internal Stream _responseStream;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x28")]
		private long _contentLength;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x30")]
		private Uri _responseUri;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x38")]
		private FtpStatusCode _statusCode;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x40")]
		private string _statusLine;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x48")]
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x50")]
		private DateTime _lastModified;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x58")]
		private string _bannerMessage;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x60")]
		private string _welcomeMessage;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x68")]
		private string _exitMessage;

		// Token: 0x0200029F RID: 671
		[Token(Token = "0x200029F")]
		internal sealed class EmptyStream : MemoryStream
		{
			// Token: 0x06001302 RID: 4866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001302")]
			[Address(RVA = "0x519D1B0", Offset = "0x519BDB0", VA = "0x18519D1B0")]
			internal EmptyStream()
			{
			}
		}
	}
}
