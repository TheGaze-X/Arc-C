using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x20005CF")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/RangeTable")]
	[Serializable]
	public class RangeDB : SimpleKVTable<RangeData, RangeDB>
	{
		// Token: 0x06006162 RID: 24930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006162")]
		[Address(RVA = "0x1DF0AD0", Offset = "0x1DEF6D0", VA = "0x181DF0AD0", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006163")]
		[Address(RVA = "0x1DF0C60", Offset = "0x1DEF860", VA = "0x181DF0C60")]
		public RangeDB()
		{
		}

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
