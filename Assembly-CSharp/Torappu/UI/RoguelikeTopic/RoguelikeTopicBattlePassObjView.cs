using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004482 RID: 17538
	[Token(Token = "0x2004482")]
	public class RoguelikeTopicBattlePassObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ACBC RID: 109756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACBC")]
		[Address(RVA = "0x13F2F00", Offset = "0x13F1B00", VA = "0x1813F2F00")]
		public void Render(RoguelikeTopicBPObjViewModel viewModel, [Optional] RoguelikeTopicBattlePassPurchaseWheelPickerView.Param param)
		{
		}

		// Token: 0x0601ACBD RID: 109757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACBD")]
		[Address(RVA = "0x13F3DF0", Offset = "0x13F29F0", VA = "0x1813F3DF0")]
		private void _DealWithPurchaseParts(RoguelikeTopicBPObjViewModel viewModel, RoguelikeTopicBattlePassPurchaseWheelPickerView.Param param)
		{
		}

		// Token: 0x0601ACBE RID: 109758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACBE")]
		[Address(RVA = "0x13F3F00", Offset = "0x13F2B00", VA = "0x1813F3F00")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x0601ACBF RID: 109759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACBF")]
		[Address(RVA = "0x13F2E70", Offset = "0x13F1A70", VA = "0x1813F2E70")]
		public void OnRewardClick()
		{
		}

		// Token: 0x0601ACC0 RID: 109760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACC0")]
		[Address(RVA = "0x13F4000", Offset = "0x13F2C00", VA = "0x1813F4000")]
		public RoguelikeTopicBattlePassObjView()
		{
		}

		// Token: 0x04022465 RID: 140389
		[Token(Token = "0x4022465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _num;

		// Token: 0x04022466 RID: 140390
		[Token(Token = "0x4022466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _valuableBkg;

		// Token: 0x04022467 RID: 140391
		[Token(Token = "0x4022467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _validLightImg;

		// Token: 0x04022468 RID: 140392
		[Token(Token = "0x4022468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _alreadyGotImg;

		// Token: 0x04022469 RID: 140393
		[Token(Token = "0x4022469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _lineLeft;

		// Token: 0x0402246A RID: 140394
		[Token(Token = "0x402246A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _lineRight;

		// Token: 0x0402246B RID: 140395
		[Token(Token = "0x402246B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _lineSpRight;

		// Token: 0x0402246C RID: 140396
		[Token(Token = "0x402246C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0402246D RID: 140397
		[Token(Token = "0x402246D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402246E RID: 140398
		[Token(Token = "0x402246E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _normalDot;

		// Token: 0x0402246F RID: 140399
		[Token(Token = "0x402246F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _rareDot;

		// Token: 0x04022470 RID: 140400
		[Token(Token = "0x4022470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _valuableDot;

		// Token: 0x04022471 RID: 140401
		[Token(Token = "0x4022471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _availableDot;

		// Token: 0x04022472 RID: 140402
		[Token(Token = "0x4022472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _numPart;

		// Token: 0x04022473 RID: 140403
		[Token(Token = "0x4022473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x04022474 RID: 140404
		[Token(Token = "0x4022474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _futurePart;

		// Token: 0x04022475 RID: 140405
		[Token(Token = "0x4022475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _endPart;

		// Token: 0x04022476 RID: 140406
		[Token(Token = "0x4022476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _hotspotBtn;

		// Token: 0x04022477 RID: 140407
		[Token(Token = "0x4022477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _itemCardCanvasGroup;

		// Token: 0x04022478 RID: 140408
		[Token(Token = "0x4022478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAtlasImage _imgValidNotice;

		// Token: 0x04022479 RID: 140409
		[Token(Token = "0x4022479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textExpandCaption;

		// Token: 0x0402247A RID: 140410
		[Token(Token = "0x402247A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _validNoticeText;

		// Token: 0x0402247B RID: 140411
		[Token(Token = "0x402247B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Purchase exclusive parts")]
		private GameObject _purchaseFirstLeftLine;

		// Token: 0x0402247C RID: 140412
		[Token(Token = "0x402247C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Purchase exclusive parts")]
		private GameObject _purchaseFirstLeftRaycastReceiver;

		// Token: 0x0402247D RID: 140413
		[Token(Token = "0x402247D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Purchase exclusive parts")]
		private GameObject _purchaseLastRightRaycastReceiver;

		// Token: 0x0402247E RID: 140414
		[Token(Token = "0x402247E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public Action<string> rewardClickAction;

		// Token: 0x0402247F RID: 140415
		[Token(Token = "0x402247F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private UIItemCard m_itemCard;

		// Token: 0x04022480 RID: 140416
		[Token(Token = "0x4022480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string m_cachedBpId;

		// Token: 0x04022481 RID: 140417
		[Token(Token = "0x4022481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022482 RID: 140418
		[Token(Token = "0x4022482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DealWithPurchaseParts;

		// Token: 0x04022483 RID: 140419
		[Token(Token = "0x4022483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04022484 RID: 140420
		[Token(Token = "0x4022484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x04022485 RID: 140421
		[Token(Token = "0x4022485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
