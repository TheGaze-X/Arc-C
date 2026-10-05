using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042E5 RID: 17125
	[Token(Token = "0x20042E5")]
	public class SandboxV2DungeonEventGroupViewModel : IHotfixable
	{
		// Token: 0x0601A54F RID: 107855 RVA: 0x000A14F0 File Offset: 0x0009F6F0
		[Token(Token = "0x601A54F")]
		[Address(RVA = "0x132CD90", Offset = "0x132B990", VA = "0x18132CD90")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601A550 RID: 107856 RVA: 0x000A1508 File Offset: 0x0009F708
		[Token(Token = "0x601A550")]
		[Address(RVA = "0x132CBD0", Offset = "0x132B7D0", VA = "0x18132CBD0")]
		public bool HasOriginalUnfinished()
		{
			return default(bool);
		}

		// Token: 0x0601A551 RID: 107857 RVA: 0x000A1520 File Offset: 0x0009F720
		[Token(Token = "0x601A551")]
		[Address(RVA = "0x132CCB0", Offset = "0x132B8B0", VA = "0x18132CCB0")]
		public bool HasUnfinished()
		{
			return default(bool);
		}

		// Token: 0x0601A552 RID: 107858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A552")]
		[Address(RVA = "0x132CB30", Offset = "0x132B730", VA = "0x18132CB30")]
		public void Clear()
		{
		}

		// Token: 0x0601A553 RID: 107859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A553")]
		[Address(RVA = "0x132CA90", Offset = "0x132B690", VA = "0x18132CA90")]
		public void AddEvent(SandboxV2DungeonEventViewModel viewModel)
		{
		}

		// Token: 0x0601A554 RID: 107860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A554")]
		[Address(RVA = "0x132CE10", Offset = "0x132BA10", VA = "0x18132CE10")]
		public SandboxV2DungeonEventGroupViewModel()
		{
		}

		// Token: 0x04021646 RID: 136774
		[Token(Token = "0x4021646")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2DungeonEventViewModel> eventList;

		// Token: 0x04021647 RID: 136775
		[Token(Token = "0x4021647")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04021648 RID: 136776
		[Token(Token = "0x4021648")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasOriginalUnfinished;

		// Token: 0x04021649 RID: 136777
		[Token(Token = "0x4021649")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HasUnfinished;

		// Token: 0x0402164A RID: 136778
		[Token(Token = "0x402164A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0402164B RID: 136779
		[Token(Token = "0x402164B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddEvent;

		// Token: 0x0402164C RID: 136780
		[Token(Token = "0x402164C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
