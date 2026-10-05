using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F4E RID: 24398
	[Token(Token = "0x2005F4E")]
	public class CharacterEvolveTextContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023544 RID: 144708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023544")]
		[Address(RVA = "0x1DD57D0", Offset = "0x1DD43D0", VA = "0x181DD57D0")]
		public void Render(CharacterInfoEvolveInfoViewModel viewModel)
		{
		}

		// Token: 0x06023545 RID: 144709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023545")]
		[Address(RVA = "0x1DD5F40", Offset = "0x1DD4B40", VA = "0x181DD5F40")]
		private void _InstAndRetext(string template, string value)
		{
		}

		// Token: 0x06023546 RID: 144710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023546")]
		[Address(RVA = "0x1DD6150", Offset = "0x1DD4D50", VA = "0x181DD6150")]
		public CharacterEvolveTextContainer()
		{
		}

		// Token: 0x04030BF6 RID: 199670
		[Token(Token = "0x4030BF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textObj;

		// Token: 0x04030BF7 RID: 199671
		[Token(Token = "0x4030BF7")]
		[FieldOffset(Offset = "0x20")]
		private List<Text> m_textList;

		// Token: 0x04030BF8 RID: 199672
		[Token(Token = "0x4030BF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030BF9 RID: 199673
		[Token(Token = "0x4030BF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InstAndRetext;

		// Token: 0x04030BFA RID: 199674
		[Token(Token = "0x4030BFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
