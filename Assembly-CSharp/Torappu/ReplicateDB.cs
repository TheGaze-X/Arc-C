using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ReplicateTable")]
	[Serializable]
	public class ReplicateDB : SimpleKVTable<ReplicateTable, ReplicateDB>
	{
		// Token: 0x06006164 RID: 24932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006164")]
		[Address(RVA = "0x1DF0CD0", Offset = "0x1DEF8D0", VA = "0x181DF0CD0")]
		public ReplicateDB()
		{
		}

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
