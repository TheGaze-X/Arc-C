using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004851 RID: 18513
	[Token(Token = "0x2004851")]
	public class MissionArchivePlayer : IHotfixable
	{
		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0601BF6D RID: 114541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF6E RID: 114542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700426C")]
		public Text subTitleText
		{
			[Token(Token = "0x601BF6D")]
			[Address(RVA = "0x1554710", Offset = "0x1553310", VA = "0x181554710")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF6E")]
			[Address(RVA = "0x1554A70", Offset = "0x1553670", VA = "0x181554A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0601BF6F RID: 114543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF70 RID: 114544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700426D")]
		public CanvasGroup subTitleGroup
		{
			[Token(Token = "0x601BF6F")]
			[Address(RVA = "0x15546B0", Offset = "0x15532B0", VA = "0x1815546B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF70")]
			[Address(RVA = "0x15549F0", Offset = "0x15535F0", VA = "0x1815549F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0601BF71 RID: 114545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF72 RID: 114546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700426E")]
		public List<CanvasGroup> playGroups
		{
			[Token(Token = "0x601BF71")]
			[Address(RVA = "0x15545F0", Offset = "0x15531F0", VA = "0x1815545F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF72")]
			[Address(RVA = "0x15548F0", Offset = "0x15534F0", VA = "0x1815548F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0601BF73 RID: 114547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF74 RID: 114548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700426F")]
		public CanvasGroup hiddenPlayGroup
		{
			[Token(Token = "0x601BF73")]
			[Address(RVA = "0x1554590", Offset = "0x1553190", VA = "0x181554590")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF74")]
			[Address(RVA = "0x1554870", Offset = "0x1553470", VA = "0x181554870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0601BF75 RID: 114549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF76 RID: 114550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004270")]
		public CanvasGroup replayGroup
		{
			[Token(Token = "0x601BF75")]
			[Address(RVA = "0x1554650", Offset = "0x1553250", VA = "0x181554650")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF76")]
			[Address(RVA = "0x1554970", Offset = "0x1553570", VA = "0x181554970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x0601BF77 RID: 114551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF78 RID: 114552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004271")]
		public MissionArchiveExteriorPlayer exteriorPlayer
		{
			[Token(Token = "0x601BF77")]
			[Address(RVA = "0x1554530", Offset = "0x1553130", VA = "0x181554530")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF78")]
			[Address(RVA = "0x15547F0", Offset = "0x15533F0", VA = "0x1815547F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x0601BF79 RID: 114553 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF7A RID: 114554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004272")]
		public string audioFxOnPlayEnd
		{
			[Token(Token = "0x601BF79")]
			[Address(RVA = "0x15544D0", Offset = "0x15530D0", VA = "0x1815544D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF7A")]
			[Address(RVA = "0x1554770", Offset = "0x1553370", VA = "0x181554770")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BF7B RID: 114555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF7B")]
		[Address(RVA = "0x1553270", Offset = "0x1551E70", VA = "0x181553270")]
		public void Reset()
		{
		}

		// Token: 0x0601BF7C RID: 114556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF7C")]
		[Address(RVA = "0x1552F30", Offset = "0x1551B30", VA = "0x181552F30")]
		public void Play(List<MissionArchiveVoiceClipViewModel> clips, bool isHidden)
		{
		}

		// Token: 0x0601BF7D RID: 114557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF7D")]
		[Address(RVA = "0x1553560", Offset = "0x1552160", VA = "0x181553560")]
		public void Stop()
		{
		}

		// Token: 0x0601BF7E RID: 114558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF7E")]
		[Address(RVA = "0x15538E0", Offset = "0x15524E0", VA = "0x1815538E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BF7F RID: 114559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF7F")]
		[Address(RVA = "0x1553C60", Offset = "0x1552860", VA = "0x181553C60")]
		private void _PlayClipIfCan()
		{
		}

		// Token: 0x0601BF80 RID: 114560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF80")]
		[Address(RVA = "0x1554040", Offset = "0x1552C40", VA = "0x181554040")]
		private void _StopInProgress()
		{
		}

		// Token: 0x0601BF81 RID: 114561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF81")]
		[Address(RVA = "0x1554340", Offset = "0x1552F40", VA = "0x181554340")]
		private void _StopSubtitleTweenIfNeed()
		{
		}

		// Token: 0x0601BF82 RID: 114562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF82")]
		[Address(RVA = "0x15543C0", Offset = "0x1552FC0", VA = "0x1815543C0")]
		public MissionArchivePlayer()
		{
		}

		// Token: 0x04024775 RID: 149365
		[Token(Token = "0x4024775")]
		private const float SUB_TITLE_FADE_TIME = 0.16f;

		// Token: 0x04024776 RID: 149366
		[Token(Token = "0x4024776")]
		private const float SUB_TITLE_FALLBACK_DURATION = 3f;

		// Token: 0x0402477E RID: 149374
		[Token(Token = "0x402477E")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402477F RID: 149375
		[Token(Token = "0x402477F")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<FadeSwitchTween> m_playSwitchTweens;

		// Token: 0x04024780 RID: 149376
		[Token(Token = "0x4024780")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_hiddenPlaySwitchTween;

		// Token: 0x04024781 RID: 149377
		[Token(Token = "0x4024781")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_replaySwitchTween;

		// Token: 0x04024782 RID: 149378
		[Token(Token = "0x4024782")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isPlaying;

		// Token: 0x04024783 RID: 149379
		[Token(Token = "0x4024783")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_playSequence;

		// Token: 0x04024784 RID: 149380
		[Token(Token = "0x4024784")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<MissionArchiveVoiceClipViewModel> m_playingClips;

		// Token: 0x04024785 RID: 149381
		[Token(Token = "0x4024785")]
		[FieldOffset(Offset = "0x80")]
		private int m_playingIndex;

		// Token: 0x04024786 RID: 149382
		[Token(Token = "0x4024786")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_subTitleText;

		// Token: 0x04024787 RID: 149383
		[Token(Token = "0x4024787")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_subTitleText;

		// Token: 0x04024788 RID: 149384
		[Token(Token = "0x4024788")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_subTitleGroup;

		// Token: 0x04024789 RID: 149385
		[Token(Token = "0x4024789")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_subTitleGroup;

		// Token: 0x0402478A RID: 149386
		[Token(Token = "0x402478A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_playGroups;

		// Token: 0x0402478B RID: 149387
		[Token(Token = "0x402478B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_playGroups;

		// Token: 0x0402478C RID: 149388
		[Token(Token = "0x402478C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hiddenPlayGroup;

		// Token: 0x0402478D RID: 149389
		[Token(Token = "0x402478D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_hiddenPlayGroup;

		// Token: 0x0402478E RID: 149390
		[Token(Token = "0x402478E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_replayGroup;

		// Token: 0x0402478F RID: 149391
		[Token(Token = "0x402478F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_replayGroup;

		// Token: 0x04024790 RID: 149392
		[Token(Token = "0x4024790")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_exteriorPlayer;

		// Token: 0x04024791 RID: 149393
		[Token(Token = "0x4024791")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_exteriorPlayer;

		// Token: 0x04024792 RID: 149394
		[Token(Token = "0x4024792")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_audioFxOnPlayEnd;

		// Token: 0x04024793 RID: 149395
		[Token(Token = "0x4024793")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_audioFxOnPlayEnd;

		// Token: 0x04024794 RID: 149396
		[Token(Token = "0x4024794")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04024795 RID: 149397
		[Token(Token = "0x4024795")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04024796 RID: 149398
		[Token(Token = "0x4024796")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04024797 RID: 149399
		[Token(Token = "0x4024797")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024798 RID: 149400
		[Token(Token = "0x4024798")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayClipIfCan;

		// Token: 0x04024799 RID: 149401
		[Token(Token = "0x4024799")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__StopInProgress;

		// Token: 0x0402479A RID: 149402
		[Token(Token = "0x402479A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__StopSubtitleTweenIfNeed;

		// Token: 0x0402479B RID: 149403
		[Token(Token = "0x402479B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
