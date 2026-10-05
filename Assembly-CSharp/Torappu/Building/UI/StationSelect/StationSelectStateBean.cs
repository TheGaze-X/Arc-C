using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C6C RID: 7276
	[Token(Token = "0x2001C6C")]
	public class StationSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B4B8 RID: 46264 RVA: 0x00044988 File Offset: 0x00042B88
		[Token(Token = "0x600B4B8")]
		[Address(RVA = "0x3300150", Offset = "0x32FED50", VA = "0x183300150")]
		public static StationSelectStateBean.Input ParseInputFromPageParam(BuildingStationSelectPage.Param pageParam)
		{
			return default(StationSelectStateBean.Input);
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x000449A0 File Offset: 0x00042BA0
		// (set) Token: 0x0600B4BA RID: 46266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015B2")]
		public bool professionFilterPanelShow
		{
			[Token(Token = "0x600B4B9")]
			[Address(RVA = "0x3301080", Offset = "0x32FFC80", VA = "0x183301080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B4BA")]
			[Address(RVA = "0x33011E0", Offset = "0x32FFDE0", VA = "0x1833011E0")]
			set
			{
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x0600B4BB RID: 46267 RVA: 0x000449B8 File Offset: 0x00042BB8
		// (set) Token: 0x0600B4BC RID: 46268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015B3")]
		public bool stationStatusFilterPanelShow
		{
			[Token(Token = "0x600B4BB")]
			[Address(RVA = "0x3301160", Offset = "0x32FFD60", VA = "0x183301160")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B4BC")]
			[Address(RVA = "0x3301320", Offset = "0x32FFF20", VA = "0x183301320")]
			set
			{
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x0600B4BD RID: 46269 RVA: 0x000449D0 File Offset: 0x00042BD0
		[Token(Token = "0x170015B4")]
		public bool isSingleMode
		{
			[Token(Token = "0x600B4BD")]
			[Address(RVA = "0x3300FC0", Offset = "0x32FFBC0", VA = "0x183300FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x000449E8 File Offset: 0x00042BE8
		[Token(Token = "0x170015B5")]
		public BuildingData.RoomType lastRoomType
		{
			[Token(Token = "0x600B4BE")]
			[Address(RVA = "0x3301020", Offset = "0x32FFC20", VA = "0x183301020")]
			get
			{
				return BuildingData.RoomType.NONE;
			}
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x00044A00 File Offset: 0x00042C00
		[Token(Token = "0x600B4BF")]
		[Address(RVA = "0x32FF520", Offset = "0x32FE120", VA = "0x1832FF520")]
		public BuildingStationSelectState.SelectResultModel GenerateSelectedCharsForRequest()
		{
			return default(BuildingStationSelectState.SelectResultModel);
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C0")]
		[Address(RVA = "0x32FF9A0", Offset = "0x32FE5A0", VA = "0x1832FF9A0")]
		public void LoadData()
		{
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C1")]
		[Address(RVA = "0x33003E0", Offset = "0x32FEFE0", VA = "0x1833003E0")]
		public void ToggleSelectedChar(StationCharViewModel selectedChar)
		{
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C2")]
		[Address(RVA = "0x32FF420", Offset = "0x32FE020", VA = "0x1832FF420")]
		public void ClearSelectedChars()
		{
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C3")]
		[Address(RVA = "0x3300730", Offset = "0x32FF330", VA = "0x183300730")]
		public void ToggleSortType(CharSortType sortType)
		{
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C4")]
		[Address(RVA = "0x3300910", Offset = "0x32FF510", VA = "0x183300910")]
		public void ToggleStationFilterType(BuildingData.CharStationFilterType stationFilterType)
		{
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x0600B4C5 RID: 46277 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B4C6 RID: 46278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015B6")]
		public BuildingStationSelectState.IPlugin statePlugin
		{
			[Token(Token = "0x600B4C5")]
			[Address(RVA = "0x3301100", Offset = "0x32FFD00", VA = "0x183301100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600B4C6")]
			[Address(RVA = "0x33012A0", Offset = "0x32FFEA0", VA = "0x1833012A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4C7")]
		[Address(RVA = "0x33009F0", Offset = "0x32FF5F0", VA = "0x1833009F0")]
		private BuildingStationSelectState.IPlugin _GenerateStatePlugin(StationSelectStateBean.Input input)
		{
			return null;
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4C8")]
		[Address(RVA = "0x3300B90", Offset = "0x32FF790", VA = "0x183300B90")]
		private string _GetRoomCurrentTarget(BuildingModel buildingModel, RoomSlotModel slotModel)
		{
			return null;
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C9")]
		[Address(RVA = "0x32FF2E0", Offset = "0x32FDEE0", VA = "0x1832FF2E0")]
		public void ChangeFilter(CharacterProfessionFilterParam filterParam)
		{
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4CA")]
		[Address(RVA = "0x3300E50", Offset = "0x32FFA50", VA = "0x183300E50")]
		public StationSelectStateBean()
		{
		}

		// Token: 0x0400B0A0 RID: 45216
		[Token(Token = "0x400B0A0")]
		[FieldOffset(Offset = "0x10")]
		public StationSelectStateBean.Input stateInput;

		// Token: 0x0400B0A1 RID: 45217
		[Token(Token = "0x400B0A1")]
		[FieldOffset(Offset = "0x50")]
		public StationCharGroupProperty charGroupProperty;

		// Token: 0x0400B0A2 RID: 45218
		[Token(Token = "0x400B0A2")]
		[FieldOffset(Offset = "0x58")]
		public StationSelectRoomStatusModelProperty roomStatusProperty;

		// Token: 0x0400B0A3 RID: 45219
		[Token(Token = "0x400B0A3")]
		[FieldOffset(Offset = "0x60")]
		private BuildingData.RoomType m_lastRoomType;

		// Token: 0x0400B0A4 RID: 45220
		[Token(Token = "0x400B0A4")]
		[FieldOffset(Offset = "0x68")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0400B0A5 RID: 45221
		[Token(Token = "0x400B0A5")]
		[FieldOffset(Offset = "0x70")]
		private string m_currRoomTarget;

		// Token: 0x0400B0A6 RID: 45222
		[Token(Token = "0x400B0A6")]
		[FieldOffset(Offset = "0x78")]
		private string m_roomSlotId;

		// Token: 0x0400B0A8 RID: 45224
		[Token(Token = "0x400B0A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseInputFromPageParam;

		// Token: 0x0400B0A9 RID: 45225
		[Token(Token = "0x400B0A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_professionFilterPanelShow;

		// Token: 0x0400B0AA RID: 45226
		[Token(Token = "0x400B0AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_professionFilterPanelShow;

		// Token: 0x0400B0AB RID: 45227
		[Token(Token = "0x400B0AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stationStatusFilterPanelShow;

		// Token: 0x0400B0AC RID: 45228
		[Token(Token = "0x400B0AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_stationStatusFilterPanelShow;

		// Token: 0x0400B0AD RID: 45229
		[Token(Token = "0x400B0AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isSingleMode;

		// Token: 0x0400B0AE RID: 45230
		[Token(Token = "0x400B0AE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_lastRoomType;

		// Token: 0x0400B0AF RID: 45231
		[Token(Token = "0x400B0AF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateSelectedCharsForRequest;

		// Token: 0x0400B0B0 RID: 45232
		[Token(Token = "0x400B0B0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400B0B1 RID: 45233
		[Token(Token = "0x400B0B1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ToggleSelectedChar;

		// Token: 0x0400B0B2 RID: 45234
		[Token(Token = "0x400B0B2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearSelectedChars;

		// Token: 0x0400B0B3 RID: 45235
		[Token(Token = "0x400B0B3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ToggleSortType;

		// Token: 0x0400B0B4 RID: 45236
		[Token(Token = "0x400B0B4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ToggleStationFilterType;

		// Token: 0x0400B0B5 RID: 45237
		[Token(Token = "0x400B0B5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_statePlugin;

		// Token: 0x0400B0B6 RID: 45238
		[Token(Token = "0x400B0B6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_statePlugin;

		// Token: 0x0400B0B7 RID: 45239
		[Token(Token = "0x400B0B7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateStatePlugin;

		// Token: 0x0400B0B8 RID: 45240
		[Token(Token = "0x400B0B8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetRoomCurrentTarget;

		// Token: 0x0400B0B9 RID: 45241
		[Token(Token = "0x400B0B9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ChangeFilter;

		// Token: 0x0400B0BA RID: 45242
		[Token(Token = "0x400B0BA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C6D RID: 7277
		[Token(Token = "0x2001C6D")]
		public enum StationSelectStateBeanInputType
		{
			// Token: 0x0400B0BC RID: 45244
			[Token(Token = "0x400B0BC")]
			StationSelect,
			// Token: 0x0400B0BD RID: 45245
			[Token(Token = "0x400B0BD")]
			PreQueueSelect,
			// Token: 0x0400B0BE RID: 45246
			[Token(Token = "0x400B0BE")]
			StationLockCharSelect
		}

		// Token: 0x02001C6E RID: 7278
		[Token(Token = "0x2001C6E")]
		public struct Input
		{
			// Token: 0x170015B7 RID: 5559
			// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B4CC RID: 46284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170015B7")]
			public object context
			{
				[Token(Token = "0x600B4CB")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600B4CC")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600B4CD RID: 46285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4CD")]
			public void BindContext<Context>(Context cxt)
			{
			}

			// Token: 0x0400B0BF RID: 45247
			[Token(Token = "0x400B0BF")]
			[FieldOffset(Offset = "0x0")]
			public int maxSelectCount;

			// Token: 0x0400B0C0 RID: 45248
			[Token(Token = "0x400B0C0")]
			[FieldOffset(Offset = "0x8")]
			public List<int> selectedChars;

			// Token: 0x0400B0C1 RID: 45249
			[Token(Token = "0x400B0C1")]
			[FieldOffset(Offset = "0x10")]
			public string slotId;

			// Token: 0x0400B0C2 RID: 45250
			[Token(Token = "0x400B0C2")]
			[FieldOffset(Offset = "0x18")]
			public BuildingStationSelectState.IPlugin plugin;

			// Token: 0x0400B0C3 RID: 45251
			[Token(Token = "0x400B0C3")]
			[FieldOffset(Offset = "0x20")]
			public StationSelectStateBean.StationSelectStateBeanInputType stateInputType;

			// Token: 0x0400B0C4 RID: 45252
			[Token(Token = "0x400B0C4")]
			[FieldOffset(Offset = "0x28")]
			public string currRoomTarget;

			// Token: 0x0400B0C5 RID: 45253
			[Token(Token = "0x400B0C5")]
			[FieldOffset(Offset = "0x30")]
			public int index;

			// Token: 0x0400B0C6 RID: 45254
			[Token(Token = "0x400B0C6")]
			[FieldOffset(Offset = "0x34")]
			public int queueIndex;
		}
	}
}
