using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	[Serializable]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HSteamPipe(int value)
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x4EDEC00", Offset = "0x4EDD800", VA = "0x184EDEC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0000A874 File Offset: 0x00008A74
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x4F1A020", Offset = "0x4F18C20", VA = "0x184F1A020", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0000A88C File Offset: 0x00008A8C
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0000A8BC File Offset: 0x00008ABC
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0000A8EC File Offset: 0x00008AEC
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator int(HSteamPipe that)
		{
			return 0;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0000A904 File Offset: 0x00008B04
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HSteamPipe other)
		{
			return default(bool);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0000A91C File Offset: 0x00008B1C
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x4EDEB50", Offset = "0x4EDD750", VA = "0x184EDEB50", Slot = "5")]
		public int CompareTo(HSteamPipe other)
		{
			return 0;
		}

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x0")]
		public int m_HSteamPipe;
	}
}
