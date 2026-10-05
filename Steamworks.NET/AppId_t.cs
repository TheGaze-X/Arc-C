using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	[Serializable]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public AppId_t(uint value)
		{
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000A184 File Offset: 0x00008384
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x4ED7570", Offset = "0x4ED6170", VA = "0x184ED7570", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000A19C File Offset: 0x0000839C
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0000A1B4 File Offset: 0x000083B4
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000A1CC File Offset: 0x000083CC
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x4ED7650", Offset = "0x4ED6250", VA = "0x184ED7650")]
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000A1E4 File Offset: 0x000083E4
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000A1FC File Offset: 0x000083FC
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(AppId_t that)
		{
			return 0U;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0000A214 File Offset: 0x00008414
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(AppId_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0000A22C File Offset: 0x0000842C
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(AppId_t other)
		{
			return 0;
		}

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AppId_t Invalid;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x0")]
		public uint m_AppId;
	}
}
