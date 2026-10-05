using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC9 RID: 20169
	[Token(Token = "0x2004EC9")]
	public class FifthAnnivExploreValueGroupViewModel : IHotfixable
	{
		// Token: 0x0601E182 RID: 123266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E182")]
		[Address(RVA = "0x17DA9E0", Offset = "0x17D95E0", VA = "0x1817DA9E0")]
		private void _LoadConstData()
		{
		}

		// Token: 0x0601E183 RID: 123267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E183")]
		[Address(RVA = "0x17DA540", Offset = "0x17D9140", VA = "0x1817DA540")]
		public void LoadInitialData(FifthAnnivExploreGroupData groupData, [Optional] PlayerMainlineExplore.PlayerExploreGameResult heritageData)
		{
		}

		// Token: 0x0601E184 RID: 123268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E184")]
		[Address(RVA = "0x17DA250", Offset = "0x17D8E50", VA = "0x1817DA250")]
		public void LoadDataAndDeltaWithOld(PlayerMainlineExplore.PlayerExploreGameContextState state)
		{
		}

		// Token: 0x0601E185 RID: 123269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E185")]
		[Address(RVA = "0x17DA890", Offset = "0x17D9490", VA = "0x1817DA890")]
		public void SetShowDeltaValue(bool showDeltaValue)
		{
		}

		// Token: 0x0601E186 RID: 123270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E186")]
		[Address(RVA = "0x17DAAB0", Offset = "0x17D96B0", VA = "0x1817DAAB0")]
		public FifthAnnivExploreValueGroupViewModel()
		{
		}

		// Token: 0x0402808E RID: 163982
		[Token(Token = "0x402808E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ListDict<string, FifthAnnivExploreValueViewModel> valueViewModels;

		// Token: 0x0402808F RID: 163983
		[Token(Token = "0x402808F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> valueOrders;

		// Token: 0x04028090 RID: 163984
		[Token(Token = "0x4028090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showNum;

		// Token: 0x04028091 RID: 163985
		[Token(Token = "0x4028091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadConstData;

		// Token: 0x04028092 RID: 163986
		[Token(Token = "0x4028092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadInitialData;

		// Token: 0x04028093 RID: 163987
		[Token(Token = "0x4028093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadDataAndDeltaWithOld;

		// Token: 0x04028094 RID: 163988
		[Token(Token = "0x4028094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShowDeltaValue;

		// Token: 0x04028095 RID: 163989
		[Token(Token = "0x4028095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
