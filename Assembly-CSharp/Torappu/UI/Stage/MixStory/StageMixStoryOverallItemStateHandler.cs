using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A98 RID: 27288
	[Token(Token = "0x2006A98")]
	public class StageMixStoryOverallItemStateHandler : IHotfixable
	{
		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x0602709C RID: 159900 RVA: 0x000CD578 File Offset: 0x000CB778
		// (set) Token: 0x0602709D RID: 159901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C3C")]
		public StageMixStoryOverallView.OverallSortMode sortMode
		{
			[Token(Token = "0x602709C")]
			[Address(RVA = "0x22426E0", Offset = "0x22412E0", VA = "0x1822426E0")]
			[CompilerGenerated]
			get
			{
				return StageMixStoryOverallView.OverallSortMode.STORYLINE;
			}
			[Token(Token = "0x602709D")]
			[Address(RVA = "0x2242740", Offset = "0x2241340", VA = "0x182242740")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x0602709E RID: 159902 RVA: 0x000CD590 File Offset: 0x000CB790
		[Token(Token = "0x17005C3D")]
		public StageMixStoryOverallView.OverallDisplayFeature displayFeature
		{
			[Token(Token = "0x602709E")]
			[Address(RVA = "0x2242620", Offset = "0x2241220", VA = "0x182242620")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x0602709F RID: 159903 RVA: 0x000CD5A8 File Offset: 0x000CB7A8
		[Token(Token = "0x17005C3E")]
		public StageMixStoryOverallView.OverallDisplayFeature presentedFeature
		{
			[Token(Token = "0x602709F")]
			[Address(RVA = "0x2242680", Offset = "0x2241280", VA = "0x182242680")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x060270A0 RID: 159904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270A0")]
		[Address(RVA = "0x22425A0", Offset = "0x22411A0", VA = "0x1822425A0")]
		public StageMixStoryOverallItemStateHandler(float switchHalfTime)
		{
		}

		// Token: 0x060270A1 RID: 159905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270A1")]
		[Address(RVA = "0x2241C30", Offset = "0x2240830", VA = "0x182241C30")]
		public void UpdateDisplayFeature(StageMixStoryOverallView.OverallDisplayFeature feature, bool fastMode)
		{
		}

		// Token: 0x060270A2 RID: 159906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270A2")]
		[Address(RVA = "0x22420E0", Offset = "0x2240CE0", VA = "0x1822420E0")]
		private void _KillPlayTweenIfExisted()
		{
		}

		// Token: 0x060270A3 RID: 159907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270A3")]
		[Address(RVA = "0x2242220", Offset = "0x2240E20", VA = "0x182242220")]
		private void _StartPlayTween()
		{
		}

		// Token: 0x060270A4 RID: 159908 RVA: 0x000CD5C0 File Offset: 0x000CB7C0
		[Token(Token = "0x60270A4")]
		[Address(RVA = "0x2242150", Offset = "0x2240D50", VA = "0x182242150")]
		private float _PlayGetter()
		{
			return 0f;
		}

		// Token: 0x060270A5 RID: 159909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270A5")]
		[Address(RVA = "0x22421B0", Offset = "0x2240DB0", VA = "0x1822421B0")]
		private void _PlaySetter(float value)
		{
		}

		// Token: 0x060270A6 RID: 159910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270A6")]
		[Address(RVA = "0x2242540", Offset = "0x2241140", VA = "0x182242540")]
		private void _UpdatePresentingFeature()
		{
		}

		// Token: 0x060270A7 RID: 159911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270A7")]
		[Address(RVA = "0x22417B0", Offset = "0x22403B0", VA = "0x1822417B0")]
		public Tween GenerateSyncTweenForItem(UIAnimationLocation location)
		{
			return null;
		}

		// Token: 0x060270A8 RID: 159912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270A8")]
		[Address(RVA = "0x2241A20", Offset = "0x2240620", VA = "0x182241A20")]
		public Tween GenerateSyncTweenForPanel(StageMixStoryOverallView.OverallDisplayFeature feature, CanvasGroup canvasGroup)
		{
			return null;
		}

		// Token: 0x060270A9 RID: 159913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270A9")]
		[Address(RVA = "0x2241D60", Offset = "0x2240960", VA = "0x182241D60")]
		private Tween _GenerateSyncTweenForActivePanel(CanvasGroup canvasGroup)
		{
			return null;
		}

		// Token: 0x060270AA RID: 159914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270AA")]
		[Address(RVA = "0x2241F70", Offset = "0x2240B70", VA = "0x182241F70")]
		private Tween _GenerateSyncTweenForInactivePanel(CanvasGroup canvasGroup)
		{
			return null;
		}

		// Token: 0x040373CD RID: 226253
		[Token(Token = "0x40373CD")]
		[FieldOffset(Offset = "0x10")]
		private readonly float m_switchHalfTime;

		// Token: 0x040373CE RID: 226254
		[Token(Token = "0x40373CE")]
		[FieldOffset(Offset = "0x14")]
		private StageMixStoryOverallView.OverallDisplayFeature m_displayFeature;

		// Token: 0x040373CF RID: 226255
		[Token(Token = "0x40373CF")]
		[FieldOffset(Offset = "0x18")]
		private StageMixStoryOverallView.OverallDisplayFeature m_presentedFeature;

		// Token: 0x040373D0 RID: 226256
		[Token(Token = "0x40373D0")]
		[FieldOffset(Offset = "0x1C")]
		private float m_playingPosition;

		// Token: 0x040373D1 RID: 226257
		[Token(Token = "0x40373D1")]
		[FieldOffset(Offset = "0x20")]
		private Tween m_playTween;

		// Token: 0x040373D3 RID: 226259
		[Token(Token = "0x40373D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortMode;

		// Token: 0x040373D4 RID: 226260
		[Token(Token = "0x40373D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sortMode;

		// Token: 0x040373D5 RID: 226261
		[Token(Token = "0x40373D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_displayFeature;

		// Token: 0x040373D6 RID: 226262
		[Token(Token = "0x40373D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_presentedFeature;

		// Token: 0x040373D7 RID: 226263
		[Token(Token = "0x40373D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040373D8 RID: 226264
		[Token(Token = "0x40373D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateDisplayFeature;

		// Token: 0x040373D9 RID: 226265
		[Token(Token = "0x40373D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__KillPlayTweenIfExisted;

		// Token: 0x040373DA RID: 226266
		[Token(Token = "0x40373DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StartPlayTween;

		// Token: 0x040373DB RID: 226267
		[Token(Token = "0x40373DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayGetter;

		// Token: 0x040373DC RID: 226268
		[Token(Token = "0x40373DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlaySetter;

		// Token: 0x040373DD RID: 226269
		[Token(Token = "0x40373DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdatePresentingFeature;

		// Token: 0x040373DE RID: 226270
		[Token(Token = "0x40373DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GenerateSyncTweenForItem;

		// Token: 0x040373DF RID: 226271
		[Token(Token = "0x40373DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GenerateSyncTweenForPanel;

		// Token: 0x040373E0 RID: 226272
		[Token(Token = "0x40373E0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenerateSyncTweenForActivePanel;

		// Token: 0x040373E1 RID: 226273
		[Token(Token = "0x40373E1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenerateSyncTweenForInactivePanel;
	}
}
