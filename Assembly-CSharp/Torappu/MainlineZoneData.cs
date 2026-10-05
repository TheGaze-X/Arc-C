using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013C3 RID: 5059
	[Token(Token = "0x20013C3")]
	[Serializable]
	public class MainlineZoneData
	{
		// Token: 0x060073B3 RID: 29619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MainlineZoneData()
		{
		}

		// Token: 0x0400707F RID: 28799
		[Token(Token = "0x400707F")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04007080 RID: 28800
		[Token(Token = "0x4007080")]
		[FieldOffset(Offset = "0x18")]
		public string chapterId;

		// Token: 0x04007081 RID: 28801
		[Token(Token = "0x4007081")]
		[FieldOffset(Offset = "0x20")]
		public string preposedZoneId;

		// Token: 0x04007082 RID: 28802
		[Token(Token = "0x4007082")]
		[FieldOffset(Offset = "0x28")]
		public int zoneIndex;

		// Token: 0x04007083 RID: 28803
		[Token(Token = "0x4007083")]
		[FieldOffset(Offset = "0x30")]
		public string startStageId;

		// Token: 0x04007084 RID: 28804
		[Token(Token = "0x4007084")]
		[FieldOffset(Offset = "0x38")]
		public string endStageId;

		// Token: 0x04007085 RID: 28805
		[Token(Token = "0x4007085")]
		[FieldOffset(Offset = "0x40")]
		public string gameMusicId;

		// Token: 0x04007086 RID: 28806
		[Token(Token = "0x4007086")]
		[FieldOffset(Offset = "0x48")]
		public string recapId;

		// Token: 0x04007087 RID: 28807
		[Token(Token = "0x4007087")]
		[FieldOffset(Offset = "0x50")]
		public string recapPreStageId;

		// Token: 0x04007088 RID: 28808
		[Token(Token = "0x4007088")]
		[FieldOffset(Offset = "0x58")]
		public string buttonName;

		// Token: 0x04007089 RID: 28809
		[Token(Token = "0x4007089")]
		[FieldOffset(Offset = "0x60")]
		public MainlineZoneData.ZoneReplayBtnType buttonStyle;

		// Token: 0x0400708A RID: 28810
		[Token(Token = "0x400708A")]
		[FieldOffset(Offset = "0x64")]
		public bool spoilAlert;

		// Token: 0x0400708B RID: 28811
		[Token(Token = "0x400708B")]
		[FieldOffset(Offset = "0x68")]
		public long zoneOpenTime;

		// Token: 0x0400708C RID: 28812
		[Token(Token = "0x400708C")]
		[FieldOffset(Offset = "0x70")]
		public List<StageDiffGroup> diffGroup;

		// Token: 0x020013C4 RID: 5060
		[Token(Token = "0x20013C4")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ZoneReplayBtnType
		{
			// Token: 0x0400708E RID: 28814
			[Token(Token = "0x400708E")]
			NONE,
			// Token: 0x0400708F RID: 28815
			[Token(Token = "0x400708F")]
			RECAP,
			// Token: 0x04007090 RID: 28816
			[Token(Token = "0x4007090")]
			REPLAY
		}
	}
}
