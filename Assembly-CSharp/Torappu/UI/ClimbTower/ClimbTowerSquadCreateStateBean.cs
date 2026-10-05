using System;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D5D RID: 23901
	[Token(Token = "0x2005D5D")]
	public class ClimbTowerSquadCreateStateBean : IStateBean, IHotfixable
	{
		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x060229E7 RID: 141799 RVA: 0x000BE128 File Offset: 0x000BC328
		// (set) Token: 0x060229E8 RID: 141800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700518D")]
		public int selectAssistIndex
		{
			[Token(Token = "0x60229E7")]
			[Address(RVA = "0x1D210E0", Offset = "0x1D1FCE0", VA = "0x181D210E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60229E8")]
			[Address(RVA = "0x1D212F0", Offset = "0x1D1FEF0", VA = "0x181D212F0")]
			set
			{
			}
		}

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x060229E9 RID: 141801 RVA: 0x000BE140 File Offset: 0x000BC340
		// (set) Token: 0x060229EA RID: 141802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700518E")]
		public ProfessionCategory assistProfession
		{
			[Token(Token = "0x60229E9")]
			[Address(RVA = "0x1D20FA0", Offset = "0x1D1FBA0", VA = "0x181D20FA0")]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x60229EA")]
			[Address(RVA = "0x1D21200", Offset = "0x1D1FE00", VA = "0x181D21200")]
			set
			{
			}
		}

		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x060229EB RID: 141803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700518F")]
		public SquadGroupViewProperty squadProperty
		{
			[Token(Token = "0x60229EB")]
			[Address(RVA = "0x1D21140", Offset = "0x1D1FD40", VA = "0x181D21140")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x060229EC RID: 141804 RVA: 0x000BE158 File Offset: 0x000BC358
		// (set) Token: 0x060229ED RID: 141805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005190")]
		public ClimbTowerSquadCreateStateBean.FriendAssistDataStruct friendDataCache
		{
			[Token(Token = "0x60229EC")]
			[Address(RVA = "0x1D21060", Offset = "0x1D1FC60", VA = "0x181D21060")]
			get
			{
				return default(ClimbTowerSquadCreateStateBean.FriendAssistDataStruct);
			}
			[Token(Token = "0x60229ED")]
			[Address(RVA = "0x1D21270", Offset = "0x1D1FE70", VA = "0x181D21270")]
			set
			{
			}
		}

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x060229EE RID: 141806 RVA: 0x000BE170 File Offset: 0x000BC370
		[Token(Token = "0x17005191")]
		public int totalStepCount
		{
			[Token(Token = "0x60229EE")]
			[Address(RVA = "0x1D211A0", Offset = "0x1D1FDA0", VA = "0x181D211A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x060229EF RID: 141807 RVA: 0x000BE188 File Offset: 0x000BC388
		[Token(Token = "0x17005192")]
		public int currentStep
		{
			[Token(Token = "0x60229EF")]
			[Address(RVA = "0x1D21000", Offset = "0x1D1FC00", VA = "0x181D21000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060229F0 RID: 141808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F0")]
		[Address(RVA = "0x1D20060", Offset = "0x1D1EC60", VA = "0x181D20060")]
		public void InitData()
		{
		}

		// Token: 0x060229F1 RID: 141809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F1")]
		[Address(RVA = "0x1D20DC0", Offset = "0x1D1F9C0", VA = "0x181D20DC0")]
		private void _InitSquadProperty(PlayerTower playerTower)
		{
		}

		// Token: 0x060229F2 RID: 141810 RVA: 0x000BE1A0 File Offset: 0x000BC3A0
		[Token(Token = "0x60229F2")]
		[Address(RVA = "0x1D1FE10", Offset = "0x1D1EA10", VA = "0x181D1FE10")]
		public bool CheckIfContainedInOtherAssist(string charId)
		{
			return default(bool);
		}

		// Token: 0x060229F3 RID: 141811 RVA: 0x000BE1B8 File Offset: 0x000BC3B8
		[Token(Token = "0x60229F3")]
		[Address(RVA = "0x1D20C60", Offset = "0x1D1F860", VA = "0x181D20C60")]
		public bool TryGetMutuallyExclusiveCharInfoInAssist(string charId, out string exclusiveCharInfo)
		{
			return default(bool);
		}

		// Token: 0x060229F4 RID: 141812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F4")]
		[Address(RVA = "0x1D1FC00", Offset = "0x1D1E800", VA = "0x181D1FC00")]
		public void ApplyToFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x060229F5 RID: 141813 RVA: 0x000BE1D0 File Offset: 0x000BC3D0
		[Token(Token = "0x60229F5")]
		[Address(RVA = "0x1D20270", Offset = "0x1D1EE70", VA = "0x181D20270")]
		public bool ReceiveFromFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
			return default(bool);
		}

		// Token: 0x060229F6 RID: 141814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F6")]
		[Address(RVA = "0x1D1F240", Offset = "0x1D1DE40", VA = "0x181D1F240")]
		public void ApplySquadFromCharSelect(CharSelectStateBean charSelectBean)
		{
		}

		// Token: 0x060229F7 RID: 141815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F7")]
		[Address(RVA = "0x1D20520", Offset = "0x1D1F120", VA = "0x181D20520")]
		public void RefreshData()
		{
		}

		// Token: 0x060229F8 RID: 141816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F8")]
		[Address(RVA = "0x1D20610", Offset = "0x1D1F210", VA = "0x181D20610")]
		public void SaveConfigToCache()
		{
		}

		// Token: 0x060229F9 RID: 141817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229F9")]
		[Address(RVA = "0x1D20B80", Offset = "0x1D1F780", VA = "0x181D20B80")]
		public void SetHasSelectSquad()
		{
		}

		// Token: 0x060229FA RID: 141818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60229FA")]
		[Address(RVA = "0x1D20EF0", Offset = "0x1D1FAF0", VA = "0x181D20EF0")]
		public ClimbTowerSquadCreateStateBean()
		{
		}

		// Token: 0x0402F93B RID: 194875
		[Token(Token = "0x402F93B")]
		[FieldOffset(Offset = "0x10")]
		private SquadGroupViewProperty m_squadProperty;

		// Token: 0x0402F93C RID: 194876
		[Token(Token = "0x402F93C")]
		[FieldOffset(Offset = "0x18")]
		private int m_selectAssistIndex;

		// Token: 0x0402F93D RID: 194877
		[Token(Token = "0x402F93D")]
		[FieldOffset(Offset = "0x1C")]
		private ProfessionCategory m_assistProfession;

		// Token: 0x0402F93E RID: 194878
		[Token(Token = "0x402F93E")]
		[FieldOffset(Offset = "0x20")]
		private ClimbTowerSquadCreateStateBean.FriendAssistDataStruct m_friendDataCache;

		// Token: 0x0402F93F RID: 194879
		[Token(Token = "0x402F93F")]
		[FieldOffset(Offset = "0x30")]
		private string m_towerId;

		// Token: 0x0402F940 RID: 194880
		[Token(Token = "0x402F940")]
		[FieldOffset(Offset = "0x38")]
		private int m_currentStep;

		// Token: 0x0402F941 RID: 194881
		[Token(Token = "0x402F941")]
		[FieldOffset(Offset = "0x3C")]
		private int m_totalStepCount;

		// Token: 0x0402F942 RID: 194882
		[Token(Token = "0x402F942")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectAssistIndex;

		// Token: 0x0402F943 RID: 194883
		[Token(Token = "0x402F943")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectAssistIndex;

		// Token: 0x0402F944 RID: 194884
		[Token(Token = "0x402F944")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_assistProfession;

		// Token: 0x0402F945 RID: 194885
		[Token(Token = "0x402F945")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_assistProfession;

		// Token: 0x0402F946 RID: 194886
		[Token(Token = "0x402F946")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_squadProperty;

		// Token: 0x0402F947 RID: 194887
		[Token(Token = "0x402F947")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_friendDataCache;

		// Token: 0x0402F948 RID: 194888
		[Token(Token = "0x402F948")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_friendDataCache;

		// Token: 0x0402F949 RID: 194889
		[Token(Token = "0x402F949")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_totalStepCount;

		// Token: 0x0402F94A RID: 194890
		[Token(Token = "0x402F94A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currentStep;

		// Token: 0x0402F94B RID: 194891
		[Token(Token = "0x402F94B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F94C RID: 194892
		[Token(Token = "0x402F94C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitSquadProperty;

		// Token: 0x0402F94D RID: 194893
		[Token(Token = "0x402F94D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfContainedInOtherAssist;

		// Token: 0x0402F94E RID: 194894
		[Token(Token = "0x402F94E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetMutuallyExclusiveCharInfoInAssist;

		// Token: 0x0402F94F RID: 194895
		[Token(Token = "0x402F94F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ApplyToFriendAssistBean;

		// Token: 0x0402F950 RID: 194896
		[Token(Token = "0x402F950")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ReceiveFromFriendAssistBean;

		// Token: 0x0402F951 RID: 194897
		[Token(Token = "0x402F951")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ApplySquadFromCharSelect;

		// Token: 0x0402F952 RID: 194898
		[Token(Token = "0x402F952")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402F953 RID: 194899
		[Token(Token = "0x402F953")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SaveConfigToCache;

		// Token: 0x0402F954 RID: 194900
		[Token(Token = "0x402F954")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetHasSelectSquad;

		// Token: 0x0402F955 RID: 194901
		[Token(Token = "0x402F955")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D5E RID: 23902
		[Token(Token = "0x2005D5E")]
		public struct FriendAssistDataStruct
		{
			// Token: 0x0402F956 RID: 194902
			[Token(Token = "0x402F956")]
			[FieldOffset(Offset = "0x0")]
			public GetFriendAssistCharListResponse friendAssistResp;

			// Token: 0x0402F957 RID: 194903
			[Token(Token = "0x402F957")]
			[FieldOffset(Offset = "0x8")]
			public bool isFromRemote;
		}
	}
}
