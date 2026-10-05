using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Legion;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002674 RID: 9844
	[Token(Token = "0x2002674")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/LegionModeBuffTable")]
	[Serializable]
	public class LegionModeBuffDB : SimpleKVTable<LegionModeBuffData, LegionModeBuffDB>
	{
		// Token: 0x0601018A RID: 65930 RVA: 0x00062400 File Offset: 0x00060600
		[Token(Token = "0x601018A")]
		[Address(RVA = "0x7C7A90", Offset = "0x7C6690", VA = "0x1807C7A90")]
		public static bool GetData(string key, out LegionModeProfessionBuffDetail data)
		{
			return default(bool);
		}

		// Token: 0x0601018B RID: 65931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601018B")]
		[Address(RVA = "0x7C7B40", Offset = "0x7C6740", VA = "0x1807C7B40")]
		public void LoadIfNot(Dictionary<string, int> dataPartDict)
		{
		}

		// Token: 0x0601018C RID: 65932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601018C")]
		[Address(RVA = "0x7C81D0", Offset = "0x7C6DD0", VA = "0x1807C81D0", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601018D RID: 65933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601018D")]
		[Address(RVA = "0x7C8240", Offset = "0x7C6E40", VA = "0x1807C8240")]
		public LegionModeBuffDB()
		{
		}

		// Token: 0x04011E76 RID: 73334
		[Token(Token = "0x4011E76")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, LegionModeProfessionBuffDetail> m_professionBuffDetails;

		// Token: 0x04011E77 RID: 73335
		[Token(Token = "0x4011E77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x04011E78 RID: 73336
		[Token(Token = "0x4011E78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadIfNot;

		// Token: 0x04011E79 RID: 73337
		[Token(Token = "0x4011E79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011E7A RID: 73338
		[Token(Token = "0x4011E7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
