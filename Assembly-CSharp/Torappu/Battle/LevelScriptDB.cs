using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002675 RID: 9845
	[Token(Token = "0x2002675")]
	[CreateAssetMenu(fileName = "level_script_db", menuName = "Torappu/DB/Table/LevelScriptTable")]
	[Serializable]
	public class LevelScriptDB : ConstTable<LevelScriptDataMap, LevelScriptDB>
	{
		// Token: 0x0601018E RID: 65934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601018E")]
		[Address(RVA = "0x7C82B0", Offset = "0x7C6EB0", VA = "0x1807C82B0")]
		public LevelScriptDB()
		{
		}

		// Token: 0x04011E7B RID: 73339
		[Token(Token = "0x4011E7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
