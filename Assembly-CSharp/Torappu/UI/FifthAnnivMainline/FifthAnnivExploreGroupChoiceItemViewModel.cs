using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC5 RID: 20165
	[Token(Token = "0x2004EC5")]
	public class FifthAnnivExploreGroupChoiceItemViewModel : IHotfixable
	{
		// Token: 0x0601E17C RID: 123260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E17C")]
		[Address(RVA = "0x17CAB50", Offset = "0x17C9750", VA = "0x1817CAB50")]
		public void LoadGroupData(FifthAnnivExploreGroupData groupData, [Optional] PlayerMainlineExplore.PlayerExploreGameResult heritageData)
		{
		}

		// Token: 0x0601E17D RID: 123261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E17D")]
		[Address(RVA = "0x17CAC40", Offset = "0x17C9840", VA = "0x1817CAC40")]
		public FifthAnnivExploreGroupChoiceItemViewModel()
		{
		}

		// Token: 0x0402807F RID: 163967
		[Token(Token = "0x402807F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isSelected;

		// Token: 0x04028080 RID: 163968
		[Token(Token = "0x4028080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		// Token: 0x04028081 RID: 163969
		[Token(Token = "0x4028081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FifthAnnivExploreGroupData groupData;

		// Token: 0x04028082 RID: 163970
		[Token(Token = "0x4028082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FifthAnnivExploreValueGroupViewModel valueGroupViewModel;

		// Token: 0x04028083 RID: 163971
		[Token(Token = "0x4028083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadGroupData;

		// Token: 0x04028084 RID: 163972
		[Token(Token = "0x4028084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
