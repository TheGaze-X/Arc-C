using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FDE RID: 20446
	[Token(Token = "0x2004FDE")]
	public class EnemyDuelEmoticonController : EmoticonPagerPanelBaseController
	{
		// Token: 0x0601E5AF RID: 124335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5AF")]
		[Address(RVA = "0x1818050", Offset = "0x1816C50", VA = "0x181818050")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x0601E5B0 RID: 124336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E5B1 RID: 124337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046F6")]
		public StateEngine bindStateEngine
		{
			[Token(Token = "0x601E5B0")]
			[Address(RVA = "0x18185E0", Offset = "0x18171E0", VA = "0x1818185E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E5B1")]
			[Address(RVA = "0x1818640", Offset = "0x1817240", VA = "0x181818640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E5B2 RID: 124338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5B2")]
		[Address(RVA = "0x1817D70", Offset = "0x1816970", VA = "0x181817D70")]
		public void OnShowEmoticonPanel()
		{
		}

		// Token: 0x0601E5B3 RID: 124339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5B3")]
		[Address(RVA = "0x1818130", Offset = "0x1816D30", VA = "0x181818130", Slot = "8")]
		protected override void _OnSendEmoji(string themeId, string emojiItem)
		{
		}

		// Token: 0x0601E5B4 RID: 124340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5B4")]
		[Address(RVA = "0x1817CF0", Offset = "0x18168F0", VA = "0x181817CF0")]
		public void OnBtnCloseEmoticonClicked()
		{
		}

		// Token: 0x0601E5B5 RID: 124341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5B5")]
		[Address(RVA = "0x1818580", Offset = "0x1817180", VA = "0x181818580")]
		public EnemyDuelEmoticonController()
		{
		}

		// Token: 0x04028972 RID: 166258
		[Token(Token = "0x4028972")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028973 RID: 166259
		[Token(Token = "0x4028973")]
		[FieldOffset(Offset = "0x78")]
		private float m_chatCd;

		// Token: 0x04028974 RID: 166260
		[Token(Token = "0x4028974")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_inited;

		// Token: 0x04028975 RID: 166261
		[Token(Token = "0x4028975")]
		[FieldOffset(Offset = "0x80")]
		private EnemyDuelBattleCoolDownController m_coolDownController;

		// Token: 0x04028977 RID: 166263
		[Token(Token = "0x4028977")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028978 RID: 166264
		[Token(Token = "0x4028978")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bindStateEngine;

		// Token: 0x04028979 RID: 166265
		[Token(Token = "0x4028979")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_bindStateEngine;

		// Token: 0x0402897A RID: 166266
		[Token(Token = "0x402897A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShowEmoticonPanel;

		// Token: 0x0402897B RID: 166267
		[Token(Token = "0x402897B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSendEmoji;

		// Token: 0x0402897C RID: 166268
		[Token(Token = "0x402897C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnCloseEmoticonClicked;

		// Token: 0x0402897D RID: 166269
		[Token(Token = "0x402897D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FDF RID: 20447
		[Token(Token = "0x2004FDF")]
		public class EmoticonParam
		{
			// Token: 0x0601E5B6 RID: 124342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EmoticonParam()
			{
			}

			// Token: 0x0402897E RID: 166270
			[Token(Token = "0x402897E")]
			[FieldOffset(Offset = "0x10")]
			public string themeId;

			// Token: 0x0402897F RID: 166271
			[Token(Token = "0x402897F")]
			[FieldOffset(Offset = "0x18")]
			public string emoticonId;
		}

		// Token: 0x02004FE0 RID: 20448
		[Token(Token = "0x2004FE0")]
		public class EmoticonConfig : IEmoticonCustomConfig, IHotfixable
		{
			// Token: 0x0601E5B7 RID: 124343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E5B7")]
			[Address(RVA = "0x180EF40", Offset = "0x180DB40", VA = "0x18180EF40", Slot = "4")]
			public string GetFocusEmoticonThemeId(ValueBundle vb)
			{
				return null;
			}

			// Token: 0x0601E5B8 RID: 124344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5B8")]
			[Address(RVA = "0x180F1E0", Offset = "0x180DDE0", VA = "0x18180F1E0", Slot = "5")]
			public void SaveSendEmoticonThemeId(ValueBundle vb, string themeId)
			{
			}

			// Token: 0x0601E5B9 RID: 124345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E5B9")]
			[Address(RVA = "0x180EE80", Offset = "0x180DA80", VA = "0x18180EE80", Slot = "6")]
			public List<string> GetEnabledEmoticonList(ValueBundle vb)
			{
				return null;
			}

			// Token: 0x0601E5BA RID: 124346 RVA: 0x000AE438 File Offset: 0x000AC638
			[Token(Token = "0x601E5BA")]
			[Address(RVA = "0x180F180", Offset = "0x180DD80", VA = "0x18180F180", Slot = "7")]
			public bool KeepEmoticonPanelAfterClick()
			{
				return default(bool);
			}

			// Token: 0x0601E5BB RID: 124347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5BB")]
			[Address(RVA = "0x180F2D0", Offset = "0x180DED0", VA = "0x18180F2D0")]
			public EmoticonConfig()
			{
			}

			// Token: 0x04028980 RID: 166272
			[Token(Token = "0x4028980")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetFocusEmoticonThemeId;

			// Token: 0x04028981 RID: 166273
			[Token(Token = "0x4028981")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SaveSendEmoticonThemeId;

			// Token: 0x04028982 RID: 166274
			[Token(Token = "0x4028982")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetEnabledEmoticonList;

			// Token: 0x04028983 RID: 166275
			[Token(Token = "0x4028983")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_KeepEmoticonPanelAfterClick;

			// Token: 0x04028984 RID: 166276
			[Token(Token = "0x4028984")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
