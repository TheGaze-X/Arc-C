using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public class GameObjectArrayCountControl : MonoBehaviour
	{
		// Token: 0x06005AD5 RID: 23253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0x1AF0940", Offset = "0x1AEF540", VA = "0x181AF0940")]
		public void Setup(int count)
		{
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public GameObjectArrayCountControl()
		{
		}

		// Token: 0x0400209E RID: 8350
		[Token(Token = "0x400209E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _gameObjectArray;
	}
}
