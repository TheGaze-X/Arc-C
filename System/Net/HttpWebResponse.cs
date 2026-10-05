using System;
using System.IO;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	[Serializable]
	public class HttpWebResponse : WebResponse, ISerializable, IDisposable
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public HttpWebResponse()
		{
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x50844D0", Offset = "0x50830D0", VA = "0x1850844D0")]
		internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x5084A70", Offset = "0x5083670", VA = "0x185084A70")]
		internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x50845C0", Offset = "0x50831C0", VA = "0x1850845C0")]
		[Obsolete("Serialization is obsoleted for this type", false)]
		protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DE")]
		public override WebHeaderCollection Headers
		{
			[Token(Token = "0x6001677")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DF")]
		public override Uri ResponseUri
		{
			[Token(Token = "0x6001678")]
			[Address(RVA = "0x5084D40", Offset = "0x5083940", VA = "0x185084D40", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x170004E0")]
		public virtual HttpStatusCode StatusCode
		{
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90", Slot = "15")]
			get
			{
				return (HttpStatusCode)0;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E1")]
		public virtual string StatusDescription
		{
			[Token(Token = "0x600167A")]
			[Address(RVA = "0x5084D60", Offset = "0x5083960", VA = "0x185084D60", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x50843F0", Offset = "0x5082FF0", VA = "0x1850843F0", Slot = "12")]
		public override Stream GetResponseStream()
		{
			return null;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x5056890", Offset = "0x5055490", VA = "0x185056890", Slot = "6")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x5084280", Offset = "0x5082E80", VA = "0x185084280", Slot = "8")]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x5084050", Offset = "0x5082C50", VA = "0x185084050", Slot = "9")]
		public override void Close()
		{
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x5084490", Offset = "0x5083090", VA = "0x185084490", Slot = "7")]
		private void Dispose()
		{
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x50840A0", Offset = "0x5082CA0", VA = "0x1850840A0", Slot = "10")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x5083FC0", Offset = "0x5082BC0", VA = "0x185083FC0")]
		private void CheckDisposed()
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x50840B0", Offset = "0x5082CB0", VA = "0x1850840B0")]
		private void FillCookies()
		{
		}

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x20")]
		private Uri uri;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x28")]
		private WebHeaderCollection webHeaders;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x30")]
		private CookieCollection cookieCollection;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x38")]
		private string method;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x40")]
		private Version version;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x48")]
		private HttpStatusCode statusCode;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x50")]
		private string statusDescription;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x58")]
		private long contentLength;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x60")]
		private string contentType;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x68")]
		private CookieContainer cookie_container;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x70")]
		private bool disposed;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x78")]
		private Stream stream;
	}
}
