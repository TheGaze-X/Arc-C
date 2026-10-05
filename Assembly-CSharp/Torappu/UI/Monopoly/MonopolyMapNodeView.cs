using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047FD RID: 18429
	[Token(Token = "0x20047FD")]
	public class MonopolyMapNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BDF0 RID: 114160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDF0")]
		[Address(RVA = "0x1540FE0", Offset = "0x153FBE0", VA = "0x181540FE0")]
		public void Render(MonopolyMapNodeItemModel nodeModel, MonopolyCardPanelModel cardPanelModel, bool isFastMode, int playerPos)
		{
		}

		// Token: 0x0601BDF1 RID: 114161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDF1")]
		[Address(RVA = "0x1541740", Offset = "0x1540340", VA = "0x181541740")]
		private void _RenderNodeImpl(MonopolyMapNodeItemModel nodeModel, MonopolyCardPanelModel cardPanelModel, bool isFastMode, int playerPos)
		{
		}

		// Token: 0x0601BDF2 RID: 114162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDF2")]
		[Address(RVA = "0x1541380", Offset = "0x153FF80", VA = "0x181541380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BDF3 RID: 114163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDF3")]
		[Address(RVA = "0x1541EC0", Offset = "0x1540AC0", VA = "0x181541EC0")]
		public MonopolyMapNodeView()
		{
		}

		// Token: 0x040244C7 RID: 148679
		[Token(Token = "0x40244C7")]
		private const int MINING_BUFF_DISPLAY_MIN_RATE = 2;

		// Token: 0x040244C8 RID: 148680
		[Token(Token = "0x40244C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _resourceTypeIcon;

		// Token: 0x040244C9 RID: 148681
		[Token(Token = "0x40244C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _resourceTypeWhiteIcon;

		// Token: 0x040244CA RID: 148682
		[Token(Token = "0x40244CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _miningBasicCount;

		// Token: 0x040244CB RID: 148683
		[Token(Token = "0x40244CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _miningBuffRate;

		// Token: 0x040244CC RID: 148684
		[Token(Token = "0x40244CC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _nodeIconSizeRect;

		// Token: 0x040244CD RID: 148685
		[Token(Token = "0x40244CD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _comboHintGo;

		// Token: 0x040244CE RID: 148686
		[Token(Token = "0x40244CE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _nodeBasicResourceCountGo;

		// Token: 0x040244CF RID: 148687
		[Token(Token = "0x40244CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _nodeBasicResourceCount;

		// Token: 0x040244D0 RID: 148688
		[Token(Token = "0x40244D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private UIAnimationLocation _chestOpenAnim;

		// Token: 0x040244D1 RID: 148689
		[Token(Token = "0x40244D1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private UIAnimationLocation _chestAddAnim;

		// Token: 0x040244D2 RID: 148690
		[Token(Token = "0x40244D2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private CanvasGroup _miningBuffCanvasGroup;

		// Token: 0x040244D3 RID: 148691
		[Token(Token = "0x40244D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private float _miningBuffSwitchDuration;

		// Token: 0x040244D4 RID: 148692
		[Token(Token = "0x40244D4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private CanvasGroup _nodeInfoCanvasGroup;

		// Token: 0x040244D5 RID: 148693
		[Token(Token = "0x40244D5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private float _miningPreviewSwitchDuration;

		// Token: 0x040244D6 RID: 148694
		[Token(Token = "0x40244D6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private UIAnimationLocation _nodeLockSwitchAnim;

		// Token: 0x040244D7 RID: 148695
		[Token(Token = "0x40244D7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private UIAnimationLocation _nodeRefreshAnim;

		// Token: 0x040244D8 RID: 148696
		[Token(Token = "0x40244D8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private CanvasGroup _nodeRefreshRootCanvas;

		// Token: 0x040244D9 RID: 148697
		[Token(Token = "0x40244D9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private float _nodeRefreshFadeDuration;

		// Token: 0x040244DA RID: 148698
		[Token(Token = "0x40244DA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private CanvasGroup _miningPreviewCanvasGroup;

		// Token: 0x040244DB RID: 148699
		[Token(Token = "0x40244DB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Node Transfer Anim")]
		private CanvasGroup _miningPreviewLockedCanvasGroup;

		// Token: 0x040244DC RID: 148700
		[Token(Token = "0x40244DC")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040244DD RID: 148701
		[Token(Token = "0x40244DD")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x040244DE RID: 148702
		[Token(Token = "0x40244DE")]
		[FieldOffset(Offset = "0xF0")]
		private UISwitchTween m_chestSwitchTween;

		// Token: 0x040244DF RID: 148703
		[Token(Token = "0x40244DF")]
		[FieldOffset(Offset = "0xF8")]
		private UISwitchTween m_miningBuffSwitchTween;

		// Token: 0x040244E0 RID: 148704
		[Token(Token = "0x40244E0")]
		[FieldOffset(Offset = "0x100")]
		private UISwitchTween m_nodeInfoSwitchTween;

		// Token: 0x040244E1 RID: 148705
		[Token(Token = "0x40244E1")]
		[FieldOffset(Offset = "0x108")]
		private UISwitchTween m_nodeLockSwitchTween;

		// Token: 0x040244E2 RID: 148706
		[Token(Token = "0x40244E2")]
		[FieldOffset(Offset = "0x110")]
		private UISwitchTween m_miningPreviewSwitchTween;

		// Token: 0x040244E3 RID: 148707
		[Token(Token = "0x40244E3")]
		[FieldOffset(Offset = "0x118")]
		private UISwitchTween m_miningPreviewLockedSwitchTween;

		// Token: 0x040244E4 RID: 148708
		[Token(Token = "0x40244E4")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_refreshTween;

		// Token: 0x040244E5 RID: 148709
		[Token(Token = "0x40244E5")]
		[FieldOffset(Offset = "0x128")]
		private string m_cacheResourceId;

		// Token: 0x040244E6 RID: 148710
		[Token(Token = "0x40244E6")]
		[FieldOffset(Offset = "0x130")]
		private string m_cacheNodeIconId;

		// Token: 0x040244E7 RID: 148711
		[Token(Token = "0x40244E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040244E8 RID: 148712
		[Token(Token = "0x40244E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderNodeImpl;

		// Token: 0x040244E9 RID: 148713
		[Token(Token = "0x40244E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040244EA RID: 148714
		[Token(Token = "0x40244EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
