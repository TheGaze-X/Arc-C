using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072E0 RID: 29408
	[Token(Token = "0x20072E0")]
	public class Act45SideMailView : DataBinder<Act45SideMailProperty>
	{
		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x060299DA RID: 170458 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060299DB RID: 170459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006263")]
		public ILoadAsset loader
		{
			[Token(Token = "0x60299DA")]
			[Address(RVA = "0x24FC380", Offset = "0x24FAF80", VA = "0x1824FC380")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60299DB")]
			[Address(RVA = "0x24FC3E0", Offset = "0x24FAFE0", VA = "0x1824FC3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060299DC RID: 170460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299DC")]
		[Address(RVA = "0x24FB140", Offset = "0x24F9D40", VA = "0x1824FB140", Slot = "7")]
		public override void OnValueChanged(Act45SideMailProperty property)
		{
		}

		// Token: 0x060299DD RID: 170461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299DD")]
		[Address(RVA = "0x24FB390", Offset = "0x24F9F90", VA = "0x1824FB390")]
		public void PlayOutAnim(Action onComplete)
		{
		}

		// Token: 0x060299DE RID: 170462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299DE")]
		[Address(RVA = "0x24FB410", Offset = "0x24FA010", VA = "0x1824FB410")]
		private void _DoRender(Act45SideMailViewModel viewModel)
		{
		}

		// Token: 0x060299DF RID: 170463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299DF")]
		[Address(RVA = "0x24FBC70", Offset = "0x24FA870", VA = "0x1824FBC70")]
		private void _RenderSingleMail(Act45SideMailItemViewModel mailItem)
		{
		}

		// Token: 0x060299E0 RID: 170464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299E0")]
		[Address(RVA = "0x24FBA80", Offset = "0x24FA680", VA = "0x1824FBA80")]
		private void _PlayAnim(UIAnimationLocation anim, [Optional] Action onComplete)
		{
		}

		// Token: 0x060299E1 RID: 170465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299E1")]
		[Address(RVA = "0x24FB550", Offset = "0x24FA150", VA = "0x1824FB550")]
		private void _InitIfNot(Act45SideMailDialog.EntryType entryType)
		{
		}

		// Token: 0x060299E2 RID: 170466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299E2")]
		[Address(RVA = "0x24FB8C0", Offset = "0x24FA4C0", VA = "0x1824FB8C0")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x060299E3 RID: 170467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299E3")]
		[Address(RVA = "0x24FC0C0", Offset = "0x24FACC0", VA = "0x1824FC0C0")]
		private void _TryPlayAudio(Act45SideMailViewModel viewModel)
		{
		}

		// Token: 0x060299E4 RID: 170468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299E4")]
		[Address(RVA = "0x24FC250", Offset = "0x24FAE50", VA = "0x1824FC250")]
		public Act45SideMailView()
		{
		}

		// Token: 0x0403B84F RID: 243791
		[Token(Token = "0x403B84F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Bg")]
		private UIBlurFloatPanel _bgBlur;

		// Token: 0x0403B850 RID: 243792
		[Token(Token = "0x403B850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Alpha")]
		private float _rewardGotAlpha;

		// Token: 0x0403B851 RID: 243793
		[Token(Token = "0x403B851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Group("Alpha")]
		private float _rewardAlpha;

		// Token: 0x0403B852 RID: 243794
		[Token(Token = "0x403B852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Mail")]
		private Text _title;

		// Token: 0x0403B853 RID: 243795
		[Token(Token = "0x403B853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Mail")]
		private Text _mailFrom;

		// Token: 0x0403B854 RID: 243796
		[Token(Token = "0x403B854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Mail")]
		private Text _content;

		// Token: 0x0403B855 RID: 243797
		[Token(Token = "0x403B855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Mail")]
		private Image _img;

		// Token: 0x0403B856 RID: 243798
		[Token(Token = "0x403B856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Mail")]
		private Text _textLock;

		// Token: 0x0403B857 RID: 243799
		[Token(Token = "0x403B857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Reward")]
		private Transform[] _rewardHolder;

		// Token: 0x0403B858 RID: 243800
		[Token(Token = "0x403B858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Reward")]
		private float _itemScale;

		// Token: 0x0403B859 RID: 243801
		[Token(Token = "0x403B859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Reward")]
		private CanvasGroup _rewardPanel;

		// Token: 0x0403B85A RID: 243802
		[Token(Token = "0x403B85A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _panelRewardGot;

		// Token: 0x0403B85B RID: 243803
		[Token(Token = "0x403B85B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Others")]
		private TwoStateToggle _toggleEntryType;

		// Token: 0x0403B85C RID: 243804
		[Token(Token = "0x403B85C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Others")]
		private TwoStateToggle _toggleBtnNext;

		// Token: 0x0403B85D RID: 243805
		[Token(Token = "0x403B85D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Others")]
		private GameObject _panelMail;

		// Token: 0x0403B85E RID: 243806
		[Token(Token = "0x403B85E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Others")]
		private GameObject _panelLocked;

		// Token: 0x0403B85F RID: 243807
		[Token(Token = "0x403B85F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Others")]
		private SimpleLayoutContent _pointContent;

		// Token: 0x0403B860 RID: 243808
		[Token(Token = "0x403B860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _leftIn;

		// Token: 0x0403B861 RID: 243809
		[Token(Token = "0x403B861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _leftOut;

		// Token: 0x0403B862 RID: 243810
		[Token(Token = "0x403B862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _rightIn;

		// Token: 0x0403B863 RID: 243811
		[Token(Token = "0x403B863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _rightOut;

		// Token: 0x0403B864 RID: 243812
		[Token(Token = "0x403B864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _enter;

		// Token: 0x0403B865 RID: 243813
		[Token(Token = "0x403B865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _out;

		// Token: 0x0403B866 RID: 243814
		[Token(Token = "0x403B866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Tween m_tween;

		// Token: 0x0403B868 RID: 243816
		[Token(Token = "0x403B868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool m_isInited;

		// Token: 0x0403B869 RID: 243817
		[Token(Token = "0x403B869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Act45SideMailViewModel m_cachedModel;

		// Token: 0x0403B86A RID: 243818
		[Token(Token = "0x403B86A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Act45SideMailView.PointAdapter m_adapter;

		// Token: 0x0403B86B RID: 243819
		[Token(Token = "0x403B86B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<UIItemCard> m_itemCards;

		// Token: 0x0403B86C RID: 243820
		[Token(Token = "0x403B86C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<UIItemViewModel> m_itemModels;

		// Token: 0x0403B86D RID: 243821
		[Token(Token = "0x403B86D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0403B86E RID: 243822
		[Token(Token = "0x403B86E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0403B86F RID: 243823
		[Token(Token = "0x403B86F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403B870 RID: 243824
		[Token(Token = "0x403B870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayOutAnim;

		// Token: 0x0403B871 RID: 243825
		[Token(Token = "0x403B871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x0403B872 RID: 243826
		[Token(Token = "0x403B872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSingleMail;

		// Token: 0x0403B873 RID: 243827
		[Token(Token = "0x403B873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403B874 RID: 243828
		[Token(Token = "0x403B874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B875 RID: 243829
		[Token(Token = "0x403B875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0403B876 RID: 243830
		[Token(Token = "0x403B876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryPlayAudio;

		// Token: 0x0403B877 RID: 243831
		[Token(Token = "0x403B877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072E1 RID: 29409
		[Token(Token = "0x20072E1")]
		private class PointAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060299E5 RID: 170469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60299E5")]
			[Address(RVA = "0x2501D90", Offset = "0x2500990", VA = "0x182501D90")]
			public PointAdapter(Act45SideMailView closure)
			{
			}

			// Token: 0x17006264 RID: 25188
			// (get) Token: 0x060299E6 RID: 170470 RVA: 0x000D60B0 File Offset: 0x000D42B0
			[Token(Token = "0x17006264")]
			public override int count
			{
				[Token(Token = "0x60299E6")]
				[Address(RVA = "0x2501E10", Offset = "0x2500A10", VA = "0x182501E10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060299E7 RID: 170471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60299E7")]
			[Address(RVA = "0x2501AF0", Offset = "0x25006F0", VA = "0x182501AF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B878 RID: 243832
			[Token(Token = "0x403B878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Act45SideMailView m_closure;

			// Token: 0x0403B879 RID: 243833
			[Token(Token = "0x403B879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B87A RID: 243834
			[Token(Token = "0x403B87A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B87B RID: 243835
			[Token(Token = "0x403B87B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
