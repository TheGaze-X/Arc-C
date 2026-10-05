using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001053 RID: 4179
	[Token(Token = "0x2001053")]
	public class FifthAnnivExploreData
	{
		// Token: 0x06006DBB RID: 28091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBB")]
		[Address(RVA = "0x2104530", Offset = "0x2103130", VA = "0x182104530")]
		public FifthAnnivExploreData()
		{
		}

		// Token: 0x040058CF RID: 22735
		[Token(Token = "0x40058CF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, FifthAnnivExploreGroupData> exploreGroupData;

		// Token: 0x040058D0 RID: 22736
		[Token(Token = "0x40058D0")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, FifthAnnivExploreStageData> exploreStageData;

		// Token: 0x040058D1 RID: 22737
		[Token(Token = "0x40058D1")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, FifthAnnivExploreTargetData> exploreTargetData;

		// Token: 0x040058D2 RID: 22738
		[Token(Token = "0x40058D2")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, FifthAnnivExploreEventData> exploreEventData;

		// Token: 0x040058D3 RID: 22739
		[Token(Token = "0x40058D3")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, FifthAnnivExploreEventChoiceData> exploreChoiceData;

		// Token: 0x040058D4 RID: 22740
		[Token(Token = "0x40058D4")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, FifthAnnivExploreBroadcastData> broadcastData;

		// Token: 0x040058D5 RID: 22741
		[Token(Token = "0x40058D5")]
		[FieldOffset(Offset = "0x40")]
		public FifthAnnivExploreConst exploreConst;

		// Token: 0x040058D6 RID: 22742
		[Token(Token = "0x40058D6")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, FifthAnnivExploreMissionData> missionData;
	}
}
