using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BC3 RID: 11203
	[Token(Token = "0x2002BC3")]
	public class ExtraActions : AbilityStandard.Behaviour, IActionNodeSource
	{
		// Token: 0x06012EC1 RID: 77505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC1")]
		[Address(RVA = "0xAC46E0", Offset = "0xAC32E0", VA = "0x180AC46E0", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06012EC2 RID: 77506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC2")]
		[Address(RVA = "0xAC4650", Offset = "0xAC3250", VA = "0x180AC4650", Slot = "16")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012EC3 RID: 77507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC3")]
		[Address(RVA = "0xAC4900", Offset = "0xAC3500", VA = "0x180AC4900")]
		public ExtraActions()
		{
		}

		// Token: 0x06012EC4 RID: 77508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC4")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x04015595 RID: 87445
		[Token(Token = "0x4015595")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x04015596 RID: 87446
		[Token(Token = "0x4015596")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015597 RID: 87447
		[Token(Token = "0x4015597")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04015598 RID: 87448
		[Token(Token = "0x4015598")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
