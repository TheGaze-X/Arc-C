using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	public class DerNumericString : DerStringBase
	{
		// Token: 0x06002079 RID: 8313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002079")]
		[Address(RVA = "0x5332A60", Offset = "0x5331660", VA = "0x185332A60")]
		public static DerNumericString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x53328B0", Offset = "0x53314B0", VA = "0x1853328B0")]
		public static DerNumericString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x5332EA0", Offset = "0x5331AA0", VA = "0x185332EA0")]
		public DerNumericString(byte[] str)
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x5332E10", Offset = "0x5331A10", VA = "0x185332E10")]
		public DerNumericString(string str)
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x5332C90", Offset = "0x5331890", VA = "0x185332C90")]
		public DerNumericString(string str, bool validate)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x5332800", Offset = "0x5331400", VA = "0x185332800", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x5332750", Offset = "0x5331350", VA = "0x185332750", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x5332BE0", Offset = "0x53317E0", VA = "0x185332BE0")]
		public static bool IsNumericString(string str)
		{
			return default(bool);
		}

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
