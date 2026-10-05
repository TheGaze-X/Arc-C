using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	public class Certificate
	{
		// Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x5244BB0", Offset = "0x52437B0", VA = "0x185244BB0")]
		public Certificate(X509CertificateStructure[] certificateList)
		{
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x4D2CF60", Offset = "0x4D2BB60", VA = "0x184D2CF60", Slot = "4")]
		public virtual X509CertificateStructure[] GetCertificateList()
		{
			return null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x187C640", Offset = "0x187B240", VA = "0x18187C640", Slot = "5")]
		public virtual X509CertificateStructure GetCertificateAt(int index)
		{
			return null;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x170002D1")]
		public virtual int Length
		{
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x170002D2")]
		public virtual bool IsEmpty
		{
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x5244C40", Offset = "0x5243840", VA = "0x185244C40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x5244060", Offset = "0x5242C60", VA = "0x185244060", Slot = "8")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x52444E0", Offset = "0x52430E0", VA = "0x1852444E0")]
		public static Certificate Parse(Stream input)
		{
			return null;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x5243FE0", Offset = "0x5242BE0", VA = "0x185243FE0", Slot = "9")]
		protected virtual X509CertificateStructure[] CloneCertificateList()
		{
			return null;
		}

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Certificate EmptyChain;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x10")]
		protected readonly X509CertificateStructure[] mCertificateList;
	}
}
