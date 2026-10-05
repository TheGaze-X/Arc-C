using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200474D RID: 18253
	[Token(Token = "0x200474D")]
	public class RecruitUpCharDetailPortraitObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA46 RID: 113222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA46")]
		[Address(RVA = "0x1505090", Offset = "0x1503C90", VA = "0x181505090")]
		public void Render(string charId, bool isLimit = false)
		{
		}

		// Token: 0x0601BA47 RID: 113223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA47")]
		[Address(RVA = "0x15053D0", Offset = "0x1503FD0", VA = "0x1815053D0")]
		public RecruitUpCharDetailPortraitObj()
		{
		}

		// Token: 0x04023DCE RID: 146894
		[Token(Token = "0x4023DCE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _portraitIcon;

		// Token: 0x04023DCF RID: 146895
		[Token(Token = "0x4023DCF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backSquare;

		// Token: 0x04023DD0 RID: 146896
		[Token(Token = "0x4023DD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04023DD1 RID: 146897
		[Token(Token = "0x4023DD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLimited;

		// Token: 0x04023DD2 RID: 146898
		[Token(Token = "0x4023DD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _isLimitFlag;

		// Token: 0x04023DD3 RID: 146899
		[Token(Token = "0x4023DD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DD4 RID: 146900
		[Token(Token = "0x4023DD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
