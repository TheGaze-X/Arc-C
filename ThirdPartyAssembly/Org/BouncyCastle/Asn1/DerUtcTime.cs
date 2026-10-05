using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	public class DerUtcTime : Asn1Object
	{
		// Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x5338480", Offset = "0x5337080", VA = "0x185338480")]
		public static DerUtcTime GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x5338260", Offset = "0x5336E60", VA = "0x185338260")]
		public static DerUtcTime GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x5338750", Offset = "0x5337350", VA = "0x185338750")]
		public DerUtcTime(string time)
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x53388F0", Offset = "0x53374F0", VA = "0x1853388F0")]
		public DerUtcTime(DateTime time)
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x53388B0", Offset = "0x53374B0", VA = "0x1853388B0")]
		internal DerUtcTime(byte[] bytes)
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x5338700", Offset = "0x5337300", VA = "0x185338700")]
		public DateTime ToDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x53386B0", Offset = "0x53372B0", VA = "0x1853386B0")]
		public DateTime ToAdjustedDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x5338600", Offset = "0x5337200", VA = "0x185338600")]
		private DateTime ParseDateString(string dateStr, string formatStr)
		{
			return default(DateTime);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000436")]
		public string TimeString
		{
			[Token(Token = "0x60020EF")]
			[Address(RVA = "0x5338A60", Offset = "0x5337660", VA = "0x185338A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000437")]
		[Obsolete("Use 'AdjustedTimeString' property instead")]
		public string AdjustedTime
		{
			[Token(Token = "0x60020F0")]
			[Address(RVA = "0x5338A50", Offset = "0x5337650", VA = "0x185338A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000438")]
		public string AdjustedTimeString
		{
			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x53389D0", Offset = "0x53375D0", VA = "0x1853389D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		private byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x53381B0", Offset = "0x5336DB0", VA = "0x1853381B0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x5338100", Offset = "0x5336D00", VA = "0x185338100", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x10")]
		private readonly string time;
	}
}
