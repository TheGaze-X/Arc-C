using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C5A RID: 27738
	[Token(Token = "0x2006C5A")]
	public class TrapCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027979 RID: 162169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027979")]
		[Address(RVA = "0x22D23F0", Offset = "0x22D0FF0", VA = "0x1822D23F0")]
		public TrapCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602797A RID: 162170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602797A")]
		[Address(RVA = "0x22D1F10", Offset = "0x22D0B10", VA = "0x1822D1F10", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602797B RID: 162171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602797B")]
		[Address(RVA = "0x22D2170", Offset = "0x22D0D70", VA = "0x1822D2170")]
		public void SetSelectedTrapItem(string trapId)
		{
		}

		// Token: 0x0602797C RID: 162172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602797C")]
		[Address(RVA = "0x22D1D00", Offset = "0x22D0900", VA = "0x1822D1D00", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602797D RID: 162173 RVA: 0x000CECE8 File Offset: 0x000CCEE8
		[Token(Token = "0x602797D")]
		[Address(RVA = "0x22D1E90", Offset = "0x22D0A90", VA = "0x1822D1E90", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602797E RID: 162174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602797E")]
		[Address(RVA = "0x22D20C0", Offset = "0x22D0CC0", VA = "0x1822D20C0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602797F RID: 162175 RVA: 0x000CED00 File Offset: 0x000CCF00
		[Token(Token = "0x602797F")]
		[Address(RVA = "0x22D1DA0", Offset = "0x22D09A0", VA = "0x1822D1DA0", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027980 RID: 162176 RVA: 0x000CED18 File Offset: 0x000CCF18
		[Token(Token = "0x6027980")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04038267 RID: 229991
		[Token(Token = "0x4038267")]
		[FieldOffset(Offset = "0x18")]
		public TrapProperty trap;

		// Token: 0x04038268 RID: 229992
		[Token(Token = "0x4038268")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedArchiveId;

		// Token: 0x04038269 RID: 229993
		[Token(Token = "0x4038269")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403826A RID: 229994
		[Token(Token = "0x403826A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403826B RID: 229995
		[Token(Token = "0x403826B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedTrapItem;

		// Token: 0x0403826C RID: 229996
		[Token(Token = "0x403826C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x0403826D RID: 229997
		[Token(Token = "0x403826D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403826E RID: 229998
		[Token(Token = "0x403826E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x0403826F RID: 229999
		[Token(Token = "0x403826F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
