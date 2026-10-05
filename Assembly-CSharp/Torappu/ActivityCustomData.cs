using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200113B RID: 4411
	[Token(Token = "0x200113B")]
	public class ActivityCustomData
	{
		// Token: 0x06006F11 RID: 28433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F11")]
		[Address(RVA = "0x20FE410", Offset = "0x20FD010", VA = "0x1820FE410")]
		public ActivityCustomData()
		{
		}

		// Token: 0x04005E88 RID: 24200
		[Token(Token = "0x4005E88")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("TYPE_ACT17SIDE")]
		public Dictionary<string, Act17sideData> typeAct17sideData;

		// Token: 0x04005E89 RID: 24201
		[Token(Token = "0x4005E89")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("TYPE_ACT25SIDE")]
		public Dictionary<string, ActivityCustomData.Act25sideCustomData> typeAct25sideData;

		// Token: 0x04005E8A RID: 24202
		[Token(Token = "0x4005E8A")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("TYPE_ACT20SIDE")]
		public Dictionary<string, Act20SideData> typeAct20sideData;

		// Token: 0x04005E8B RID: 24203
		[Token(Token = "0x4005E8B")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("TYPE_ACT21SIDE")]
		public Dictionary<string, Act21SideData> typeAct21sideData;

		// Token: 0x0200113C RID: 4412
		[Token(Token = "0x200113C")]
		public class Act25sideCustomData
		{
			// Token: 0x06006F12 RID: 28434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F12")]
			[Address(RVA = "0x20FE350", Offset = "0x20FCF50", VA = "0x1820FE350")]
			public Act25sideCustomData()
			{
			}

			// Token: 0x04005E8C RID: 24204
			[Token(Token = "0x4005E8C")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, Act25SideData.BattlePerformanceData> battlePerformanceData;
		}
	}
}
