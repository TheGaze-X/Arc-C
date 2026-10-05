using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200389E RID: 14494
	[Token(Token = "0x200389E")]
	public static class ViewPagerUtils
	{
		// Token: 0x06016F0C RID: 93964 RVA: 0x000940E0 File Offset: 0x000922E0
		[Token(Token = "0x6016F0C")]
		[Address(RVA = "0xF6C600", Offset = "0xF6B200", VA = "0x180F6C600")]
		public static ViewPagerUtils.ScrollEffectConfig ScrollEffectPlayGearAudio()
		{
			return default(ViewPagerUtils.ScrollEffectConfig);
		}

		// Token: 0x06016F0D RID: 93965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F0D")]
		[Address(RVA = "0xF6C730", Offset = "0xF6B330", VA = "0x180F6C730")]
		private static void _PlayAudioGear()
		{
		}

		// Token: 0x06016F0E RID: 93966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F0E")]
		[Address(RVA = "0xF6C6D0", Offset = "0xF6B2D0", VA = "0x180F6C6D0")]
		private static void _PlayAudioGearLock()
		{
		}

		// Token: 0x0200389F RID: 14495
		[Token(Token = "0x200389F")]
		public struct ScrollEffectConfig
		{
			// Token: 0x06016F0F RID: 93967 RVA: 0x000940F8 File Offset: 0x000922F8
			[Token(Token = "0x6016F0F")]
			[Address(RVA = "0xF5BCC0", Offset = "0xF5A8C0", VA = "0x180F5BCC0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0401BAF4 RID: 113396
			[Token(Token = "0x401BAF4")]
			[FieldOffset(Offset = "0x0")]
			public Action onScrollToItem;

			// Token: 0x0401BAF5 RID: 113397
			[Token(Token = "0x401BAF5")]
			[FieldOffset(Offset = "0x8")]
			public Action onAlignedToItem;

			// Token: 0x0401BAF6 RID: 113398
			[Token(Token = "0x401BAF6")]
			[FieldOffset(Offset = "0x10")]
			public float minScrollInterval;

			// Token: 0x0401BAF7 RID: 113399
			[Token(Token = "0x401BAF7")]
			[FieldOffset(Offset = "0x14")]
			public ViewPagerUtils.ScrollEffectConfig.Timing timing;

			// Token: 0x020038A0 RID: 14496
			[Token(Token = "0x20038A0")]
			public enum Timing
			{
				// Token: 0x0401BAF9 RID: 113401
				[Token(Token = "0x401BAF9")]
				HALF_VALUE,
				// Token: 0x0401BAFA RID: 113402
				[Token(Token = "0x401BAFA")]
				FULL_VALUE
			}
		}

		// Token: 0x020038A1 RID: 14497
		[Token(Token = "0x20038A1")]
		public class ScrollEffectTrigger : IHotfixable
		{
			// Token: 0x06016F10 RID: 93968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F10")]
			[Address(RVA = "0xF5C090", Offset = "0xF5AC90", VA = "0x180F5C090")]
			public ScrollEffectTrigger(ViewPagerUtils.ScrollEffectConfig config)
			{
			}

			// Token: 0x06016F11 RID: 93969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F11")]
			[Address(RVA = "0xF5BDD0", Offset = "0xF5A9D0", VA = "0x180F5BDD0")]
			public void NotifyScrolling(float curIndex, float deltaTime)
			{
			}

			// Token: 0x06016F12 RID: 93970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F12")]
			[Address(RVA = "0xF5BCE0", Offset = "0xF5A8E0", VA = "0x180F5BCE0")]
			public void MarkHasScrolled()
			{
			}

			// Token: 0x06016F13 RID: 93971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F13")]
			[Address(RVA = "0xF5BD50", Offset = "0xF5A950", VA = "0x180F5BD50")]
			public void NotifyAlignFinish()
			{
			}

			// Token: 0x06016F14 RID: 93972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016F14")]
			[Address(RVA = "0xF5BFF0", Offset = "0xF5ABF0", VA = "0x180F5BFF0")]
			public void Reset(int curIndex)
			{
			}

			// Token: 0x0401BAFB RID: 113403
			[Token(Token = "0x401BAFB")]
			private const float DFT_MIN_INTERVAL = 0.1f;

			// Token: 0x0401BAFC RID: 113404
			[Token(Token = "0x401BAFC")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isValid;

			// Token: 0x0401BAFD RID: 113405
			[Token(Token = "0x401BAFD")]
			[FieldOffset(Offset = "0x18")]
			private ViewPagerUtils.ScrollEffectConfig m_config;

			// Token: 0x0401BAFE RID: 113406
			[Token(Token = "0x401BAFE")]
			[FieldOffset(Offset = "0x30")]
			private int m_lastFocusIndex;

			// Token: 0x0401BAFF RID: 113407
			[Token(Token = "0x401BAFF")]
			[FieldOffset(Offset = "0x34")]
			private float m_curTime;

			// Token: 0x0401BB00 RID: 113408
			[Token(Token = "0x401BB00")]
			[FieldOffset(Offset = "0x38")]
			private float m_lastScrollTime;

			// Token: 0x0401BB01 RID: 113409
			[Token(Token = "0x401BB01")]
			[FieldOffset(Offset = "0x3C")]
			private bool m_hasScrolled;

			// Token: 0x0401BB02 RID: 113410
			[Token(Token = "0x401BB02")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BB03 RID: 113411
			[Token(Token = "0x401BB03")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_NotifyScrolling;

			// Token: 0x0401BB04 RID: 113412
			[Token(Token = "0x401BB04")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_MarkHasScrolled;

			// Token: 0x0401BB05 RID: 113413
			[Token(Token = "0x401BB05")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyAlignFinish;

			// Token: 0x0401BB06 RID: 113414
			[Token(Token = "0x401BB06")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Reset;
		}
	}
}
