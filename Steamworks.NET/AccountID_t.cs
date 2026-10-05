using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	[Serializable]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public AccountID_t(uint value)
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4ED7280", Offset = "0x4ED5E80", VA = "0x184ED7280", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0000A0DC File Offset: 0x000082DC
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0000A10C File Offset: 0x0000830C
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x4ED7370", Offset = "0x4ED5F70", VA = "0x184ED7370")]
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0000A124 File Offset: 0x00008324
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0000A13C File Offset: 0x0000833C
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(AccountID_t that)
		{
			return 0U;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0000A154 File Offset: 0x00008354
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(AccountID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000A16C File Offset: 0x0000836C
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(AccountID_t other)
		{
			return 0;
		}

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AccountID_t Invalid;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x0")]
		public uint m_AccountID;
	}
}
