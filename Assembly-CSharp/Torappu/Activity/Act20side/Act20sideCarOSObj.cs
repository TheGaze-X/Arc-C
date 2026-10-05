using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007658 RID: 30296
	[Token(Token = "0x2007658")]
	public class Act20sideCarOSObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A9D9 RID: 174553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D9")]
		[Address(RVA = "0x2651D30", Offset = "0x2650930", VA = "0x182651D30")]
		public void Render(Dictionary<CartComponents.CartAccessoryPos, CartCompViewModel> carComps, CartComponents.CartAccessoryPos pos)
		{
		}

		// Token: 0x0602A9DA RID: 174554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9DA")]
		[Address(RVA = "0x2651FB0", Offset = "0x2650BB0", VA = "0x182651FB0")]
		public Act20sideCarOSObj()
		{
		}

		// Token: 0x0403D5E7 RID: 251367
		[Token(Token = "0x403D5E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _osState;

		// Token: 0x0403D5E8 RID: 251368
		[Token(Token = "0x403D5E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _pos1;

		// Token: 0x0403D5E9 RID: 251369
		[Token(Token = "0x403D5E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _pos2;

		// Token: 0x0403D5EA RID: 251370
		[Token(Token = "0x403D5EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _os1Image;

		// Token: 0x0403D5EB RID: 251371
		[Token(Token = "0x403D5EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _os2Image;

		// Token: 0x0403D5EC RID: 251372
		[Token(Token = "0x403D5EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _noOs1;

		// Token: 0x0403D5ED RID: 251373
		[Token(Token = "0x403D5ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _noOs2;

		// Token: 0x0403D5EE RID: 251374
		[Token(Token = "0x403D5EE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _selectedFrame1;

		// Token: 0x0403D5EF RID: 251375
		[Token(Token = "0x403D5EF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _selectedFrame2;

		// Token: 0x0403D5F0 RID: 251376
		[Token(Token = "0x403D5F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D5F1 RID: 251377
		[Token(Token = "0x403D5F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
