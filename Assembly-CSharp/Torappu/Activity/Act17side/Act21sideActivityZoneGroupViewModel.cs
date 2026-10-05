using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079B7 RID: 31159
	[Token(Token = "0x20079B7")]
	public class Act21sideActivityZoneGroupViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x0602BB45 RID: 179013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB45")]
		[Address(RVA = "0x27A8490", Offset = "0x27A7090", VA = "0x1827A8490")]
		public Act21sideActivityZoneGroupViewModel(object param)
		{
		}

		// Token: 0x0602BB46 RID: 179014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB46")]
		[Address(RVA = "0x27A81B0", Offset = "0x27A6DB0", VA = "0x1827A81B0")]
		public void LoadData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> zoneViewModelList)
		{
		}

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x0602BB47 RID: 179015 RVA: 0x000DCF08 File Offset: 0x000DB108
		// (set) Token: 0x0602BB48 RID: 179016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006682")]
		public bool isAllTimeout
		{
			[Token(Token = "0x602BB47")]
			[Address(RVA = "0x27A87D0", Offset = "0x27A73D0", VA = "0x1827A87D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BB48")]
			[Address(RVA = "0x27A8830", Offset = "0x27A7430", VA = "0x1827A8830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x0602BB49 RID: 179017 RVA: 0x000DCF20 File Offset: 0x000DB120
		[Token(Token = "0x17006683")]
		public bool hasNewSign
		{
			[Token(Token = "0x602BB49")]
			[Address(RVA = "0x27A86D0", Offset = "0x27A72D0", VA = "0x1827A86D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0403F3A9 RID: 258985
		[Token(Token = "0x403F3A9")]
		[FieldOffset(Offset = "0x20")]
		public List<Act21sideActivityZoneGroupViewModel.ZoneViewModel> zoneDescList;

		// Token: 0x0403F3AB RID: 258987
		[Token(Token = "0x403F3AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403F3AC RID: 258988
		[Token(Token = "0x403F3AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F3AD RID: 258989
		[Token(Token = "0x403F3AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAllTimeout;

		// Token: 0x0403F3AE RID: 258990
		[Token(Token = "0x403F3AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isAllTimeout;

		// Token: 0x0403F3AF RID: 258991
		[Token(Token = "0x403F3AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hasNewSign;

		// Token: 0x020079B8 RID: 31160
		[Token(Token = "0x20079B8")]
		public class Input
		{
			// Token: 0x0602BB4A RID: 179018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB4A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F3B0 RID: 258992
			[Token(Token = "0x403F3B0")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo actBasicInfo;

			// Token: 0x0403F3B1 RID: 258993
			[Token(Token = "0x403F3B1")]
			[FieldOffset(Offset = "0x88")]
			public List<ActivityZoneViewModel> activityZoneViewModelList;
		}

		// Token: 0x020079B9 RID: 31161
		[Token(Token = "0x20079B9")]
		public class ZoneViewModel
		{
			// Token: 0x17006684 RID: 26244
			// (get) Token: 0x0602BB4B RID: 179019 RVA: 0x000DCF38 File Offset: 0x000DB138
			[Token(Token = "0x17006684")]
			public bool isTimeout
			{
				[Token(Token = "0x602BB4B")]
				[Address(RVA = "0x27AB730", Offset = "0x27AA330", VA = "0x1827AB730")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17006685 RID: 26245
			// (get) Token: 0x0602BB4C RID: 179020 RVA: 0x000DCF50 File Offset: 0x000DB150
			[Token(Token = "0x17006685")]
			public bool hasNewSign
			{
				[Token(Token = "0x602BB4C")]
				[Address(RVA = "0x27AB640", Offset = "0x27AA240", VA = "0x1827AB640")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602BB4D RID: 179021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BB4D")]
			[Address(RVA = "0x27AB170", Offset = "0x27A9D70", VA = "0x1827AB170")]
			public static Act21sideActivityZoneGroupViewModel.ZoneViewModel Create(long actStartTime, ActivityZoneViewModel zoneData)
			{
				return null;
			}

			// Token: 0x0602BB4E RID: 179022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB4E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneViewModel()
			{
			}

			// Token: 0x0403F3B2 RID: 258994
			[Token(Token = "0x403F3B2")]
			[FieldOffset(Offset = "0x10")]
			private ZoneValidInfo m_zoneValidInfo;

			// Token: 0x0403F3B3 RID: 258995
			[Token(Token = "0x403F3B3")]
			[FieldOffset(Offset = "0x18")]
			private bool m_hasStageJustUnlock;

			// Token: 0x0403F3B4 RID: 258996
			[Token(Token = "0x403F3B4")]
			[FieldOffset(Offset = "0x19")]
			private bool m_needUnlock;
		}
	}
}
