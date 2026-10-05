using System;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	internal class UnityTlsProvider : MobileTlsProvider
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public override string Name
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x4F66760", Offset = "0x4F65360", VA = "0x184F66760", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x1700000E")]
		public override Guid ID
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4F66700", Offset = "0x4F65300", VA = "0x184F66700", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x1700000F")]
		public override bool SupportsSslStream
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x17000010")]
		public override bool SupportsMonoExtensions
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x17000011")]
		public override bool SupportsConnectionInfo
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x17000012")]
		internal override bool SupportsCleanShutdown
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x17000013")]
		public override SslProtocols SupportedProtocols
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4F5BF00", Offset = "0x4F5AB00", VA = "0x184F5BF00", Slot = "9")]
			get
			{
				return SslProtocols.None;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4F65AD0", Offset = "0x4F646D0", VA = "0x184F65AD0", Slot = "11")]
		internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4F66790", Offset = "0x4F65390", VA = "0x184F66790")]
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
		private unsafe static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
		{
			return UnityTls.unitytls_x509verify_result.UNITYTLS_X509VERIFY_SUCCESS;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4F65CD0", Offset = "0x4F648D0", VA = "0x184F65CD0", Slot = "12")]
		internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
		{
			return default(bool);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UnityTlsProvider()
		{
		}
	}
}
