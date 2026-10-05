using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A60 RID: 27232
	[Token(Token = "0x2006A60")]
	public class StageMixStoryStorylineItemSyncHandler : IHotfixable
	{
		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x06026EB6 RID: 159414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BC2")]
		public StageStorylineViewModel focusedStoryline
		{
			[Token(Token = "0x6026EB6")]
			[Address(RVA = "0x22250F0", Offset = "0x2223CF0", VA = "0x1822250F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026EB7 RID: 159415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EB7")]
		[Address(RVA = "0x2224FF0", Offset = "0x2223BF0", VA = "0x182224FF0")]
		public StageMixStoryStorylineItemSyncHandler(UIAnimationLocation focusAnimation)
		{
		}

		// Token: 0x06026EB8 RID: 159416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EB8")]
		[Address(RVA = "0x22249B0", Offset = "0x22235B0", VA = "0x1822249B0")]
		public void Reset()
		{
		}

		// Token: 0x06026EB9 RID: 159417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EB9")]
		[Address(RVA = "0x2224A80", Offset = "0x2223680", VA = "0x182224A80")]
		public void UpdateState(MixStoryZoneGroupViewModel model)
		{
		}

		// Token: 0x06026EBA RID: 159418 RVA: 0x000CCB88 File Offset: 0x000CAD88
		[Token(Token = "0x6026EBA")]
		[Address(RVA = "0x22248F0", Offset = "0x22234F0", VA = "0x1822248F0")]
		public float GetProgressOfStoryline(string storylineId)
		{
			return 0f;
		}

		// Token: 0x06026EBB RID: 159419 RVA: 0x000CCBA0 File Offset: 0x000CADA0
		[Token(Token = "0x6026EBB")]
		[Address(RVA = "0x2224D50", Offset = "0x2223950", VA = "0x182224D50")]
		private float _GetProgress()
		{
			return 0f;
		}

		// Token: 0x06026EBC RID: 159420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EBC")]
		[Address(RVA = "0x2224DB0", Offset = "0x22239B0", VA = "0x182224DB0")]
		private void _SetProgress(float value)
		{
		}

		// Token: 0x040370C4 RID: 225476
		[Token(Token = "0x40370C4")]
		[FieldOffset(Offset = "0x10")]
		private readonly float m_focusDuration;

		// Token: 0x040370C5 RID: 225477
		[Token(Token = "0x40370C5")]
		[FieldOffset(Offset = "0x18")]
		private readonly ListDict<string, float> m_progressOfStorylines;

		// Token: 0x040370C6 RID: 225478
		[Token(Token = "0x40370C6")]
		[FieldOffset(Offset = "0x20")]
		private StageStorylineViewModel m_focusedStoryline;

		// Token: 0x040370C7 RID: 225479
		[Token(Token = "0x40370C7")]
		[FieldOffset(Offset = "0x28")]
		private float m_focusProgress;

		// Token: 0x040370C8 RID: 225480
		[Token(Token = "0x40370C8")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x040370C9 RID: 225481
		[Token(Token = "0x40370C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusedStoryline;

		// Token: 0x040370CA RID: 225482
		[Token(Token = "0x40370CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040370CB RID: 225483
		[Token(Token = "0x40370CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040370CC RID: 225484
		[Token(Token = "0x40370CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040370CD RID: 225485
		[Token(Token = "0x40370CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProgressOfStoryline;

		// Token: 0x040370CE RID: 225486
		[Token(Token = "0x40370CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetProgress;

		// Token: 0x040370CF RID: 225487
		[Token(Token = "0x40370CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetProgress;
	}
}
