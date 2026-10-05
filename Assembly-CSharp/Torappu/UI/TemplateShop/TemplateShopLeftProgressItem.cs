using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D5B RID: 15707
	[Token(Token = "0x2003D5B")]
	public class TemplateShopLeftProgressItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018768 RID: 100200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018768")]
		[Address(RVA = "0x10F53A0", Offset = "0x10F3FA0", VA = "0x1810F53A0")]
		private void _EnsureItemCard()
		{
		}

		// Token: 0x06018769 RID: 100201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018769")]
		[Address(RVA = "0x10F4D50", Offset = "0x10F3950", VA = "0x1810F4D50")]
		private void InitCommonPart(int index, TemplateShopData.ProgessGoodItem item)
		{
		}

		// Token: 0x0601876A RID: 100202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601876A")]
		[Address(RVA = "0x10F4C20", Offset = "0x10F3820", VA = "0x1810F4C20")]
		public void InitActiveData(int index, int totalCount, TemplateShopData.ProgessGoodItem viewModel)
		{
		}

		// Token: 0x0601876B RID: 100203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601876B")]
		[Address(RVA = "0x10F5070", Offset = "0x10F3C70", VA = "0x1810F5070")]
		public void InitUnActiveData(int index, int totalCount, TemplateShopData.ProgessGoodItem viewModel, bool isSoldOut)
		{
		}

		// Token: 0x0601876C RID: 100204 RVA: 0x0009A758 File Offset: 0x00098958
		[Token(Token = "0x601876C")]
		[Address(RVA = "0x10F4B50", Offset = "0x10F3750", VA = "0x1810F4B50")]
		public float GetWidth(int totalCount, bool isActive)
		{
			return 0f;
		}

		// Token: 0x0601876D RID: 100205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601876D")]
		[Address(RVA = "0x10F5260", Offset = "0x10F3E60", VA = "0x1810F5260")]
		public void OpenCharacterShow()
		{
		}

		// Token: 0x0601876E RID: 100206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601876E")]
		[Address(RVA = "0x10F55F0", Offset = "0x10F41F0", VA = "0x1810F55F0")]
		public TemplateShopLeftProgressItem()
		{
		}

		// Token: 0x0401DF49 RID: 122697
		[Token(Token = "0x401DF49")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemSprite;

		// Token: 0x0401DF4A RID: 122698
		[Token(Token = "0x401DF4A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _itemSpriteReplicate;

		// Token: 0x0401DF4B RID: 122699
		[Token(Token = "0x401DF4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401DF4C RID: 122700
		[Token(Token = "0x401DF4C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _index;

		// Token: 0x0401DF4D RID: 122701
		[Token(Token = "0x401DF4D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _count;

		// Token: 0x0401DF4E RID: 122702
		[Token(Token = "0x401DF4E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0401DF4F RID: 122703
		[Token(Token = "0x401DF4F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _charPart;

		// Token: 0x0401DF50 RID: 122704
		[Token(Token = "0x401DF50")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _isSoldOut;

		// Token: 0x0401DF51 RID: 122705
		[Token(Token = "0x401DF51")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0401DF52 RID: 122706
		[Token(Token = "0x401DF52")]
		[FieldOffset(Offset = "0x60")]
		private UIItemViewModel m_cacheViewModel;

		// Token: 0x0401DF53 RID: 122707
		[Token(Token = "0x401DF53")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x0401DF54 RID: 122708
		[Token(Token = "0x401DF54")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] BACKIMAGEBLACKTYPE;

		// Token: 0x0401DF55 RID: 122709
		[Token(Token = "0x401DF55")]
		private const float ACTIVE_SCALE = 1.64f;

		// Token: 0x0401DF56 RID: 122710
		[Token(Token = "0x401DF56")]
		private const float TOTAL_WIDTH = 479f;

		// Token: 0x0401DF57 RID: 122711
		[Token(Token = "0x401DF57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x0401DF58 RID: 122712
		[Token(Token = "0x401DF58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitCommonPart;

		// Token: 0x0401DF59 RID: 122713
		[Token(Token = "0x401DF59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitActiveData;

		// Token: 0x0401DF5A RID: 122714
		[Token(Token = "0x401DF5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitUnActiveData;

		// Token: 0x0401DF5B RID: 122715
		[Token(Token = "0x401DF5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetWidth;

		// Token: 0x0401DF5C RID: 122716
		[Token(Token = "0x401DF5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenCharacterShow;

		// Token: 0x0401DF5D RID: 122717
		[Token(Token = "0x401DF5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
