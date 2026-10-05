using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D26 RID: 23846
	[Token(Token = "0x2005D26")]
	public class ClimbTowerEndingTrapCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022873 RID: 141427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022873")]
		[Address(RVA = "0x1D01170", Offset = "0x1CFFD70", VA = "0x181D01170")]
		public void Render(ClimbTowerEndTrapViewModel viewModel)
		{
		}

		// Token: 0x06022874 RID: 141428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022874")]
		[Address(RVA = "0x1D01270", Offset = "0x1CFFE70", VA = "0x181D01270")]
		public ClimbTowerEndingTrapCardView()
		{
		}

		// Token: 0x0402F759 RID: 194393
		[Token(Token = "0x402F759")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggleTrapType;

		// Token: 0x0402F75A RID: 194394
		[Token(Token = "0x402F75A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleCardItem;

		// Token: 0x0402F75B RID: 194395
		[Token(Token = "0x402F75B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTrap;

		// Token: 0x0402F75C RID: 194396
		[Token(Token = "0x402F75C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCurseCard;

		// Token: 0x0402F75D RID: 194397
		[Token(Token = "0x402F75D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F75E RID: 194398
		[Token(Token = "0x402F75E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
