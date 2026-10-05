using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	internal class ChainValidationHelper : ICertificateValidator
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4F4E990", Offset = "0x4F4D590", VA = "0x184F4E990")]
		internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings)
		{
			return null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4F4E8A0", Offset = "0x4F4D4A0", VA = "0x184F4E8A0")]
		internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream)
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4F4F340", Offset = "0x4F4DF40", VA = "0x184F4F340")]
		private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4F4EAC0", Offset = "0x4F4D6C0", VA = "0x184F4EAC0")]
		private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings)
		{
			return null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x4F4E950", Offset = "0x4F4D550", VA = "0x184F4E950")]
		private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers)
		{
			return null;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public MonoTlsSettings Settings
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4F4EC90", Offset = "0x4F4D890", VA = "0x184F4EC90", Slot = "5")]
		public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate)
		{
			return default(bool);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4F4ECF0", Offset = "0x4F4D8F0", VA = "0x184F4ECF0")]
		public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain)
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4F4ED90", Offset = "0x4F4D990", VA = "0x184F4ED90")]
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4F4EE70", Offset = "0x4F4DA70", VA = "0x184F4EE70")]
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4F4EBD0", Offset = "0x4F4D7D0", VA = "0x184F4EBD0")]
		private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors)
		{
			return default(bool);
		}

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x10")]
		private readonly WeakReference<SslStream> owner;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x18")]
		private readonly MonoTlsSettings settings;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		private readonly MobileTlsProvider provider;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x28")]
		private readonly ServerCertValidationCallback certValidationCallback;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x30")]
		private readonly LocalCertSelectionCallback certSelectionCallback;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x38")]
		private readonly MonoTlsStream tlsStream;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x40")]
		private readonly HttpWebRequest request;
	}
}
