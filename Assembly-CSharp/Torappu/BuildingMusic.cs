using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public class BuildingMusic
	{
		// Token: 0x0600673E RID: 26430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600673E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMusic()
		{
		}

		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		[FieldOffset(Offset = "0x10")]
		public bool inUse;

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x18")]
		public string selected;

		// Token: 0x0400390A RID: 14602
		[Token(Token = "0x400390A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, BuildingMusicState> state;
	}
}
