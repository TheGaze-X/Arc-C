using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004454 RID: 17492
	[Token(Token = "0x2004454")]
	public class SandboxV2ToolSelectView : DataBinder<SandboxV2ToolSelectProp>
	{
		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0601ABAF RID: 109487 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ABB0 RID: 109488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F76")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x601ABAF")]
			[Address(RVA = "0x13EB440", Offset = "0x13EA040", VA = "0x1813EB440")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ABB0")]
			[Address(RVA = "0x13EB4A0", Offset = "0x13EA0A0", VA = "0x1813EB4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ABB1 RID: 109489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABB1")]
		[Address(RVA = "0x13EA6C0", Offset = "0x13E92C0", VA = "0x1813EA6C0", Slot = "7")]
		public override void OnValueChanged(SandboxV2ToolSelectProp property)
		{
		}

		// Token: 0x0601ABB2 RID: 109490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABB2")]
		[Address(RVA = "0x13EAF80", Offset = "0x13E9B80", VA = "0x1813EAF80")]
		private void _ScrollToPosIfNeed(int scrollSeqNum, int scrollTargetIdx, int totalCount)
		{
		}

		// Token: 0x0601ABB3 RID: 109491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABB3")]
		[Address(RVA = "0x13EADF0", Offset = "0x13E99F0", VA = "0x1813EADF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ABB4 RID: 109492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABB4")]
		[Address(RVA = "0x13EB3C0", Offset = "0x13E9FC0", VA = "0x1813EB3C0")]
		public SandboxV2ToolSelectView()
		{
		}

		// Token: 0x0402223D RID: 139837
		[Token(Token = "0x402223D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2ToolSelectListAdapter _toolListAdapter;

		// Token: 0x0402223E RID: 139838
		[Token(Token = "0x402223E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyInfoGo;

		// Token: 0x0402223F RID: 139839
		[Token(Token = "0x402223F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _focusInfoGo;

		// Token: 0x04022240 RID: 139840
		[Token(Token = "0x4022240")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _emptyToolHintGo;

		// Token: 0x04022241 RID: 139841
		[Token(Token = "0x4022241")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textToolName;

		// Token: 0x04022242 RID: 139842
		[Token(Token = "0x4022242")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTagName;

		// Token: 0x04022243 RID: 139843
		[Token(Token = "0x4022243")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgTagBg;

		// Token: 0x04022244 RID: 139844
		[Token(Token = "0x4022244")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textToolDesc;

		// Token: 0x04022245 RID: 139845
		[Token(Token = "0x4022245")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textToolUsage;

		// Token: 0x04022246 RID: 139846
		[Token(Token = "0x4022246")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x04022247 RID: 139847
		[Token(Token = "0x4022247")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04022248 RID: 139848
		[Token(Token = "0x4022248")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04022249 RID: 139849
		[Token(Token = "0x4022249")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LoopScrollRect _toolScrollRect;

		// Token: 0x0402224A RID: 139850
		[Token(Token = "0x402224A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _scrollDuration;

		// Token: 0x0402224B RID: 139851
		[Token(Token = "0x402224B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GridLayoutGroup _toolGridGroup;

		// Token: 0x0402224D RID: 139853
		[Token(Token = "0x402224D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0402224E RID: 139854
		[Token(Token = "0x402224E")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x0402224F RID: 139855
		[Token(Token = "0x402224F")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022250 RID: 139856
		[Token(Token = "0x4022250")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_scrollTween;

		// Token: 0x04022251 RID: 139857
		[Token(Token = "0x4022251")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cacheScrollSeqNum;

		// Token: 0x04022252 RID: 139858
		[Token(Token = "0x4022252")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x04022253 RID: 139859
		[Token(Token = "0x4022253")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x04022254 RID: 139860
		[Token(Token = "0x4022254")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022255 RID: 139861
		[Token(Token = "0x4022255")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ScrollToPosIfNeed;

		// Token: 0x04022256 RID: 139862
		[Token(Token = "0x4022256")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022257 RID: 139863
		[Token(Token = "0x4022257")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
