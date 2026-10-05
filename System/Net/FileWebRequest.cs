using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x5055B50", Offset = "0x5054750", VA = "0x185055B50")]
		internal FileWebRequest(Uri uri)
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x5055D50", Offset = "0x5054950", VA = "0x185055D50")]
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x5055950", Offset = "0x5054550", VA = "0x185055950", Slot = "6")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x5054BF0", Offset = "0x50537F0", VA = "0x185054BF0", Slot = "7")]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x17000466")]
		internal bool Aborted
		{
			[Token(Token = "0x60014C7")]
			[Address(RVA = "0x5056220", Offset = "0x5054E20", VA = "0x185056220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00009CA8 File Offset: 0x00007EA8
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000467")]
		public override long ContentLength
		{
			[Token(Token = "0x60014C8")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "13")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60014C9")]
			[Address(RVA = "0x5056260", Offset = "0x5054E60", VA = "0x185056260", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000468")]
		public override string ContentType
		{
			[Token(Token = "0x60014CA")]
			[Address(RVA = "0x5056300", Offset = "0x5054F00", VA = "0x185056300", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000469")]
		public override ICredentials Credentials
		{
			[Token(Token = "0x60014CB")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014CC")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046A")]
		public override WebHeaderCollection Headers
		{
			[Token(Token = "0x60014CD")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046B")]
		public override string Method
		{
			[Token(Token = "0x60014CE")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014CF")]
			[Address(RVA = "0x5056360", Offset = "0x5054F60", VA = "0x185056360", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046C")]
		public override IWebProxy Proxy
		{
			[Token(Token = "0x60014D0")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014D1")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00009CC0 File Offset: 0x00007EC0
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046D")]
		public override int Timeout
		{
			[Token(Token = "0x60014D2")]
			[Address(RVA = "0x42BAD30", Offset = "0x42B9930", VA = "0x1842BAD30", Slot = "21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60014D3")]
			[Address(RVA = "0x5056440", Offset = "0x5055040", VA = "0x185056440", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046E")]
		public override Uri RequestUri
		{
			[Token(Token = "0x60014D4")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x5053F40", Offset = "0x5052B40", VA = "0x185053F40", Slot = "27")]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x50543A0", Offset = "0x5052FA0", VA = "0x1850543A0", Slot = "25")]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x5054600", Offset = "0x5053200", VA = "0x185054600")]
		private bool CanGetRequestStream()
		{
			return default(bool);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x5054750", Offset = "0x5053350", VA = "0x185054750", Slot = "28")]
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x50549A0", Offset = "0x50535A0", VA = "0x1850549A0", Slot = "26")]
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x5055110", Offset = "0x5053D10", VA = "0x185055110", Slot = "23")]
		public override Stream GetRequestStream()
		{
			return null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x5055710", Offset = "0x5054310", VA = "0x185055710", Slot = "24")]
		public override WebResponse GetResponse()
		{
			return null;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x5054E40", Offset = "0x5053A40", VA = "0x185054E40")]
		private static void GetRequestStreamCallback(object state)
		{
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x5055350", Offset = "0x5053F50", VA = "0x185055350")]
		private static void GetResponseCallback(object state)
		{
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x50559B0", Offset = "0x50545B0", VA = "0x1850559B0")]
		internal void UnblockReader()
		{
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x1700046F")]
		public override bool UseDefaultCredentials
		{
			[Token(Token = "0x60014DF")]
			[Address(RVA = "0x5056230", Offset = "0x5054E30", VA = "0x185056230", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x5053CA0", Offset = "0x50528A0", VA = "0x185053CA0", Slot = "31")]
		public override void Abort()
		{
		}

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x0")]
		private static WaitCallback s_GetRequestStreamCallback;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x8")]
		private static WaitCallback s_GetResponseCallback;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x38")]
		private string m_connectionGroupName;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x40")]
		private long m_contentLength;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x48")]
		private ICredentials m_credentials;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x50")]
		private FileAccess m_fileAccess;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x58")]
		private WebHeaderCollection m_headers;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x60")]
		private string m_method;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x68")]
		private IWebProxy m_proxy;

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x70")]
		private ManualResetEvent m_readerEvent;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x78")]
		private bool m_readPending;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x80")]
		private WebResponse m_response;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x88")]
		private Stream m_stream;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_syncHint;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x94")]
		private int m_timeout;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x98")]
		private Uri m_uri;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_writePending;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_writing;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0xA8")]
		private LazyAsyncResult m_WriteAResult;

		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0xB0")]
		private LazyAsyncResult m_ReadAResult;

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0xB8")]
		private int m_Aborted;
	}
}
