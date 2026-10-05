using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DF3 RID: 3571
	[Token(Token = "0x2000DF3")]
	public class ActivityCollectionData
	{
		// Token: 0x06006ABF RID: 27327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ABF")]
		[Address(RVA = "0x1FFAEC0", Offset = "0x1FF9AC0", VA = "0x181FFAEC0")]
		public ActivityCollectionData()
		{
		}

		// Token: 0x04004A05 RID: 18949
		[Token(Token = "0x4004A05")]
		[FieldOffset(Offset = "0x10")]
		public List<ActivityCollectionData.CollectionInfo> collections;

		// Token: 0x04004A06 RID: 18950
		[Token(Token = "0x4004A06")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x04004A07 RID: 18951
		[Token(Token = "0x4004A07")]
		[FieldOffset(Offset = "0x20")]
		public ActivityCollectionData.Consts consts;

		// Token: 0x02000DF4 RID: 3572
		[Token(Token = "0x2000DF4")]
		public class CollectionInfo
		{
			// Token: 0x06006AC0 RID: 27328 RVA: 0x000310F8 File Offset: 0x0002F2F8
			[Token(Token = "0x6006AC0")]
			[Address(RVA = "0x2008660", Offset = "0x2007260", VA = "0x182008660")]
			public bool ShouldSerializeisBonusShow()
			{
				return default(bool);
			}

			// Token: 0x06006AC1 RID: 27329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AC1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CollectionInfo()
			{
			}

			// Token: 0x04004A08 RID: 18952
			[Token(Token = "0x4004A08")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			// Token: 0x04004A09 RID: 18953
			[Token(Token = "0x4004A09")]
			[FieldOffset(Offset = "0x14")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType itemType;

			// Token: 0x04004A0A RID: 18954
			[Token(Token = "0x4004A0A")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x04004A0B RID: 18955
			[Token(Token = "0x4004A0B")]
			[FieldOffset(Offset = "0x20")]
			public int itemCnt;

			// Token: 0x04004A0C RID: 18956
			[Token(Token = "0x4004A0C")]
			[FieldOffset(Offset = "0x28")]
			public string pointId;

			// Token: 0x04004A0D RID: 18957
			[Token(Token = "0x4004A0D")]
			[FieldOffset(Offset = "0x30")]
			public int pointCnt;

			// Token: 0x04004A0E RID: 18958
			[Token(Token = "0x4004A0E")]
			[FieldOffset(Offset = "0x34")]
			public bool isBonus;

			// Token: 0x04004A0F RID: 18959
			[Token(Token = "0x4004A0F")]
			[FieldOffset(Offset = "0x38")]
			public string pngName;

			// Token: 0x04004A10 RID: 18960
			[Token(Token = "0x4004A10")]
			[FieldOffset(Offset = "0x40")]
			public int pngSort;

			// Token: 0x04004A11 RID: 18961
			[Token(Token = "0x4004A11")]
			[FieldOffset(Offset = "0x44")]
			public bool isShow;

			// Token: 0x04004A12 RID: 18962
			[Token(Token = "0x4004A12")]
			[FieldOffset(Offset = "0x45")]
			public bool showInList;

			// Token: 0x04004A13 RID: 18963
			[Token(Token = "0x4004A13")]
			[FieldOffset(Offset = "0x46")]
			public bool showIconBG;

			// Token: 0x04004A14 RID: 18964
			[Token(Token = "0x4004A14")]
			[FieldOffset(Offset = "0x47")]
			public bool isBonusShow;
		}

		// Token: 0x02000DF5 RID: 3573
		[Token(Token = "0x2000DF5")]
		public enum JumpType
		{
			// Token: 0x04004A16 RID: 18966
			[Token(Token = "0x4004A16")]
			NONE,
			// Token: 0x04004A17 RID: 18967
			[Token(Token = "0x4004A17")]
			ROGUE,
			// Token: 0x04004A18 RID: 18968
			[Token(Token = "0x4004A18")]
			CHAR_REPO
		}

		// Token: 0x02000DF6 RID: 3574
		[Token(Token = "0x2000DF6")]
		public class Consts
		{
			// Token: 0x06006AC2 RID: 27330 RVA: 0x00031110 File Offset: 0x0002F310
			[Token(Token = "0x6006AC2")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			public bool ShouldSerializeshowJumpBtn()
			{
				return default(bool);
			}

			// Token: 0x06006AC3 RID: 27331 RVA: 0x00031128 File Offset: 0x0002F328
			[Token(Token = "0x6006AC3")]
			[Address(RVA = "0x20086C0", Offset = "0x20072C0", VA = "0x1820086C0")]
			public bool ShouldSerializejumpBtnType()
			{
				return default(bool);
			}

			// Token: 0x06006AC4 RID: 27332 RVA: 0x00031140 File Offset: 0x0002F340
			[Token(Token = "0x6006AC4")]
			[Address(RVA = "0x20086A0", Offset = "0x20072A0", VA = "0x1820086A0")]
			public bool ShouldSerializejumpBtnParam1()
			{
				return default(bool);
			}

			// Token: 0x06006AC5 RID: 27333 RVA: 0x00031158 File Offset: 0x0002F358
			[Token(Token = "0x6006AC5")]
			[Address(RVA = "0x1FF8AF0", Offset = "0x1FF76F0", VA = "0x181FF8AF0")]
			public bool ShouldSerializejumpBtnParam2()
			{
				return default(bool);
			}

			// Token: 0x06006AC6 RID: 27334 RVA: 0x00031170 File Offset: 0x0002F370
			[Token(Token = "0x6006AC6")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			public bool ShouldSerializedailyTaskDisabled()
			{
				return default(bool);
			}

			// Token: 0x06006AC7 RID: 27335 RVA: 0x00031188 File Offset: 0x0002F388
			[Token(Token = "0x6006AC7")]
			[Address(RVA = "0x2008690", Offset = "0x2007290", VA = "0x182008690")]
			public bool ShouldSerializedailyTaskStartTime()
			{
				return default(bool);
			}

			// Token: 0x06006AC8 RID: 27336 RVA: 0x000311A0 File Offset: 0x0002F3A0
			[Token(Token = "0x6006AC8")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			public bool ShouldSerializeisSimpleMode()
			{
				return default(bool);
			}

			// Token: 0x06006AC9 RID: 27337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AC9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Consts()
			{
			}

			// Token: 0x04004A19 RID: 18969
			[Token(Token = "0x4004A19")]
			[FieldOffset(Offset = "0x10")]
			public bool showJumpBtn;

			// Token: 0x04004A1A RID: 18970
			[Token(Token = "0x4004A1A")]
			[FieldOffset(Offset = "0x14")]
			public ActivityCollectionData.JumpType jumpBtnType;

			// Token: 0x04004A1B RID: 18971
			[Token(Token = "0x4004A1B")]
			[FieldOffset(Offset = "0x18")]
			public string jumpBtnParam1;

			// Token: 0x04004A1C RID: 18972
			[Token(Token = "0x4004A1C")]
			[FieldOffset(Offset = "0x20")]
			public string jumpBtnParam2;

			// Token: 0x04004A1D RID: 18973
			[Token(Token = "0x4004A1D")]
			[FieldOffset(Offset = "0x28")]
			public bool dailyTaskDisabled;

			// Token: 0x04004A1E RID: 18974
			[Token(Token = "0x4004A1E")]
			[FieldOffset(Offset = "0x30")]
			public long dailyTaskStartTime;

			// Token: 0x04004A1F RID: 18975
			[Token(Token = "0x4004A1F")]
			[FieldOffset(Offset = "0x38")]
			public bool isSimpleMode;
		}
	}
}
