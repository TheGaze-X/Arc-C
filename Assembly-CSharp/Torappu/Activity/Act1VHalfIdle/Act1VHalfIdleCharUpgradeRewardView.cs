using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200771C RID: 30492
	[Token(Token = "0x200771C")]
	public class Act1VHalfIdleCharUpgradeRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AD6C RID: 175468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD6C")]
		[Address(RVA = "0x269D0A0", Offset = "0x269BCA0", VA = "0x18269D0A0")]
		public void Render(Act1VHalfIdleCharUpgradeRewardViewModel viewModel)
		{
		}

		// Token: 0x0602AD6D RID: 175469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD6D")]
		[Address(RVA = "0x269D010", Offset = "0x269BC10", VA = "0x18269D010")]
		public void OnBtnItemClicked()
		{
		}

		// Token: 0x0602AD6E RID: 175470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD6E")]
		[Address(RVA = "0x269D2D0", Offset = "0x269BED0", VA = "0x18269D2D0")]
		public Act1VHalfIdleCharUpgradeRewardView()
		{
		}

		// Token: 0x0403DBE8 RID: 252904
		[Token(Token = "0x403DBE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x0403DBE9 RID: 252905
		[Token(Token = "0x403DBE9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x0403DBEA RID: 252906
		[Token(Token = "0x403DBEA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _btnReward;

		// Token: 0x0403DBEB RID: 252907
		[Token(Token = "0x403DBEB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEvolvePhase;

		// Token: 0x0403DBEC RID: 252908
		[Token(Token = "0x403DBEC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlItemIcon;

		// Token: 0x0403DBED RID: 252909
		[Token(Token = "0x403DBED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlCompleted;

		// Token: 0x0403DBEE RID: 252910
		[Token(Token = "0x403DBEE")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedItemId;

		// Token: 0x0403DBEF RID: 252911
		[Token(Token = "0x403DBEF")]
		[FieldOffset(Offset = "0x50")]
		private EvolvePhase m_cachedEvolvePhase;

		// Token: 0x0403DBF0 RID: 252912
		[Token(Token = "0x403DBF0")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DBF1 RID: 252913
		[Token(Token = "0x403DBF1")]
		[FieldOffset(Offset = "0x68")]
		private Act1VHalfIdleCharUpgradeRewardViewModel m_cachedViewModel;

		// Token: 0x0403DBF2 RID: 252914
		[Token(Token = "0x403DBF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DBF3 RID: 252915
		[Token(Token = "0x403DBF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnItemClicked;

		// Token: 0x0403DBF4 RID: 252916
		[Token(Token = "0x403DBF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
