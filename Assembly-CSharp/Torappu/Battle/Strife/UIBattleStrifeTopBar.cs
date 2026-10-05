using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Strife
{
	// Token: 0x02002686 RID: 9862
	[Token(Token = "0x2002686")]
	public class UIBattleStrifeTopBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101B6 RID: 65974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B6")]
		[Address(RVA = "0x7D4A20", Offset = "0x7D3620", VA = "0x1807D4A20")]
		public void UpdateRemainingDuration(int remainingDuration, int totalDuration)
		{
		}

		// Token: 0x060101B7 RID: 65975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B7")]
		[Address(RVA = "0x7D4BB0", Offset = "0x7D37B0", VA = "0x1807D4BB0")]
		public UIBattleStrifeTopBar()
		{
		}

		// Token: 0x04011EFF RID: 73471
		[Token(Token = "0x4011EFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _remainTimeText;

		// Token: 0x04011F00 RID: 73472
		[Token(Token = "0x4011F00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _waringAnim;

		// Token: 0x04011F01 RID: 73473
		[Token(Token = "0x4011F01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _waringTime;

		// Token: 0x04011F02 RID: 73474
		[Token(Token = "0x4011F02")]
		[FieldOffset(Offset = "0x2C")]
		private int m_remainTime;

		// Token: 0x04011F03 RID: 73475
		[Token(Token = "0x4011F03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateRemainingDuration;

		// Token: 0x04011F04 RID: 73476
		[Token(Token = "0x4011F04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
