using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x0200621F RID: 25119
	[Token(Token = "0x200621F")]
	public class SixStarBattleFinishRankView : SixStarBattleFinishTimeTickListener, IHotfixable
	{
		// Token: 0x060243D7 RID: 148439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D7")]
		[Address(RVA = "0x1F1C250", Offset = "0x1F1AE50", VA = "0x181F1C250", Slot = "4")]
		public override void OnSetData(SixStarBattleFinishViewModel viewModel)
		{
		}

		// Token: 0x060243D8 RID: 148440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D8")]
		[Address(RVA = "0x1F1C430", Offset = "0x1F1B030", VA = "0x181F1C430", Slot = "5")]
		public override void OnTriggerTick()
		{
		}

		// Token: 0x060243D9 RID: 148441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D9")]
		[Address(RVA = "0x1F1C4D0", Offset = "0x1F1B0D0", VA = "0x181F1C4D0")]
		private void _PlayStarAudio()
		{
		}

		// Token: 0x060243DA RID: 148442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243DA")]
		[Address(RVA = "0x1F1C560", Offset = "0x1F1B160", VA = "0x181F1C560")]
		public SixStarBattleFinishRankView()
		{
		}

		// Token: 0x0403263C RID: 206396
		[Token(Token = "0x403263C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _rankItems;

		// Token: 0x0403263D RID: 206397
		[Token(Token = "0x403263D")]
		[FieldOffset(Offset = "0x20")]
		private int m_rankBeforeBattle;

		// Token: 0x0403263E RID: 206398
		[Token(Token = "0x403263E")]
		[FieldOffset(Offset = "0x24")]
		private int m_rankAfterBattle;

		// Token: 0x0403263F RID: 206399
		[Token(Token = "0x403263F")]
		[FieldOffset(Offset = "0x28")]
		private int m_curCountRank;

		// Token: 0x04032640 RID: 206400
		[Token(Token = "0x4032640")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSetData;

		// Token: 0x04032641 RID: 206401
		[Token(Token = "0x4032641")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTriggerTick;

		// Token: 0x04032642 RID: 206402
		[Token(Token = "0x4032642")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayStarAudio;

		// Token: 0x04032643 RID: 206403
		[Token(Token = "0x4032643")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
