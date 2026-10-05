using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	public class CertificateStatusRequest
	{
		// Token: 0x06001452 RID: 5202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x5243840", Offset = "0x5242440", VA = "0x185243840")]
		public CertificateStatusRequest(byte statusType, object request)
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x170002D8")]
		public virtual byte StatusType
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D9")]
		public virtual object Request
		{
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x5243440", Offset = "0x5242040", VA = "0x185243440", Slot = "6")]
		public virtual OcspStatusRequest GetOcspStatusRequest()
		{
			return null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x5243260", Offset = "0x5241E60", VA = "0x185243260", Slot = "7")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x52436D0", Offset = "0x52422D0", VA = "0x1852436D0")]
		public static CertificateStatusRequest Parse(Stream input)
		{
			return null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x52435C0", Offset = "0x52421C0", VA = "0x1852435C0")]
		protected static bool IsCorrectType(byte statusType, object request)
		{
			return default(bool);
		}

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte mStatusType;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x18")]
		protected readonly object mRequest;
	}
}
