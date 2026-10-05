using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CB3 RID: 27827
	[Token(Token = "0x2006CB3")]
	public class TemplateActivityEntry : TemplateActivitySingleComponent, IHotfixable, IAudioAnimationPlayerConditionProvider
	{
		// Token: 0x06027B41 RID: 162625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B41")]
		[Address(RVA = "0x22DCC10", Offset = "0x22DB810", VA = "0x1822DCC10")]
		private void Awake()
		{
		}

		// Token: 0x06027B42 RID: 162626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B42")]
		[Address(RVA = "0x22DF040", Offset = "0x22DDC40", VA = "0x1822DF040")]
		private void _UpdateBindToParentStatus()
		{
		}

		// Token: 0x06027B43 RID: 162627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B43")]
		[Address(RVA = "0x22DD760", Offset = "0x22DC360", VA = "0x1822DD760", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06027B44 RID: 162628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B44")]
		[Address(RVA = "0x22DD600", Offset = "0x22DC200", VA = "0x1822DD600", Slot = "6")]
		protected override void OnBindToParent()
		{
		}

		// Token: 0x06027B45 RID: 162629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B45")]
		[Address(RVA = "0x22DDC00", Offset = "0x22DC800", VA = "0x1822DDC00", Slot = "9")]
		protected override void OnPageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06027B46 RID: 162630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B46")]
		[Address(RVA = "0x22DD670", Offset = "0x22DC270", VA = "0x1822DD670")]
		private void OnDestroy()
		{
		}

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x06027B47 RID: 162631 RVA: 0x000CF1B0 File Offset: 0x000CD3B0
		[Token(Token = "0x17005DC8")]
		public bool isAnimPlaying
		{
			[Token(Token = "0x6027B47")]
			[Address(RVA = "0x22DF1B0", Offset = "0x22DDDB0", VA = "0x1822DF1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027B48 RID: 162632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B48")]
		[Address(RVA = "0x22DDD90", Offset = "0x22DC990", VA = "0x1822DDD90")]
		private void _CheckAllFinish()
		{
		}

		// Token: 0x06027B49 RID: 162633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B49")]
		[Address(RVA = "0x22DDD30", Offset = "0x22DC930", VA = "0x1822DDD30")]
		private void _DescreasePlayingCount()
		{
		}

		// Token: 0x06027B4A RID: 162634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B4A")]
		[Address(RVA = "0x22DE790", Offset = "0x22DD390", VA = "0x1822DE790")]
		private void _SampleAllAnimClipAtBegin()
		{
		}

		// Token: 0x06027B4B RID: 162635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B4B")]
		[Address(RVA = "0x22DE3A0", Offset = "0x22DCFA0", VA = "0x1822DE3A0")]
		private IEnumerator _PlayTargetAnim(bool isSkip, TemplateActivityEntry.EntryAnim anim)
		{
			return null;
		}

		// Token: 0x06027B4C RID: 162636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B4C")]
		[Address(RVA = "0x22DE490", Offset = "0x22DD090", VA = "0x1822DE490")]
		private void _PlayWithAnim(bool isSkip)
		{
		}

		// Token: 0x06027B4D RID: 162637 RVA: 0x000CF1C8 File Offset: 0x000CD3C8
		[Token(Token = "0x6027B4D")]
		[Address(RVA = "0x22DEE70", Offset = "0x22DDA70", VA = "0x1822DEE70")]
		private bool _TryTriggerAVG()
		{
			return default(bool);
		}

		// Token: 0x06027B4E RID: 162638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B4E")]
		[Address(RVA = "0x22DE140", Offset = "0x22DCD40", VA = "0x1822DE140")]
		private void _OnVideoStoryCompleted(Story _)
		{
		}

		// Token: 0x06027B4F RID: 162639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B4F")]
		[Address(RVA = "0x22DEA40", Offset = "0x22DD640", VA = "0x1822DEA40")]
		private void _TryStartAnim()
		{
		}

		// Token: 0x06027B50 RID: 162640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B50")]
		[Address(RVA = "0x22DECC0", Offset = "0x22DD8C0", VA = "0x1822DECC0")]
		private void _TryTrigTutorial()
		{
		}

		// Token: 0x06027B51 RID: 162641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B51")]
		[Address(RVA = "0x22DEAC0", Offset = "0x22DD6C0", VA = "0x1822DEAC0")]
		private void _TryTrigTutorialOnResume(UIPageTransContext context)
		{
		}

		// Token: 0x06027B52 RID: 162642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B52")]
		[Address(RVA = "0x22DE8A0", Offset = "0x22DD4A0", VA = "0x1822DE8A0")]
		private void _TryRegisterGOAndRaiseSignal()
		{
		}

		// Token: 0x06027B53 RID: 162643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B53")]
		[Address(RVA = "0x22DCDB0", Offset = "0x22DB9B0", VA = "0x1822DCDB0")]
		public void EventOnMedalClicked()
		{
		}

		// Token: 0x06027B54 RID: 162644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B54")]
		[Address(RVA = "0x22DD340", Offset = "0x22DBF40", VA = "0x1822DD340")]
		public void EventOnUngroupedMedalClicked()
		{
		}

		// Token: 0x06027B55 RID: 162645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B55")]
		[Address(RVA = "0x22DD4B0", Offset = "0x22DC0B0", VA = "0x1822DD4B0")]
		public void EventOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x06027B56 RID: 162646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B56")]
		[Address(RVA = "0x22DE6F0", Offset = "0x22DD2F0", VA = "0x1822DE6F0")]
		private void _RealEventOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x06027B57 RID: 162647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B57")]
		[Address(RVA = "0x22DCE80", Offset = "0x22DBA80", VA = "0x1822DCE80")]
		public void EventOnReplayEntryAVG()
		{
		}

		// Token: 0x06027B58 RID: 162648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B58")]
		[Address(RVA = "0x22DD180", Offset = "0x22DBD80", VA = "0x1822DD180")]
		public void EventOnShopClicked()
		{
		}

		// Token: 0x06027B59 RID: 162649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B59")]
		[Address(RVA = "0x22DD0B0", Offset = "0x22DBCB0", VA = "0x1822DD0B0")]
		public void EventOnReplicateClicked()
		{
		}

		// Token: 0x06027B5A RID: 162650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B5A")]
		[Address(RVA = "0x22DDF90", Offset = "0x22DCB90", VA = "0x1822DDF90")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x06027B5B RID: 162651 RVA: 0x000CF1E0 File Offset: 0x000CD3E0
		[Token(Token = "0x6027B5B")]
		[Address(RVA = "0x22DCC70", Offset = "0x22DB870", VA = "0x1822DCC70", Slot = "10")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x06027B5C RID: 162652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B5C")]
		[Address(RVA = "0x22DF110", Offset = "0x22DDD10", VA = "0x1822DF110")]
		public TemplateActivityEntry()
		{
		}

		// Token: 0x06027B5E RID: 162654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B5E")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06027B5F RID: 162655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B5F")]
		[Address(RVA = "0x22DDCD0", Offset = "0x22DC8D0", VA = "0x1822DDCD0")]
		private void <>xLuaBaseProxy_OnBindToParent()
		{
		}

		// Token: 0x06027B60 RID: 162656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B60")]
		[Address(RVA = "0x22DDCF0", Offset = "0x22DC8F0", VA = "0x1822DDCF0")]
		private void <>xLuaBaseProxy_OnPageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x040384BE RID: 230590
		[Token(Token = "0x40384BE")]
		public const float ANIM_SMOOTH_DELAY = 0.05f;

		// Token: 0x040384BF RID: 230591
		[Token(Token = "0x40384BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040384C0 RID: 230592
		[Token(Token = "0x40384C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<TemplateActivityEntry.EntryAnim> _animList;

		// Token: 0x040384C1 RID: 230593
		[Token(Token = "0x40384C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _entryAnimOncePerLogin;

		// Token: 0x040384C2 RID: 230594
		[Token(Token = "0x40384C2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<UnityEvent> _onAnimEndList;

		// Token: 0x040384C3 RID: 230595
		[Token(Token = "0x40384C3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("BindComponents")]
		[Tooltip("Objects to enable when component binded")]
		private GameObject[] _enableWhenBinded;

		// Token: 0x040384C4 RID: 230596
		[Token(Token = "0x40384C4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tutorial")]
		private TemplateActivityEntryTutorialHandler _tutorialHandler;

		// Token: 0x040384C5 RID: 230597
		[Token(Token = "0x40384C5")]
		[FieldOffset(Offset = "0x60")]
		private CommonTopMenu m_topMenu;

		// Token: 0x040384C6 RID: 230598
		[Token(Token = "0x40384C6")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isAnimPlaying;

		// Token: 0x040384C7 RID: 230599
		[Token(Token = "0x40384C7")]
		[FieldOffset(Offset = "0x6C")]
		private int m_runningAnimCount;

		// Token: 0x040384C8 RID: 230600
		[Token(Token = "0x40384C8")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isBindToParent;

		// Token: 0x040384C9 RID: 230601
		[Token(Token = "0x40384C9")]
		[FieldOffset(Offset = "0x78")]
		private TemplateActivityController.AVGResetToActEntryCommandExecutor m_resetToEntryCmdExecutor;

		// Token: 0x040384CA RID: 230602
		[Token(Token = "0x40384CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040384CB RID: 230603
		[Token(Token = "0x40384CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateBindToParentStatus;

		// Token: 0x040384CC RID: 230604
		[Token(Token = "0x40384CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x040384CD RID: 230605
		[Token(Token = "0x40384CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBindToParent;

		// Token: 0x040384CE RID: 230606
		[Token(Token = "0x40384CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPageResumed;

		// Token: 0x040384CF RID: 230607
		[Token(Token = "0x40384CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040384D0 RID: 230608
		[Token(Token = "0x40384D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isAnimPlaying;

		// Token: 0x040384D1 RID: 230609
		[Token(Token = "0x40384D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckAllFinish;

		// Token: 0x040384D2 RID: 230610
		[Token(Token = "0x40384D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DescreasePlayingCount;

		// Token: 0x040384D3 RID: 230611
		[Token(Token = "0x40384D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SampleAllAnimClipAtBegin;

		// Token: 0x040384D4 RID: 230612
		[Token(Token = "0x40384D4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayTargetAnim;

		// Token: 0x040384D5 RID: 230613
		[Token(Token = "0x40384D5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayWithAnim;

		// Token: 0x040384D6 RID: 230614
		[Token(Token = "0x40384D6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryTriggerAVG;

		// Token: 0x040384D7 RID: 230615
		[Token(Token = "0x40384D7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnVideoStoryCompleted;

		// Token: 0x040384D8 RID: 230616
		[Token(Token = "0x40384D8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryStartAnim;

		// Token: 0x040384D9 RID: 230617
		[Token(Token = "0x40384D9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryTrigTutorial;

		// Token: 0x040384DA RID: 230618
		[Token(Token = "0x40384DA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryTrigTutorialOnResume;

		// Token: 0x040384DB RID: 230619
		[Token(Token = "0x40384DB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryRegisterGOAndRaiseSignal;

		// Token: 0x040384DC RID: 230620
		[Token(Token = "0x40384DC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnMedalClicked;

		// Token: 0x040384DD RID: 230621
		[Token(Token = "0x40384DD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnUngroupedMedalClicked;

		// Token: 0x040384DE RID: 230622
		[Token(Token = "0x40384DE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnZoneClicked;

		// Token: 0x040384DF RID: 230623
		[Token(Token = "0x40384DF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RealEventOnZoneClicked;

		// Token: 0x040384E0 RID: 230624
		[Token(Token = "0x40384E0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnReplayEntryAVG;

		// Token: 0x040384E1 RID: 230625
		[Token(Token = "0x40384E1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnShopClicked;

		// Token: 0x040384E2 RID: 230626
		[Token(Token = "0x40384E2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnReplicateClicked;

		// Token: 0x040384E3 RID: 230627
		[Token(Token = "0x40384E3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x040384E4 RID: 230628
		[Token(Token = "0x40384E4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x040384E5 RID: 230629
		[Token(Token = "0x40384E5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CB4 RID: 27828
		[Token(Token = "0x2006CB4")]
		[Serializable]
		private class EntryAnim
		{
			// Token: 0x06027B61 RID: 162657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B61")]
			[Address(RVA = "0xFEA040", Offset = "0xFE8C40", VA = "0x180FEA040")]
			public EntryAnim()
			{
			}

			// Token: 0x040384E6 RID: 230630
			[Token(Token = "0x40384E6")]
			[FieldOffset(Offset = "0x10")]
			public UIAnimationLocation animLocaction;

			// Token: 0x040384E7 RID: 230631
			[Token(Token = "0x40384E7")]
			[FieldOffset(Offset = "0x20")]
			public TemplateActivityEntry.EntryAnim.AnimType animType;

			// Token: 0x040384E8 RID: 230632
			[Token(Token = "0x40384E8")]
			[FieldOffset(Offset = "0x24")]
			public bool skipAble;

			// Token: 0x040384E9 RID: 230633
			[Token(Token = "0x40384E9")]
			[FieldOffset(Offset = "0x28")]
			public Ease ease;

			// Token: 0x040384EA RID: 230634
			[Token(Token = "0x40384EA")]
			[FieldOffset(Offset = "0x2C")]
			public float delayDurationSec;

			// Token: 0x040384EB RID: 230635
			[Token(Token = "0x40384EB")]
			[FieldOffset(Offset = "0x30")]
			public float skipOffset;

			// Token: 0x040384EC RID: 230636
			[Token(Token = "0x40384EC")]
			[FieldOffset(Offset = "0x34")]
			public bool enableEvents;

			// Token: 0x02006CB5 RID: 27829
			[Token(Token = "0x2006CB5")]
			[Serializable]
			public enum AnimType
			{
				// Token: 0x040384EE RID: 230638
				[Token(Token = "0x40384EE")]
				LOOP,
				// Token: 0x040384EF RID: 230639
				[Token(Token = "0x40384EF")]
				ENTRY
			}
		}
	}
}
