using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F92 RID: 3986
	[Token(Token = "0x2000F92")]
	[Serializable]
	public class ClimbTowerDropDisplayInfo
	{
		// Token: 0x06006CD0 RID: 27856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerDropDisplayInfo()
		{
		}

		// Token: 0x040054A1 RID: 21665
		[Token(Token = "0x40054A1")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040054A2 RID: 21666
		[Token(Token = "0x40054A2")]
		[FieldOffset(Offset = "0x18")]
		public ItemType type;

		// Token: 0x040054A3 RID: 21667
		[Token(Token = "0x40054A3")]
		[FieldOffset(Offset = "0x1C")]
		public int maxCount;

		// Token: 0x040054A4 RID: 21668
		[Token(Token = "0x40054A4")]
		[FieldOffset(Offset = "0x20")]
		public int minCount;
	}
}
