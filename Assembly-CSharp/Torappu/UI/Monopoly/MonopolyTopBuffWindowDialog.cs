using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200481E RID: 18462
	[Token(Token = "0x200481E")]
	public class MonopolyTopBuffWindowDialog : UICompDialog<MonopolyTopBuffModel>
	{
		// Token: 0x0601BE99 RID: 114329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE99")]
		[Address(RVA = "0x15489C0", Offset = "0x15475C0", VA = "0x1815489C0", Slot = "18")]
		protected override void OnRender(MonopolyTopBuffModel input)
		{
		}

		// Token: 0x0601BE9A RID: 114330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BE9A")]
		[Address(RVA = "0x1548790", Offset = "0x1547390", VA = "0x181548790", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601BE9B RID: 114331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE9B")]
		[Address(RVA = "0x15488F0", Offset = "0x15474F0", VA = "0x1815488F0")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x0601BE9C RID: 114332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE9C")]
		[Address(RVA = "0x1548DD0", Offset = "0x15479D0", VA = "0x181548DD0")]
		public MonopolyTopBuffWindowDialog()
		{
		}

		// Token: 0x0601BE9E RID: 114334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BE9E")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0402463A RID: 149050
		[Token(Token = "0x402463A")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402463B RID: 149051
		[Token(Token = "0x402463B")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402463C RID: 149052
		[Token(Token = "0x402463C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x0402463D RID: 149053
		[Token(Token = "0x402463D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _buffDesc;

		// Token: 0x0402463E RID: 149054
		[Token(Token = "0x402463E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _buffProgDesc;

		// Token: 0x0402463F RID: 149055
		[Token(Token = "0x402463F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _buffActiveDesc;

		// Token: 0x04024640 RID: 149056
		[Token(Token = "0x4024640")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _buffProgPanel;

		// Token: 0x04024641 RID: 149057
		[Token(Token = "0x4024641")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04024642 RID: 149058
		[Token(Token = "0x4024642")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04024643 RID: 149059
		[Token(Token = "0x4024643")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04024644 RID: 149060
		[Token(Token = "0x4024644")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x04024645 RID: 149061
		[Token(Token = "0x4024645")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
