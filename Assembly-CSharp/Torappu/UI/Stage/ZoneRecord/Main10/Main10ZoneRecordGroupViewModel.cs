using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A40 RID: 27200
	[Token(Token = "0x2006A40")]
	public class Main10ZoneRecordGroupViewModel : ZoneRecordGroupViewModel
	{
		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x06026E1D RID: 159261 RVA: 0x000CC930 File Offset: 0x000CAB30
		// (set) Token: 0x06026E1E RID: 159262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BB3")]
		public StageDiffGroup selectedDiffGroup
		{
			[Token(Token = "0x6026E1D")]
			[Address(RVA = "0x21EF540", Offset = "0x21EE140", VA = "0x1821EF540")]
			[CompilerGenerated]
			get
			{
				return StageDiffGroup.NONE;
			}
			[Token(Token = "0x6026E1E")]
			[Address(RVA = "0x21EF5A0", Offset = "0x21EE1A0", VA = "0x1821EF5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026E1F RID: 159263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E1F")]
		[Address(RVA = "0x21EEFC0", Offset = "0x21EDBC0", VA = "0x1821EEFC0", Slot = "4")]
		public override void LoadData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026E20 RID: 159264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E20")]
		[Address(RVA = "0x21EF040", Offset = "0x21EDC40", VA = "0x1821EF040")]
		public void RefreshData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026E21 RID: 159265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E21")]
		[Address(RVA = "0x21EED00", Offset = "0x21ED900", VA = "0x1821EED00")]
		public RecordRewardInfo GetCurrentRewardInfo()
		{
			return null;
		}

		// Token: 0x06026E22 RID: 159266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E22")]
		[Address(RVA = "0x21EEED0", Offset = "0x21EDAD0", VA = "0x1821EEED0")]
		public ZoneRecordRewardViewModel GetRewardViewModel(StageDiffGroup diff)
		{
			return null;
		}

		// Token: 0x06026E23 RID: 159267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E23")]
		[Address(RVA = "0x21EF4E0", Offset = "0x21EE0E0", VA = "0x1821EF4E0")]
		public Main10ZoneRecordGroupViewModel()
		{
		}

		// Token: 0x06026E24 RID: 159268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E24")]
		[Address(RVA = "0x21EF4D0", Offset = "0x21EE0D0", VA = "0x1821EF4D0")]
		private void <>xLuaBaseProxy_LoadData(ZoneRecordGroupData P0)
		{
		}

		// Token: 0x04036FB9 RID: 225209
		[Token(Token = "0x4036FB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedDiffGroup;

		// Token: 0x04036FBA RID: 225210
		[Token(Token = "0x4036FBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedDiffGroup;

		// Token: 0x04036FBB RID: 225211
		[Token(Token = "0x4036FBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036FBC RID: 225212
		[Token(Token = "0x4036FBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04036FBD RID: 225213
		[Token(Token = "0x4036FBD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurrentRewardInfo;

		// Token: 0x04036FBE RID: 225214
		[Token(Token = "0x4036FBE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRewardViewModel;

		// Token: 0x04036FBF RID: 225215
		[Token(Token = "0x4036FBF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
