using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004084 RID: 16516
	[Token(Token = "0x2004084")]
	public class SandboxV2CookDrinkItemLoopAdapter : LoopScrollAdapter<SandboxV2CookDrinkItemLoopAdapter.ViewHolder, SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel>
	{
		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x060198C5 RID: 104645 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198C6 RID: 104646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF1")]
		public Func<int, int, bool> itemSelectEvent
		{
			[Token(Token = "0x60198C5")]
			[Address(RVA = "0x124E240", Offset = "0x124CE40", VA = "0x18124E240")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198C6")]
			[Address(RVA = "0x124E2A0", Offset = "0x124CEA0", VA = "0x18124E2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060198C7 RID: 104647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60198C7")]
		[Address(RVA = "0x124DB60", Offset = "0x124C760", VA = "0x18124DB60", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060198C8 RID: 104648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198C8")]
		[Address(RVA = "0x124DC40", Offset = "0x124C840", VA = "0x18124DC40", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2CookDrinkItemLoopAdapter.ViewHolder holder, SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel data)
		{
		}

		// Token: 0x060198C9 RID: 104649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198C9")]
		[Address(RVA = "0x124E050", Offset = "0x124CC50", VA = "0x18124E050")]
		private void _TutorialOnly_TryRegisterAVGFirstItem(SandboxV2CookDrinkItemView view)
		{
		}

		// Token: 0x060198CA RID: 104650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198CA")]
		[Address(RVA = "0x124E1D0", Offset = "0x124CDD0", VA = "0x18124E1D0")]
		public SandboxV2CookDrinkItemLoopAdapter()
		{
		}

		// Token: 0x0401FDE2 RID: 130530
		[Token(Token = "0x401FDE2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2CookDrinkItemView _itemViewPrefab;

		// Token: 0x0401FDE4 RID: 130532
		[Token(Token = "0x401FDE4")]
		[FieldOffset(Offset = "0x68")]
		private bool m_tutorialIsFirstItemRegistered;

		// Token: 0x0401FDE5 RID: 130533
		[Token(Token = "0x401FDE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x0401FDE6 RID: 130534
		[Token(Token = "0x401FDE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x0401FDE7 RID: 130535
		[Token(Token = "0x401FDE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401FDE8 RID: 130536
		[Token(Token = "0x401FDE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401FDE9 RID: 130537
		[Token(Token = "0x401FDE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRegisterAVGFirstItem;

		// Token: 0x0401FDEA RID: 130538
		[Token(Token = "0x401FDEA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004085 RID: 16517
		[Token(Token = "0x2004085")]
		public class ViewHolder
		{
			// Token: 0x060198CB RID: 104651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198CB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401FDEB RID: 130539
			[Token(Token = "0x401FDEB")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2CookDrinkItemView view;
		}
	}
}
