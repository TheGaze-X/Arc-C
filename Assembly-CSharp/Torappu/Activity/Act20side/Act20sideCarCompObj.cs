using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200764D RID: 30285
	[Token(Token = "0x200764D")]
	public class Act20sideCarCompObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006433 RID: 25651
		// (get) Token: 0x0602A9AF RID: 174511 RVA: 0x000D93C8 File Offset: 0x000D75C8
		[Token(Token = "0x17006433")]
		public CartComponents.CartAccessoryPos pos
		{
			[Token(Token = "0x602A9AF")]
			[Address(RVA = "0x2650DD0", Offset = "0x264F9D0", VA = "0x182650DD0")]
			get
			{
				return CartComponents.CartAccessoryPos.NONE;
			}
		}

		// Token: 0x0602A9B0 RID: 174512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B0")]
		[Address(RVA = "0x2650C40", Offset = "0x264F840", VA = "0x182650C40")]
		public void OnRender(CartCompViewModel viewModel)
		{
		}

		// Token: 0x0602A9B1 RID: 174513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B1")]
		[Address(RVA = "0x2650D70", Offset = "0x264F970", VA = "0x182650D70")]
		public Act20sideCarCompObj()
		{
		}

		// Token: 0x0403D57F RID: 251263
		[Token(Token = "0x403D57F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _equipName;

		// Token: 0x0403D580 RID: 251264
		[Token(Token = "0x403D580")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CartComponents.CartAccessoryPos _pos;

		// Token: 0x0403D581 RID: 251265
		[Token(Token = "0x403D581")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconSprite;

		// Token: 0x0403D582 RID: 251266
		[Token(Token = "0x403D582")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyState;

		// Token: 0x0403D583 RID: 251267
		[Token(Token = "0x403D583")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _unEmptyState;

		// Token: 0x0403D584 RID: 251268
		[Token(Token = "0x403D584")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pos;

		// Token: 0x0403D585 RID: 251269
		[Token(Token = "0x403D585")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403D586 RID: 251270
		[Token(Token = "0x403D586")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
