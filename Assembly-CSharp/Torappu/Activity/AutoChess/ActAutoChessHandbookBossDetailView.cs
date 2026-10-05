using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200711D RID: 28957
	[Token(Token = "0x200711D")]
	public class ActAutoChessHandbookBossDetailView : ActAutoChessHandbookDetailBaseView, IHotfixable
	{
		// Token: 0x06029221 RID: 168481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029221")]
		[Address(RVA = "0x24838D0", Offset = "0x24824D0", VA = "0x1824838D0", Slot = "8")]
		protected override void Render(ActAutoChessHandbookViewModel model)
		{
		}

		// Token: 0x06029222 RID: 168482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029222")]
		[Address(RVA = "0x24837F0", Offset = "0x24823F0", VA = "0x1824837F0")]
		public void EventOnEnemyDetailClicked()
		{
		}

		// Token: 0x06029223 RID: 168483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029223")]
		[Address(RVA = "0x2483B80", Offset = "0x2482780", VA = "0x182483B80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029224 RID: 168484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029224")]
		[Address(RVA = "0x2483CA0", Offset = "0x24828A0", VA = "0x182483CA0")]
		public ActAutoChessHandbookBossDetailView()
		{
		}

		// Token: 0x0403ABCD RID: 240589
		[Token(Token = "0x403ABCD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403ABCE RID: 240590
		[Token(Token = "0x403ABCE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403ABCF RID: 240591
		[Token(Token = "0x403ABCF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403ABD0 RID: 240592
		[Token(Token = "0x403ABD0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403ABD1 RID: 240593
		[Token(Token = "0x403ABD1")]
		[FieldOffset(Offset = "0x60")]
		private ActAutoChessHandbookBossDetailView.Adapter m_adapter;

		// Token: 0x0403ABD2 RID: 240594
		[Token(Token = "0x403ABD2")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403ABD3 RID: 240595
		[Token(Token = "0x403ABD3")]
		[FieldOffset(Offset = "0x70")]
		private List<EnemyHandBookEverViewModel> m_cachedList;

		// Token: 0x0403ABD4 RID: 240596
		[Token(Token = "0x403ABD4")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403ABD5 RID: 240597
		[Token(Token = "0x403ABD5")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedId;

		// Token: 0x0403ABD6 RID: 240598
		[Token(Token = "0x403ABD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ABD7 RID: 240599
		[Token(Token = "0x403ABD7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnEnemyDetailClicked;

		// Token: 0x0403ABD8 RID: 240600
		[Token(Token = "0x403ABD8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403ABD9 RID: 240601
		[Token(Token = "0x403ABD9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200711E RID: 28958
		[Token(Token = "0x200711E")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06029225 RID: 168485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029225")]
			[Address(RVA = "0x248F760", Offset = "0x248E360", VA = "0x18248F760")]
			public Adapter(ActAutoChessHandbookBossDetailView closure)
			{
			}

			// Token: 0x17006167 RID: 24935
			// (get) Token: 0x06029226 RID: 168486 RVA: 0x000D4940 File Offset: 0x000D2B40
			[Token(Token = "0x17006167")]
			public override int count
			{
				[Token(Token = "0x6029226")]
				[Address(RVA = "0x248F7E0", Offset = "0x248E3E0", VA = "0x18248F7E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029227 RID: 168487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029227")]
			[Address(RVA = "0x248F5E0", Offset = "0x248E1E0", VA = "0x18248F5E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403ABDA RID: 240602
			[Token(Token = "0x403ABDA")]
			[FieldOffset(Offset = "0x20")]
			private ActAutoChessHandbookBossDetailView m_closure;

			// Token: 0x0403ABDB RID: 240603
			[Token(Token = "0x403ABDB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403ABDC RID: 240604
			[Token(Token = "0x403ABDC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403ABDD RID: 240605
			[Token(Token = "0x403ABDD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
