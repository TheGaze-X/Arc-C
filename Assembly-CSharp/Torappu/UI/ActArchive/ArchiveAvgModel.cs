using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B0D RID: 27405
	[Token(Token = "0x2006B0D")]
	public class ArchiveAvgModel : IHotfixable
	{
		// Token: 0x060272FC RID: 160508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272FC")]
		[Address(RVA = "0x2255C00", Offset = "0x2254800", VA = "0x182255C00")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060272FD RID: 160509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272FD")]
		[Address(RVA = "0x2256280", Offset = "0x2254E80", VA = "0x182256280")]
		private ActArchiveResData.AvgArchiveResItemData _getArchiveAvgResData(string avgId)
		{
			return null;
		}

		// Token: 0x060272FE RID: 160510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272FE")]
		[Address(RVA = "0x22559E0", Offset = "0x22545E0", VA = "0x1822559E0")]
		public string GetDefaultItemID()
		{
			return null;
		}

		// Token: 0x060272FF RID: 160511 RVA: 0x000CD998 File Offset: 0x000CBB98
		[Token(Token = "0x60272FF")]
		[Address(RVA = "0x2255B70", Offset = "0x2254770", VA = "0x182255B70")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x06027300 RID: 160512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027300")]
		[Address(RVA = "0x22561D0", Offset = "0x2254DD0", VA = "0x1822561D0")]
		public ArchiveAvgModel()
		{
		}

		// Token: 0x040376F4 RID: 227060
		[Token(Token = "0x40376F4")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, AvgItemModel> avgItems;

		// Token: 0x040376F5 RID: 227061
		[Token(Token = "0x40376F5")]
		[FieldOffset(Offset = "0x18")]
		public string selectedAvgId;

		// Token: 0x040376F6 RID: 227062
		[Token(Token = "0x40376F6")]
		[FieldOffset(Offset = "0x20")]
		public bool isInit;

		// Token: 0x040376F7 RID: 227063
		[Token(Token = "0x40376F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040376F8 RID: 227064
		[Token(Token = "0x40376F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__getArchiveAvgResData;

		// Token: 0x040376F9 RID: 227065
		[Token(Token = "0x40376F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemID;

		// Token: 0x040376FA RID: 227066
		[Token(Token = "0x40376FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x040376FB RID: 227067
		[Token(Token = "0x40376FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
