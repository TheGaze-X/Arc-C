using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006395 RID: 25493
	[Token(Token = "0x2006395")]
	public class AutoChessStageInfoBondGroupView : UISimpleRecycleLayoutItemView<AutoChessStageInfoBondGroupModel>, IHotfixable
	{
		// Token: 0x06024C43 RID: 150595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C43")]
		[Address(RVA = "0x1FA50E0", Offset = "0x1FA3CE0", VA = "0x181FA50E0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C44 RID: 150596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C44")]
		[Address(RVA = "0x1FA5150", Offset = "0x1FA3D50", VA = "0x181FA5150", Slot = "6")]
		protected override void OnRender(AutoChessStageInfoBondGroupModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06024C45 RID: 150597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C45")]
		[Address(RVA = "0x1FA5430", Offset = "0x1FA4030", VA = "0x181FA5430")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C46 RID: 150598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C46")]
		[Address(RVA = "0x1FA5550", Offset = "0x1FA4150", VA = "0x181FA5550")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x06024C47 RID: 150599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C47")]
		[Address(RVA = "0x1FA5610", Offset = "0x1FA4210", VA = "0x181FA5610")]
		public AutoChessStageInfoBondGroupView()
		{
		}

		// Token: 0x040335F5 RID: 210421
		[Token(Token = "0x40335F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040335F6 RID: 210422
		[Token(Token = "0x40335F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x040335F7 RID: 210423
		[Token(Token = "0x40335F7")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x040335F8 RID: 210424
		[Token(Token = "0x40335F8")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessStageInfoBondGroupView.Adapter m_adapter;

		// Token: 0x040335F9 RID: 210425
		[Token(Token = "0x40335F9")]
		[FieldOffset(Offset = "0x48")]
		private List<AutoChessStageInfoBondViewModel> m_cachedBondList;

		// Token: 0x040335FA RID: 210426
		[Token(Token = "0x40335FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x040335FB RID: 210427
		[Token(Token = "0x40335FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040335FC RID: 210428
		[Token(Token = "0x40335FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040335FD RID: 210429
		[Token(Token = "0x40335FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x040335FE RID: 210430
		[Token(Token = "0x40335FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006396 RID: 25494
		[Token(Token = "0x2006396")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06024C48 RID: 150600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C48")]
			[Address(RVA = "0x1F96E30", Offset = "0x1F95A30", VA = "0x181F96E30")]
			public Adapter(AutoChessStageInfoBondGroupView closure)
			{
			}

			// Token: 0x170056CA RID: 22218
			// (get) Token: 0x06024C49 RID: 150601 RVA: 0x000C56A0 File Offset: 0x000C38A0
			[Token(Token = "0x170056CA")]
			public override int count
			{
				[Token(Token = "0x6024C49")]
				[Address(RVA = "0x1F970A0", Offset = "0x1F95CA0", VA = "0x181F970A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024C4A RID: 150602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024C4A")]
			[Address(RVA = "0x1F96BB0", Offset = "0x1F957B0", VA = "0x181F96BB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040335FF RID: 210431
			[Token(Token = "0x40335FF")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessStageInfoBondGroupView m_closure;

			// Token: 0x04033600 RID: 210432
			[Token(Token = "0x4033600")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033601 RID: 210433
			[Token(Token = "0x4033601")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033602 RID: 210434
			[Token(Token = "0x4033602")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
