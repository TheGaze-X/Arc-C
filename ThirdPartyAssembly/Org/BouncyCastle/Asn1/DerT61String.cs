using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	public class DerT61String : DerStringBase
	{
		// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x53372D0", Offset = "0x5335ED0", VA = "0x1853372D0")]
		public static DerT61String GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x5337450", Offset = "0x5336050", VA = "0x185337450")]
		public static DerT61String GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x5337690", Offset = "0x5336290", VA = "0x185337690")]
		public DerT61String(byte[] str)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x5337600", Offset = "0x5336200", VA = "0x185337600")]
		public DerT61String(string str)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x5337220", Offset = "0x5335E20", VA = "0x185337220", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x53375F0", Offset = "0x53361F0", VA = "0x1853375F0")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x5337170", Offset = "0x5335D70", VA = "0x185337170", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
