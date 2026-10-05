using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005330 RID: 21296
	[Token(Token = "0x2005330")]
	public class RoguelikeStatusBarSpLevelWindow : RoguelikeMenuWindow<RoguelikeMenuLevelViewModel>
	{
		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x0601F698 RID: 128664 RVA: 0x000B1D98 File Offset: 0x000AFF98
		[Token(Token = "0x170049A2")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F698")]
			[Address(RVA = "0x1935570", Offset = "0x1934170", VA = "0x181935570", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F699 RID: 128665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F699")]
		[Address(RVA = "0x1934F30", Offset = "0x1933B30", VA = "0x181934F30", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F69A RID: 128666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F69A")]
		[Address(RVA = "0x19350B0", Offset = "0x1933CB0", VA = "0x1819350B0", Slot = "10")]
		public override void Render(RoguelikeMenuLevelViewModel viewModel)
		{
		}

		// Token: 0x0601F69B RID: 128667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F69B")]
		[Address(RVA = "0x19354E0", Offset = "0x19340E0", VA = "0x1819354E0")]
		public RoguelikeStatusBarSpLevelWindow()
		{
		}

		// Token: 0x0601F69D RID: 128669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F69D")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402A3EE RID: 173038
		[Token(Token = "0x402A3EE")]
		[FieldOffset(Offset = "0x0")]
		private new static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402A3EF RID: 173039
		[Token(Token = "0x402A3EF")]
		[FieldOffset(Offset = "0x8")]
		private new static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402A3F0 RID: 173040
		[Token(Token = "0x402A3F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNextLevel;

		// Token: 0x0402A3F1 RID: 173041
		[Token(Token = "0x402A3F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textPopulationUp;

		// Token: 0x0402A3F2 RID: 173042
		[Token(Token = "0x402A3F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textSquadUp;

		// Token: 0x0402A3F3 RID: 173043
		[Token(Token = "0x402A3F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMaxHpUp;

		// Token: 0x0402A3F4 RID: 173044
		[Token(Token = "0x402A3F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelPopulationUp;

		// Token: 0x0402A3F5 RID: 173045
		[Token(Token = "0x402A3F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelSquadUp;

		// Token: 0x0402A3F6 RID: 173046
		[Token(Token = "0x402A3F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelMaxHpUp;

		// Token: 0x0402A3F7 RID: 173047
		[Token(Token = "0x402A3F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A3F8 RID: 173048
		[Token(Token = "0x402A3F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A3F9 RID: 173049
		[Token(Token = "0x402A3F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A3FA RID: 173050
		[Token(Token = "0x402A3FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
