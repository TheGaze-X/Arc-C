using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Torappu.Battle.UI
{
	// Token: 0x0200332A RID: 13098
	[Token(Token = "0x200332A")]
	[RequireComponent(typeof(Collider2D))]
	public class UILegacyMouseUpListener : MonoBehaviour
	{
		// Token: 0x06014D81 RID: 85377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D81")]
		[Address(RVA = "0xD4BB10", Offset = "0xD4A710", VA = "0x180D4BB10")]
		private void OnMouseUpAsButton()
		{
		}

		// Token: 0x06014D82 RID: 85378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D82")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UILegacyMouseUpListener()
		{
		}

		// Token: 0x04018C81 RID: 101505
		[Token(Token = "0x4018C81")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent onMouseUp;
	}
}
