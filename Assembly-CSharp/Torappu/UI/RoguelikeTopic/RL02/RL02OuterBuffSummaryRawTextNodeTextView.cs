using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004623 RID: 17955
	[Token(Token = "0x2004623")]
	public class RL02OuterBuffSummaryRawTextNodeTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B499 RID: 111769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B499")]
		[Address(RVA = "0x14A1C60", Offset = "0x14A0860", VA = "0x1814A1C60")]
		public void Render(RL02OuterBuffListRawTextItemModel model, float unlockAlpha, float lockedTextAlpha, float lockedIconAlpha)
		{
		}

		// Token: 0x0601B49A RID: 111770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B49A")]
		[Address(RVA = "0x14A1DC0", Offset = "0x14A09C0", VA = "0x1814A1DC0")]
		public RL02OuterBuffSummaryRawTextNodeTextView()
		{
		}

		// Token: 0x04023399 RID: 144281
		[Token(Token = "0x4023399")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402339A RID: 144282
		[Token(Token = "0x402339A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroupIcon;

		// Token: 0x0402339B RID: 144283
		[Token(Token = "0x402339B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroupText;

		// Token: 0x0402339C RID: 144284
		[Token(Token = "0x402339C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402339D RID: 144285
		[Token(Token = "0x402339D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
