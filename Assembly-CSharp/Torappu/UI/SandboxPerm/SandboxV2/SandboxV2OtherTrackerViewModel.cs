using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200422F RID: 16943
	[Token(Token = "0x200422F")]
	public class SandboxV2OtherTrackerViewModel : IHotfixable
	{
		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0601A20D RID: 107021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E1F")]
		public string topicId
		{
			[Token(Token = "0x601A20D")]
			[Address(RVA = "0x130C320", Offset = "0x130AF20", VA = "0x18130C320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0601A20E RID: 107022 RVA: 0x000A0548 File Offset: 0x0009E748
		[Token(Token = "0x17003E20")]
		public int enterSeq
		{
			[Token(Token = "0x601A20E")]
			[Address(RVA = "0x130C260", Offset = "0x130AE60", VA = "0x18130C260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0601A20F RID: 107023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E21")]
		public ListDict<string, SandboxV2OtherTrackerItemViewModel> itemViewModels
		{
			[Token(Token = "0x601A20F")]
			[Address(RVA = "0x130C2C0", Offset = "0x130AEC0", VA = "0x18130C2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A210 RID: 107024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A210")]
		[Address(RVA = "0x130BCF0", Offset = "0x130A8F0", VA = "0x18130BCF0")]
		public void LoadData(string topicId, List<SandboxV2DungeonNodeViewModel> nodeList)
		{
		}

		// Token: 0x0601A211 RID: 107025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A211")]
		[Address(RVA = "0x130BC30", Offset = "0x130A830", VA = "0x18130BC30")]
		public string GetSelectedNodeId()
		{
			return null;
		}

		// Token: 0x0601A212 RID: 107026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A212")]
		[Address(RVA = "0x130C150", Offset = "0x130AD50", VA = "0x18130C150")]
		public void NotifyEnterSeq()
		{
		}

		// Token: 0x0601A213 RID: 107027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A213")]
		[Address(RVA = "0x130C1B0", Offset = "0x130ADB0", VA = "0x18130C1B0")]
		public SandboxV2OtherTrackerViewModel()
		{
		}

		// Token: 0x04020FC6 RID: 135110
		[Token(Token = "0x4020FC6")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04020FC7 RID: 135111
		[Token(Token = "0x4020FC7")]
		[FieldOffset(Offset = "0x18")]
		private int m_enterSeq;

		// Token: 0x04020FC8 RID: 135112
		[Token(Token = "0x4020FC8")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, SandboxV2OtherTrackerItemViewModel> m_itemViewModels;

		// Token: 0x04020FC9 RID: 135113
		[Token(Token = "0x4020FC9")]
		[FieldOffset(Offset = "0x28")]
		public string selectedId;

		// Token: 0x04020FCA RID: 135114
		[Token(Token = "0x4020FCA")]
		[FieldOffset(Offset = "0x30")]
		public string confirmedNodeId;

		// Token: 0x04020FCB RID: 135115
		[Token(Token = "0x4020FCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020FCC RID: 135116
		[Token(Token = "0x4020FCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x04020FCD RID: 135117
		[Token(Token = "0x4020FCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemViewModels;

		// Token: 0x04020FCE RID: 135118
		[Token(Token = "0x4020FCE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020FCF RID: 135119
		[Token(Token = "0x4020FCF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSelectedNodeId;

		// Token: 0x04020FD0 RID: 135120
		[Token(Token = "0x4020FD0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyEnterSeq;

		// Token: 0x04020FD1 RID: 135121
		[Token(Token = "0x4020FD1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
