using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B8 RID: 1464
	[Token(Token = "0x20005B8")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ClimbTowerDB")]
	[Serializable]
	public class ClimbTowerDB : ConstTable<ClimbTowerTable, ClimbTowerDB>
	{
		// Token: 0x060060F3 RID: 24819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0x1CEB380", Offset = "0x1CE9F80", VA = "0x181CEB380", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F4")]
		[Address(RVA = "0x1CEB320", Offset = "0x1CE9F20", VA = "0x181CEB320")]
		public string[] GetTrainTowerIds()
		{
			return null;
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F5")]
		[Address(RVA = "0x1CEB270", Offset = "0x1CE9E70", VA = "0x181CEB270")]
		public List<ClimbTowerTacticalBuffData> GetBuffListByProfession(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F6")]
		[Address(RVA = "0x1CEBBB0", Offset = "0x1CEA7B0", VA = "0x181CEBBB0")]
		public ClimbTowerDB()
		{
		}

		// Token: 0x04002A78 RID: 10872
		[Token(Token = "0x4002A78")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<ProfessionCategory, List<ClimbTowerTacticalBuffData>> m_tacticalBuffDict;

		// Token: 0x04002A79 RID: 10873
		[Token(Token = "0x4002A79")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private ListDict<string, ClimbTowerSingleTowerData> m_trainTowerMap;

		// Token: 0x04002A7A RID: 10874
		[Token(Token = "0x4002A7A")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private string[] m_trainTowerIdArray;

		// Token: 0x04002A7B RID: 10875
		[Token(Token = "0x4002A7B")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private List<string> m_trainTowerIdList;

		// Token: 0x04002A7C RID: 10876
		[Token(Token = "0x4002A7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A7D RID: 10877
		[Token(Token = "0x4002A7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTrainTowerIds;

		// Token: 0x04002A7E RID: 10878
		[Token(Token = "0x4002A7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBuffListByProfession;

		// Token: 0x04002A7F RID: 10879
		[Token(Token = "0x4002A7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
