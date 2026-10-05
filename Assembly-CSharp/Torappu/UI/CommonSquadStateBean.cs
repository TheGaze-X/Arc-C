using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.Squad;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035DB RID: 13787
	[Token(Token = "0x20035DB")]
	public class CommonSquadStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x06015F0C RID: 89868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034C1")]
		public CommonSquadGroupViewProperty squadGroupProp
		{
			[Token(Token = "0x6015F0C")]
			[Address(RVA = "0xE7B500", Offset = "0xE7A100", VA = "0x180E7B500")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x06015F0D RID: 89869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034C2")]
		public ICommonSquadPlugin squadPlugin
		{
			[Token(Token = "0x6015F0D")]
			[Address(RVA = "0xE7B560", Offset = "0xE7A160", VA = "0x180E7B560")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015F0E RID: 89870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F0E")]
		[Address(RVA = "0xE7A9E0", Offset = "0xE795E0", VA = "0x180E7A9E0")]
		public void SetPlugin(ICommonSquadPlugin plugin)
		{
		}

		// Token: 0x06015F0F RID: 89871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F0F")]
		[Address(RVA = "0xE7A470", Offset = "0xE79070", VA = "0x180E7A470")]
		public void LoadData(ICommonSquadPage.ISquadInputs squadInputs, ICommonSquadMsgReceiver msgReceiver)
		{
		}

		// Token: 0x06015F10 RID: 89872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F10")]
		[Address(RVA = "0xE7B1C0", Offset = "0xE79DC0", VA = "0x180E7B1C0")]
		private void _LoadDataInternal(ICommonSquadPage.ISquadInputs squadInputs)
		{
		}

		// Token: 0x06015F11 RID: 89873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F11")]
		[Address(RVA = "0xE7A860", Offset = "0xE79460", VA = "0x180E7A860")]
		public void RefreshData()
		{
		}

		// Token: 0x06015F12 RID: 89874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F12")]
		[Address(RVA = "0xE7AA60", Offset = "0xE79660", VA = "0x180E7AA60")]
		private void _InitViewModel(ICommonSquadPage.ISquadInputs squadInputs)
		{
		}

		// Token: 0x06015F13 RID: 89875 RVA: 0x0008EC50 File Offset: 0x0008CE50
		[Token(Token = "0x6015F13")]
		[Address(RVA = "0xE78AD0", Offset = "0xE776D0", VA = "0x180E78AD0")]
		public bool CheckIfCharRuneValid(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06015F14 RID: 89876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F14")]
		[Address(RVA = "0xE7A120", Offset = "0xE78D20", VA = "0x180E7A120")]
		public ExternalRuneChecker GetExternalRuneChecker()
		{
			return null;
		}

		// Token: 0x06015F15 RID: 89877 RVA: 0x0008EC68 File Offset: 0x0008CE68
		[Token(Token = "0x6015F15")]
		[Address(RVA = "0xE78B90", Offset = "0xE77790", VA = "0x180E78B90")]
		public bool CheckIfFriendLegal()
		{
			return default(bool);
		}

		// Token: 0x06015F16 RID: 89878 RVA: 0x0008EC80 File Offset: 0x0008CE80
		[Token(Token = "0x6015F16")]
		[Address(RVA = "0xE7A220", Offset = "0xE78E20", VA = "0x180E7A220")]
		public int GetSquadAssistNum()
		{
			return 0;
		}

		// Token: 0x06015F17 RID: 89879 RVA: 0x0008EC98 File Offset: 0x0008CE98
		[Token(Token = "0x6015F17")]
		[Address(RVA = "0xE7A660", Offset = "0xE79260", VA = "0x180E7A660")]
		public int MaxNum4CharSelect()
		{
			return 0;
		}

		// Token: 0x06015F18 RID: 89880 RVA: 0x0008ECB0 File Offset: 0x0008CEB0
		[Token(Token = "0x6015F18")]
		[Address(RVA = "0xE7A300", Offset = "0xE78F00", VA = "0x180E7A300")]
		public SquadMaxNumInfo GetSquadMaxRawNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06015F19 RID: 89881 RVA: 0x0008ECC8 File Offset: 0x0008CEC8
		[Token(Token = "0x6015F19")]
		[Address(RVA = "0xE7A080", Offset = "0xE78C80", VA = "0x180E7A080")]
		public int GetCurSquadValidMemberNum()
		{
			return 0;
		}

		// Token: 0x06015F1A RID: 89882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F1A")]
		[Address(RVA = "0xE79FF0", Offset = "0xE78BF0", VA = "0x180E79FF0")]
		public CommonSquadSingleSquadViewModel GetCurSelectSquad()
		{
			return null;
		}

		// Token: 0x06015F1B RID: 89883 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
		[Token(Token = "0x6015F1B")]
		[Address(RVA = "0xE78D20", Offset = "0xE77920", VA = "0x180E78D20")]
		public BattleStartController.Param CreateParamToStartBattle()
		{
			return default(BattleStartController.Param);
		}

		// Token: 0x06015F1C RID: 89884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F1C")]
		[Address(RVA = "0xE7B410", Offset = "0xE7A010", VA = "0x180E7B410")]
		public CommonSquadStateBean()
		{
		}

		// Token: 0x0401A5FF RID: 108031
		[Token(Token = "0x401A5FF")]
		[FieldOffset(Offset = "0x10")]
		private CommonSquadGroupViewProperty m_squadProperty;

		// Token: 0x0401A600 RID: 108032
		[Token(Token = "0x401A600")]
		[FieldOffset(Offset = "0x18")]
		private ICommonSquadPlugin m_squadPlugin;

		// Token: 0x0401A601 RID: 108033
		[Token(Token = "0x401A601")]
		[FieldOffset(Offset = "0x20")]
		private ICommonSquadPage.ISquadInputs m_cachedSquadInputs;

		// Token: 0x0401A602 RID: 108034
		[Token(Token = "0x401A602")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadGroupProp;

		// Token: 0x0401A603 RID: 108035
		[Token(Token = "0x401A603")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_squadPlugin;

		// Token: 0x0401A604 RID: 108036
		[Token(Token = "0x401A604")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPlugin;

		// Token: 0x0401A605 RID: 108037
		[Token(Token = "0x401A605")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401A606 RID: 108038
		[Token(Token = "0x401A606")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadDataInternal;

		// Token: 0x0401A607 RID: 108039
		[Token(Token = "0x401A607")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401A608 RID: 108040
		[Token(Token = "0x401A608")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitViewModel;

		// Token: 0x0401A609 RID: 108041
		[Token(Token = "0x401A609")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfCharRuneValid;

		// Token: 0x0401A60A RID: 108042
		[Token(Token = "0x401A60A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetExternalRuneChecker;

		// Token: 0x0401A60B RID: 108043
		[Token(Token = "0x401A60B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfFriendLegal;

		// Token: 0x0401A60C RID: 108044
		[Token(Token = "0x401A60C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetSquadAssistNum;

		// Token: 0x0401A60D RID: 108045
		[Token(Token = "0x401A60D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_MaxNum4CharSelect;

		// Token: 0x0401A60E RID: 108046
		[Token(Token = "0x401A60E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetSquadMaxRawNumInfo;

		// Token: 0x0401A60F RID: 108047
		[Token(Token = "0x401A60F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCurSquadValidMemberNum;

		// Token: 0x0401A610 RID: 108048
		[Token(Token = "0x401A610")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetCurSelectSquad;

		// Token: 0x0401A611 RID: 108049
		[Token(Token = "0x401A611")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CreateParamToStartBattle;

		// Token: 0x0401A612 RID: 108050
		[Token(Token = "0x401A612")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
