using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FED RID: 28653
	[Token(Token = "0x2006FED")]
	public class ActMultiV3StageListInfoDialog : UICompDialog<ActMultiV3StageListInfoDialog.Options>
	{
		// Token: 0x06028B12 RID: 166674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B12")]
		[Address(RVA = "0x24015B0", Offset = "0x24001B0", VA = "0x1824015B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B13 RID: 166675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B13")]
		[Address(RVA = "0x2401290", Offset = "0x23FFE90", VA = "0x182401290", Slot = "18")]
		protected override void OnRender(ActMultiV3StageListInfoDialog.Options input)
		{
		}

		// Token: 0x06028B14 RID: 166676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B14")]
		[Address(RVA = "0x2401230", Offset = "0x23FFE30", VA = "0x182401230", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06028B15 RID: 166677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B15")]
		[Address(RVA = "0x2401170", Offset = "0x23FFD70", VA = "0x182401170")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06028B16 RID: 166678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B16")]
		[Address(RVA = "0x2401730", Offset = "0x2400330", VA = "0x182401730")]
		public ActMultiV3StageListInfoDialog()
		{
		}

		// Token: 0x06028B17 RID: 166679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B17")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04039FD7 RID: 237527
		[Token(Token = "0x4039FD7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x04039FD8 RID: 237528
		[Token(Token = "0x4039FD8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _layoutModeItems;

		// Token: 0x04039FD9 RID: 237529
		[Token(Token = "0x4039FD9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x04039FDA RID: 237530
		[Token(Token = "0x4039FDA")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04039FDB RID: 237531
		[Token(Token = "0x4039FDB")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3StageListInfoDialog.ViewModel m_viewModel;

		// Token: 0x04039FDC RID: 237532
		[Token(Token = "0x4039FDC")]
		[FieldOffset(Offset = "0x98")]
		private ActMultiV3StageListInfoDialog.Adapter m_adapter;

		// Token: 0x04039FDD RID: 237533
		[Token(Token = "0x4039FDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039FDE RID: 237534
		[Token(Token = "0x4039FDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039FDF RID: 237535
		[Token(Token = "0x4039FDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04039FE0 RID: 237536
		[Token(Token = "0x4039FE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04039FE1 RID: 237537
		[Token(Token = "0x4039FE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FEE RID: 28654
		[Token(Token = "0x2006FEE")]
		public class Options
		{
			// Token: 0x06028B18 RID: 166680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B18")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04039FE2 RID: 237538
			[Token(Token = "0x4039FE2")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02006FEF RID: 28655
		[Token(Token = "0x2006FEF")]
		public class ModeItemViewModel : IHotfixable, IComparable<ActMultiV3StageListInfoDialog.ModeItemViewModel>
		{
			// Token: 0x06028B19 RID: 166681 RVA: 0x000D2AF8 File Offset: 0x000D0CF8
			[Token(Token = "0x6028B19")]
			[Address(RVA = "0x2403420", Offset = "0x2402020", VA = "0x182403420", Slot = "4")]
			public int CompareTo(ActMultiV3StageListInfoDialog.ModeItemViewModel other)
			{
				return 0;
			}

			// Token: 0x06028B1A RID: 166682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B1A")]
			[Address(RVA = "0x24034E0", Offset = "0x24020E0", VA = "0x1824034E0")]
			public ModeItemViewModel()
			{
			}

			// Token: 0x04039FE3 RID: 237539
			[Token(Token = "0x4039FE3")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapModeType modeType;

			// Token: 0x04039FE4 RID: 237540
			[Token(Token = "0x4039FE4")]
			[FieldOffset(Offset = "0x18")]
			public string modeDescTitle;

			// Token: 0x04039FE5 RID: 237541
			[Token(Token = "0x4039FE5")]
			[FieldOffset(Offset = "0x20")]
			public string modeDescContent;

			// Token: 0x04039FE6 RID: 237542
			[Token(Token = "0x4039FE6")]
			[FieldOffset(Offset = "0x28")]
			public string modeColor;

			// Token: 0x04039FE7 RID: 237543
			[Token(Token = "0x4039FE7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04039FE8 RID: 237544
			[Token(Token = "0x4039FE8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006FF0 RID: 28656
		[Token(Token = "0x2006FF0")]
		public class ViewModel : IHotfixable
		{
			// Token: 0x06028B1B RID: 166683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B1B")]
			[Address(RVA = "0x24049E0", Offset = "0x24035E0", VA = "0x1824049E0")]
			public void LoadData(string actId)
			{
			}

			// Token: 0x06028B1C RID: 166684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B1C")]
			[Address(RVA = "0x2404C70", Offset = "0x2403870", VA = "0x182404C70")]
			public ViewModel()
			{
			}

			// Token: 0x04039FE9 RID: 237545
			[Token(Token = "0x4039FE9")]
			[FieldOffset(Offset = "0x10")]
			public List<ActMultiV3StageListInfoDialog.ModeItemViewModel> modeItems;

			// Token: 0x04039FEA RID: 237546
			[Token(Token = "0x4039FEA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x04039FEB RID: 237547
			[Token(Token = "0x4039FEB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006FF1 RID: 28657
		[Token(Token = "0x2006FF1")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06028B1D RID: 166685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B1D")]
			[Address(RVA = "0x2418B40", Offset = "0x2417740", VA = "0x182418B40")]
			public Adapter(ActMultiV3StageListInfoDialog closure)
			{
			}

			// Token: 0x17006019 RID: 24601
			// (get) Token: 0x06028B1E RID: 166686 RVA: 0x000D2B10 File Offset: 0x000D0D10
			[Token(Token = "0x17006019")]
			public override int count
			{
				[Token(Token = "0x6028B1E")]
				[Address(RVA = "0x2418E10", Offset = "0x2417A10", VA = "0x182418E10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028B1F RID: 166687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028B1F")]
			[Address(RVA = "0x2418380", Offset = "0x2416F80", VA = "0x182418380", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039FEC RID: 237548
			[Token(Token = "0x4039FEC")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3StageListInfoDialog m_closure;

			// Token: 0x04039FED RID: 237549
			[Token(Token = "0x4039FED")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039FEE RID: 237550
			[Token(Token = "0x4039FEE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039FEF RID: 237551
			[Token(Token = "0x4039FEF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
