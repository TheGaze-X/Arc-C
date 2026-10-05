using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077CD RID: 30669
	[Token(Token = "0x20077CD")]
	public class Act1VHalfIdleRecruitDetailDialog : UICompDialog<Act1VHalfIdleRecruitDetailDialog.Options>
	{
		// Token: 0x0602B0B5 RID: 176309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0B5")]
		[Address(RVA = "0x26DAD90", Offset = "0x26D9990", VA = "0x1826DAD90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B0B6 RID: 176310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0B6")]
		[Address(RVA = "0x26DABB0", Offset = "0x26D97B0", VA = "0x1826DABB0", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleRecruitDetailDialog.Options input)
		{
		}

		// Token: 0x0602B0B7 RID: 176311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B0B7")]
		[Address(RVA = "0x26DAA80", Offset = "0x26D9680", VA = "0x1826DAA80", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B0B8 RID: 176312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0B8")]
		[Address(RVA = "0x26DAAE0", Offset = "0x26D96E0", VA = "0x1826DAAE0")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x0602B0B9 RID: 176313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0B9")]
		[Address(RVA = "0x26DAEC0", Offset = "0x26D9AC0", VA = "0x1826DAEC0")]
		public Act1VHalfIdleRecruitDetailDialog()
		{
		}

		// Token: 0x0602B0BA RID: 176314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B0BA")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403E2A5 RID: 254629
		[Token(Token = "0x403E2A5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0403E2A6 RID: 254630
		[Token(Token = "0x403E2A6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0403E2A7 RID: 254631
		[Token(Token = "0x403E2A7")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdleRecruitDetailDialog.RecruitDetailViewModel m_viewModel;

		// Token: 0x0403E2A8 RID: 254632
		[Token(Token = "0x403E2A8")]
		[FieldOffset(Offset = "0x88")]
		private Act1VHalfIdleRecruitDetailDialog.Adapter m_adapter;

		// Token: 0x0403E2A9 RID: 254633
		[Token(Token = "0x403E2A9")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0403E2AA RID: 254634
		[Token(Token = "0x403E2AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E2AB RID: 254635
		[Token(Token = "0x403E2AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E2AC RID: 254636
		[Token(Token = "0x403E2AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E2AD RID: 254637
		[Token(Token = "0x403E2AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0403E2AE RID: 254638
		[Token(Token = "0x403E2AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077CE RID: 30670
		[Token(Token = "0x20077CE")]
		public class Options
		{
			// Token: 0x0602B0BB RID: 176315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0BB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0403E2AF RID: 254639
			[Token(Token = "0x403E2AF")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x020077CF RID: 30671
		[Token(Token = "0x20077CF")]
		public class RecruitDetailItemViewModel : IHotfixable
		{
			// Token: 0x0602B0BC RID: 176316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0BC")]
			[Address(RVA = "0x26EC3E0", Offset = "0x26EAFE0", VA = "0x1826EC3E0")]
			public RecruitDetailItemViewModel()
			{
			}

			// Token: 0x0403E2B0 RID: 254640
			[Token(Token = "0x403E2B0")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleGachaPoolType recruitType;

			// Token: 0x0403E2B1 RID: 254641
			[Token(Token = "0x403E2B1")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0403E2B2 RID: 254642
			[Token(Token = "0x403E2B2")]
			[FieldOffset(Offset = "0x20")]
			public string desc;

			// Token: 0x0403E2B3 RID: 254643
			[Token(Token = "0x403E2B3")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x0403E2B4 RID: 254644
			[Token(Token = "0x403E2B4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077D0 RID: 30672
		[Token(Token = "0x20077D0")]
		public class RecruitDetailViewModel : IHotfixable
		{
			// Token: 0x0602B0BD RID: 176317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0BD")]
			[Address(RVA = "0x26EC440", Offset = "0x26EB040", VA = "0x1826EC440")]
			public void LoadData(string actId)
			{
			}

			// Token: 0x0602B0BE RID: 176318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0BE")]
			[Address(RVA = "0x26EC790", Offset = "0x26EB390", VA = "0x1826EC790")]
			public RecruitDetailViewModel()
			{
			}

			// Token: 0x0403E2B5 RID: 254645
			[Token(Token = "0x403E2B5")]
			[FieldOffset(Offset = "0x10")]
			public List<Act1VHalfIdleRecruitDetailDialog.RecruitDetailItemViewModel> itemListViewModel;

			// Token: 0x0403E2B6 RID: 254646
			[Token(Token = "0x403E2B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E2B7 RID: 254647
			[Token(Token = "0x403E2B7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077D2 RID: 30674
		[Token(Token = "0x20077D2")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B0C2 RID: 176322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0C2")]
			[Address(RVA = "0x26E9DD0", Offset = "0x26E89D0", VA = "0x1826E9DD0")]
			public Adapter(Act1VHalfIdleRecruitDetailDialog closure)
			{
			}

			// Token: 0x170064CB RID: 25803
			// (get) Token: 0x0602B0C3 RID: 176323 RVA: 0x000DAB20 File Offset: 0x000D8D20
			[Token(Token = "0x170064CB")]
			public override int count
			{
				[Token(Token = "0x602B0C3")]
				[Address(RVA = "0x26EA000", Offset = "0x26E8C00", VA = "0x1826EA000", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B0C4 RID: 176324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B0C4")]
			[Address(RVA = "0x26E9460", Offset = "0x26E8060", VA = "0x1826E9460", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E2BA RID: 254650
			[Token(Token = "0x403E2BA")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleRecruitDetailDialog m_closure;

			// Token: 0x0403E2BB RID: 254651
			[Token(Token = "0x403E2BB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E2BC RID: 254652
			[Token(Token = "0x403E2BC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E2BD RID: 254653
			[Token(Token = "0x403E2BD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
