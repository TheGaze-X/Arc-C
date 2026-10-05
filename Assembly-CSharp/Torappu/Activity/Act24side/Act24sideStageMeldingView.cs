using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075A1 RID: 30113
	[Token(Token = "0x20075A1")]
	public class Act24sideStageMeldingView : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x0602A5FD RID: 173565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5FD")]
		[Address(RVA = "0x261A690", Offset = "0x2619290", VA = "0x18261A690", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A5FE RID: 173566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5FE")]
		[Address(RVA = "0x261A920", Offset = "0x2619520", VA = "0x18261A920")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A5FF RID: 173567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5FF")]
		[Address(RVA = "0x261AA50", Offset = "0x2619650", VA = "0x18261AA50")]
		public Act24sideStageMeldingView()
		{
		}

		// Token: 0x0403CF66 RID: 249702
		[Token(Token = "0x403CF66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403CF67 RID: 249703
		[Token(Token = "0x403CF67")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403CF68 RID: 249704
		[Token(Token = "0x403CF68")]
		[FieldOffset(Offset = "0x28")]
		private Act24sideStageMeldingView.Adapter m_adapter;

		// Token: 0x0403CF69 RID: 249705
		[Token(Token = "0x403CF69")]
		[FieldOffset(Offset = "0x30")]
		private Act24sideStageMeldingViewModel m_model;

		// Token: 0x0403CF6A RID: 249706
		[Token(Token = "0x403CF6A")]
		[FieldOffset(Offset = "0x38")]
		public ILoadAsset assetLoader;

		// Token: 0x0403CF6B RID: 249707
		[Token(Token = "0x403CF6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403CF6C RID: 249708
		[Token(Token = "0x403CF6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CF6D RID: 249709
		[Token(Token = "0x403CF6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075A2 RID: 30114
		[Token(Token = "0x20075A2")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170063B4 RID: 25524
			// (get) Token: 0x0602A600 RID: 173568 RVA: 0x000D82D0 File Offset: 0x000D64D0
			[Token(Token = "0x170063B4")]
			public override int count
			{
				[Token(Token = "0x602A600")]
				[Address(RVA = "0x261B3A0", Offset = "0x2619FA0", VA = "0x18261B3A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A601 RID: 173569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A601")]
			[Address(RVA = "0x261AAB0", Offset = "0x26196B0", VA = "0x18261AAB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A602 RID: 173570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A602")]
			[Address(RVA = "0x261B2A0", Offset = "0x2619EA0", VA = "0x18261B2A0")]
			public Adapter(Act24sideStageMeldingView closure)
			{
			}

			// Token: 0x0403CF6E RID: 249710
			[Token(Token = "0x403CF6E")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideStageMeldingView m_closure;

			// Token: 0x0403CF6F RID: 249711
			[Token(Token = "0x403CF6F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CF70 RID: 249712
			[Token(Token = "0x403CF70")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403CF71 RID: 249713
			[Token(Token = "0x403CF71")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
