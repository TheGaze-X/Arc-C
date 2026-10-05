using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F3B RID: 16187
	[Token(Token = "0x2003F3B")]
	public class SiracusaOperaCommentView : DataBinder<SiracusaOperaCommentProperty>
	{
		// Token: 0x0601923E RID: 102974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601923E")]
		[Address(RVA = "0x11DACB0", Offset = "0x11D98B0", VA = "0x1811DACB0", Slot = "7")]
		public override void OnValueChanged(SiracusaOperaCommentProperty property)
		{
		}

		// Token: 0x0601923F RID: 102975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601923F")]
		[Address(RVA = "0x11DAC30", Offset = "0x11D9830", VA = "0x1811DAC30")]
		public void OnLikeCancel()
		{
		}

		// Token: 0x06019240 RID: 102976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019240")]
		[Address(RVA = "0x11DB7B0", Offset = "0x11DA3B0", VA = "0x1811DB7B0")]
		private void _OnCommentClicked(string commentId)
		{
		}

		// Token: 0x06019241 RID: 102977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019241")]
		[Address(RVA = "0x11DB570", Offset = "0x11DA170", VA = "0x1811DB570")]
		private Sprite _LoadTitleBkg(string operaId)
		{
			return null;
		}

		// Token: 0x06019242 RID: 102978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019242")]
		[Address(RVA = "0x11DB420", Offset = "0x11DA020", VA = "0x1811DB420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019243 RID: 102979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019243")]
		[Address(RVA = "0x11DB840", Offset = "0x11DA440", VA = "0x1811DB840")]
		public SiracusaOperaCommentView()
		{
		}

		// Token: 0x0401F238 RID: 127544
		[Token(Token = "0x401F238")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _operaName;

		// Token: 0x0401F239 RID: 127545
		[Token(Token = "0x401F239")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _operaSubName;

		// Token: 0x0401F23A RID: 127546
		[Token(Token = "0x401F23A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _score;

		// Token: 0x0401F23B RID: 127547
		[Token(Token = "0x401F23B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _canLike;

		// Token: 0x0401F23C RID: 127548
		[Token(Token = "0x401F23C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _totalLike;

		// Token: 0x0401F23D RID: 127549
		[Token(Token = "0x401F23D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _timeNum;

		// Token: 0x0401F23E RID: 127550
		[Token(Token = "0x401F23E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _timeUnit;

		// Token: 0x0401F23F RID: 127551
		[Token(Token = "0x401F23F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _bottomText;

		// Token: 0x0401F240 RID: 127552
		[Token(Token = "0x401F240")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelTime;

		// Token: 0x0401F241 RID: 127553
		[Token(Token = "0x401F241")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLike;

		// Token: 0x0401F242 RID: 127554
		[Token(Token = "0x401F242")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _titleBkg;

		// Token: 0x0401F243 RID: 127555
		[Token(Token = "0x401F243")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _scroll;

		// Token: 0x0401F244 RID: 127556
		[Token(Token = "0x401F244")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401F245 RID: 127557
		[Token(Token = "0x401F245")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIStringEvent _onCommentClicked;

		// Token: 0x0401F246 RID: 127558
		[Token(Token = "0x401F246")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0401F247 RID: 127559
		[Token(Token = "0x401F247")]
		[FieldOffset(Offset = "0x98")]
		private SiracusaOperaCommentView.Adapter m_adapter;

		// Token: 0x0401F248 RID: 127560
		[Token(Token = "0x401F248")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F249 RID: 127561
		[Token(Token = "0x401F249")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLikeCancel;

		// Token: 0x0401F24A RID: 127562
		[Token(Token = "0x401F24A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnCommentClicked;

		// Token: 0x0401F24B RID: 127563
		[Token(Token = "0x401F24B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadTitleBkg;

		// Token: 0x0401F24C RID: 127564
		[Token(Token = "0x401F24C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F24D RID: 127565
		[Token(Token = "0x401F24D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F3C RID: 16188
		[Token(Token = "0x2003F3C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C23 RID: 15395
			// (set) Token: 0x06019244 RID: 102980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C23")]
			public List<List<SiracusaOperaCommentItemViewModel>> commentGroups
			{
				[Token(Token = "0x6019244")]
				[Address(RVA = "0x11C54B0", Offset = "0x11C40B0", VA = "0x1811C54B0")]
				set
				{
				}
			}

			// Token: 0x17003C24 RID: 15396
			// (get) Token: 0x06019245 RID: 102981 RVA: 0x0009D170 File Offset: 0x0009B370
			[Token(Token = "0x17003C24")]
			public override int count
			{
				[Token(Token = "0x6019245")]
				[Address(RVA = "0x11C5320", Offset = "0x11C3F20", VA = "0x1811C5320", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019246 RID: 102982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019246")]
			[Address(RVA = "0x11C4B60", Offset = "0x11C3760", VA = "0x1811C4B60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019247 RID: 102983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019247")]
			[Address(RVA = "0x11C4DD0", Offset = "0x11C39D0", VA = "0x1811C4DD0")]
			public void UpdateColumnBottomHeight()
			{
			}

			// Token: 0x06019248 RID: 102984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019248")]
			[Address(RVA = "0x11C5000", Offset = "0x11C3C00", VA = "0x1811C5000")]
			public Adapter()
			{
			}

			// Token: 0x0401F24E RID: 127566
			[Token(Token = "0x401F24E")]
			[FieldOffset(Offset = "0x20")]
			private List<List<SiracusaOperaCommentItemViewModel>> m_commentGroups;

			// Token: 0x0401F24F RID: 127567
			[Token(Token = "0x401F24F")]
			[FieldOffset(Offset = "0x28")]
			private float m_maxHeight;

			// Token: 0x0401F250 RID: 127568
			[Token(Token = "0x401F250")]
			[FieldOffset(Offset = "0x30")]
			public string selectedCommentId;

			// Token: 0x0401F251 RID: 127569
			[Token(Token = "0x401F251")]
			[FieldOffset(Offset = "0x38")]
			public SiracusaOperaCommentView closure;

			// Token: 0x0401F252 RID: 127570
			[Token(Token = "0x401F252")]
			[FieldOffset(Offset = "0x40")]
			public bool isInit;

			// Token: 0x0401F253 RID: 127571
			[Token(Token = "0x401F253")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_commentGroups;

			// Token: 0x0401F254 RID: 127572
			[Token(Token = "0x401F254")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F255 RID: 127573
			[Token(Token = "0x401F255")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F256 RID: 127574
			[Token(Token = "0x401F256")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateColumnBottomHeight;

			// Token: 0x0401F257 RID: 127575
			[Token(Token = "0x401F257")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
