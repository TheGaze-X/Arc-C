using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	[Serializable]
	public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
	{
		// Token: 0x06000ACE RID: 2766 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HSteamListenSocket(uint value)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000094C4 File Offset: 0x000076C4
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x4EDECA0", Offset = "0x4EDD8A0", VA = "0x184EDECA0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000094DC File Offset: 0x000076DC
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000094F4 File Offset: 0x000076F4
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HSteamListenSocket x, HSteamListenSocket y)
		{
			return default(bool);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0000950C File Offset: 0x0000770C
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x4EDED80", Offset = "0x4EDD980", VA = "0x184EDED80")]
		public static bool operator !=(HSteamListenSocket x, HSteamListenSocket y)
		{
			return default(bool);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00009524 File Offset: 0x00007724
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HSteamListenSocket(uint value)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000953C File Offset: 0x0000773C
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(HSteamListenSocket that)
		{
			return 0U;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00009554 File Offset: 0x00007754
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HSteamListenSocket other)
		{
			return default(bool);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000956C File Offset: 0x0000776C
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(HSteamListenSocket other)
		{
			return 0;
		}

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HSteamListenSocket Invalid;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HSteamListenSocket;
	}
}
