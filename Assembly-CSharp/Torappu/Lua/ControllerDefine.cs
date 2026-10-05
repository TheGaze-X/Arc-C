using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Lua
{
	// Token: 0x0200160A RID: 5642
	[Token(Token = "0x200160A")]
	[Serializable]
	public class ControllerDefine
	{
		// Token: 0x0600800E RID: 32782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ControllerDefine()
		{
		}

		// Token: 0x04008178 RID: 33144
		[Token(Token = "0x4008178")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04008179 RID: 33145
		[Token(Token = "0x4008179")]
		[FieldOffset(Offset = "0x18")]
		public UnityEngine.Object ctrl;
	}
}
