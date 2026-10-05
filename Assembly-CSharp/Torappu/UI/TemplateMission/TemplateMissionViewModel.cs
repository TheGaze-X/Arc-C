using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DB5 RID: 15797
	[Token(Token = "0x2003DB5")]
	public class TemplateMissionViewModel : IHotfixable
	{
		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x060188F8 RID: 100600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A9F")]
		public TemplateMissionStyleData missionViewStyleData
		{
			[Token(Token = "0x60188F8")]
			[Address(RVA = "0x111A130", Offset = "0x1118D30", VA = "0x18111A130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x060188F9 RID: 100601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AA0")]
		public TemplateMissionCoinViewModel missionCoinViewModel
		{
			[Token(Token = "0x60188F9")]
			[Address(RVA = "0x111A070", Offset = "0x1118C70", VA = "0x18111A070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x060188FA RID: 100602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AA1")]
		public List<ITemplateMissionListItemViewModel> missionItemList
		{
			[Token(Token = "0x60188FA")]
			[Address(RVA = "0x111A0D0", Offset = "0x1118CD0", VA = "0x18111A0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x060188FB RID: 100603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AA2")]
		public ITemplateMissionViewModelPlugin plugin
		{
			[Token(Token = "0x60188FB")]
			[Address(RVA = "0x111A190", Offset = "0x1118D90", VA = "0x18111A190")]
			get
			{
				return null;
			}
		}

		// Token: 0x060188FC RID: 100604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188FC")]
		[Address(RVA = "0x11184B0", Offset = "0x11170B0", VA = "0x1811184B0")]
		public void InitViewModel(TemplateMissionInputParam param)
		{
		}

		// Token: 0x060188FD RID: 100605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188FD")]
		[Address(RVA = "0x11186E0", Offset = "0x11172E0", VA = "0x1811186E0")]
		public void RefreshMissionState()
		{
		}

		// Token: 0x060188FE RID: 100606 RVA: 0x0009AC38 File Offset: 0x00098E38
		[Token(Token = "0x60188FE")]
		[Address(RVA = "0x1117900", Offset = "0x1116500", VA = "0x181117900")]
		public bool CheckHaveMissionToGet(long currTs)
		{
			return default(bool);
		}

		// Token: 0x060188FF RID: 100607 RVA: 0x0009AC50 File Offset: 0x00098E50
		[Token(Token = "0x60188FF")]
		[Address(RVA = "0x1118350", Offset = "0x1116F50", VA = "0x181118350")]
		public int GetCompletedMissionCount()
		{
			return 0;
		}

		// Token: 0x06018900 RID: 100608 RVA: 0x0009AC68 File Offset: 0x00098E68
		[Token(Token = "0x6018900")]
		[Address(RVA = "0x1117AB0", Offset = "0x11166B0", VA = "0x181117AB0")]
		public bool CheckMissionListPlayerDataChanged(PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x06018901 RID: 100609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018901")]
		[Address(RVA = "0x1118160", Offset = "0x1116D60", VA = "0x181118160")]
		public List<string> GetCanClaimMissionList()
		{
			return null;
		}

		// Token: 0x06018902 RID: 100610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018902")]
		[Address(RVA = "0x1119400", Offset = "0x1118000", VA = "0x181119400")]
		private void _InitMissionList(TemplateMissionInputParam param)
		{
		}

		// Token: 0x06018903 RID: 100611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018903")]
		[Address(RVA = "0x1118DB0", Offset = "0x11179B0", VA = "0x181118DB0")]
		private void _InitListNormalItemViewModels(TemplateMissionInputParam param)
		{
		}

		// Token: 0x06018904 RID: 100612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018904")]
		[Address(RVA = "0x1118A40", Offset = "0x1117640", VA = "0x181118A40")]
		private void _InitClaimAllViewModel()
		{
		}

		// Token: 0x06018905 RID: 100613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018905")]
		[Address(RVA = "0x1119D20", Offset = "0x1118920", VA = "0x181119D20")]
		private void _RefreshMissionList()
		{
		}

		// Token: 0x06018906 RID: 100614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018906")]
		[Address(RVA = "0x1119A40", Offset = "0x1118640", VA = "0x181119A40")]
		private void _RefreshListNormalItemViewModels()
		{
		}

		// Token: 0x06018907 RID: 100615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018907")]
		[Address(RVA = "0x1119820", Offset = "0x1118420", VA = "0x181119820")]
		private void _RefreshClaimAllItemViewModel()
		{
		}

		// Token: 0x06018908 RID: 100616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018908")]
		[Address(RVA = "0x1119580", Offset = "0x1118180", VA = "0x181119580")]
		private void _RefreshClaimAllItemInMissionList()
		{
		}

		// Token: 0x06018909 RID: 100617 RVA: 0x0009AC80 File Offset: 0x00098E80
		[Token(Token = "0x6018909")]
		[Address(RVA = "0x11194A0", Offset = "0x11180A0", VA = "0x1811194A0")]
		private bool _IsClaimAllItemShowInList()
		{
			return default(bool);
		}

		// Token: 0x0601890A RID: 100618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601890A")]
		[Address(RVA = "0x1119E70", Offset = "0x1118A70", VA = "0x181119E70")]
		private TemplateMissionListClaimAllItemViewModel _TryGetClaimAllItemInMissionList()
		{
			return null;
		}

		// Token: 0x0601890B RID: 100619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601890B")]
		[Address(RVA = "0x1119D90", Offset = "0x1118990", VA = "0x181119D90")]
		private void _SortMissionList()
		{
		}

		// Token: 0x0601890C RID: 100620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601890C")]
		[Address(RVA = "0x1119FB0", Offset = "0x1118BB0", VA = "0x181119FB0")]
		public TemplateMissionViewModel()
		{
		}

		// Token: 0x0401E1D0 RID: 123344
		[Token(Token = "0x401E1D0")]
		[FieldOffset(Offset = "0x10")]
		private List<ITemplateMissionListItemViewModel> m_missionList;

		// Token: 0x0401E1D1 RID: 123345
		[Token(Token = "0x401E1D1")]
		[FieldOffset(Offset = "0x18")]
		private TemplateMissionListClaimAllItemViewModel m_claimAllViewModel;

		// Token: 0x0401E1D2 RID: 123346
		[Token(Token = "0x401E1D2")]
		[FieldOffset(Offset = "0x20")]
		private TemplateMissionCoinViewModel m_missionCoinViewModel;

		// Token: 0x0401E1D3 RID: 123347
		[Token(Token = "0x401E1D3")]
		[FieldOffset(Offset = "0x28")]
		private TemplateMissionStyleData m_missionViewStyleData;

		// Token: 0x0401E1D4 RID: 123348
		[Token(Token = "0x401E1D4")]
		[FieldOffset(Offset = "0x30")]
		private ITemplateMissionViewModelPlugin m_plugin;

		// Token: 0x0401E1D5 RID: 123349
		[Token(Token = "0x401E1D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_missionViewStyleData;

		// Token: 0x0401E1D6 RID: 123350
		[Token(Token = "0x401E1D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_missionCoinViewModel;

		// Token: 0x0401E1D7 RID: 123351
		[Token(Token = "0x401E1D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_missionItemList;

		// Token: 0x0401E1D8 RID: 123352
		[Token(Token = "0x401E1D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0401E1D9 RID: 123353
		[Token(Token = "0x401E1D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x0401E1DA RID: 123354
		[Token(Token = "0x401E1DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshMissionState;

		// Token: 0x0401E1DB RID: 123355
		[Token(Token = "0x401E1DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckHaveMissionToGet;

		// Token: 0x0401E1DC RID: 123356
		[Token(Token = "0x401E1DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCompletedMissionCount;

		// Token: 0x0401E1DD RID: 123357
		[Token(Token = "0x401E1DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckMissionListPlayerDataChanged;

		// Token: 0x0401E1DE RID: 123358
		[Token(Token = "0x401E1DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCanClaimMissionList;

		// Token: 0x0401E1DF RID: 123359
		[Token(Token = "0x401E1DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitMissionList;

		// Token: 0x0401E1E0 RID: 123360
		[Token(Token = "0x401E1E0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitListNormalItemViewModels;

		// Token: 0x0401E1E1 RID: 123361
		[Token(Token = "0x401E1E1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitClaimAllViewModel;

		// Token: 0x0401E1E2 RID: 123362
		[Token(Token = "0x401E1E2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RefreshMissionList;

		// Token: 0x0401E1E3 RID: 123363
		[Token(Token = "0x401E1E3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshListNormalItemViewModels;

		// Token: 0x0401E1E4 RID: 123364
		[Token(Token = "0x401E1E4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshClaimAllItemViewModel;

		// Token: 0x0401E1E5 RID: 123365
		[Token(Token = "0x401E1E5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshClaimAllItemInMissionList;

		// Token: 0x0401E1E6 RID: 123366
		[Token(Token = "0x401E1E6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IsClaimAllItemShowInList;

		// Token: 0x0401E1E7 RID: 123367
		[Token(Token = "0x401E1E7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryGetClaimAllItemInMissionList;

		// Token: 0x0401E1E8 RID: 123368
		[Token(Token = "0x401E1E8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SortMissionList;

		// Token: 0x0401E1E9 RID: 123369
		[Token(Token = "0x401E1E9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DB6 RID: 15798
		[Token(Token = "0x2003DB6")]
		private struct MissionStateStruct : IHotfixable
		{
			// Token: 0x0601890E RID: 100622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601890E")]
			[Address(RVA = "0x1105070", Offset = "0x1103C70", VA = "0x181105070")]
			public MissionStateStruct(MissionHoldingState state, int target, int value)
			{
			}

			// Token: 0x0601890F RID: 100623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601890F")]
			[Address(RVA = "0x1105190", Offset = "0x1103D90", VA = "0x181105190")]
			public MissionStateStruct(MissionPlayerState missionPlayerState)
			{
			}

			// Token: 0x06018910 RID: 100624 RVA: 0x0009ACB0 File Offset: 0x00098EB0
			[Token(Token = "0x6018910")]
			[Address(RVA = "0x1104F50", Offset = "0x1103B50", VA = "0x181104F50")]
			public bool IsEqual(TemplateMissionViewModel.MissionStateStruct targetStruct)
			{
				return default(bool);
			}

			// Token: 0x0401E1EA RID: 123370
			[Token(Token = "0x401E1EA")]
			[FieldOffset(Offset = "0x0")]
			public MissionHoldingState state;

			// Token: 0x0401E1EB RID: 123371
			[Token(Token = "0x401E1EB")]
			[FieldOffset(Offset = "0x4")]
			public int target;

			// Token: 0x0401E1EC RID: 123372
			[Token(Token = "0x401E1EC")]
			[FieldOffset(Offset = "0x8")]
			public int value;

			// Token: 0x0401E1ED RID: 123373
			[Token(Token = "0x401E1ED")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E1EE RID: 123374
			[Token(Token = "0x401E1EE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix1_ctor;

			// Token: 0x0401E1EF RID: 123375
			[Token(Token = "0x401E1EF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsEqual;
		}
	}
}
