using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001105 RID: 4357
	[Token(Token = "0x2001105")]
	[Serializable]
	public class MissionData
	{
		// Token: 0x06006EC6 RID: 28358 RVA: 0x000322F8 File Offset: 0x000304F8
		[Token(Token = "0x6006EC6")]
		[Address(RVA = "0x2108050", Offset = "0x2106C50", VA = "0x182108050")]
		public bool ShouldSerializecountEndTs()
		{
			return default(bool);
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC7")]
		[Address(RVA = "0x2108060", Offset = "0x2106C60", VA = "0x182108060")]
		public MissionData()
		{
		}

		// Token: 0x04005D60 RID: 23904
		[Token(Token = "0x4005D60")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005D61 RID: 23905
		[Token(Token = "0x4005D61")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005D62 RID: 23906
		[Token(Token = "0x4005D62")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04005D63 RID: 23907
		[Token(Token = "0x4005D63")]
		[FieldOffset(Offset = "0x28")]
		[JsonConverter(typeof(StringEnumConverter))]
		public MissionType type;

		// Token: 0x04005D64 RID: 23908
		[Token(Token = "0x4005D64")]
		[FieldOffset(Offset = "0x2C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public MissionItemBgType itemBgType;

		// Token: 0x04005D65 RID: 23909
		[Token(Token = "0x4005D65")]
		[FieldOffset(Offset = "0x30")]
		public List<string> preMissionIds;

		// Token: 0x04005D66 RID: 23910
		[Token(Token = "0x4005D66")]
		[FieldOffset(Offset = "0x38")]
		public string template;

		// Token: 0x04005D67 RID: 23911
		[Token(Token = "0x4005D67")]
		[FieldOffset(Offset = "0x40")]
		public string templateType;

		// Token: 0x04005D68 RID: 23912
		[Token(Token = "0x4005D68")]
		[FieldOffset(Offset = "0x48")]
		public string[] param;

		// Token: 0x04005D69 RID: 23913
		[Token(Token = "0x4005D69")]
		[FieldOffset(Offset = "0x50")]
		public string unlockCondition;

		// Token: 0x04005D6A RID: 23914
		[Token(Token = "0x4005D6A")]
		[FieldOffset(Offset = "0x58")]
		public string[] unlockParam;

		// Token: 0x04005D6B RID: 23915
		[Token(Token = "0x4005D6B")]
		[FieldOffset(Offset = "0x60")]
		public string missionGroup;

		// Token: 0x04005D6C RID: 23916
		[Token(Token = "0x4005D6C")]
		[FieldOffset(Offset = "0x68")]
		public string toPage;

		// Token: 0x04005D6D RID: 23917
		[Token(Token = "0x4005D6D")]
		[FieldOffset(Offset = "0x70")]
		public int periodicalPoint;

		// Token: 0x04005D6E RID: 23918
		[Token(Token = "0x4005D6E")]
		[FieldOffset(Offset = "0x78")]
		public List<MissionDisplayRewards> rewards;

		// Token: 0x04005D6F RID: 23919
		[Token(Token = "0x4005D6F")]
		[FieldOffset(Offset = "0x80")]
		public string backImagePath;

		// Token: 0x04005D70 RID: 23920
		[Token(Token = "0x4005D70")]
		[FieldOffset(Offset = "0x88")]
		public string foldId;

		// Token: 0x04005D71 RID: 23921
		[Token(Token = "0x4005D71")]
		[FieldOffset(Offset = "0x90")]
		public bool haveSubMissionToUnlock;

		// Token: 0x04005D72 RID: 23922
		[Token(Token = "0x4005D72")]
		[FieldOffset(Offset = "0x98")]
		public long countEndTs;
	}
}
