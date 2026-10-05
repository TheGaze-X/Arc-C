using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200549E RID: 21662
	[Token(Token = "0x200549E")]
	public class RoguelikeCharSelectBranchView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004AB9 RID: 19129
		// (set) Token: 0x0601FE01 RID: 130561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004AB9")]
		public Action<string> onBranchClicked
		{
			[Token(Token = "0x601FE01")]
			[Address(RVA = "0x19F2860", Offset = "0x19F1460", VA = "0x1819F2860")]
			set
			{
			}
		}

		// Token: 0x0601FE02 RID: 130562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE02")]
		[Address(RVA = "0x19F2550", Offset = "0x19F1150", VA = "0x1819F2550")]
		public void Render(RoguelikeCharSelectBranchItemViewModel branchModel, bool isSelected)
		{
		}

		// Token: 0x0601FE03 RID: 130563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE03")]
		[Address(RVA = "0x19F24D0", Offset = "0x19F10D0", VA = "0x1819F24D0")]
		public void OnBranchClicked()
		{
		}

		// Token: 0x0601FE04 RID: 130564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE04")]
		[Address(RVA = "0x19F2800", Offset = "0x19F1400", VA = "0x1819F2800")]
		public RoguelikeCharSelectBranchView()
		{
		}

		// Token: 0x0402AF6F RID: 175983
		[Token(Token = "0x402AF6F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorGraphic _brachIconColor;

		// Token: 0x0402AF70 RID: 175984
		[Token(Token = "0x402AF70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _brachIcon;

		// Token: 0x0402AF71 RID: 175985
		[Token(Token = "0x402AF71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _selectedIconColor;

		// Token: 0x0402AF72 RID: 175986
		[Token(Token = "0x402AF72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _unselectedIconColor;

		// Token: 0x0402AF73 RID: 175987
		[Token(Token = "0x402AF73")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelselectedBg;

		// Token: 0x0402AF74 RID: 175988
		[Token(Token = "0x402AF74")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelunselectedBg;

		// Token: 0x0402AF75 RID: 175989
		[Token(Token = "0x402AF75")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelLockBg;

		// Token: 0x0402AF76 RID: 175990
		[Token(Token = "0x402AF76")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x0402AF77 RID: 175991
		[Token(Token = "0x402AF77")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0402AF78 RID: 175992
		[Token(Token = "0x402AF78")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelLevel;

		// Token: 0x0402AF79 RID: 175993
		[Token(Token = "0x402AF79")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelSingleBranch;

		// Token: 0x0402AF7A RID: 175994
		[Token(Token = "0x402AF7A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelMultiBranch;

		// Token: 0x0402AF7B RID: 175995
		[Token(Token = "0x402AF7B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _singleBranchName;

		// Token: 0x0402AF7C RID: 175996
		[Token(Token = "0x402AF7C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _multiBranchName;

		// Token: 0x0402AF7D RID: 175997
		[Token(Token = "0x402AF7D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _multiExtraBranchIcon;

		// Token: 0x0402AF7E RID: 175998
		[Token(Token = "0x402AF7E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _equipLvl;

		// Token: 0x0402AF7F RID: 175999
		[Token(Token = "0x402AF7F")]
		[FieldOffset(Offset = "0xA8")]
		private Action<string> m_onBranchClicked;

		// Token: 0x0402AF80 RID: 176000
		[Token(Token = "0x402AF80")]
		[FieldOffset(Offset = "0xB0")]
		private string m_equipId;

		// Token: 0x0402AF81 RID: 176001
		[Token(Token = "0x402AF81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onBranchClicked;

		// Token: 0x0402AF82 RID: 176002
		[Token(Token = "0x402AF82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AF83 RID: 176003
		[Token(Token = "0x402AF83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBranchClicked;

		// Token: 0x0402AF84 RID: 176004
		[Token(Token = "0x402AF84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
