using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	internal class ServerCertValidationCallback
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x5081750", Offset = "0x5080350", VA = "0x185081750")]
		internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000477")]
		internal RemoteCertificateValidationCallback ValidationCallback
		{
			[Token(Token = "0x600151C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x50814E0", Offset = "0x50800E0", VA = "0x1850814E0")]
		internal void Callback(object state)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x50815D0", Offset = "0x50801D0", VA = "0x1850815D0")]
		internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x10")]
		private readonly RemoteCertificateValidationCallback m_ValidationCallback;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x18")]
		private readonly ExecutionContext m_Context;

		// Token: 0x020002FD RID: 765
		[Token(Token = "0x20002FD")]
		private class CallbackContext
		{
			// Token: 0x0600151F RID: 5407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x50696E0", Offset = "0x50682E0", VA = "0x1850696E0")]
			internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
			{
			}

			// Token: 0x04000B86 RID: 2950
			[Token(Token = "0x4000B86")]
			[FieldOffset(Offset = "0x10")]
			internal readonly object request;

			// Token: 0x04000B87 RID: 2951
			[Token(Token = "0x4000B87")]
			[FieldOffset(Offset = "0x18")]
			internal readonly X509Certificate certificate;

			// Token: 0x04000B88 RID: 2952
			[Token(Token = "0x4000B88")]
			[FieldOffset(Offset = "0x20")]
			internal readonly X509Chain chain;

			// Token: 0x04000B89 RID: 2953
			[Token(Token = "0x4000B89")]
			[FieldOffset(Offset = "0x28")]
			internal readonly SslPolicyErrors sslPolicyErrors;

			// Token: 0x04000B8A RID: 2954
			[Token(Token = "0x4000B8A")]
			[FieldOffset(Offset = "0x2C")]
			internal bool result;
		}
	}
}
