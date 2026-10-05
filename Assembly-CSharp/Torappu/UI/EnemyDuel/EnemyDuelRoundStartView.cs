using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005004 RID: 20484
	[Token(Token = "0x2005004")]
	public class EnemyDuelRoundStartView : DataBinder<EnemyDuelRoundStartProperty>
	{
		// Token: 0x0601E66E RID: 124526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E66E")]
		[Address(RVA = "0x1820280", Offset = "0x181EE80", VA = "0x181820280", Slot = "7")]
		public override void OnValueChanged(EnemyDuelRoundStartProperty property)
		{
		}

		// Token: 0x0601E66F RID: 124527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E66F")]
		[Address(RVA = "0x1820400", Offset = "0x181F000", VA = "0x181820400")]
		public EnemyDuelRoundStartView()
		{
		}

		// Token: 0x04028A7F RID: 166527
		[Token(Token = "0x4028A7F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlTotalWave;

		// Token: 0x04028A80 RID: 166528
		[Token(Token = "0x4028A80")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCurWave;

		// Token: 0x04028A81 RID: 166529
		[Token(Token = "0x4028A81")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTotalWave;

		// Token: 0x04028A82 RID: 166530
		[Token(Token = "0x4028A82")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;

		// Token: 0x04028A83 RID: 166531
		[Token(Token = "0x4028A83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028A84 RID: 166532
		[Token(Token = "0x4028A84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
