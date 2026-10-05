using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200545C RID: 21596
	[Token(Token = "0x200545C")]
	public class RoguelikeSacrificeSelectedView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FC98 RID: 130200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC98")]
		[Address(RVA = "0x19F7F90", Offset = "0x19F6B90", VA = "0x1819F7F90")]
		public void Render(RoguelikeSacrificeViewModel viewModel)
		{
		}

		// Token: 0x0601FC99 RID: 130201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC99")]
		[Address(RVA = "0x19F8760", Offset = "0x19F7360", VA = "0x1819F8760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FC9A RID: 130202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC9A")]
		[Address(RVA = "0x19F8490", Offset = "0x19F7090", VA = "0x1819F8490")]
		private string _GetUsage(RoguelikeSacrificeViewModel model)
		{
			return null;
		}

		// Token: 0x0601FC9B RID: 130203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC9B")]
		[Address(RVA = "0x19F88F0", Offset = "0x19F74F0", VA = "0x1819F88F0")]
		public RoguelikeSacrificeSelectedView()
		{
		}

		// Token: 0x0402AD3F RID: 175423
		[Token(Token = "0x402AD3F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasEmpty;

		// Token: 0x0402AD40 RID: 175424
		[Token(Token = "0x402AD40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasItem;

		// Token: 0x0402AD41 RID: 175425
		[Token(Token = "0x402AD41")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0402AD42 RID: 175426
		[Token(Token = "0x402AD42")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textItemUsage;

		// Token: 0x0402AD43 RID: 175427
		[Token(Token = "0x402AD43")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelChosen;

		// Token: 0x0402AD44 RID: 175428
		[Token(Token = "0x402AD44")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _itemIconHolder;

		// Token: 0x0402AD45 RID: 175429
		[Token(Token = "0x402AD45")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeCustomizableItemIcon _itemIconPrefab;

		// Token: 0x0402AD46 RID: 175430
		[Token(Token = "0x402AD46")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _itemIconScale;

		// Token: 0x0402AD47 RID: 175431
		[Token(Token = "0x402AD47")]
		[FieldOffset(Offset = "0x54")]
		private bool m_hasInited;

		// Token: 0x0402AD48 RID: 175432
		[Token(Token = "0x402AD48")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_showTweenEmpty;

		// Token: 0x0402AD49 RID: 175433
		[Token(Token = "0x402AD49")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween m_showTweenIcon;

		// Token: 0x0402AD4A RID: 175434
		[Token(Token = "0x402AD4A")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedSelectedItemId;

		// Token: 0x0402AD4B RID: 175435
		[Token(Token = "0x402AD4B")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCustomizableItemIcon m_itemIcon;

		// Token: 0x0402AD4C RID: 175436
		[Token(Token = "0x402AD4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AD4D RID: 175437
		[Token(Token = "0x402AD4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AD4E RID: 175438
		[Token(Token = "0x402AD4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetUsage;

		// Token: 0x0402AD4F RID: 175439
		[Token(Token = "0x402AD4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
