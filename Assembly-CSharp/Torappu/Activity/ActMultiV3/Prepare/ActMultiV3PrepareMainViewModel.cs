using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.Multiplayer.Servers;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007029 RID: 28713
	[Token(Token = "0x2007029")]
	public class ActMultiV3PrepareMainViewModel : IHotfixable
	{
		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x06028C17 RID: 166935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C18 RID: 166936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006039")]
		public string activityId
		{
			[Token(Token = "0x6028C17")]
			[Address(RVA = "0x240D440", Offset = "0x240C040", VA = "0x18240D440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C18")]
			[Address(RVA = "0x240DB80", Offset = "0x240C780", VA = "0x18240DB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x06028C19 RID: 166937 RVA: 0x000D2DE0 File Offset: 0x000D0FE0
		// (set) Token: 0x06028C1A RID: 166938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700603A")]
		public bool isMatch
		{
			[Token(Token = "0x6028C19")]
			[Address(RVA = "0x240D8F0", Offset = "0x240C4F0", VA = "0x18240D8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028C1A")]
			[Address(RVA = "0x240E150", Offset = "0x240CD50", VA = "0x18240E150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x06028C1B RID: 166939 RVA: 0x000D2DF8 File Offset: 0x000D0FF8
		// (set) Token: 0x06028C1C RID: 166940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700603B")]
		public bool isInvertMode
		{
			[Token(Token = "0x6028C1B")]
			[Address(RVA = "0x240D890", Offset = "0x240C490", VA = "0x18240D890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028C1C")]
			[Address(RVA = "0x240E0E0", Offset = "0x240CCE0", VA = "0x18240E0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x06028C1D RID: 166941 RVA: 0x000D2E10 File Offset: 0x000D1010
		// (set) Token: 0x06028C1E RID: 166942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700603C")]
		public ActMultiV3PrepareStepType currStep
		{
			[Token(Token = "0x6028C1D")]
			[Address(RVA = "0x240D770", Offset = "0x240C370", VA = "0x18240D770")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3PrepareStepType.NONE;
			}
			[Token(Token = "0x6028C1E")]
			[Address(RVA = "0x240DF80", Offset = "0x240CB80", VA = "0x18240DF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x06028C1F RID: 166943 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C20 RID: 166944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700603D")]
		public ActMultiV3SelectStepData currStepData
		{
			[Token(Token = "0x6028C1F")]
			[Address(RVA = "0x240D710", Offset = "0x240C310", VA = "0x18240D710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C20")]
			[Address(RVA = "0x240DF00", Offset = "0x240CB00", VA = "0x18240DF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x06028C21 RID: 166945 RVA: 0x000D2E28 File Offset: 0x000D1028
		// (set) Token: 0x06028C22 RID: 166946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700603E")]
		public TeamProtocol.TeamState teamState
		{
			[Token(Token = "0x6028C21")]
			[Address(RVA = "0x240DB20", Offset = "0x240C720", VA = "0x18240DB20")]
			[CompilerGenerated]
			get
			{
				return TeamProtocol.TeamState.INIT;
			}
			[Token(Token = "0x6028C22")]
			[Address(RVA = "0x240E3D0", Offset = "0x240CFD0", VA = "0x18240E3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x06028C23 RID: 166947 RVA: 0x000D2E40 File Offset: 0x000D1040
		// (set) Token: 0x06028C24 RID: 166948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700603F")]
		public ActMultiV3PrepareMainViewConfig mainViewConfig
		{
			[Token(Token = "0x6028C23")]
			[Address(RVA = "0x240D950", Offset = "0x240C550", VA = "0x18240D950")]
			[CompilerGenerated]
			get
			{
				return default(ActMultiV3PrepareMainViewConfig);
			}
			[Token(Token = "0x6028C24")]
			[Address(RVA = "0x240E1C0", Offset = "0x240CDC0", VA = "0x18240E1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x06028C25 RID: 166949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C26 RID: 166950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006040")]
		public List<ActMultiV3ConstData.PingCond> pingConds
		{
			[Token(Token = "0x6028C25")]
			[Address(RVA = "0x240D9E0", Offset = "0x240C5E0", VA = "0x18240D9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C26")]
			[Address(RVA = "0x240E250", Offset = "0x240CE50", VA = "0x18240E250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x06028C27 RID: 166951 RVA: 0x000D2E58 File Offset: 0x000D1058
		// (set) Token: 0x06028C28 RID: 166952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006041")]
		public ActMultiV3PrepareMainViewModel.StepCDInfo stepCD
		{
			[Token(Token = "0x6028C27")]
			[Address(RVA = "0x240DAA0", Offset = "0x240C6A0", VA = "0x18240DAA0")]
			[CompilerGenerated]
			get
			{
				return default(ActMultiV3PrepareMainViewModel.StepCDInfo);
			}
			[Token(Token = "0x6028C28")]
			[Address(RVA = "0x240E350", Offset = "0x240CF50", VA = "0x18240E350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x06028C29 RID: 166953 RVA: 0x000D2E70 File Offset: 0x000D1070
		// (set) Token: 0x06028C2A RID: 166954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006042")]
		public ActMultiV3PrepareMainViewModel.StageInfo curStageInfo
		{
			[Token(Token = "0x6028C29")]
			[Address(RVA = "0x240D680", Offset = "0x240C280", VA = "0x18240D680")]
			[CompilerGenerated]
			get
			{
				return default(ActMultiV3PrepareMainViewModel.StageInfo);
			}
			[Token(Token = "0x6028C2A")]
			[Address(RVA = "0x240DE50", Offset = "0x240CA50", VA = "0x18240DE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x06028C2B RID: 166955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C2C RID: 166956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006043")]
		public ActMultiV3DifficultyIconViewModel diffIconModel
		{
			[Token(Token = "0x6028C2B")]
			[Address(RVA = "0x240D7D0", Offset = "0x240C3D0", VA = "0x18240D7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C2C")]
			[Address(RVA = "0x240DFF0", Offset = "0x240CBF0", VA = "0x18240DFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x06028C2D RID: 166957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C2E RID: 166958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006044")]
		public ActMultiV3PrepareMainPlayerInfoViewModel playerInfoViewModel
		{
			[Token(Token = "0x6028C2D")]
			[Address(RVA = "0x240DA40", Offset = "0x240C640", VA = "0x18240DA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C2E")]
			[Address(RVA = "0x240E2D0", Offset = "0x240CED0", VA = "0x18240E2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x06028C2F RID: 166959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C30 RID: 166960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006045")]
		public string cachedPartnerUID
		{
			[Token(Token = "0x6028C2F")]
			[Address(RVA = "0x240D500", Offset = "0x240C100", VA = "0x18240D500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C30")]
			[Address(RVA = "0x240DC80", Offset = "0x240C880", VA = "0x18240DC80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x06028C31 RID: 166961 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C32 RID: 166962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006046")]
		public FriendDataWithNameCard cachedPartnerNameCardData
		{
			[Token(Token = "0x6028C31")]
			[Address(RVA = "0x240D4A0", Offset = "0x240C0A0", VA = "0x18240D4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C32")]
			[Address(RVA = "0x240DC00", Offset = "0x240C800", VA = "0x18240DC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x06028C33 RID: 166963 RVA: 0x000D2E88 File Offset: 0x000D1088
		// (set) Token: 0x06028C34 RID: 166964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006047")]
		public bool inEmergency
		{
			[Token(Token = "0x6028C33")]
			[Address(RVA = "0x240D830", Offset = "0x240C430", VA = "0x18240D830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028C34")]
			[Address(RVA = "0x240E070", Offset = "0x240CC70", VA = "0x18240E070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x06028C35 RID: 166965 RVA: 0x000D2EA0 File Offset: 0x000D10A0
		// (set) Token: 0x06028C36 RID: 166966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006048")]
		public ActMultiV3EmoticonController.LeftChatPosType chatPosType
		{
			[Token(Token = "0x6028C35")]
			[Address(RVA = "0x240D620", Offset = "0x240C220", VA = "0x18240D620")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3EmoticonController.LeftChatPosType.NONE;
			}
			[Token(Token = "0x6028C36")]
			[Address(RVA = "0x240DDE0", Offset = "0x240C9E0", VA = "0x18240DDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x06028C37 RID: 166967 RVA: 0x000D2EB8 File Offset: 0x000D10B8
		// (set) Token: 0x06028C38 RID: 166968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006049")]
		public int chatCdSeqNum
		{
			[Token(Token = "0x6028C37")]
			[Address(RVA = "0x240D5C0", Offset = "0x240C1C0", VA = "0x18240D5C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028C38")]
			[Address(RVA = "0x240DD70", Offset = "0x240C970", VA = "0x18240DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x06028C39 RID: 166969 RVA: 0x000D2ED0 File Offset: 0x000D10D0
		// (set) Token: 0x06028C3A RID: 166970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700604A")]
		public int chatCdDuration
		{
			[Token(Token = "0x6028C39")]
			[Address(RVA = "0x240D560", Offset = "0x240C160", VA = "0x18240D560")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028C3A")]
			[Address(RVA = "0x240DD00", Offset = "0x240C900", VA = "0x18240DD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028C3B RID: 166971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C3B")]
		[Address(RVA = "0x240BC50", Offset = "0x240A850", VA = "0x18240BC50")]
		public void LoadStableData(string actId)
		{
		}

		// Token: 0x06028C3C RID: 166972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C3C")]
		[Address(RVA = "0x240C810", Offset = "0x240B410", VA = "0x18240C810")]
		public void Update()
		{
		}

		// Token: 0x06028C3D RID: 166973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C3D")]
		[Address(RVA = "0x240C350", Offset = "0x240AF50", VA = "0x18240C350")]
		public void RefreshPlayerInfoTrackpoint()
		{
		}

		// Token: 0x06028C3E RID: 166974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C3E")]
		[Address(RVA = "0x240D0A0", Offset = "0x240BCA0", VA = "0x18240D0A0")]
		private void _LoadCurStageData(TeamInfo teamInfo)
		{
		}

		// Token: 0x06028C3F RID: 166975 RVA: 0x000D2EE8 File Offset: 0x000D10E8
		[Token(Token = "0x6028C3F")]
		[Address(RVA = "0x240CFC0", Offset = "0x240BBC0", VA = "0x18240CFC0")]
		private ActMultiV3PrepareStepType _GetStep(TeamProtocol.TeamState teamState)
		{
			return ActMultiV3PrepareStepType.NONE;
		}

		// Token: 0x06028C40 RID: 166976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C40")]
		[Address(RVA = "0x240C6C0", Offset = "0x240B2C0", VA = "0x18240C6C0")]
		public void SetPartnerNameCardData(string uid, FriendDataWithNameCard data)
		{
		}

		// Token: 0x06028C41 RID: 166977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C41")]
		[Address(RVA = "0x240C500", Offset = "0x240B100", VA = "0x18240C500")]
		public void SetMainViewConfig(ActMultiV3PrepareMainViewConfig mvConfig, out bool isChatPosTypeChanged)
		{
		}

		// Token: 0x06028C42 RID: 166978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C42")]
		[Address(RVA = "0x240C450", Offset = "0x240B050", VA = "0x18240C450")]
		public void SetInEmergency(bool state)
		{
		}

		// Token: 0x06028C43 RID: 166979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C43")]
		[Address(RVA = "0x240C240", Offset = "0x240AE40", VA = "0x18240C240")]
		public void NotifyChatCD()
		{
		}

		// Token: 0x06028C44 RID: 166980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C44")]
		[Address(RVA = "0x240D3E0", Offset = "0x240BFE0", VA = "0x18240D3E0")]
		public ActMultiV3PrepareMainViewModel()
		{
		}

		// Token: 0x0403A1E2 RID: 238050
		[Token(Token = "0x403A1E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403A1E3 RID: 238051
		[Token(Token = "0x403A1E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x0403A1E4 RID: 238052
		[Token(Token = "0x403A1E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMatch;

		// Token: 0x0403A1E5 RID: 238053
		[Token(Token = "0x403A1E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isMatch;

		// Token: 0x0403A1E6 RID: 238054
		[Token(Token = "0x403A1E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isInvertMode;

		// Token: 0x0403A1E7 RID: 238055
		[Token(Token = "0x403A1E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isInvertMode;

		// Token: 0x0403A1E8 RID: 238056
		[Token(Token = "0x403A1E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currStep;

		// Token: 0x0403A1E9 RID: 238057
		[Token(Token = "0x403A1E9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_currStep;

		// Token: 0x0403A1EA RID: 238058
		[Token(Token = "0x403A1EA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currStepData;

		// Token: 0x0403A1EB RID: 238059
		[Token(Token = "0x403A1EB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_currStepData;

		// Token: 0x0403A1EC RID: 238060
		[Token(Token = "0x403A1EC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_teamState;

		// Token: 0x0403A1ED RID: 238061
		[Token(Token = "0x403A1ED")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_teamState;

		// Token: 0x0403A1EE RID: 238062
		[Token(Token = "0x403A1EE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_mainViewConfig;

		// Token: 0x0403A1EF RID: 238063
		[Token(Token = "0x403A1EF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_mainViewConfig;

		// Token: 0x0403A1F0 RID: 238064
		[Token(Token = "0x403A1F0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_pingConds;

		// Token: 0x0403A1F1 RID: 238065
		[Token(Token = "0x403A1F1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_pingConds;

		// Token: 0x0403A1F2 RID: 238066
		[Token(Token = "0x403A1F2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_stepCD;

		// Token: 0x0403A1F3 RID: 238067
		[Token(Token = "0x403A1F3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_stepCD;

		// Token: 0x0403A1F4 RID: 238068
		[Token(Token = "0x403A1F4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_curStageInfo;

		// Token: 0x0403A1F5 RID: 238069
		[Token(Token = "0x403A1F5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_curStageInfo;

		// Token: 0x0403A1F6 RID: 238070
		[Token(Token = "0x403A1F6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_diffIconModel;

		// Token: 0x0403A1F7 RID: 238071
		[Token(Token = "0x403A1F7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_diffIconModel;

		// Token: 0x0403A1F8 RID: 238072
		[Token(Token = "0x403A1F8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_playerInfoViewModel;

		// Token: 0x0403A1F9 RID: 238073
		[Token(Token = "0x403A1F9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_playerInfoViewModel;

		// Token: 0x0403A1FA RID: 238074
		[Token(Token = "0x403A1FA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_cachedPartnerUID;

		// Token: 0x0403A1FB RID: 238075
		[Token(Token = "0x403A1FB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_cachedPartnerUID;

		// Token: 0x0403A1FC RID: 238076
		[Token(Token = "0x403A1FC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_cachedPartnerNameCardData;

		// Token: 0x0403A1FD RID: 238077
		[Token(Token = "0x403A1FD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_cachedPartnerNameCardData;

		// Token: 0x0403A1FE RID: 238078
		[Token(Token = "0x403A1FE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_inEmergency;

		// Token: 0x0403A1FF RID: 238079
		[Token(Token = "0x403A1FF")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_inEmergency;

		// Token: 0x0403A200 RID: 238080
		[Token(Token = "0x403A200")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_chatPosType;

		// Token: 0x0403A201 RID: 238081
		[Token(Token = "0x403A201")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_chatPosType;

		// Token: 0x0403A202 RID: 238082
		[Token(Token = "0x403A202")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_chatCdSeqNum;

		// Token: 0x0403A203 RID: 238083
		[Token(Token = "0x403A203")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_chatCdSeqNum;

		// Token: 0x0403A204 RID: 238084
		[Token(Token = "0x403A204")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_chatCdDuration;

		// Token: 0x0403A205 RID: 238085
		[Token(Token = "0x403A205")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_chatCdDuration;

		// Token: 0x0403A206 RID: 238086
		[Token(Token = "0x403A206")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadStableData;

		// Token: 0x0403A207 RID: 238087
		[Token(Token = "0x403A207")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403A208 RID: 238088
		[Token(Token = "0x403A208")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_RefreshPlayerInfoTrackpoint;

		// Token: 0x0403A209 RID: 238089
		[Token(Token = "0x403A209")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__LoadCurStageData;

		// Token: 0x0403A20A RID: 238090
		[Token(Token = "0x403A20A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__GetStep;

		// Token: 0x0403A20B RID: 238091
		[Token(Token = "0x403A20B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_SetPartnerNameCardData;

		// Token: 0x0403A20C RID: 238092
		[Token(Token = "0x403A20C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_SetMainViewConfig;

		// Token: 0x0403A20D RID: 238093
		[Token(Token = "0x403A20D")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_SetInEmergency;

		// Token: 0x0403A20E RID: 238094
		[Token(Token = "0x403A20E")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_NotifyChatCD;

		// Token: 0x0403A20F RID: 238095
		[Token(Token = "0x403A20F")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200702A RID: 28714
		[Token(Token = "0x200702A")]
		public struct StepCDInfo
		{
			// Token: 0x0403A210 RID: 238096
			[Token(Token = "0x403A210")]
			[FieldOffset(Offset = "0x0")]
			public long cdEndTs;

			// Token: 0x0403A211 RID: 238097
			[Token(Token = "0x403A211")]
			[FieldOffset(Offset = "0x8")]
			public float cdTotalSec;

			// Token: 0x0403A212 RID: 238098
			[Token(Token = "0x403A212")]
			[FieldOffset(Offset = "0xC")]
			public int emergencySec;
		}

		// Token: 0x0200702B RID: 28715
		[Token(Token = "0x200702B")]
		public struct StageInfo
		{
			// Token: 0x0403A213 RID: 238099
			[Token(Token = "0x403A213")]
			[FieldOffset(Offset = "0x0")]
			public ActMultiV3MapDiffType diffType;

			// Token: 0x0403A214 RID: 238100
			[Token(Token = "0x403A214")]
			[FieldOffset(Offset = "0x4")]
			public ActMultiV3MapModeType modeType;

			// Token: 0x0403A215 RID: 238101
			[Token(Token = "0x403A215")]
			[FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x0403A216 RID: 238102
			[Token(Token = "0x403A216")]
			[FieldOffset(Offset = "0x10")]
			public string stageName;

			// Token: 0x0403A217 RID: 238103
			[Token(Token = "0x403A217")]
			[FieldOffset(Offset = "0x18")]
			public string stageCode;

			// Token: 0x0403A218 RID: 238104
			[Token(Token = "0x403A218")]
			[FieldOffset(Offset = "0x20")]
			public TeamProtocol.StageRandomType stageRandomType;
		}
	}
}
