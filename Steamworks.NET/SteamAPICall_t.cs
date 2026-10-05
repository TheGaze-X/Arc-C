using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	[Serializable]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public SteamAPICall_t(ulong value)
		{
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0000A484 File Offset: 0x00008684
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x4F1A1A0", Offset = "0x4F18DA0", VA = "0x184F1A1A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0000A49C File Offset: 0x0000869C
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0000A4B4 File Offset: 0x000086B4
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0000A4CC File Offset: 0x000086CC
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x4F1A280", Offset = "0x4F18E80", VA = "0x184F1A280")]
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000A4E4 File Offset: 0x000086E4
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000A4FC File Offset: 0x000086FC
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000A514 File Offset: 0x00008714
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(SteamAPICall_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0000A52C File Offset: 0x0000872C
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(SteamAPICall_t other)
		{
			return 0;
		}

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamAPICall_t Invalid;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;
	}
}
