using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	[Serializable]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HSteamUser(int value)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x4EDEC00", Offset = "0x4EDD800", VA = "0x184EDEC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0000A934 File Offset: 0x00008B34
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x4F1A0A0", Offset = "0x4F18CA0", VA = "0x184F1A0A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0000A94C File Offset: 0x00008B4C
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0000A964 File Offset: 0x00008B64
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0000A97C File Offset: 0x00008B7C
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0000A994 File Offset: 0x00008B94
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0000A9AC File Offset: 0x00008BAC
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator int(HSteamUser that)
		{
			return 0;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HSteamUser other)
		{
			return default(bool);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0000A9DC File Offset: 0x00008BDC
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x4EDEB50", Offset = "0x4EDD750", VA = "0x184EDEB50", Slot = "5")]
		public int CompareTo(HSteamUser other)
		{
			return 0;
		}

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x0")]
		public int m_HSteamUser;
	}
}
