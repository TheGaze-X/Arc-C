using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	internal abstract class MobileTlsContext : IDisposable
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4F53130", Offset = "0x4F51D30", VA = "0x184F53130")]
		protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		internal MonoSslAuthenticationOptions Options
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		internal MobileAuthenticatedStream Parent
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public MonoTlsSettings Settings
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x4F534A0", Offset = "0x4F520A0", VA = "0x184F534A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600011F RID: 287
		[Token(Token = "0x17000035")]
		public abstract bool IsAuthenticated { [Token(Token = "0x600011F")] get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x17000036")]
		public bool IsServer
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		internal string TargetHost
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		protected string ServerName
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000039")]
		protected bool AskForClientCertificate
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x1700003A")]
		protected SslProtocols EnabledProtocols
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			[CompilerGenerated]
			get
			{
				return SslProtocols.None;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		protected X509CertificateCollection ClientCertificates
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4F52770", Offset = "0x4F51370", VA = "0x184F52770")]
		protected void GetProtocolVersions(out TlsProtocolCode? min, out TlsProtocolCode? max)
		{
		}

		// Token: 0x06000127 RID: 295
		[Token(Token = "0x6000127")]
		public abstract void StartHandshake();

		// Token: 0x06000128 RID: 296
		[Token(Token = "0x6000128")]
		public abstract bool ProcessHandshake();

		// Token: 0x06000129 RID: 297
		[Token(Token = "0x6000129")]
		public abstract void FinishHandshake();

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003C")]
		internal X509Certificate LocalServerCertificate
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012C RID: 300
		[Token(Token = "0x1700003D")]
		internal abstract X509Certificate LocalClientCertificate { [Token(Token = "0x600012C")] get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012D RID: 301
		[Token(Token = "0x1700003E")]
		public abstract X509Certificate2 RemoteCertificate { [Token(Token = "0x600012D")] get; }

		// Token: 0x0600012E RID: 302
		[Token(Token = "0x600012E")]
		public abstract void Flush();

		// Token: 0x0600012F RID: 303
		[Token(Token = "0x600012F")]
		public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

		// Token: 0x06000130 RID: 304
		[Token(Token = "0x6000130")]
		public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

		// Token: 0x06000131 RID: 305
		[Token(Token = "0x6000131")]
		public abstract void Shutdown();

		// Token: 0x06000132 RID: 306
		[Token(Token = "0x6000132")]
		public abstract bool PendingRenegotiation();

		// Token: 0x06000133 RID: 307 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4F530D0", Offset = "0x4F51CD0", VA = "0x184F530D0")]
		protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain)
		{
			return default(bool);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4F52DE0", Offset = "0x4F519E0", VA = "0x184F52DE0")]
		protected X509Certificate SelectServerCertificate(string serverIdentity)
		{
			return null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4F52850", Offset = "0x4F51450", VA = "0x184F52850")]
		protected X509Certificate SelectClientCertificate(string[] acceptableIssuers)
		{
			return null;
		}

		// Token: 0x06000136 RID: 310
		[Token(Token = "0x6000136")]
		public abstract void Renegotiate();

		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4F52680", Offset = "0x4F51280", VA = "0x184F52680", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4F526F0", Offset = "0x4F512F0", VA = "0x184F526F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x10")]
		private ChainValidationHelper certificateValidator;
	}
}
