using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200766D RID: 30317
	[Token(Token = "0x200766D")]
	public class Act20sideCollectionState : PopupFadeState
	{
		// Token: 0x0602AA4C RID: 174668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA4C")]
		[Address(RVA = "0x2670750", Offset = "0x266F350", VA = "0x182670750", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA4D RID: 174669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA4D")]
		[Address(RVA = "0x26706F0", Offset = "0x266F2F0", VA = "0x1826706F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA4E RID: 174670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA4E")]
		[Address(RVA = "0x2670B50", Offset = "0x266F750", VA = "0x182670B50")]
		private void _OnCompItemClicked(string compId)
		{
		}

		// Token: 0x0602AA4F RID: 174671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA4F")]
		[Address(RVA = "0x26709D0", Offset = "0x266F5D0", VA = "0x1826709D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA50 RID: 174672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA50")]
		[Address(RVA = "0x2670CD0", Offset = "0x266F8D0", VA = "0x182670CD0")]
		public Act20sideCollectionState()
		{
		}

		// Token: 0x0602AA51 RID: 174673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA51")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403D6A7 RID: 251559
		[Token(Token = "0x403D6A7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403D6A8 RID: 251560
		[Token(Token = "0x403D6A8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act20sideCollectionView _view;

		// Token: 0x0403D6A9 RID: 251561
		[Token(Token = "0x403D6A9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403D6AA RID: 251562
		[Token(Token = "0x403D6AA")]
		[FieldOffset(Offset = "0x88")]
		private Act20sideCollectionStateBean m_stateBean;

		// Token: 0x0403D6AB RID: 251563
		[Token(Token = "0x403D6AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D6AC RID: 251564
		[Token(Token = "0x403D6AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D6AD RID: 251565
		[Token(Token = "0x403D6AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnCompItemClicked;

		// Token: 0x0403D6AE RID: 251566
		[Token(Token = "0x403D6AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D6AF RID: 251567
		[Token(Token = "0x403D6AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
