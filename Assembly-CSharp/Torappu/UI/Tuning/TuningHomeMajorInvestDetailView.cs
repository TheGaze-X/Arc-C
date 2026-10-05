using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CBB RID: 15547
	[Token(Token = "0x2003CBB")]
	public class TuningHomeMajorInvestDetailView : DataBinder<TuningHomeMajorInvestDetailProperty>, IHotfixable
	{
		// Token: 0x060183F6 RID: 99318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F6")]
		[Address(RVA = "0x10BD930", Offset = "0x10BC530", VA = "0x1810BD930", Slot = "7")]
		public override void OnValueChanged(TuningHomeMajorInvestDetailProperty property)
		{
		}

		// Token: 0x060183F7 RID: 99319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F7")]
		[Address(RVA = "0x10BD8B0", Offset = "0x10BC4B0", VA = "0x1810BD8B0")]
		public void EventOnCloseBtnClicked()
		{
		}

		// Token: 0x060183F8 RID: 99320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F8")]
		[Address(RVA = "0x10BDD30", Offset = "0x10BC930", VA = "0x1810BDD30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060183F9 RID: 99321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183F9")]
		[Address(RVA = "0x10BDEF0", Offset = "0x10BCAF0", VA = "0x1810BDEF0")]
		public TuningHomeMajorInvestDetailView()
		{
		}

		// Token: 0x0401D924 RID: 121124
		[Token(Token = "0x401D924")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textProgressCurr;

		// Token: 0x0401D925 RID: 121125
		[Token(Token = "0x401D925")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textProgressTarget;

		// Token: 0x0401D926 RID: 121126
		[Token(Token = "0x401D926")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc1;

		// Token: 0x0401D927 RID: 121127
		[Token(Token = "0x401D927")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc2;

		// Token: 0x0401D928 RID: 121128
		[Token(Token = "0x401D928")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc3;

		// Token: 0x0401D929 RID: 121129
		[Token(Token = "0x401D929")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDesc4;

		// Token: 0x0401D92A RID: 121130
		[Token(Token = "0x401D92A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401D92B RID: 121131
		[Token(Token = "0x401D92B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x0401D92C RID: 121132
		[Token(Token = "0x401D92C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0401D92D RID: 121133
		[Token(Token = "0x401D92D")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D92E RID: 121134
		[Token(Token = "0x401D92E")]
		[FieldOffset(Offset = "0x78")]
		private List<TuningHomeMajorInvestItemViewModel> m_cachedModelList;

		// Token: 0x0401D92F RID: 121135
		[Token(Token = "0x401D92F")]
		[FieldOffset(Offset = "0x80")]
		private TuningHomeMajorInvestDetailView.Adapter m_adapter;

		// Token: 0x0401D930 RID: 121136
		[Token(Token = "0x401D930")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D931 RID: 121137
		[Token(Token = "0x401D931")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClicked;

		// Token: 0x0401D932 RID: 121138
		[Token(Token = "0x401D932")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D933 RID: 121139
		[Token(Token = "0x401D933")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CBC RID: 15548
		[Token(Token = "0x2003CBC")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060183FA RID: 99322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183FA")]
			[Address(RVA = "0x10BAD90", Offset = "0x10B9990", VA = "0x1810BAD90")]
			public Adapter(TuningHomeMajorInvestDetailView closure)
			{
			}

			// Token: 0x170039D7 RID: 14807
			// (get) Token: 0x060183FB RID: 99323 RVA: 0x00099C30 File Offset: 0x00097E30
			[Token(Token = "0x170039D7")]
			public override int count
			{
				[Token(Token = "0x60183FB")]
				[Address(RVA = "0x10BAF00", Offset = "0x10B9B00", VA = "0x1810BAF00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060183FC RID: 99324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60183FC")]
			[Address(RVA = "0x10BABC0", Offset = "0x10B97C0", VA = "0x1810BABC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D934 RID: 121140
			[Token(Token = "0x401D934")]
			[FieldOffset(Offset = "0x20")]
			private TuningHomeMajorInvestDetailView m_closure;

			// Token: 0x0401D935 RID: 121141
			[Token(Token = "0x401D935")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D936 RID: 121142
			[Token(Token = "0x401D936")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D937 RID: 121143
			[Token(Token = "0x401D937")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
