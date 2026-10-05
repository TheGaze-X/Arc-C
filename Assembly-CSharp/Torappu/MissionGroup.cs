using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001109 RID: 4361
	[Token(Token = "0x2001109")]
	[Serializable]
	public class MissionGroup
	{
		// Token: 0x06006ECB RID: 28363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECB")]
		[Address(RVA = "0x2108110", Offset = "0x2106D10", VA = "0x182108110")]
		public MissionGroup()
		{
		}

		// Token: 0x04005D7E RID: 23934
		[Token(Token = "0x4005D7E")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005D7F RID: 23935
		[Token(Token = "0x4005D7F")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04005D80 RID: 23936
		[Token(Token = "0x4005D80")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(StringEnumConverter))]
		public MissionType type;

		// Token: 0x04005D81 RID: 23937
		[Token(Token = "0x4005D81")]
		[FieldOffset(Offset = "0x28")]
		public string preMissionGroup;

		// Token: 0x04005D82 RID: 23938
		[Token(Token = "0x4005D82")]
		[FieldOffset(Offset = "0x30")]
		public int[] period;

		// Token: 0x04005D83 RID: 23939
		[Token(Token = "0x4005D83")]
		[FieldOffset(Offset = "0x38")]
		public List<MissionDisplayRewards> rewards;

		// Token: 0x04005D84 RID: 23940
		[Token(Token = "0x4005D84")]
		[FieldOffset(Offset = "0x40")]
		public string[] missionIds;

		// Token: 0x04005D85 RID: 23941
		[Token(Token = "0x4005D85")]
		[FieldOffset(Offset = "0x48")]
		public long startTs;

		// Token: 0x04005D86 RID: 23942
		[Token(Token = "0x4005D86")]
		[FieldOffset(Offset = "0x50")]
		public long endTs;
	}
}
