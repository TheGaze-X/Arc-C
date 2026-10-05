using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B1C RID: 27420
	[Token(Token = "0x2006B1C")]
	public class ArchiveBuffModel : IHotfixable
	{
		// Token: 0x0602732F RID: 160559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602732F")]
		[Address(RVA = "0x2263140", Offset = "0x2261D40", VA = "0x182263140")]
		public string GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x06027330 RID: 160560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027330")]
		[Address(RVA = "0x22632F0", Offset = "0x2261EF0", VA = "0x1822632F0")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027331 RID: 160561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027331")]
		[Address(RVA = "0x22639C0", Offset = "0x22625C0", VA = "0x1822639C0")]
		public ArchiveBuffModel()
		{
		}

		// Token: 0x0403775C RID: 227164
		[Token(Token = "0x403775C")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, BuffItemModel> buffItems;

		// Token: 0x0403775D RID: 227165
		[Token(Token = "0x403775D")]
		[FieldOffset(Offset = "0x18")]
		public string selectedBuffId;

		// Token: 0x0403775E RID: 227166
		[Token(Token = "0x403775E")]
		[FieldOffset(Offset = "0x20")]
		public List<ArchiveBuffGroupModel> buffGroups;

		// Token: 0x0403775F RID: 227167
		[Token(Token = "0x403775F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x04037760 RID: 227168
		[Token(Token = "0x4037760")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037761 RID: 227169
		[Token(Token = "0x4037761")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
