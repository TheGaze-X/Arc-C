using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060C9 RID: 24777
	[Token(Token = "0x20060C9")]
	public class CampaignBriefTrainingViewModel : IHotfixable
	{
		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x06023D10 RID: 146704 RVA: 0x000C2238 File Offset: 0x000C0438
		[Token(Token = "0x1700549A")]
		public bool isValid
		{
			[Token(Token = "0x6023D10")]
			[Address(RVA = "0x1E6F120", Offset = "0x1E6DD20", VA = "0x181E6F120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023D11 RID: 146705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D11")]
		[Address(RVA = "0x1E6E580", Offset = "0x1E6D180", VA = "0x181E6E580")]
		public void LoadData(string groupId, bool isNext, bool isAllOpen, [Optional] string returnGroupId)
		{
		}

		// Token: 0x06023D12 RID: 146706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D12")]
		[Address(RVA = "0x1E6E500", Offset = "0x1E6D100", VA = "0x181E6E500")]
		public void Clear()
		{
		}

		// Token: 0x06023D13 RID: 146707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D13")]
		[Address(RVA = "0x1E6EC10", Offset = "0x1E6D810", VA = "0x181E6EC10")]
		private void _AddStageInfo(string stageId)
		{
		}

		// Token: 0x06023D14 RID: 146708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D14")]
		[Address(RVA = "0x1E6EF60", Offset = "0x1E6DB60", VA = "0x181E6EF60")]
		private CampaignBriefTrainingViewModel.StageInfoViewModel _GetStageInfoViewModel(string zoneId)
		{
			return null;
		}

		// Token: 0x06023D15 RID: 146709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D15")]
		[Address(RVA = "0x1E6F070", Offset = "0x1E6DC70", VA = "0x181E6F070")]
		public CampaignBriefTrainingViewModel()
		{
		}

		// Token: 0x04031AB8 RID: 203448
		[Token(Token = "0x4031AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04031AB9 RID: 203449
		[Token(Token = "0x4031AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isNext;

		// Token: 0x04031ABA RID: 203450
		[Token(Token = "0x4031ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isAllOpen;

		// Token: 0x04031ABB RID: 203451
		[Token(Token = "0x4031ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isReturnAllOpen;

		// Token: 0x04031ABC RID: 203452
		[Token(Token = "0x4031ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string remainTimeStr;

		// Token: 0x04031ABD RID: 203453
		[Token(Token = "0x4031ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CampaignBriefTrainingViewModel.StageInfoViewModel> stageInfoModels;

		// Token: 0x04031ABE RID: 203454
		[Token(Token = "0x4031ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x04031ABF RID: 203455
		[Token(Token = "0x4031ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031AC0 RID: 203456
		[Token(Token = "0x4031AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04031AC1 RID: 203457
		[Token(Token = "0x4031AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddStageInfo;

		// Token: 0x04031AC2 RID: 203458
		[Token(Token = "0x4031AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetStageInfoViewModel;

		// Token: 0x04031AC3 RID: 203459
		[Token(Token = "0x4031AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060CA RID: 24778
		[Token(Token = "0x20060CA")]
		public class StageInfoViewModel : IHotfixable
		{
			// Token: 0x06023D16 RID: 146710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023D16")]
			[Address(RVA = "0x1E81490", Offset = "0x1E80090", VA = "0x181E81490")]
			public StageInfoViewModel(string zoneId)
			{
			}

			// Token: 0x06023D17 RID: 146711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023D17")]
			[Address(RVA = "0x1E81280", Offset = "0x1E7FE80", VA = "0x181E81280")]
			public string GetStageNamesStr()
			{
				return null;
			}

			// Token: 0x04031AC4 RID: 203460
			[Token(Token = "0x4031AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04031AC5 RID: 203461
			[Token(Token = "0x4031AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string zoneName;

			// Token: 0x04031AC6 RID: 203462
			[Token(Token = "0x4031AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> stageNames;

			// Token: 0x04031AC7 RID: 203463
			[Token(Token = "0x4031AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private StringBuilder m_stageNameSb;

			// Token: 0x04031AC8 RID: 203464
			[Token(Token = "0x4031AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031AC9 RID: 203465
			[Token(Token = "0x4031AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetStageNamesStr;
		}
	}
}
