using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BB6 RID: 19382
	[Token(Token = "0x2004BB6")]
	public class HomeMailArchiveViewModel : IHotfixable
	{
		// Token: 0x0601D21C RID: 119324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D21C")]
		[Address(RVA = "0x169CA50", Offset = "0x169B650", VA = "0x18169CA50")]
		public void Clear()
		{
		}

		// Token: 0x0601D21D RID: 119325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D21D")]
		[Address(RVA = "0x169CB70", Offset = "0x169B770", VA = "0x18169CB70")]
		public void LoadData(List<string> unlockList, List<MailArchiveItemData> extraData)
		{
		}

		// Token: 0x0601D21E RID: 119326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D21E")]
		[Address(RVA = "0x169D4E0", Offset = "0x169C0E0", VA = "0x18169D4E0")]
		public HomeMailArchiveViewModel()
		{
		}

		// Token: 0x040263BD RID: 156605
		[Token(Token = "0x40263BD")]
		[FieldOffset(Offset = "0x10")]
		public List<HomeMailArchiveItemViewModel> itemModelList;

		// Token: 0x040263BE RID: 156606
		[Token(Token = "0x40263BE")]
		[FieldOffset(Offset = "0x18")]
		public List<HomeMailArchiveItemViewModel> itemModelWithoutTitle;

		// Token: 0x040263BF RID: 156607
		[Token(Token = "0x40263BF")]
		[FieldOffset(Offset = "0x20")]
		public List<HomeMailArchiveItemViewModel> titleItemModelList;

		// Token: 0x040263C0 RID: 156608
		[Token(Token = "0x40263C0")]
		[FieldOffset(Offset = "0x28")]
		public int selectItemIndex;

		// Token: 0x040263C1 RID: 156609
		[Token(Token = "0x40263C1")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, MailArchiveItemData> m_infoDict;

		// Token: 0x040263C2 RID: 156610
		[Token(Token = "0x40263C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x040263C3 RID: 156611
		[Token(Token = "0x40263C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040263C4 RID: 156612
		[Token(Token = "0x40263C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
