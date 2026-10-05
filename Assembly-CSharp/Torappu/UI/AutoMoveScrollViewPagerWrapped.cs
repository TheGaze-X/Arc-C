using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003909 RID: 14601
	[Token(Token = "0x2003909")]
	public class AutoMoveScrollViewPagerWrapped : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601714F RID: 94543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601714F")]
		[Address(RVA = "0xF6DDA0", Offset = "0xF6C9A0", VA = "0x180F6DDA0")]
		public void InitRenderFunc(List<string> spriteList, string hubPath)
		{
		}

		// Token: 0x06017150 RID: 94544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017150")]
		[Address(RVA = "0xF6E6F0", Offset = "0xF6D2F0", VA = "0x180F6E6F0")]
		private void _EnsureImg(int indexI)
		{
		}

		// Token: 0x06017151 RID: 94545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017151")]
		[Address(RVA = "0xF6E160", Offset = "0xF6CD60", VA = "0x180F6E160")]
		public void InitRender(List<Sprite> spriteList)
		{
		}

		// Token: 0x06017152 RID: 94546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017152")]
		[Address(RVA = "0xF6DCA0", Offset = "0xF6C8A0", VA = "0x180F6DCA0")]
		private void Awake()
		{
		}

		// Token: 0x06017153 RID: 94547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017153")]
		[Address(RVA = "0xF6E4E0", Offset = "0xF6D0E0", VA = "0x180F6E4E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06017154 RID: 94548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017154")]
		[Address(RVA = "0xF6EA00", Offset = "0xF6D600", VA = "0x180F6EA00")]
		private void _PageSwitchCallback(int index)
		{
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017155")]
		[Address(RVA = "0xF6E5E0", Offset = "0xF6D1E0", VA = "0x180F6E5E0")]
		private void Update()
		{
		}

		// Token: 0x06017156 RID: 94550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017156")]
		[Address(RVA = "0xF6EB60", Offset = "0xF6D760", VA = "0x180F6EB60")]
		private void _TryTweenToPage(int pageIndex)
		{
		}

		// Token: 0x06017157 RID: 94551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017157")]
		[Address(RVA = "0xF6E970", Offset = "0xF6D570", VA = "0x180F6E970")]
		private void _EnsureSelectedPicState(int pageIndex)
		{
		}

		// Token: 0x06017158 RID: 94552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017158")]
		[Address(RVA = "0xF6EC00", Offset = "0xF6D800", VA = "0x180F6EC00")]
		public AutoMoveScrollViewPagerWrapped()
		{
		}

		// Token: 0x0401BDA1 RID: 114081
		[Token(Token = "0x401BDA1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollViewPager _viewPager;

		// Token: 0x0401BDA2 RID: 114082
		[Token(Token = "0x401BDA2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _objImg;

		// Token: 0x0401BDA3 RID: 114083
		[Token(Token = "0x401BDA3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _imgContainer;

		// Token: 0x0401BDA4 RID: 114084
		[Token(Token = "0x401BDA4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle _pageToggle;

		// Token: 0x0401BDA5 RID: 114085
		[Token(Token = "0x401BDA5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _toggleContainer;

		// Token: 0x0401BDA6 RID: 114086
		[Token(Token = "0x401BDA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _dontMoveWhenOnlyHaveOneImage;

		// Token: 0x0401BDA7 RID: 114087
		[Token(Token = "0x401BDA7")]
		[FieldOffset(Offset = "0x48")]
		private List<Image> m_imageList;

		// Token: 0x0401BDA8 RID: 114088
		[Token(Token = "0x401BDA8")]
		[FieldOffset(Offset = "0x50")]
		private List<Toggle> m_switchToggles;

		// Token: 0x0401BDA9 RID: 114089
		[Token(Token = "0x401BDA9")]
		[FieldOffset(Offset = "0x58")]
		private List<string> m_spriteList;

		// Token: 0x0401BDAA RID: 114090
		[Token(Token = "0x401BDAA")]
		[FieldOffset(Offset = "0x60")]
		private AutoPackSpriteHub m_hub;

		// Token: 0x0401BDAB RID: 114091
		[Token(Token = "0x401BDAB")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401BDAC RID: 114092
		[Token(Token = "0x401BDAC")]
		[FieldOffset(Offset = "0x78")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0401BDAD RID: 114093
		[Token(Token = "0x401BDAD")]
		[FieldOffset(Offset = "0x80")]
		private float m_switchCountDown;

		// Token: 0x0401BDAE RID: 114094
		[Token(Token = "0x401BDAE")]
		private const float SWITCH_PAGE_PERIOD = 6f;

		// Token: 0x0401BDAF RID: 114095
		[Token(Token = "0x401BDAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitRenderFunc;

		// Token: 0x0401BDB0 RID: 114096
		[Token(Token = "0x401BDB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureImg;

		// Token: 0x0401BDB1 RID: 114097
		[Token(Token = "0x401BDB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitRender;

		// Token: 0x0401BDB2 RID: 114098
		[Token(Token = "0x401BDB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401BDB3 RID: 114099
		[Token(Token = "0x401BDB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401BDB4 RID: 114100
		[Token(Token = "0x401BDB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PageSwitchCallback;

		// Token: 0x0401BDB5 RID: 114101
		[Token(Token = "0x401BDB5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401BDB6 RID: 114102
		[Token(Token = "0x401BDB6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTweenToPage;

		// Token: 0x0401BDB7 RID: 114103
		[Token(Token = "0x401BDB7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EnsureSelectedPicState;

		// Token: 0x0401BDB8 RID: 114104
		[Token(Token = "0x401BDB8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
