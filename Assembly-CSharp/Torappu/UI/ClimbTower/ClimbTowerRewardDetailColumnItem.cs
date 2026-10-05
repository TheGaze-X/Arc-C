using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C5D RID: 23645
	[Token(Token = "0x2005C5D")]
	public class ClimbTowerRewardDetailColumnItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022428 RID: 140328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022428")]
		[Address(RVA = "0x1CC11A0", Offset = "0x1CBFDA0", VA = "0x181CC11A0")]
		public void Render(ClimbTowerRewardInfo rewardInfo, bool isLastItem)
		{
		}

		// Token: 0x06022429 RID: 140329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022429")]
		[Address(RVA = "0x1CC1380", Offset = "0x1CBFF80", VA = "0x181CC1380")]
		public ClimbTowerRewardDetailColumnItem()
		{
		}

		// Token: 0x0402F09B RID: 192667
		[Token(Token = "0x402F09B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textLayer;

		// Token: 0x0402F09C RID: 192668
		[Token(Token = "0x402F09C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLowerItem;

		// Token: 0x0402F09D RID: 192669
		[Token(Token = "0x402F09D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textHigherItem;

		// Token: 0x0402F09E RID: 192670
		[Token(Token = "0x402F09E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlHigherItemNoDrop;

		// Token: 0x0402F09F RID: 192671
		[Token(Token = "0x402F09F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlHigherItemDrop;

		// Token: 0x0402F0A0 RID: 192672
		[Token(Token = "0x402F0A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _separators;

		// Token: 0x0402F0A1 RID: 192673
		[Token(Token = "0x402F0A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F0A2 RID: 192674
		[Token(Token = "0x402F0A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
