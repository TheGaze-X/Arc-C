using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003526 RID: 13606
	[Token(Token = "0x2003526")]
	public class UICharacterAttackRangeDeltaWidget : UICharacterAttackRangeWidget
	{
		// Token: 0x06015AF9 RID: 88825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AF9")]
		[Address(RVA = "0xE3CB50", Offset = "0xE3B750", VA = "0x180E3CB50")]
		private void _InitPos(AttackRangeDescModel attackRangeInit, AttackRangeDescModel attackRangeEnd)
		{
		}

		// Token: 0x06015AFA RID: 88826 RVA: 0x0008D750 File Offset: 0x0008B950
		[Token(Token = "0x6015AFA")]
		[Address(RVA = "0xE3CA80", Offset = "0xE3B680", VA = "0x180E3CA80")]
		private bool _CheckAvalid(AttackRangeDescModel attackRange, int row, int col)
		{
			return default(bool);
		}

		// Token: 0x06015AFB RID: 88827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AFB")]
		[Address(RVA = "0xE3C580", Offset = "0xE3B180", VA = "0x180E3C580")]
		public void RenderAttackRange(AttackRangeDescModel attackRangeInit, AttackRangeDescModel attackRangeEnd)
		{
		}

		// Token: 0x06015AFC RID: 88828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AFC")]
		[Address(RVA = "0xE3CD70", Offset = "0xE3B970", VA = "0x180E3CD70")]
		public UICharacterAttackRangeDeltaWidget()
		{
		}

		// Token: 0x0401A098 RID: 106648
		[Token(Token = "0x401A098")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _tileDelta;

		// Token: 0x0401A099 RID: 106649
		[Token(Token = "0x401A099")]
		[FieldOffset(Offset = "0x48")]
		private int m_endCol;

		// Token: 0x0401A09A RID: 106650
		[Token(Token = "0x401A09A")]
		[FieldOffset(Offset = "0x4C")]
		private int m_endRow;

		// Token: 0x0401A09B RID: 106651
		[Token(Token = "0x401A09B")]
		[FieldOffset(Offset = "0x50")]
		private int m_initCol;

		// Token: 0x0401A09C RID: 106652
		[Token(Token = "0x401A09C")]
		[FieldOffset(Offset = "0x54")]
		private int m_initRow;

		// Token: 0x0401A09D RID: 106653
		[Token(Token = "0x401A09D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitPos;

		// Token: 0x0401A09E RID: 106654
		[Token(Token = "0x401A09E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckAvalid;

		// Token: 0x0401A09F RID: 106655
		[Token(Token = "0x401A09F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderAttackRange;

		// Token: 0x0401A0A0 RID: 106656
		[Token(Token = "0x401A0A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
