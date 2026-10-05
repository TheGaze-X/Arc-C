using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005682 RID: 22146
	[Token(Token = "0x2005682")]
	public class RL04AlchemySlotItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060207DE RID: 133086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207DE")]
		[Address(RVA = "0x1A9F9D0", Offset = "0x1A9E5D0", VA = "0x181A9F9D0")]
		public void Render(RL04AlchemySlotItemViewModel slotItemViewModel)
		{
		}

		// Token: 0x060207DF RID: 133087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207DF")]
		[Address(RVA = "0x1A9FF60", Offset = "0x1A9EB60", VA = "0x181A9FF60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207E0 RID: 133088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207E0")]
		[Address(RVA = "0x1A9FDF0", Offset = "0x1A9E9F0", VA = "0x181A9FDF0")]
		private void _EnsureFragmentCard()
		{
		}

		// Token: 0x060207E1 RID: 133089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207E1")]
		[Address(RVA = "0x1A9F870", Offset = "0x1A9E470", VA = "0x181A9F870")]
		public void EventOnSlotClick()
		{
		}

		// Token: 0x060207E2 RID: 133090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207E2")]
		[Address(RVA = "0x1AA0040", Offset = "0x1A9EC40", VA = "0x181AA0040")]
		public RL04AlchemySlotItemView()
		{
		}

		// Token: 0x0402C072 RID: 180338
		[Token(Token = "0x402C072")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasFragmentItem;

		// Token: 0x0402C073 RID: 180339
		[Token(Token = "0x402C073")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _graphicColor;

		// Token: 0x0402C074 RID: 180340
		[Token(Token = "0x402C074")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _fragmentCardContainer;

		// Token: 0x0402C075 RID: 180341
		[Token(Token = "0x402C075")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL04AlchemySlotFragmentItemCard _fragmentCardPrefab;

		// Token: 0x0402C076 RID: 180342
		[Token(Token = "0x402C076")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtFragmentName;

		// Token: 0x0402C077 RID: 180343
		[Token(Token = "0x402C077")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtFragmentDesc;

		// Token: 0x0402C078 RID: 180344
		[Token(Token = "0x402C078")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402C079 RID: 180345
		[Token(Token = "0x402C079")]
		[FieldOffset(Offset = "0x50")]
		private RL04AlchemySlotFragmentItemCard m_fragmentCard;

		// Token: 0x0402C07A RID: 180346
		[Token(Token = "0x402C07A")]
		[FieldOffset(Offset = "0x58")]
		private RL04AlchemySlotItemViewModel m_cachedItemViewModel;

		// Token: 0x0402C07B RID: 180347
		[Token(Token = "0x402C07B")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_tweenFragmentItem;

		// Token: 0x0402C07C RID: 180348
		[Token(Token = "0x402C07C")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402C07D RID: 180349
		[Token(Token = "0x402C07D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C07E RID: 180350
		[Token(Token = "0x402C07E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C07F RID: 180351
		[Token(Token = "0x402C07F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureFragmentCard;

		// Token: 0x0402C080 RID: 180352
		[Token(Token = "0x402C080")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSlotClick;

		// Token: 0x0402C081 RID: 180353
		[Token(Token = "0x402C081")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
