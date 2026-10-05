using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C9B RID: 15515
	[Token(Token = "0x2003C9B")]
	public class TuningHomeFragGroupView : DataBinder<TuningHomeProperty>, IHotfixable
	{
		// Token: 0x0601838A RID: 99210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601838A")]
		[Address(RVA = "0x10B7900", Offset = "0x10B6500", VA = "0x1810B7900", Slot = "7")]
		public override void OnValueChanged(TuningHomeProperty property)
		{
		}

		// Token: 0x0601838B RID: 99211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601838B")]
		[Address(RVA = "0x10B7880", Offset = "0x10B6480", VA = "0x1810B7880")]
		public void OnProductBtnClicked()
		{
		}

		// Token: 0x0601838C RID: 99212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601838C")]
		[Address(RVA = "0x10B77F0", Offset = "0x10B63F0", VA = "0x1810B77F0")]
		public void OnArchiveBtnClicked()
		{
		}

		// Token: 0x0601838D RID: 99213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601838D")]
		[Address(RVA = "0x10B7B80", Offset = "0x10B6780", VA = "0x1810B7B80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601838E RID: 99214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601838E")]
		[Address(RVA = "0x10B7CE0", Offset = "0x10B68E0", VA = "0x1810B7CE0")]
		public TuningHomeFragGroupView()
		{
		}

		// Token: 0x0401D82B RID: 120875
		[Token(Token = "0x401D82B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401D82C RID: 120876
		[Token(Token = "0x401D82C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _productTrackPoint;

		// Token: 0x0401D82D RID: 120877
		[Token(Token = "0x401D82D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelArchiveBtn;

		// Token: 0x0401D82E RID: 120878
		[Token(Token = "0x401D82E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _archiveTrackPoint;

		// Token: 0x0401D82F RID: 120879
		[Token(Token = "0x401D82F")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D830 RID: 120880
		[Token(Token = "0x401D830")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0401D831 RID: 120881
		[Token(Token = "0x401D831")]
		[FieldOffset(Offset = "0x58")]
		private TuningHomeFragGroupView.Adapter m_adapter;

		// Token: 0x0401D832 RID: 120882
		[Token(Token = "0x401D832")]
		[FieldOffset(Offset = "0x60")]
		private List<TuningHomeFragItemViewModel> m_cacheFragList;

		// Token: 0x0401D833 RID: 120883
		[Token(Token = "0x401D833")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_productTrackPointProperty;

		// Token: 0x0401D834 RID: 120884
		[Token(Token = "0x401D834")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_archiveTrackPointProperty;

		// Token: 0x0401D835 RID: 120885
		[Token(Token = "0x401D835")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D836 RID: 120886
		[Token(Token = "0x401D836")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProductBtnClicked;

		// Token: 0x0401D837 RID: 120887
		[Token(Token = "0x401D837")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnArchiveBtnClicked;

		// Token: 0x0401D838 RID: 120888
		[Token(Token = "0x401D838")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D839 RID: 120889
		[Token(Token = "0x401D839")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C9C RID: 15516
		[Token(Token = "0x2003C9C")]
		private class TuningHomeProductTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x0601838F RID: 99215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601838F")]
			[Address(RVA = "0x10B9300", Offset = "0x10B7F00", VA = "0x1810B9300", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x170039D2 RID: 14802
			// (get) Token: 0x06018390 RID: 99216 RVA: 0x00099B70 File Offset: 0x00097D70
			[Token(Token = "0x170039D2")]
			public bool isShow
			{
				[Token(Token = "0x6018390")]
				[Address(RVA = "0x10B9430", Offset = "0x10B8030", VA = "0x1810B9430", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06018391 RID: 99217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018391")]
			[Address(RVA = "0x10B93D0", Offset = "0x10B7FD0", VA = "0x1810B93D0")]
			public TuningHomeProductTrackPointModel()
			{
			}

			// Token: 0x0401D83A RID: 120890
			[Token(Token = "0x401D83A")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0401D83B RID: 120891
			[Token(Token = "0x401D83B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0401D83C RID: 120892
			[Token(Token = "0x401D83C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0401D83D RID: 120893
			[Token(Token = "0x401D83D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003C9D RID: 15517
		[Token(Token = "0x2003C9D")]
		private class TuningHomeArchiveTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x06018392 RID: 99218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018392")]
			[Address(RVA = "0x10B7660", Offset = "0x10B6260", VA = "0x1810B7660", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x170039D3 RID: 14803
			// (get) Token: 0x06018393 RID: 99219 RVA: 0x00099B88 File Offset: 0x00097D88
			[Token(Token = "0x170039D3")]
			public bool isShow
			{
				[Token(Token = "0x6018393")]
				[Address(RVA = "0x10B7790", Offset = "0x10B6390", VA = "0x1810B7790", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06018394 RID: 99220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018394")]
			[Address(RVA = "0x10B7730", Offset = "0x10B6330", VA = "0x1810B7730")]
			public TuningHomeArchiveTrackPointModel()
			{
			}

			// Token: 0x0401D83E RID: 120894
			[Token(Token = "0x401D83E")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0401D83F RID: 120895
			[Token(Token = "0x401D83F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0401D840 RID: 120896
			[Token(Token = "0x401D840")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0401D841 RID: 120897
			[Token(Token = "0x401D841")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003C9E RID: 15518
		[Token(Token = "0x2003C9E")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06018395 RID: 99221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018395")]
			[Address(RVA = "0x10A4210", Offset = "0x10A2E10", VA = "0x1810A4210")]
			public Adapter(TuningHomeFragGroupView closure)
			{
			}

			// Token: 0x170039D4 RID: 14804
			// (get) Token: 0x06018396 RID: 99222 RVA: 0x00099BA0 File Offset: 0x00097DA0
			[Token(Token = "0x170039D4")]
			public override int count
			{
				[Token(Token = "0x6018396")]
				[Address(RVA = "0x10A4290", Offset = "0x10A2E90", VA = "0x1810A4290", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018397 RID: 99223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018397")]
			[Address(RVA = "0x10A3EF0", Offset = "0x10A2AF0", VA = "0x1810A3EF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D842 RID: 120898
			[Token(Token = "0x401D842")]
			[FieldOffset(Offset = "0x20")]
			private TuningHomeFragGroupView m_closure;

			// Token: 0x0401D843 RID: 120899
			[Token(Token = "0x401D843")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D844 RID: 120900
			[Token(Token = "0x401D844")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D845 RID: 120901
			[Token(Token = "0x401D845")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
