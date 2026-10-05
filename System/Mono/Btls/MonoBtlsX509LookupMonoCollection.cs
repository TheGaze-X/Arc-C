using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x50D4800", Offset = "0x50D3400", VA = "0x1850D4800")]
		internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x50D4420", Offset = "0x50D3020", VA = "0x1850D4420")]
		private void Initialize()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x50D4730", Offset = "0x50D3330", VA = "0x1850D4730", Slot = "6")]
		protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name)
		{
			return null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x50D42D0", Offset = "0x50D2ED0", VA = "0x1850D42D0", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x48")]
		private long[] hashes;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x50")]
		private MonoBtlsX509[] certificates;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x58")]
		private X509CertificateCollection collection;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x60")]
		private MonoBtlsX509TrustKind trust;
	}
}
