using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F11 RID: 20241
	[Token(Token = "0x2004F11")]
	public class FifthAnnivExploreSideInfoViewModel : IHotfixable
	{
		// Token: 0x0601E2A9 RID: 123561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A9")]
		[Address(RVA = "0x17D7F30", Offset = "0x17D6B30", VA = "0x1817D7F30")]
		public void LoadData()
		{
		}

		// Token: 0x0601E2AA RID: 123562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2AA")]
		[Address(RVA = "0x17D7C40", Offset = "0x17D6840", VA = "0x1817D7C40")]
		public void LoadData(FifthAnnivExploreData exploreData, PlayerMainlineExplore playerExplore)
		{
		}

		// Token: 0x0601E2AB RID: 123563 RVA: 0x000ADB50 File Offset: 0x000ABD50
		[Token(Token = "0x601E2AB")]
		[Address(RVA = "0x17D8010", Offset = "0x17D6C10", VA = "0x1817D8010")]
		private bool _IsNextCheckpoint(PlayerMainlineExplore playerExplore)
		{
			return default(bool);
		}

		// Token: 0x0601E2AC RID: 123564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2AC")]
		[Address(RVA = "0x17D80B0", Offset = "0x17D6CB0", VA = "0x1817D80B0")]
		public FifthAnnivExploreSideInfoViewModel()
		{
		}

		// Token: 0x040282A0 RID: 164512
		[Token(Token = "0x40282A0")]
		[FieldOffset(Offset = "0x10")]
		public string currentGroupName;

		// Token: 0x040282A1 RID: 164513
		[Token(Token = "0x40282A1")]
		[FieldOffset(Offset = "0x18")]
		public string currentGroupCode;

		// Token: 0x040282A2 RID: 164514
		[Token(Token = "0x40282A2")]
		[FieldOffset(Offset = "0x20")]
		public string currentGroupDesc;

		// Token: 0x040282A3 RID: 164515
		[Token(Token = "0x40282A3")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> previousAbilityValues;

		// Token: 0x040282A4 RID: 164516
		[Token(Token = "0x40282A4")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> currentAbilityValues;

		// Token: 0x040282A5 RID: 164517
		[Token(Token = "0x40282A5")]
		[FieldOffset(Offset = "0x38")]
		public bool hasPrevValue;

		// Token: 0x040282A6 RID: 164518
		[Token(Token = "0x40282A6")]
		[FieldOffset(Offset = "0x39")]
		public bool isNextCheckpoint;

		// Token: 0x040282A7 RID: 164519
		[Token(Token = "0x40282A7")]
		[FieldOffset(Offset = "0x3A")]
		public bool isNextCheckpointFulfill;

		// Token: 0x040282A8 RID: 164520
		[Token(Token = "0x40282A8")]
		[FieldOffset(Offset = "0x40")]
		public FifthAnnivExploreValueGroupViewModel valueGroupViewModel;

		// Token: 0x040282A9 RID: 164521
		[Token(Token = "0x40282A9")]
		[FieldOffset(Offset = "0x48")]
		public string currentGroupIconId;

		// Token: 0x040282AA RID: 164522
		[Token(Token = "0x40282AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040282AB RID: 164523
		[Token(Token = "0x40282AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x040282AC RID: 164524
		[Token(Token = "0x40282AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__IsNextCheckpoint;

		// Token: 0x040282AD RID: 164525
		[Token(Token = "0x40282AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
