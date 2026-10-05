using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[Flags]
	[Serializable]
	public enum FlexibleValueMeta
	{
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		NONE = 0,
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		FIXED_SCHEMA = 1,
		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		NOT_REMOVABLE = 2,
		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		HIDE_INSPECTOR = 4,
		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		READ_ONLY = 8
	}
}
