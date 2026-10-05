using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007117 RID: 28951
	[Token(Token = "0x2007117")]
	public abstract class ActAutoChessHandbookGroupBaseView<TItemView, TItemModel, TViewModel> : UISimpleRecycleLayoutItemView<TViewModel>, IHotfixable where TItemView : ActAutoChessHandbookItemBaseView<TItemModel> where TItemModel : ActAutoChessHandbookItemModelBase where TViewModel : ActAutoChessHandbookGroupModelBase<TItemModel>
	{
		// Token: 0x06029210 RID: 168464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029210")]
		protected override void OnRender(TViewModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06029211 RID: 168465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029211")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029212 RID: 168466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029212")]
		protected ActAutoChessHandbookGroupBaseView()
		{
		}

		// Token: 0x0403ABB0 RID: 240560
		[Token(Token = "0x403ABB0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403ABB1 RID: 240561
		[Token(Token = "0x403ABB1")]
		[FieldOffset(Offset = "0x0")]
		private bool m_hasInited;

		// Token: 0x0403ABB2 RID: 240562
		[Token(Token = "0x403ABB2")]
		[FieldOffset(Offset = "0x0")]
		private ActAutoChessHandbookGroupBaseView<TItemView, TItemModel, TViewModel>.Adapter m_adapter;

		// Token: 0x0403ABB3 RID: 240563
		[Token(Token = "0x403ABB3")]
		[FieldOffset(Offset = "0x0")]
		private List<TItemModel> m_cachedModelList;

		// Token: 0x0403ABB4 RID: 240564
		[Token(Token = "0x403ABB4")]
		[FieldOffset(Offset = "0x0")]
		private string m_selectedItemId;

		// Token: 0x0403ABB5 RID: 240565
		[Token(Token = "0x403ABB5")]
		[FieldOffset(Offset = "0x0")]
		private bool m_cachedFastMode;

		// Token: 0x0403ABB6 RID: 240566
		[Token(Token = "0x403ABB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403ABB7 RID: 240567
		[Token(Token = "0x403ABB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403ABB8 RID: 240568
		[Token(Token = "0x403ABB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007118 RID: 28952
		[Token(Token = "0x2007118")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06029213 RID: 168467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029213")]
			public Adapter(ActAutoChessHandbookGroupBaseView<TItemView, TItemModel, TViewModel> closure)
			{
			}

			// Token: 0x17006166 RID: 24934
			// (get) Token: 0x06029214 RID: 168468 RVA: 0x000D4928 File Offset: 0x000D2B28
			[Token(Token = "0x17006166")]
			public override int count
			{
				[Token(Token = "0x6029214")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029215 RID: 168469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029215")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403ABB9 RID: 240569
			[Token(Token = "0x403ABB9")]
			[FieldOffset(Offset = "0x0")]
			private ActAutoChessHandbookGroupBaseView<TItemView, TItemModel, TViewModel> m_closure;

			// Token: 0x0403ABBA RID: 240570
			[Token(Token = "0x403ABBA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403ABBB RID: 240571
			[Token(Token = "0x403ABBB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403ABBC RID: 240572
			[Token(Token = "0x403ABBC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
