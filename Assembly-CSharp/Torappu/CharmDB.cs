using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B3 RID: 1459
	[Token(Token = "0x20005B3")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CharmTable")]
	[Serializable]
	public class CharmDB : ConstTable<CharmData, CharmDB>
	{
		// Token: 0x060060D2 RID: 24786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D2")]
		[Address(RVA = "0x1CEAD90", Offset = "0x1CE9990", VA = "0x181CEAD90", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D3")]
		[Address(RVA = "0x1CEACB0", Offset = "0x1CE98B0", VA = "0x181CEACB0")]
		public CharmItemData GetCharmDataById(string id)
		{
			return null;
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D4")]
		[Address(RVA = "0x1CEAF00", Offset = "0x1CE9B00", VA = "0x181CEAF00")]
		public CharmDB()
		{
		}

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, CharmItemData> m_charmDic;

		// Token: 0x04002A53 RID: 10835
		[Token(Token = "0x4002A53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A54 RID: 10836
		[Token(Token = "0x4002A54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCharmDataById;

		// Token: 0x04002A55 RID: 10837
		[Token(Token = "0x4002A55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
