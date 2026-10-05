using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public class DerPrintableString : DerStringBase
	{
		// Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x5335410", Offset = "0x5334010", VA = "0x185335410")]
		public static DerPrintableString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x5335590", Offset = "0x5334190", VA = "0x185335590")]
		public static DerPrintableString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x5335AF0", Offset = "0x53346F0", VA = "0x185335AF0")]
		public DerPrintableString(byte[] str)
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x5335A60", Offset = "0x5334660", VA = "0x185335A60")]
		public DerPrintableString(string str)
		{
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x5335870", Offset = "0x5334470", VA = "0x185335870")]
		public DerPrintableString(string str, bool validate)
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x5335360", Offset = "0x5333F60", VA = "0x185335360", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x53352B0", Offset = "0x5333EB0", VA = "0x1853352B0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x5335740", Offset = "0x5334340", VA = "0x185335740")]
		public static bool IsPrintableString(string str)
		{
			return default(bool);
		}

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
