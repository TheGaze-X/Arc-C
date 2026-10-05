using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C3B RID: 3131
	[Token(Token = "0x2000C3B")]
	[Serializable]
	public class ActArchiveMusicData
	{
		// Token: 0x0600691B RID: 26907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691B")]
		[Address(RVA = "0x1FF8BA0", Offset = "0x1FF77A0", VA = "0x181FF8BA0")]
		public ActArchiveMusicData()
		{
		}

		// Token: 0x04003FFD RID: 16381
		[Token(Token = "0x4003FFD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveMusicItemData> musics;
	}
}
