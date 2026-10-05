using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002670 RID: 9840
	[Token(Token = "0x2002670")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/BuffTemplateTable")]
	[Serializable]
	public class BuffTemplateDB : SimpleKVTable<BuffTemplateDBData, BuffTemplateDB>
	{
		// Token: 0x06010173 RID: 65907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010173")]
		[Address(RVA = "0x7C2980", Offset = "0x7C1580", VA = "0x1807C2980")]
		public BuffTemplateDB()
		{
		}

		// Token: 0x04011E5E RID: 73310
		[Token(Token = "0x4011E5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
