using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C39 RID: 19513
	[Token(Token = "0x2004C39")]
	public class HomeMailArchiveDetailView : DataBinder<HomeMailArchiveDetailProperty>
	{
		// Token: 0x0601D4C2 RID: 120002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C2")]
		[Address(RVA = "0x16CFFD0", Offset = "0x16CEBD0", VA = "0x1816CFFD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D4C3 RID: 120003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C3")]
		[Address(RVA = "0x16CFD50", Offset = "0x16CE950", VA = "0x1816CFD50", Slot = "7")]
		public override void OnValueChanged(HomeMailArchiveDetailProperty property)
		{
		}

		// Token: 0x0601D4C4 RID: 120004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C4")]
		[Address(RVA = "0x16D0360", Offset = "0x16CEF60", VA = "0x1816D0360")]
		private void _PlayAnim(bool isNext)
		{
		}

		// Token: 0x0601D4C5 RID: 120005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C5")]
		[Address(RVA = "0x16D0100", Offset = "0x16CED00", VA = "0x1816D0100")]
		private void _PlayAnimImpl(UIAnimationLocation firstAnim, UIAnimationLocation secondAnim)
		{
		}

		// Token: 0x0601D4C6 RID: 120006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C6")]
		[Address(RVA = "0x16D0420", Offset = "0x16CF020", VA = "0x1816D0420")]
		private void _UpdateView()
		{
		}

		// Token: 0x0601D4C7 RID: 120007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C7")]
		[Address(RVA = "0x16CFCB0", Offset = "0x16CE8B0", VA = "0x1816CFCB0")]
		public void OnPrevClick()
		{
		}

		// Token: 0x0601D4C8 RID: 120008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C8")]
		[Address(RVA = "0x16CFC10", Offset = "0x16CE810", VA = "0x1816CFC10")]
		public void OnNextClick()
		{
		}

		// Token: 0x0601D4C9 RID: 120009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C9")]
		[Address(RVA = "0x16CFB70", Offset = "0x16CE770", VA = "0x1816CFB70")]
		public void OnCloseClick()
		{
		}

		// Token: 0x0601D4CA RID: 120010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4CA")]
		[Address(RVA = "0x16D0730", Offset = "0x16CF330", VA = "0x1816D0730")]
		public HomeMailArchiveDetailView()
		{
		}

		// Token: 0x040268A6 RID: 157862
		[Token(Token = "0x40268A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040268A7 RID: 157863
		[Token(Token = "0x40268A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x040268A8 RID: 157864
		[Token(Token = "0x40268A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _name;

		// Token: 0x040268A9 RID: 157865
		[Token(Token = "0x40268A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _time;

		// Token: 0x040268AA RID: 157866
		[Token(Token = "0x40268AA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _content;

		// Token: 0x040268AB RID: 157867
		[Token(Token = "0x40268AB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x040268AC RID: 157868
		[Token(Token = "0x40268AC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040268AD RID: 157869
		[Token(Token = "0x40268AD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _leftAnim;

		// Token: 0x040268AE RID: 157870
		[Token(Token = "0x40268AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _rightAnim;

		// Token: 0x040268AF RID: 157871
		[Token(Token = "0x40268AF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _panelSwitchBtn;

		// Token: 0x040268B0 RID: 157872
		[Token(Token = "0x40268B0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x040268B1 RID: 157873
		[Token(Token = "0x40268B1")]
		[FieldOffset(Offset = "0x88")]
		private HomeMailArchiveDetailView.Adapter m_adapter;

		// Token: 0x040268B2 RID: 157874
		[Token(Token = "0x40268B2")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040268B3 RID: 157875
		[Token(Token = "0x40268B3")]
		[FieldOffset(Offset = "0xA0")]
		private int m_enterSeq;

		// Token: 0x040268B4 RID: 157876
		[Token(Token = "0x40268B4")]
		[FieldOffset(Offset = "0xA4")]
		private int m_prevSeq;

		// Token: 0x040268B5 RID: 157877
		[Token(Token = "0x40268B5")]
		[FieldOffset(Offset = "0xA8")]
		private int m_nextSeq;

		// Token: 0x040268B6 RID: 157878
		[Token(Token = "0x40268B6")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_cachedTween;

		// Token: 0x040268B7 RID: 157879
		[Token(Token = "0x40268B7")]
		[FieldOffset(Offset = "0xB8")]
		private HomeMailArchiveDetailViewModel m_cachedViewModel;

		// Token: 0x040268B8 RID: 157880
		[Token(Token = "0x40268B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040268B9 RID: 157881
		[Token(Token = "0x40268B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040268BA RID: 157882
		[Token(Token = "0x40268BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x040268BB RID: 157883
		[Token(Token = "0x40268BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnimImpl;

		// Token: 0x040268BC RID: 157884
		[Token(Token = "0x40268BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x040268BD RID: 157885
		[Token(Token = "0x40268BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPrevClick;

		// Token: 0x040268BE RID: 157886
		[Token(Token = "0x40268BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnNextClick;

		// Token: 0x040268BF RID: 157887
		[Token(Token = "0x40268BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCloseClick;

		// Token: 0x040268C0 RID: 157888
		[Token(Token = "0x40268C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C3A RID: 19514
		[Token(Token = "0x2004C3A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D4CB RID: 120011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D4CB")]
			[Address(RVA = "0x16C5C50", Offset = "0x16C4850", VA = "0x1816C5C50")]
			public Adapter(HomeMailArchiveDetailView closure)
			{
			}

			// Token: 0x170044DB RID: 17627
			// (get) Token: 0x0601D4CC RID: 120012 RVA: 0x000AB1E0 File Offset: 0x000A93E0
			[Token(Token = "0x170044DB")]
			public override int count
			{
				[Token(Token = "0x601D4CC")]
				[Address(RVA = "0x16C5CD0", Offset = "0x16C48D0", VA = "0x1816C5CD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D4CD RID: 120013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D4CD")]
			[Address(RVA = "0x16C5940", Offset = "0x16C4540", VA = "0x1816C5940", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040268C1 RID: 157889
			[Token(Token = "0x40268C1")]
			[FieldOffset(Offset = "0x20")]
			private HomeMailArchiveDetailView m_closure;

			// Token: 0x040268C2 RID: 157890
			[Token(Token = "0x40268C2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040268C3 RID: 157891
			[Token(Token = "0x40268C3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040268C4 RID: 157892
			[Token(Token = "0x40268C4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
