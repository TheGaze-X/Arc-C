using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200461E RID: 17950
	[Token(Token = "0x200461E")]
	public class RL02OuterBuffSummaryMergedItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x0601B485 RID: 111749 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B486 RID: 111750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004105")]
		public UIPage page
		{
			[Token(Token = "0x601B485")]
			[Address(RVA = "0x14A0FF0", Offset = "0x149FBF0", VA = "0x1814A0FF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B486")]
			[Address(RVA = "0x14A1050", Offset = "0x149FC50", VA = "0x1814A1050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B487 RID: 111751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B487")]
		[Address(RVA = "0x14A0CE0", Offset = "0x149F8E0", VA = "0x1814A0CE0")]
		public void Render(string topicId, RL02OuterBuffListMergedItemModel viewModel)
		{
		}

		// Token: 0x0601B488 RID: 111752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B488")]
		[Address(RVA = "0x14A0F80", Offset = "0x149FB80", VA = "0x1814A0F80")]
		public RL02OuterBuffSummaryMergedItemView()
		{
		}

		// Token: 0x04023368 RID: 144232
		[Token(Token = "0x4023368")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04023369 RID: 144233
		[Token(Token = "0x4023369")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTokenDesc;

		// Token: 0x0402336A RID: 144234
		[Token(Token = "0x402336A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textValue;

		// Token: 0x0402336B RID: 144235
		[Token(Token = "0x402336B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402336C RID: 144236
		[Token(Token = "0x402336C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _alphaUnlock;

		// Token: 0x0402336D RID: 144237
		[Token(Token = "0x402336D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _alphaLocked;

		// Token: 0x0402336F RID: 144239
		[Token(Token = "0x402336F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04023370 RID: 144240
		[Token(Token = "0x4023370")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04023371 RID: 144241
		[Token(Token = "0x4023371")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023372 RID: 144242
		[Token(Token = "0x4023372")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
