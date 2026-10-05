using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A1D RID: 27165
	[Token(Token = "0x2006A1D")]
	public class Main12ZoneRecordGroupViewModel : ZoneRecordGroupViewModel, IHotfixable
	{
		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x06026D62 RID: 159074 RVA: 0x000CC7E0 File Offset: 0x000CA9E0
		[Token(Token = "0x17005BA6")]
		public bool hasStageBanned
		{
			[Token(Token = "0x6026D62")]
			[Address(RVA = "0x21FAF30", Offset = "0x21F9B30", VA = "0x1821FAF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026D63 RID: 159075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D63")]
		[Address(RVA = "0x21FA990", Offset = "0x21F9590", VA = "0x1821FA990", Slot = "4")]
		public override void LoadData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026D64 RID: 159076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D64")]
		[Address(RVA = "0x21FAA10", Offset = "0x21F9610", VA = "0x1821FAA10")]
		public void RefreshData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026D65 RID: 159077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026D65")]
		[Address(RVA = "0x21FA920", Offset = "0x21F9520", VA = "0x1821FA920")]
		public string GetRewardBuffItemId()
		{
			return null;
		}

		// Token: 0x06026D66 RID: 159078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D66")]
		[Address(RVA = "0x21FAE90", Offset = "0x21F9A90", VA = "0x1821FAE90")]
		public Main12ZoneRecordGroupViewModel()
		{
		}

		// Token: 0x06026D67 RID: 159079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D67")]
		[Address(RVA = "0x21EF4D0", Offset = "0x21EE0D0", VA = "0x1821EF4D0")]
		private void <>xLuaBaseProxy_LoadData(ZoneRecordGroupData P0)
		{
		}

		// Token: 0x04036E46 RID: 224838
		[Token(Token = "0x4036E46")]
		[FieldOffset(Offset = "0x48")]
		public ZoneRewardBuffViewModel rewardBuffModel;

		// Token: 0x04036E47 RID: 224839
		[Token(Token = "0x4036E47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasStageBanned;

		// Token: 0x04036E48 RID: 224840
		[Token(Token = "0x4036E48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036E49 RID: 224841
		[Token(Token = "0x4036E49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04036E4A RID: 224842
		[Token(Token = "0x4036E4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRewardBuffItemId;

		// Token: 0x04036E4B RID: 224843
		[Token(Token = "0x4036E4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A1E RID: 27166
		[Token(Token = "0x2006A1E")]
		private class Main12ZoneRecordPlugin : ZoneRecordViewModel.IPlugin
		{
			// Token: 0x06026D68 RID: 159080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D68")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public Main12ZoneRecordPlugin(ZoneRewardBuffViewModel buffModel)
			{
			}

			// Token: 0x06026D69 RID: 159081 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026D69")]
			[Address(RVA = "0x21FB010", Offset = "0x21F9C10", VA = "0x1821FB010", Slot = "4")]
			public List<string> GetOutdateItemIdList()
			{
				return null;
			}

			// Token: 0x04036E4C RID: 224844
			[Token(Token = "0x4036E4C")]
			[FieldOffset(Offset = "0x10")]
			private ZoneRewardBuffViewModel m_buffModel;
		}
	}
}
