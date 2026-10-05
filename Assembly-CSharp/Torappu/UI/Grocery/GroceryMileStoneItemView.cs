using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D3D RID: 19773
	[Token(Token = "0x2004D3D")]
	public class GroceryMileStoneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D987 RID: 121223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D987")]
		[Address(RVA = "0x172EE90", Offset = "0x172DA90", VA = "0x18172EE90")]
		public void Render(GroceryMileStoneItemViewModel model)
		{
		}

		// Token: 0x0601D988 RID: 121224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D988")]
		[Address(RVA = "0x172EDB0", Offset = "0x172D9B0", VA = "0x18172EDB0")]
		public void OnClick()
		{
		}

		// Token: 0x0601D989 RID: 121225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D989")]
		[Address(RVA = "0x172F5E0", Offset = "0x172E1E0", VA = "0x18172F5E0")]
		private void _UpdateReplicateInfo(GroceryMileStoneItemViewModel model)
		{
		}

		// Token: 0x0601D98A RID: 121226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D98A")]
		[Address(RVA = "0x172F230", Offset = "0x172DE30", VA = "0x18172F230")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D98B RID: 121227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D98B")]
		[Address(RVA = "0x172F010", Offset = "0x172DC10", VA = "0x18172F010")]
		private UIItemCard _EnsureRepItemCard()
		{
			return null;
		}

		// Token: 0x0601D98C RID: 121228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D98C")]
		[Address(RVA = "0x172F420", Offset = "0x172E020", VA = "0x18172F420")]
		private void _OnItemCardClicked(int index)
		{
		}

		// Token: 0x0601D98D RID: 121229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D98D")]
		[Address(RVA = "0x172F570", Offset = "0x172E170", VA = "0x18172F570")]
		private void _OnRepItemCardClicked(int index)
		{
		}

		// Token: 0x0601D98E RID: 121230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D98E")]
		[Address(RVA = "0x172F490", Offset = "0x172E090", VA = "0x18172F490")]
		private static void _OnItemCardClicked(UIItemCard itemCard)
		{
		}

		// Token: 0x0601D98F RID: 121231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D98F")]
		[Address(RVA = "0x172F820", Offset = "0x172E420", VA = "0x18172F820")]
		public GroceryMileStoneItemView()
		{
		}

		// Token: 0x04027163 RID: 160099
		[Token(Token = "0x4027163")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _bkgAndPrizeTextToggle;

		// Token: 0x04027164 RID: 160100
		[Token(Token = "0x4027164")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _needPointNumText;

		// Token: 0x04027165 RID: 160101
		[Token(Token = "0x4027165")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lower panel")]
		private Transform _itemCardHolder;

		// Token: 0x04027166 RID: 160102
		[Token(Token = "0x4027166")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Lower panel")]
		private float _itemCardScaleInfo;

		// Token: 0x04027167 RID: 160103
		[Token(Token = "0x4027167")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _finishMask;

		// Token: 0x04027168 RID: 160104
		[Token(Token = "0x4027168")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _btnRaycast;

		// Token: 0x04027169 RID: 160105
		[Token(Token = "0x4027169")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _panelReplicateItem;

		// Token: 0x0402716A RID: 160106
		[Token(Token = "0x402716A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _replicateItemContainer;

		// Token: 0x0402716B RID: 160107
		[Token(Token = "0x402716B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _repAnim;

		// Token: 0x0402716C RID: 160108
		[Token(Token = "0x402716C")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x0402716D RID: 160109
		[Token(Token = "0x402716D")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_repItemCard;

		// Token: 0x0402716E RID: 160110
		[Token(Token = "0x402716E")]
		[FieldOffset(Offset = "0x78")]
		private string m_cacheId;

		// Token: 0x0402716F RID: 160111
		[Token(Token = "0x402716F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04027170 RID: 160112
		[Token(Token = "0x4027170")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027171 RID: 160113
		[Token(Token = "0x4027171")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_loopTween;

		// Token: 0x04027172 RID: 160114
		[Token(Token = "0x4027172")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027173 RID: 160115
		[Token(Token = "0x4027173")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04027174 RID: 160116
		[Token(Token = "0x4027174")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateReplicateInfo;

		// Token: 0x04027175 RID: 160117
		[Token(Token = "0x4027175")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027176 RID: 160118
		[Token(Token = "0x4027176")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureRepItemCard;

		// Token: 0x04027177 RID: 160119
		[Token(Token = "0x4027177")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04027178 RID: 160120
		[Token(Token = "0x4027178")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRepItemCardClicked;

		// Token: 0x04027179 RID: 160121
		[Token(Token = "0x4027179")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1__OnItemCardClicked;

		// Token: 0x0402717A RID: 160122
		[Token(Token = "0x402717A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
