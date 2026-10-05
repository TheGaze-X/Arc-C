using System;
using System.IO;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	[Serializable]
	public class FileWebResponse : WebResponse, ISerializable, ICloseEx
	{
		// Token: 0x060014EF RID: 5359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x5056C10", Offset = "0x5055810", VA = "0x185056C10")]
		internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x50568F0", Offset = "0x50554F0", VA = "0x1850568F0")]
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x5056890", Offset = "0x5055490", VA = "0x185056890", Slot = "6")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x50565B0", Offset = "0x50551B0", VA = "0x1850565B0", Slot = "8")]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000470")]
		public override WebHeaderCollection Headers
		{
			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x5056F90", Offset = "0x5055B90", VA = "0x185056F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000471")]
		public override Uri ResponseUri
		{
			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x5056FB0", Offset = "0x5055BB0", VA = "0x185056FB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x50564E0", Offset = "0x50550E0", VA = "0x1850564E0")]
		private void CheckDisposed()
		{
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x5056570", Offset = "0x5055170", VA = "0x185056570", Slot = "9")]
		public override void Close()
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x5056760", Offset = "0x5055360", VA = "0x185056760", Slot = "15")]
		private void CloseEx(CloseExState closeState)
		{
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x5056720", Offset = "0x5055320", VA = "0x185056720", Slot = "12")]
		public override Stream GetResponseStream()
		{
			return null;
		}

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x20")]
		private bool m_closed;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x28")]
		private long m_contentLength;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x30")]
		private FileAccess m_fileAccess;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x38")]
		private WebHeaderCollection m_headers;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x40")]
		private Stream m_stream;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x48")]
		private Uri m_uri;
	}
}
