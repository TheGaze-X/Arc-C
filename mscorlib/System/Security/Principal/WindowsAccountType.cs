using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public enum WindowsAccountType
	{
		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		Normal,
		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		Guest,
		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		System,
		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		Anonymous
	}
}
