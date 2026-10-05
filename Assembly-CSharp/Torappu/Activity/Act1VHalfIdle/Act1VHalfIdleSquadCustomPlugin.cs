using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077FD RID: 30717
	[Token(Token = "0x20077FD")]
	public class Act1VHalfIdleSquadCustomPlugin : CommonBattlePlayerDataSquadPlugin<Act1VHalfIdleCharViewModel>
	{
		// Token: 0x170064D0 RID: 25808
		// (get) Token: 0x0602B170 RID: 176496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064D0")]
		public override Dictionary<Type, Action<IStateBean>> toDataListenerActions
		{
			[Token(Token = "0x602B170")]
			[Address(RVA = "0x26E6D50", Offset = "0x26E5950", VA = "0x1826E6D50", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x170064D1 RID: 25809
		// (get) Token: 0x0602B171 RID: 176497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064D1")]
		public override Dictionary<Type, Action<IStateBean>> fromDataListenerActions
		{
			[Token(Token = "0x602B171")]
			[Address(RVA = "0x26E6BE0", Offset = "0x26E57E0", VA = "0x1826E6BE0", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B172 RID: 176498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B172")]
		[Address(RVA = "0x26E4A50", Offset = "0x26E3650", VA = "0x1826E4A50", Slot = "40")]
		public override ICustomSquadGroupViewModel GetCustomViewModel()
		{
			return null;
		}

		// Token: 0x0602B173 RID: 176499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B173")]
		[Address(RVA = "0x26E5120", Offset = "0x26E3D20", VA = "0x1826E5120", Slot = "67")]
		public override List<CommonSquadSingleSquadViewModel> LoadSquadCache()
		{
			return null;
		}

		// Token: 0x0602B174 RID: 176500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B174")]
		[Address(RVA = "0x26E69D0", Offset = "0x26E55D0", VA = "0x1826E69D0")]
		private List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache> _TryGetPrefStagePassSquad(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x0602B175 RID: 176501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B175")]
		[Address(RVA = "0x26E6300", Offset = "0x26E4F00", VA = "0x1826E6300")]
		private void _SetTutorialPredefinedSquad(string actId, ref ICommonSquadChar[] squad)
		{
		}

		// Token: 0x0602B176 RID: 176502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B176")]
		[Address(RVA = "0x26E5F10", Offset = "0x26E4B10", VA = "0x1826E5F10")]
		private void _SetDefaultSquad(string actId, ref ICommonSquadChar[] squad)
		{
		}

		// Token: 0x0602B177 RID: 176503 RVA: 0x000DACB8 File Offset: 0x000D8EB8
		[Token(Token = "0x602B177")]
		[Address(RVA = "0x26E5C00", Offset = "0x26E4800", VA = "0x1826E5C00")]
		private int _HalfIdleCharComparer(ICharacterCardViewModel modelA, ICharacterCardViewModel modelB)
		{
			return 0;
		}

		// Token: 0x0602B178 RID: 176504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B178")]
		[Address(RVA = "0x26E5740", Offset = "0x26E4340", VA = "0x1826E5740", Slot = "68")]
		public override void SaveSquadCache()
		{
		}

		// Token: 0x0602B179 RID: 176505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B179")]
		[Address(RVA = "0x26E5A80", Offset = "0x26E4680", VA = "0x1826E5A80", Slot = "70")]
		protected override void UpdateMemberStatus(CommonSquadGroupViewModel squadGroupViewModel)
		{
		}

		// Token: 0x0602B17A RID: 176506 RVA: 0x000DACD0 File Offset: 0x000D8ED0
		[Token(Token = "0x602B17A")]
		[Address(RVA = "0x26E4D00", Offset = "0x26E3900", VA = "0x1826E4D00", Slot = "77")]
		public override bool GetIfCharSelectStateHasTopMenuInState(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return default(bool);
		}

		// Token: 0x0602B17B RID: 176507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B17B")]
		[Address(RVA = "0x26E44E0", Offset = "0x26E30E0", VA = "0x1826E44E0", Slot = "64")]
		public override TemplateCharSelectController.TemplateCustomInput GetCharSelectCustomInput(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return null;
		}

		// Token: 0x0602B17C RID: 176508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B17C")]
		[Address(RVA = "0x26E4240", Offset = "0x26E2E40", VA = "0x1826E4240", Slot = "66")]
		protected override TemplateCharSelectCardViewModel CreateCharSelectCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x0602B17D RID: 176509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B17D")]
		[Address(RVA = "0x26E4710", Offset = "0x26E3310", VA = "0x1826E4710", Slot = "58")]
		protected override Act1VHalfIdleCharViewModel GetCharViewModelFromCharSelect(TemplateCharSelectCardViewModel selectChar)
		{
			return null;
		}

		// Token: 0x0602B17E RID: 176510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B17E")]
		[Address(RVA = "0x26E4580", Offset = "0x26E3180", VA = "0x1826E4580", Slot = "62")]
		public override Action<TemplateCharSelectController.InputParam> GetCharSelectMultiSelectOnFull(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return null;
		}

		// Token: 0x0602B17F RID: 176511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B17F")]
		[Address(RVA = "0x26E5D90", Offset = "0x26E4990", VA = "0x1826E5D90")]
		private void _OnCharSelectFull(TemplateCharSelectController.InputParam inputParam)
		{
		}

		// Token: 0x0602B180 RID: 176512 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		[Token(Token = "0x602B180")]
		[Address(RVA = "0x26E4630", Offset = "0x26E3230", VA = "0x1826E4630", Slot = "63")]
		public override bool GetCharSelectNeedScroll(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return default(bool);
		}

		// Token: 0x0602B181 RID: 176513 RVA: 0x000DAD00 File Offset: 0x000D8F00
		[Token(Token = "0x602B181")]
		[Address(RVA = "0x26E4E30", Offset = "0x26E3A30", VA = "0x1826E4E30", Slot = "42")]
		public override bool HandleMsg(int key, ValueBundle msg, UICompDialogMgr dlgMgr)
		{
			return default(bool);
		}

		// Token: 0x0602B182 RID: 176514 RVA: 0x000DAD18 File Offset: 0x000D8F18
		[Token(Token = "0x602B182")]
		[Address(RVA = "0x26E4C80", Offset = "0x26E3880", VA = "0x1826E4C80", Slot = "53")]
		public override GameTagMeta GetGameTagMeta()
		{
			return default(GameTagMeta);
		}

		// Token: 0x0602B183 RID: 176515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B183")]
		[Address(RVA = "0x26E56E0", Offset = "0x26E42E0", VA = "0x1826E56E0", Slot = "48")]
		public override CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x0602B184 RID: 176516 RVA: 0x000DAD30 File Offset: 0x000D8F30
		[Token(Token = "0x602B184")]
		[Address(RVA = "0x26E4D70", Offset = "0x26E3970", VA = "0x1826E4D70", Slot = "49")]
		public override bool GetIsSkipBattleFinishWhenFailed()
		{
			return default(bool);
		}

		// Token: 0x0602B185 RID: 176517 RVA: 0x000DAD48 File Offset: 0x000D8F48
		[Token(Token = "0x602B185")]
		[Address(RVA = "0x26E4DD0", Offset = "0x26E39D0", VA = "0x1826E4DD0", Slot = "51")]
		public override bool GetIsUploadBattleLog()
		{
			return default(bool);
		}

		// Token: 0x0602B186 RID: 176518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B186")]
		[Address(RVA = "0x26E6B20", Offset = "0x26E5720", VA = "0x1826E6B20")]
		public Act1VHalfIdleSquadCustomPlugin()
		{
		}

		// Token: 0x0403E443 RID: 255043
		[Token(Token = "0x403E443")]
		public const string KEY_ACT_ID = "key_act_id";

		// Token: 0x0403E444 RID: 255044
		[Token(Token = "0x403E444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DataBundle m_cachedUpdateDataBundle;

		// Token: 0x0403E445 RID: 255045
		[Token(Token = "0x403E445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_toDataListenerActions;

		// Token: 0x0403E446 RID: 255046
		[Token(Token = "0x403E446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fromDataListenerActions;

		// Token: 0x0403E447 RID: 255047
		[Token(Token = "0x403E447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCustomViewModel;

		// Token: 0x0403E448 RID: 255048
		[Token(Token = "0x403E448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadSquadCache;

		// Token: 0x0403E449 RID: 255049
		[Token(Token = "0x403E449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGetPrefStagePassSquad;

		// Token: 0x0403E44A RID: 255050
		[Token(Token = "0x403E44A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetTutorialPredefinedSquad;

		// Token: 0x0403E44B RID: 255051
		[Token(Token = "0x403E44B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetDefaultSquad;

		// Token: 0x0403E44C RID: 255052
		[Token(Token = "0x403E44C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HalfIdleCharComparer;

		// Token: 0x0403E44D RID: 255053
		[Token(Token = "0x403E44D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveSquadCache;

		// Token: 0x0403E44E RID: 255054
		[Token(Token = "0x403E44E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateMemberStatus;

		// Token: 0x0403E44F RID: 255055
		[Token(Token = "0x403E44F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetIfCharSelectStateHasTopMenuInState;

		// Token: 0x0403E450 RID: 255056
		[Token(Token = "0x403E450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCharSelectCustomInput;

		// Token: 0x0403E451 RID: 255057
		[Token(Token = "0x403E451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateCharSelectCardViewModel;

		// Token: 0x0403E452 RID: 255058
		[Token(Token = "0x403E452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCharViewModelFromCharSelect;

		// Token: 0x0403E453 RID: 255059
		[Token(Token = "0x403E453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetCharSelectMultiSelectOnFull;

		// Token: 0x0403E454 RID: 255060
		[Token(Token = "0x403E454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCharSelectFull;

		// Token: 0x0403E455 RID: 255061
		[Token(Token = "0x403E455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetCharSelectNeedScroll;

		// Token: 0x0403E456 RID: 255062
		[Token(Token = "0x403E456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HandleMsg;

		// Token: 0x0403E457 RID: 255063
		[Token(Token = "0x403E457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetGameTagMeta;

		// Token: 0x0403E458 RID: 255064
		[Token(Token = "0x403E458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x0403E459 RID: 255065
		[Token(Token = "0x403E459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetIsSkipBattleFinishWhenFailed;

		// Token: 0x0403E45A RID: 255066
		[Token(Token = "0x403E45A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetIsUploadBattleLog;

		// Token: 0x0403E45B RID: 255067
		[Token(Token = "0x403E45B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077FE RID: 30718
		[Token(Token = "0x20077FE")]
		public class Act1VHalfIdleSelectCharParam : CommonSquadHomeState.SelectCharParam
		{
			// Token: 0x0602B187 RID: 176519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B187")]
			[Address(RVA = "0x26E3370", Offset = "0x26E1F70", VA = "0x1826E3370")]
			public Act1VHalfIdleSelectCharParam()
			{
			}

			// Token: 0x0403E45C RID: 255068
			[Token(Token = "0x403E45C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isNeedScrollToEnd;

			// Token: 0x0403E45D RID: 255069
			[Token(Token = "0x403E45D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077FF RID: 30719
		[Token(Token = "0x20077FF")]
		public class Act1VHalfIdleSquadCustomData : ICustomSquadGroupViewModel, IHotfixable
		{
			// Token: 0x0602B188 RID: 176520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B188")]
			[Address(RVA = "0x26E3830", Offset = "0x26E2430", VA = "0x1826E3830")]
			public void LoadData(CommonSquadGroupViewModel squadGroupViewModel)
			{
			}

			// Token: 0x0602B189 RID: 176521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B189")]
			[Address(RVA = "0x26E38F0", Offset = "0x26E24F0", VA = "0x1826E38F0", Slot = "4")]
			public void UpdateData(CommonSquadGroupViewModel squadGroupViewModel)
			{
			}

			// Token: 0x0602B18A RID: 176522 RVA: 0x000DAD60 File Offset: 0x000D8F60
			[Token(Token = "0x602B18A")]
			[Address(RVA = "0x26E36F0", Offset = "0x26E22F0", VA = "0x1826E36F0")]
			public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType GetCharTypeInAct(string charId)
			{
				return Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType.COMMON;
			}

			// Token: 0x0602B18B RID: 176523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B18B")]
			[Address(RVA = "0x26E3980", Offset = "0x26E2580", VA = "0x1826E3980")]
			public Act1VHalfIdleSquadCustomData()
			{
			}

			// Token: 0x0403E45E RID: 255070
			[Token(Token = "0x403E45E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<string, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType> m_charTypeDict;

			// Token: 0x0403E45F RID: 255071
			[Token(Token = "0x403E45F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E460 RID: 255072
			[Token(Token = "0x403E460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0403E461 RID: 255073
			[Token(Token = "0x403E461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCharTypeInAct;

			// Token: 0x0403E462 RID: 255074
			[Token(Token = "0x403E462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
