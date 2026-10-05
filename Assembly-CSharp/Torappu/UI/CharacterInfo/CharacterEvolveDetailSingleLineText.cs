using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F4A RID: 24394
	[Token(Token = "0x2005F4A")]
	public class CharacterEvolveDetailSingleLineText : CharacterEvolveDetailCommon
	{
		// Token: 0x06023530 RID: 144688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023530")]
		[Address(RVA = "0x1DD4980", Offset = "0x1DD3580", VA = "0x181DD4980")]
		public void Render(string content)
		{
		}

		// Token: 0x06023531 RID: 144689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023531")]
		[Address(RVA = "0x1DD4AF0", Offset = "0x1DD36F0", VA = "0x181DD4AF0")]
		public CharacterEvolveDetailSingleLineText()
		{
		}

		// Token: 0x04030BDD RID: 199645
		[Token(Token = "0x4030BDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _contentText;

		// Token: 0x04030BDE RID: 199646
		[Token(Token = "0x4030BDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommentedText _contentText_fact;

		// Token: 0x04030BDF RID: 199647
		[Token(Token = "0x4030BDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030BE0 RID: 199648
		[Token(Token = "0x4030BE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
