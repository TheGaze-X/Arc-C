using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005538 RID: 21816
	[Token(Token = "0x2005538")]
	public class RoguelikeStashedTicketUseConfirmBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020154 RID: 131412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020154")]
		[Address(RVA = "0x1A3E200", Offset = "0x1A3CE00", VA = "0x181A3E200")]
		public void Render(RoguelikeStashedTicketUseViewModel model)
		{
		}

		// Token: 0x06020155 RID: 131413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020155")]
		[Address(RVA = "0x1A3E170", Offset = "0x1A3CD70", VA = "0x181A3E170")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x06020156 RID: 131414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020156")]
		[Address(RVA = "0x1A3E440", Offset = "0x1A3D040", VA = "0x181A3E440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020157 RID: 131415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020157")]
		[Address(RVA = "0x1A3E520", Offset = "0x1A3D120", VA = "0x181A3E520")]
		public RoguelikeStashedTicketUseConfirmBtnView()
		{
		}

		// Token: 0x0402B54D RID: 177485
		[Token(Token = "0x402B54D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objLimitCntPart;

		// Token: 0x0402B54E RID: 177486
		[Token(Token = "0x402B54E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtLimitTips;

		// Token: 0x0402B54F RID: 177487
		[Token(Token = "0x402B54F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasCantUseMask;

		// Token: 0x0402B550 RID: 177488
		[Token(Token = "0x402B550")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402B551 RID: 177489
		[Token(Token = "0x402B551")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_maskTween;

		// Token: 0x0402B552 RID: 177490
		[Token(Token = "0x402B552")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B553 RID: 177491
		[Token(Token = "0x402B553")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B554 RID: 177492
		[Token(Token = "0x402B554")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x0402B555 RID: 177493
		[Token(Token = "0x402B555")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B556 RID: 177494
		[Token(Token = "0x402B556")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
