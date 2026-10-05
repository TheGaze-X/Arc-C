using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D6 RID: 6614
	[Token(Token = "0x20019D6")]
	public class ThemeFurnitureItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000055 RID: 85
		// (add) Token: 0x0600A62F RID: 42543 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A630 RID: 42544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000055")]
		public event Action<DIYThemeItemViewData, ThemeFurnitureItemView> buttonPressed
		{
			[Token(Token = "0x600A62F")]
			[Address(RVA = "0x3226800", Offset = "0x3225400", VA = "0x183226800")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A630")]
			[Address(RVA = "0x3226900", Offset = "0x3225500", VA = "0x183226900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A631")]
		[Address(RVA = "0x3226660", Offset = "0x3225260", VA = "0x183226660")]
		private void _SetupIcon(Image img, Sprite sp)
		{
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A632")]
		[Address(RVA = "0x3225FC0", Offset = "0x3224BC0", VA = "0x183225FC0")]
		public void Setup(DIYThemeItemViewData data)
		{
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A633")]
		[Address(RVA = "0x32265B0", Offset = "0x32251B0", VA = "0x1832265B0")]
		private void _OnButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A634")]
		[Address(RVA = "0x3225EB0", Offset = "0x3224AB0", VA = "0x183225EB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A635")]
		[Address(RVA = "0x32267A0", Offset = "0x32253A0", VA = "0x1832267A0")]
		public ThemeFurnitureItemView()
		{
		}

		// Token: 0x04009E12 RID: 40466
		[Token(Token = "0x4009E12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FurnitureItemView _innerFurnitureItemView;

		// Token: 0x04009E13 RID: 40467
		[Token(Token = "0x4009E13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countLabel;

		// Token: 0x04009E14 RID: 40468
		[Token(Token = "0x4009E14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _comfortLabel;

		// Token: 0x04009E15 RID: 40469
		[Token(Token = "0x4009E15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _cashCostPanel;

		// Token: 0x04009E16 RID: 40470
		[Token(Token = "0x4009E16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _cashCostLabel;

		// Token: 0x04009E17 RID: 40471
		[Token(Token = "0x4009E17")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _furnitureCoinCostPanel;

		// Token: 0x04009E18 RID: 40472
		[Token(Token = "0x4009E18")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _furnitureCoinCostLabel;

		// Token: 0x04009E19 RID: 40473
		[Token(Token = "0x4009E19")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _discountPanel;

		// Token: 0x04009E1A RID: 40474
		[Token(Token = "0x4009E1A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _discountLabel;

		// Token: 0x04009E1B RID: 40475
		[Token(Token = "0x4009E1B")]
		[FieldOffset(Offset = "0x60")]
		private DIYThemeItemViewData m_themeItemData;

		// Token: 0x04009E1D RID: 40477
		[Token(Token = "0x4009E1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_buttonPressed;

		// Token: 0x04009E1E RID: 40478
		[Token(Token = "0x4009E1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_buttonPressed;

		// Token: 0x04009E1F RID: 40479
		[Token(Token = "0x4009E1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetupIcon;

		// Token: 0x04009E20 RID: 40480
		[Token(Token = "0x4009E20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009E21 RID: 40481
		[Token(Token = "0x4009E21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x04009E22 RID: 40482
		[Token(Token = "0x4009E22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009E23 RID: 40483
		[Token(Token = "0x4009E23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
