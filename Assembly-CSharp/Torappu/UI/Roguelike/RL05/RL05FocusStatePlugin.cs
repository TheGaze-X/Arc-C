using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055DA RID: 21978
	[Token(Token = "0x20055DA")]
	public class RL05FocusStatePlugin : RoguelikeFocusStatePlugin
	{
		// Token: 0x0602041F RID: 132127 RVA: 0x000B5140 File Offset: 0x000B3340
		[Token(Token = "0x602041F")]
		[Address(RVA = "0x1A60E30", Offset = "0x1A5FA30", VA = "0x181A60E30", Slot = "4")]
		public override ValueBundle GetRollNodeDialogOptionExtraData(string topicId)
		{
			return default(ValueBundle);
		}

		// Token: 0x06020420 RID: 132128 RVA: 0x000B5158 File Offset: 0x000B3358
		[Token(Token = "0x6020420")]
		[Address(RVA = "0x1A60F00", Offset = "0x1A5FB00", VA = "0x181A60F00", Slot = "5")]
		public override bool PassRollNodeItemChecker(string topicId, RoguelikeTopicDetail topicData, RoguelikeDungeonNode focusNode)
		{
			return default(bool);
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x06020421 RID: 132129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B9C")]
		public override string rollSucToast
		{
			[Token(Token = "0x6020421")]
			[Address(RVA = "0x1A611B0", Offset = "0x1A5FDB0", VA = "0x181A611B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x06020422 RID: 132130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B9D")]
		public override List<ICheckNodeUnlockStrategy> dynamicCheckNodeUnlockStrategies
		{
			[Token(Token = "0x6020422")]
			[Address(RVA = "0x1A61090", Offset = "0x1A5FC90", VA = "0x181A61090", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020423 RID: 132131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020423")]
		[Address(RVA = "0x1A61030", Offset = "0x1A5FC30", VA = "0x181A61030")]
		public RL05FocusStatePlugin()
		{
		}

		// Token: 0x06020424 RID: 132132 RVA: 0x000B5170 File Offset: 0x000B3370
		[Token(Token = "0x6020424")]
		[Address(RVA = "0x1A60FD0", Offset = "0x1A5FBD0", VA = "0x181A60FD0")]
		private ValueBundle <>xLuaBaseProxy_GetRollNodeDialogOptionExtraData(string P0)
		{
			return default(ValueBundle);
		}

		// Token: 0x06020425 RID: 132133 RVA: 0x000B5188 File Offset: 0x000B3388
		[Token(Token = "0x6020425")]
		[Address(RVA = "0x1A61000", Offset = "0x1A5FC00", VA = "0x181A61000")]
		private bool <>xLuaBaseProxy_PassRollNodeItemChecker(string P0, RoguelikeTopicDetail P1, RoguelikeDungeonNode P2)
		{
			return default(bool);
		}

		// Token: 0x06020426 RID: 132134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020426")]
		[Address(RVA = "0x1A61020", Offset = "0x1A5FC20", VA = "0x181A61020")]
		private string <>xLuaBaseProxy_get_rollSucToast()
		{
			return null;
		}

		// Token: 0x06020427 RID: 132135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020427")]
		[Address(RVA = "0x1A61010", Offset = "0x1A5FC10", VA = "0x181A61010")]
		private List<ICheckNodeUnlockStrategy> <>xLuaBaseProxy_get_dynamicCheckNodeUnlockStrategies()
		{
			return null;
		}

		// Token: 0x0402BA3D RID: 178749
		[Token(Token = "0x402BA3D")]
		[FieldOffset(Offset = "0x18")]
		private List<ICheckNodeUnlockStrategy> m_dynamicCheckNodeUnlockStrategies;

		// Token: 0x0402BA3E RID: 178750
		[Token(Token = "0x402BA3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRollNodeDialogOptionExtraData;

		// Token: 0x0402BA3F RID: 178751
		[Token(Token = "0x402BA3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PassRollNodeItemChecker;

		// Token: 0x0402BA40 RID: 178752
		[Token(Token = "0x402BA40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rollSucToast;

		// Token: 0x0402BA41 RID: 178753
		[Token(Token = "0x402BA41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_dynamicCheckNodeUnlockStrategies;

		// Token: 0x0402BA42 RID: 178754
		[Token(Token = "0x402BA42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
