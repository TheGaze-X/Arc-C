using System;
using System.Net;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	[Serializable]
	public struct SteamIPAddress_t
	{
		// Token: 0x06000BC4 RID: 3012 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x4F1A530", Offset = "0x4F19130", VA = "0x184F1A530")]
		public SteamIPAddress_t(IPAddress iPAddress)
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x4F1A300", Offset = "0x4F18F00", VA = "0x184F1A300")]
		public IPAddress ToIPAddress()
		{
			return null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x4F1A4E0", Offset = "0x4F190E0", VA = "0x184F1A4E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0000A544 File Offset: 0x00008744
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
		public ESteamIPType GetIPType()
		{
			return ESteamIPType.k_ESteamIPTypeIPv4;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0000A55C File Offset: 0x0000875C
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x4F1A2E0", Offset = "0x4F18EE0", VA = "0x184F1A2E0")]
		public bool IsSet()
		{
			return default(bool);
		}

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x0")]
		private long m_ip0;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x8")]
		private long m_ip1;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x10")]
		private ESteamIPType m_eType;
	}
}
