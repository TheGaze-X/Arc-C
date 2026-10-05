using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A8 RID: 21672
	[Token(Token = "0x20054A8")]
	public class RoguelikeSelectCharTalentItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE2A RID: 130602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE2A")]
		[Address(RVA = "0x1A136C0", Offset = "0x1A122C0", VA = "0x181A136C0")]
		public void Render(RoguelikeTalentViewModel viewModel)
		{
		}

		// Token: 0x0601FE2B RID: 130603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE2B")]
		[Address(RVA = "0x1A13910", Offset = "0x1A12510", VA = "0x181A13910")]
		public RoguelikeSelectCharTalentItem()
		{
		}

		// Token: 0x0402AFFE RID: 176126
		[Token(Token = "0x402AFFE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402AFFF RID: 176127
		[Token(Token = "0x402AFFF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0402B000 RID: 176128
		[Token(Token = "0x402B000")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeSelectCharTalentUnlockView _unlockView;

		// Token: 0x0402B001 RID: 176129
		[Token(Token = "0x402B001")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useDarkCommentText;

		// Token: 0x0402B002 RID: 176130
		[Token(Token = "0x402B002")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B003 RID: 176131
		[Token(Token = "0x402B003")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
