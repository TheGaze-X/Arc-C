using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A85 RID: 27269
	[Token(Token = "0x2006A85")]
	public class StageMixStoryBriefSSView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027041 RID: 159809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027041")]
		[Address(RVA = "0x223D170", Offset = "0x223BD70", VA = "0x18223D170")]
		public void ToStoriesEvent()
		{
		}

		// Token: 0x06027042 RID: 159810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027042")]
		[Address(RVA = "0x223D030", Offset = "0x223BC30", VA = "0x18223D030")]
		public void ToReopenActEvent()
		{
		}

		// Token: 0x06027043 RID: 159811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027043")]
		[Address(RVA = "0x223D0D0", Offset = "0x223BCD0", VA = "0x18223D0D0")]
		public void ToRetroTrailEvent()
		{
		}

		// Token: 0x06027044 RID: 159812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027044")]
		[Address(RVA = "0x223D210", Offset = "0x223BE10", VA = "0x18223D210")]
		public void ToZoneMapEvent()
		{
		}

		// Token: 0x06027045 RID: 159813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027045")]
		[Address(RVA = "0x223D2B0", Offset = "0x223BEB0", VA = "0x18223D2B0")]
		public void UnlockRetroEvent()
		{
		}

		// Token: 0x06027046 RID: 159814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027046")]
		[Address(RVA = "0x223CF90", Offset = "0x223BB90", VA = "0x18223CF90")]
		public void ToCoinDetailEvent()
		{
		}

		// Token: 0x06027047 RID: 159815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027047")]
		[Address(RVA = "0x223C9E0", Offset = "0x223B5E0", VA = "0x18223C9E0")]
		public void ClearCache()
		{
		}

		// Token: 0x06027048 RID: 159816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027048")]
		[Address(RVA = "0x223CA50", Offset = "0x223B650", VA = "0x18223CA50")]
		public void Render(StageStorylineSSViewModel model)
		{
		}

		// Token: 0x06027049 RID: 159817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027049")]
		[Address(RVA = "0x223D350", Offset = "0x223BF50", VA = "0x18223D350")]
		private void _RenderRetro(StageStorylineSSViewModel model)
		{
		}

		// Token: 0x0602704A RID: 159818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602704A")]
		[Address(RVA = "0x223D640", Offset = "0x223C240", VA = "0x18223D640")]
		private void _RenderTrail(StageStorylineSSViewModel model)
		{
		}

		// Token: 0x0602704B RID: 159819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602704B")]
		[Address(RVA = "0x223D500", Offset = "0x223C100", VA = "0x18223D500")]
		private void _RenderTrackPoint(StageStorylineSSViewModel model)
		{
		}

		// Token: 0x0602704C RID: 159820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602704C")]
		[Address(RVA = "0x223D860", Offset = "0x223C460", VA = "0x18223D860")]
		public StageMixStoryBriefSSView()
		{
		}

		// Token: 0x04037304 RID: 226052
		[Token(Token = "0x4037304")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageMixStoryBriefTagView _tagView;

		// Token: 0x04037305 RID: 226053
		[Token(Token = "0x4037305")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _blockCountText;

		// Token: 0x04037306 RID: 226054
		[Token(Token = "0x4037306")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04037307 RID: 226055
		[Token(Token = "0x4037307")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _descScrollRect;

		// Token: 0x04037308 RID: 226056
		[Token(Token = "0x4037308")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _beforeReopenPart;

		// Token: 0x04037309 RID: 226057
		[Token(Token = "0x4037309")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _storyPart;

		// Token: 0x0403730A RID: 226058
		[Token(Token = "0x403730A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _reopeningPart;

		// Token: 0x0403730B RID: 226059
		[Token(Token = "0x403730B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _retroPart;

		// Token: 0x0403730C RID: 226060
		[Token(Token = "0x403730C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _retroLockedPart;

		// Token: 0x0403730D RID: 226061
		[Token(Token = "0x403730D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _retroUnlockDescText;

		// Token: 0x0403730E RID: 226062
		[Token(Token = "0x403730E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _retroUnlockedPart;

		// Token: 0x0403730F RID: 226063
		[Token(Token = "0x403730F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _retroTrailPart;

		// Token: 0x04037310 RID: 226064
		[Token(Token = "0x4037310")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _stageProgressText;

		// Token: 0x04037311 RID: 226065
		[Token(Token = "0x4037311")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _retroTrailIncompletePart;

		// Token: 0x04037312 RID: 226066
		[Token(Token = "0x4037312")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _retroTrailColorImage;

		// Token: 0x04037313 RID: 226067
		[Token(Token = "0x4037313")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x04037314 RID: 226068
		[Token(Token = "0x4037314")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _trackPointHolder;

		// Token: 0x04037315 RID: 226069
		[Token(Token = "0x4037315")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _retroTrailCompletePart;

		// Token: 0x04037316 RID: 226070
		[Token(Token = "0x4037316")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_finder;

		// Token: 0x04037317 RID: 226071
		[Token(Token = "0x4037317")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_trackPointInstance;

		// Token: 0x04037318 RID: 226072
		[Token(Token = "0x4037318")]
		[FieldOffset(Offset = "0xC0")]
		private StageStorylineSSViewModel m_cachedModel;

		// Token: 0x04037319 RID: 226073
		[Token(Token = "0x4037319")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToStoriesEvent;

		// Token: 0x0403731A RID: 226074
		[Token(Token = "0x403731A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToReopenActEvent;

		// Token: 0x0403731B RID: 226075
		[Token(Token = "0x403731B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToRetroTrailEvent;

		// Token: 0x0403731C RID: 226076
		[Token(Token = "0x403731C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToZoneMapEvent;

		// Token: 0x0403731D RID: 226077
		[Token(Token = "0x403731D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnlockRetroEvent;

		// Token: 0x0403731E RID: 226078
		[Token(Token = "0x403731E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ToCoinDetailEvent;

		// Token: 0x0403731F RID: 226079
		[Token(Token = "0x403731F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearCache;

		// Token: 0x04037320 RID: 226080
		[Token(Token = "0x4037320")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037321 RID: 226081
		[Token(Token = "0x4037321")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderRetro;

		// Token: 0x04037322 RID: 226082
		[Token(Token = "0x4037322")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderTrail;

		// Token: 0x04037323 RID: 226083
		[Token(Token = "0x4037323")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderTrackPoint;

		// Token: 0x04037324 RID: 226084
		[Token(Token = "0x4037324")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
