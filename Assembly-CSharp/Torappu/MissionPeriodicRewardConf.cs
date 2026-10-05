using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200110A RID: 4362
	[Token(Token = "0x200110A")]
	[Serializable]
	public abstract class MissionPeriodicRewardConf
	{
		// Token: 0x06006ECC RID: 28364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MissionPeriodicRewardConf()
		{
		}

		// Token: 0x04005D87 RID: 23943
		[Token(Token = "0x4005D87")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005D88 RID: 23944
		[Token(Token = "0x4005D88")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x04005D89 RID: 23945
		[Token(Token = "0x4005D89")]
		[FieldOffset(Offset = "0x20")]
		public int periodicalPointCost;

		// Token: 0x04005D8A RID: 23946
		[Token(Token = "0x4005D8A")]
		[FieldOffset(Offset = "0x24")]
		[JsonConverter(typeof(StringEnumConverter))]
		public MissionType type;

		// Token: 0x04005D8B RID: 23947
		[Token(Token = "0x4005D8B")]
		[FieldOffset(Offset = "0x28")]
		public int sortIndex;

		// Token: 0x04005D8C RID: 23948
		[Token(Token = "0x4005D8C")]
		[FieldOffset(Offset = "0x30")]
		public List<MissionDisplayRewards> rewards;
	}
}
