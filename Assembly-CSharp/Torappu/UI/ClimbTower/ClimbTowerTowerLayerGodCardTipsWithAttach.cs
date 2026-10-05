using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CB7 RID: 23735
	[Token(Token = "0x2005CB7")]
	public class ClimbTowerTowerLayerGodCardTipsWithAttach : ClimbTowerTowerLayerBaseGodCardTips
	{
		// Token: 0x0602259F RID: 140703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602259F")]
		[Address(RVA = "0x1CD8030", Offset = "0x1CD6C30", VA = "0x181CD8030", Slot = "4")]
		public override void Render(ClimbTowerTowerLayerStackAdapter adapter)
		{
		}

		// Token: 0x060225A0 RID: 140704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225A0")]
		[Address(RVA = "0x1CD8130", Offset = "0x1CD6D30", VA = "0x181CD8130")]
		public ClimbTowerTowerLayerGodCardTipsWithAttach()
		{
		}

		// Token: 0x0402F34B RID: 193355
		[Token(Token = "0x402F34B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _imgSubCardNotSelected;

		// Token: 0x0402F34C RID: 193356
		[Token(Token = "0x402F34C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _imgSubCardSelected;

		// Token: 0x0402F34D RID: 193357
		[Token(Token = "0x402F34D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F34E RID: 193358
		[Token(Token = "0x402F34E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
