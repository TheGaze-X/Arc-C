using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E50 RID: 15952
	[Token(Token = "0x2003E50")]
	public class SpecialOperatorBoardMasterNode : SpecialOperatorBoardNodeBase
	{
		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x06018CDA RID: 101594 RVA: 0x0009BF58 File Offset: 0x0009A158
		[Token(Token = "0x17003B30")]
		public override bool isUnlocked
		{
			[Token(Token = "0x6018CDA")]
			[Address(RVA = "0x116F620", Offset = "0x116E220", VA = "0x18116F620", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x06018CDB RID: 101595 RVA: 0x0009BF70 File Offset: 0x0009A170
		// (set) Token: 0x06018CDC RID: 101596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B31")]
		public override bool unlockTaskMeet
		{
			[Token(Token = "0x6018CDB")]
			[Address(RVA = "0x116F6F0", Offset = "0x116E2F0", VA = "0x18116F6F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018CDC")]
			[Address(RVA = "0x116F7C0", Offset = "0x116E3C0", VA = "0x18116F7C0", Slot = "8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x06018CDD RID: 101597 RVA: 0x0009BF88 File Offset: 0x0009A188
		// (set) Token: 0x06018CDE RID: 101598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B32")]
		public override bool evolveLevelMeet
		{
			[Token(Token = "0x6018CDD")]
			[Address(RVA = "0x116F5C0", Offset = "0x116E1C0", VA = "0x18116F5C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018CDE")]
			[Address(RVA = "0x116F750", Offset = "0x116E350", VA = "0x18116F750", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x06018CDF RID: 101599 RVA: 0x0009BFA0 File Offset: 0x0009A1A0
		[Token(Token = "0x17003B33")]
		public bool conditionCompleted
		{
			[Token(Token = "0x6018CDF")]
			[Address(RVA = "0x116F550", Offset = "0x116E150", VA = "0x18116F550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x06018CE0 RID: 101600 RVA: 0x0009BFB8 File Offset: 0x0009A1B8
		[Token(Token = "0x17003B34")]
		public override SpecialOperatorSelectAnchorType selectAnchorType
		{
			[Token(Token = "0x6018CE0")]
			[Address(RVA = "0x116F680", Offset = "0x116E280", VA = "0x18116F680", Slot = "11")]
			get
			{
				return SpecialOperatorSelectAnchorType.OFFSET;
			}
		}

		// Token: 0x06018CE1 RID: 101601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CE1")]
		[Address(RVA = "0x116F1B0", Offset = "0x116DDB0", VA = "0x18116F1B0", Slot = "10")]
		public override void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018CE2 RID: 101602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CE2")]
		[Address(RVA = "0x116EE30", Offset = "0x116DA30", VA = "0x18116EE30", Slot = "9")]
		protected override void OnInitData()
		{
		}

		// Token: 0x06018CE3 RID: 101603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CE3")]
		[Address(RVA = "0x116F4B0", Offset = "0x116E0B0", VA = "0x18116F4B0")]
		public SpecialOperatorBoardMasterNode()
		{
		}

		// Token: 0x06018CE4 RID: 101604 RVA: 0x0009BFD0 File Offset: 0x0009A1D0
		[Token(Token = "0x6018CE4")]
		[Address(RVA = "0x116F450", Offset = "0x116E050", VA = "0x18116F450")]
		private SpecialOperatorSelectAnchorType <>xLuaBaseProxy_get_selectAnchorType()
		{
			return SpecialOperatorSelectAnchorType.OFFSET;
		}

		// Token: 0x0401E7C7 RID: 124871
		[Token(Token = "0x401E7C7")]
		[FieldOffset(Offset = "0x40")]
		public string masterId;

		// Token: 0x0401E7C8 RID: 124872
		[Token(Token = "0x401E7C8")]
		[FieldOffset(Offset = "0x48")]
		public int level;

		// Token: 0x0401E7C9 RID: 124873
		[Token(Token = "0x401E7C9")]
		[FieldOffset(Offset = "0x50")]
		public string name;

		// Token: 0x0401E7CA RID: 124874
		[Token(Token = "0x401E7CA")]
		[FieldOffset(Offset = "0x58")]
		public string conditionDesc;

		// Token: 0x0401E7CB RID: 124875
		[Token(Token = "0x401E7CB")]
		[FieldOffset(Offset = "0x60")]
		public string effectDesc;

		// Token: 0x0401E7CC RID: 124876
		[Token(Token = "0x401E7CC")]
		[FieldOffset(Offset = "0x68")]
		public string unlockTaskId;

		// Token: 0x0401E7CD RID: 124877
		[Token(Token = "0x401E7CD")]
		[FieldOffset(Offset = "0x70")]
		public int unlockTaskProgress;

		// Token: 0x0401E7CE RID: 124878
		[Token(Token = "0x401E7CE")]
		[FieldOffset(Offset = "0x74")]
		public int unlockTaskTarget;

		// Token: 0x0401E7CF RID: 124879
		[Token(Token = "0x401E7CF")]
		[FieldOffset(Offset = "0x78")]
		public string unlockConditionDesc;

		// Token: 0x0401E7D0 RID: 124880
		[Token(Token = "0x401E7D0")]
		[FieldOffset(Offset = "0x80")]
		public SpecialOperatorNodeStyleType nodeStyleType;

		// Token: 0x0401E7D1 RID: 124881
		[Token(Token = "0x401E7D1")]
		[FieldOffset(Offset = "0x84")]
		public SpecialOperatorConditionViewType conditionType;

		// Token: 0x0401E7D2 RID: 124882
		[Token(Token = "0x401E7D2")]
		[FieldOffset(Offset = "0x88")]
		public string upgradeNoticeStr;

		// Token: 0x0401E7D3 RID: 124883
		[Token(Token = "0x401E7D3")]
		[FieldOffset(Offset = "0x90")]
		public PlayerSpecialOperatorNode.State nodeState;

		// Token: 0x0401E7D4 RID: 124884
		[Token(Token = "0x401E7D4")]
		[FieldOffset(Offset = "0x94")]
		public EvolvePhase nodeUnlockPhase;

		// Token: 0x0401E7D5 RID: 124885
		[Token(Token = "0x401E7D5")]
		[FieldOffset(Offset = "0x98")]
		public int nodeUnlockLevel;

		// Token: 0x0401E7D8 RID: 124888
		[Token(Token = "0x401E7D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlocked;

		// Token: 0x0401E7D9 RID: 124889
		[Token(Token = "0x401E7D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_unlockTaskMeet;

		// Token: 0x0401E7DA RID: 124890
		[Token(Token = "0x401E7DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_unlockTaskMeet;

		// Token: 0x0401E7DB RID: 124891
		[Token(Token = "0x401E7DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_evolveLevelMeet;

		// Token: 0x0401E7DC RID: 124892
		[Token(Token = "0x401E7DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_evolveLevelMeet;

		// Token: 0x0401E7DD RID: 124893
		[Token(Token = "0x401E7DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_conditionCompleted;

		// Token: 0x0401E7DE RID: 124894
		[Token(Token = "0x401E7DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectAnchorType;

		// Token: 0x0401E7DF RID: 124895
		[Token(Token = "0x401E7DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E7E0 RID: 124896
		[Token(Token = "0x401E7E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInitData;

		// Token: 0x0401E7E1 RID: 124897
		[Token(Token = "0x401E7E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
