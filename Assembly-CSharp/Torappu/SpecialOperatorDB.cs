using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/SpecialOperatorTable")]
	[Serializable]
	public class SpecialOperatorDB : ConstTable<SpecialOperatorTable, SpecialOperatorDB>
	{
		// Token: 0x0600619D RID: 24989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619D")]
		[Address(RVA = "0x1DF7490", Offset = "0x1DF6090", VA = "0x181DF7490", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619E")]
		[Address(RVA = "0x1DF7400", Offset = "0x1DF6000", VA = "0x181DF7400")]
		public string GetUniequipNodeId(string uniEquipId)
		{
			return null;
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619F")]
		[Address(RVA = "0x1DF77E0", Offset = "0x1DF63E0", VA = "0x181DF77E0")]
		public SpecialOperatorDB()
		{
		}

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		private const int UNIEQUIP_DEFAULT_LEVEL = 1;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, string> m_uniequipNodeMap;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetUniequipNodeId;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
