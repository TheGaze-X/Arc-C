using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BC2 RID: 11202
	[Token(Token = "0x2002BC2")]
	public class ActionToOwner : AbilityStandard.Behaviour, IActionNodeSource
	{
		// Token: 0x06012EBA RID: 77498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EBA")]
		[Address(RVA = "0xAC2940", Offset = "0xAC1540", VA = "0x180AC2940", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012EBB RID: 77499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EBB")]
		[Address(RVA = "0xAC29A0", Offset = "0xAC15A0", VA = "0x180AC29A0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012EBC RID: 77500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EBC")]
		[Address(RVA = "0xAC28B0", Offset = "0xAC14B0", VA = "0x180AC28B0", Slot = "16")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012EBD RID: 77501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EBD")]
		[Address(RVA = "0xAC2A50", Offset = "0xAC1650", VA = "0x180AC2A50")]
		private void _RunActions()
		{
		}

		// Token: 0x06012EBE RID: 77502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EBE")]
		[Address(RVA = "0xAC2CB0", Offset = "0xAC18B0", VA = "0x180AC2CB0")]
		public ActionToOwner()
		{
		}

		// Token: 0x06012EBF RID: 77503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EBF")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012EC0 RID: 77504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC0")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401558C RID: 87436
		[Token(Token = "0x401558C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _runActionOnEvent;

		// Token: 0x0401558D RID: 87437
		[Token(Token = "0x401558D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0401558E RID: 87438
		[Token(Token = "0x401558E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _onlyRunOnce;

		// Token: 0x0401558F RID: 87439
		[Token(Token = "0x401558F")]
		[FieldOffset(Offset = "0x31")]
		private bool m_run;

		// Token: 0x04015590 RID: 87440
		[Token(Token = "0x4015590")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015591 RID: 87441
		[Token(Token = "0x4015591")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015592 RID: 87442
		[Token(Token = "0x4015592")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04015593 RID: 87443
		[Token(Token = "0x4015593")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RunActions;

		// Token: 0x04015594 RID: 87444
		[Token(Token = "0x4015594")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
