using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	[Serializable]
	public struct SteamDatagramHostedAddress
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x4F0E0A0", Offset = "0x4F0CCA0", VA = "0x184F0E0A0")]
		public void Clear()
		{
		}

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x0")]
		public int m_cbSize;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x8")]
		public byte[] m_data;
	}
}
