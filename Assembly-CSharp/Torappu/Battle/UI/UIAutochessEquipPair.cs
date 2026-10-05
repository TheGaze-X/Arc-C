using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032A1 RID: 12961
	[Token(Token = "0x20032A1")]
	public class UIAutochessEquipPair : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014973 RID: 84339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014973")]
		[Address(RVA = "0xCD89B0", Offset = "0xCD75B0", VA = "0x180CD89B0")]
		public void UpdateLayout(string equipName, string equipDescription, Sprite icon)
		{
		}

		// Token: 0x06014974 RID: 84340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014974")]
		[Address(RVA = "0xCD8AE0", Offset = "0xCD76E0", VA = "0x180CD8AE0")]
		public UIAutochessEquipPair()
		{
		}

		// Token: 0x040185D5 RID: 99797
		[Token(Token = "0x40185D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _equipName;

		// Token: 0x040185D6 RID: 99798
		[Token(Token = "0x40185D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _equipDescription;

		// Token: 0x040185D7 RID: 99799
		[Token(Token = "0x40185D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _equipIcon;

		// Token: 0x040185D8 RID: 99800
		[Token(Token = "0x40185D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CancelDragIfFits _cancelDragIfFits;

		// Token: 0x040185D9 RID: 99801
		[Token(Token = "0x40185D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLayout;

		// Token: 0x040185DA RID: 99802
		[Token(Token = "0x40185DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
