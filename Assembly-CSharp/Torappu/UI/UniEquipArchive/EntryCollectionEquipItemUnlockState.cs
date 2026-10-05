using System;
using Il2CppDummyDll;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C07 RID: 15367
	[Token(Token = "0x2003C07")]
	public enum EntryCollectionEquipItemUnlockState
	{
		// Token: 0x0401D22A RID: 119338
		[Token(Token = "0x401D22A")]
		PHASE_2_AND_CAN_UNLOCK,
		// Token: 0x0401D22B RID: 119339
		[Token(Token = "0x401D22B")]
		PHASE_2_BUT_CANT_UNLOCK,
		// Token: 0x0401D22C RID: 119340
		[Token(Token = "0x401D22C")]
		NOT_PHASE_2_CANT_UNLOCK,
		// Token: 0x0401D22D RID: 119341
		[Token(Token = "0x401D22D")]
		NOT_OWN_CHAR_CANT_UNLOCK,
		// Token: 0x0401D22E RID: 119342
		[Token(Token = "0x401D22E")]
		UNLOCKED
	}
}
