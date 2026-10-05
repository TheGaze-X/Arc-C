using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069F2 RID: 27122
	[Token(Token = "0x20069F2")]
	public class ZoneRecordStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06026C89 RID: 158857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C89")]
		[Address(RVA = "0x21E4FE0", Offset = "0x21E3BE0", VA = "0x1821E4FE0")]
		public void LoadData(string zoneId)
		{
		}

		// Token: 0x06026C8A RID: 158858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C8A")]
		[Address(RVA = "0x21E5750", Offset = "0x21E4350", VA = "0x1821E5750")]
		public void RefreshData()
		{
		}

		// Token: 0x06026C8B RID: 158859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C8B")]
		[Address(RVA = "0x21E52F0", Offset = "0x21E3EF0", VA = "0x1821E52F0")]
		public void OnContentClick(string recordId)
		{
		}

		// Token: 0x06026C8C RID: 158860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C8C")]
		[Address(RVA = "0x21E4E00", Offset = "0x21E3A00", VA = "0x1821E4E00")]
		public void EnsureLatestPageIdx()
		{
		}

		// Token: 0x06026C8D RID: 158861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C8D")]
		[Address(RVA = "0x21E5580", Offset = "0x21E4180", VA = "0x1821E5580")]
		public void OnNoteCoverClick()
		{
		}

		// Token: 0x06026C8E RID: 158862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C8E")]
		[Address(RVA = "0x21E5470", Offset = "0x21E4070", VA = "0x1821E5470")]
		public void OnNextNote()
		{
		}

		// Token: 0x06026C8F RID: 158863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C8F")]
		[Address(RVA = "0x21E5600", Offset = "0x21E4200", VA = "0x1821E5600")]
		public void OnPrevNote()
		{
		}

		// Token: 0x06026C90 RID: 158864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C90")]
		[Address(RVA = "0x21E5800", Offset = "0x21E4400", VA = "0x1821E5800")]
		private void _JumpToRecordPageByIdx(int idx)
		{
		}

		// Token: 0x06026C91 RID: 158865 RVA: 0x000CC558 File Offset: 0x000CA758
		[Token(Token = "0x6026C91")]
		[Address(RVA = "0x21E4EB0", Offset = "0x21E3AB0", VA = "0x1821E4EB0")]
		public int GetLatestRocordIdx()
		{
			return 0;
		}

		// Token: 0x06026C92 RID: 158866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C92")]
		[Address(RVA = "0x21E59A0", Offset = "0x21E45A0", VA = "0x1821E59A0")]
		public ZoneRecordStateBean()
		{
		}

		// Token: 0x04036CBD RID: 224445
		[Token(Token = "0x4036CBD")]
		[FieldOffset(Offset = "0x10")]
		public ZoneRecordViewProperty property;

		// Token: 0x04036CBE RID: 224446
		[Token(Token = "0x4036CBE")]
		[FieldOffset(Offset = "0x18")]
		private ZoneRecordGroupData m_cachedGroupData;

		// Token: 0x04036CBF RID: 224447
		[Token(Token = "0x4036CBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036CC0 RID: 224448
		[Token(Token = "0x4036CC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04036CC1 RID: 224449
		[Token(Token = "0x4036CC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnContentClick;

		// Token: 0x04036CC2 RID: 224450
		[Token(Token = "0x4036CC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EnsureLatestPageIdx;

		// Token: 0x04036CC3 RID: 224451
		[Token(Token = "0x4036CC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnNoteCoverClick;

		// Token: 0x04036CC4 RID: 224452
		[Token(Token = "0x4036CC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnNextNote;

		// Token: 0x04036CC5 RID: 224453
		[Token(Token = "0x4036CC5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPrevNote;

		// Token: 0x04036CC6 RID: 224454
		[Token(Token = "0x4036CC6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__JumpToRecordPageByIdx;

		// Token: 0x04036CC7 RID: 224455
		[Token(Token = "0x4036CC7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLatestRocordIdx;

		// Token: 0x04036CC8 RID: 224456
		[Token(Token = "0x4036CC8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
