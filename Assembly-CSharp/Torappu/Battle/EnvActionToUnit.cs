using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002281 RID: 8833
	[Token(Token = "0x2002281")]
	public class EnvActionToUnit : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DE38 RID: 56888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE38")]
		[Address(RVA = "0x36340D0", Offset = "0x3632CD0", VA = "0x1836340D0", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600DE39 RID: 56889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE39")]
		[Address(RVA = "0x3634180", Offset = "0x3632D80", VA = "0x183634180", Slot = "16")]
		public override void OnEnvChanged(string status, Entity target, [Optional] Entity sourceNullable)
		{
		}

		// Token: 0x0600DE3A RID: 56890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE3A")]
		[Address(RVA = "0x3634280", Offset = "0x3632E80", VA = "0x183634280")]
		public void RunActionsOnTarget(Entity entity, [Optional] Entity sourceNullable)
		{
		}

		// Token: 0x0600DE3B RID: 56891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE3B")]
		[Address(RVA = "0x3634030", Offset = "0x3632C30", VA = "0x183634030", Slot = "11")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE3C")]
		[Address(RVA = "0x3634440", Offset = "0x3633040", VA = "0x183634440")]
		public EnvActionToUnit()
		{
		}

		// Token: 0x0600DE3D RID: 56893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE3D")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DE3E RID: 56894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE3E")]
		[Address(RVA = "0x3634430", Offset = "0x3633030", VA = "0x183634430")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0, Entity P1, Entity P2)
		{
		}

		// Token: 0x0600DE3F RID: 56895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE3F")]
		[Address(RVA = "0x550BB0", Offset = "0x54F7B0", VA = "0x180550BB0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0400F100 RID: 61696
		[Token(Token = "0x400F100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<string> _envStatus;

		// Token: 0x0400F101 RID: 61697
		[Token(Token = "0x400F101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected TargetOptions _options;

		// Token: 0x0400F102 RID: 61698
		[Token(Token = "0x400F102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0400F103 RID: 61699
		[Token(Token = "0x400F103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F104 RID: 61700
		[Token(Token = "0x400F104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F105 RID: 61701
		[Token(Token = "0x400F105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RunActionsOnTarget;

		// Token: 0x0400F106 RID: 61702
		[Token(Token = "0x400F106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400F107 RID: 61703
		[Token(Token = "0x400F107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
