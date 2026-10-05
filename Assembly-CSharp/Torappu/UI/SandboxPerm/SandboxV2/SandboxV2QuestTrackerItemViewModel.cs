using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004233 RID: 16947
	[Token(Token = "0x2004233")]
	public class SandboxV2QuestTrackerItemViewModel : IHotfixable, IComparable<SandboxV2QuestTrackerItemViewModel>
	{
		// Token: 0x0601A218 RID: 107032 RVA: 0x000A0578 File Offset: 0x0009E778
		[Token(Token = "0x601A218")]
		[Address(RVA = "0x130C890", Offset = "0x130B490", VA = "0x18130C890", Slot = "4")]
		public int CompareTo(SandboxV2QuestTrackerItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A219 RID: 107033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A219")]
		[Address(RVA = "0x130C930", Offset = "0x130B530", VA = "0x18130C930")]
		public SandboxV2QuestTrackerItemViewModel()
		{
		}

		// Token: 0x04020FD6 RID: 135126
		[Token(Token = "0x4020FD6")]
		[FieldOffset(Offset = "0x10")]
		public string questId;

		// Token: 0x04020FD7 RID: 135127
		[Token(Token = "0x4020FD7")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2QuestTrackerFloatViewModel> nodeFloats;

		// Token: 0x04020FD8 RID: 135128
		[Token(Token = "0x4020FD8")]
		[FieldOffset(Offset = "0x20")]
		public int selectedNodeIndex;

		// Token: 0x04020FD9 RID: 135129
		[Token(Token = "0x4020FD9")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		// Token: 0x04020FDA RID: 135130
		[Token(Token = "0x4020FDA")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x04020FDB RID: 135131
		[Token(Token = "0x4020FDB")]
		[FieldOffset(Offset = "0x38")]
		public string targetDesc;

		// Token: 0x04020FDC RID: 135132
		[Token(Token = "0x4020FDC")]
		[FieldOffset(Offset = "0x40")]
		public string progress;

		// Token: 0x04020FDD RID: 135133
		[Token(Token = "0x4020FDD")]
		[FieldOffset(Offset = "0x48")]
		public string target;

		// Token: 0x04020FDE RID: 135134
		[Token(Token = "0x4020FDE")]
		[FieldOffset(Offset = "0x50")]
		public bool showProgress;

		// Token: 0x04020FDF RID: 135135
		[Token(Token = "0x4020FDF")]
		[FieldOffset(Offset = "0x54")]
		public SandboxV2QuestLineBadgeType badgeType;

		// Token: 0x04020FE0 RID: 135136
		[Token(Token = "0x4020FE0")]
		[FieldOffset(Offset = "0x58")]
		public SandboxV2QuestRouteType routeType;

		// Token: 0x04020FE1 RID: 135137
		[Token(Token = "0x4020FE1")]
		[FieldOffset(Offset = "0x60")]
		public string routeParam;

		// Token: 0x04020FE2 RID: 135138
		[Token(Token = "0x4020FE2")]
		[FieldOffset(Offset = "0x68")]
		public int questLineSortId;

		// Token: 0x04020FE3 RID: 135139
		[Token(Token = "0x4020FE3")]
		[FieldOffset(Offset = "0x6C")]
		public int unlockSortId;

		// Token: 0x04020FE4 RID: 135140
		[Token(Token = "0x4020FE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04020FE5 RID: 135141
		[Token(Token = "0x4020FE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
