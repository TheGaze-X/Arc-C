using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x020017EE RID: 6126
	[Token(Token = "0x20017EE")]
	public struct FurnitureLodObj
	{
		// Token: 0x04009115 RID: 37141
		[Token(Token = "0x4009115")]
		[FieldOffset(Offset = "0x0")]
		public GameObject obj;

		// Token: 0x04009116 RID: 37142
		[Token(Token = "0x4009116")]
		[FieldOffset(Offset = "0x8")]
		public FurnitureLodObjType type;

		// Token: 0x04009117 RID: 37143
		[Token(Token = "0x4009117")]
		[FieldOffset(Offset = "0xC")]
		public int vertexCount;

		// Token: 0x04009118 RID: 37144
		[Token(Token = "0x4009118")]
		[FieldOffset(Offset = "0x10")]
		public bool hasAlphaBlend;
	}
}
