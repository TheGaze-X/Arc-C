using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class DerGeneralizedTime : Asn1Object
	{
		// Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002036")]
		[Address(RVA = "0x531F8A0", Offset = "0x531E4A0", VA = "0x18531F8A0")]
		public static DerGeneralizedTime GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x531F650", Offset = "0x531E250", VA = "0x18531F650")]
		public static DerGeneralizedTime GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x5320270", Offset = "0x531EE70", VA = "0x185320270")]
		public DerGeneralizedTime(string time)
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x5320380", Offset = "0x531EF80", VA = "0x185320380")]
		public DerGeneralizedTime(DateTime time)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x5320340", Offset = "0x531EF40", VA = "0x185320340")]
		internal DerGeneralizedTime(byte[] bytes)
		{
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000431")]
		public string TimeString
		{
			[Token(Token = "0x600203B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x531FA30", Offset = "0x531E630", VA = "0x18531FA30")]
		public string GetTime()
		{
			return null;
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x531F140", Offset = "0x531DD40", VA = "0x18531F140")]
		private string CalculateGmtOffset()
		{
			return null;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x531F510", Offset = "0x531E110", VA = "0x18531F510")]
		private static string Convert(int time)
		{
			return null;
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x531FFC0", Offset = "0x531EBC0", VA = "0x18531FFC0")]
		public DateTime ToDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x531F5B0", Offset = "0x531E1B0", VA = "0x18531F5B0")]
		private string FString(int count)
		{
			return null;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x531FDD0", Offset = "0x531E9D0", VA = "0x18531FDD0")]
		private DateTime ParseDateString(string s, string format, bool makeUniversal)
		{
			return default(DateTime);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x17000432")]
		private bool HasFractionalSeconds
		{
			[Token(Token = "0x6002042")]
			[Address(RVA = "0x5320400", Offset = "0x531F000", VA = "0x185320400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		private byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x531F570", Offset = "0x531E170", VA = "0x18531F570", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0000F348 File Offset: 0x0000D548
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x531F090", Offset = "0x531DC90", VA = "0x18531F090", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x10")]
		private readonly string time;
	}
}
