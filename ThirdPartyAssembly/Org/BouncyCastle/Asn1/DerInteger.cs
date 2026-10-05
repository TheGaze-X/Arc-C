using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	public class DerInteger : Asn1Object
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x5332020", Offset = "0x5330C20", VA = "0x185332020")]
		public static DerInteger GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002069")]
		[Address(RVA = "0x53321A0", Offset = "0x5330DA0", VA = "0x1853321A0")]
		public static DerInteger GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x53323A0", Offset = "0x5330FA0", VA = "0x1853323A0")]
		public DerInteger(int value)
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206B")]
		[Address(RVA = "0x532F4F0", Offset = "0x532E0F0", VA = "0x18532F4F0")]
		public DerInteger(BigInteger value)
		{
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206C")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DerInteger(byte[] bytes)
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000433")]
		public BigInteger Value
		{
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x5332430", Offset = "0x5331030", VA = "0x185332430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000434")]
		public BigInteger PositiveValue
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x532F580", Offset = "0x532E180", VA = "0x18532F580")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x5331F70", Offset = "0x5330B70", VA = "0x185331F70", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x531D3D0", Offset = "0x531BFD0", VA = "0x18531D3D0", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x6002071")]
		[Address(RVA = "0x5331EC0", Offset = "0x5330AC0", VA = "0x185331EC0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x5332310", Offset = "0x5330F10", VA = "0x185332310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] bytes;
	}
}
