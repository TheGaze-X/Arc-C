using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E18 RID: 24088
	[Token(Token = "0x2005E18")]
	public class CharSelectBranchView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170052C2 RID: 21186
		// (set) Token: 0x06022E8D RID: 142989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052C2")]
		public Action<string> onBranchClicked
		{
			[Token(Token = "0x6022E8D")]
			[Address(RVA = "0x1D65000", Offset = "0x1D63C00", VA = "0x181D65000")]
			set
			{
			}
		}

		// Token: 0x06022E8E RID: 142990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E8E")]
		[Address(RVA = "0x1D64CF0", Offset = "0x1D638F0", VA = "0x181D64CF0")]
		public void Render(CharSelectBranchItemViewModel branchModel, bool isSelected)
		{
		}

		// Token: 0x06022E8F RID: 142991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E8F")]
		[Address(RVA = "0x1D64C70", Offset = "0x1D63870", VA = "0x181D64C70")]
		public void OnBranchClicked()
		{
		}

		// Token: 0x06022E90 RID: 142992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E90")]
		[Address(RVA = "0x1D64FA0", Offset = "0x1D63BA0", VA = "0x181D64FA0")]
		public CharSelectBranchView()
		{
		}

		// Token: 0x0403013A RID: 196922
		[Token(Token = "0x403013A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorGraphic _brachIconColor;

		// Token: 0x0403013B RID: 196923
		[Token(Token = "0x403013B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _brachIcon;

		// Token: 0x0403013C RID: 196924
		[Token(Token = "0x403013C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _selectedIconColor;

		// Token: 0x0403013D RID: 196925
		[Token(Token = "0x403013D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _unselectedIconColor;

		// Token: 0x0403013E RID: 196926
		[Token(Token = "0x403013E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelselectedBg;

		// Token: 0x0403013F RID: 196927
		[Token(Token = "0x403013F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelunselectedBg;

		// Token: 0x04030140 RID: 196928
		[Token(Token = "0x4030140")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelLockBg;

		// Token: 0x04030141 RID: 196929
		[Token(Token = "0x4030141")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x04030142 RID: 196930
		[Token(Token = "0x4030142")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04030143 RID: 196931
		[Token(Token = "0x4030143")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelLevel;

		// Token: 0x04030144 RID: 196932
		[Token(Token = "0x4030144")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelSingleBranch;

		// Token: 0x04030145 RID: 196933
		[Token(Token = "0x4030145")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelMultiBranch;

		// Token: 0x04030146 RID: 196934
		[Token(Token = "0x4030146")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _singleBranchName;

		// Token: 0x04030147 RID: 196935
		[Token(Token = "0x4030147")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _multiBranchName;

		// Token: 0x04030148 RID: 196936
		[Token(Token = "0x4030148")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _multiExtraBranchIcon;

		// Token: 0x04030149 RID: 196937
		[Token(Token = "0x4030149")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _equipLvl;

		// Token: 0x0403014A RID: 196938
		[Token(Token = "0x403014A")]
		[FieldOffset(Offset = "0xA8")]
		private Action<string> m_onBranchClicked;

		// Token: 0x0403014B RID: 196939
		[Token(Token = "0x403014B")]
		[FieldOffset(Offset = "0xB0")]
		private string m_equipId;

		// Token: 0x0403014C RID: 196940
		[Token(Token = "0x403014C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onBranchClicked;

		// Token: 0x0403014D RID: 196941
		[Token(Token = "0x403014D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403014E RID: 196942
		[Token(Token = "0x403014E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBranchClicked;

		// Token: 0x0403014F RID: 196943
		[Token(Token = "0x403014F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
