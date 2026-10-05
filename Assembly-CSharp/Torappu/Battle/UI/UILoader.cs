using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x0200332F RID: 13103
	[Token(Token = "0x200332F")]
	public class UILoader : MonoBehaviour
	{
		// Token: 0x06014E3C RID: 85564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E3C")]
		[Address(RVA = "0xD5FD70", Offset = "0xD5E970", VA = "0x180D5FD70")]
		public void Awake()
		{
		}

		// Token: 0x06014E3D RID: 85565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E3D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UILoader()
		{
		}

		// Token: 0x04018D9A RID: 101786
		[Token(Token = "0x4018D9A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIController _uiPrefab;
	}
}
