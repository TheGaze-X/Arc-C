using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049FA RID: 18938
	[Token(Token = "0x20049FA")]
	public class InformantCustomerBarViewModel : IHotfixable
	{
		// Token: 0x0601C824 RID: 116772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C824")]
		[Address(RVA = "0x15F50E0", Offset = "0x15F3CE0", VA = "0x1815F50E0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C825 RID: 116773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C825")]
		[Address(RVA = "0x15F5160", Offset = "0x15F3D60", VA = "0x1815F5160")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601C826 RID: 116774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C826")]
		[Address(RVA = "0x15F5360", Offset = "0x15F3F60", VA = "0x1815F5360")]
		public InformantCustomerBarViewModel()
		{
		}

		// Token: 0x040255B2 RID: 153010
		[Token(Token = "0x40255B2")]
		[FieldOffset(Offset = "0x10")]
		public List<bool> customerList;

		// Token: 0x040255B3 RID: 153011
		[Token(Token = "0x40255B3")]
		[FieldOffset(Offset = "0x18")]
		public int currentIndex;

		// Token: 0x040255B4 RID: 153012
		[Token(Token = "0x40255B4")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x040255B5 RID: 153013
		[Token(Token = "0x40255B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040255B6 RID: 153014
		[Token(Token = "0x40255B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040255B7 RID: 153015
		[Token(Token = "0x40255B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
