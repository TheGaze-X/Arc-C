using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	[Serializable]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public SNetListenSocket_t(uint value)
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00009AC4 File Offset: 0x00007CC4
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x4F0D200", Offset = "0x4F0BE00", VA = "0x184F0D200", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00009ADC File Offset: 0x00007CDC
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00009B0C File Offset: 0x00007D0C
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00009B24 File Offset: 0x00007D24
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00009B3C File Offset: 0x00007D3C
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return 0U;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00009B54 File Offset: 0x00007D54
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(SNetListenSocket_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00009B6C File Offset: 0x00007D6C
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(SNetListenSocket_t other)
		{
			return 0;
		}

		// Token: 0x04000B4B RID: 2891
		[Token(Token = "0x4000B4B")]
		[FieldOffset(Offset = "0x0")]
		public uint m_SNetListenSocket;
	}
}
