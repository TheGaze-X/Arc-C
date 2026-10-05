using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007652 RID: 30290
	[Token(Token = "0x2007652")]
	public class Act20sideCarDetailCompObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A9C1 RID: 174529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C1")]
		[Address(RVA = "0x2650E30", Offset = "0x264FA30", VA = "0x182650E30")]
		public void Render(string compId, bool notAvail = true)
		{
		}

		// Token: 0x0602A9C2 RID: 174530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C2")]
		[Address(RVA = "0x2651050", Offset = "0x264FC50", VA = "0x182651050")]
		public Act20sideCarDetailCompObj()
		{
		}

		// Token: 0x0403D5A0 RID: 251296
		[Token(Token = "0x403D5A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403D5A1 RID: 251297
		[Token(Token = "0x403D5A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403D5A2 RID: 251298
		[Token(Token = "0x403D5A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403D5A3 RID: 251299
		[Token(Token = "0x403D5A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _havePart;

		// Token: 0x0403D5A4 RID: 251300
		[Token(Token = "0x403D5A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _notHavePart;

		// Token: 0x0403D5A5 RID: 251301
		[Token(Token = "0x403D5A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0403D5A6 RID: 251302
		[Token(Token = "0x403D5A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D5A7 RID: 251303
		[Token(Token = "0x403D5A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
