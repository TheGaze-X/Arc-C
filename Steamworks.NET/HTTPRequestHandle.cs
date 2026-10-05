using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	[Serializable]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		// Token: 0x06000A4F RID: 2639 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HTTPRequestHandle(uint value)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00008C6C File Offset: 0x00006E6C
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x4EDF160", Offset = "0x4EDDD60", VA = "0x184EDF160", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00008C84 File Offset: 0x00006E84
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x4EDF240", Offset = "0x4EDDE40", VA = "0x184EDF240")]
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00008CCC File Offset: 0x00006ECC
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return 0U;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00008CFC File Offset: 0x00006EFC
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HTTPRequestHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00008D14 File Offset: 0x00006F14
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(HTTPRequestHandle other)
		{
			return 0;
		}

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HTTPRequestHandle Invalid;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HTTPRequestHandle;
	}
}
