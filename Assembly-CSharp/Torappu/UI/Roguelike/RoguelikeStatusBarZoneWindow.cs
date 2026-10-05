using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005331 RID: 21297
	[Token(Token = "0x2005331")]
	public class RoguelikeStatusBarZoneWindow : RoguelikeMenuWindow<RoguelikeMenuZoneViewModel>
	{
		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x0601F69E RID: 128670 RVA: 0x000B1DB0 File Offset: 0x000AFFB0
		[Token(Token = "0x170049A3")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F69E")]
			[Address(RVA = "0x1935AC0", Offset = "0x19346C0", VA = "0x181935AC0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F69F RID: 128671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F69F")]
		[Address(RVA = "0x19355E0", Offset = "0x19341E0", VA = "0x1819355E0", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F6A0 RID: 128672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6A0")]
		[Address(RVA = "0x1935760", Offset = "0x1934360", VA = "0x181935760", Slot = "10")]
		public override void Render(RoguelikeMenuZoneViewModel viewModel)
		{
		}

		// Token: 0x0601F6A1 RID: 128673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6A1")]
		[Address(RVA = "0x1935A30", Offset = "0x1934630", VA = "0x181935A30")]
		public RoguelikeStatusBarZoneWindow()
		{
		}

		// Token: 0x0601F6A3 RID: 128675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F6A3")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402A3FB RID: 173051
		[Token(Token = "0x402A3FB")]
		[FieldOffset(Offset = "0x0")]
		private new static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402A3FC RID: 173052
		[Token(Token = "0x402A3FC")]
		[FieldOffset(Offset = "0x8")]
		private new static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402A3FD RID: 173053
		[Token(Token = "0x402A3FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeStatusBarZoneWindow.VariationPanel _variationPanel1;

		// Token: 0x0402A3FE RID: 173054
		[Token(Token = "0x402A3FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeStatusBarZoneWindow.VariationPanel _variationPanel2;

		// Token: 0x0402A3FF RID: 173055
		[Token(Token = "0x402A3FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeStatusBarZoneWindow.FusionPanel _fusionPanel;

		// Token: 0x0402A400 RID: 173056
		[Token(Token = "0x402A400")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A401 RID: 173057
		[Token(Token = "0x402A401")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A402 RID: 173058
		[Token(Token = "0x402A402")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A403 RID: 173059
		[Token(Token = "0x402A403")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005332 RID: 21298
		[Token(Token = "0x2005332")]
		[Serializable]
		private class VariationPanel
		{
			// Token: 0x0601F6A4 RID: 128676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F6A4")]
			[Address(RVA = "0x1937B20", Offset = "0x1936720", VA = "0x181937B20")]
			public void Render(RoguelikeVariationModel model)
			{
			}

			// Token: 0x0601F6A5 RID: 128677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F6A5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VariationPanel()
			{
			}

			// Token: 0x0402A404 RID: 173060
			[Token(Token = "0x402A404")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelVariation;

			// Token: 0x0402A405 RID: 173061
			[Token(Token = "0x402A405")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textVariationName;

			// Token: 0x0402A406 RID: 173062
			[Token(Token = "0x402A406")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textVariationEffect;

			// Token: 0x0402A407 RID: 173063
			[Token(Token = "0x402A407")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textVariationDesc;
		}

		// Token: 0x02005333 RID: 21299
		[Token(Token = "0x2005333")]
		[Serializable]
		private class FusionPanel
		{
			// Token: 0x0601F6A6 RID: 128678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F6A6")]
			[Address(RVA = "0x1921390", Offset = "0x191FF90", VA = "0x181921390")]
			public void Render(RoguelikeFusionModel model)
			{
			}

			// Token: 0x0601F6A7 RID: 128679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F6A7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FusionPanel()
			{
			}

			// Token: 0x0402A408 RID: 173064
			[Token(Token = "0x402A408")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _rootPanel;

			// Token: 0x0402A409 RID: 173065
			[Token(Token = "0x402A409")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _name;

			// Token: 0x0402A40A RID: 173066
			[Token(Token = "0x402A40A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _effect;

			// Token: 0x0402A40B RID: 173067
			[Token(Token = "0x402A40B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _desc;
		}
	}
}
