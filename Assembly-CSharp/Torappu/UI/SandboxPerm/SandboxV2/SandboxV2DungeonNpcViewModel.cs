using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042E9 RID: 17129
	[Token(Token = "0x20042E9")]
	public class SandboxV2DungeonNpcViewModel : SandboxV2DungeonFloatViewModel
	{
		// Token: 0x0601A55D RID: 107869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A55D")]
		[Address(RVA = "0x133A110", Offset = "0x1338D10", VA = "0x18133A110")]
		public void UpdateData(SandboxV2DungeonNpcViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A55E RID: 107870 RVA: 0x000A1580 File Offset: 0x0009F780
		[Token(Token = "0x601A55E")]
		[Address(RVA = "0x133A020", Offset = "0x1338C20", VA = "0x18133A020", Slot = "4")]
		public override int CompareDungeonFloat(SandboxV2DungeonFloatViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A55F RID: 107871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A55F")]
		[Address(RVA = "0x133A510", Offset = "0x1339110", VA = "0x18133A510")]
		public SandboxV2DungeonNpcViewModel()
		{
		}

		// Token: 0x0601A560 RID: 107872 RVA: 0x000A1598 File Offset: 0x0009F798
		[Token(Token = "0x601A560")]
		[Address(RVA = "0x132BFB0", Offset = "0x132ABB0", VA = "0x18132BFB0")]
		private int <>xLuaBaseProxy_CompareDungeonFloat(SandboxV2DungeonFloatViewModel P0)
		{
			return 0;
		}

		// Token: 0x04021663 RID: 136803
		[Token(Token = "0x4021663")]
		private const string UNIQUE_ID_FORMAT = "npc_{0}";

		// Token: 0x04021664 RID: 136804
		[Token(Token = "0x4021664")]
		[FieldOffset(Offset = "0x60")]
		public string npcId;

		// Token: 0x04021665 RID: 136805
		[Token(Token = "0x4021665")]
		[FieldOffset(Offset = "0x68")]
		public int instId;

		// Token: 0x04021666 RID: 136806
		[Token(Token = "0x4021666")]
		[FieldOffset(Offset = "0x6C")]
		public bool isBlackMarketNpc;

		// Token: 0x04021667 RID: 136807
		[Token(Token = "0x4021667")]
		[FieldOffset(Offset = "0x70")]
		public string npcTrapId;

		// Token: 0x04021668 RID: 136808
		[Token(Token = "0x4021668")]
		[FieldOffset(Offset = "0x78")]
		public bool enabled;

		// Token: 0x04021669 RID: 136809
		[Token(Token = "0x4021669")]
		[FieldOffset(Offset = "0x7C")]
		public SandboxV2NpcType npcType;

		// Token: 0x0402166A RID: 136810
		[Token(Token = "0x402166A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402166B RID: 136811
		[Token(Token = "0x402166B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareDungeonFloat;

		// Token: 0x0402166C RID: 136812
		[Token(Token = "0x402166C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042EA RID: 17130
		[Token(Token = "0x20042EA")]
		public struct UpdateParam
		{
			// Token: 0x0402166D RID: 136813
			[Token(Token = "0x402166D")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402166E RID: 136814
			[Token(Token = "0x402166E")]
			[FieldOffset(Offset = "0x8")]
			public string nodeId;

			// Token: 0x0402166F RID: 136815
			[Token(Token = "0x402166F")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021670 RID: 136816
			[Token(Token = "0x4021670")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Dungeon.NpcGroup.Npc playerNpcData;
		}
	}
}
