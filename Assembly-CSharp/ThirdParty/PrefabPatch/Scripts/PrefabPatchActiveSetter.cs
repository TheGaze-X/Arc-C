using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ThirdParty.PrefabPatch.Scripts
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	public class PrefabPatchActiveSetter : MonoBehaviour
	{
		// Token: 0x06004A10 RID: 18960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A10")]
		[Address(RVA = "0x1693550", Offset = "0x1692150", VA = "0x181693550")]
		private void Awake()
		{
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A11")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PrefabPatchActiveSetter()
		{
		}

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _activeList;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _inActiveList;
	}
}
