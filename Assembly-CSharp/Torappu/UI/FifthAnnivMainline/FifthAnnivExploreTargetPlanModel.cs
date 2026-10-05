using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EA1 RID: 20129
	[Token(Token = "0x2004EA1")]
	public class FifthAnnivExploreTargetPlanModel : FifthAnnivExplorePlanModel
	{
		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x0601E086 RID: 123014 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E087 RID: 123015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004676")]
		public string displayNum
		{
			[Token(Token = "0x601E086")]
			[Address(RVA = "0x17C3390", Offset = "0x17C1F90", VA = "0x1817C3390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E087")]
			[Address(RVA = "0x17C33F0", Offset = "0x17C1FF0", VA = "0x1817C33F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E088 RID: 123016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E088")]
		[Address(RVA = "0x17C3020", Offset = "0x17C1C20", VA = "0x1817C3020")]
		public void LoadData(string nextStageId, List<string> playerTargetList)
		{
		}

		// Token: 0x0601E089 RID: 123017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E089")]
		[Address(RVA = "0x17C3330", Offset = "0x17C1F30", VA = "0x1817C3330")]
		public FifthAnnivExploreTargetPlanModel()
		{
		}

		// Token: 0x04027EF7 RID: 163575
		[Token(Token = "0x4027EF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayNum;

		// Token: 0x04027EF8 RID: 163576
		[Token(Token = "0x4027EF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_displayNum;

		// Token: 0x04027EF9 RID: 163577
		[Token(Token = "0x4027EF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027EFA RID: 163578
		[Token(Token = "0x4027EFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
