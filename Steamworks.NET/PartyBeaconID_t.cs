using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	[Serializable]
	public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
	{
		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public PartyBeaconID_t(ulong value)
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0000A304 File Offset: 0x00008504
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4F0C8C0", Offset = "0x4F0B4C0", VA = "0x184F0C8C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000A31C File Offset: 0x0000851C
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0000A334 File Offset: 0x00008534
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000A34C File Offset: 0x0000854C
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x4F0C9A0", Offset = "0x4F0B5A0", VA = "0x184F0C9A0")]
		public static bool operator !=(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0000A364 File Offset: 0x00008564
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator PartyBeaconID_t(ulong value)
		{
			return default(PartyBeaconID_t);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000A37C File Offset: 0x0000857C
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(PartyBeaconID_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0000A394 File Offset: 0x00008594
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(PartyBeaconID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0000A3AC File Offset: 0x000085AC
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(PartyBeaconID_t other)
		{
			return 0;
		}

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PartyBeaconID_t Invalid;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_PartyBeaconID;
	}
}
