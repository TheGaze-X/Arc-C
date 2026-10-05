using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200567A RID: 22138
	[Token(Token = "0x200567A")]
	public class RL04AlchemyPoolRarityItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060207B2 RID: 133042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B2")]
		[Address(RVA = "0x1A9C4E0", Offset = "0x1A9B0E0", VA = "0x181A9C4E0")]
		public void Render(RL04AlchemyForecastRandomViewModel.RandomRewardRarityItemStatus itemStatus)
		{
		}

		// Token: 0x060207B3 RID: 133043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B3")]
		[Address(RVA = "0x1A9C670", Offset = "0x1A9B270", VA = "0x181A9C670")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207B4 RID: 133044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B4")]
		[Address(RVA = "0x1A9C790", Offset = "0x1A9B390", VA = "0x181A9C790")]
		public RL04AlchemyPoolRarityItemView()
		{
		}

		// Token: 0x0402C01C RID: 180252
		[Token(Token = "0x402C01C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasItem;

		// Token: 0x0402C01D RID: 180253
		[Token(Token = "0x402C01D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _itemBrightAnim;

		// Token: 0x0402C01E RID: 180254
		[Token(Token = "0x402C01E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402C01F RID: 180255
		[Token(Token = "0x402C01F")]
		[FieldOffset(Offset = "0x38")]
		private RL04AlchemyPoolRarityItemView.ItemSwitchTween m_itemTween;

		// Token: 0x0402C020 RID: 180256
		[Token(Token = "0x402C020")]
		private const float DURATION_FOR_FADE_OUT = 0.2f;

		// Token: 0x0402C021 RID: 180257
		[Token(Token = "0x402C021")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C022 RID: 180258
		[Token(Token = "0x402C022")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C023 RID: 180259
		[Token(Token = "0x402C023")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200567B RID: 22139
		[Token(Token = "0x200567B")]
		private class ItemSwitchTween : UISwitchTween
		{
			// Token: 0x060207B5 RID: 133045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207B5")]
			[Address(RVA = "0x1A8B8D0", Offset = "0x1A8A4D0", VA = "0x181A8B8D0")]
			public ItemSwitchTween(RL04AlchemyPoolRarityItemView itemView)
			{
			}

			// Token: 0x060207B6 RID: 133046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207B6")]
			[Address(RVA = "0x1A8B710", Offset = "0x1A8A310", VA = "0x181A8B710", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060207B7 RID: 133047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207B7")]
			[Address(RVA = "0x1A8B630", Offset = "0x1A8A230", VA = "0x181A8B630", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0402C024 RID: 180260
			[Token(Token = "0x402C024")]
			[FieldOffset(Offset = "0x48")]
			private RL04AlchemyPoolRarityItemView m_closure;

			// Token: 0x0402C025 RID: 180261
			[Token(Token = "0x402C025")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C026 RID: 180262
			[Token(Token = "0x402C026")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402C027 RID: 180263
			[Token(Token = "0x402C027")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}
	}
}
