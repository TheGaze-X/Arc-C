using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.BP
{
	// Token: 0x02001AC3 RID: 6851
	[Token(Token = "0x2001AC3")]
	public class BStationViewForProgressRoom : MonoBehaviour
	{
		// Token: 0x0600AD0C RID: 44300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0C")]
		[Address(RVA = "0x3277FD0", Offset = "0x3276BD0", VA = "0x183277FD0")]
		public void Render(BStationInfoModel infoModel)
		{
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0D")]
		[Address(RVA = "0x3278100", Offset = "0x3276D00", VA = "0x183278100")]
		private void _ChooseText(string text, Text enabled, Text disabled)
		{
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BStationViewForProgressRoom()
		{
		}

		// Token: 0x0400A545 RID: 42309
		[Token(Token = "0x400A545")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textNumber;

		// Token: 0x0400A546 RID: 42310
		[Token(Token = "0x400A546")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("When some special numbers encountered, show this hilight number")]
		private Text _textHilightNumber;

		// Token: 0x0400A547 RID: 42311
		[Token(Token = "0x400A547")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLimit;

		// Token: 0x0400A548 RID: 42312
		[Token(Token = "0x400A548")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _iconCharTired;

		// Token: 0x0400A549 RID: 42313
		[Token(Token = "0x400A549")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _iconCharNormal;
	}
}
