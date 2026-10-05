using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042DC RID: 17116
	[Token(Token = "0x20042DC")]
	public abstract class SandboxV2DungeonFloatViewModel : IHotfixable
	{
		// Token: 0x0601A53B RID: 107835 RVA: 0x000A1418 File Offset: 0x0009F618
		[Token(Token = "0x601A53B")]
		[Address(RVA = "0x132D7C0", Offset = "0x132C3C0", VA = "0x18132D7C0", Slot = "4")]
		public virtual int CompareDungeonFloat(SandboxV2DungeonFloatViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A53C RID: 107836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A53C")]
		[Address(RVA = "0x132D950", Offset = "0x132C550", VA = "0x18132D950")]
		protected SandboxV2DungeonFloatViewModel()
		{
		}

		// Token: 0x040215FD RID: 136701
		[Token(Token = "0x40215FD")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x040215FE RID: 136702
		[Token(Token = "0x40215FE")]
		[FieldOffset(Offset = "0x18")]
		public List<string> path;

		// Token: 0x040215FF RID: 136703
		[Token(Token = "0x40215FF")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2DungeonPathLineViewModel.PathType pathType;

		// Token: 0x04021600 RID: 136704
		[Token(Token = "0x4021600")]
		[FieldOffset(Offset = "0x24")]
		public bool showFloat;

		// Token: 0x04021601 RID: 136705
		[Token(Token = "0x4021601")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2QuestLineBadgeType badgeType;

		// Token: 0x04021602 RID: 136706
		[Token(Token = "0x4021602")]
		[FieldOffset(Offset = "0x30")]
		public string floatIconId;

		// Token: 0x04021603 RID: 136707
		[Token(Token = "0x4021603")]
		[FieldOffset(Offset = "0x38")]
		public string floatIconName;

		// Token: 0x04021604 RID: 136708
		[Token(Token = "0x4021604")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2FloatAppearanceType appearanceType;

		// Token: 0x04021605 RID: 136709
		[Token(Token = "0x4021605")]
		[FieldOffset(Offset = "0x44")]
		public PlayerSandboxV2.Dungeon.FloatSourceType srcType;

		// Token: 0x04021606 RID: 136710
		[Token(Token = "0x4021606")]
		[FieldOffset(Offset = "0x48")]
		public string srcId;

		// Token: 0x04021607 RID: 136711
		[Token(Token = "0x4021607")]
		[FieldOffset(Offset = "0x50")]
		public string uniqueId;

		// Token: 0x04021608 RID: 136712
		[Token(Token = "0x4021608")]
		[FieldOffset(Offset = "0x58")]
		public bool newlyAttached;

		// Token: 0x04021609 RID: 136713
		[Token(Token = "0x4021609")]
		[FieldOffset(Offset = "0x59")]
		public bool ignoreWhenNodeLocked;

		// Token: 0x0402160A RID: 136714
		[Token(Token = "0x402160A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareDungeonFloat;

		// Token: 0x0402160B RID: 136715
		[Token(Token = "0x402160B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
