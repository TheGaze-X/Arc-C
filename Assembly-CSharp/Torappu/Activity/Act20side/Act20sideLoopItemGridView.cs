using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007687 RID: 30343
	[Token(Token = "0x2007687")]
	public class Act20sideLoopItemGridView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AAE1 RID: 174817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAE1")]
		[Address(RVA = "0x2676750", Offset = "0x2675350", VA = "0x182676750")]
		public void Render(bool isBlue, Sprite itemImg)
		{
		}

		// Token: 0x0602AAE2 RID: 174818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAE2")]
		[Address(RVA = "0x26768C0", Offset = "0x26754C0", VA = "0x1826768C0")]
		public Act20sideLoopItemGridView()
		{
		}

		// Token: 0x0403D7D4 RID: 251860
		[Token(Token = "0x403D7D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _gridBlueBg;

		// Token: 0x0403D7D5 RID: 251861
		[Token(Token = "0x403D7D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _gridGreyBg;

		// Token: 0x0403D7D6 RID: 251862
		[Token(Token = "0x403D7D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403D7D7 RID: 251863
		[Token(Token = "0x403D7D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D7D8 RID: 251864
		[Token(Token = "0x403D7D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
