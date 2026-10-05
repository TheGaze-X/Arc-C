using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[UsedByNativeCode]
	[Flags]
	public enum GlyphLoadFlags
	{
		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		LOAD_DEFAULT = 0,
		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		LOAD_NO_SCALE = 1,
		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		LOAD_NO_HINTING = 2,
		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		LOAD_RENDER = 4,
		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		LOAD_NO_BITMAP = 8,
		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		LOAD_FORCE_AUTOHINT = 32,
		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		LOAD_MONOCHROME = 4096,
		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		LOAD_NO_AUTOHINT = 32768,
		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		LOAD_COLOR = 1048576,
		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		LOAD_COMPUTE_METRICS = 2097152,
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		LOAD_BITMAP_METRICS_ONLY = 4194304
	}
}
