using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200227E RID: 8830
	[Token(Token = "0x200227E")]
	public class EnvActionToGlobal : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DE22 RID: 56866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE22")]
		[Address(RVA = "0x3632970", Offset = "0x3631570", VA = "0x183632970", Slot = "19")]
		public override void OnEnvChanged(string status)
		{
		}

		// Token: 0x0600DE23 RID: 56867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE23")]
		[Address(RVA = "0x3632AE0", Offset = "0x36316E0", VA = "0x183632AE0")]
		public void RunActions()
		{
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE24")]
		[Address(RVA = "0x36328D0", Offset = "0x36314D0", VA = "0x1836328D0", Slot = "11")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE25")]
		[Address(RVA = "0x3632BA0", Offset = "0x36317A0", VA = "0x183632BA0")]
		public EnvActionToGlobal()
		{
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE26")]
		[Address(RVA = "0x3632B90", Offset = "0x3631790", VA = "0x183632B90")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0)
		{
		}

		// Token: 0x0600DE27 RID: 56871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE27")]
		[Address(RVA = "0x550BB0", Offset = "0x54F7B0", VA = "0x180550BB0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0400F0E4 RID: 61668
		[Token(Token = "0x400F0E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<string> _envStatus;

		// Token: 0x0400F0E5 RID: 61669
		[Token(Token = "0x400F0E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0400F0E6 RID: 61670
		[Token(Token = "0x400F0E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F0E7 RID: 61671
		[Token(Token = "0x400F0E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RunActions;

		// Token: 0x0400F0E8 RID: 61672
		[Token(Token = "0x400F0E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400F0E9 RID: 61673
		[Token(Token = "0x400F0E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
