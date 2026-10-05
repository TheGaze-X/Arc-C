using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	[Serializable]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HTTPCookieContainerHandle(uint value)
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00008BAC File Offset: 0x00006DAC
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x4EDF030", Offset = "0x4EDDC30", VA = "0x184EDF030", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00008BDC File Offset: 0x00006DDC
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x4EDF110", Offset = "0x4EDDD10", VA = "0x184EDF110")]
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00008C0C File Offset: 0x00006E0C
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00008C24 File Offset: 0x00006E24
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return 0U;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00008C3C File Offset: 0x00006E3C
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00008C54 File Offset: 0x00006E54
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return 0;
		}

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HTTPCookieContainerHandle Invalid;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HTTPCookieContainerHandle;
	}
}
