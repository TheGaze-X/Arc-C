using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Mock
{
	// Token: 0x02002682 RID: 9858
	[Token(Token = "0x2002682")]
	public class MockCharacterLocator : MonoBehaviour
	{
		// Token: 0x0601019E RID: 65950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601019E")]
		[Address(RVA = "0x7CD620", Offset = "0x7CC220", VA = "0x1807CD620")]
		private void Update()
		{
		}

		// Token: 0x0601019F RID: 65951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601019F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MockCharacterLocator()
		{
		}

		// Token: 0x04011EDD RID: 73437
		[Token(Token = "0x4011EDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BattleCharacterData _mockCharacterData;
	}
}
