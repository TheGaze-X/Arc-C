using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x02001894 RID: 6292
	[Token(Token = "0x2001894")]
	public class FurnitureControllerHolder : MonoBehaviour
	{
		// Token: 0x06009F11 RID: 40721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F11")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FurnitureControllerHolder()
		{
		}

		// Token: 0x040095AB RID: 38315
		[Token(Token = "0x40095AB")]
		[FieldOffset(Offset = "0x18")]
		public DIYRoom.IFurnitureController furnitureController;
	}
}
