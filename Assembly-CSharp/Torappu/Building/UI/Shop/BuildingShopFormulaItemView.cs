using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CFA RID: 7418
	[Token(Token = "0x2001CFA")]
	public class BuildingShopFormulaItemView : MonoBehaviour
	{
		// Token: 0x0600B744 RID: 46916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B744")]
		[Address(RVA = "0x333F530", Offset = "0x333E130", VA = "0x18333F530")]
		public void Render(SFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B745")]
		[Address(RVA = "0x333F6C0", Offset = "0x333E2C0", VA = "0x18333F6C0")]
		private void _Init(SFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B746")]
		[Address(RVA = "0x333F930", Offset = "0x333E530", VA = "0x18333F930")]
		private void _RenderActive(SFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B747")]
		[Address(RVA = "0x333F690", Offset = "0x333E290", VA = "0x18333F690")]
		private Sprite _GetSpriteByType(ItemType itemType)
		{
			return null;
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B748")]
		[Address(RVA = "0x333F8A0", Offset = "0x333E4A0", VA = "0x18333F8A0")]
		private void _OnFormulaClicked()
		{
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x000451C8 File Offset: 0x000433C8
		[Token(Token = "0x600B749")]
		[Address(RVA = "0x333F8C0", Offset = "0x333E4C0", VA = "0x18333F8C0")]
		private bool _OnFormulaLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B74A")]
		[Address(RVA = "0x333FC50", Offset = "0x333E850", VA = "0x18333FC50")]
		public BuildingShopFormulaItemView()
		{
		}

		// Token: 0x0400B51B RID: 46363
		[Token(Token = "0x400B51B")]
		private const int LARGE_ITEM_FOR_DISPLAY = 99;

		// Token: 0x0400B51C RID: 46364
		[Token(Token = "0x400B51C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIItemCard _itemPrefab;

		// Token: 0x0400B51D RID: 46365
		[Token(Token = "0x400B51D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400B51E RID: 46366
		[Token(Token = "0x400B51E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _targetScale;

		// Token: 0x0400B51F RID: 46367
		[Token(Token = "0x400B51F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelClickSpot;

		// Token: 0x0400B520 RID: 46368
		[Token(Token = "0x400B520")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400B521 RID: 46369
		[Token(Token = "0x400B521")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400B522 RID: 46370
		[Token(Token = "0x400B522")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400B523 RID: 46371
		[Token(Token = "0x400B523")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B524 RID: 46372
		[Token(Token = "0x400B524")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIBicolorText _textTime;

		// Token: 0x0400B525 RID: 46373
		[Token(Token = "0x400B525")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _iconCost;

		// Token: 0x0400B526 RID: 46374
		[Token(Token = "0x400B526")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textPrice;

		// Token: 0x0400B527 RID: 46375
		[Token(Token = "0x400B527")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x0400B528 RID: 46376
		[Token(Token = "0x400B528")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UILongPressButton _btnFormula;

		// Token: 0x0400B529 RID: 46377
		[Token(Token = "0x400B529")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Cost Sprites")]
		private Sprite _iconGold;

		// Token: 0x0400B52A RID: 46378
		[Token(Token = "0x400B52A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Cost Sprites")]
		private Sprite _iconDiamond;

		// Token: 0x0400B52B RID: 46379
		[Token(Token = "0x400B52B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Cost Sprites")]
		private Sprite _iconDmdShd;

		// Token: 0x0400B52C RID: 46380
		[Token(Token = "0x400B52C")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action<SFormulaViewModel> onFormulaClicked;

		// Token: 0x0400B52D RID: 46381
		[Token(Token = "0x400B52D")]
		[FieldOffset(Offset = "0xA0")]
		private SFormulaViewModel m_cachedFormula;

		// Token: 0x0400B52E RID: 46382
		[Token(Token = "0x400B52E")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0400B52F RID: 46383
		[Token(Token = "0x400B52F")]
		[FieldOffset(Offset = "0xB0")]
		private UIItemCard m_targetItemCard;

		// Token: 0x0400B530 RID: 46384
		[Token(Token = "0x400B530")]
		[FieldOffset(Offset = "0xB8")]
		private UIItemViewModel m_targetItemModel;
	}
}
