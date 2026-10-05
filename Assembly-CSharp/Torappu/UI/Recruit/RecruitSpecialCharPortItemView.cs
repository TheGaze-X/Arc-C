using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200474A RID: 18250
	[Token(Token = "0x200474A")]
	public class RecruitSpecialCharPortItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA3F RID: 113215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA3F")]
		[Address(RVA = "0x1504760", Offset = "0x1503360", VA = "0x181504760")]
		public void Render(string charId)
		{
		}

		// Token: 0x0601BA40 RID: 113216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA40")]
		[Address(RVA = "0x1504A00", Offset = "0x1503600", VA = "0x181504A00")]
		public RecruitSpecialCharPortItemView()
		{
		}

		// Token: 0x04023DBD RID: 146877
		[Token(Token = "0x4023DBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgPortrait;

		// Token: 0x04023DBE RID: 146878
		[Token(Token = "0x4023DBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBackSquare;

		// Token: 0x04023DBF RID: 146879
		[Token(Token = "0x4023DBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x04023DC0 RID: 146880
		[Token(Token = "0x4023DC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DC1 RID: 146881
		[Token(Token = "0x4023DC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
