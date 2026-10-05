using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA1 RID: 15521
	[Token(Token = "0x2003CA1")]
	public class TuningHomeInvestGroupView : DataBinder<TuningHomeProperty>, IHotfixable
	{
		// Token: 0x0601839D RID: 99229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601839D")]
		[Address(RVA = "0x10B82E0", Offset = "0x10B6EE0", VA = "0x1810B82E0", Slot = "7")]
		public override void OnValueChanged(TuningHomeProperty property)
		{
		}

		// Token: 0x0601839E RID: 99230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601839E")]
		[Address(RVA = "0x10B8550", Offset = "0x10B7150", VA = "0x1810B8550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601839F RID: 99231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601839F")]
		[Address(RVA = "0x10B8670", Offset = "0x10B7270", VA = "0x1810B8670")]
		public TuningHomeInvestGroupView()
		{
		}

		// Token: 0x0401D853 RID: 120915
		[Token(Token = "0x401D853")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TuningHomeMajorInvestView _majorView;

		// Token: 0x0401D854 RID: 120916
		[Token(Token = "0x401D854")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TuningHomeHiddenInvestView _hiddenView;

		// Token: 0x0401D855 RID: 120917
		[Token(Token = "0x401D855")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _normalContent;

		// Token: 0x0401D856 RID: 120918
		[Token(Token = "0x401D856")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRemainTime;

		// Token: 0x0401D857 RID: 120919
		[Token(Token = "0x401D857")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0401D858 RID: 120920
		[Token(Token = "0x401D858")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0401D859 RID: 120921
		[Token(Token = "0x401D859")]
		[FieldOffset(Offset = "0x50")]
		private List<TuningHomeNormalInvestViewModel> m_cacheNormalInvestModel;

		// Token: 0x0401D85A RID: 120922
		[Token(Token = "0x401D85A")]
		[FieldOffset(Offset = "0x58")]
		private int m_cacheEntryAnimSequence;

		// Token: 0x0401D85B RID: 120923
		[Token(Token = "0x401D85B")]
		[FieldOffset(Offset = "0x60")]
		private TuningHomeInvestGroupView.NormalAdapter m_adapter;

		// Token: 0x0401D85C RID: 120924
		[Token(Token = "0x401D85C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D85D RID: 120925
		[Token(Token = "0x401D85D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D85E RID: 120926
		[Token(Token = "0x401D85E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CA2 RID: 15522
		[Token(Token = "0x2003CA2")]
		private class NormalAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060183A0 RID: 99232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183A0")]
			[Address(RVA = "0x10A50C0", Offset = "0x10A3CC0", VA = "0x1810A50C0")]
			public NormalAdapter(TuningHomeInvestGroupView closure)
			{
			}

			// Token: 0x170039D5 RID: 14805
			// (get) Token: 0x060183A1 RID: 99233 RVA: 0x00099BB8 File Offset: 0x00097DB8
			[Token(Token = "0x170039D5")]
			public override int count
			{
				[Token(Token = "0x60183A1")]
				[Address(RVA = "0x10A5140", Offset = "0x10A3D40", VA = "0x1810A5140", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060183A2 RID: 99234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60183A2")]
			[Address(RVA = "0x10A4F00", Offset = "0x10A3B00", VA = "0x1810A4F00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D85F RID: 120927
			[Token(Token = "0x401D85F")]
			[FieldOffset(Offset = "0x20")]
			private TuningHomeInvestGroupView m_closure;

			// Token: 0x0401D860 RID: 120928
			[Token(Token = "0x401D860")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D861 RID: 120929
			[Token(Token = "0x401D861")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D862 RID: 120930
			[Token(Token = "0x401D862")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
