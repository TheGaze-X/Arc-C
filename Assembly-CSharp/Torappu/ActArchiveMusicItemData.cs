using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C3C RID: 3132
	[Token(Token = "0x2000C3C")]
	public class ActArchiveMusicItemData
	{
		// Token: 0x0600691C RID: 26908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveMusicItemData()
		{
		}

		// Token: 0x04003FFE RID: 16382
		[Token(Token = "0x4003FFE")]
		[FieldOffset(Offset = "0x10")]
		public string musicId;

		// Token: 0x04003FFF RID: 16383
		[Token(Token = "0x4003FFF")]
		[FieldOffset(Offset = "0x18")]
		public int musicSortId;
	}
}
