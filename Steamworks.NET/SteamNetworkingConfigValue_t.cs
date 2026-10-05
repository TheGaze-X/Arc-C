using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	[Serializable]
	public struct SteamNetworkingConfigValue_t
	{
		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ESteamNetworkingConfigValue m_eValue;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ESteamNetworkingConfigDataType m_eDataType;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamNetworkingConfigValue_t.OptionValue m_val;

		// Token: 0x020001DA RID: 474
		[Token(Token = "0x20001DA")]
		[StructLayout(2)]
		public struct OptionValue
		{
			// Token: 0x04000B0C RID: 2828
			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int m_int32;

			// Token: 0x04000B0D RID: 2829
			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long m_int64;

			// Token: 0x04000B0E RID: 2830
			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float m_float;

			// Token: 0x04000B0F RID: 2831
			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr m_string;

			// Token: 0x04000B10 RID: 2832
			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr m_functionPtr;
		}
	}
}
