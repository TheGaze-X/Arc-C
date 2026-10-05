using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ThirdParty.PrefabPatch.Scripts
{
	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	public class PrefabPatchRootOrderSwapper : MonoBehaviour
	{
		// Token: 0x06004A12 RID: 18962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A12")]
		[Address(RVA = "0x1693730", Offset = "0x1692330", VA = "0x181693730")]
		private void Awake()
		{
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PrefabPatchRootOrderSwapper()
		{
		}

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _gameObjectToSwap1;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _gameObjectToSwap2;
	}
}
