using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x0200289C RID: 10396
	[Token(Token = "0x200289C")]
	public class BattleDebugController : MonoBehaviour
	{
		// Token: 0x060114CB RID: 70859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114CB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleDebugController()
		{
		}

		// Token: 0x0401352C RID: 79148
		[Token(Token = "0x401352C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _debugPanelPrefab;
	}
}
