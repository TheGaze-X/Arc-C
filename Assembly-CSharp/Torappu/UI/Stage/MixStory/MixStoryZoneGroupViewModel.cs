using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A72 RID: 27250
	[Token(Token = "0x2006A72")]
	public class MixStoryZoneGroupViewModel : ZoneGroupViewModel, IHotfixable
	{
		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x06026EFC RID: 159484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BCD")]
		public StageStorylineMainlineChapterViewModel chapterModel
		{
			[Token(Token = "0x6026EFC")]
			[Address(RVA = "0x221D900", Offset = "0x221C500", VA = "0x18221D900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x06026EFD RID: 159485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BCE")]
		public StageStorylineViewModel lastVisitedStoryline
		{
			[Token(Token = "0x6026EFD")]
			[Address(RVA = "0x221DC00", Offset = "0x221C800", VA = "0x18221DC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x06026EFE RID: 159486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BCF")]
		public StageStorylineStorySetLocationViewModel lastVisitedLocation
		{
			[Token(Token = "0x6026EFE")]
			[Address(RVA = "0x221DB60", Offset = "0x221C760", VA = "0x18221DB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x06026EFF RID: 159487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BD0")]
		public StageStorylineViewModel focusedStoryline
		{
			[Token(Token = "0x6026EFF")]
			[Address(RVA = "0x221DA60", Offset = "0x221C660", VA = "0x18221DA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x06026F00 RID: 159488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BD1")]
		public StageStorylineStorySetLocationViewModel focusedLocation
		{
			[Token(Token = "0x6026F00")]
			[Address(RVA = "0x221D9C0", Offset = "0x221C5C0", VA = "0x18221D9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x06026F01 RID: 159489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BD2")]
		public List<StageStorylineViewModel> presentedStorylines
		{
			[Token(Token = "0x6026F01")]
			[Address(RVA = "0x221DCA0", Offset = "0x221C8A0", VA = "0x18221DCA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x06026F02 RID: 159490 RVA: 0x000CCD98 File Offset: 0x000CAF98
		// (set) Token: 0x06026F03 RID: 159491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD3")]
		public int dataSequence
		{
			[Token(Token = "0x6026F02")]
			[Address(RVA = "0x221D960", Offset = "0x221C560", VA = "0x18221D960")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026F03")]
			[Address(RVA = "0x221DE20", Offset = "0x221CA20", VA = "0x18221DE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x06026F04 RID: 159492 RVA: 0x000CCDB0 File Offset: 0x000CAFB0
		// (set) Token: 0x06026F05 RID: 159493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD4")]
		public bool hasTrackPoint
		{
			[Token(Token = "0x6026F04")]
			[Address(RVA = "0x221DB00", Offset = "0x221C700", VA = "0x18221DB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026F05")]
			[Address(RVA = "0x221DE90", Offset = "0x221CA90", VA = "0x18221DE90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x06026F06 RID: 159494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026F07 RID: 159495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD5")]
		public StageStorylineStorySetViewModel selectedBriefStorySet
		{
			[Token(Token = "0x6026F06")]
			[Address(RVA = "0x221DD60", Offset = "0x221C960", VA = "0x18221DD60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026F07")]
			[Address(RVA = "0x221DF70", Offset = "0x221CB70", VA = "0x18221DF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x06026F08 RID: 159496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026F09 RID: 159497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD6")]
		public StageStorylineViewModel selectedBriefStoryline
		{
			[Token(Token = "0x6026F08")]
			[Address(RVA = "0x221DDC0", Offset = "0x221C9C0", VA = "0x18221DDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026F09")]
			[Address(RVA = "0x221DFF0", Offset = "0x221CBF0", VA = "0x18221DFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x06026F0A RID: 159498 RVA: 0x000CCDC8 File Offset: 0x000CAFC8
		// (set) Token: 0x06026F0B RID: 159499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD7")]
		public int selectedBriefIndex
		{
			[Token(Token = "0x6026F0A")]
			[Address(RVA = "0x221DD00", Offset = "0x221C900", VA = "0x18221DD00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026F0B")]
			[Address(RVA = "0x221DF00", Offset = "0x221CB00", VA = "0x18221DF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026F0C RID: 159500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F0C")]
		[Address(RVA = "0x2218FF0", Offset = "0x2217BF0", VA = "0x182218FF0")]
		public void LoadData()
		{
		}

		// Token: 0x06026F0D RID: 159501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F0D")]
		[Address(RVA = "0x2219930", Offset = "0x2218530", VA = "0x182219930")]
		public void RefreshData()
		{
		}

		// Token: 0x06026F0E RID: 159502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F0E")]
		[Address(RVA = "0x221BF70", Offset = "0x221AB70", VA = "0x18221BF70")]
		private void _LoadTags(Dictionary<string, StorylineTagData> tags)
		{
		}

		// Token: 0x06026F0F RID: 159503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F0F")]
		[Address(RVA = "0x221B780", Offset = "0x221A380", VA = "0x18221B780")]
		private void _LoadStorySets(Dictionary<string, StorylineStorySetData> storySets)
		{
		}

		// Token: 0x06026F10 RID: 159504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F10")]
		[Address(RVA = "0x221BA80", Offset = "0x221A680", VA = "0x18221BA80")]
		private void _LoadStorylines(ListDict<string, StorylineData> storylines, StorylineConstData constData)
		{
		}

		// Token: 0x06026F11 RID: 159505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F11")]
		[Address(RVA = "0x221C570", Offset = "0x221B170", VA = "0x18221C570")]
		private void _PostProcessStorySet(StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026F12 RID: 159506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F12")]
		[Address(RVA = "0x221C960", Offset = "0x221B560", VA = "0x18221C960")]
		private void _PostProcessThroughZonesAndStages(ListDict<string, string> zoneToRetro)
		{
		}

		// Token: 0x06026F13 RID: 159507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F13")]
		[Address(RVA = "0x221C7F0", Offset = "0x221B3F0", VA = "0x18221C7F0")]
		private void _PostProcessThroughRetros(ListDict<string, string> zoneToRetro)
		{
		}

		// Token: 0x06026F14 RID: 159508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F14")]
		[Address(RVA = "0x221CB20", Offset = "0x221B720", VA = "0x18221CB20")]
		private void _PostProcessThroughZones()
		{
		}

		// Token: 0x06026F15 RID: 159509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F15")]
		[Address(RVA = "0x221C6B0", Offset = "0x221B2B0", VA = "0x18221C6B0")]
		private void _PostProcessThroughRetroZone(ZoneViewModel zone, StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026F16 RID: 159510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F16")]
		[Address(RVA = "0x221CE90", Offset = "0x221BA90", VA = "0x18221CE90")]
		private void _RefreshStorySets(StorylineConstData constData)
		{
		}

		// Token: 0x06026F17 RID: 159511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F17")]
		[Address(RVA = "0x221CE00", Offset = "0x221BA00", VA = "0x18221CE00")]
		private void _PostRefreshSideStory(StageStorylineSSViewModel model)
		{
		}

		// Token: 0x06026F18 RID: 159512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F18")]
		[Address(RVA = "0x221D2F0", Offset = "0x221BEF0", VA = "0x18221D2F0")]
		private void _RefreshStorylines()
		{
		}

		// Token: 0x06026F19 RID: 159513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F19")]
		[Address(RVA = "0x221B350", Offset = "0x2219F50", VA = "0x18221B350")]
		private void _InitLastVisitAndFocusIfNot()
		{
		}

		// Token: 0x06026F1A RID: 159514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F1A")]
		[Address(RVA = "0x221B410", Offset = "0x221A010", VA = "0x18221B410")]
		private void _InitLastVisitedIfNot()
		{
		}

		// Token: 0x06026F1B RID: 159515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F1B")]
		[Address(RVA = "0x221B2D0", Offset = "0x2219ED0", VA = "0x18221B2D0")]
		private void _InitFocusIfNot()
		{
		}

		// Token: 0x06026F1C RID: 159516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026F1C")]
		[Address(RVA = "0x2218BC0", Offset = "0x22177C0", VA = "0x182218BC0")]
		public string GetRetroIdByZoneId(string zoneId)
		{
			return null;
		}

		// Token: 0x06026F1D RID: 159517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F1D")]
		[Address(RVA = "0x22189E0", Offset = "0x22175E0", VA = "0x1822189E0")]
		public void FocusLastVisitedMainline()
		{
		}

		// Token: 0x06026F1E RID: 159518 RVA: 0x000CCDE0 File Offset: 0x000CAFE0
		[Token(Token = "0x6026F1E")]
		[Address(RVA = "0x2218820", Offset = "0x2217420", VA = "0x182218820")]
		public bool CheckZoneShouldCheckBriefByZoneId(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026F1F RID: 159519 RVA: 0x000CCDF8 File Offset: 0x000CAFF8
		[Token(Token = "0x6026F1F")]
		[Address(RVA = "0x2218510", Offset = "0x2217110", VA = "0x182218510")]
		public bool CheckZoneShouldCheckBriefByActivityId(string activityId)
		{
			return default(bool);
		}

		// Token: 0x06026F20 RID: 159520 RVA: 0x000CCE10 File Offset: 0x000CB010
		[Token(Token = "0x6026F20")]
		[Address(RVA = "0x2218710", Offset = "0x2217310", VA = "0x182218710")]
		public bool CheckZoneShouldCheckBriefByStorySetId(string storySetId)
		{
			return default(bool);
		}

		// Token: 0x06026F21 RID: 159521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026F21")]
		[Address(RVA = "0x2218D60", Offset = "0x2217960", VA = "0x182218D60")]
		public StageStorylineStorySetViewModel GetStorySetViewModelByRelevantActId(string actId)
		{
			return null;
		}

		// Token: 0x06026F22 RID: 159522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F22")]
		[Address(RVA = "0x22193B0", Offset = "0x2217FB0", VA = "0x1822193B0")]
		public void OnZoneSelected(string zoneId)
		{
		}

		// Token: 0x06026F23 RID: 159523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F23")]
		[Address(RVA = "0x221A6F0", Offset = "0x22192F0", VA = "0x18221A6F0")]
		public void SetFocusedStorySet(string storySetId)
		{
		}

		// Token: 0x06026F24 RID: 159524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F24")]
		[Address(RVA = "0x221D430", Offset = "0x221C030", VA = "0x18221D430")]
		private void _SetFocusedStorySet(StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026F25 RID: 159525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F25")]
		[Address(RVA = "0x221A800", Offset = "0x2219400", VA = "0x18221A800")]
		public void SetFocusedStoryline(string storylineId)
		{
		}

		// Token: 0x06026F26 RID: 159526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F26")]
		[Address(RVA = "0x221ABE0", Offset = "0x22197E0", VA = "0x18221ABE0")]
		public void SetLastVisitedStorySet(StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026F27 RID: 159527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F27")]
		[Address(RVA = "0x221AA20", Offset = "0x2219620", VA = "0x18221AA20")]
		public void SetLastVisitedStorySet(string storySetId)
		{
		}

		// Token: 0x06026F28 RID: 159528 RVA: 0x000CCE28 File Offset: 0x000CB028
		[Token(Token = "0x6026F28")]
		[Address(RVA = "0x221A140", Offset = "0x2218D40", VA = "0x18221A140")]
		public bool SelectBrief(string storySetId)
		{
			return default(bool);
		}

		// Token: 0x06026F29 RID: 159529 RVA: 0x000CCE40 File Offset: 0x000CB040
		[Token(Token = "0x6026F29")]
		[Address(RVA = "0x2219F70", Offset = "0x2218B70", VA = "0x182219F70")]
		public bool SelectBriefByZoneId(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026F2A RID: 159530 RVA: 0x000CCE58 File Offset: 0x000CB058
		[Token(Token = "0x6026F2A")]
		[Address(RVA = "0x2219B30", Offset = "0x2218730", VA = "0x182219B30")]
		public bool SelectBriefByRelevantActId(string relevantActId)
		{
			return default(bool);
		}

		// Token: 0x06026F2B RID: 159531 RVA: 0x000CCE70 File Offset: 0x000CB070
		[Token(Token = "0x6026F2B")]
		[Address(RVA = "0x2219D50", Offset = "0x2218950", VA = "0x182219D50")]
		public bool SelectBriefByStorySetId(string storySetId)
		{
			return default(bool);
		}

		// Token: 0x06026F2C RID: 159532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F2C")]
		[Address(RVA = "0x221C1A0", Offset = "0x221ADA0", VA = "0x18221C1A0")]
		private void _OnStorySetSelectedInBrief(StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026F2D RID: 159533 RVA: 0x000CCE88 File Offset: 0x000CB088
		[Token(Token = "0x6026F2D")]
		[Address(RVA = "0x221AD10", Offset = "0x2219910", VA = "0x18221AD10")]
		public bool SwitchBrief(string storySetId)
		{
			return default(bool);
		}

		// Token: 0x06026F2E RID: 159534 RVA: 0x000CCEA0 File Offset: 0x000CB0A0
		[Token(Token = "0x6026F2E")]
		[Address(RVA = "0x221D4B0", Offset = "0x221C0B0", VA = "0x18221D4B0")]
		private static int _SortStoryline(StageStorylineViewModel x, StageStorylineViewModel y)
		{
			return 0;
		}

		// Token: 0x06026F2F RID: 159535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F2F")]
		[Address(RVA = "0x221D580", Offset = "0x221C180", VA = "0x18221D580")]
		public MixStoryZoneGroupViewModel()
		{
		}

		// Token: 0x04037138 RID: 225592
		[Token(Token = "0x4037138")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, StageStorylineTagViewModel> m_tags;

		// Token: 0x04037139 RID: 225593
		[Token(Token = "0x4037139")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, StageStorylineStorySetViewModel> m_storySets;

		// Token: 0x0403713A RID: 225594
		[Token(Token = "0x403713A")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, StageStorylineViewModel> m_storylines;

		// Token: 0x0403713B RID: 225595
		[Token(Token = "0x403713B")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<StageStorylineViewModel> m_presentedStorylineList;

		// Token: 0x0403713C RID: 225596
		[Token(Token = "0x403713C")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<string, StageStorylineStorySetViewModel> m_cachedRetroToStorySets;

		// Token: 0x0403713D RID: 225597
		[Token(Token = "0x403713D")]
		[FieldOffset(Offset = "0x50")]
		private readonly Dictionary<string, StageStorylineStorySetViewModel> m_cacheZoneToStorySets;

		// Token: 0x0403713E RID: 225598
		[Token(Token = "0x403713E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_guideHideRecommend;

		// Token: 0x0403713F RID: 225599
		[Token(Token = "0x403713F")]
		[FieldOffset(Offset = "0x60")]
		private StageStorylineStorySetViewModel m_lastVisitedStorySet;

		// Token: 0x04037140 RID: 225600
		[Token(Token = "0x4037140")]
		[FieldOffset(Offset = "0x68")]
		private StageStorylineStorySetViewModel m_focusedStorySet;

		// Token: 0x04037141 RID: 225601
		[Token(Token = "0x4037141")]
		[FieldOffset(Offset = "0x70")]
		private StageStorylineMainlineChapterViewModel m_chapterModel;

		// Token: 0x04037142 RID: 225602
		[Token(Token = "0x4037142")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, ZoneViewModel> m_zoneDict;

		// Token: 0x04037148 RID: 225608
		[Token(Token = "0x4037148")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chapterModel;

		// Token: 0x04037149 RID: 225609
		[Token(Token = "0x4037149")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lastVisitedStoryline;

		// Token: 0x0403714A RID: 225610
		[Token(Token = "0x403714A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lastVisitedLocation;

		// Token: 0x0403714B RID: 225611
		[Token(Token = "0x403714B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_focusedStoryline;

		// Token: 0x0403714C RID: 225612
		[Token(Token = "0x403714C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_focusedLocation;

		// Token: 0x0403714D RID: 225613
		[Token(Token = "0x403714D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_presentedStorylines;

		// Token: 0x0403714E RID: 225614
		[Token(Token = "0x403714E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_dataSequence;

		// Token: 0x0403714F RID: 225615
		[Token(Token = "0x403714F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_dataSequence;

		// Token: 0x04037150 RID: 225616
		[Token(Token = "0x4037150")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_hasTrackPoint;

		// Token: 0x04037151 RID: 225617
		[Token(Token = "0x4037151")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_hasTrackPoint;

		// Token: 0x04037152 RID: 225618
		[Token(Token = "0x4037152")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_selectedBriefStorySet;

		// Token: 0x04037153 RID: 225619
		[Token(Token = "0x4037153")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_selectedBriefStorySet;

		// Token: 0x04037154 RID: 225620
		[Token(Token = "0x4037154")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_selectedBriefStoryline;

		// Token: 0x04037155 RID: 225621
		[Token(Token = "0x4037155")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_selectedBriefStoryline;

		// Token: 0x04037156 RID: 225622
		[Token(Token = "0x4037156")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_selectedBriefIndex;

		// Token: 0x04037157 RID: 225623
		[Token(Token = "0x4037157")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_selectedBriefIndex;

		// Token: 0x04037158 RID: 225624
		[Token(Token = "0x4037158")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037159 RID: 225625
		[Token(Token = "0x4037159")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403715A RID: 225626
		[Token(Token = "0x403715A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadTags;

		// Token: 0x0403715B RID: 225627
		[Token(Token = "0x403715B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadStorySets;

		// Token: 0x0403715C RID: 225628
		[Token(Token = "0x403715C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadStorylines;

		// Token: 0x0403715D RID: 225629
		[Token(Token = "0x403715D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PostProcessStorySet;

		// Token: 0x0403715E RID: 225630
		[Token(Token = "0x403715E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PostProcessThroughZonesAndStages;

		// Token: 0x0403715F RID: 225631
		[Token(Token = "0x403715F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PostProcessThroughRetros;

		// Token: 0x04037160 RID: 225632
		[Token(Token = "0x4037160")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__PostProcessThroughZones;

		// Token: 0x04037161 RID: 225633
		[Token(Token = "0x4037161")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PostProcessThroughRetroZone;

		// Token: 0x04037162 RID: 225634
		[Token(Token = "0x4037162")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RefreshStorySets;

		// Token: 0x04037163 RID: 225635
		[Token(Token = "0x4037163")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__PostRefreshSideStory;

		// Token: 0x04037164 RID: 225636
		[Token(Token = "0x4037164")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshStorylines;

		// Token: 0x04037165 RID: 225637
		[Token(Token = "0x4037165")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__InitLastVisitAndFocusIfNot;

		// Token: 0x04037166 RID: 225638
		[Token(Token = "0x4037166")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__InitLastVisitedIfNot;

		// Token: 0x04037167 RID: 225639
		[Token(Token = "0x4037167")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__InitFocusIfNot;

		// Token: 0x04037168 RID: 225640
		[Token(Token = "0x4037168")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetRetroIdByZoneId;

		// Token: 0x04037169 RID: 225641
		[Token(Token = "0x4037169")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_FocusLastVisitedMainline;

		// Token: 0x0403716A RID: 225642
		[Token(Token = "0x403716A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CheckZoneShouldCheckBriefByZoneId;

		// Token: 0x0403716B RID: 225643
		[Token(Token = "0x403716B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckZoneShouldCheckBriefByActivityId;

		// Token: 0x0403716C RID: 225644
		[Token(Token = "0x403716C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckZoneShouldCheckBriefByStorySetId;

		// Token: 0x0403716D RID: 225645
		[Token(Token = "0x403716D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetStorySetViewModelByRelevantActId;

		// Token: 0x0403716E RID: 225646
		[Token(Token = "0x403716E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnZoneSelected;

		// Token: 0x0403716F RID: 225647
		[Token(Token = "0x403716F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_SetFocusedStorySet;

		// Token: 0x04037170 RID: 225648
		[Token(Token = "0x4037170")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SetFocusedStorySet;

		// Token: 0x04037171 RID: 225649
		[Token(Token = "0x4037171")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_SetFocusedStoryline;

		// Token: 0x04037172 RID: 225650
		[Token(Token = "0x4037172")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_SetLastVisitedStorySet;

		// Token: 0x04037173 RID: 225651
		[Token(Token = "0x4037173")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix1_SetLastVisitedStorySet;

		// Token: 0x04037174 RID: 225652
		[Token(Token = "0x4037174")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SelectBrief;

		// Token: 0x04037175 RID: 225653
		[Token(Token = "0x4037175")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_SelectBriefByZoneId;

		// Token: 0x04037176 RID: 225654
		[Token(Token = "0x4037176")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_SelectBriefByRelevantActId;

		// Token: 0x04037177 RID: 225655
		[Token(Token = "0x4037177")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_SelectBriefByStorySetId;

		// Token: 0x04037178 RID: 225656
		[Token(Token = "0x4037178")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnStorySetSelectedInBrief;

		// Token: 0x04037179 RID: 225657
		[Token(Token = "0x4037179")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_SwitchBrief;

		// Token: 0x0403717A RID: 225658
		[Token(Token = "0x403717A")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__SortStoryline;

		// Token: 0x0403717B RID: 225659
		[Token(Token = "0x403717B")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
