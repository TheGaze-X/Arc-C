using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F5 RID: 25845
	[Token(Token = "0x20064F5")]
	public abstract class AutoChessBattleUISettleEndingWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025236 RID: 152118
		[Token(Token = "0x6025236")]
		public abstract void Render(AutoChessSettleDataModel settleModel);

		// Token: 0x06025237 RID: 152119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025237")]
		[Address(RVA = "0x2023BA0", Offset = "0x20227A0", VA = "0x182023BA0")]
		protected AutoChessBattleUISettleEndingWidget()
		{
		}

		// Token: 0x04034119 RID: 213273
		[Token(Token = "0x4034119")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
