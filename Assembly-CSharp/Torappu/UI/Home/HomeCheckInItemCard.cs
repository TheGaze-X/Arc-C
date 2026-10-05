using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE7 RID: 19431
	[Token(Token = "0x2004BE7")]
	public class HomeCheckInItemCard : MonoBehaviour, UIItemDescFloat.IItemCard, IHotfixable
	{
		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x0601D33A RID: 119610 RVA: 0x000AADF0 File Offset: 0x000A8FF0
		// (set) Token: 0x0601D33B RID: 119611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044AE")]
		public bool isCardClickable
		{
			[Token(Token = "0x601D33A")]
			[Address(RVA = "0x16C35C0", Offset = "0x16C21C0", VA = "0x1816C35C0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D33B")]
			[Address(RVA = "0x16C3620", Offset = "0x16C2220", VA = "0x1816C3620", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x0601D33C RID: 119612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D33C")]
		[Address(RVA = "0x16C33E0", Offset = "0x16C1FE0", VA = "0x1816C33E0")]
		public void Render(ISharedItemModel itemModel)
		{
		}

		// Token: 0x0601D33D RID: 119613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D33D")]
		[Address(RVA = "0x16C3300", Offset = "0x16C1F00", VA = "0x1816C3300")]
		public void OnClick()
		{
		}

		// Token: 0x0601D33E RID: 119614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D33E")]
		[Address(RVA = "0x16C3560", Offset = "0x16C2160", VA = "0x1816C3560")]
		public HomeCheckInItemCard()
		{
		}

		// Token: 0x0402658E RID: 157070
		[Token(Token = "0x402658E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0402658F RID: 157071
		[Token(Token = "0x402658F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04026590 RID: 157072
		[Token(Token = "0x4026590")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04026591 RID: 157073
		[Token(Token = "0x4026591")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic _raycastBtn;

		// Token: 0x04026592 RID: 157074
		[Token(Token = "0x4026592")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _targetGameObject;

		// Token: 0x04026593 RID: 157075
		[Token(Token = "0x4026593")]
		[FieldOffset(Offset = "0x40")]
		private UIItemViewModel m_cachedModel;

		// Token: 0x04026594 RID: 157076
		[Token(Token = "0x4026594")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isClickable;

		// Token: 0x04026595 RID: 157077
		[Token(Token = "0x4026595")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCardClickable;

		// Token: 0x04026596 RID: 157078
		[Token(Token = "0x4026596")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isCardClickable;

		// Token: 0x04026597 RID: 157079
		[Token(Token = "0x4026597")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026598 RID: 157080
		[Token(Token = "0x4026598")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026599 RID: 157081
		[Token(Token = "0x4026599")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
