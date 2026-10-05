using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F6 RID: 25846
	[Token(Token = "0x20064F6")]
	public class AutoChessSettleEndingBossWidget : AutoChessBattleUISettleEndingWidget
	{
		// Token: 0x06025238 RID: 152120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025238")]
		[Address(RVA = "0x2024D70", Offset = "0x2023970", VA = "0x182024D70", Slot = "4")]
		public override void Render(AutoChessSettleDataModel settleModel)
		{
		}

		// Token: 0x06025239 RID: 152121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025239")]
		[Address(RVA = "0x2024EB0", Offset = "0x2023AB0", VA = "0x182024EB0")]
		private Sprite _LoadBossIcon(AutoChessSettleBossModel bossModel)
		{
			return null;
		}

		// Token: 0x0602523A RID: 152122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602523A")]
		[Address(RVA = "0x2024F60", Offset = "0x2023B60", VA = "0x182024F60")]
		public AutoChessSettleEndingBossWidget()
		{
		}

		// Token: 0x0403411A RID: 213274
		[Token(Token = "0x403411A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgNormBoss;

		// Token: 0x0403411B RID: 213275
		[Token(Token = "0x403411B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgHideBoss;

		// Token: 0x0403411C RID: 213276
		[Token(Token = "0x403411C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403411D RID: 213277
		[Token(Token = "0x403411D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadBossIcon;

		// Token: 0x0403411E RID: 213278
		[Token(Token = "0x403411E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
