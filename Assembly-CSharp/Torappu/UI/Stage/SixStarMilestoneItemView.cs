using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006828 RID: 26664
	[Token(Token = "0x2006828")]
	public class SixStarMilestoneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026317 RID: 156439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026317")]
		[Address(RVA = "0x213A9C0", Offset = "0x21395C0", VA = "0x18213A9C0")]
		public void Render(SixStarMilestoneItemViewModel viewModel, bool isFirstItem)
		{
		}

		// Token: 0x06026318 RID: 156440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026318")]
		[Address(RVA = "0x213A930", Offset = "0x2139530", VA = "0x18213A930")]
		public void EventOnClaimAllClicked()
		{
		}

		// Token: 0x06026319 RID: 156441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026319")]
		[Address(RVA = "0x213AED0", Offset = "0x2139AD0", VA = "0x18213AED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602631A RID: 156442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602631A")]
		[Address(RVA = "0x213ADD0", Offset = "0x21399D0", VA = "0x18213ADD0")]
		private void _EventOnItemCardClicked(int _)
		{
		}

		// Token: 0x0602631B RID: 156443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602631B")]
		[Address(RVA = "0x213B0D0", Offset = "0x2139CD0", VA = "0x18213B0D0")]
		private static void _SetGroupActiveIfNecessary(GameObject[] gameObject, bool isActive)
		{
		}

		// Token: 0x0602631C RID: 156444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602631C")]
		[Address(RVA = "0x213B1A0", Offset = "0x2139DA0", VA = "0x18213B1A0")]
		public SixStarMilestoneItemView()
		{
		}

		// Token: 0x04035CFF RID: 220415
		[Token(Token = "0x4035CFF")]
		private const float ALPHA_REWARD_UNCOMPLETE = 0.3f;

		// Token: 0x04035D00 RID: 220416
		[Token(Token = "0x4035D00")]
		private const float ALPHA_ITEM_CARD_UNCOMPLETE = 0.5f;

		// Token: 0x04035D01 RID: 220417
		[Token(Token = "0x4035D01")]
		private const float ALPHA_COMPLETE = 1f;

		// Token: 0x04035D02 RID: 220418
		[Token(Token = "0x4035D02")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _textPoint;

		// Token: 0x04035D03 RID: 220419
		[Token(Token = "0x4035D03")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04035D04 RID: 220420
		[Token(Token = "0x4035D04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelFirstItem;

		// Token: 0x04035D05 RID: 220421
		[Token(Token = "0x4035D05")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlockStage;

		// Token: 0x04035D06 RID: 220422
		[Token(Token = "0x4035D06")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _panelRewardItem;

		// Token: 0x04035D07 RID: 220423
		[Token(Token = "0x4035D07")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x04035D08 RID: 220424
		[Token(Token = "0x4035D08")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04035D09 RID: 220425
		[Token(Token = "0x4035D09")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _panelRewardFinish;

		// Token: 0x04035D0A RID: 220426
		[Token(Token = "0x4035D0A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelRewardConfirmed;

		// Token: 0x04035D0B RID: 220427
		[Token(Token = "0x4035D0B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelUnlockStageUncomplete;

		// Token: 0x04035D0C RID: 220428
		[Token(Token = "0x4035D0C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroupReward;

		// Token: 0x04035D0D RID: 220429
		[Token(Token = "0x4035D0D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroupItemCard;

		// Token: 0x04035D0E RID: 220430
		[Token(Token = "0x4035D0E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04035D0F RID: 220431
		[Token(Token = "0x4035D0F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _scaleItemCard;

		// Token: 0x04035D10 RID: 220432
		[Token(Token = "0x4035D10")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_itemCard;

		// Token: 0x04035D11 RID: 220433
		[Token(Token = "0x4035D11")]
		[FieldOffset(Offset = "0x90")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04035D12 RID: 220434
		[Token(Token = "0x4035D12")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04035D13 RID: 220435
		[Token(Token = "0x4035D13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035D14 RID: 220436
		[Token(Token = "0x4035D14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClaimAllClicked;

		// Token: 0x04035D15 RID: 220437
		[Token(Token = "0x4035D15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035D16 RID: 220438
		[Token(Token = "0x4035D16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnItemCardClicked;

		// Token: 0x04035D17 RID: 220439
		[Token(Token = "0x4035D17")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetGroupActiveIfNecessary;

		// Token: 0x04035D18 RID: 220440
		[Token(Token = "0x4035D18")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
