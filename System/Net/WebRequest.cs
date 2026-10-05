using System;
using System.Collections;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	[Serializable]
	public abstract class WebRequest : MarshalByRefObject, ISerializable
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041A")]
		private static object InternalSyncObject
		{
			[Token(Token = "0x60013BD")]
			[Address(RVA = "0x50668E0", Offset = "0x50654E0", VA = "0x1850668E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x5065400", Offset = "0x5064000", VA = "0x185065400")]
		private static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			return null;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x5065800", Offset = "0x5064400", VA = "0x185065800")]
		public static WebRequest Create(string requestUriString)
		{
			return null;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x5065730", Offset = "0x5064330", VA = "0x185065730")]
		public static WebRequest Create(Uri requestUri)
		{
			return null;
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041B")]
		internal static ArrayList PrefixList
		{
			[Token(Token = "0x60013C1")]
			[Address(RVA = "0x5066A00", Offset = "0x5065600", VA = "0x185066A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x5065FD0", Offset = "0x5064BD0", VA = "0x185065FD0")]
		private static ArrayList PopulatePrefixList()
		{
			return null;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x5066640", Offset = "0x5065240", VA = "0x185066640")]
		protected WebRequest()
		{
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x5055950", Offset = "0x5054550", VA = "0x185055950", Slot = "6")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041C")]
		public virtual RequestCachePolicy CachePolicy
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x5065EF0", Offset = "0x5064AF0", VA = "0x185065EF0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x5065EF0", Offset = "0x5064AF0", VA = "0x185065EF0")]
		private void InternalSetCachePolicy(RequestCachePolicy policy)
		{
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041D")]
		public virtual string Method
		{
			[Token(Token = "0x60013C9")]
			[Address(RVA = "0x50669D0", Offset = "0x50655D0", VA = "0x1850669D0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013CA")]
			[Address(RVA = "0x5066D00", Offset = "0x5065900", VA = "0x185066D00", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041E")]
		public virtual Uri RequestUri
		{
			[Token(Token = "0x60013CB")]
			[Address(RVA = "0x5066BE0", Offset = "0x50657E0", VA = "0x185066BE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041F")]
		public virtual WebHeaderCollection Headers
		{
			[Token(Token = "0x60013CC")]
			[Address(RVA = "0x50666D0", Offset = "0x50652D0", VA = "0x1850666D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00009720 File Offset: 0x00007920
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000420")]
		public virtual long ContentLength
		{
			[Token(Token = "0x60013CD")]
			[Address(RVA = "0x5066670", Offset = "0x5065270", VA = "0x185066670", Slot = "13")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60013CE")]
			[Address(RVA = "0x5066C70", Offset = "0x5065870", VA = "0x185066C70", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000421")]
		public virtual string ContentType
		{
			[Token(Token = "0x60013CF")]
			[Address(RVA = "0x5066CA0", Offset = "0x50658A0", VA = "0x185066CA0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000422")]
		public virtual ICredentials Credentials
		{
			[Token(Token = "0x60013D0")]
			[Address(RVA = "0x50666A0", Offset = "0x50652A0", VA = "0x1850666A0", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013D1")]
			[Address(RVA = "0x5066CD0", Offset = "0x50658D0", VA = "0x185066CD0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x17000423")]
		public virtual bool UseDefaultCredentials
		{
			[Token(Token = "0x60013D2")]
			[Address(RVA = "0x5066C40", Offset = "0x5065840", VA = "0x185066C40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000424")]
		public virtual IWebProxy Proxy
		{
			[Token(Token = "0x60013D3")]
			[Address(RVA = "0x5066BB0", Offset = "0x50657B0", VA = "0x185066BB0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013D4")]
			[Address(RVA = "0x5066D30", Offset = "0x5065930", VA = "0x185066D30", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00009750 File Offset: 0x00007950
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000425")]
		public virtual int Timeout
		{
			[Token(Token = "0x60013D5")]
			[Address(RVA = "0x5066C10", Offset = "0x5065810", VA = "0x185066C10", Slot = "21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60013D6")]
			[Address(RVA = "0x5066D60", Offset = "0x5065960", VA = "0x185066D60", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x5065BF0", Offset = "0x50647F0", VA = "0x185065BF0", Slot = "23")]
		public virtual Stream GetRequestStream()
		{
			return null;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x5065EC0", Offset = "0x5064AC0", VA = "0x185065EC0", Slot = "24")]
		public virtual WebResponse GetResponse()
		{
			return null;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x50653D0", Offset = "0x5063FD0", VA = "0x1850653D0", Slot = "25")]
		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x5065920", Offset = "0x5064520", VA = "0x185065920", Slot = "26")]
		public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x50653A0", Offset = "0x5063FA0", VA = "0x1850653A0", Slot = "27")]
		public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x50658F0", Offset = "0x50644F0", VA = "0x1850658F0", Slot = "28")]
		public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x5065950", Offset = "0x5064550", VA = "0x185065950", Slot = "29")]
		public virtual Task<Stream> GetRequestStreamAsync()
		{
			return null;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x5065C20", Offset = "0x5064820", VA = "0x185065C20", Slot = "30")]
		public virtual Task<WebResponse> GetResponseAsync()
		{
			return null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x50662C0", Offset = "0x5064EC0", VA = "0x1850662C0")]
		private WindowsIdentity SafeCaptureIdenity()
		{
			return null;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x5065370", Offset = "0x5063F70", VA = "0x185065370", Slot = "31")]
		public virtual void Abort()
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000426")]
		internal RequestCacheProtocol CacheProtocol
		{
			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000427")]
		internal static IWebProxy InternalDefaultWebProxy
		{
			[Token(Token = "0x60013E3")]
			[Address(RVA = "0x5066700", Offset = "0x5065300", VA = "0x185066700")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x0")]
		private static ArrayList s_PrefixList;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x8")]
		private static object s_InternalSyncObject;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x10")]
		private static TimerThread.Queue s_DefaultTimerQueue;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x18")]
		private AuthenticationLevel m_AuthenticationLevel;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x1C")]
		private TokenImpersonationLevel m_ImpersonationLevel;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x20")]
		private RequestCachePolicy m_CachePolicy;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x28")]
		private RequestCacheProtocol m_CacheProtocol;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x30")]
		private RequestCacheBinding m_CacheBinding;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x18")]
		private static WebRequest.DesignerWebRequestCreate webRequestCreate;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x20")]
		private static IWebProxy s_DefaultWebProxy;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x28")]
		private static bool s_DefaultWebProxyInitialized;

		// Token: 0x020002C8 RID: 712
		[Token(Token = "0x20002C8")]
		internal class DesignerWebRequestCreate : IWebRequestCreate
		{
			// Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x5053960", Offset = "0x5052560", VA = "0x185053960", Slot = "4")]
			public WebRequest Create(Uri uri)
			{
				return null;
			}

			// Token: 0x060013E8 RID: 5096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60013E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DesignerWebRequestCreate()
			{
			}
		}
	}
}
