using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049FE RID: 18942
	[Token(Token = "0x20049FE")]
	public class InformantCustomerInfoViewModel : IHotfixable
	{
		// Token: 0x0601C82D RID: 116781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C82D")]
		[Address(RVA = "0x15F59F0", Offset = "0x15F45F0", VA = "0x1815F59F0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C82E RID: 116782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C82E")]
		[Address(RVA = "0x15F5A70", Offset = "0x15F4670", VA = "0x1815F5A70")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601C82F RID: 116783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C82F")]
		[Address(RVA = "0x15F5D90", Offset = "0x15F4990", VA = "0x1815F5D90")]
		public InformantCustomerInfoViewModel()
		{
		}

		// Token: 0x040255C5 RID: 153029
		[Token(Token = "0x40255C5")]
		[FieldOffset(Offset = "0x10")]
		public string customerId;

		// Token: 0x040255C6 RID: 153030
		[Token(Token = "0x40255C6")]
		[FieldOffset(Offset = "0x18")]
		public string customerName;

		// Token: 0x040255C7 RID: 153031
		[Token(Token = "0x40255C7")]
		[FieldOffset(Offset = "0x20")]
		public string customerAVGCharId;

		// Token: 0x040255C8 RID: 153032
		[Token(Token = "0x40255C8")]
		[FieldOffset(Offset = "0x28")]
		public string customerDesc;

		// Token: 0x040255C9 RID: 153033
		[Token(Token = "0x40255C9")]
		[FieldOffset(Offset = "0x30")]
		public string customerIconId;

		// Token: 0x040255CA RID: 153034
		[Token(Token = "0x40255CA")]
		[FieldOffset(Offset = "0x38")]
		public bool isCustomerUnlocked;

		// Token: 0x040255CB RID: 153035
		[Token(Token = "0x40255CB")]
		[FieldOffset(Offset = "0x40")]
		public string tagId;

		// Token: 0x040255CC RID: 153036
		[Token(Token = "0x40255CC")]
		[FieldOffset(Offset = "0x48")]
		public string tagName;

		// Token: 0x040255CD RID: 153037
		[Token(Token = "0x40255CD")]
		[FieldOffset(Offset = "0x50")]
		public string tagDesc;

		// Token: 0x040255CE RID: 153038
		[Token(Token = "0x40255CE")]
		[FieldOffset(Offset = "0x58")]
		public bool isTagUnlocked;

		// Token: 0x040255CF RID: 153039
		[Token(Token = "0x40255CF")]
		[FieldOffset(Offset = "0x60")]
		private string m_actId;

		// Token: 0x040255D0 RID: 153040
		[Token(Token = "0x40255D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040255D1 RID: 153041
		[Token(Token = "0x40255D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040255D2 RID: 153042
		[Token(Token = "0x40255D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
