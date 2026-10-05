using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[Serializable]
	public struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public RemotePlaySessionID_t(uint value)
		{
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00009C44 File Offset: 0x00007E44
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x4F0CE20", Offset = "0x4F0BA20", VA = "0x184F0CE20", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00009C5C File Offset: 0x00007E5C
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00009C74 File Offset: 0x00007E74
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00009C8C File Offset: 0x00007E8C
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator RemotePlaySessionID_t(uint value)
		{
			return default(RemotePlaySessionID_t);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00009CBC File Offset: 0x00007EBC
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(RemotePlaySessionID_t that)
		{
			return 0U;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00009CD4 File Offset: 0x00007ED4
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(RemotePlaySessionID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00009CEC File Offset: 0x00007EEC
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(RemotePlaySessionID_t other)
		{
			return 0;
		}

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x0")]
		public uint m_RemotePlaySessionID;
	}
}
