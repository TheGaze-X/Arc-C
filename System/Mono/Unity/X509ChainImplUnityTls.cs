using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Unity
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	internal class X509ChainImplUnityTls : X509ChainImpl
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4F66EB0", Offset = "0x4F65AB0", VA = "0x184F66EB0")]
		internal X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4F66DC0", Offset = "0x4F659C0", VA = "0x184F66DC0")]
		internal unsafe X509ChainImplUnityTls(UnityTls.unitytls_x509list* ownedList, UnityTls.unitytls_errorstate* errorState, bool reverseOrder = false)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000014")]
		public override bool IsValid
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x4F672C0", Offset = "0x4F65EC0", VA = "0x184F672C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000015")]
		internal UnityTls.unitytls_x509list_ref NativeCertificateChain
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return default(UnityTls.unitytls_x509list_ref);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public override X509ChainElementCollection ChainElements
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4F66F60", Offset = "0x4F65B60", VA = "0x184F66F60", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4F66B80", Offset = "0x4F65780", VA = "0x184F66B80", Slot = "9")]
		public override void AddStatus(X509ChainStatusFlags error)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public override X509ChainPolicy ChainPolicy
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool Build(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4F66D20", Offset = "0x4F65920", VA = "0x184F66D20", Slot = "10")]
		public override void Reset()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4F66CD0", Offset = "0x4F658D0", VA = "0x184F66CD0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		private X509ChainElementCollection elements;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private unsafe UnityTls.unitytls_x509list* ownedList;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		private UnityTls.unitytls_x509list_ref nativeCertificateChain;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x28")]
		private X509ChainPolicy policy;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x30")]
		private List<X509ChainStatus> chainStatusList;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x38")]
		private bool reverseOrder;
	}
}
