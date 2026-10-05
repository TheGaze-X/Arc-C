using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C6F RID: 7279
	[Token(Token = "0x2001C6F")]
	public class StationCharViewModel
	{
		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x0600B4CE RID: 46286 RVA: 0x00044A18 File Offset: 0x00042C18
		// (set) Token: 0x0600B4CF RID: 46287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015B8")]
		public bool hasActiveBuff
		{
			[Token(Token = "0x600B4CE")]
			[Address(RVA = "0x51CBE0", Offset = "0x51B7E0", VA = "0x18051CBE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B4CF")]
			[Address(RVA = "0x32FC4E0", Offset = "0x32FB0E0", VA = "0x1832FC4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600B4D0 RID: 46288 RVA: 0x00044A30 File Offset: 0x00042C30
		// (set) Token: 0x0600B4D1 RID: 46289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015B9")]
		public int buffSortId
		{
			[Token(Token = "0x600B4D0")]
			[Address(RVA = "0x32FC470", Offset = "0x32FB070", VA = "0x1832FC470")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B4D1")]
			[Address(RVA = "0x32FC4C0", Offset = "0x32FB0C0", VA = "0x1832FC4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600B4D2 RID: 46290 RVA: 0x00044A48 File Offset: 0x00042C48
		// (set) Token: 0x0600B4D3 RID: 46291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015BA")]
		public int buffSortIdForEfficiencySort
		{
			[Token(Token = "0x600B4D2")]
			[Address(RVA = "0x32FC460", Offset = "0x32FB060", VA = "0x1832FC460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B4D3")]
			[Address(RVA = "0x32FC4B0", Offset = "0x32FB0B0", VA = "0x1832FC4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x0600B4D4 RID: 46292 RVA: 0x00044A60 File Offset: 0x00042C60
		// (set) Token: 0x0600B4D5 RID: 46293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015BB")]
		public int topBuffGroupSortId
		{
			[Token(Token = "0x600B4D4")]
			[Address(RVA = "0x32FC4A0", Offset = "0x32FB0A0", VA = "0x1832FC4A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B4D5")]
			[Address(RVA = "0x32FC500", Offset = "0x32FB100", VA = "0x1832FC500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x0600B4D6 RID: 46294 RVA: 0x00044A78 File Offset: 0x00042C78
		// (set) Token: 0x0600B4D7 RID: 46295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015BC")]
		public bool hasActiveBuffMatchTarget
		{
			[Token(Token = "0x600B4D6")]
			[Address(RVA = "0x32FC480", Offset = "0x32FB080", VA = "0x1832FC480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B4D7")]
			[Address(RVA = "0x32FC4D0", Offset = "0x32FB0D0", VA = "0x1832FC4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x0600B4D8 RID: 46296 RVA: 0x00044A90 File Offset: 0x00042C90
		// (set) Token: 0x0600B4D9 RID: 46297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015BD")]
		public int highestBuffEfficiency
		{
			[Token(Token = "0x600B4D8")]
			[Address(RVA = "0x32FC490", Offset = "0x32FB090", VA = "0x1832FC490")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B4D9")]
			[Address(RVA = "0x32FC4F0", Offset = "0x32FB0F0", VA = "0x1832FC4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4DA")]
		[Address(RVA = "0x32FB990", Offset = "0x32FA590", VA = "0x1832FB990")]
		public void LoadData(BuildingCharModel charModel, BuildingData.RoomType roomId, [Optional] string roomTarget)
		{
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4DB")]
		[Address(RVA = "0x32FBF50", Offset = "0x32FAB50", VA = "0x1832FBF50")]
		public void UpdateForSort()
		{
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x00044AA8 File Offset: 0x00042CA8
		[Token(Token = "0x600B4DC")]
		[Address(RVA = "0x32FB8D0", Offset = "0x32FA4D0", VA = "0x1832FB8D0")]
		public bool FilterWithBuff(BuildingData.BuffCategory category)
		{
			return default(bool);
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4DD")]
		[Address(RVA = "0x32FC040", Offset = "0x32FAC40", VA = "0x1832FC040")]
		private void _PickBuffEfficiencyAndSortId()
		{
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4DE")]
		[Address(RVA = "0x32FC340", Offset = "0x32FAF40", VA = "0x1832FC340")]
		public StationCharViewModel()
		{
		}

		// Token: 0x0400B0C8 RID: 45256
		[Token(Token = "0x400B0C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BuildingCharModel buildingChar;

		// Token: 0x0400B0C9 RID: 45257
		[Token(Token = "0x400B0C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public CharacterCardViewModel commonChar;

		// Token: 0x0400B0CA RID: 45258
		[Token(Token = "0x400B0CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BuildingData.RoomType roomType;

		// Token: 0x0400B0CB RID: 45259
		[Token(Token = "0x400B0CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BuildingData.RoomCategory roomCategory;

		// Token: 0x0400B0CC RID: 45260
		[Token(Token = "0x400B0CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public long apForSort;

		// Token: 0x0400B0CD RID: 45261
		[Token(Token = "0x400B0CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public StationedCharState stateForSort;

		// Token: 0x0400B0CE RID: 45262
		[Token(Token = "0x400B0CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isShowPreQueueTag;

		// Token: 0x0400B0CF RID: 45263
		[Token(Token = "0x400B0CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<StationCharViewModel.BuffStruct> unlockedBuffs;

		// Token: 0x02001C70 RID: 7280
		[Token(Token = "0x2001C70")]
		public class BuffStruct
		{
			// Token: 0x0600B4DF RID: 46303 RVA: 0x00044AC0 File Offset: 0x00042CC0
			[Token(Token = "0x600B4DF")]
			[Address(RVA = "0x32EC380", Offset = "0x32EAF80", VA = "0x1832EC380")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600B4E0 RID: 46304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B4E0")]
			[Address(RVA = "0x32EC170", Offset = "0x32EAD70", VA = "0x1832EC170")]
			public static StationCharViewModel.BuffStruct CreateInst(BuildingData.BuildingBuff buffData, BuildingData.RoomType targetRoom, int buffIndex, string roomTarget)
			{
				return null;
			}

			// Token: 0x0600B4E1 RID: 46305 RVA: 0x00044AD8 File Offset: 0x00042CD8
			[Token(Token = "0x600B4E1")]
			[Address(RVA = "0x32EC390", Offset = "0x32EAF90", VA = "0x1832EC390")]
			private static bool _CheckBuffMatchesTarget(BuildingData.BuildingBuff buff, string target)
			{
				return default(bool);
			}

			// Token: 0x0600B4E2 RID: 46306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuffStruct()
			{
			}

			// Token: 0x0400B0D6 RID: 45270
			[Token(Token = "0x400B0D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly StationCharViewModel.BuffStruct EMPTY;

			// Token: 0x0400B0D7 RID: 45271
			[Token(Token = "0x400B0D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400B0D8 RID: 45272
			[Token(Token = "0x400B0D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0400B0D9 RID: 45273
			[Token(Token = "0x400B0D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string iconId;

			// Token: 0x0400B0DA RID: 45274
			[Token(Token = "0x400B0DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string skillIcon;

			// Token: 0x0400B0DB RID: 45275
			[Token(Token = "0x400B0DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int sortId;

			// Token: 0x0400B0DC RID: 45276
			[Token(Token = "0x400B0DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int buffIndex;

			// Token: 0x0400B0DD RID: 45277
			[Token(Token = "0x400B0DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400B0DE RID: 45278
			[Token(Token = "0x400B0DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public BuildingData.BuffCategory category;

			// Token: 0x0400B0DF RID: 45279
			[Token(Token = "0x400B0DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Color color;

			// Token: 0x0400B0E0 RID: 45280
			[Token(Token = "0x400B0E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Color textColor;

			// Token: 0x0400B0E1 RID: 45281
			[Token(Token = "0x400B0E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public bool isActive;

			// Token: 0x0400B0E2 RID: 45282
			[Token(Token = "0x400B0E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
			public bool matchesTarget;

			// Token: 0x0400B0E3 RID: 45283
			[Token(Token = "0x400B0E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int efficiency;

			// Token: 0x0400B0E4 RID: 45284
			[Token(Token = "0x400B0E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int targetGroupSortId;
		}
	}
}
