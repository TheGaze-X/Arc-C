using System;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	internal class MonoBtlsProvider : MobileTlsProvider
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x1700006C")]
		public override Guid ID
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x4F5BE70", Offset = "0x4F5AA70", VA = "0x184F5BE70", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public override string Name
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x4F5BED0", Offset = "0x4F5AAD0", VA = "0x184F5BED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4F5BDC0", Offset = "0x4F5A9C0", VA = "0x184F5BDC0")]
		internal MonoBtlsProvider()
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x1700006E")]
		public override bool SupportsSslStream
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x1700006F")]
		public override bool SupportsMonoExtensions
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x17000070")]
		public override bool SupportsConnectionInfo
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x17000071")]
		internal override bool SupportsCleanShutdown
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x17000072")]
		public override SslProtocols SupportedProtocols
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x4F5BF00", Offset = "0x4F5AB00", VA = "0x184F5BF00", Slot = "9")]
			get
			{
				return SslProtocols.None;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4F59C80", Offset = "0x4F58880", VA = "0x184F59C80", Slot = "11")]
		internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4F59EB0", Offset = "0x4F58AB0", VA = "0x184F59EB0")]
		internal X509Certificate2Impl GetNativeCertificate(byte[] data, string password, X509KeyStorageFlags flags)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4F5A090", Offset = "0x4F58C90", VA = "0x184F5A090")]
		internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4F5A000", Offset = "0x4F58C00", VA = "0x184F5A000")]
		internal X509Certificate2Impl GetNativeCertificate(byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags)
		{
			return null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4F5A570", Offset = "0x4F59170", VA = "0x184F5A570")]
		internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4F5AD80", Offset = "0x4F59980", VA = "0x184F5AD80", Slot = "12")]
		internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
		{
			return default(bool);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4F5B7A0", Offset = "0x4F5A3A0", VA = "0x184F5B7A0")]
		internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param)
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4F59840", Offset = "0x4F58440", VA = "0x184F59840")]
		private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4F5A6F0", Offset = "0x4F592F0", VA = "0x184F5A6F0")]
		internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code)
		{
			return X509ChainStatusFlags.NoError;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4F5A960", Offset = "0x4F59560", VA = "0x184F5A960")]
		internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4F5ACF0", Offset = "0x4F598F0", VA = "0x184F5ACF0")]
		private static void SetupDefaultCertificateStore(MonoBtlsX509Store store)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4F597F0", Offset = "0x4F583F0", VA = "0x184F597F0")]
		private static void AddUserStore(MonoBtlsX509Store store)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4F59760", Offset = "0x4F58360", VA = "0x184F59760")]
		private static void AddMachineStore(MonoBtlsX509Store store)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4F597B0", Offset = "0x4F583B0", VA = "0x184F597B0")]
		private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4F59B60", Offset = "0x4F58760", VA = "0x184F59B60")]
		public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509)
		{
			return null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4F59E20", Offset = "0x4F58A20", VA = "0x184F59E20")]
		public static X509Chain GetManagedChain(MonoBtlsX509Chain chain)
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4F59D30", Offset = "0x4F58930", VA = "0x184F59D30")]
		public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate)
		{
			return null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4F5A240", Offset = "0x4F58E40", VA = "0x184F5A240")]
		public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates)
		{
			return null;
		}
	}
}
