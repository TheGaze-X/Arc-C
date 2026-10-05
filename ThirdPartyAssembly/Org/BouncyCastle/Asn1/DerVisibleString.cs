using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003D2 RID: 978
	[Token(Token = "0x20003D2")]
	public class DerVisibleString : DerStringBase
	{
		// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x5339E10", Offset = "0x5338A10", VA = "0x185339E10")]
		public static DerVisibleString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x5339DE0", Offset = "0x53389E0", VA = "0x185339DE0")]
		public static DerVisibleString GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x533A140", Offset = "0x5338D40", VA = "0x18533A140")]
		public DerVisibleString(byte[] str)
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x533A1E0", Offset = "0x5338DE0", VA = "0x18533A1E0")]
		public DerVisibleString(string str)
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x5339D30", Offset = "0x5338930", VA = "0x185339D30", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0000F648 File Offset: 0x0000D848
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x5339C80", Offset = "0x5338880", VA = "0x185339C80", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0000F660 File Offset: 0x0000D860
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
