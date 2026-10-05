using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000FDA RID: 4058
	[Token(Token = "0x2000FDA")]
	public class CrisisV2AchievementData
	{
		// Token: 0x06006D2F RID: 27951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2F")]
		[Address(RVA = "0x2100900", Offset = "0x20FF500", VA = "0x182100900")]
		public CrisisV2AchievementData()
		{
		}

		// Token: 0x0400561A RID: 22042
		[Token(Token = "0x400561A")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "pMapName")]
		public CrisisV2AchievementPermanentData permanentMapData;

		// Token: 0x0400561B RID: 22043
		[Token(Token = "0x400561B")]
		[FieldOffset(Offset = "0x18")]
		public List<CrisisV2AchievementRuneData> runes;

		// Token: 0x0400561C RID: 22044
		[Token(Token = "0x400561C")]
		[FieldOffset(Offset = "0x20")]
		public List<CrisisV2AchievementCommentData> comments;

		// Token: 0x0400561D RID: 22045
		[Token(Token = "0x400561D")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "dimensions")]
		public List<CrisisV2DimensionItemData> dimensionItemList;
	}
}
