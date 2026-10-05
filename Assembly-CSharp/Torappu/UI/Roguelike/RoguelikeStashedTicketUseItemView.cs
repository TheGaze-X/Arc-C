using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200553A RID: 21818
	[Token(Token = "0x200553A")]
	public class RoguelikeStashedTicketUseItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602015A RID: 131418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602015A")]
		[Address(RVA = "0x1A3F640", Offset = "0x1A3E240", VA = "0x181A3F640")]
		public void Render(IRoguelikeStashedTicketItemViewModel data, int idx, int selectTicketIdx)
		{
		}

		// Token: 0x0602015B RID: 131419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602015B")]
		[Address(RVA = "0x1A3F9C0", Offset = "0x1A3E5C0", VA = "0x181A3F9C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602015C RID: 131420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602015C")]
		[Address(RVA = "0x1A3F560", Offset = "0x1A3E160", VA = "0x181A3F560")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0602015D RID: 131421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602015D")]
		[Address(RVA = "0x1A3FAA0", Offset = "0x1A3E6A0", VA = "0x181A3FAA0")]
		public RoguelikeStashedTicketUseItemView()
		{
		}

		// Token: 0x0402B55D RID: 177501
		[Token(Token = "0x402B55D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402B55E RID: 177502
		[Token(Token = "0x402B55E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0402B55F RID: 177503
		[Token(Token = "0x402B55F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtUsage;

		// Token: 0x0402B560 RID: 177504
		[Token(Token = "0x402B560")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objStorageCheck;

		// Token: 0x0402B561 RID: 177505
		[Token(Token = "0x402B561")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtStorageTips;

		// Token: 0x0402B562 RID: 177506
		[Token(Token = "0x402B562")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasSelect;

		// Token: 0x0402B563 RID: 177507
		[Token(Token = "0x402B563")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0402B564 RID: 177508
		[Token(Token = "0x402B564")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_selectedTween;

		// Token: 0x0402B565 RID: 177509
		[Token(Token = "0x402B565")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedIdx;

		// Token: 0x0402B566 RID: 177510
		[Token(Token = "0x402B566")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedTicketId;

		// Token: 0x0402B567 RID: 177511
		[Token(Token = "0x402B567")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B568 RID: 177512
		[Token(Token = "0x402B568")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B569 RID: 177513
		[Token(Token = "0x402B569")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B56A RID: 177514
		[Token(Token = "0x402B56A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402B56B RID: 177515
		[Token(Token = "0x402B56B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
