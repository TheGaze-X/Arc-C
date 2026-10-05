using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x2000A72")]
	public class PlayerBuildingFurniturePositionInfo
	{
		// Token: 0x0600672F RID: 26415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingFurniturePositionInfo()
		{
		}

		// Token: 0x040038CD RID: 14541
		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0x18")]
		public PlayerBuildingGridPosition coordinate;
	}
}
