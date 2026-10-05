using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001020 RID: 4128
	[Token(Token = "0x2001020")]
	public class ArtGalleryCollectSetMissionData
	{
		// Token: 0x06006D72 RID: 28018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x20FEA20", Offset = "0x20FD620", VA = "0x1820FEA20")]
		public ArtGalleryCollectSetMissionData()
		{
		}

		// Token: 0x040057AC RID: 22444
		[Token(Token = "0x40057AC")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x040057AD RID: 22445
		[Token(Token = "0x40057AD")]
		[FieldOffset(Offset = "0x18")]
		public int requireItemCount;

		// Token: 0x040057AE RID: 22446
		[Token(Token = "0x40057AE")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemBundle> rewardList;
	}
}
