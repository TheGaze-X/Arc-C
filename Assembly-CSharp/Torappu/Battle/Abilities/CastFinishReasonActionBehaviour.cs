using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C15 RID: 11285
	[Token(Token = "0x2002C15")]
	public class CastFinishReasonActionBehaviour : AbilityStandard.Behaviour, IActionNodeSource
	{
		// Token: 0x060130E6 RID: 78054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E6")]
		[Address(RVA = "0xB185B0", Offset = "0xB171B0", VA = "0x180B185B0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x060130E7 RID: 78055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E7")]
		[Address(RVA = "0xB18510", Offset = "0xB17110", VA = "0x180B18510", Slot = "16")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x060130E8 RID: 78056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E8")]
		[Address(RVA = "0xB187B0", Offset = "0xB173B0", VA = "0x180B187B0")]
		public CastFinishReasonActionBehaviour()
		{
		}

		// Token: 0x060130E9 RID: 78057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E9")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0401584E RID: 88142
		[Token(Token = "0x401584E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ability.FinishReason _reason;

		// Token: 0x0401584F RID: 88143
		[Token(Token = "0x401584F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _isReasonMatch;

		// Token: 0x04015850 RID: 88144
		[Token(Token = "0x4015850")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x04015851 RID: 88145
		[Token(Token = "0x4015851")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015852 RID: 88146
		[Token(Token = "0x4015852")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04015853 RID: 88147
		[Token(Token = "0x4015853")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
