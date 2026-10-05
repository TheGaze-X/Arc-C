using System;
using Il2CppDummyDll;

namespace FullInspector.Rotorz.ReorderableList
{
	// Token: 0x02007C67 RID: 31847
	[Token(Token = "0x2007C67")]
	[Flags]
	public enum ReorderableListFlags
	{
		// Token: 0x0404033C RID: 262972
		[Token(Token = "0x404033C")]
		DisableReordering = 1,
		// Token: 0x0404033D RID: 262973
		[Token(Token = "0x404033D")]
		HideAddButton = 2,
		// Token: 0x0404033E RID: 262974
		[Token(Token = "0x404033E")]
		HideRemoveButtons = 4,
		// Token: 0x0404033F RID: 262975
		[Token(Token = "0x404033F")]
		DisableContextMenu = 8,
		// Token: 0x04040340 RID: 262976
		[Token(Token = "0x4040340")]
		DisableDuplicateCommand = 16,
		// Token: 0x04040341 RID: 262977
		[Token(Token = "0x4040341")]
		DisableAutoFocus = 32,
		// Token: 0x04040342 RID: 262978
		[Token(Token = "0x4040342")]
		ShowIndices = 64,
		// Token: 0x04040343 RID: 262979
		[Token(Token = "0x4040343")]
		DisableClipping = 128
	}
}
