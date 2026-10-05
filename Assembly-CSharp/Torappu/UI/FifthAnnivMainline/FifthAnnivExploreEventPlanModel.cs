using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EA2 RID: 20130
	[Token(Token = "0x2004EA2")]
	public class FifthAnnivExploreEventPlanModel : FifthAnnivExplorePlanModel
	{
		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x0601E08A RID: 123018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E08B RID: 123019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004677")]
		public string iconId
		{
			[Token(Token = "0x601E08A")]
			[Address(RVA = "0x17BB670", Offset = "0x17BA270", VA = "0x1817BB670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E08B")]
			[Address(RVA = "0x17BB6D0", Offset = "0x17BA2D0", VA = "0x1817BB6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E08C RID: 123020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E08C")]
		[Address(RVA = "0x17BB300", Offset = "0x17B9F00", VA = "0x1817BB300")]
		public void LoadData(string eventId, List<PlayerMainlineExplore.PlayerExploreGameContextNodeEventChoice> choices)
		{
		}

		// Token: 0x0601E08D RID: 123021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E08D")]
		[Address(RVA = "0x17BB610", Offset = "0x17BA210", VA = "0x1817BB610")]
		public FifthAnnivExploreEventPlanModel()
		{
		}

		// Token: 0x04027EFC RID: 163580
		[Token(Token = "0x4027EFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x04027EFD RID: 163581
		[Token(Token = "0x4027EFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_iconId;

		// Token: 0x04027EFE RID: 163582
		[Token(Token = "0x4027EFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027EFF RID: 163583
		[Token(Token = "0x4027EFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
