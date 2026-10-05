using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Scripts.UI.Squad;
using Torappu.UI;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E7A RID: 28282
	[Token(Token = "0x2006E7A")]
	public class VecBreakSquadGroupViewModel : SquadGroupViewModel
	{
		// Token: 0x17005F0B RID: 24331
		// (get) Token: 0x060283E7 RID: 164839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F0B")]
		public string stageId
		{
			[Token(Token = "0x60283E7")]
			[Address(RVA = "0x239CE70", Offset = "0x239BA70", VA = "0x18239CE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x060283E8 RID: 164840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F0C")]
		public string actId
		{
			[Token(Token = "0x60283E8")]
			[Address(RVA = "0x239CCE0", Offset = "0x239B8E0", VA = "0x18239CCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x060283E9 RID: 164841 RVA: 0x000D0FC8 File Offset: 0x000CF1C8
		[Token(Token = "0x17005F0D")]
		public bool canAssist
		{
			[Token(Token = "0x60283E9")]
			[Address(RVA = "0x239CD80", Offset = "0x239B980", VA = "0x18239CD80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x060283EA RID: 164842 RVA: 0x000D0FE0 File Offset: 0x000CF1E0
		[Token(Token = "0x17005F0E")]
		public SquadStartButtonTypeEnum startButtonMode
		{
			[Token(Token = "0x60283EA")]
			[Address(RVA = "0x239CF10", Offset = "0x239BB10", VA = "0x18239CF10")]
			get
			{
				return SquadStartButtonTypeEnum.COMMON;
			}
		}

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x060283EB RID: 164843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F0F")]
		public ExternalRuneChecker externalRuneChecker
		{
			[Token(Token = "0x60283EB")]
			[Address(RVA = "0x239CE10", Offset = "0x239BA10", VA = "0x18239CE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060283EC RID: 164844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283EC")]
		[Address(RVA = "0x239A330", Offset = "0x2398F30", VA = "0x18239A330")]
		public void LoadData(VecBreakSquadPage.InputParams inputParams)
		{
		}

		// Token: 0x060283ED RID: 164845 RVA: 0x000D0FF8 File Offset: 0x000CF1F8
		[Token(Token = "0x60283ED")]
		[Address(RVA = "0x239A060", Offset = "0x2398C60", VA = "0x18239A060")]
		public VecBreakStageDefendStatus CalcCharDefendStatus(int charInstId)
		{
			return VecBreakStageDefendStatus.NONE;
		}

		// Token: 0x060283EE RID: 164846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283EE")]
		[Address(RVA = "0x239A0F0", Offset = "0x2398CF0", VA = "0x18239A0F0")]
		public string GetDefendHint(VecBreakStageDefendStatus defendStatus)
		{
			return null;
		}

		// Token: 0x060283EF RID: 164847 RVA: 0x000D1010 File Offset: 0x000CF210
		[Token(Token = "0x60283EF")]
		[Address(RVA = "0x239A8E0", Offset = "0x23994E0", VA = "0x18239A8E0")]
		public bool TryCreateBattleParam(out BattleStartController.Param battleParam)
		{
			return default(bool);
		}

		// Token: 0x060283F0 RID: 164848 RVA: 0x000D1028 File Offset: 0x000CF228
		[Token(Token = "0x60283F0")]
		[Address(RVA = "0x239A210", Offset = "0x2398E10", VA = "0x18239A210")]
		public SquadMaxNumInfo GetSquadMaxRawNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x060283F1 RID: 164849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283F1")]
		[Address(RVA = "0x239A590", Offset = "0x2399190", VA = "0x18239A590")]
		public void SaveAllSquadDataToLocalCache()
		{
		}

		// Token: 0x060283F2 RID: 164850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283F2")]
		[Address(RVA = "0x239B040", Offset = "0x2399C40", VA = "0x18239B040")]
		public void UpdateMemberStatus()
		{
		}

		// Token: 0x060283F3 RID: 164851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283F3")]
		[Address(RVA = "0x239C230", Offset = "0x239AE30", VA = "0x18239C230")]
		private SquadViewModel _LoadSquadViewModel()
		{
			return null;
		}

		// Token: 0x060283F4 RID: 164852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283F4")]
		[Address(RVA = "0x239B490", Offset = "0x239A090", VA = "0x18239B490")]
		private CommonStartBattleRequest.SquadModel _CreateRequestSquad()
		{
			return null;
		}

		// Token: 0x060283F5 RID: 164853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283F5")]
		[Address(RVA = "0x239B7E0", Offset = "0x239A3E0", VA = "0x18239B7E0")]
		private SquadItemStruct[] _CreateSquadLocal()
		{
			return null;
		}

		// Token: 0x060283F6 RID: 164854 RVA: 0x000D1040 File Offset: 0x000CF240
		[Token(Token = "0x60283F6")]
		[Address(RVA = "0x239C9E0", Offset = "0x239B5E0", VA = "0x18239C9E0")]
		private BattleFinishIllust _PickRandomChar()
		{
			return default(BattleFinishIllust);
		}

		// Token: 0x060283F7 RID: 164855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283F7")]
		[Address(RVA = "0x239B930", Offset = "0x239A530", VA = "0x18239B930")]
		private void _FillSquadMembersByLocalCache(List<SquadSlotCache> cachedSquad, int squadSlotMax, SquadItemStruct[] members)
		{
		}

		// Token: 0x060283F8 RID: 164856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283F8")]
		[Address(RVA = "0x239BBD0", Offset = "0x239A7D0", VA = "0x18239BBD0")]
		private void _FillSquadMembersByPlayerData(SquadItemStruct[] members)
		{
		}

		// Token: 0x060283F9 RID: 164857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283F9")]
		[Address(RVA = "0x239BF10", Offset = "0x239AB10", VA = "0x18239BF10")]
		private void _KickOutDefendCharsFromSquad(SquadViewModel squadViewModel)
		{
		}

		// Token: 0x060283FA RID: 164858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283FA")]
		[Address(RVA = "0x239C7E0", Offset = "0x239B3E0", VA = "0x18239C7E0")]
		private static string _MigrateSkillIfTmplChanged(CharacterCardViewModel curCard, SquadSlotCache savedSlot)
		{
			return null;
		}

		// Token: 0x060283FB RID: 164859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283FB")]
		[Address(RVA = "0x239C5E0", Offset = "0x239B1E0", VA = "0x18239C5E0")]
		private static string _MigrateEquipIfTmplChanged(CharacterCardViewModel curCard, SquadSlotCache savedSlot)
		{
			return null;
		}

		// Token: 0x060283FC RID: 164860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283FC")]
		[Address(RVA = "0x239C100", Offset = "0x239AD00", VA = "0x18239C100")]
		private void _LoadDataFromStage()
		{
		}

		// Token: 0x060283FD RID: 164861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283FD")]
		[Address(RVA = "0x239CC30", Offset = "0x239B830", VA = "0x18239CC30")]
		public VecBreakSquadGroupViewModel()
		{
		}

		// Token: 0x04039339 RID: 234297
		[Token(Token = "0x4039339")]
		[FieldOffset(Offset = "0x40")]
		private ExternalRuneChecker m_externalRuneChecker;

		// Token: 0x0403933A RID: 234298
		[Token(Token = "0x403933A")]
		[FieldOffset(Offset = "0x48")]
		private VecBreakStageInfoProvider m_stageProvider;

		// Token: 0x0403933B RID: 234299
		[Token(Token = "0x403933B")]
		private const int VEC_BREAK_SQUADS_SIZE = 1;

		// Token: 0x0403933C RID: 234300
		[Token(Token = "0x403933C")]
		private const int FIRST_SQUAD_FROM_TROOP_INDEX = 0;

		// Token: 0x0403933D RID: 234301
		[Token(Token = "0x403933D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403933E RID: 234302
		[Token(Token = "0x403933E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403933F RID: 234303
		[Token(Token = "0x403933F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_canAssist;

		// Token: 0x04039340 RID: 234304
		[Token(Token = "0x4039340")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_startButtonMode;

		// Token: 0x04039341 RID: 234305
		[Token(Token = "0x4039341")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_externalRuneChecker;

		// Token: 0x04039342 RID: 234306
		[Token(Token = "0x4039342")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039343 RID: 234307
		[Token(Token = "0x4039343")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CalcCharDefendStatus;

		// Token: 0x04039344 RID: 234308
		[Token(Token = "0x4039344")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDefendHint;

		// Token: 0x04039345 RID: 234309
		[Token(Token = "0x4039345")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryCreateBattleParam;

		// Token: 0x04039346 RID: 234310
		[Token(Token = "0x4039346")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSquadMaxRawNumInfo;

		// Token: 0x04039347 RID: 234311
		[Token(Token = "0x4039347")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveAllSquadDataToLocalCache;

		// Token: 0x04039348 RID: 234312
		[Token(Token = "0x4039348")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateMemberStatus;

		// Token: 0x04039349 RID: 234313
		[Token(Token = "0x4039349")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadSquadViewModel;

		// Token: 0x0403934A RID: 234314
		[Token(Token = "0x403934A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateRequestSquad;

		// Token: 0x0403934B RID: 234315
		[Token(Token = "0x403934B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateSquadLocal;

		// Token: 0x0403934C RID: 234316
		[Token(Token = "0x403934C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PickRandomChar;

		// Token: 0x0403934D RID: 234317
		[Token(Token = "0x403934D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FillSquadMembersByLocalCache;

		// Token: 0x0403934E RID: 234318
		[Token(Token = "0x403934E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FillSquadMembersByPlayerData;

		// Token: 0x0403934F RID: 234319
		[Token(Token = "0x403934F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__KickOutDefendCharsFromSquad;

		// Token: 0x04039350 RID: 234320
		[Token(Token = "0x4039350")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__MigrateSkillIfTmplChanged;

		// Token: 0x04039351 RID: 234321
		[Token(Token = "0x4039351")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__MigrateEquipIfTmplChanged;

		// Token: 0x04039352 RID: 234322
		[Token(Token = "0x4039352")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadDataFromStage;

		// Token: 0x04039353 RID: 234323
		[Token(Token = "0x4039353")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
