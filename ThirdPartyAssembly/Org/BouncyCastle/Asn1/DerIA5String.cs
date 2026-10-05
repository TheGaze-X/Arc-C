using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	public class DerIA5String : DerStringBase
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x5331A90", Offset = "0x5330690", VA = "0x185331A90")]
		public static DerIA5String GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205E")]
		[Address(RVA = "0x5331810", Offset = "0x5330410", VA = "0x185331810")]
		public static DerIA5String GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x5331C70", Offset = "0x5330870", VA = "0x185331C70")]
		public DerIA5String(byte[] str)
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002060")]
		[Address(RVA = "0x5331D10", Offset = "0x5330910", VA = "0x185331D10")]
		public DerIA5String(string str)
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002061")]
		[Address(RVA = "0x5331DA0", Offset = "0x53309A0", VA = "0x185331DA0")]
		public DerIA5String(string str, bool validate)
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x5331760", Offset = "0x5330360", VA = "0x185331760", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x53316B0", Offset = "0x53302B0", VA = "0x1853316B0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x5331C10", Offset = "0x5330810", VA = "0x185331C10")]
		public static bool IsIA5String(string str)
		{
			return default(bool);
		}

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
