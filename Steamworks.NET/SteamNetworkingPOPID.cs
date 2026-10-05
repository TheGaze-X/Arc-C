using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	[Serializable]
	public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public SteamNetworkingPOPID(uint value)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00009A04 File Offset: 0x00007C04
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x4F0F900", Offset = "0x4F0E500", VA = "0x184F0F900", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00009A1C File Offset: 0x00007C1C
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00009A34 File Offset: 0x00007C34
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			return default(bool);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00009A4C File Offset: 0x00007C4C
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			return default(bool);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00009A64 File Offset: 0x00007C64
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator SteamNetworkingPOPID(uint value)
		{
			return default(SteamNetworkingPOPID);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00009A7C File Offset: 0x00007C7C
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(SteamNetworkingPOPID that)
		{
			return 0U;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00009A94 File Offset: 0x00007C94
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(SteamNetworkingPOPID other)
		{
			return default(bool);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00009AAC File Offset: 0x00007CAC
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(SteamNetworkingPOPID other)
		{
			return 0;
		}

		// Token: 0x04000B4A RID: 2890
		[Token(Token = "0x4000B4A")]
		[FieldOffset(Offset = "0x0")]
		public uint m_SteamNetworkingPOPID;
	}
}
