using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B24 RID: 27428
	[Token(Token = "0x2006B24")]
	public class ArchiveCapsuleModel : IHotfixable
	{
		// Token: 0x0602735B RID: 160603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602735B")]
		[Address(RVA = "0x2265250", Offset = "0x2263E50", VA = "0x182265250")]
		public string GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x0602735C RID: 160604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602735C")]
		[Address(RVA = "0x2265330", Offset = "0x2263F30", VA = "0x182265330")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602735D RID: 160605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602735D")]
		[Address(RVA = "0x2265A90", Offset = "0x2264690", VA = "0x182265A90")]
		public ArchiveCapsuleModel()
		{
		}

		// Token: 0x040377A6 RID: 227238
		[Token(Token = "0x40377A6")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, CapsuleItemModel> capsuleItems;

		// Token: 0x040377A7 RID: 227239
		[Token(Token = "0x40377A7")]
		[FieldOffset(Offset = "0x18")]
		public string selectedCapsuleId;

		// Token: 0x040377A8 RID: 227240
		[Token(Token = "0x40377A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x040377A9 RID: 227241
		[Token(Token = "0x40377A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040377AA RID: 227242
		[Token(Token = "0x40377AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
