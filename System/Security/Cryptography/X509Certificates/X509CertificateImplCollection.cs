using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	internal class X509CertificateImplCollection : IDisposable
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x512E4E0", Offset = "0x512D0E0", VA = "0x18512E4E0")]
		public X509CertificateImplCollection()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x512E570", Offset = "0x512D170", VA = "0x18512E570")]
		private X509CertificateImplCollection(X509CertificateImplCollection other)
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x1700017F")]
		public int Count
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x512E750", Offset = "0x512D350", VA = "0x18512E750")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000180 RID: 384
		[Token(Token = "0x17000180")]
		public X509CertificateImpl this[int index]
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x512E790", Offset = "0x512D390", VA = "0x18512E790")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x512E220", Offset = "0x512CE20", VA = "0x18512E220")]
		public void Add(X509CertificateImpl impl, bool takeOwnership)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x512E2C0", Offset = "0x512CEC0", VA = "0x18512E2C0")]
		public X509CertificateImplCollection Clone()
		{
			return null;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x512E470", Offset = "0x512D070", VA = "0x18512E470", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x512E320", Offset = "0x512CF20", VA = "0x18512E320", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x10")]
		private List<X509CertificateImpl> list;
	}
}
