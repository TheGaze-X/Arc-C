using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200723D RID: 29245
	[Token(Token = "0x200723D")]
	public class Act5D1RuneStageRuneContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602970B RID: 169739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602970B")]
		[Address(RVA = "0x24CD260", Offset = "0x24CBE60", VA = "0x1824CD260")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602970C RID: 169740 RVA: 0x000D5B40 File Offset: 0x000D3D40
		[Token(Token = "0x602970C")]
		[Address(RVA = "0x24CD210", Offset = "0x24CBE10", VA = "0x1824CD210")]
		private static RuneClassify _GetDefaultClassRune()
		{
			return RuneClassify.ALL;
		}

		// Token: 0x0602970D RID: 169741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602970D")]
		[Address(RVA = "0x24CCF00", Offset = "0x24CBB00", VA = "0x1824CCF00")]
		public void Render(List<RuneInfo> input)
		{
		}

		// Token: 0x0602970E RID: 169742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602970E")]
		[Address(RVA = "0x24CCFE0", Offset = "0x24CBBE0", VA = "0x1824CCFE0")]
		public void SetAll()
		{
		}

		// Token: 0x0602970F RID: 169743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602970F")]
		[Address(RVA = "0x24CD0A0", Offset = "0x24CBCA0", VA = "0x1824CD0A0")]
		public void SetNewHand()
		{
		}

		// Token: 0x06029710 RID: 169744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029710")]
		[Address(RVA = "0x24CD040", Offset = "0x24CBC40", VA = "0x1824CD040")]
		public void SetDanger()
		{
		}

		// Token: 0x06029711 RID: 169745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029711")]
		[Address(RVA = "0x24CD100", Offset = "0x24CBD00", VA = "0x1824CD100")]
		public void SetType(RuneClassify classify)
		{
		}

		// Token: 0x06029712 RID: 169746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029712")]
		[Address(RVA = "0x24CD3C0", Offset = "0x24CBFC0", VA = "0x1824CD3C0")]
		public Act5D1RuneStageRuneContainer()
		{
		}

		// Token: 0x0403B34D RID: 242509
		[Token(Token = "0x403B34D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIStringEvent _onClick;

		// Token: 0x0403B34E RID: 242510
		[Token(Token = "0x403B34E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403B34F RID: 242511
		[Token(Token = "0x403B34F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateFadeSwitcher _allToggle;

		// Token: 0x0403B350 RID: 242512
		[Token(Token = "0x403B350")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateFadeSwitcher _dangerToggle;

		// Token: 0x0403B351 RID: 242513
		[Token(Token = "0x403B351")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateFadeSwitcher _newHandToggle;

		// Token: 0x0403B352 RID: 242514
		[Token(Token = "0x403B352")]
		[FieldOffset(Offset = "0x40")]
		private Act5D1RuneStageRuneContainer.Adapter m_adapter;

		// Token: 0x0403B353 RID: 242515
		[Token(Token = "0x403B353")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInit;

		// Token: 0x0403B354 RID: 242516
		[Token(Token = "0x403B354")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B355 RID: 242517
		[Token(Token = "0x403B355")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetDefaultClassRune;

		// Token: 0x0403B356 RID: 242518
		[Token(Token = "0x403B356")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B357 RID: 242519
		[Token(Token = "0x403B357")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetAll;

		// Token: 0x0403B358 RID: 242520
		[Token(Token = "0x403B358")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetNewHand;

		// Token: 0x0403B359 RID: 242521
		[Token(Token = "0x403B359")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetDanger;

		// Token: 0x0403B35A RID: 242522
		[Token(Token = "0x403B35A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetType;

		// Token: 0x0403B35B RID: 242523
		[Token(Token = "0x403B35B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200723E RID: 29246
		[Token(Token = "0x200723E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17006225 RID: 25125
			// (get) Token: 0x06029713 RID: 169747 RVA: 0x000D5B58 File Offset: 0x000D3D58
			[Token(Token = "0x17006225")]
			public override int count
			{
				[Token(Token = "0x6029713")]
				[Address(RVA = "0x24D39C0", Offset = "0x24D25C0", VA = "0x1824D39C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029714 RID: 169748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029714")]
			[Address(RVA = "0x24D3750", Offset = "0x24D2350", VA = "0x1824D3750")]
			public Adapter()
			{
			}

			// Token: 0x06029715 RID: 169749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029715")]
			[Address(RVA = "0x24D3070", Offset = "0x24D1C70", VA = "0x1824D3070", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B35C RID: 242524
			[Token(Token = "0x403B35C")]
			[FieldOffset(Offset = "0x20")]
			public RuneClassify classify;

			// Token: 0x0403B35D RID: 242525
			[Token(Token = "0x403B35D")]
			[FieldOffset(Offset = "0x28")]
			public List<RuneInfo> infoList;

			// Token: 0x0403B35E RID: 242526
			[Token(Token = "0x403B35E")]
			[FieldOffset(Offset = "0x30")]
			public UIStringEvent onClickEvent;

			// Token: 0x0403B35F RID: 242527
			[Token(Token = "0x403B35F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B360 RID: 242528
			[Token(Token = "0x403B360")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B361 RID: 242529
			[Token(Token = "0x403B361")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
