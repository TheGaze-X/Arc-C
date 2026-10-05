using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	[Serializable]
	public struct SteamNetworkingMicroseconds : IEquatable<SteamNetworkingMicroseconds>, IComparable<SteamNetworkingMicroseconds>
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public SteamNetworkingMicroseconds(long value)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x4F0F8F0", Offset = "0x4F0E4F0", VA = "0x184F0F8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00009944 File Offset: 0x00007B44
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x4F0F850", Offset = "0x4F0E450", VA = "0x184F0F850", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0000995C File Offset: 0x00007B5C
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x4F0F8E0", Offset = "0x4F0E4E0", VA = "0x184F0F8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00009974 File Offset: 0x00007B74
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			return default(bool);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0000998C File Offset: 0x00007B8C
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			return default(bool);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000099A4 File Offset: 0x00007BA4
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator SteamNetworkingMicroseconds(long value)
		{
			return default(SteamNetworkingMicroseconds);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000099BC File Offset: 0x00007BBC
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator long(SteamNetworkingMicroseconds that)
		{
			return 0L;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000099D4 File Offset: 0x00007BD4
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(SteamNetworkingMicroseconds other)
		{
			return default(bool);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x000099EC File Offset: 0x00007BEC
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x4F0F840", Offset = "0x4F0E440", VA = "0x184F0F840", Slot = "5")]
		public int CompareTo(SteamNetworkingMicroseconds other)
		{
			return 0;
		}

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x0")]
		public long m_SteamNetworkingMicroseconds;
	}
}
