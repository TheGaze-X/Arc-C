using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB.Test
{
	// Token: 0x020016BC RID: 5820
	[Token(Token = "0x20016BC")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/SkillTable")]
	[Serializable]
	public class SkillTable : LRUKVTable<SkillData, SkillTable>
	{
		// Token: 0x06009334 RID: 37684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009334")]
		[Address(RVA = "0x2B3B830", Offset = "0x2B3A430", VA = "0x182B3B830")]
		private SkillTable()
		{
		}

		// Token: 0x040088EC RID: 35052
		[Token(Token = "0x40088EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
