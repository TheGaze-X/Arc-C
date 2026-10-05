using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	public class CertificateStatus
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x5243F20", Offset = "0x5242B20", VA = "0x185243F20")]
		public CertificateStatus(byte statusType, object response)
		{
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x170002D6")]
		public virtual byte StatusType
		{
			[Token(Token = "0x600144C")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D7")]
		public virtual object Response
		{
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x5243B00", Offset = "0x5242700", VA = "0x185243B00", Slot = "6")]
		public virtual OcspResponse GetOcspResponse()
		{
			return null;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x5243900", Offset = "0x5242500", VA = "0x185243900", Slot = "7")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x5243D90", Offset = "0x5242990", VA = "0x185243D90")]
		public static CertificateStatus Parse(Stream input)
		{
			return null;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x5243C80", Offset = "0x5242880", VA = "0x185243C80")]
		protected static bool IsCorrectType(byte statusType, object response)
		{
			return default(bool);
		}

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte mStatusType;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x18")]
		protected readonly object mResponse;
	}
}
