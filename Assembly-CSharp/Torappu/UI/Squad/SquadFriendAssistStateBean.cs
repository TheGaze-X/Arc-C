using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DF4 RID: 15860
	[Token(Token = "0x2003DF4")]
	public class SquadFriendAssistStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x06018AB4 RID: 101044 RVA: 0x0009B2F8 File Offset: 0x000994F8
		// (set) Token: 0x06018AB5 RID: 101045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003ABB")]
		public EvolvePhaseAndLevel maxPhaseAndLv
		{
			[Token(Token = "0x6018AB4")]
			[Address(RVA = "0x1124220", Offset = "0x1122E20", VA = "0x181124220")]
			get
			{
				return default(EvolvePhaseAndLevel);
			}
			[Token(Token = "0x6018AB5")]
			[Address(RVA = "0x1124530", Offset = "0x1123130", VA = "0x181124530")]
			set
			{
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x06018AB6 RID: 101046 RVA: 0x0009B310 File Offset: 0x00099510
		// (set) Token: 0x06018AB7 RID: 101047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003ABC")]
		public SquadFriendAssistStateBean.ExtraInput extraInput
		{
			[Token(Token = "0x6018AB6")]
			[Address(RVA = "0x1124180", Offset = "0x1122D80", VA = "0x181124180")]
			[CompilerGenerated]
			get
			{
				return default(SquadFriendAssistStateBean.ExtraInput);
			}
			[Token(Token = "0x6018AB7")]
			[Address(RVA = "0x1124480", Offset = "0x1123080", VA = "0x181124480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x06018AB8 RID: 101048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018AB9 RID: 101049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003ABD")]
		public SquadFriendAssistState.IPlugin statePlugin
		{
			[Token(Token = "0x6018AB8")]
			[Address(RVA = "0x1124400", Offset = "0x1123000", VA = "0x181124400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018AB9")]
			[Address(RVA = "0x11245F0", Offset = "0x11231F0", VA = "0x1811245F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x06018ABA RID: 101050 RVA: 0x0009B328 File Offset: 0x00099528
		[Token(Token = "0x17003ABE")]
		public SquadFriendAssistStateBean.RenderOptions renderOption
		{
			[Token(Token = "0x6018ABA")]
			[Address(RVA = "0x1124380", Offset = "0x1122F80", VA = "0x181124380")]
			get
			{
				return default(SquadFriendAssistStateBean.RenderOptions);
			}
		}

		// Token: 0x06018ABB RID: 101051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ABB")]
		[Address(RVA = "0x1122EE0", Offset = "0x1121AE0", VA = "0x181122EE0")]
		public void SetExtraInput(SquadFriendAssistStateBean.ExtraInput input)
		{
		}

		// Token: 0x06018ABC RID: 101052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ABC")]
		[Address(RVA = "0x1122960", Offset = "0x1121560", VA = "0x181122960")]
		public void ClearStatePlugin()
		{
		}

		// Token: 0x06018ABD RID: 101053 RVA: 0x0009B340 File Offset: 0x00099540
		[Token(Token = "0x6018ABD")]
		[Address(RVA = "0x1122770", Offset = "0x1121370", VA = "0x181122770")]
		public bool CheckIfContainedInCurSquad(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018ABE RID: 101054 RVA: 0x0009B358 File Offset: 0x00099558
		[Token(Token = "0x6018ABE")]
		[Address(RVA = "0x1123400", Offset = "0x1122000", VA = "0x181123400")]
		public bool TryGetMutuallyExclusiveCharInfoInCurSquad(string charId, out string exclusiveInfo)
		{
			return default(bool);
		}

		// Token: 0x06018ABF RID: 101055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018ABF")]
		[Address(RVA = "0x11229E0", Offset = "0x11215E0", VA = "0x1811229E0")]
		public SquadFriendData ConvertAssistDataToFriendData(SquadAssistData assistData)
		{
			return null;
		}

		// Token: 0x06018AC0 RID: 101056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AC0")]
		[Address(RVA = "0x11231E0", Offset = "0x1121DE0", VA = "0x1811231E0")]
		public void SetFriendDataCache(ProfessionCategory profession, GetFriendAssistCharListResponse response)
		{
		}

		// Token: 0x06018AC1 RID: 101057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AC1")]
		[Address(RVA = "0x1122D70", Offset = "0x1121970", VA = "0x181122D70")]
		public GetFriendAssistCharListResponse GetFriendDataCache(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x06018AC2 RID: 101058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AC2")]
		[Address(RVA = "0x1123350", Offset = "0x1121F50", VA = "0x181123350")]
		public void SetFriendReqDisableById(string id)
		{
		}

		// Token: 0x06018AC3 RID: 101059 RVA: 0x0009B370 File Offset: 0x00099570
		[Token(Token = "0x6018AC3")]
		[Address(RVA = "0x1122B40", Offset = "0x1121740", VA = "0x181122B40")]
		public SquadFriendAssistStateBean.Options GetAssistOption(string id)
		{
			return default(SquadFriendAssistStateBean.Options);
		}

		// Token: 0x06018AC4 RID: 101060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AC4")]
		[Address(RVA = "0x11228B0", Offset = "0x11214B0", VA = "0x1811228B0")]
		public void CleanCache()
		{
		}

		// Token: 0x06018AC5 RID: 101061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AC5")]
		[Address(RVA = "0x1122E40", Offset = "0x1121A40", VA = "0x181122E40")]
		public void LoadConstData()
		{
		}

		// Token: 0x06018AC6 RID: 101062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AC6")]
		[Address(RVA = "0x1122C30", Offset = "0x1121830", VA = "0x181122C30")]
		public List<SquadAssistData> GetFriendAssistDataByProfession(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x06018AC7 RID: 101063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AC7")]
		[Address(RVA = "0x1123710", Offset = "0x1122310", VA = "0x181123710")]
		private SquadFriendAssistState.IPlugin _GenerateStatePlugin(SquadFriendAssistStateBean.ExtraInput input)
		{
			return null;
		}

		// Token: 0x06018AC8 RID: 101064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AC8")]
		[Address(RVA = "0x11239C0", Offset = "0x11225C0", VA = "0x1811239C0")]
		private void _UpdateAssistOption(GetFriendAssistCharListResponse response)
		{
		}

		// Token: 0x06018AC9 RID: 101065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AC9")]
		[Address(RVA = "0x1123A90", Offset = "0x1122690", VA = "0x181123A90")]
		private void _UpdateRequestFriendData(SquadAssistData[] assistList, bool isStarFriend)
		{
		}

		// Token: 0x06018ACA RID: 101066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ACA")]
		[Address(RVA = "0x1123570", Offset = "0x1122170", VA = "0x181123570")]
		private void _AddSquadSlotWithoutDup(List<SquadAssistData> retList, SquadAssistData[] dataSource, int maxLength)
		{
		}

		// Token: 0x06018ACB RID: 101067 RVA: 0x0009B388 File Offset: 0x00099588
		[Token(Token = "0x6018ACB")]
		[Address(RVA = "0x11238E0", Offset = "0x11224E0", VA = "0x1811238E0")]
		private bool _IsSameAssistData(SquadAssistData a, SquadAssistData b)
		{
			return default(bool);
		}

		// Token: 0x06018ACC RID: 101068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ACC")]
		[Address(RVA = "0x1123F90", Offset = "0x1122B90", VA = "0x181123F90")]
		public SquadFriendAssistStateBean()
		{
		}

		// Token: 0x0401E3E5 RID: 123877
		[Token(Token = "0x401E3E5")]
		[FieldOffset(Offset = "0x0")]
		public static List<ProfessionCategory> PROFESSION_LIST;

		// Token: 0x0401E3E6 RID: 123878
		[Token(Token = "0x401E3E6")]
		[FieldOffset(Offset = "0x10")]
		public SquadFriendData assistCharModel;

		// Token: 0x0401E3E7 RID: 123879
		[Token(Token = "0x401E3E7")]
		[FieldOffset(Offset = "0x18")]
		public bool isFriend;

		// Token: 0x0401E3E8 RID: 123880
		[Token(Token = "0x401E3E8")]
		[FieldOffset(Offset = "0x20")]
		public ISquadChecker currentSquad;

		// Token: 0x0401E3E9 RID: 123881
		[Token(Token = "0x401E3E9")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<ProfessionCategory, GetFriendAssistCharListResponse> assistDataCacheDict;

		// Token: 0x0401E3EA RID: 123882
		[Token(Token = "0x401E3EA")]
		[FieldOffset(Offset = "0x30")]
		public ProfessionCategory professionCache;

		// Token: 0x0401E3EB RID: 123883
		[Token(Token = "0x401E3EB")]
		[FieldOffset(Offset = "0x38")]
		public ListDict<string, SquadFriendAssistStateBean.Options> assistOptionDict;

		// Token: 0x0401E3EC RID: 123884
		[Token(Token = "0x401E3EC")]
		[FieldOffset(Offset = "0x40")]
		public bool isSquadImmutable;

		// Token: 0x0401E3ED RID: 123885
		[Token(Token = "0x401E3ED")]
		[FieldOffset(Offset = "0x48")]
		public string tipDesc;

		// Token: 0x0401E3EE RID: 123886
		[Token(Token = "0x401E3EE")]
		[FieldOffset(Offset = "0x50")]
		public bool isCharShowMultipleSlot;

		// Token: 0x0401E3EF RID: 123887
		[Token(Token = "0x401E3EF")]
		[FieldOffset(Offset = "0x58")]
		public SquadAssistCharDetailProperty charDetailProperty;

		// Token: 0x0401E3F0 RID: 123888
		[Token(Token = "0x401E3F0")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, FriendDataWithNameCard> cachedNameCardDict;

		// Token: 0x0401E3F1 RID: 123889
		[Token(Token = "0x401E3F1")]
		[FieldOffset(Offset = "0x68")]
		public bool usePlayerSelection;

		// Token: 0x0401E3F2 RID: 123890
		[Token(Token = "0x401E3F2")]
		[FieldOffset(Offset = "0x69")]
		public bool showSpecMaxIcon;

		// Token: 0x0401E3F3 RID: 123891
		[Token(Token = "0x401E3F3")]
		[FieldOffset(Offset = "0x6C")]
		private int m_maxSquadAssistDisplayNum;

		// Token: 0x0401E3F4 RID: 123892
		[Token(Token = "0x401E3F4")]
		[FieldOffset(Offset = "0x70")]
		public bool starFriendTabSelected;

		// Token: 0x0401E3F5 RID: 123893
		[Token(Token = "0x401E3F5")]
		[FieldOffset(Offset = "0x74")]
		private EvolvePhaseAndLevel? m_overridePhaseAndLv;

		// Token: 0x0401E3F8 RID: 123896
		[Token(Token = "0x401E3F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxPhaseAndLv;

		// Token: 0x0401E3F9 RID: 123897
		[Token(Token = "0x401E3F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_maxPhaseAndLv;

		// Token: 0x0401E3FA RID: 123898
		[Token(Token = "0x401E3FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_extraInput;

		// Token: 0x0401E3FB RID: 123899
		[Token(Token = "0x401E3FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_extraInput;

		// Token: 0x0401E3FC RID: 123900
		[Token(Token = "0x401E3FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_statePlugin;

		// Token: 0x0401E3FD RID: 123901
		[Token(Token = "0x401E3FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_statePlugin;

		// Token: 0x0401E3FE RID: 123902
		[Token(Token = "0x401E3FE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_renderOption;

		// Token: 0x0401E3FF RID: 123903
		[Token(Token = "0x401E3FF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetExtraInput;

		// Token: 0x0401E400 RID: 123904
		[Token(Token = "0x401E400")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearStatePlugin;

		// Token: 0x0401E401 RID: 123905
		[Token(Token = "0x401E401")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfContainedInCurSquad;

		// Token: 0x0401E402 RID: 123906
		[Token(Token = "0x401E402")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetMutuallyExclusiveCharInfoInCurSquad;

		// Token: 0x0401E403 RID: 123907
		[Token(Token = "0x401E403")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ConvertAssistDataToFriendData;

		// Token: 0x0401E404 RID: 123908
		[Token(Token = "0x401E404")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetFriendDataCache;

		// Token: 0x0401E405 RID: 123909
		[Token(Token = "0x401E405")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetFriendDataCache;

		// Token: 0x0401E406 RID: 123910
		[Token(Token = "0x401E406")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetFriendReqDisableById;

		// Token: 0x0401E407 RID: 123911
		[Token(Token = "0x401E407")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetAssistOption;

		// Token: 0x0401E408 RID: 123912
		[Token(Token = "0x401E408")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CleanCache;

		// Token: 0x0401E409 RID: 123913
		[Token(Token = "0x401E409")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadConstData;

		// Token: 0x0401E40A RID: 123914
		[Token(Token = "0x401E40A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetFriendAssistDataByProfession;

		// Token: 0x0401E40B RID: 123915
		[Token(Token = "0x401E40B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GenerateStatePlugin;

		// Token: 0x0401E40C RID: 123916
		[Token(Token = "0x401E40C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateAssistOption;

		// Token: 0x0401E40D RID: 123917
		[Token(Token = "0x401E40D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateRequestFriendData;

		// Token: 0x0401E40E RID: 123918
		[Token(Token = "0x401E40E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__AddSquadSlotWithoutDup;

		// Token: 0x0401E40F RID: 123919
		[Token(Token = "0x401E40F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__IsSameAssistData;

		// Token: 0x0401E410 RID: 123920
		[Token(Token = "0x401E410")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DF5 RID: 15861
		[Token(Token = "0x2003DF5")]
		public struct ExtraInput
		{
			// Token: 0x17003ABF RID: 15039
			// (get) Token: 0x06018ACE RID: 101070 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06018ACF RID: 101071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003ABF")]
			public Type pluginType
			{
				[Token(Token = "0x6018ACE")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6018ACF")]
				[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003AC0 RID: 15040
			// (get) Token: 0x06018AD0 RID: 101072 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06018AD1 RID: 101073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003AC0")]
			public object context
			{
				[Token(Token = "0x6018AD0")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6018AD1")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06018AD2 RID: 101074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018AD2")]
			public void SetPlugin<Plugin, Context>(Context cxt) where Plugin : SquadFriendAssistState.Plugin<Context>, new()
			{
			}

			// Token: 0x0401E411 RID: 123921
			[Token(Token = "0x401E411")]
			[FieldOffset(Offset = "0x0")]
			public bool ignoreMainlineSquadWeight;
		}

		// Token: 0x02003DF6 RID: 15862
		[Token(Token = "0x2003DF6")]
		public struct Options
		{
			// Token: 0x0401E414 RID: 123924
			[Token(Token = "0x401E414")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SquadFriendAssistStateBean.Options DEFAULT;

			// Token: 0x0401E415 RID: 123925
			[Token(Token = "0x401E415")]
			[FieldOffset(Offset = "0x0")]
			public bool isFriendRequestEnable;

			// Token: 0x0401E416 RID: 123926
			[Token(Token = "0x401E416")]
			[FieldOffset(Offset = "0x1")]
			public bool isStarFriend;
		}

		// Token: 0x02003DF7 RID: 15863
		[Token(Token = "0x2003DF7")]
		public struct RenderOptions
		{
			// Token: 0x0401E417 RID: 123927
			[Token(Token = "0x401E417")]
			[FieldOffset(Offset = "0x0")]
			public bool isCharShowMultipleSlot;

			// Token: 0x0401E418 RID: 123928
			[Token(Token = "0x401E418")]
			[FieldOffset(Offset = "0x1")]
			public bool usePlayerSelection;
		}
	}
}
