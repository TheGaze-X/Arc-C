using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200671A RID: 26394
	[Token(Token = "0x200671A")]
	public class HandBookV2FavorMissionModel
	{
		// Token: 0x06025DEC RID: 155116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DEC")]
		[Address(RVA = "0x20D22F0", Offset = "0x20D0EF0", VA = "0x1820D22F0")]
		public void SetData(Dictionary<string, List<HandBookV2MissionListItemModel.CharacterFavorData>> forceId2CharDataListMap, Dictionary<string, HandBookV2ForceFavorViewModel> forceId2FavorModelMap)
		{
		}

		// Token: 0x06025DED RID: 155117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DED")]
		[Address(RVA = "0x20D21B0", Offset = "0x20D0DB0", VA = "0x1820D21B0")]
		public void RefreshRewardAvailState()
		{
		}

		// Token: 0x06025DEE RID: 155118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DEE")]
		[Address(RVA = "0x20D2600", Offset = "0x20D1200", VA = "0x1820D2600")]
		public HandBookV2FavorMissionModel()
		{
		}

		// Token: 0x0403543D RID: 218173
		[Token(Token = "0x403543D")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookV2MissionListItemModel> missionItemModelList;
	}
}
