using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021FA RID: 8698
	[Token(Token = "0x20021FA")]
	public class RecoverSpForEnemySkill : EnemySkill.Behaviour
	{
		// Token: 0x0600D9AE RID: 55726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AE")]
		[Address(RVA = "0x35EBBE0", Offset = "0x35EA7E0", VA = "0x1835EBBE0", Slot = "10")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x0600D9AF RID: 55727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AF")]
		[Address(RVA = "0x35EBE70", Offset = "0x35EAA70", VA = "0x1835EBE70")]
		private void _RecoverSp(int delta)
		{
		}

		// Token: 0x0600D9B0 RID: 55728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9B0")]
		[Address(RVA = "0x35EC040", Offset = "0x35EAC40", VA = "0x1835EC040")]
		public RecoverSpForEnemySkill()
		{
		}

		// Token: 0x0600D9B1 RID: 55729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9B1")]
		[Address(RVA = "0x35EBA30", Offset = "0x35EA630", VA = "0x1835EBA30")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0400EAEB RID: 60139
		[Token(Token = "0x400EAEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _recoverSpIfNoTarget;

		// Token: 0x0400EAEC RID: 60140
		[Token(Token = "0x400EAEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0400EAED RID: 60141
		[Token(Token = "0x400EAED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RecoverSp;

		// Token: 0x0400EAEE RID: 60142
		[Token(Token = "0x400EAEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
