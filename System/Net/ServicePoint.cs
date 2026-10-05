using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	public class ServicePoint
	{
		// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x508C4C0", Offset = "0x508B0C0", VA = "0x18508C4C0")]
		internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
		{
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F9")]
		internal ServicePointManager.SPKey Key
		{
			[Token(Token = "0x60016DF")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		private ServicePointScheduler Scheduler
		{
			[Token(Token = "0x60016E0")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60016E1")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FB")]
		public Uri Address
		{
			[Token(Token = "0x60016E2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x170004FC")]
		public int ConnectionLimit
		{
			[Token(Token = "0x60016E3")]
			[Address(RVA = "0x1820C10", Offset = "0x181F810", VA = "0x181820C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FD")]
		public virtual Version ProtocolVersion
		{
			[Token(Token = "0x60016E4")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FE")]
		public bool Expect100Continue
		{
			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x508CBF0", Offset = "0x508B7F0", VA = "0x18508CBF0")]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0000A7A0 File Offset: 0x000089A0
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FF")]
		public bool UseNagleAlgorithm
		{
			[Token(Token = "0x60016E6")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0000A7B8 File Offset: 0x000089B8
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000500")]
		internal bool SendContinue
		{
			[Token(Token = "0x60016E8")]
			[Address(RVA = "0x508CB60", Offset = "0x508B760", VA = "0x18508CB60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016E9")]
			[Address(RVA = "0x508CBF0", Offset = "0x508B7F0", VA = "0x18508CBF0")]
			set
			{
			}
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x508C2E0", Offset = "0x508AEE0", VA = "0x18508C2E0")]
		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x508BFB0", Offset = "0x508ABB0", VA = "0x18508BFB0")]
		internal void KeepAliveSetup(Socket socket)
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x508C070", Offset = "0x508AC70", VA = "0x18508C070")]
		private static void PutBytes(byte[] bytes, uint v, int offset)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0000A7D0 File Offset: 0x000089D0
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000501")]
		internal bool UsesProxy
		{
			[Token(Token = "0x60016ED")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016EE")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0000A7E8 File Offset: 0x000089E8
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		internal bool UseConnect
		{
			[Token(Token = "0x60016EF")]
			[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016F0")]
			[Address(RVA = "0x508CC00", Offset = "0x508B800", VA = "0x18508CC00")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x17000503")]
		private bool HasTimedOut
		{
			[Token(Token = "0x60016F1")]
			[Address(RVA = "0x508C5E0", Offset = "0x508B1E0", VA = "0x18508C5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000504")]
		internal IPHostEntry HostEntry
		{
			[Token(Token = "0x60016F2")]
			[Address(RVA = "0x508C700", Offset = "0x508B300", VA = "0x18508C700")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
		internal void SetVersion(Version version)
		{
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x508C190", Offset = "0x508AD90", VA = "0x18508C190")]
		internal void SendRequest(WebOperation operation, string groupName)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x508BF90", Offset = "0x508AB90", VA = "0x18508BF90")]
		internal void FreeServicePoint()
		{
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x508C450", Offset = "0x508B050", VA = "0x18508C450")]
		internal void UpdateServerCertificate(X509Certificate certificate)
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x508C3E0", Offset = "0x508AFE0", VA = "0x18508C3E0")]
		internal void UpdateClientCertificate(X509Certificate certificate)
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x508BEC0", Offset = "0x508AAC0", VA = "0x18508BEC0")]
		internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			return default(bool);
		}

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x10")]
		private readonly Uri uri;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x18")]
		private DateTime lastDnsResolve;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x20")]
		private Version protocolVersion;

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x28")]
		private IPHostEntry host;

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x30")]
		private bool usesProxy;

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x31")]
		private bool sendContinue;

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x32")]
		private bool useConnect;

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x38")]
		private object hostE;

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x40")]
		private bool useNagle;

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x48")]
		private BindIPEndPoint endPointCallback;

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x50")]
		private bool tcp_keepalive;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x54")]
		private int tcp_keepalive_time;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x58")]
		private int tcp_keepalive_interval;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x5C")]
		private bool disposed;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x60")]
		private int connectionLeaseTimeout;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x64")]
		private int receiveBufferSize;

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x78")]
		private int connectionLimit;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x7C")]
		private int maxIdleTime;

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x80")]
		private object m_ServerCertificateOrBytes;

		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x88")]
		private object m_ClientCertificateOrBytes;
	}
}
