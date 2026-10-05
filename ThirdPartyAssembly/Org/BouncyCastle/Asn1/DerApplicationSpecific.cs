using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	public class DerApplicationSpecific : Asn1Object
	{
		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x5318E40", Offset = "0x5317A40", VA = "0x185318E40")]
		internal DerApplicationSpecific(bool isConstructed, int tag, byte[] octets)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x531AFE0", Offset = "0x5319BE0", VA = "0x18531AFE0")]
		public DerApplicationSpecific(int tag, byte[] octets)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x531B030", Offset = "0x5319C30", VA = "0x18531B030")]
		public DerApplicationSpecific(int tag, Asn1Encodable obj)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x531AE10", Offset = "0x5319A10", VA = "0x18531AE10")]
		public DerApplicationSpecific(bool isExplicit, int tag, Asn1Encodable obj)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x531AC50", Offset = "0x5319850", VA = "0x18531AC50")]
		public DerApplicationSpecific(int tagNo, Asn1EncodableVector vec)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0000F150 File Offset: 0x0000D350
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x531A840", Offset = "0x5319440", VA = "0x18531A840")]
		private int GetLengthOfHeader(byte[] data)
		{
			return 0;
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0000F168 File Offset: 0x0000D368
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
		public bool IsConstructed()
		{
			return default(bool);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public byte[] GetContents()
		{
			return null;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x0000F180 File Offset: 0x0000D380
		[Token(Token = "0x17000427")]
		public int ApplicationTag
		{
			[Token(Token = "0x6001FEC")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x531A910", Offset = "0x5319510", VA = "0x18531A910")]
		public Asn1Object GetObject()
		{
			return null;
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x531A920", Offset = "0x5319520", VA = "0x18531A920")]
		public Asn1Object GetObject(int derTagNo)
		{
			return null;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x531A7F0", Offset = "0x53193F0", VA = "0x18531A7F0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0000F198 File Offset: 0x0000D398
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x531A6A0", Offset = "0x53192A0", VA = "0x18531A6A0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x531A760", Offset = "0x5319360", VA = "0x18531A760", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x531AB00", Offset = "0x5319700", VA = "0x18531AB00")]
		private byte[] ReplaceTagNumber(int newTag, byte[] input)
		{
			return null;
		}

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool isConstructed;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x14")]
		private readonly int tag;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] octets;
	}
}
