using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	[Serializable]
	public struct servernetadr_t
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x4F19C80", Offset = "0x4F18880", VA = "0x184F19C80")]
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0000848C File Offset: 0x0000668C
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x4009BB0", Offset = "0x40087B0", VA = "0x184009BB0")]
		public ushort GetQueryPort()
		{
			return 0;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x4F19C90", Offset = "0x4F18890", VA = "0x184F19C90")]
		public void SetQueryPort(ushort usPort)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000084A4 File Offset: 0x000066A4
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50")]
		public ushort GetConnectionPort()
		{
			return 0;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x4EDD9F0", Offset = "0x4EDC5F0", VA = "0x184EDD9F0")]
		public void SetConnectionPort(ushort usPort)
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000084BC File Offset: 0x000066BC
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
		public uint GetIP()
		{
			return 0U;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
		public void SetIP(uint unIP)
		{
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x4F19C10", Offset = "0x4F18810", VA = "0x184F19C10")]
		public string GetConnectionAddressString()
		{
			return null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x4F19C70", Offset = "0x4F18870", VA = "0x184F19C70")]
		public string GetQueryAddressString()
		{
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x4F19CA0", Offset = "0x4F188A0", VA = "0x184F19CA0")]
		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000084D4 File Offset: 0x000066D4
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x4F19FF0", Offset = "0x4F18BF0", VA = "0x184F19FF0")]
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000084EC File Offset: 0x000066EC
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x4F19F80", Offset = "0x4F18B80", VA = "0x184F19F80")]
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00008504 File Offset: 0x00006704
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x4F19B30", Offset = "0x4F18730", VA = "0x184F19B30", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0000851C File Offset: 0x0000671C
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x4F19C20", Offset = "0x4F18820", VA = "0x184F19C20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00008534 File Offset: 0x00006734
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x4F19F40", Offset = "0x4F18B40", VA = "0x184F19F40")]
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0000854C File Offset: 0x0000674C
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x4F19FB0", Offset = "0x4F18BB0", VA = "0x184F19FB0")]
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00008564 File Offset: 0x00006764
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x4F19BE0", Offset = "0x4F187E0", VA = "0x184F19BE0")]
		public bool Equals(servernetadr_t other)
		{
			return default(bool);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0000857C File Offset: 0x0000677C
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x4F19AC0", Offset = "0x4F186C0", VA = "0x184F19AC0")]
		public int CompareTo(servernetadr_t other)
		{
			return 0;
		}

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x0")]
		private ushort m_usConnectionPort;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x2")]
		private ushort m_usQueryPort;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x4")]
		private uint m_unIP;
	}
}
