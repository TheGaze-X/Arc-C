using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F7B RID: 3963
	[Token(Token = "0x2000F7B")]
	public class CharWordTable
	{
		// Token: 0x06006CAB RID: 27819 RVA: 0x00031980 File Offset: 0x0002FB80
		[Token(Token = "0x6006CAB")]
		[Address(RVA = "0x20FF9B0", Offset = "0x20FE5B0", VA = "0x1820FF9B0")]
		public bool ShouldSerializenewTagList()
		{
			return default(bool);
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00031998 File Offset: 0x0002FB98
		[Token(Token = "0x6006CAC")]
		[Address(RVA = "0x20FF9F0", Offset = "0x20FE5F0", VA = "0x1820FF9F0")]
		public bool ShouldSerializestartTimeWithTypeDict()
		{
			return default(bool);
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x000319B0 File Offset: 0x0002FBB0
		[Token(Token = "0x6006CAD")]
		[Address(RVA = "0x20FF930", Offset = "0x20FE530", VA = "0x1820FF930")]
		public bool ShouldSerializedisplayGroupTypeList()
		{
			return default(bool);
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x000319C8 File Offset: 0x0002FBC8
		[Token(Token = "0x6006CAE")]
		[Address(RVA = "0x20FF970", Offset = "0x20FE570", VA = "0x1820FF970")]
		public bool ShouldSerializedisplayTypeList()
		{
			return default(bool);
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAF")]
		[Address(RVA = "0x20FFA30", Offset = "0x20FE630", VA = "0x1820FFA30")]
		public CharWordTable()
		{
		}

		// Token: 0x04005413 RID: 21523
		[Token(Token = "0x4005413")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CharWordData> charWords;

		// Token: 0x04005414 RID: 21524
		[Token(Token = "0x4005414")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CharExtraWordData> charExtraWords;

		// Token: 0x04005415 RID: 21525
		[Token(Token = "0x4005415")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, VoiceLangData> voiceLangDict;

		// Token: 0x04005416 RID: 21526
		[Token(Token = "0x4005416")]
		[FieldOffset(Offset = "0x28")]
		public VoiceLangType defaultLangType;

		// Token: 0x04005417 RID: 21527
		[Token(Token = "0x4005417")]
		[FieldOffset(Offset = "0x30")]
		public List<string> newTagList;

		// Token: 0x04005418 RID: 21528
		[Token(Token = "0x4005418")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<VoiceLangType, VoiceLangTypeData> voiceLangTypeDict;

		// Token: 0x04005419 RID: 21529
		[Token(Token = "0x4005419")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<VoiceLangGroupType, VoiceLangGroupData> voiceLangGroupTypeDict;

		// Token: 0x0400541A RID: 21530
		[Token(Token = "0x400541A")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, VoiceLangType> charDefaultTypeDict;

		// Token: 0x0400541B RID: 21531
		[Token(Token = "0x400541B")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<VoiceLangType, List<NewVoiceTimeData>> startTimeWithTypeDict;

		// Token: 0x0400541C RID: 21532
		[Token(Token = "0x400541C")]
		[FieldOffset(Offset = "0x58")]
		public List<VoiceLangGroupType> displayGroupTypeList;

		// Token: 0x0400541D RID: 21533
		[Token(Token = "0x400541D")]
		[FieldOffset(Offset = "0x60")]
		public List<VoiceLangType> displayTypeList;

		// Token: 0x0400541E RID: 21534
		[Token(Token = "0x400541E")]
		[FieldOffset(Offset = "0x68")]
		public CharWordShowType playVoiceRange;

		// Token: 0x0400541F RID: 21535
		[Token(Token = "0x400541F")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, FestivalVoiceData> fesVoiceData;

		// Token: 0x04005420 RID: 21536
		[Token(Token = "0x4005420")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, FestivalVoiceWeightData> fesVoiceWeight;

		// Token: 0x04005421 RID: 21537
		[Token(Token = "0x4005421")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, ExtraVoiceConfigData> extraVoiceConfigData;
	}
}
