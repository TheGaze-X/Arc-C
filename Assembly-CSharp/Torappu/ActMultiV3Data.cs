using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E3B RID: 3643
	[Token(Token = "0x2000E3B")]
	public class ActMultiV3Data
	{
		// Token: 0x06006B09 RID: 27401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0x1FF9F10", Offset = "0x1FF8B10", VA = "0x181FF9F10")]
		public ActMultiV3Data()
		{
		}

		// Token: 0x04004BC7 RID: 19399
		[Token(Token = "0x4004BC7")]
		[FieldOffset(Offset = "0x10")]
		public List<ActMultiV3SelectStepData> selectStepDataList;

		// Token: 0x04004BC8 RID: 19400
		[Token(Token = "0x4004BC8")]
		[FieldOffset(Offset = "0x18")]
		public List<ActMultiV3SquadInfoData> squadInfoList;

		// Token: 0x04004BC9 RID: 19401
		[Token(Token = "0x4004BC9")]
		[FieldOffset(Offset = "0x20")]
		public List<ActMultiV3IdentityData> identityDataList;

		// Token: 0x04004BCA RID: 19402
		[Token(Token = "0x4004BCA")]
		[FieldOffset(Offset = "0x28")]
		public List<ActMultiV3SquadEffectData> squadEffectList;

		// Token: 0x04004BCB RID: 19403
		[Token(Token = "0x4004BCB")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActMultiV3TargetMissionData> targetMissionDataDict;

		// Token: 0x04004BCC RID: 19404
		[Token(Token = "0x4004BCC")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ActMultiV3MapTypeData> mapTypeDataDict;

		// Token: 0x04004BCD RID: 19405
		[Token(Token = "0x4004BCD")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ActMultiV3MapData> mapDataDict;

		// Token: 0x04004BCE RID: 19406
		[Token(Token = "0x4004BCE")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ActMultiV3MapModeData> mapModeDataDict;

		// Token: 0x04004BCF RID: 19407
		[Token(Token = "0x4004BCF")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, ActMultiV3MapDiffData> mapDiffDataDict;

		// Token: 0x04004BD0 RID: 19408
		[Token(Token = "0x4004BD0")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, string> missionTitleDict;

		// Token: 0x04004BD1 RID: 19409
		[Token(Token = "0x4004BD1")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, ActMultiV3TitleData> titleDataDict;

		// Token: 0x04004BD2 RID: 19410
		[Token(Token = "0x4004BD2")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, ActMultiV3PhotoTypeData> photoTypeDataDict;

		// Token: 0x04004BD3 RID: 19411
		[Token(Token = "0x4004BD3")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, ActMultiV3WeeklyPhotoRewardData> photoWeeklyRewardDataDict;

		// Token: 0x04004BD4 RID: 19412
		[Token(Token = "0x4004BD4")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, ActMultiV3MatchPosData> matchPosDataDict;

		// Token: 0x04004BD5 RID: 19413
		[Token(Token = "0x4004BD5")]
		[FieldOffset(Offset = "0x80")]
		public List<string> enabledEmoticonThemeIdList;

		// Token: 0x04004BD6 RID: 19414
		[Token(Token = "0x4004BD6")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, ActMultiV3DiffStarRewardData> diffStarRewardDict;

		// Token: 0x04004BD7 RID: 19415
		[Token(Token = "0x4004BD7")]
		[FieldOffset(Offset = "0x90")]
		public List<ActMultiV3MilestoneData> milestoneList;

		// Token: 0x04004BD8 RID: 19416
		[Token(Token = "0x4004BD8")]
		[FieldOffset(Offset = "0x98")]
		public List<ActMultiV3TipsData> tipsDataList;

		// Token: 0x04004BD9 RID: 19417
		[Token(Token = "0x4004BD9")]
		[FieldOffset(Offset = "0xA0")]
		public List<CommonReportPlayerData> reportDataList;

		// Token: 0x04004BDA RID: 19418
		[Token(Token = "0x4004BDA")]
		[FieldOffset(Offset = "0xA8")]
		public List<ActMultiV3TempCharData> tempCharDataList;

		// Token: 0x04004BDB RID: 19419
		[Token(Token = "0x4004BDB")]
		[FieldOffset(Offset = "0xB0")]
		public ActMultiV3ConstToastData constToastData;

		// Token: 0x04004BDC RID: 19420
		[Token(Token = "0x4004BDC")]
		[FieldOffset(Offset = "0xB8")]
		public ActMultiV3ConstData constData;

		// Token: 0x04004BDD RID: 19421
		[Token(Token = "0x4004BDD")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, ActMultiV3SailBoatLevelPoolData> sailBoatLevelPoolDict;

		// Token: 0x04004BDE RID: 19422
		[Token(Token = "0x4004BDE")]
		[FieldOffset(Offset = "0xC8")]
		public Dictionary<string, List<ActMultiV3SailBoatBlockPoolData>> sailBoatBlockPoolDict;

		// Token: 0x04004BDF RID: 19423
		[Token(Token = "0x4004BDF")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<string, ActMultiV3SailBoatBlockInfoData> sailBoatBlockInfoList;
	}
}
