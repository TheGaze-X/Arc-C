using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	internal static class UnityTlsConversions
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4F659C0", Offset = "0x4F645C0", VA = "0x184F659C0")]
		public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols)
		{
			return UnityTls.unitytls_protocol.UNITYTLS_PROTOCOL_TLS_1_0;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4F65980", Offset = "0x4F64580", VA = "0x184F65980")]
		public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols)
		{
			return UnityTls.unitytls_protocol.UNITYTLS_PROTOCOL_TLS_1_0;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4F65950", Offset = "0x4F64550", VA = "0x184F65950")]
		public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
		{
			return TlsProtocols.Zero;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4F65A00", Offset = "0x4F64600", VA = "0x184F65A00")]
		public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			return AlertDescription.CloseNotify;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4F65AA0", Offset = "0x4F646A0", VA = "0x184F65AA0")]
		public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
		{
			return SslPolicyErrors.None;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4F65A60", Offset = "0x4F64660", VA = "0x184F65A60")]
		public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
		{
			return X509ChainStatusFlags.NoError;
		}
	}
}
