using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Gacha
{
	// Token: 0x02001664 RID: 5732
	[Token(Token = "0x2001664")]
	public class PanelItemInfo : MonoBehaviour
	{
		// Token: 0x0600820A RID: 33290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820A")]
		[Address(RVA = "0x2B0A2E0", Offset = "0x2B08EE0", VA = "0x182B0A2E0")]
		public void ApplyData(string itemId, int itemCount, bool isNew)
		{
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PanelItemInfo()
		{
		}

		// Token: 0x0400841D RID: 33821
		[Token(Token = "0x400841D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0400841E RID: 33822
		[Token(Token = "0x400841E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0400841F RID: 33823
		[Token(Token = "0x400841F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x04008420 RID: 33824
		[Token(Token = "0x4008420")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _getType;
	}
}
