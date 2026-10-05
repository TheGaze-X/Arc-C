using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x2000C2E")]
	public class ActArchiveCopperItemData
	{
		// Token: 0x0600690C RID: 26892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690C")]
		[Address(RVA = "0x1FF88B0", Offset = "0x1FF74B0", VA = "0x181FF88B0")]
		public ActArchiveCopperItemData()
		{
		}

		// Token: 0x04003FC8 RID: 16328
		[Token(Token = "0x4003FC8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04003FC9 RID: 16329
		[Token(Token = "0x4003FC9")]
		[FieldOffset(Offset = "0x18")]
		public string displayCopperId;

		// Token: 0x04003FCA RID: 16330
		[Token(Token = "0x4003FCA")]
		[FieldOffset(Offset = "0x20")]
		public ActArchiveCopperType archiveType;

		// Token: 0x04003FCB RID: 16331
		[Token(Token = "0x4003FCB")]
		[FieldOffset(Offset = "0x24")]
		public RoguelikeCopperType copperType;

		// Token: 0x04003FCC RID: 16332
		[Token(Token = "0x4003FCC")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x04003FCD RID: 16333
		[Token(Token = "0x4003FCD")]
		[FieldOffset(Offset = "0x30")]
		public string enrollId;

		// Token: 0x04003FCE RID: 16334
		[Token(Token = "0x4003FCE")]
		[FieldOffset(Offset = "0x38")]
		public List<string> coppersInGroup;
	}
}
