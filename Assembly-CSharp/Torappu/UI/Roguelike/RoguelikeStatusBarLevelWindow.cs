using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200532F RID: 21295
	[Token(Token = "0x200532F")]
	public class RoguelikeStatusBarLevelWindow : RoguelikeMenuWindow<RoguelikeMenuLevelViewModel>
	{
		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x0601F692 RID: 128658 RVA: 0x000B1D80 File Offset: 0x000AFF80
		[Token(Token = "0x170049A1")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F692")]
			[Address(RVA = "0x191CBA0", Offset = "0x191B7A0", VA = "0x18191CBA0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F693 RID: 128659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F693")]
		[Address(RVA = "0x191C560", Offset = "0x191B160", VA = "0x18191C560", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F694 RID: 128660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F694")]
		[Address(RVA = "0x191C6E0", Offset = "0x191B2E0", VA = "0x18191C6E0", Slot = "10")]
		public override void Render(RoguelikeMenuLevelViewModel viewModel)
		{
		}

		// Token: 0x0601F695 RID: 128661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F695")]
		[Address(RVA = "0x191CB10", Offset = "0x191B710", VA = "0x18191CB10")]
		public RoguelikeStatusBarLevelWindow()
		{
		}

		// Token: 0x0601F697 RID: 128663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F697")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402A3E1 RID: 173025
		[Token(Token = "0x402A3E1")]
		[FieldOffset(Offset = "0x0")]
		private new static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402A3E2 RID: 173026
		[Token(Token = "0x402A3E2")]
		[FieldOffset(Offset = "0x8")]
		private new static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402A3E3 RID: 173027
		[Token(Token = "0x402A3E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNextLevel;

		// Token: 0x0402A3E4 RID: 173028
		[Token(Token = "0x402A3E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textPopulationUp;

		// Token: 0x0402A3E5 RID: 173029
		[Token(Token = "0x402A3E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textSquadUp;

		// Token: 0x0402A3E6 RID: 173030
		[Token(Token = "0x402A3E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMaxHpUp;

		// Token: 0x0402A3E7 RID: 173031
		[Token(Token = "0x402A3E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelPopulationUp;

		// Token: 0x0402A3E8 RID: 173032
		[Token(Token = "0x402A3E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelSquadUp;

		// Token: 0x0402A3E9 RID: 173033
		[Token(Token = "0x402A3E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelMaxHpUp;

		// Token: 0x0402A3EA RID: 173034
		[Token(Token = "0x402A3EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A3EB RID: 173035
		[Token(Token = "0x402A3EB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A3EC RID: 173036
		[Token(Token = "0x402A3EC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A3ED RID: 173037
		[Token(Token = "0x402A3ED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
