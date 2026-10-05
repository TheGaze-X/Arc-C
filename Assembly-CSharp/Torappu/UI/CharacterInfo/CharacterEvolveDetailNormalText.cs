using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F49 RID: 24393
	[Token(Token = "0x2005F49")]
	public class CharacterEvolveDetailNormalText : CharacterEvolveDetailCommon
	{
		// Token: 0x0602352E RID: 144686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602352E")]
		[Address(RVA = "0x1DD4730", Offset = "0x1DD3330", VA = "0x181DD4730")]
		public void Render(string title, string content)
		{
		}

		// Token: 0x0602352F RID: 144687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602352F")]
		[Address(RVA = "0x1DD48E0", Offset = "0x1DD34E0", VA = "0x181DD48E0")]
		public CharacterEvolveDetailNormalText()
		{
		}

		// Token: 0x04030BD8 RID: 199640
		[Token(Token = "0x4030BD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04030BD9 RID: 199641
		[Token(Token = "0x4030BD9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _contentText;

		// Token: 0x04030BDA RID: 199642
		[Token(Token = "0x4030BDA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _contentText_fact;

		// Token: 0x04030BDB RID: 199643
		[Token(Token = "0x4030BDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030BDC RID: 199644
		[Token(Token = "0x4030BDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
