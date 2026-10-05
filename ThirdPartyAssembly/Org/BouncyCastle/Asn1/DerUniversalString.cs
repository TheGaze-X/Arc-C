using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003CE RID: 974
	[Token(Token = "0x20003CE")]
	public class DerUniversalString : DerStringBase
	{
		// Token: 0x060020DF RID: 8415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x5337C50", Offset = "0x5336850", VA = "0x185337C50")]
		public static DerUniversalString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x5337AA0", Offset = "0x53366A0", VA = "0x185337AA0")]
		public static DerUniversalString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x5338070", Offset = "0x5336C70", VA = "0x185338070")]
		public DerUniversalString(byte[] str)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x5337E50", Offset = "0x5336A50", VA = "0x185337E50", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x5337DD0", Offset = "0x53369D0", VA = "0x185337DD0")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x53379F0", Offset = "0x53365F0", VA = "0x1853379F0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x5337940", Offset = "0x5336540", VA = "0x185337940", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] table;

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] str;
	}
}
