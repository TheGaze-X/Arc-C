using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200723F RID: 29247
	[Token(Token = "0x200723F")]
	public class Act5D1RuneStageSelectRuneContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029716 RID: 169750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029716")]
		[Address(RVA = "0x24CD7C0", Offset = "0x24CC3C0", VA = "0x1824CD7C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029717 RID: 169751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029717")]
		[Address(RVA = "0x24CD4B0", Offset = "0x24CC0B0", VA = "0x1824CD4B0")]
		public void Render(List<RuneInfo> input)
		{
		}

		// Token: 0x06029718 RID: 169752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029718")]
		[Address(RVA = "0x24CD420", Offset = "0x24CC020", VA = "0x1824CD420")]
		public void Refresh()
		{
		}

		// Token: 0x06029719 RID: 169753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029719")]
		[Address(RVA = "0x24CD8E0", Offset = "0x24CC4E0", VA = "0x1824CD8E0")]
		public Act5D1RuneStageSelectRuneContainer()
		{
		}

		// Token: 0x0403B362 RID: 242530
		[Token(Token = "0x403B362")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIStringEvent _onClick;

		// Token: 0x0403B363 RID: 242531
		[Token(Token = "0x403B363")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403B364 RID: 242532
		[Token(Token = "0x403B364")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInit;

		// Token: 0x0403B365 RID: 242533
		[Token(Token = "0x403B365")]
		[FieldOffset(Offset = "0x30")]
		private Act5D1RuneStageSelectRuneContainer.Adapter m_adapter;

		// Token: 0x0403B366 RID: 242534
		[Token(Token = "0x403B366")]
		[FieldOffset(Offset = "0x38")]
		private List<RuneInfo> m_displayRuneList;

		// Token: 0x0403B367 RID: 242535
		[Token(Token = "0x403B367")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B368 RID: 242536
		[Token(Token = "0x403B368")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B369 RID: 242537
		[Token(Token = "0x403B369")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403B36A RID: 242538
		[Token(Token = "0x403B36A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007240 RID: 29248
		[Token(Token = "0x2007240")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17006226 RID: 25126
			// (get) Token: 0x0602971A RID: 169754 RVA: 0x000D5B70 File Offset: 0x000D3D70
			[Token(Token = "0x17006226")]
			public override int count
			{
				[Token(Token = "0x602971A")]
				[Address(RVA = "0x24D38D0", Offset = "0x24D24D0", VA = "0x1824D38D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602971B RID: 169755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602971B")]
			[Address(RVA = "0x24D3850", Offset = "0x24D2450", VA = "0x1824D3850")]
			public Adapter(Act5D1RuneStageSelectRuneContainer context)
			{
			}

			// Token: 0x0602971C RID: 169756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602971C")]
			[Address(RVA = "0x24D35A0", Offset = "0x24D21A0", VA = "0x1824D35A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B36B RID: 242539
			[Token(Token = "0x403B36B")]
			[FieldOffset(Offset = "0x20")]
			private Act5D1RuneStageSelectRuneContainer m_context;

			// Token: 0x0403B36C RID: 242540
			[Token(Token = "0x403B36C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B36D RID: 242541
			[Token(Token = "0x403B36D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B36E RID: 242542
			[Token(Token = "0x403B36E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
