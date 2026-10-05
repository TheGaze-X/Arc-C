using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050F4 RID: 20724
	[Token(Token = "0x20050F4")]
	public class UIDebugAutoChessPanel : MonoBehaviour
	{
		// Token: 0x0601EA06 RID: 125446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA06")]
		[Address(RVA = "0x1865290", Offset = "0x1863E90", VA = "0x181865290")]
		public UIDebugAutoChessPanel()
		{
		}

		// Token: 0x040290C9 RID: 168137
		[Token(Token = "0x40290C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dropdown _dropDownListAct;

		// Token: 0x040290CA RID: 168138
		[Token(Token = "0x40290CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown _dropDownList;

		// Token: 0x040290CB RID: 168139
		[Token(Token = "0x40290CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField _input1;

		// Token: 0x040290CC RID: 168140
		[Token(Token = "0x40290CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField _input2;

		// Token: 0x040290CD RID: 168141
		[Token(Token = "0x40290CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField _input3;

		// Token: 0x040290CE RID: 168142
		[Token(Token = "0x40290CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<UIDebugAutoChessPanel.CheatParam> _cheatOrderList;

		// Token: 0x040290CF RID: 168143
		[Token(Token = "0x40290CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x040290D0 RID: 168144
		[Token(Token = "0x40290D0")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedActId;

		// Token: 0x040290D1 RID: 168145
		[Token(Token = "0x40290D1")]
		[FieldOffset(Offset = "0x58")]
		private List<UIDebugAutoChessPanel.CheatParam> m_cachedCheatList;

		// Token: 0x040290D2 RID: 168146
		[Token(Token = "0x40290D2")]
		[FieldOffset(Offset = "0x60")]
		private UIDebugAutoChessPanel.CheatParam m_cacheCheat;

		// Token: 0x020050F5 RID: 20725
		[Token(Token = "0x20050F5")]
		[Serializable]
		public class CheatParam : ISearchFilterable
		{
			// Token: 0x0601EA07 RID: 125447 RVA: 0x000AF200 File Offset: 0x000AD400
			[Token(Token = "0x601EA07")]
			[Address(RVA = "0x184F230", Offset = "0x184DE30", VA = "0x18184F230", Slot = "4")]
			public bool IsMatch(string searchString)
			{
				return default(bool);
			}

			// Token: 0x0601EA08 RID: 125448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA08")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CheatParam()
			{
			}

			// Token: 0x040290D3 RID: 168147
			[Token(Token = "0x40290D3")]
			[FieldOffset(Offset = "0x10")]
			public bool useAutoChessService;

			// Token: 0x040290D4 RID: 168148
			[Token(Token = "0x40290D4")]
			[FieldOffset(Offset = "0x18")]
			public string cheatOrder;

			// Token: 0x040290D5 RID: 168149
			[Token(Token = "0x40290D5")]
			[FieldOffset(Offset = "0x20")]
			public string desc;

			// Token: 0x040290D6 RID: 168150
			[Token(Token = "0x40290D6")]
			[FieldOffset(Offset = "0x28")]
			public string detailDesc;

			// Token: 0x040290D7 RID: 168151
			[Token(Token = "0x40290D7")]
			[FieldOffset(Offset = "0x30")]
			public bool cheatParam1IsActId;

			// Token: 0x040290D8 RID: 168152
			[Token(Token = "0x40290D8")]
			[FieldOffset(Offset = "0x38")]
			public string cheatParam1;

			// Token: 0x040290D9 RID: 168153
			[Token(Token = "0x40290D9")]
			[FieldOffset(Offset = "0x40")]
			public string param1DefaultValue;

			// Token: 0x040290DA RID: 168154
			[Token(Token = "0x40290DA")]
			[FieldOffset(Offset = "0x48")]
			public bool cheatParam2IsActId;

			// Token: 0x040290DB RID: 168155
			[Token(Token = "0x40290DB")]
			[FieldOffset(Offset = "0x50")]
			public string cheatParam2;

			// Token: 0x040290DC RID: 168156
			[Token(Token = "0x40290DC")]
			[FieldOffset(Offset = "0x58")]
			public string param2DefaultValue;

			// Token: 0x040290DD RID: 168157
			[Token(Token = "0x40290DD")]
			[FieldOffset(Offset = "0x60")]
			public bool cheatParam3IsActId;

			// Token: 0x040290DE RID: 168158
			[Token(Token = "0x40290DE")]
			[FieldOffset(Offset = "0x68")]
			public string cheatParam3;

			// Token: 0x040290DF RID: 168159
			[Token(Token = "0x40290DF")]
			[FieldOffset(Offset = "0x70")]
			public string param3DefaultValue;
		}
	}
}
