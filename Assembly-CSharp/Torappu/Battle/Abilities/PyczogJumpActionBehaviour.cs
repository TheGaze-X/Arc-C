using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C25 RID: 11301
	[Token(Token = "0x2002C25")]
	public class PyczogJumpActionBehaviour : AbilityStandard.Behaviour, IActionNodeSource
	{
		// Token: 0x06013163 RID: 78179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013163")]
		[Address(RVA = "0xB21AC0", Offset = "0xB206C0", VA = "0x180B21AC0", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06013164 RID: 78180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013164")]
		[Address(RVA = "0xB21C20", Offset = "0xB20820", VA = "0x180B21C20", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013165 RID: 78181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013165")]
		[Address(RVA = "0xB21960", Offset = "0xB20560", VA = "0x180B21960", Slot = "16")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06013166 RID: 78182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013166")]
		[Address(RVA = "0xB21DE0", Offset = "0xB209E0", VA = "0x180B21DE0")]
		private void _RunActions(PyczogJumpActionBehaviour.JumpEndAction jumpAction)
		{
		}

		// Token: 0x06013167 RID: 78183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013167")]
		[Address(RVA = "0xB22060", Offset = "0xB20C60", VA = "0x180B22060")]
		public PyczogJumpActionBehaviour()
		{
		}

		// Token: 0x06013168 RID: 78184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013168")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06013169 RID: 78185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013169")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x040158D7 RID: 88279
		[Token(Token = "0x40158D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PyczogJumpActionBehaviour.JumpEndAction> _jumpEndActions;

		// Token: 0x040158D8 RID: 88280
		[Token(Token = "0x40158D8")]
		[FieldOffset(Offset = "0x28")]
		private PycjmpJumpAbility m_jumpAbility;

		// Token: 0x040158D9 RID: 88281
		[Token(Token = "0x40158D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040158DA RID: 88282
		[Token(Token = "0x40158DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040158DB RID: 88283
		[Token(Token = "0x40158DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x040158DC RID: 88284
		[Token(Token = "0x40158DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RunActions;

		// Token: 0x040158DD RID: 88285
		[Token(Token = "0x40158DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C26 RID: 11302
		[Token(Token = "0x2002C26")]
		[Serializable]
		public class JumpEndAction
		{
			// Token: 0x0601316A RID: 78186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601316A")]
			[Address(RVA = "0xB1C670", Offset = "0xB1B270", VA = "0x180B1C670")]
			public JumpEndAction()
			{
			}

			// Token: 0x040158DE RID: 88286
			[Token(Token = "0x40158DE")]
			[FieldOffset(Offset = "0x10")]
			public PycjmpJumpAbility.JumpEndType jumpEndType;

			// Token: 0x040158DF RID: 88287
			[Token(Token = "0x40158DF")]
			[FieldOffset(Offset = "0x18")]
			public ActionArray actions;
		}
	}
}
