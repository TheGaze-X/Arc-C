using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	public struct SteamParamStringArray_t
	{
		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr m_ppStrings;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x8")]
		public int m_nNumStrings;
	}
}
