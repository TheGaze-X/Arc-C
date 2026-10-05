using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200286E RID: 10350
	[Token(Token = "0x200286E")]
	[Serializable]
	public class ParamListForGraph
	{
		// Token: 0x06011378 RID: 70520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011378")]
		[Address(RVA = "0x922960", Offset = "0x921560", VA = "0x180922960")]
		private void _AddParam()
		{
		}

		// Token: 0x06011379 RID: 70521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011379")]
		[Address(RVA = "0x922A30", Offset = "0x921630", VA = "0x180922A30")]
		public ParamListForGraph()
		{
		}

		// Token: 0x0401346D RID: 78957
		[Token(Token = "0x401346D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<ParamKeyValue> value;
	}
}
