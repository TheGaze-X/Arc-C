using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	[Serializable]
	public struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public RTime32(uint value)
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0000A3C4 File Offset: 0x000085C4
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x4F1A120", Offset = "0x4F18D20", VA = "0x184F1A120", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000A3DC File Offset: 0x000085DC
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0000A3F4 File Offset: 0x000085F4
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(RTime32 x, RTime32 y)
		{
			return default(bool);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000A40C File Offset: 0x0000860C
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(RTime32 x, RTime32 y)
		{
			return default(bool);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000A424 File Offset: 0x00008624
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator RTime32(uint value)
		{
			return default(RTime32);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0000A43C File Offset: 0x0000863C
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(RTime32 that)
		{
			return 0U;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0000A454 File Offset: 0x00008654
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(RTime32 other)
		{
			return default(bool);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0000A46C File Offset: 0x0000866C
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(RTime32 other)
		{
			return 0;
		}

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x0")]
		public uint m_RTime32;
	}
}
