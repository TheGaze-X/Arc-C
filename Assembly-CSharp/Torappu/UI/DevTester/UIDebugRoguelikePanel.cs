using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x02005102 RID: 20738
	[Token(Token = "0x2005102")]
	public class UIDebugRoguelikePanel : MonoBehaviour
	{
		// Token: 0x0601EA18 RID: 125464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA18")]
		[Address(RVA = "0x1865490", Offset = "0x1864090", VA = "0x181865490")]
		public UIDebugRoguelikePanel()
		{
		}

		// Token: 0x0402911D RID: 168221
		[Token(Token = "0x402911D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dropdown dropDownListTheme;

		// Token: 0x0402911E RID: 168222
		[Token(Token = "0x402911E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown dropDownList;

		// Token: 0x0402911F RID: 168223
		[Token(Token = "0x402911F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField _input1;

		// Token: 0x04029120 RID: 168224
		[Token(Token = "0x4029120")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField _input2;

		// Token: 0x04029121 RID: 168225
		[Token(Token = "0x4029121")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField _input3;

		// Token: 0x04029122 RID: 168226
		[Token(Token = "0x4029122")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<UIDebugRoguelikePanel.ThemeParam> _themeList;

		// Token: 0x04029123 RID: 168227
		[Token(Token = "0x4029123")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<UIDebugRoguelikePanel.CheatParam> _cheatOrderList;

		// Token: 0x04029124 RID: 168228
		[Token(Token = "0x4029124")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04029125 RID: 168229
		[Token(Token = "0x4029125")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _actId;

		// Token: 0x04029126 RID: 168230
		[Token(Token = "0x4029126")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private InputField _retroId;

		// Token: 0x04029127 RID: 168231
		[Token(Token = "0x4029127")]
		[FieldOffset(Offset = "0x68")]
		private UIDebugRoguelikePanel.ThemeParam m_cachedThemeParam;

		// Token: 0x04029128 RID: 168232
		[Token(Token = "0x4029128")]
		[FieldOffset(Offset = "0x70")]
		private List<UIDebugRoguelikePanel.CheatParam> m_cachedCheatList;

		// Token: 0x04029129 RID: 168233
		[Token(Token = "0x4029129")]
		[FieldOffset(Offset = "0x78")]
		private UIDebugRoguelikePanel.CheatParam m_cacheCheat;

		// Token: 0x02005103 RID: 20739
		[Token(Token = "0x2005103")]
		[Flags]
		public enum RoguelikeTheme
		{
			// Token: 0x0402912B RID: 168235
			[Token(Token = "0x402912B")]
			ROGUE_1 = 1,
			// Token: 0x0402912C RID: 168236
			[Token(Token = "0x402912C")]
			ROGUE_2 = 2,
			// Token: 0x0402912D RID: 168237
			[Token(Token = "0x402912D")]
			ROGUE_3 = 4,
			// Token: 0x0402912E RID: 168238
			[Token(Token = "0x402912E")]
			ROGUE_4 = 8,
			// Token: 0x0402912F RID: 168239
			[Token(Token = "0x402912F")]
			ROGUE_5 = 16,
			// Token: 0x04029130 RID: 168240
			[Token(Token = "0x4029130")]
			ALL = 31
		}

		// Token: 0x02005104 RID: 20740
		[Token(Token = "0x2005104")]
		[Serializable]
		public class ThemeParam
		{
			// Token: 0x0601EA19 RID: 125465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA19")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ThemeParam()
			{
			}

			// Token: 0x04029131 RID: 168241
			[Token(Token = "0x4029131")]
			[FieldOffset(Offset = "0x10")]
			public string theme;

			// Token: 0x04029132 RID: 168242
			[Token(Token = "0x4029132")]
			[FieldOffset(Offset = "0x18")]
			public UIDebugRoguelikePanel.RoguelikeTheme themeType;
		}

		// Token: 0x02005105 RID: 20741
		[Token(Token = "0x2005105")]
		[Serializable]
		public class CheatParam : ISearchFilterable
		{
			// Token: 0x0601EA1A RID: 125466 RVA: 0x000AF218 File Offset: 0x000AD418
			[Token(Token = "0x601EA1A")]
			[Address(RVA = "0x184F2A0", Offset = "0x184DEA0", VA = "0x18184F2A0", Slot = "4")]
			public bool IsMatch(string searchString)
			{
				return default(bool);
			}

			// Token: 0x0601EA1B RID: 125467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA1B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CheatParam()
			{
			}

			// Token: 0x04029133 RID: 168243
			[Token(Token = "0x4029133")]
			[FieldOffset(Offset = "0x10")]
			public UIDebugRoguelikePanel.RoguelikeTheme theme;

			// Token: 0x04029134 RID: 168244
			[Token(Token = "0x4029134")]
			[FieldOffset(Offset = "0x18")]
			public string cheatOrder;

			// Token: 0x04029135 RID: 168245
			[Token(Token = "0x4029135")]
			[FieldOffset(Offset = "0x20")]
			public string desc;

			// Token: 0x04029136 RID: 168246
			[Token(Token = "0x4029136")]
			[FieldOffset(Offset = "0x28")]
			public string detailDesc;

			// Token: 0x04029137 RID: 168247
			[Token(Token = "0x4029137")]
			[FieldOffset(Offset = "0x30")]
			public bool cheatParam1IsTheme;

			// Token: 0x04029138 RID: 168248
			[Token(Token = "0x4029138")]
			[FieldOffset(Offset = "0x38")]
			public string cheatParam1;

			// Token: 0x04029139 RID: 168249
			[Token(Token = "0x4029139")]
			[FieldOffset(Offset = "0x40")]
			public string param1DefaultValue;

			// Token: 0x0402913A RID: 168250
			[Token(Token = "0x402913A")]
			[FieldOffset(Offset = "0x48")]
			public bool cheatParam2IsTheme;

			// Token: 0x0402913B RID: 168251
			[Token(Token = "0x402913B")]
			[FieldOffset(Offset = "0x50")]
			public string cheatParam2;

			// Token: 0x0402913C RID: 168252
			[Token(Token = "0x402913C")]
			[FieldOffset(Offset = "0x58")]
			public string param2DefaultValue;

			// Token: 0x0402913D RID: 168253
			[Token(Token = "0x402913D")]
			[FieldOffset(Offset = "0x60")]
			public bool cheatParam3IsTheme;

			// Token: 0x0402913E RID: 168254
			[Token(Token = "0x402913E")]
			[FieldOffset(Offset = "0x68")]
			public string cheatParam3;

			// Token: 0x0402913F RID: 168255
			[Token(Token = "0x402913F")]
			[FieldOffset(Offset = "0x70")]
			public string param3DefaultValue;
		}
	}
}
