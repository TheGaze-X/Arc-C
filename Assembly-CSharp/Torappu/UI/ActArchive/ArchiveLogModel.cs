using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BA6 RID: 27558
	[Token(Token = "0x2006BA6")]
	public class ArchiveLogModel : IHotfixable
	{
		// Token: 0x060275AA RID: 161194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275AA")]
		[Address(RVA = "0x22862F0", Offset = "0x2284EF0", VA = "0x1822862F0")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060275AB RID: 161195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275AB")]
		[Address(RVA = "0x2286800", Offset = "0x2285400", VA = "0x182286800")]
		private ActArchiveResData.LogArchiveResItemData _GetArchiveLogResData(string logId)
		{
			return null;
		}

		// Token: 0x060275AC RID: 161196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275AC")]
		[Address(RVA = "0x22860D0", Offset = "0x2284CD0", VA = "0x1822860D0")]
		public string GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x060275AD RID: 161197 RVA: 0x000CE2E0 File Offset: 0x000CC4E0
		[Token(Token = "0x60275AD")]
		[Address(RVA = "0x2286260", Offset = "0x2284E60", VA = "0x182286260")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x060275AE RID: 161198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275AE")]
		[Address(RVA = "0x2286910", Offset = "0x2285510", VA = "0x182286910")]
		public ArchiveLogModel()
		{
		}

		// Token: 0x04037C1D RID: 228381
		[Token(Token = "0x4037C1D")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, LogItemModel> logItems;

		// Token: 0x04037C1E RID: 228382
		[Token(Token = "0x4037C1E")]
		[FieldOffset(Offset = "0x18")]
		public string selectedLogId;

		// Token: 0x04037C1F RID: 228383
		[Token(Token = "0x4037C1F")]
		[FieldOffset(Offset = "0x20")]
		public bool isInit;

		// Token: 0x04037C20 RID: 228384
		[Token(Token = "0x4037C20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037C21 RID: 228385
		[Token(Token = "0x4037C21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetArchiveLogResData;

		// Token: 0x04037C22 RID: 228386
		[Token(Token = "0x4037C22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x04037C23 RID: 228387
		[Token(Token = "0x4037C23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x04037C24 RID: 228388
		[Token(Token = "0x4037C24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
