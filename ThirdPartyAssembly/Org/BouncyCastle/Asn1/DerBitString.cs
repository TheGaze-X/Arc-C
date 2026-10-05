using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	public class DerBitString : DerStringBase
	{
		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x531B4B0", Offset = "0x531A0B0", VA = "0x18531B4B0")]
		public static DerBitString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x531B730", Offset = "0x531A330", VA = "0x18531B730")]
		public static DerBitString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x531BEE0", Offset = "0x531AAE0", VA = "0x18531BEE0")]
		public DerBitString(byte[] data, int padBits)
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x531BC20", Offset = "0x531A820", VA = "0x18531BC20")]
		public DerBitString(byte[] data)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x531BD80", Offset = "0x531A980", VA = "0x18531BD80")]
		public DerBitString(int namedBits)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x531BCC0", Offset = "0x531A8C0", VA = "0x18531BCC0")]
		public DerBitString(Asn1Encodable obj)
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x531B980", Offset = "0x531A580", VA = "0x18531B980", Slot = "11")]
		public virtual byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x531B450", Offset = "0x531A050", VA = "0x18531B450", Slot = "12")]
		public virtual byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x17000428")]
		public virtual int PadBits
		{
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x17000429")]
		public virtual int IntValue
		{
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x531C050", Offset = "0x531AC50", VA = "0x18531C050", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x531B1C0", Offset = "0x5319DC0", VA = "0x18531B1C0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x5284150", Offset = "0x5282D50", VA = "0x185284150", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x531B110", Offset = "0x5319D10", VA = "0x18531B110", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x531BA00", Offset = "0x531A600", VA = "0x18531BA00", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x531B2A0", Offset = "0x5319EA0", VA = "0x18531B2A0")]
		internal static DerBitString FromAsn1Octets(byte[] octets)
		{
			return null;
		}

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] table;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte[] mData;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x18")]
		protected readonly int mPadBits;
	}
}
