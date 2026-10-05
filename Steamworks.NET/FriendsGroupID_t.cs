using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[Serializable]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x4EDD9F0", Offset = "0x4EDC5F0", VA = "0x184EDD9F0")]
		public FriendsGroupID_t(short value)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x4EDD9A0", Offset = "0x4EDC5A0", VA = "0x184EDD9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00008A2C File Offset: 0x00006C2C
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x4EDD8F0", Offset = "0x4EDC4F0", VA = "0x184EDD8F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00008A44 File Offset: 0x00006C44
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x4EDD990", Offset = "0x4EDC590", VA = "0x184EDD990", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00008A5C File Offset: 0x00006C5C
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x4EDDA00", Offset = "0x4EDC600", VA = "0x184EDDA00")]
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00008A74 File Offset: 0x00006C74
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x4EDDA10", Offset = "0x4EDC610", VA = "0x184EDDA10")]
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00008A8C File Offset: 0x00006C8C
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00008AA4 File Offset: 0x00006CA4
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		public static explicit operator short(FriendsGroupID_t that)
		{
			return 0;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00008ABC File Offset: 0x00006CBC
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x4CA90E0", Offset = "0x4CA7CE0", VA = "0x184CA90E0", Slot = "4")]
		public bool Equals(FriendsGroupID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00008AD4 File Offset: 0x00006CD4
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x4EDD8E0", Offset = "0x4EDC4E0", VA = "0x184EDD8E0", Slot = "5")]
		public int CompareTo(FriendsGroupID_t other)
		{
			return 0;
		}

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FriendsGroupID_t Invalid;

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x0")]
		public short m_FriendsGroupID;
	}
}
