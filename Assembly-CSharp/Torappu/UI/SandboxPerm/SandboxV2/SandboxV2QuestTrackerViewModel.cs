using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004235 RID: 16949
	[Token(Token = "0x2004235")]
	public class SandboxV2QuestTrackerViewModel : IHotfixable
	{
		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0601A21C RID: 107036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E22")]
		public string topicId
		{
			[Token(Token = "0x601A21C")]
			[Address(RVA = "0x130EF20", Offset = "0x130DB20", VA = "0x18130EF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0601A21D RID: 107037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E23")]
		public ListDict<string, SandboxV2QuestTrackerItemViewModel> questViewModels
		{
			[Token(Token = "0x601A21D")]
			[Address(RVA = "0x130EEC0", Offset = "0x130DAC0", VA = "0x18130EEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0601A21E RID: 107038 RVA: 0x000A05A8 File Offset: 0x0009E7A8
		[Token(Token = "0x17003E24")]
		public int enterSeq
		{
			[Token(Token = "0x601A21E")]
			[Address(RVA = "0x130EE60", Offset = "0x130DA60", VA = "0x18130EE60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A21F RID: 107039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A21F")]
		[Address(RVA = "0x130E220", Offset = "0x130CE20", VA = "0x18130E220")]
		public void LoadData(string topicId, List<SandboxV2DungeonNodeViewModel> nodeList)
		{
		}

		// Token: 0x0601A220 RID: 107040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A220")]
		[Address(RVA = "0x130E9D0", Offset = "0x130D5D0", VA = "0x18130E9D0")]
		public void NotifyEnterSeq()
		{
		}

		// Token: 0x0601A221 RID: 107041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A221")]
		[Address(RVA = "0x130EA30", Offset = "0x130D630", VA = "0x18130EA30")]
		private List<SandboxV2QuestTrackerFloatViewModel> _FilterTrackerFloat(SandboxV2QuestRouteType routeType, List<SandboxV2DungeonFloatViewModel> floatViewModels, string routeParam)
		{
			return null;
		}

		// Token: 0x0601A222 RID: 107042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A222")]
		[Address(RVA = "0x130EDB0", Offset = "0x130D9B0", VA = "0x18130EDB0")]
		public SandboxV2QuestTrackerViewModel()
		{
		}

		// Token: 0x04020FE8 RID: 135144
		[Token(Token = "0x4020FE8")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04020FE9 RID: 135145
		[Token(Token = "0x4020FE9")]
		[FieldOffset(Offset = "0x18")]
		private int m_enterSeq;

		// Token: 0x04020FEA RID: 135146
		[Token(Token = "0x4020FEA")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, SandboxV2QuestTrackerItemViewModel> m_questViewModels;

		// Token: 0x04020FEB RID: 135147
		[Token(Token = "0x4020FEB")]
		[FieldOffset(Offset = "0x28")]
		public string selectedId;

		// Token: 0x04020FEC RID: 135148
		[Token(Token = "0x4020FEC")]
		[FieldOffset(Offset = "0x30")]
		public string confirmedNodeId;

		// Token: 0x04020FED RID: 135149
		[Token(Token = "0x4020FED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020FEE RID: 135150
		[Token(Token = "0x4020FEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_questViewModels;

		// Token: 0x04020FEF RID: 135151
		[Token(Token = "0x4020FEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x04020FF0 RID: 135152
		[Token(Token = "0x4020FF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020FF1 RID: 135153
		[Token(Token = "0x4020FF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyEnterSeq;

		// Token: 0x04020FF2 RID: 135154
		[Token(Token = "0x4020FF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FilterTrackerFloat;

		// Token: 0x04020FF3 RID: 135155
		[Token(Token = "0x4020FF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
