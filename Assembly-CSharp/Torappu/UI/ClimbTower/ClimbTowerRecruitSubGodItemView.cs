using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D4E RID: 23886
	[Token(Token = "0x2005D4E")]
	public class ClimbTowerRecruitSubGodItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x06022971 RID: 141681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022972 RID: 141682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005174")]
		public Action<string> onItemSelected
		{
			[Token(Token = "0x6022971")]
			[Address(RVA = "0x1D1D100", Offset = "0x1D1BD00", VA = "0x181D1D100")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022972")]
			[Address(RVA = "0x1D1D160", Offset = "0x1D1BD60", VA = "0x181D1D160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022973 RID: 141683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022973")]
		[Address(RVA = "0x1D1CE00", Offset = "0x1D1BA00", VA = "0x181D1CE00")]
		public void Render(ClimbTowerRecruitSubGodItemModel subCardModel, bool isSelected)
		{
		}

		// Token: 0x06022974 RID: 141684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022974")]
		[Address(RVA = "0x1D1CCF0", Offset = "0x1D1B8F0", VA = "0x181D1CCF0")]
		public void EventOnSubItemClick()
		{
		}

		// Token: 0x06022975 RID: 141685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022975")]
		[Address(RVA = "0x1D1D0A0", Offset = "0x1D1BCA0", VA = "0x181D1D0A0")]
		public ClimbTowerRecruitSubGodItemView()
		{
		}

		// Token: 0x0402F8B2 RID: 194738
		[Token(Token = "0x402F8B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402F8B3 RID: 194739
		[Token(Token = "0x402F8B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402F8B4 RID: 194740
		[Token(Token = "0x402F8B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectPanel;

		// Token: 0x0402F8B5 RID: 194741
		[Token(Token = "0x402F8B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F8B6 RID: 194742
		[Token(Token = "0x402F8B6")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerRecruitSubGodItemModel m_subCardModel;

		// Token: 0x0402F8B7 RID: 194743
		[Token(Token = "0x402F8B7")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isSelected;

		// Token: 0x0402F8B9 RID: 194745
		[Token(Token = "0x402F8B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemSelected;

		// Token: 0x0402F8BA RID: 194746
		[Token(Token = "0x402F8BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemSelected;

		// Token: 0x0402F8BB RID: 194747
		[Token(Token = "0x402F8BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F8BC RID: 194748
		[Token(Token = "0x402F8BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSubItemClick;

		// Token: 0x0402F8BD RID: 194749
		[Token(Token = "0x402F8BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
