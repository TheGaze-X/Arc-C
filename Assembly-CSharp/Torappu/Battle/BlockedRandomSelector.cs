using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002504 RID: 9476
	[Token(Token = "0x2002504")]
	public class BlockedRandomSelector : RandomSelector
	{
		// Token: 0x0600F407 RID: 62471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F407")]
		[Address(RVA = "0x6B7900", Offset = "0x6B6500", VA = "0x1806B7900", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F408 RID: 62472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F408")]
		[Address(RVA = "0x6B7330", Offset = "0x6B5F30", VA = "0x1806B7330", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F409 RID: 62473 RVA: 0x0005A030 File Offset: 0x00058230
		[Token(Token = "0x600F409")]
		[Address(RVA = "0x6B7A90", Offset = "0x6B6690", VA = "0x1806B7A90", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F40A RID: 62474 RVA: 0x0005A048 File Offset: 0x00058248
		[Token(Token = "0x600F40A")]
		[Address(RVA = "0x6B7C10", Offset = "0x6B6810", VA = "0x1806B7C10")]
		private bool _ValidateWithTargetFree(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F40B RID: 62475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F40B")]
		[Address(RVA = "0x6B7D20", Offset = "0x6B6920", VA = "0x1806B7D20")]
		public BlockedRandomSelector()
		{
		}

		// Token: 0x0600F40C RID: 62476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F40C")]
		[Address(RVA = "0x6B7A80", Offset = "0x6B6680", VA = "0x1806B7A80")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F40D RID: 62477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F40D")]
		[Address(RVA = "0x6B7A70", Offset = "0x6B6670", VA = "0x1806B7A70")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x0600F40E RID: 62478 RVA: 0x0005A060 File Offset: 0x00058260
		[Token(Token = "0x600F40E")]
		[Address(RVA = "0x6A2DC0", Offset = "0x6A19C0", VA = "0x1806A2DC0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E33 RID: 69171
		[Token(Token = "0x4010E33")]
		[FieldOffset(Offset = "0xC0")]
		private Character m_character;

		// Token: 0x04010E34 RID: 69172
		[Token(Token = "0x4010E34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010E35 RID: 69173
		[Token(Token = "0x4010E35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E36 RID: 69174
		[Token(Token = "0x4010E36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E37 RID: 69175
		[Token(Token = "0x4010E37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ValidateWithTargetFree;

		// Token: 0x04010E38 RID: 69176
		[Token(Token = "0x4010E38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
