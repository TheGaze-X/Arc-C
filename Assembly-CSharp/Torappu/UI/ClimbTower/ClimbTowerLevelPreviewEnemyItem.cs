using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C9F RID: 23711
	[Token(Token = "0x2005C9F")]
	public class ClimbTowerLevelPreviewEnemyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602252E RID: 140590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602252E")]
		[Address(RVA = "0x1CBDD00", Offset = "0x1CBC900", VA = "0x181CBDD00")]
		public void Render(EnemyHandBookEverViewModel viewModel, int index)
		{
		}

		// Token: 0x0602252F RID: 140591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602252F")]
		[Address(RVA = "0x1CBDC80", Offset = "0x1CBC880", VA = "0x181CBDC80")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x06022530 RID: 140592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022530")]
		[Address(RVA = "0x1CBDE90", Offset = "0x1CBCA90", VA = "0x181CBDE90")]
		public ClimbTowerLevelPreviewEnemyItem()
		{
		}

		// Token: 0x0402F219 RID: 193049
		[Token(Token = "0x402F219")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402F21A RID: 193050
		[Token(Token = "0x402F21A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0402F21B RID: 193051
		[Token(Token = "0x402F21B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _viewPart;

		// Token: 0x0402F21C RID: 193052
		[Token(Token = "0x402F21C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bossLogo;

		// Token: 0x0402F21D RID: 193053
		[Token(Token = "0x402F21D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _idText;

		// Token: 0x0402F21E RID: 193054
		[Token(Token = "0x402F21E")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> OnJumpToEnemyHandbook;

		// Token: 0x0402F21F RID: 193055
		[Token(Token = "0x402F21F")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedEnemyId;

		// Token: 0x0402F220 RID: 193056
		[Token(Token = "0x402F220")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedIndex;

		// Token: 0x0402F221 RID: 193057
		[Token(Token = "0x402F221")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F222 RID: 193058
		[Token(Token = "0x402F222")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402F223 RID: 193059
		[Token(Token = "0x402F223")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
