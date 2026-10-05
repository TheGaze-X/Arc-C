using System;
using System.IO;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	[Serializable]
	public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected WebResponse()
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x5056890", Offset = "0x5055490", VA = "0x185056890", Slot = "6")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public virtual void Close()
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x5066DD0", Offset = "0x50659D0", VA = "0x185066DD0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x5066D90", Offset = "0x5065990", VA = "0x185066D90", Slot = "10")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x17000428")]
		public virtual bool IsFromCache
		{
			[Token(Token = "0x60013F4")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x5066E40", Offset = "0x5065A40", VA = "0x185066E40", Slot = "12")]
		public virtual Stream GetResponseStream()
		{
			return null;
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		public virtual Uri ResponseUri
		{
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x5066EA0", Offset = "0x5065AA0", VA = "0x185066EA0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042A")]
		public virtual WebHeaderCollection Headers
		{
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x5066E70", Offset = "0x5065A70", VA = "0x185066E70", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x18")]
		private bool m_IsFromCache;
	}
}
