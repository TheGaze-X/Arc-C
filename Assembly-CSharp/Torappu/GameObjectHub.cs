using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	public class GameObjectHub : MonoBehaviour
	{
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9C")]
		public GameObject[] gameObjects
		{
			[Token(Token = "0x6005ADD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public GameObjectHub()
		{
		}

		// Token: 0x040020A6 RID: 8358
		[Token(Token = "0x40020A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _objects;
	}
}
