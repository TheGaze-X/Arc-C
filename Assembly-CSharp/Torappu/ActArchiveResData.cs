using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001396 RID: 5014
	[Token(Token = "0x2001396")]
	[Serializable]
	public class ActArchiveResData
	{
		// Token: 0x06007374 RID: 29556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007374")]
		[Address(RVA = "0x21FE920", Offset = "0x21FD520", VA = "0x1821FE920")]
		public ActArchiveResData()
		{
		}

		// Token: 0x04006F4B RID: 28491
		[Token(Token = "0x4006F4B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveResData.PicArchiveResItemData> pics;

		// Token: 0x04006F4C RID: 28492
		[Token(Token = "0x4006F4C")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActArchiveResData.AudioArchiveResItemData> audios;

		// Token: 0x04006F4D RID: 28493
		[Token(Token = "0x4006F4D")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActArchiveResData.AvgArchiveResItemData> avgs;

		// Token: 0x04006F4E RID: 28494
		[Token(Token = "0x4006F4E")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ActArchiveResData.StoryArchiveResItemData> stories;

		// Token: 0x04006F4F RID: 28495
		[Token(Token = "0x4006F4F")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActArchiveResData.NewsArchiveResItemData> news;

		// Token: 0x04006F50 RID: 28496
		[Token(Token = "0x4006F50")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ActArchiveResData.LandmarkArchiveResItemData> landmarks;

		// Token: 0x04006F51 RID: 28497
		[Token(Token = "0x4006F51")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ActArchiveResData.LogArchiveResItemData> logs;

		// Token: 0x04006F52 RID: 28498
		[Token(Token = "0x4006F52")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ActArchiveResData.ChallengeBookArchiveResItemData> challengeBooks;

		// Token: 0x02001397 RID: 5015
		[Token(Token = "0x2001397")]
		public class PicArchiveResItemData
		{
			// Token: 0x06007375 RID: 29557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007375")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PicArchiveResItemData()
			{
			}

			// Token: 0x04006F53 RID: 28499
			[Token(Token = "0x4006F53")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04006F54 RID: 28500
			[Token(Token = "0x4006F54")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04006F55 RID: 28501
			[Token(Token = "0x4006F55")]
			[FieldOffset(Offset = "0x20")]
			public string assetPath;

			// Token: 0x04006F56 RID: 28502
			[Token(Token = "0x4006F56")]
			[FieldOffset(Offset = "0x28")]
			public ActArchivePicType type;

			// Token: 0x04006F57 RID: 28503
			[Token(Token = "0x4006F57")]
			[FieldOffset(Offset = "0x30")]
			public string subType;

			// Token: 0x04006F58 RID: 28504
			[Token(Token = "0x4006F58")]
			[FieldOffset(Offset = "0x38")]
			public string picDescription;

			// Token: 0x04006F59 RID: 28505
			[Token(Token = "0x4006F59")]
			[FieldOffset(Offset = "0x40")]
			public string kvId;
		}

		// Token: 0x02001398 RID: 5016
		[Token(Token = "0x2001398")]
		public class AudioArchiveResItemData
		{
			// Token: 0x06007376 RID: 29558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007376")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AudioArchiveResItemData()
			{
			}

			// Token: 0x04006F5A RID: 28506
			[Token(Token = "0x4006F5A")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04006F5B RID: 28507
			[Token(Token = "0x4006F5B")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04006F5C RID: 28508
			[Token(Token = "0x4006F5C")]
			[FieldOffset(Offset = "0x20")]
			public string name;
		}

		// Token: 0x02001399 RID: 5017
		[Token(Token = "0x2001399")]
		public class AvgArchiveResItemData
		{
			// Token: 0x06007377 RID: 29559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007377")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AvgArchiveResItemData()
			{
			}

			// Token: 0x04006F5D RID: 28509
			[Token(Token = "0x4006F5D")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04006F5E RID: 28510
			[Token(Token = "0x4006F5E")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04006F5F RID: 28511
			[Token(Token = "0x4006F5F")]
			[FieldOffset(Offset = "0x20")]
			public string breifPath;

			// Token: 0x04006F60 RID: 28512
			[Token(Token = "0x4006F60")]
			[FieldOffset(Offset = "0x28")]
			public string contentPath;

			// Token: 0x04006F61 RID: 28513
			[Token(Token = "0x4006F61")]
			[FieldOffset(Offset = "0x30")]
			public string imagePath;

			// Token: 0x04006F62 RID: 28514
			[Token(Token = "0x4006F62")]
			[FieldOffset(Offset = "0x38")]
			public string rawBrief;

			// Token: 0x04006F63 RID: 28515
			[Token(Token = "0x4006F63")]
			[FieldOffset(Offset = "0x40")]
			public string titleIconPath;
		}

		// Token: 0x0200139A RID: 5018
		[Token(Token = "0x200139A")]
		public class StoryArchiveResItemData
		{
			// Token: 0x06007378 RID: 29560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007378")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StoryArchiveResItemData()
			{
			}

			// Token: 0x04006F64 RID: 28516
			[Token(Token = "0x4006F64")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04006F65 RID: 28517
			[Token(Token = "0x4006F65")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04006F66 RID: 28518
			[Token(Token = "0x4006F66")]
			[FieldOffset(Offset = "0x20")]
			public string date;

			// Token: 0x04006F67 RID: 28519
			[Token(Token = "0x4006F67")]
			[FieldOffset(Offset = "0x28")]
			public string pic;

			// Token: 0x04006F68 RID: 28520
			[Token(Token = "0x4006F68")]
			[FieldOffset(Offset = "0x30")]
			public string text;

			// Token: 0x04006F69 RID: 28521
			[Token(Token = "0x4006F69")]
			[FieldOffset(Offset = "0x38")]
			public string titlePic;
		}

		// Token: 0x0200139B RID: 5019
		[Token(Token = "0x200139B")]
		public class NewsArchiveResItemData
		{
			// Token: 0x06007379 RID: 29561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007379")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsArchiveResItemData()
			{
			}

			// Token: 0x04006F6A RID: 28522
			[Token(Token = "0x4006F6A")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04006F6B RID: 28523
			[Token(Token = "0x4006F6B")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04006F6C RID: 28524
			[Token(Token = "0x4006F6C")]
			[FieldOffset(Offset = "0x20")]
			public string newsType;

			// Token: 0x04006F6D RID: 28525
			[Token(Token = "0x4006F6D")]
			[FieldOffset(Offset = "0x28")]
			public ActArchiveResData.NewsFormatData newsFormat;

			// Token: 0x04006F6E RID: 28526
			[Token(Token = "0x4006F6E")]
			[FieldOffset(Offset = "0x50")]
			public string newsText;

			// Token: 0x04006F6F RID: 28527
			[Token(Token = "0x4006F6F")]
			[FieldOffset(Offset = "0x58")]
			public string newsAuthor;

			// Token: 0x04006F70 RID: 28528
			[Token(Token = "0x4006F70")]
			[FieldOffset(Offset = "0x60")]
			public int paramP0;

			// Token: 0x04006F71 RID: 28529
			[Token(Token = "0x4006F71")]
			[FieldOffset(Offset = "0x64")]
			public int paramK;

			// Token: 0x04006F72 RID: 28530
			[Token(Token = "0x4006F72")]
			[FieldOffset(Offset = "0x68")]
			public float paramR;

			// Token: 0x04006F73 RID: 28531
			[Token(Token = "0x4006F73")]
			[FieldOffset(Offset = "0x70")]
			public List<ActArchiveResData.ActivityNewsLine> newsLines;
		}

		// Token: 0x0200139C RID: 5020
		[Token(Token = "0x200139C")]
		public struct NewsFormatData
		{
			// Token: 0x04006F74 RID: 28532
			[Token(Token = "0x4006F74")]
			[FieldOffset(Offset = "0x0")]
			public string typeId;

			// Token: 0x04006F75 RID: 28533
			[Token(Token = "0x4006F75")]
			[FieldOffset(Offset = "0x8")]
			public string typeName;

			// Token: 0x04006F76 RID: 28534
			[Token(Token = "0x4006F76")]
			[FieldOffset(Offset = "0x10")]
			public string typeLogo;

			// Token: 0x04006F77 RID: 28535
			[Token(Token = "0x4006F77")]
			[FieldOffset(Offset = "0x18")]
			public string typeMainLogo;

			// Token: 0x04006F78 RID: 28536
			[Token(Token = "0x4006F78")]
			[FieldOffset(Offset = "0x20")]
			public string typeMainSealing;
		}

		// Token: 0x0200139D RID: 5021
		[Token(Token = "0x200139D")]
		public class ActivityNewsLine
		{
			// Token: 0x0600737A RID: 29562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600737A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityNewsLine()
			{
			}

			// Token: 0x04006F79 RID: 28537
			[Token(Token = "0x4006F79")]
			[FieldOffset(Offset = "0x10")]
			public ActArchiveResData.ArchiveNewsLineType lineType;

			// Token: 0x04006F7A RID: 28538
			[Token(Token = "0x4006F7A")]
			[FieldOffset(Offset = "0x18")]
			public string content;
		}

		// Token: 0x0200139E RID: 5022
		[Token(Token = "0x200139E")]
		public enum ArchiveNewsLineType
		{
			// Token: 0x04006F7C RID: 28540
			[Token(Token = "0x4006F7C")]
			TextContent,
			// Token: 0x04006F7D RID: 28541
			[Token(Token = "0x4006F7D")]
			ImageContent
		}

		// Token: 0x0200139F RID: 5023
		[Token(Token = "0x200139F")]
		public class LandmarkArchiveResItemData
		{
			// Token: 0x0600737B RID: 29563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600737B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LandmarkArchiveResItemData()
			{
			}

			// Token: 0x04006F7E RID: 28542
			[Token(Token = "0x4006F7E")]
			[FieldOffset(Offset = "0x10")]
			public string landmarkId;

			// Token: 0x04006F7F RID: 28543
			[Token(Token = "0x4006F7F")]
			[FieldOffset(Offset = "0x18")]
			public string landmarkName;

			// Token: 0x04006F80 RID: 28544
			[Token(Token = "0x4006F80")]
			[FieldOffset(Offset = "0x20")]
			public string landmarkPic;

			// Token: 0x04006F81 RID: 28545
			[Token(Token = "0x4006F81")]
			[FieldOffset(Offset = "0x28")]
			public string landmarkDesc;

			// Token: 0x04006F82 RID: 28546
			[Token(Token = "0x4006F82")]
			[FieldOffset(Offset = "0x30")]
			public string landmarkEngName;
		}

		// Token: 0x020013A0 RID: 5024
		[Token(Token = "0x20013A0")]
		public class LogArchiveResItemData
		{
			// Token: 0x0600737C RID: 29564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600737C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LogArchiveResItemData()
			{
			}

			// Token: 0x04006F83 RID: 28547
			[Token(Token = "0x4006F83")]
			[FieldOffset(Offset = "0x10")]
			public string logId;

			// Token: 0x04006F84 RID: 28548
			[Token(Token = "0x4006F84")]
			[FieldOffset(Offset = "0x18")]
			public string logDesc;
		}

		// Token: 0x020013A1 RID: 5025
		[Token(Token = "0x20013A1")]
		public class ChallengeBookArchiveResItemData
		{
			// Token: 0x0600737D RID: 29565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600737D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ChallengeBookArchiveResItemData()
			{
			}

			// Token: 0x04006F85 RID: 28549
			[Token(Token = "0x4006F85")]
			[FieldOffset(Offset = "0x10")]
			public string storyId;

			// Token: 0x04006F86 RID: 28550
			[Token(Token = "0x4006F86")]
			[FieldOffset(Offset = "0x18")]
			public string titleName;

			// Token: 0x04006F87 RID: 28551
			[Token(Token = "0x4006F87")]
			[FieldOffset(Offset = "0x20")]
			public string storyName;

			// Token: 0x04006F88 RID: 28552
			[Token(Token = "0x4006F88")]
			[FieldOffset(Offset = "0x28")]
			public string textId;
		}
	}
}
