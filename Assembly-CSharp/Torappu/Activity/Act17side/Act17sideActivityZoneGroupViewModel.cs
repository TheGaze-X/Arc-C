using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.DeepSeaRP;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079B3 RID: 31155
	[Token(Token = "0x20079B3")]
	public class Act17sideActivityZoneGroupViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x0602BB2E RID: 178990 RVA: 0x000DCE30 File Offset: 0x000DB030
		// (set) Token: 0x0602BB2F RID: 178991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006677")]
		public bool isAllTimeout
		{
			[Token(Token = "0x602BB2E")]
			[Address(RVA = "0x27A1D00", Offset = "0x27A0900", VA = "0x1827A1D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BB2F")]
			[Address(RVA = "0x27A1DC0", Offset = "0x27A09C0", VA = "0x1827A1DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x0602BB30 RID: 178992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BB31 RID: 178993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006678")]
		public string selectedZoneId
		{
			[Token(Token = "0x602BB30")]
			[Address(RVA = "0x27A1D60", Offset = "0x27A0960", VA = "0x1827A1D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BB31")]
			[Address(RVA = "0x27A1E30", Offset = "0x27A0A30", VA = "0x1827A1E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BB32 RID: 178994 RVA: 0x000DCE48 File Offset: 0x000DB048
		[Token(Token = "0x602BB32")]
		[Address(RVA = "0x27A0E50", Offset = "0x279FA50", VA = "0x1827A0E50")]
		public bool CheckIfZoneUnlock(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0602BB33 RID: 178995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB33")]
		[Address(RVA = "0x27A1AC0", Offset = "0x27A06C0", VA = "0x1827A1AC0")]
		public Act17sideActivityZoneGroupViewModel(object param)
		{
		}

		// Token: 0x0602BB34 RID: 178996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB34")]
		[Address(RVA = "0x27A0F80", Offset = "0x279FB80", VA = "0x1827A0F80")]
		public void LoadData(ActivityBasicInfo actBasicInfo, Act17sideData actData)
		{
		}

		// Token: 0x0602BB35 RID: 178997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB35")]
		[Address(RVA = "0x27A1940", Offset = "0x27A0540", VA = "0x1827A1940")]
		public void SetSelectedZone(string zoneId)
		{
		}

		// Token: 0x0403F398 RID: 258968
		[Token(Token = "0x403F398")]
		[FieldOffset(Offset = "0x20")]
		public List<Act17sideActivityZoneGroupViewModel.ZoneViewModel> zoneDescModelList;

		// Token: 0x0403F39B RID: 258971
		[Token(Token = "0x403F39B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAllTimeout;

		// Token: 0x0403F39C RID: 258972
		[Token(Token = "0x403F39C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isAllTimeout;

		// Token: 0x0403F39D RID: 258973
		[Token(Token = "0x403F39D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedZoneId;

		// Token: 0x0403F39E RID: 258974
		[Token(Token = "0x403F39E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectedZoneId;

		// Token: 0x0403F39F RID: 258975
		[Token(Token = "0x403F39F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfZoneUnlock;

		// Token: 0x0403F3A0 RID: 258976
		[Token(Token = "0x403F3A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403F3A1 RID: 258977
		[Token(Token = "0x403F3A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F3A2 RID: 258978
		[Token(Token = "0x403F3A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSelectedZone;

		// Token: 0x020079B4 RID: 31156
		[Token(Token = "0x20079B4")]
		public class Input
		{
			// Token: 0x0602BB36 RID: 178998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB36")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F3A3 RID: 258979
			[Token(Token = "0x403F3A3")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo actBasicInfo;

			// Token: 0x0403F3A4 RID: 258980
			[Token(Token = "0x403F3A4")]
			[FieldOffset(Offset = "0x88")]
			public Act17sideData actData;
		}

		// Token: 0x020079B5 RID: 31157
		[Token(Token = "0x20079B5")]
		public class ZoneViewModel
		{
			// Token: 0x17006679 RID: 26233
			// (get) Token: 0x0602BB37 RID: 178999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006679")]
			public string zoneId
			{
				[Token(Token = "0x602BB37")]
				[Address(RVA = "0x27AB9F0", Offset = "0x27AA5F0", VA = "0x1827AB9F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700667A RID: 26234
			// (get) Token: 0x0602BB38 RID: 179000 RVA: 0x000DCE60 File Offset: 0x000DB060
			[Token(Token = "0x1700667A")]
			public long startTime
			{
				[Token(Token = "0x602BB38")]
				[Address(RVA = "0x27AB9B0", Offset = "0x27AA5B0", VA = "0x1827AB9B0")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700667B RID: 26235
			// (get) Token: 0x0602BB39 RID: 179001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700667B")]
			public string unlockText
			{
				[Token(Token = "0x602BB39")]
				[Address(RVA = "0x27AB9D0", Offset = "0x27AA5D0", VA = "0x1827AB9D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700667C RID: 26236
			// (get) Token: 0x0602BB3A RID: 179002 RVA: 0x000DCE78 File Offset: 0x000DB078
			[Token(Token = "0x1700667C")]
			public bool isLocked
			{
				[Token(Token = "0x602BB3A")]
				[Address(RVA = "0x27AB6A0", Offset = "0x27AA2A0", VA = "0x1827AB6A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700667D RID: 26237
			// (get) Token: 0x0602BB3B RID: 179003 RVA: 0x000DCE90 File Offset: 0x000DB090
			[Token(Token = "0x1700667D")]
			public bool isAccessible
			{
				[Token(Token = "0x602BB3B")]
				[Address(RVA = "0x27AB670", Offset = "0x27AA270", VA = "0x1827AB670")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700667E RID: 26238
			// (get) Token: 0x0602BB3C RID: 179004 RVA: 0x000DCEA8 File Offset: 0x000DB0A8
			[Token(Token = "0x1700667E")]
			public bool isTimeout
			{
				[Token(Token = "0x602BB3C")]
				[Address(RVA = "0x27AB790", Offset = "0x27AA390", VA = "0x1827AB790")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700667F RID: 26239
			// (get) Token: 0x0602BB3D RID: 179005 RVA: 0x000DCEC0 File Offset: 0x000DB0C0
			[Token(Token = "0x1700667F")]
			public bool showTrackPoint
			{
				[Token(Token = "0x602BB3D")]
				[Address(RVA = "0x27AB7C0", Offset = "0x27AA3C0", VA = "0x1827AB7C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17006680 RID: 26240
			// (get) Token: 0x0602BB3E RID: 179006 RVA: 0x000DCED8 File Offset: 0x000DB0D8
			[Token(Token = "0x17006680")]
			public bool isTimeLocked
			{
				[Token(Token = "0x602BB3E")]
				[Address(RVA = "0x27AB700", Offset = "0x27AA300", VA = "0x1827AB700")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17006681 RID: 26241
			// (get) Token: 0x0602BB3F RID: 179007 RVA: 0x000DCEF0 File Offset: 0x000DB0F0
			[Token(Token = "0x17006681")]
			public bool isStageLocked
			{
				[Token(Token = "0x602BB3F")]
				[Address(RVA = "0x27AB6D0", Offset = "0x27AA2D0", VA = "0x1827AB6D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602BB40 RID: 179008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB40")]
			[Address(RVA = "0x27AB5D0", Offset = "0x27AA1D0", VA = "0x1827AB5D0")]
			private ZoneViewModel()
			{
			}

			// Token: 0x0602BB41 RID: 179009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BB41")]
			[Address(RVA = "0x27AADA0", Offset = "0x27A99A0", VA = "0x1827AADA0")]
			public static Act17sideActivityZoneGroupViewModel.ZoneViewModel Create(string actId, Act17sideData.ZoneData zoneData, List<Act17sideData.PlaceData> placeDataList, List<Act17sideData.NodeInfoData> nodeDataList, long activityStartTime, Act17sideData actData)
			{
				return null;
			}

			// Token: 0x0602BB42 RID: 179010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB42")]
			[Address(RVA = "0x27AAB90", Offset = "0x27A9790", VA = "0x1827AAB90")]
			public void CalcNodeStatus(out int placeCompleted, out int placeTotal)
			{
			}

			// Token: 0x0602BB43 RID: 179011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB43")]
			[Address(RVA = "0x27AB3F0", Offset = "0x27A9FF0", VA = "0x1827AB3F0")]
			public void UpdatePlaceData(PlayerDeepSea deepSeaData)
			{
			}

			// Token: 0x0403F3A5 RID: 258981
			[Token(Token = "0x403F3A5")]
			[FieldOffset(Offset = "0x10")]
			public DeepSeaRPZoneMapModel zoneMapModel;

			// Token: 0x0403F3A6 RID: 258982
			[Token(Token = "0x403F3A6")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, DeepSeaRPPlaceModel> zonePlaceModel;

			// Token: 0x0403F3A7 RID: 258983
			[Token(Token = "0x403F3A7")]
			[FieldOffset(Offset = "0x20")]
			public bool isNew;
		}
	}
}
