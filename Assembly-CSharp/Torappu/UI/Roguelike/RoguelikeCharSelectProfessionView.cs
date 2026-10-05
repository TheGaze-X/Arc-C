using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200549F RID: 21663
	[Token(Token = "0x200549F")]
	public class RoguelikeCharSelectProfessionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE05 RID: 130565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE05")]
		[Address(RVA = "0x19F28E0", Offset = "0x19F14E0", VA = "0x1819F28E0")]
		public void RenderView(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FE06 RID: 130566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE06")]
		[Address(RVA = "0x19F2C30", Offset = "0x19F1830", VA = "0x1819F2C30")]
		private void _LoadUniqEquip(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FE07 RID: 130567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE07")]
		[Address(RVA = "0x19F2D90", Offset = "0x19F1990", VA = "0x1819F2D90")]
		public RoguelikeCharSelectProfessionView()
		{
		}

		// Token: 0x0402AF85 RID: 176005
		[Token(Token = "0x402AF85")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x0402AF86 RID: 176006
		[Token(Token = "0x402AF86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommentedText _subProfDetailBasic;

		// Token: 0x0402AF87 RID: 176007
		[Token(Token = "0x402AF87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommentedText _subProfDetailAdditive;

		// Token: 0x0402AF88 RID: 176008
		[Token(Token = "0x402AF88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _subProfImg;

		// Token: 0x0402AF89 RID: 176009
		[Token(Token = "0x402AF89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeCharSelectUniEquipView _objEquip;

		// Token: 0x0402AF8A RID: 176010
		[Token(Token = "0x402AF8A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objNonEquip;

		// Token: 0x0402AF8B RID: 176011
		[Token(Token = "0x402AF8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402AF8C RID: 176012
		[Token(Token = "0x402AF8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadUniqEquip;

		// Token: 0x0402AF8D RID: 176013
		[Token(Token = "0x402AF8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
