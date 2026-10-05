using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[Serializable]
	public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection>
	{
		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HSteamNetConnection(uint value)
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00009584 File Offset: 0x00007784
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x4EDEDD0", Offset = "0x4EDD9D0", VA = "0x184EDEDD0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0000959C File Offset: 0x0000779C
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000095B4 File Offset: 0x000077B4
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HSteamNetConnection x, HSteamNetConnection y)
		{
			return default(bool);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000095CC File Offset: 0x000077CC
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x4EDEEB0", Offset = "0x4EDDAB0", VA = "0x184EDEEB0")]
		public static bool operator !=(HSteamNetConnection x, HSteamNetConnection y)
		{
			return default(bool);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x000095E4 File Offset: 0x000077E4
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HSteamNetConnection(uint value)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000095FC File Offset: 0x000077FC
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(HSteamNetConnection that)
		{
			return 0U;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00009614 File Offset: 0x00007814
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HSteamNetConnection other)
		{
			return default(bool);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0000962C File Offset: 0x0000782C
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(HSteamNetConnection other)
		{
			return 0;
		}

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HSteamNetConnection Invalid;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HSteamNetConnection;
	}
}
