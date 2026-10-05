using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005C1 RID: 1473
	[Token(Token = "0x20005C1")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/GachaData")]
	public class GachaDB : ConstTable<GachaData, GachaDB>
	{
		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06006126 RID: 24870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC4")]
		public Dictionary<int, RecruitPool.RecruitTime> recruitBuildTimeMap
		{
			[Token(Token = "0x6006126")]
			[Address(RVA = "0x1DEC940", Offset = "0x1DEB540", VA = "0x181DEC940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006127")]
		[Address(RVA = "0x1DEC000", Offset = "0x1DEAC00", VA = "0x181DEC000", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006128")]
		[Address(RVA = "0x1DEC2D0", Offset = "0x1DEAED0", VA = "0x181DEC2D0")]
		private void _InitFreeLimitGachaMap()
		{
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006129")]
		[Address(RVA = "0x1DEC410", Offset = "0x1DEB010", VA = "0x181DEC410")]
		private void _InitPoolSearchTable()
		{
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612A")]
		[Address(RVA = "0x1DEB980", Offset = "0x1DEA580", VA = "0x181DEB980")]
		public GachaPoolClientData GetGachaPool(string poolId)
		{
			return null;
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612B")]
		[Address(RVA = "0x1DEBA10", Offset = "0x1DEA610", VA = "0x181DEBA10")]
		public string GetGuaranteeName(string poolId)
		{
			return null;
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612C")]
		[Address(RVA = "0x1DEBAC0", Offset = "0x1DEA6C0", VA = "0x181DEBAC0")]
		public string GetRecruit6StarHint(string poolId)
		{
			return null;
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612D")]
		[Address(RVA = "0x1DEBC00", Offset = "0x1DEA800", VA = "0x181DEBC00")]
		public SpecialRecruitPool GetSpecialRecruitPool(int tagId)
		{
			return null;
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x0002F9A0 File Offset: 0x0002DBA0
		[Token(Token = "0x600612E")]
		[Address(RVA = "0x1DEB7F0", Offset = "0x1DEA3F0", VA = "0x181DEB7F0")]
		public static bool CheckFreeGachaLastRefresh(string inputPoolId)
		{
			return default(bool);
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612F")]
		[Address(RVA = "0x1DEBF50", Offset = "0x1DEAB50", VA = "0x181DEBF50")]
		public IEnumerator<GachaPoolClientData> GetValidPoolsEnumerator()
		{
			return null;
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006130")]
		[Address(RVA = "0x1DEBDF0", Offset = "0x1DEA9F0", VA = "0x181DEBDF0")]
		public IEnumerator<GachaData.LimitTenGachaTkt> GetValidLimitTenGachaTktEnumerator()
		{
			return null;
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006131")]
		[Address(RVA = "0x1DEBEA0", Offset = "0x1DEAAA0", VA = "0x181DEBEA0")]
		public IEnumerator<GachaData.LinkageTenGachaTkt> GetValidLinkageTenGachaTktEnumerator()
		{
			return null;
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006132")]
		[Address(RVA = "0x1DEBD40", Offset = "0x1DEA940", VA = "0x181DEBD40")]
		public IEnumerator<GachaData.NormalGachaTkt> GetValiNormalGachaTktEnumerator()
		{
			return null;
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006133")]
		[Address(RVA = "0x1DEC690", Offset = "0x1DEB290", VA = "0x181DEC690")]
		public GachaDB()
		{
		}

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<int, RecruitPool.RecruitTime> m_recruitBuildTimeMap;

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, GachaData.FreeLimitGachaData> m_freeLimitGachaMap;

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, GachaPoolClientData> m_poolMap;

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private GachaDB.TimeList<GachaPoolClientData> m_poolTimeList;

		// Token: 0x04002ABC RID: 10940
		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private GachaDB.TimeList<GachaData.LimitTenGachaTkt> m_limitTktTimeList;

		// Token: 0x04002ABD RID: 10941
		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private GachaDB.TimeList<GachaData.LinkageTenGachaTkt> m_linkageTktTimeList;

		// Token: 0x04002ABE RID: 10942
		[Token(Token = "0x4002ABE")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private GachaDB.TimeList<GachaData.NormalGachaTkt> m_normalTktTimeList;

		// Token: 0x04002ABF RID: 10943
		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_recruitBuildTimeMap;

		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitFreeLimitGachaMap;

		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitPoolSearchTable;

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetGachaPool;

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetGuaranteeName;

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetRecruit6StarHint;

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSpecialRecruitPool;

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckFreeGachaLastRefresh;

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetValidPoolsEnumerator;

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetValidLimitTenGachaTktEnumerator;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetValidLinkageTenGachaTktEnumerator;

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetValiNormalGachaTktEnumerator;

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020005C2 RID: 1474
		[Token(Token = "0x20005C2")]
		private class TimeList<Type> where Type : IGachaTimeData
		{
			// Token: 0x06006134 RID: 24884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006134")]
			public void Init(IList<Type> list)
			{
			}

			// Token: 0x06006135 RID: 24885 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
			[Token(Token = "0x6006135")]
			private static int _Comparer(Type lhs, Type rhs)
			{
				return 0;
			}

			// Token: 0x06006136 RID: 24886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006136")]
			public IEnumerator<Type> GetEnumerator(long curTs)
			{
				return null;
			}

			// Token: 0x06006137 RID: 24887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006137")]
			public TimeList()
			{
			}

			// Token: 0x04002ACD RID: 10957
			[Token(Token = "0x4002ACD")]
			[FieldOffset(Offset = "0x0")]
			private List<Type> m_timeList;
		}
	}
}
