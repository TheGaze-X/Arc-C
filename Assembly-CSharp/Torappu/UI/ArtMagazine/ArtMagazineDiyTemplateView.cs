using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006570 RID: 25968
	[Token(Token = "0x2006570")]
	public class ArtMagazineDiyTemplateView : DataBinder<ArtMagazineDiyTemplateProperty>
	{
		// Token: 0x0602556C RID: 152940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602556C")]
		[Address(RVA = "0x20536A0", Offset = "0x20522A0", VA = "0x1820536A0", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyTemplateProperty property)
		{
		}

		// Token: 0x0602556D RID: 152941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602556D")]
		[Address(RVA = "0x20539F0", Offset = "0x20525F0", VA = "0x1820539F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602556E RID: 152942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602556E")]
		[Address(RVA = "0x2053410", Offset = "0x2052010", VA = "0x182053410")]
		public void EventOnTemplateSet()
		{
		}

		// Token: 0x0602556F RID: 152943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602556F")]
		[Address(RVA = "0x2053370", Offset = "0x2051F70", VA = "0x182053370")]
		public void EventCloseToHomeState()
		{
		}

		// Token: 0x06025570 RID: 152944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025570")]
		[Address(RVA = "0x2053B20", Offset = "0x2052720", VA = "0x182053B20")]
		public ArtMagazineDiyTemplateView()
		{
		}

		// Token: 0x0403464C RID: 214604
		[Token(Token = "0x403464C")]
		private const string PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x0403464D RID: 214605
		[Token(Token = "0x403464D")]
		private const string TYPE_NAME_FORMAT = ".{0}";

		// Token: 0x0403464E RID: 214606
		[Token(Token = "0x403464E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _leafViewHolder;

		// Token: 0x0403464F RID: 214607
		[Token(Token = "0x403464F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _requireItemLayout;

		// Token: 0x04034650 RID: 214608
		[Token(Token = "0x4034650")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x04034651 RID: 214609
		[Token(Token = "0x4034651")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04034652 RID: 214610
		[Token(Token = "0x4034652")]
		[FieldOffset(Offset = "0x48")]
		private List<ArtMagazineDiyTemplateItemCardViewModel> m_cacheItemViewModelList;

		// Token: 0x04034653 RID: 214611
		[Token(Token = "0x4034653")]
		[FieldOffset(Offset = "0x50")]
		private ArtMagazineDiyTemplateView.ItemCardAdapter m_adapter;

		// Token: 0x04034654 RID: 214612
		[Token(Token = "0x4034654")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034655 RID: 214613
		[Token(Token = "0x4034655")]
		[FieldOffset(Offset = "0x68")]
		private bool m_needPlaySetAnim;

		// Token: 0x04034656 RID: 214614
		[Token(Token = "0x4034656")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_firstSetAnimTween;

		// Token: 0x04034657 RID: 214615
		[Token(Token = "0x4034657")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04034658 RID: 214616
		[Token(Token = "0x4034658")]
		[FieldOffset(Offset = "0x80")]
		private string m_cacheTemplateId;

		// Token: 0x04034659 RID: 214617
		[Token(Token = "0x4034659")]
		[FieldOffset(Offset = "0x88")]
		private int m_enterSeqNum;

		// Token: 0x0403465A RID: 214618
		[Token(Token = "0x403465A")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_enterAnimTween;

		// Token: 0x0403465B RID: 214619
		[Token(Token = "0x403465B")]
		[FieldOffset(Offset = "0x98")]
		private ArtMagazineDiyTemplateViewModel m_cacheModel;

		// Token: 0x0403465C RID: 214620
		[Token(Token = "0x403465C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403465D RID: 214621
		[Token(Token = "0x403465D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403465E RID: 214622
		[Token(Token = "0x403465E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnTemplateSet;

		// Token: 0x0403465F RID: 214623
		[Token(Token = "0x403465F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventCloseToHomeState;

		// Token: 0x04034660 RID: 214624
		[Token(Token = "0x4034660")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006571 RID: 25969
		[Token(Token = "0x2006571")]
		private class ItemCardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06025571 RID: 152945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025571")]
			[Address(RVA = "0x2054B80", Offset = "0x2053780", VA = "0x182054B80")]
			public ItemCardAdapter(ArtMagazineDiyTemplateView closure)
			{
			}

			// Token: 0x1700581F RID: 22559
			// (get) Token: 0x06025572 RID: 152946 RVA: 0x000C7788 File Offset: 0x000C5988
			[Token(Token = "0x1700581F")]
			public override int count
			{
				[Token(Token = "0x6025572")]
				[Address(RVA = "0x2054C00", Offset = "0x2053800", VA = "0x182054C00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025573 RID: 152947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025573")]
			[Address(RVA = "0x2054850", Offset = "0x2053450", VA = "0x182054850", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025574 RID: 152948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025574")]
			[Address(RVA = "0x2054A60", Offset = "0x2053660", VA = "0x182054A60")]
			private void _ShowItemDescPanel(int index)
			{
			}

			// Token: 0x04034661 RID: 214625
			[Token(Token = "0x4034661")]
			[FieldOffset(Offset = "0x20")]
			private ArtMagazineDiyTemplateView m_closure;

			// Token: 0x04034662 RID: 214626
			[Token(Token = "0x4034662")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034663 RID: 214627
			[Token(Token = "0x4034663")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034664 RID: 214628
			[Token(Token = "0x4034664")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04034665 RID: 214629
			[Token(Token = "0x4034665")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ShowItemDescPanel;
		}
	}
}
