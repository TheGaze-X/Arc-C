using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE4 RID: 27620
	[Token(Token = "0x2006BE4")]
	public class DynamicPicCompInfo : ActArchiveCompInfo
	{
		// Token: 0x0602770D RID: 161549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602770D")]
		[Address(RVA = "0x22A1D00", Offset = "0x22A0900", VA = "0x1822A1D00")]
		public DynamicPicCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602770E RID: 161550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602770E")]
		[Address(RVA = "0x22A1B50", Offset = "0x22A0750", VA = "0x1822A1B50")]
		public void SetSelectedPicItem(string picID, bool isInit)
		{
		}

		// Token: 0x0602770F RID: 161551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602770F")]
		[Address(RVA = "0x22A1A70", Offset = "0x22A0670", VA = "0x1822A1A70")]
		public void SetPicItemFullscreen(bool on)
		{
		}

		// Token: 0x06027710 RID: 161552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027710")]
		[Address(RVA = "0x22A1790", Offset = "0x22A0390", VA = "0x1822A1790")]
		public void SetHomeKV()
		{
		}

		// Token: 0x06027711 RID: 161553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027711")]
		[Address(RVA = "0x22A1570", Offset = "0x22A0170", VA = "0x1822A1570", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027712 RID: 161554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027712")]
		[Address(RVA = "0x22A1170", Offset = "0x229FD70", VA = "0x1822A1170", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027713 RID: 161555 RVA: 0x000CE658 File Offset: 0x000CC858
		[Token(Token = "0x6027713")]
		[Address(RVA = "0x22A14F0", Offset = "0x22A00F0", VA = "0x1822A14F0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027714 RID: 161556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027714")]
		[Address(RVA = "0x22A16E0", Offset = "0x22A02E0", VA = "0x1822A16E0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027715 RID: 161557 RVA: 0x000CE670 File Offset: 0x000CC870
		[Token(Token = "0x6027715")]
		[Address(RVA = "0x22A1390", Offset = "0x229FF90", VA = "0x1822A1390", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027716 RID: 161558 RVA: 0x000CE688 File Offset: 0x000CC888
		[Token(Token = "0x6027716")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037E16 RID: 228886
		[Token(Token = "0x4037E16")]
		[FieldOffset(Offset = "0x18")]
		public PicProperty pic;

		// Token: 0x04037E17 RID: 228887
		[Token(Token = "0x4037E17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037E18 RID: 228888
		[Token(Token = "0x4037E18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedPicItem;

		// Token: 0x04037E19 RID: 228889
		[Token(Token = "0x4037E19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPicItemFullscreen;

		// Token: 0x04037E1A RID: 228890
		[Token(Token = "0x4037E1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetHomeKV;

		// Token: 0x04037E1B RID: 228891
		[Token(Token = "0x4037E1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037E1C RID: 228892
		[Token(Token = "0x4037E1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037E1D RID: 228893
		[Token(Token = "0x4037E1D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037E1E RID: 228894
		[Token(Token = "0x4037E1E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037E1F RID: 228895
		[Token(Token = "0x4037E1F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
