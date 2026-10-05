using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001884 RID: 6276
	[Token(Token = "0x2001884")]
	public interface IDIYRoomModifierDataProvider : IHotfixable
	{
		// Token: 0x06009ECD RID: 40653
		[Token(Token = "0x6009ECD")]
		void QueryData(Predicate<IDIYRoomModifierData> filter, Action<IDIYRoomModifierData> action);

		// Token: 0x06009ECE RID: 40654
		[Token(Token = "0x6009ECE")]
		void QueryDatas(Predicate<IDIYRoomModifierData> filter, Action<IDIYRoomModifierData> action);

		// Token: 0x06009ECF RID: 40655
		[Token(Token = "0x6009ECF")]
		IDIYRoomModifierData GetData(string furnitureId);

		// Token: 0x06009ED0 RID: 40656
		[Token(Token = "0x6009ED0")]
		IList<IDIYRoomModifierData> GetDatasByType(BuildingData.FurnitureType type);

		// Token: 0x06009ED1 RID: 40657
		[Token(Token = "0x6009ED1")]
		IList<IDIYRoomModifierData> GetDatasBySubType(BuildingData.FurnitureSubType subType);

		// Token: 0x06009ED2 RID: 40658
		[Token(Token = "0x6009ED2")]
		IList<IDIYRoomModifierData> GetDatasByThemeId(string themeId);

		// Token: 0x06009ED3 RID: 40659
		[Token(Token = "0x6009ED3")]
		IList<IDIYRoomModifierData> GetDatasByRoomPart(DIYRoomPart part);
	}
}
