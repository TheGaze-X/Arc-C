using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[Serializable]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		// Token: 0x06000B38 RID: 2872 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public SNetSocket_t(uint value)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00009B84 File Offset: 0x00007D84
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x4F0D280", Offset = "0x4F0BE80", VA = "0x184F0D280", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00009B9C File Offset: 0x00007D9C
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00009BB4 File Offset: 0x00007DB4
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00009BCC File Offset: 0x00007DCC
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00009BE4 File Offset: 0x00007DE4
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00009BFC File Offset: 0x00007DFC
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(SNetSocket_t that)
		{
			return 0U;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00009C14 File Offset: 0x00007E14
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(SNetSocket_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00009C2C File Offset: 0x00007E2C
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(SNetSocket_t other)
		{
			return 0;
		}

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x0")]
		public uint m_SNetSocket;
	}
}
