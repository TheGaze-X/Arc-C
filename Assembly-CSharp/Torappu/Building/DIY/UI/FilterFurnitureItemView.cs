using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B1 RID: 6577
	[Token(Token = "0x20019B1")]
	public class FilterFurnitureItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1400004D RID: 77
		// (add) Token: 0x0600A533 RID: 42291 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A534 RID: 42292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004D")]
		public event Action<DIYShopFilterViewData> buttonPressed
		{
			[Token(Token = "0x600A533")]
			[Address(RVA = "0x31FC230", Offset = "0x31FAE30", VA = "0x1831FC230")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A534")]
			[Address(RVA = "0x31FC530", Offset = "0x31FB130", VA = "0x1831FC530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x0600A535 RID: 42293 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A536 RID: 42294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004E")]
		public event Action<DIYShopFilterViewData> infoPressed
		{
			[Token(Token = "0x600A535")]
			[Address(RVA = "0x31FC430", Offset = "0x31FB030", VA = "0x1831FC430")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A536")]
			[Address(RVA = "0x31FC730", Offset = "0x31FB330", VA = "0x1831FC730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x0600A537 RID: 42295 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A538 RID: 42296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004F")]
		public event Action<DIYShopFilterViewData> descPressed
		{
			[Token(Token = "0x600A537")]
			[Address(RVA = "0x31FC330", Offset = "0x31FAF30", VA = "0x1831FC330")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A538")]
			[Address(RVA = "0x31FC630", Offset = "0x31FB230", VA = "0x1831FC630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A539")]
		[Address(RVA = "0x31FC090", Offset = "0x31FAC90", VA = "0x1831FC090")]
		private void _SetupIcon(Image img, Sprite sp)
		{
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53A")]
		[Address(RVA = "0x31FBC80", Offset = "0x31FA880", VA = "0x1831FBC80")]
		public void Setup(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53B")]
		[Address(RVA = "0x31FBA90", Offset = "0x31FA690", VA = "0x1831FBA90")]
		public void OnBackgroundButtonPressed()
		{
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53C")]
		[Address(RVA = "0x31FBF50", Offset = "0x31FAB50", VA = "0x1831FBF50")]
		private void _OnButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53D")]
		[Address(RVA = "0x31FBFF0", Offset = "0x31FABF0", VA = "0x1831FBFF0")]
		private void _OnInfoButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53E")]
		[Address(RVA = "0x31FBB10", Offset = "0x31FA710", VA = "0x1831FBB10")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A53F")]
		[Address(RVA = "0x31FC1D0", Offset = "0x31FADD0", VA = "0x1831FC1D0")]
		public FilterFurnitureItemView()
		{
		}

		// Token: 0x04009CA4 RID: 40100
		[Token(Token = "0x4009CA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FurnitureItemView _innerFurnitureItemView;

		// Token: 0x04009CA5 RID: 40101
		[Token(Token = "0x4009CA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectBackground;

		// Token: 0x04009CA6 RID: 40102
		[Token(Token = "0x4009CA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descriptionLabel;

		// Token: 0x04009CA7 RID: 40103
		[Token(Token = "0x4009CA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _descriptionPanel;

		// Token: 0x04009CA8 RID: 40104
		[Token(Token = "0x4009CA8")]
		[FieldOffset(Offset = "0x38")]
		private DIYShopFilterViewData m_shopItemData;

		// Token: 0x04009CAC RID: 40108
		[Token(Token = "0x4009CAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_buttonPressed;

		// Token: 0x04009CAD RID: 40109
		[Token(Token = "0x4009CAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_buttonPressed;

		// Token: 0x04009CAE RID: 40110
		[Token(Token = "0x4009CAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_infoPressed;

		// Token: 0x04009CAF RID: 40111
		[Token(Token = "0x4009CAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_infoPressed;

		// Token: 0x04009CB0 RID: 40112
		[Token(Token = "0x4009CB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_descPressed;

		// Token: 0x04009CB1 RID: 40113
		[Token(Token = "0x4009CB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_descPressed;

		// Token: 0x04009CB2 RID: 40114
		[Token(Token = "0x4009CB2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetupIcon;

		// Token: 0x04009CB3 RID: 40115
		[Token(Token = "0x4009CB3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009CB4 RID: 40116
		[Token(Token = "0x4009CB4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackgroundButtonPressed;

		// Token: 0x04009CB5 RID: 40117
		[Token(Token = "0x4009CB5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x04009CB6 RID: 40118
		[Token(Token = "0x4009CB6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnInfoButtonPressed;

		// Token: 0x04009CB7 RID: 40119
		[Token(Token = "0x4009CB7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009CB8 RID: 40120
		[Token(Token = "0x4009CB8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
