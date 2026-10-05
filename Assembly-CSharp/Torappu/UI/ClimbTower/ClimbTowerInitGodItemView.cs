using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D4D RID: 23885
	[Token(Token = "0x2005D4D")]
	public class ClimbTowerInitGodItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x0602296C RID: 141676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602296D RID: 141677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005173")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x602296C")]
			[Address(RVA = "0x1D1C590", Offset = "0x1D1B190", VA = "0x181D1C590")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602296D")]
			[Address(RVA = "0x1D1C5F0", Offset = "0x1D1B1F0", VA = "0x181D1C5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602296E RID: 141678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602296E")]
		[Address(RVA = "0x1D1C170", Offset = "0x1D1AD70", VA = "0x181D1C170")]
		public void Render(int position, ClimbTowerInitGodCardModel godCardModel, bool isSelected)
		{
		}

		// Token: 0x0602296F RID: 141679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602296F")]
		[Address(RVA = "0x1D1C060", Offset = "0x1D1AC60", VA = "0x181D1C060")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06022970 RID: 141680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022970")]
		[Address(RVA = "0x1D1C530", Offset = "0x1D1B130", VA = "0x181D1C530")]
		public ClimbTowerInitGodItemView()
		{
		}

		// Token: 0x0402F8A2 RID: 194722
		[Token(Token = "0x402F8A2")]
		private const float SELECT_ALPHA = 1f;

		// Token: 0x0402F8A3 RID: 194723
		[Token(Token = "0x402F8A3")]
		private const float UNSELECT_ALPHA = 0.6f;

		// Token: 0x0402F8A4 RID: 194724
		[Token(Token = "0x402F8A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402F8A5 RID: 194725
		[Token(Token = "0x402F8A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F8A6 RID: 194726
		[Token(Token = "0x402F8A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402F8A7 RID: 194727
		[Token(Token = "0x402F8A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectPanel;

		// Token: 0x0402F8A8 RID: 194728
		[Token(Token = "0x402F8A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _group;

		// Token: 0x0402F8A9 RID: 194729
		[Token(Token = "0x402F8A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTowerName;

		// Token: 0x0402F8AA RID: 194730
		[Token(Token = "0x402F8AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBindTowerName;

		// Token: 0x0402F8AB RID: 194731
		[Token(Token = "0x402F8AB")]
		[FieldOffset(Offset = "0x50")]
		private int m_position;

		// Token: 0x0402F8AD RID: 194733
		[Token(Token = "0x402F8AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402F8AE RID: 194734
		[Token(Token = "0x402F8AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402F8AF RID: 194735
		[Token(Token = "0x402F8AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F8B0 RID: 194736
		[Token(Token = "0x402F8B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0402F8B1 RID: 194737
		[Token(Token = "0x402F8B1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
