using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B32 RID: 27442
	[Token(Token = "0x2006B32")]
	public class ChallengeBookCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060273A5 RID: 160677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A5")]
		[Address(RVA = "0x22762E0", Offset = "0x2274EE0", VA = "0x1822762E0")]
		public ChallengeBookCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060273A6 RID: 160678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A6")]
		[Address(RVA = "0x22761F0", Offset = "0x2274DF0", VA = "0x1822761F0")]
		public void SetSelectedStoryId(string storyId)
		{
		}

		// Token: 0x060273A7 RID: 160679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A7")]
		[Address(RVA = "0x2275D70", Offset = "0x2274970", VA = "0x182275D70", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060273A8 RID: 160680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A8")]
		[Address(RVA = "0x22759C0", Offset = "0x22745C0", VA = "0x1822759C0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060273A9 RID: 160681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A9")]
		[Address(RVA = "0x2276140", Offset = "0x2274D40", VA = "0x182276140", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x060273AA RID: 160682 RVA: 0x000CDBC0 File Offset: 0x000CBDC0
		[Token(Token = "0x60273AA")]
		[Address(RVA = "0x2275CF0", Offset = "0x22748F0", VA = "0x182275CF0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060273AB RID: 160683 RVA: 0x000CDBD8 File Offset: 0x000CBDD8
		[Token(Token = "0x60273AB")]
		[Address(RVA = "0x2275B10", Offset = "0x2274710", VA = "0x182275B10", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060273AC RID: 160684 RVA: 0x000CDBF0 File Offset: 0x000CBDF0
		[Token(Token = "0x60273AC")]
		[Address(RVA = "0x2275F30", Offset = "0x2274B30", VA = "0x182275F30", Slot = "11")]
		public override bool NeedClosePageOnBack()
		{
			return default(bool);
		}

		// Token: 0x060273AD RID: 160685 RVA: 0x000CDC08 File Offset: 0x000CBE08
		[Token(Token = "0x60273AD")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060273AE RID: 160686 RVA: 0x000CDC20 File Offset: 0x000CBE20
		[Token(Token = "0x60273AE")]
		[Address(RVA = "0x22762D0", Offset = "0x2274ED0", VA = "0x1822762D0")]
		private bool <>xLuaBaseProxy_NeedClosePageOnBack()
		{
			return default(bool);
		}

		// Token: 0x04037810 RID: 227344
		[Token(Token = "0x4037810")]
		[FieldOffset(Offset = "0x18")]
		public ChallengeBookProperty challengeBook;

		// Token: 0x04037811 RID: 227345
		[Token(Token = "0x4037811")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037812 RID: 227346
		[Token(Token = "0x4037812")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedStoryId;

		// Token: 0x04037813 RID: 227347
		[Token(Token = "0x4037813")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037814 RID: 227348
		[Token(Token = "0x4037814")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037815 RID: 227349
		[Token(Token = "0x4037815")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037816 RID: 227350
		[Token(Token = "0x4037816")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037817 RID: 227351
		[Token(Token = "0x4037817")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x04037818 RID: 227352
		[Token(Token = "0x4037818")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NeedClosePageOnBack;
	}
}
