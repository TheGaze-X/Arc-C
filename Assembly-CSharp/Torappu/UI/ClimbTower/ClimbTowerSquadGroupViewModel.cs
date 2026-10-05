using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D5F RID: 23903
	[Token(Token = "0x2005D5F")]
	public class ClimbTowerSquadGroupViewModel : SquadGroupViewModel
	{
		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x060229FB RID: 141819 RVA: 0x000BE1E8 File Offset: 0x000BC3E8
		[Token(Token = "0x17005193")]
		public int currentAssitCount
		{
			[Token(Token = "0x60229FB")]
			[Address(RVA = "0x1D2B1F0", Offset = "0x1D29DF0", VA = "0x181D2B1F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x060229FC RID: 141820 RVA: 0x000BE200 File Offset: 0x000BC400
		[Token(Token = "0x17005194")]
		public int editableMemCount
		{
			[Token(Token = "0x60229FC")]
			[Address(RVA = "0x1D2B340", Offset = "0x1D29F40", VA = "0x181D2B340")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x060229FD RID: 141821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005195")]
		public SquadItemStruct[] selfMembers
		{
			[Token(Token = "0x60229FD")]
			[Address(RVA = "0x1D2B450", Offset = "0x1D2A050", VA = "0x181D2B450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x060229FE RID: 141822 RVA: 0x000BE218 File Offset: 0x000BC418
		[Token(Token = "0x17005196")]
		public EvolvePhaseAndLevel maxEvolvePhaseAndLevel
		{
			[Token(Token = "0x60229FE")]
			[Address(RVA = "0x1D2B3B0", Offset = "0x1D29FB0", VA = "0x181D2B3B0")]
			get
			{
				return default(EvolvePhaseAndLevel);
			}
		}

		// Token: 0x060229FF RID: 141823 RVA: 0x000BE230 File Offset: 0x000BC430
		[Token(Token = "0x60229FF")]
		[Address(RVA = "0x1D2A260", Offset = "0x1D28E60", VA = "0x181D2A260")]
		public int GetTotalMemCount()
		{
			return 0;
		}

		// Token: 0x06022A00 RID: 141824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A00")]
		[Address(RVA = "0x1D29C50", Offset = "0x1D28850", VA = "0x181D29C50")]
		public void GetAssistDataList(List<SquadFriendData> outputList)
		{
		}

		// Token: 0x06022A01 RID: 141825 RVA: 0x000BE248 File Offset: 0x000BC448
		[Token(Token = "0x6022A01")]
		[Address(RVA = "0x1D29FF0", Offset = "0x1D28BF0", VA = "0x181D29FF0")]
		public int GetProfessionCount(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x06022A02 RID: 141826 RVA: 0x000BE260 File Offset: 0x000BC460
		[Token(Token = "0x6022A02")]
		[Address(RVA = "0x1D2ACE0", Offset = "0x1D298E0", VA = "0x181D2ACE0")]
		private int _GetRealAssistIdx(int index)
		{
			return 0;
		}

		// Token: 0x06022A03 RID: 141827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A03")]
		[Address(RVA = "0x1D2A370", Offset = "0x1D28F70", VA = "0x181D2A370")]
		public void LoadDataFromClimbTower(PlayerTower playerTower)
		{
		}

		// Token: 0x06022A04 RID: 141828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A04")]
		[Address(RVA = "0x1D2AD50", Offset = "0x1D29950", VA = "0x181D2AD50")]
		private void _LoadSquadFromPlayerData(PlayerTower playerTower, out SquadItemStruct[] squadItemList)
		{
		}

		// Token: 0x06022A05 RID: 141829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A05")]
		[Address(RVA = "0x1D29E10", Offset = "0x1D28A10", VA = "0x181D29E10")]
		public ClimbTowerFriendAssistModel GetAssistModelByIndex(int index)
		{
			return null;
		}

		// Token: 0x06022A06 RID: 141830 RVA: 0x000BE278 File Offset: 0x000BC478
		[Token(Token = "0x6022A06")]
		[Address(RVA = "0x1D2A900", Offset = "0x1D29500", VA = "0x181D2A900")]
		public bool TryGetInstInSquad(int instId, out SquadItemStruct inst)
		{
			return default(bool);
		}

		// Token: 0x06022A07 RID: 141831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A07")]
		[Address(RVA = "0x1D2A6A0", Offset = "0x1D292A0", VA = "0x181D2A6A0")]
		public void ShrinkAssistList()
		{
		}

		// Token: 0x06022A08 RID: 141832 RVA: 0x000BE290 File Offset: 0x000BC490
		[Token(Token = "0x6022A08")]
		[Address(RVA = "0x1D29AD0", Offset = "0x1D286D0", VA = "0x181D29AD0")]
		public bool CheckIfContainedInAssistList(string charId, int m_selectAssistIndex)
		{
			return default(bool);
		}

		// Token: 0x06022A09 RID: 141833 RVA: 0x000BE2A8 File Offset: 0x000BC4A8
		[Token(Token = "0x6022A09")]
		[Address(RVA = "0x1D2A300", Offset = "0x1D28F00", VA = "0x181D2A300")]
		public bool IsFull()
		{
			return default(bool);
		}

		// Token: 0x06022A0A RID: 141834 RVA: 0x000BE2C0 File Offset: 0x000BC4C0
		[Token(Token = "0x6022A0A")]
		[Address(RVA = "0x1D29EB0", Offset = "0x1D28AB0", VA = "0x181D29EB0")]
		public int GetAvailAssistIndex()
		{
			return 0;
		}

		// Token: 0x06022A0B RID: 141835 RVA: 0x000BE2D8 File Offset: 0x000BC4D8
		[Token(Token = "0x6022A0B")]
		[Address(RVA = "0x1D2AAD0", Offset = "0x1D296D0", VA = "0x181D2AAD0")]
		public bool TryGetMutuallyExclusiveCharInfoInAssist(int m_selectAssistIndex, string charId, out string exclusiveCharInfo)
		{
			return default(bool);
		}

		// Token: 0x06022A0C RID: 141836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A0C")]
		[Address(RVA = "0x1D29920", Offset = "0x1D28520", VA = "0x181D29920")]
		public void CheckAndClearMutuallyExclusiveChar(string charId)
		{
		}

		// Token: 0x06022A0D RID: 141837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A0D")]
		[Address(RVA = "0x1D2B190", Offset = "0x1D29D90", VA = "0x181D2B190")]
		public ClimbTowerSquadGroupViewModel()
		{
		}

		// Token: 0x0402F958 RID: 194904
		[Token(Token = "0x402F958")]
		[FieldOffset(Offset = "0x40")]
		private ClimbTowerFriendAssistModel[] m_assistList;

		// Token: 0x0402F959 RID: 194905
		[Token(Token = "0x402F959")]
		[FieldOffset(Offset = "0x48")]
		public bool isFromRecord;

		// Token: 0x0402F95A RID: 194906
		[Token(Token = "0x402F95A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentAssitCount;

		// Token: 0x0402F95B RID: 194907
		[Token(Token = "0x402F95B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_editableMemCount;

		// Token: 0x0402F95C RID: 194908
		[Token(Token = "0x402F95C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selfMembers;

		// Token: 0x0402F95D RID: 194909
		[Token(Token = "0x402F95D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxEvolvePhaseAndLevel;

		// Token: 0x0402F95E RID: 194910
		[Token(Token = "0x402F95E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTotalMemCount;

		// Token: 0x0402F95F RID: 194911
		[Token(Token = "0x402F95F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetAssistDataList;

		// Token: 0x0402F960 RID: 194912
		[Token(Token = "0x402F960")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProfessionCount;

		// Token: 0x0402F961 RID: 194913
		[Token(Token = "0x402F961")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetRealAssistIdx;

		// Token: 0x0402F962 RID: 194914
		[Token(Token = "0x402F962")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadDataFromClimbTower;

		// Token: 0x0402F963 RID: 194915
		[Token(Token = "0x402F963")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadSquadFromPlayerData;

		// Token: 0x0402F964 RID: 194916
		[Token(Token = "0x402F964")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetAssistModelByIndex;

		// Token: 0x0402F965 RID: 194917
		[Token(Token = "0x402F965")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetInstInSquad;

		// Token: 0x0402F966 RID: 194918
		[Token(Token = "0x402F966")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShrinkAssistList;

		// Token: 0x0402F967 RID: 194919
		[Token(Token = "0x402F967")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIfContainedInAssistList;

		// Token: 0x0402F968 RID: 194920
		[Token(Token = "0x402F968")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsFull;

		// Token: 0x0402F969 RID: 194921
		[Token(Token = "0x402F969")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetAvailAssistIndex;

		// Token: 0x0402F96A RID: 194922
		[Token(Token = "0x402F96A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryGetMutuallyExclusiveCharInfoInAssist;

		// Token: 0x0402F96B RID: 194923
		[Token(Token = "0x402F96B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckAndClearMutuallyExclusiveChar;

		// Token: 0x0402F96C RID: 194924
		[Token(Token = "0x402F96C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
