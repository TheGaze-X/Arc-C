using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C6E RID: 19566
	[Token(Token = "0x2004C6E")]
	public class HomeThemeApplier : UIStylerApplier<HomeTheme>
	{
		// Token: 0x0601D596 RID: 120214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D596")]
		[Address(RVA = "0x16E4950", Offset = "0x16E3550", VA = "0x1816E4950")]
		private void _TryInitDefaultElmData()
		{
		}

		// Token: 0x0601D597 RID: 120215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D597")]
		[Address(RVA = "0x16E41F0", Offset = "0x16E2DF0", VA = "0x1816E41F0", Slot = "18")]
		protected override void OnApplyStyle(HomeTheme theme)
		{
		}

		// Token: 0x0601D598 RID: 120216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D598")]
		[Address(RVA = "0x16E48C0", Offset = "0x16E34C0", VA = "0x1816E48C0")]
		private IHomeThemeElemBase[] _GetAllElements()
		{
			return null;
		}

		// Token: 0x0601D599 RID: 120217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D599")]
		[Address(RVA = "0x16E4CC0", Offset = "0x16E38C0", VA = "0x1816E4CC0")]
		public HomeThemeApplier()
		{
		}

		// Token: 0x040269C1 RID: 158145
		[Token(Token = "0x40269C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<float> _heightList;

		// Token: 0x040269C2 RID: 158146
		[Token(Token = "0x40269C2")]
		[FieldOffset(Offset = "0x28")]
		private string m_elementsPropName;

		// Token: 0x040269C3 RID: 158147
		[Token(Token = "0x40269C3")]
		[FieldOffset(Offset = "0x30")]
		private string m_namePropName;

		// Token: 0x040269C4 RID: 158148
		[Token(Token = "0x40269C4")]
		[FieldOffset(Offset = "0x38")]
		private IHomeThemeElemBase[] m_elements;

		// Token: 0x040269C5 RID: 158149
		[Token(Token = "0x40269C5")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, JObject> m_elmDataDic;

		// Token: 0x040269C6 RID: 158150
		[Token(Token = "0x40269C6")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, JObject> m_defaultElmDataDic;

		// Token: 0x040269C7 RID: 158151
		[Token(Token = "0x40269C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TryInitDefaultElmData;

		// Token: 0x040269C8 RID: 158152
		[Token(Token = "0x40269C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x040269C9 RID: 158153
		[Token(Token = "0x40269C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetAllElements;

		// Token: 0x040269CA RID: 158154
		[Token(Token = "0x40269CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
