using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F0 RID: 25840
	[Token(Token = "0x20064F0")]
	public class AutoChessEmojiController : EmoticonPagerPanelBaseController
	{
		// Token: 0x06025222 RID: 152098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025222")]
		[Address(RVA = "0x2023C00", Offset = "0x2022800", VA = "0x182023C00", Slot = "8")]
		protected override void _OnSendEmoji(string themeId, string emojiItem)
		{
		}

		// Token: 0x06025223 RID: 152099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025223")]
		[Address(RVA = "0x2023E00", Offset = "0x2022A00", VA = "0x182023E00")]
		public AutoChessEmojiController()
		{
		}

		// Token: 0x040340F4 RID: 213236
		[Token(Token = "0x40340F4")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040340F5 RID: 213237
		[Token(Token = "0x40340F5")]
		[FieldOffset(Offset = "0x78")]
		private AutoChessChatData m_tempEmojiData;

		// Token: 0x040340F6 RID: 213238
		[Token(Token = "0x40340F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnSendEmoji;

		// Token: 0x040340F7 RID: 213239
		[Token(Token = "0x40340F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064F1 RID: 25841
		[Token(Token = "0x20064F1")]
		public class EmojiConfig : IEmoticonCustomConfig, IHotfixable
		{
			// Token: 0x06025224 RID: 152100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025224")]
			[Address(RVA = "0x2025820", Offset = "0x2024420", VA = "0x182025820", Slot = "4")]
			public string GetFocusEmoticonThemeId(ValueBundle vb)
			{
				return null;
			}

			// Token: 0x06025225 RID: 152101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025225")]
			[Address(RVA = "0x2025A40", Offset = "0x2024640", VA = "0x182025A40", Slot = "5")]
			public void SaveSendEmoticonThemeId(ValueBundle vb, string themeId)
			{
			}

			// Token: 0x06025226 RID: 152102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025226")]
			[Address(RVA = "0x2025770", Offset = "0x2024370", VA = "0x182025770", Slot = "6")]
			public List<string> GetEnabledEmoticonList(ValueBundle vb)
			{
				return null;
			}

			// Token: 0x06025227 RID: 152103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025227")]
			[Address(RVA = "0x2025B30", Offset = "0x2024730", VA = "0x182025B30")]
			public EmojiConfig()
			{
			}

			// Token: 0x040340F8 RID: 213240
			[Token(Token = "0x40340F8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetFocusEmoticonThemeId;

			// Token: 0x040340F9 RID: 213241
			[Token(Token = "0x40340F9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SaveSendEmoticonThemeId;

			// Token: 0x040340FA RID: 213242
			[Token(Token = "0x40340FA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetEnabledEmoticonList;

			// Token: 0x040340FB RID: 213243
			[Token(Token = "0x40340FB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
