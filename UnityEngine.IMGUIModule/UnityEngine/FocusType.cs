using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public enum FocusType
	{
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
		Native,
		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		Keyboard,
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		Passive
	}
}
