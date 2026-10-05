using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B83 RID: 2947
	[Token(Token = "0x2000B83")]
	public class PlayerMainlineRecord
	{
		// Token: 0x06006822 RID: 26658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006822")]
		[Address(RVA = "0x1EFB170", Offset = "0x1EF9D70", VA = "0x181EFB170")]
		public PlayerMainlineRecord()
		{
		}

		// Token: 0x04003D16 RID: 15638
		[Token(Token = "0x4003D16")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> record;

		// Token: 0x04003D17 RID: 15639
		[Token(Token = "0x4003D17")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> cache;

		// Token: 0x04003D18 RID: 15640
		[Token(Token = "0x4003D18")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerZoneRecordMissionData> additionalMission;

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("charVoiceRecord")]
		public Dictionary<string, PlayerMissionArchive> missionArchive;

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x30")]
		public PlayerMainlineExplore explore;
	}
}
