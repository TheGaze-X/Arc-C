using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B51 RID: 6993
	[Token(Token = "0x2001B51")]
	public class UIArchitectureFurnitureItemView : MonoBehaviour
	{
		// Token: 0x0600AFA8 RID: 44968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA8")]
		[Address(RVA = "0x32B5F90", Offset = "0x32B4B90", VA = "0x1832B5F90")]
		public void Setup(NewFurnitureItemModel arg)
		{
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIArchitectureFurnitureItemView()
		{
		}

		// Token: 0x0400A991 RID: 43409
		[Token(Token = "0x400A991")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400A992 RID: 43410
		[Token(Token = "0x400A992")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFurnitureIconSpriteHub _spriteHub;
	}
}
