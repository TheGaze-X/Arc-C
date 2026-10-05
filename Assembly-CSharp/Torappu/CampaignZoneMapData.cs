using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F3A RID: 3898
	[Token(Token = "0x2000F3A")]
	[Serializable]
	public class CampaignZoneMapData
	{
		// Token: 0x06006C40 RID: 27712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C40")]
		[Address(RVA = "0x2008030", Offset = "0x2006C30", VA = "0x182008030")]
		public CampaignZoneMapData()
		{
		}

		// Token: 0x040052F2 RID: 21234
		[Token(Token = "0x40052F2")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Dictionary<string, CampaignStageMapData>> mapDict;
	}
}
