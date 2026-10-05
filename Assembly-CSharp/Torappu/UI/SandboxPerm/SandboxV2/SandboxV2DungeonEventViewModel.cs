using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042E3 RID: 17123
	[Token(Token = "0x20042E3")]
	public class SandboxV2DungeonEventViewModel : SandboxV2DungeonFloatViewModel
	{
		// Token: 0x0601A54B RID: 107851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A54B")]
		[Address(RVA = "0x132D0D0", Offset = "0x132BCD0", VA = "0x18132D0D0")]
		public void UpdateData(SandboxV2DungeonEventViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A54C RID: 107852 RVA: 0x000A14C0 File Offset: 0x0009F6C0
		[Token(Token = "0x601A54C")]
		[Address(RVA = "0x132CFE0", Offset = "0x132BBE0", VA = "0x18132CFE0", Slot = "4")]
		public override int CompareDungeonFloat(SandboxV2DungeonFloatViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A54D RID: 107853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A54D")]
		[Address(RVA = "0x132D350", Offset = "0x132BF50", VA = "0x18132D350")]
		public SandboxV2DungeonEventViewModel()
		{
		}

		// Token: 0x0601A54E RID: 107854 RVA: 0x000A14D8 File Offset: 0x0009F6D8
		[Token(Token = "0x601A54E")]
		[Address(RVA = "0x132BFB0", Offset = "0x132ABB0", VA = "0x18132BFB0")]
		private int <>xLuaBaseProxy_CompareDungeonFloat(SandboxV2DungeonFloatViewModel P0)
		{
			return 0;
		}

		// Token: 0x04021637 RID: 136759
		[Token(Token = "0x4021637")]
		private const string FLOAT_ICON_ID_ENCOUNTER = "img_encounter";

		// Token: 0x04021638 RID: 136760
		[Token(Token = "0x4021638")]
		private const string FLOAT_ICON_ID_EXPEDITION = "img_expedition";

		// Token: 0x04021639 RID: 136761
		[Token(Token = "0x4021639")]
		private const string UNIQUE_ID_FORMAT = "event_{0}";

		// Token: 0x0402163A RID: 136762
		[Token(Token = "0x402163A")]
		[FieldOffset(Offset = "0x60")]
		public string eventId;

		// Token: 0x0402163B RID: 136763
		[Token(Token = "0x402163B")]
		[FieldOffset(Offset = "0x68")]
		public int instId;

		// Token: 0x0402163C RID: 136764
		[Token(Token = "0x402163C")]
		[FieldOffset(Offset = "0x6C")]
		public SandboxV2EventType eventType;

		// Token: 0x0402163D RID: 136765
		[Token(Token = "0x402163D")]
		[FieldOffset(Offset = "0x70")]
		public string sceneId;

		// Token: 0x0402163E RID: 136766
		[Token(Token = "0x402163E")]
		[FieldOffset(Offset = "0x78")]
		public bool finished;

		// Token: 0x0402163F RID: 136767
		[Token(Token = "0x402163F")]
		[FieldOffset(Offset = "0x79")]
		public bool isOriginal;

		// Token: 0x04021640 RID: 136768
		[Token(Token = "0x4021640")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04021641 RID: 136769
		[Token(Token = "0x4021641")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareDungeonFloat;

		// Token: 0x04021642 RID: 136770
		[Token(Token = "0x4021642")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042E4 RID: 17124
		[Token(Token = "0x20042E4")]
		public struct UpdateParam
		{
			// Token: 0x04021643 RID: 136771
			[Token(Token = "0x4021643")]
			[FieldOffset(Offset = "0x0")]
			public string nodeId;

			// Token: 0x04021644 RID: 136772
			[Token(Token = "0x4021644")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021645 RID: 136773
			[Token(Token = "0x4021645")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon.EventGroup.Event playerEventData;
		}
	}
}
