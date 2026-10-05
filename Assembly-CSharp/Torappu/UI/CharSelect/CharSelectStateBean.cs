using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E0E RID: 24078
	[Token(Token = "0x2005E0E")]
	public class CharSelectStateBean : PageComponent, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06022E57 RID: 142935 RVA: 0x000BF670 File Offset: 0x000BD870
		[Token(Token = "0x6022E57")]
		[Address(RVA = "0x1D68760", Offset = "0x1D67360", VA = "0x181D68760")]
		public CharSelectStateBean.CharSelectInputParam DefaultSelectInputParam(CharSelectStateBean.Input input, int squadIndex)
		{
			return default(CharSelectStateBean.CharSelectInputParam);
		}

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x06022E58 RID: 142936 RVA: 0x000BF688 File Offset: 0x000BD888
		[Token(Token = "0x170052B6")]
		public bool isSingleMode
		{
			[Token(Token = "0x6022E58")]
			[Address(RVA = "0x1D6B210", Offset = "0x1D69E10", VA = "0x181D6B210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x06022E59 RID: 142937 RVA: 0x000BF6A0 File Offset: 0x000BD8A0
		[Token(Token = "0x170052B7")]
		public bool isSkillSelectablePredefined
		{
			[Token(Token = "0x6022E59")]
			[Address(RVA = "0x1D6B270", Offset = "0x1D69E70", VA = "0x181D6B270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x06022E5A RID: 142938 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022E5B RID: 142939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052B8")]
		public UICharacterSelectState.IPlugin statePlugin
		{
			[Token(Token = "0x6022E5A")]
			[Address(RVA = "0x1D6B350", Offset = "0x1D69F50", VA = "0x181D6B350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022E5B")]
			[Address(RVA = "0x1D6B4F0", Offset = "0x1D6A0F0", VA = "0x181D6B4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06022E5C RID: 142940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E5C")]
		[Address(RVA = "0x1D69970", Offset = "0x1D68570", VA = "0x181D69970")]
		public void SetData(CharSelectStateBean.Input input)
		{
		}

		// Token: 0x06022E5D RID: 142941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E5D")]
		[Address(RVA = "0x1D68AD0", Offset = "0x1D676D0", VA = "0x181D68AD0")]
		public void ReloadData()
		{
		}

		// Token: 0x06022E5E RID: 142942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E5E")]
		[Address(RVA = "0x1D689C0", Offset = "0x1D675C0", VA = "0x181D689C0")]
		public string GetSelectedSkillId(int charInstId)
		{
			return null;
		}

		// Token: 0x06022E5F RID: 142943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E5F")]
		[Address(RVA = "0x1D688B0", Offset = "0x1D674B0", VA = "0x181D688B0")]
		public string GetSelectedBranchId(int charInstId)
		{
			return null;
		}

		// Token: 0x06022E60 RID: 142944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E60")]
		[Address(RVA = "0x1D6A9F0", Offset = "0x1D695F0", VA = "0x181D6A9F0")]
		public void SwitchSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x06022E61 RID: 142945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E61")]
		[Address(RVA = "0x1D681B0", Offset = "0x1D66DB0", VA = "0x181D681B0")]
		public void ChangeFilter(CharacterProfessionFilterParam filterParam)
		{
		}

		// Token: 0x06022E62 RID: 142946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E62")]
		[Address(RVA = "0x1D6AB20", Offset = "0x1D69720", VA = "0x181D6AB20")]
		public void ToggleStarMarkTopSelected()
		{
		}

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x06022E63 RID: 142947 RVA: 0x000BF6B8 File Offset: 0x000BD8B8
		// (set) Token: 0x06022E64 RID: 142948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052B9")]
		public bool starMarkTopState
		{
			[Token(Token = "0x6022E63")]
			[Address(RVA = "0x1D6B2D0", Offset = "0x1D69ED0", VA = "0x181D6B2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022E64")]
			[Address(RVA = "0x1D6B3B0", Offset = "0x1D69FB0", VA = "0x181D6B3B0")]
			set
			{
			}
		}

		// Token: 0x06022E65 RID: 142949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E65")]
		[Address(RVA = "0x1D68280", Offset = "0x1D66E80", VA = "0x181D68280")]
		public void ClearSquad()
		{
		}

		// Token: 0x06022E66 RID: 142950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E66")]
		[Address(RVA = "0x1D68550", Offset = "0x1D67150", VA = "0x181D68550")]
		public void ConfirmOutputData()
		{
		}

		// Token: 0x06022E67 RID: 142951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E67")]
		[Address(RVA = "0x1D69660", Offset = "0x1D68260", VA = "0x181D69660")]
		public void SelectSkill(string skillId)
		{
		}

		// Token: 0x06022E68 RID: 142952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E68")]
		[Address(RVA = "0x1D69410", Offset = "0x1D68010", VA = "0x181D69410")]
		public void SelectBranch(string equipId)
		{
		}

		// Token: 0x06022E69 RID: 142953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E69")]
		[Address(RVA = "0x1D68380", Offset = "0x1D66F80", VA = "0x181D68380")]
		public void ClearStatePlugin()
		{
		}

		// Token: 0x06022E6A RID: 142954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E6A")]
		[Address(RVA = "0x1D6ABF0", Offset = "0x1D697F0", VA = "0x181D6ABF0")]
		private UICharacterSelectState.IPlugin _GenerateStatePlugin(CharSelectStateBean.Input input)
		{
			return null;
		}

		// Token: 0x06022E6B RID: 142955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E6B")]
		[Address(RVA = "0x1D6ADD0", Offset = "0x1D699D0", VA = "0x181D6ADD0")]
		private void _InitSpriteHubIfNot()
		{
		}

		// Token: 0x06022E6C RID: 142956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E6C")]
		[Address(RVA = "0x1D6AF60", Offset = "0x1D69B60", VA = "0x181D6AF60")]
		private static string _UpdateSelectedSkillDuringReload(int instId, string prevSkillId)
		{
			return null;
		}

		// Token: 0x06022E6D RID: 142957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E6D")]
		[Address(RVA = "0x1D6AE90", Offset = "0x1D69A90", VA = "0x181D6AE90")]
		private static string _UpdateSelectedBranchDuringReload(int instId, string prevEquipId)
		{
			return null;
		}

		// Token: 0x06022E6E RID: 142958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E6E")]
		[Address(RVA = "0x1D6B030", Offset = "0x1D69C30", VA = "0x181D6B030")]
		public CharSelectStateBean()
		{
		}

		// Token: 0x040300C2 RID: 196802
		[Token(Token = "0x40300C2")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CharacterCardSortTypeViewProperty cardSortTypeProperty;

		// Token: 0x040300C3 RID: 196803
		[Token(Token = "0x40300C3")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public CharAttrViewProperty attrProperty;

		// Token: 0x040300C4 RID: 196804
		[Token(Token = "0x40300C4")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public CardGroupViewProperty cardGroupProperty;

		// Token: 0x040300C5 RID: 196805
		[Token(Token = "0x40300C5")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public CharSelectStateBean.Output outputParam;

		// Token: 0x040300C6 RID: 196806
		[Token(Token = "0x40300C6")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public int maxSelectNum;

		// Token: 0x040300C7 RID: 196807
		[Token(Token = "0x40300C7")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public BoolProperty starMarkSelectedProperty;

		// Token: 0x040300C8 RID: 196808
		[Token(Token = "0x40300C8")]
		[FieldOffset(Offset = "0xA0")]
		private CharSelectStateBean.Input m_inputParam;

		// Token: 0x040300C9 RID: 196809
		[Token(Token = "0x40300C9")]
		[FieldOffset(Offset = "0xE0")]
		private SpriteHub m_professionIconHub;

		// Token: 0x040300CB RID: 196811
		[Token(Token = "0x40300CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DefaultSelectInputParam;

		// Token: 0x040300CC RID: 196812
		[Token(Token = "0x40300CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSingleMode;

		// Token: 0x040300CD RID: 196813
		[Token(Token = "0x40300CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSkillSelectablePredefined;

		// Token: 0x040300CE RID: 196814
		[Token(Token = "0x40300CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_statePlugin;

		// Token: 0x040300CF RID: 196815
		[Token(Token = "0x40300CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_statePlugin;

		// Token: 0x040300D0 RID: 196816
		[Token(Token = "0x40300D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040300D1 RID: 196817
		[Token(Token = "0x40300D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReloadData;

		// Token: 0x040300D2 RID: 196818
		[Token(Token = "0x40300D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSelectedSkillId;

		// Token: 0x040300D3 RID: 196819
		[Token(Token = "0x40300D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetSelectedBranchId;

		// Token: 0x040300D4 RID: 196820
		[Token(Token = "0x40300D4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SwitchSortType;

		// Token: 0x040300D5 RID: 196821
		[Token(Token = "0x40300D5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ChangeFilter;

		// Token: 0x040300D6 RID: 196822
		[Token(Token = "0x40300D6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ToggleStarMarkTopSelected;

		// Token: 0x040300D7 RID: 196823
		[Token(Token = "0x40300D7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_starMarkTopState;

		// Token: 0x040300D8 RID: 196824
		[Token(Token = "0x40300D8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_starMarkTopState;

		// Token: 0x040300D9 RID: 196825
		[Token(Token = "0x40300D9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ClearSquad;

		// Token: 0x040300DA RID: 196826
		[Token(Token = "0x40300DA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ConfirmOutputData;

		// Token: 0x040300DB RID: 196827
		[Token(Token = "0x40300DB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SelectSkill;

		// Token: 0x040300DC RID: 196828
		[Token(Token = "0x40300DC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SelectBranch;

		// Token: 0x040300DD RID: 196829
		[Token(Token = "0x40300DD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ClearStatePlugin;

		// Token: 0x040300DE RID: 196830
		[Token(Token = "0x40300DE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenerateStatePlugin;

		// Token: 0x040300DF RID: 196831
		[Token(Token = "0x40300DF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitSpriteHubIfNot;

		// Token: 0x040300E0 RID: 196832
		[Token(Token = "0x40300E0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateSelectedSkillDuringReload;

		// Token: 0x040300E1 RID: 196833
		[Token(Token = "0x40300E1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateSelectedBranchDuringReload;

		// Token: 0x040300E2 RID: 196834
		[Token(Token = "0x40300E2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E0F RID: 24079
		[Token(Token = "0x2005E0F")]
		public struct Input
		{
			// Token: 0x170052BA RID: 21178
			// (get) Token: 0x06022E6F RID: 142959 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022E70 RID: 142960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170052BA")]
			public Type pluginType
			{
				[Token(Token = "0x6022E6F")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6022E70")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170052BB RID: 21179
			// (get) Token: 0x06022E71 RID: 142961 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022E72 RID: 142962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170052BB")]
			public object context
			{
				[Token(Token = "0x6022E71")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6022E72")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06022E73 RID: 142963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E73")]
			public void SetPlugin<Plugin, Context>(Context cxt) where Plugin : UICharacterSelectState.Plugin<Context>, new()
			{
			}

			// Token: 0x040300E3 RID: 196835
			[Token(Token = "0x40300E3")]
			[FieldOffset(Offset = "0x0")]
			public int editingIndex;

			// Token: 0x040300E4 RID: 196836
			[Token(Token = "0x40300E4")]
			[FieldOffset(Offset = "0x4")]
			public bool isSingleMode;

			// Token: 0x040300E5 RID: 196837
			[Token(Token = "0x40300E5")]
			[FieldOffset(Offset = "0x5")]
			public bool isSkillSelectablePredefined;

			// Token: 0x040300E6 RID: 196838
			[Token(Token = "0x40300E6")]
			[FieldOffset(Offset = "0x8")]
			public int maxSelectNum;

			// Token: 0x040300E7 RID: 196839
			[Token(Token = "0x40300E7")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, string> selectedChars;

			// Token: 0x040300E8 RID: 196840
			[Token(Token = "0x40300E8")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, string> selectedEquips;

			// Token: 0x040300E9 RID: 196841
			[Token(Token = "0x40300E9")]
			[FieldOffset(Offset = "0x20")]
			public List<CharacterCardViewModel> candidates;

			// Token: 0x040300EA RID: 196842
			[Token(Token = "0x40300EA")]
			[FieldOffset(Offset = "0x28")]
			public CharacterSortType defaultSortType;
		}

		// Token: 0x02005E10 RID: 24080
		[Token(Token = "0x2005E10")]
		public struct Output
		{
			// Token: 0x040300ED RID: 196845
			[Token(Token = "0x40300ED")]
			[FieldOffset(Offset = "0x0")]
			public bool isConfirm;

			// Token: 0x040300EE RID: 196846
			[Token(Token = "0x40300EE")]
			[FieldOffset(Offset = "0x8")]
			public List<CharacterCardViewModel> selectedChars;

			// Token: 0x040300EF RID: 196847
			[Token(Token = "0x40300EF")]
			[FieldOffset(Offset = "0x10")]
			public List<KeyValuePair<int, string>> selectedSquadItems;

			// Token: 0x040300F0 RID: 196848
			[Token(Token = "0x40300F0")]
			[FieldOffset(Offset = "0x18")]
			public CharSelectStateBean.Input inputClosure;
		}

		// Token: 0x02005E11 RID: 24081
		[Token(Token = "0x2005E11")]
		public interface ICharSelectInputParam
		{
			// Token: 0x170052BC RID: 21180
			// (get) Token: 0x06022E74 RID: 142964
			[Token(Token = "0x170052BC")]
			CharSelectStateBean.Input inputParam { [Token(Token = "0x6022E74")] get; }

			// Token: 0x170052BD RID: 21181
			// (get) Token: 0x06022E75 RID: 142965
			[Token(Token = "0x170052BD")]
			int squadIndex { [Token(Token = "0x6022E75")] get; }
		}

		// Token: 0x02005E12 RID: 24082
		[Token(Token = "0x2005E12")]
		public struct CharSelectInputParam : CharSelectStateBean.ICharSelectInputParam
		{
			// Token: 0x170052BE RID: 21182
			// (get) Token: 0x06022E76 RID: 142966 RVA: 0x000BF6D0 File Offset: 0x000BD8D0
			[Token(Token = "0x170052BE")]
			public CharSelectStateBean.Input inputParam
			{
				[Token(Token = "0x6022E76")]
				[Address(RVA = "0x111C700", Offset = "0x111B300", VA = "0x18111C700", Slot = "4")]
				get
				{
					return default(CharSelectStateBean.Input);
				}
			}

			// Token: 0x170052BF RID: 21183
			// (get) Token: 0x06022E77 RID: 142967 RVA: 0x000BF6E8 File Offset: 0x000BD8E8
			// (set) Token: 0x06022E78 RID: 142968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170052BF")]
			public int squadIndex
			{
				[Token(Token = "0x6022E77")]
				[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6022E78")]
				[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x040300F1 RID: 196849
			[Token(Token = "0x40300F1")]
			[FieldOffset(Offset = "0x0")]
			public CharSelectStateBean.Input paramToSelectState;
		}
	}
}
