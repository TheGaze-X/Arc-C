using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Hire;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DFE RID: 7678
	[Token(Token = "0x2001DFE")]
	public class BuildingHireRefreshCountView : MonoBehaviour
	{
		// Token: 0x0600BD96 RID: 48534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD96")]
		[Address(RVA = "0x33B05E0", Offset = "0x33AF1E0", VA = "0x1833B05E0")]
		public void Render(HiringSnapshot snapshot)
		{
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x000464A0 File Offset: 0x000446A0
		[Token(Token = "0x600BD97")]
		[Address(RVA = "0x33B0810", Offset = "0x33AF410", VA = "0x1833B0810")]
		private Color _PickColor(HiringSnapshot snapshot, Color halfColor, Color fullColor)
		{
			return default(Color);
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD98")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingHireRefreshCountView()
		{
		}

		// Token: 0x0400BE22 RID: 48674
		[Token(Token = "0x400BE22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0400BE23 RID: 48675
		[Token(Token = "0x400BE23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BE24 RID: 48676
		[Token(Token = "0x400BE24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLimit;

		// Token: 0x0400BE25 RID: 48677
		[Token(Token = "0x400BE25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorBkgFull;

		// Token: 0x0400BE26 RID: 48678
		[Token(Token = "0x400BE26")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorBkgHalf;

		// Token: 0x0400BE27 RID: 48679
		[Token(Token = "0x400BE27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorTextFull;

		// Token: 0x0400BE28 RID: 48680
		[Token(Token = "0x400BE28")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorTextHalf;
	}
}
