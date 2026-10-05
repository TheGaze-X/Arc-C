using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FEA RID: 24554
	[Token(Token = "0x2005FEA")]
	public class CGGalleryViewModel : IHotfixable
	{
		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x060237C0 RID: 145344 RVA: 0x000C1020 File Offset: 0x000BF220
		// (set) Token: 0x060237C1 RID: 145345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053BB")]
		public bool isStorylineMainline
		{
			[Token(Token = "0x60237C0")]
			[Address(RVA = "0x1E1D630", Offset = "0x1E1C230", VA = "0x181E1D630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60237C1")]
			[Address(RVA = "0x1E1D950", Offset = "0x1E1C550", VA = "0x181E1D950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x060237C2 RID: 145346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060237C3 RID: 145347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053BC")]
		public string storylineName
		{
			[Token(Token = "0x60237C2")]
			[Address(RVA = "0x1E1D810", Offset = "0x1E1C410", VA = "0x181E1D810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60237C3")]
			[Address(RVA = "0x1E1DB30", Offset = "0x1E1C730", VA = "0x181E1DB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x060237C4 RID: 145348 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060237C5 RID: 145349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053BD")]
		public string storylineLogoId
		{
			[Token(Token = "0x60237C4")]
			[Address(RVA = "0x1E1D7B0", Offset = "0x1E1C3B0", VA = "0x181E1D7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60237C5")]
			[Address(RVA = "0x1E1DAB0", Offset = "0x1E1C6B0", VA = "0x181E1DAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x060237C6 RID: 145350 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060237C7 RID: 145351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053BE")]
		public string storylineAbbrId
		{
			[Token(Token = "0x60237C6")]
			[Address(RVA = "0x1E1D690", Offset = "0x1E1C290", VA = "0x181E1D690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60237C7")]
			[Address(RVA = "0x1E1D9C0", Offset = "0x1E1C5C0", VA = "0x181E1D9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x060237C8 RID: 145352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053BF")]
		public IReadOnlyList<CGGalleryDisplayGroupViewModel> storylineGroups
		{
			[Token(Token = "0x60237C8")]
			[Address(RVA = "0x1E1D750", Offset = "0x1E1C350", VA = "0x181E1D750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x060237C9 RID: 145353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053C0")]
		public IReadOnlyList<CGGalleryDisplayGroupViewModel> favouriteGroups
		{
			[Token(Token = "0x60237C9")]
			[Address(RVA = "0x1E1D510", Offset = "0x1E1C110", VA = "0x181E1D510")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x060237CA RID: 145354 RVA: 0x000C1038 File Offset: 0x000BF238
		// (set) Token: 0x060237CB RID: 145355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053C1")]
		public int storylineCgCount
		{
			[Token(Token = "0x60237CA")]
			[Address(RVA = "0x1E1D6F0", Offset = "0x1E1C2F0", VA = "0x181E1D6F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60237CB")]
			[Address(RVA = "0x1E1DA40", Offset = "0x1E1C640", VA = "0x181E1DA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x060237CC RID: 145356 RVA: 0x000C1050 File Offset: 0x000BF250
		// (set) Token: 0x060237CD RID: 145357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053C2")]
		public int favouriteCgCount
		{
			[Token(Token = "0x60237CC")]
			[Address(RVA = "0x1E1D4B0", Offset = "0x1E1C0B0", VA = "0x181E1D4B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60237CD")]
			[Address(RVA = "0x1E1D870", Offset = "0x1E1C470", VA = "0x181E1D870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x060237CE RID: 145358 RVA: 0x000C1068 File Offset: 0x000BF268
		// (set) Token: 0x060237CF RID: 145359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053C3")]
		public CGGalleryFilterMode filterMode
		{
			[Token(Token = "0x60237CE")]
			[Address(RVA = "0x1E1D570", Offset = "0x1E1C170", VA = "0x181E1D570")]
			[CompilerGenerated]
			get
			{
				return CGGalleryFilterMode.NONE;
			}
			[Token(Token = "0x60237CF")]
			[Address(RVA = "0x1E1D8E0", Offset = "0x1E1C4E0", VA = "0x181E1D8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x060237D0 RID: 145360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053C4")]
		public CGGalleryViewModel.ICollectionStatus collectionStatus
		{
			[Token(Token = "0x60237D0")]
			[Address(RVA = "0x1E1D450", Offset = "0x1E1C050", VA = "0x181E1D450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x060237D1 RID: 145361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053C5")]
		public CGGalleryViewModel.IInspectorStatus inspectorStatus
		{
			[Token(Token = "0x60237D1")]
			[Address(RVA = "0x1E1D5D0", Offset = "0x1E1C1D0", VA = "0x181E1D5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060237D2 RID: 145362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237D2")]
		[Address(RVA = "0x1E1AFC0", Offset = "0x1E19BC0", VA = "0x181E1AFC0")]
		public void LoadData(string storylineId)
		{
		}

		// Token: 0x060237D3 RID: 145363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237D3")]
		[Address(RVA = "0x1E1B880", Offset = "0x1E1A480", VA = "0x181E1B880")]
		public void RefreshData(ICollection<string> favouriteCgIds)
		{
		}

		// Token: 0x060237D4 RID: 145364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237D4")]
		[Address(RVA = "0x1E1A820", Offset = "0x1E19420", VA = "0x181E1A820")]
		public void ApplyFavouriteCollection()
		{
		}

		// Token: 0x060237D5 RID: 145365 RVA: 0x000C1080 File Offset: 0x000BF280
		[Token(Token = "0x60237D5")]
		[Address(RVA = "0x1E1C1B0", Offset = "0x1E1ADB0", VA = "0x181E1C1B0")]
		public bool SwitchFilterMode(CGGalleryFilterMode filterMode)
		{
			return default(bool);
		}

		// Token: 0x060237D6 RID: 145366 RVA: 0x000C1098 File Offset: 0x000BF298
		[Token(Token = "0x60237D6")]
		[Address(RVA = "0x1E1AD70", Offset = "0x1E19970", VA = "0x181E1AD70")]
		public bool InspectGroup(string storySetId)
		{
			return default(bool);
		}

		// Token: 0x060237D7 RID: 145367 RVA: 0x000C10B0 File Offset: 0x000BF2B0
		[Token(Token = "0x60237D7")]
		[Address(RVA = "0x1E1AB90", Offset = "0x1E19790", VA = "0x181E1AB90")]
		public bool InspectDisplay(string displayId)
		{
			return default(bool);
		}

		// Token: 0x060237D8 RID: 145368 RVA: 0x000C10C8 File Offset: 0x000BF2C8
		[Token(Token = "0x60237D8")]
		[Address(RVA = "0x1E1C280", Offset = "0x1E1AE80", VA = "0x181E1C280")]
		public bool SwitchInspect(bool forward)
		{
			return default(bool);
		}

		// Token: 0x060237D9 RID: 145369 RVA: 0x000C10E0 File Offset: 0x000BF2E0
		[Token(Token = "0x60237D9")]
		[Address(RVA = "0x1E1C960", Offset = "0x1E1B560", VA = "0x181E1C960")]
		private bool _CheckGroupPresented(StorylineLocationData location, StorylineStorySetData storySet)
		{
			return default(bool);
		}

		// Token: 0x060237DA RID: 145370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237DA")]
		[Address(RVA = "0x1E1CD70", Offset = "0x1E1B970", VA = "0x181E1CD70")]
		private CGGalleryDisplayGroupViewModel _LoadGroup(StorylineData storyline, StorylineLocationData location, StorylineStorySetData storySet, CGGalleryGroupData group)
		{
			return null;
		}

		// Token: 0x060237DB RID: 145371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60237DB")]
		[Address(RVA = "0x1E1CA50", Offset = "0x1E1B650", VA = "0x181E1CA50")]
		private List<CGGalleryDisplayViewModel> _LoadDisplays(CGGalleryDisplayGroupViewModel parent, IEnumerable<string> displayIds, string relatedActId)
		{
			return null;
		}

		// Token: 0x060237DC RID: 145372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237DC")]
		[Address(RVA = "0x1E1CFE0", Offset = "0x1E1BBE0", VA = "0x181E1CFE0")]
		private void _ResetCollectionStatus()
		{
		}

		// Token: 0x060237DD RID: 145373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237DD")]
		[Address(RVA = "0x1E1D040", Offset = "0x1E1BC40", VA = "0x181E1D040")]
		private void _ResetInspectorStatus()
		{
		}

		// Token: 0x060237DE RID: 145374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237DE")]
		[Address(RVA = "0x1E1C120", Offset = "0x1E1AD20", VA = "0x181E1C120")]
		public void SetInspectorOpenView(bool isOpenView)
		{
		}

		// Token: 0x060237DF RID: 145375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237DF")]
		[Address(RVA = "0x1E1D140", Offset = "0x1E1BD40", VA = "0x181E1D140")]
		public CGGalleryViewModel()
		{
		}

		// Token: 0x04031169 RID: 201065
		[Token(Token = "0x4031169")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, CGGalleryDisplayViewModel> m_displayMap;

		// Token: 0x0403116A RID: 201066
		[Token(Token = "0x403116A")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, CGGalleryDisplayGroupViewModel> m_groupMap;

		// Token: 0x0403116B RID: 201067
		[Token(Token = "0x403116B")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<CGGalleryDisplayGroupViewModel> m_storylineGroups;

		// Token: 0x0403116C RID: 201068
		[Token(Token = "0x403116C")]
		[FieldOffset(Offset = "0x28")]
		private readonly HashSet<string> m_storylineSet;

		// Token: 0x0403116D RID: 201069
		[Token(Token = "0x403116D")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<CGGalleryDisplayGroupViewModel> m_favouriteGroups;

		// Token: 0x0403116E RID: 201070
		[Token(Token = "0x403116E")]
		[FieldOffset(Offset = "0x38")]
		private readonly HashSet<string> m_favouriteSet;

		// Token: 0x0403116F RID: 201071
		[Token(Token = "0x403116F")]
		[FieldOffset(Offset = "0x40")]
		private readonly CGGalleryViewModel.CollectionStatusModel m_collectionStatus;

		// Token: 0x04031170 RID: 201072
		[Token(Token = "0x4031170")]
		[FieldOffset(Offset = "0x48")]
		private readonly CGGalleryViewModel.InspectorStatusModel m_inspectorStatus;

		// Token: 0x04031178 RID: 201080
		[Token(Token = "0x4031178")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStorylineMainline;

		// Token: 0x04031179 RID: 201081
		[Token(Token = "0x4031179")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isStorylineMainline;

		// Token: 0x0403117A RID: 201082
		[Token(Token = "0x403117A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_storylineName;

		// Token: 0x0403117B RID: 201083
		[Token(Token = "0x403117B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_storylineName;

		// Token: 0x0403117C RID: 201084
		[Token(Token = "0x403117C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_storylineLogoId;

		// Token: 0x0403117D RID: 201085
		[Token(Token = "0x403117D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_storylineLogoId;

		// Token: 0x0403117E RID: 201086
		[Token(Token = "0x403117E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_storylineAbbrId;

		// Token: 0x0403117F RID: 201087
		[Token(Token = "0x403117F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_storylineAbbrId;

		// Token: 0x04031180 RID: 201088
		[Token(Token = "0x4031180")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_storylineGroups;

		// Token: 0x04031181 RID: 201089
		[Token(Token = "0x4031181")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_favouriteGroups;

		// Token: 0x04031182 RID: 201090
		[Token(Token = "0x4031182")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_storylineCgCount;

		// Token: 0x04031183 RID: 201091
		[Token(Token = "0x4031183")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_storylineCgCount;

		// Token: 0x04031184 RID: 201092
		[Token(Token = "0x4031184")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_favouriteCgCount;

		// Token: 0x04031185 RID: 201093
		[Token(Token = "0x4031185")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_favouriteCgCount;

		// Token: 0x04031186 RID: 201094
		[Token(Token = "0x4031186")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_filterMode;

		// Token: 0x04031187 RID: 201095
		[Token(Token = "0x4031187")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_filterMode;

		// Token: 0x04031188 RID: 201096
		[Token(Token = "0x4031188")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_collectionStatus;

		// Token: 0x04031189 RID: 201097
		[Token(Token = "0x4031189")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_inspectorStatus;

		// Token: 0x0403118A RID: 201098
		[Token(Token = "0x403118A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403118B RID: 201099
		[Token(Token = "0x403118B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403118C RID: 201100
		[Token(Token = "0x403118C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ApplyFavouriteCollection;

		// Token: 0x0403118D RID: 201101
		[Token(Token = "0x403118D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SwitchFilterMode;

		// Token: 0x0403118E RID: 201102
		[Token(Token = "0x403118E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_InspectGroup;

		// Token: 0x0403118F RID: 201103
		[Token(Token = "0x403118F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_InspectDisplay;

		// Token: 0x04031190 RID: 201104
		[Token(Token = "0x4031190")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SwitchInspect;

		// Token: 0x04031191 RID: 201105
		[Token(Token = "0x4031191")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CheckGroupPresented;

		// Token: 0x04031192 RID: 201106
		[Token(Token = "0x4031192")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__LoadGroup;

		// Token: 0x04031193 RID: 201107
		[Token(Token = "0x4031193")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__LoadDisplays;

		// Token: 0x04031194 RID: 201108
		[Token(Token = "0x4031194")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ResetCollectionStatus;

		// Token: 0x04031195 RID: 201109
		[Token(Token = "0x4031195")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ResetInspectorStatus;

		// Token: 0x04031196 RID: 201110
		[Token(Token = "0x4031196")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SetInspectorOpenView;

		// Token: 0x04031197 RID: 201111
		[Token(Token = "0x4031197")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FEB RID: 24555
		[Token(Token = "0x2005FEB")]
		public interface ICollectionStatus : IHotfixable
		{
		}

		// Token: 0x02005FEC RID: 24556
		[Token(Token = "0x2005FEC")]
		private class CollectionStatusModel : CGGalleryViewModel.ICollectionStatus, IHotfixable
		{
			// Token: 0x060237E0 RID: 145376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60237E0")]
			[Address(RVA = "0x1E24610", Offset = "0x1E23210", VA = "0x181E24610")]
			public CollectionStatusModel()
			{
			}

			// Token: 0x04031198 RID: 201112
			[Token(Token = "0x4031198")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005FED RID: 24557
		[Token(Token = "0x2005FED")]
		public interface IInspectorStatus : IHotfixable
		{
			// Token: 0x170053C6 RID: 21446
			// (get) Token: 0x060237E1 RID: 145377
			[Token(Token = "0x170053C6")]
			CGGalleryDisplayGroupViewModel inspectedGroup { [Token(Token = "0x60237E1")] get; }

			// Token: 0x170053C7 RID: 21447
			// (get) Token: 0x060237E2 RID: 145378
			[Token(Token = "0x170053C7")]
			CGGalleryDisplayViewModel inspectedDisplay { [Token(Token = "0x60237E2")] get; }

			// Token: 0x170053C8 RID: 21448
			// (get) Token: 0x060237E3 RID: 145379
			[Token(Token = "0x170053C8")]
			CGGalleryCGViewModel inspectedCG { [Token(Token = "0x60237E3")] get; }

			// Token: 0x170053C9 RID: 21449
			// (get) Token: 0x060237E4 RID: 145380
			[Token(Token = "0x170053C9")]
			bool inspectForward { [Token(Token = "0x60237E4")] get; }

			// Token: 0x170053CA RID: 21450
			// (get) Token: 0x060237E5 RID: 145381
			[Token(Token = "0x170053CA")]
			bool isSameDisplay { [Token(Token = "0x60237E5")] get; }

			// Token: 0x170053CB RID: 21451
			// (get) Token: 0x060237E6 RID: 145382
			[Token(Token = "0x170053CB")]
			bool isOpenView { [Token(Token = "0x60237E6")] get; }
		}

		// Token: 0x02005FEE RID: 24558
		[Token(Token = "0x2005FEE")]
		private class InspectorStatusModel : CGGalleryViewModel.IInspectorStatus, IHotfixable
		{
			// Token: 0x170053CC RID: 21452
			// (get) Token: 0x060237E7 RID: 145383 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060237E8 RID: 145384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053CC")]
			public CGGalleryDisplayGroupViewModel inspectedGroup
			{
				[Token(Token = "0x60237E7")]
				[Address(RVA = "0x1E24FD0", Offset = "0x1E23BD0", VA = "0x181E24FD0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60237E8")]
				[Address(RVA = "0x1E25260", Offset = "0x1E23E60", VA = "0x181E25260")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053CD RID: 21453
			// (get) Token: 0x060237E9 RID: 145385 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060237EA RID: 145386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053CD")]
			public CGGalleryDisplayViewModel inspectedDisplay
			{
				[Token(Token = "0x60237E9")]
				[Address(RVA = "0x1E24F70", Offset = "0x1E23B70", VA = "0x181E24F70", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60237EA")]
				[Address(RVA = "0x1E251E0", Offset = "0x1E23DE0", VA = "0x181E251E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053CE RID: 21454
			// (get) Token: 0x060237EB RID: 145387 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060237EC RID: 145388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053CE")]
			public CGGalleryCGViewModel inspectedCG
			{
				[Token(Token = "0x60237EB")]
				[Address(RVA = "0x1E24F10", Offset = "0x1E23B10", VA = "0x181E24F10", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60237EC")]
				[Address(RVA = "0x1E25160", Offset = "0x1E23D60", VA = "0x181E25160")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053CF RID: 21455
			// (get) Token: 0x060237ED RID: 145389 RVA: 0x000C10F8 File Offset: 0x000BF2F8
			// (set) Token: 0x060237EE RID: 145390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053CF")]
			public bool inspectForward
			{
				[Token(Token = "0x60237ED")]
				[Address(RVA = "0x1E24EB0", Offset = "0x1E23AB0", VA = "0x181E24EB0", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60237EE")]
				[Address(RVA = "0x1E250F0", Offset = "0x1E23CF0", VA = "0x181E250F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053D0 RID: 21456
			// (get) Token: 0x060237EF RID: 145391 RVA: 0x000C1110 File Offset: 0x000BF310
			// (set) Token: 0x060237F0 RID: 145392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053D0")]
			public bool isSameDisplay
			{
				[Token(Token = "0x60237EF")]
				[Address(RVA = "0x1E25090", Offset = "0x1E23C90", VA = "0x181E25090", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60237F0")]
				[Address(RVA = "0x1E25350", Offset = "0x1E23F50", VA = "0x181E25350")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053D1 RID: 21457
			// (get) Token: 0x060237F1 RID: 145393 RVA: 0x000C1128 File Offset: 0x000BF328
			// (set) Token: 0x060237F2 RID: 145394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053D1")]
			public bool isOpenView
			{
				[Token(Token = "0x60237F1")]
				[Address(RVA = "0x1E25030", Offset = "0x1E23C30", VA = "0x181E25030", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60237F2")]
				[Address(RVA = "0x1E252E0", Offset = "0x1E23EE0", VA = "0x181E252E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060237F3 RID: 145395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60237F3")]
			[Address(RVA = "0x1E24E50", Offset = "0x1E23A50", VA = "0x181E24E50")]
			public InspectorStatusModel()
			{
			}

			// Token: 0x0403119F RID: 201119
			[Token(Token = "0x403119F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_inspectedGroup;

			// Token: 0x040311A0 RID: 201120
			[Token(Token = "0x40311A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_inspectedGroup;

			// Token: 0x040311A1 RID: 201121
			[Token(Token = "0x40311A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_inspectedDisplay;

			// Token: 0x040311A2 RID: 201122
			[Token(Token = "0x40311A2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_inspectedDisplay;

			// Token: 0x040311A3 RID: 201123
			[Token(Token = "0x40311A3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_inspectedCG;

			// Token: 0x040311A4 RID: 201124
			[Token(Token = "0x40311A4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_inspectedCG;

			// Token: 0x040311A5 RID: 201125
			[Token(Token = "0x40311A5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_inspectForward;

			// Token: 0x040311A6 RID: 201126
			[Token(Token = "0x40311A6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_inspectForward;

			// Token: 0x040311A7 RID: 201127
			[Token(Token = "0x40311A7")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_isSameDisplay;

			// Token: 0x040311A8 RID: 201128
			[Token(Token = "0x40311A8")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_isSameDisplay;

			// Token: 0x040311A9 RID: 201129
			[Token(Token = "0x40311A9")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_isOpenView;

			// Token: 0x040311AA RID: 201130
			[Token(Token = "0x40311AA")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_isOpenView;

			// Token: 0x040311AB RID: 201131
			[Token(Token = "0x40311AB")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
