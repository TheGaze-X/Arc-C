using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ThirdParty.PrefabPatch.Scripts
{
	// Token: 0x0200044B RID: 1099
	[Token(Token = "0x200044B")]
	public class PrefabPatchSiblingIndexRefactor : MonoBehaviour
	{
		// Token: 0x06004A14 RID: 18964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A14")]
		[Address(RVA = "0x16939C0", Offset = "0x16925C0", VA = "0x1816939C0")]
		private void Awake()
		{
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PrefabPatchSiblingIndexRefactor()
		{
		}

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _orderedGameObjects;
	}
}
