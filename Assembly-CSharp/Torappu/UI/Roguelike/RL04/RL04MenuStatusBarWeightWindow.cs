using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056E9 RID: 22249
	[Token(Token = "0x20056E9")]
	public class RL04MenuStatusBarWeightWindow : RoguelikeMenuWindow<RL04MenuStatusBarWeightViewModel>
	{
		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x06020A17 RID: 133655 RVA: 0x000B6988 File Offset: 0x000B4B88
		[Token(Token = "0x17004C79")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020A17")]
			[Address(RVA = "0x1AC7CE0", Offset = "0x1AC68E0", VA = "0x181AC7CE0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020A18 RID: 133656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A18")]
		[Address(RVA = "0x1AC7A20", Offset = "0x1AC6620", VA = "0x181AC7A20", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06020A19 RID: 133657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A19")]
		[Address(RVA = "0x1AC7A80", Offset = "0x1AC6680", VA = "0x181AC7A80", Slot = "8")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x06020A1A RID: 133658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A1A")]
		[Address(RVA = "0x1AC7B00", Offset = "0x1AC6700", VA = "0x181AC7B00", Slot = "10")]
		public override void Render(RL04MenuStatusBarWeightViewModel viewModel)
		{
		}

		// Token: 0x06020A1B RID: 133659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A1B")]
		[Address(RVA = "0x1AC7C70", Offset = "0x1AC6870", VA = "0x181AC7C70")]
		public RL04MenuStatusBarWeightWindow()
		{
		}

		// Token: 0x06020A1C RID: 133660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A1C")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06020A1D RID: 133661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A1D")]
		[Address(RVA = "0x19153E0", Offset = "0x1913FE0", VA = "0x1819153E0")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402C42B RID: 181291
		[Token(Token = "0x402C42B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtWeightUp;

		// Token: 0x0402C42C RID: 181292
		[Token(Token = "0x402C42C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelView;

		// Token: 0x0402C42D RID: 181293
		[Token(Token = "0x402C42D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402C42E RID: 181294
		[Token(Token = "0x402C42E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402C42F RID: 181295
		[Token(Token = "0x402C42F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402C430 RID: 181296
		[Token(Token = "0x402C430")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C431 RID: 181297
		[Token(Token = "0x402C431")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
