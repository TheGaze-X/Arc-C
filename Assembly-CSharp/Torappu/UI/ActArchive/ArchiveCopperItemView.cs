using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B56 RID: 27478
	[Token(Token = "0x2006B56")]
	public class ArchiveCopperItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x06027446 RID: 160838 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027447 RID: 160839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CCA")]
		public ArchiveCopperController controller
		{
			[Token(Token = "0x6027446")]
			[Address(RVA = "0x22718C0", Offset = "0x22704C0", VA = "0x1822718C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027447")]
			[Address(RVA = "0x2271930", Offset = "0x2270530", VA = "0x182271930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027448 RID: 160840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027448")]
		[Address(RVA = "0x2271150", Offset = "0x226FD50", VA = "0x182271150")]
		public void Render(CopperItemModel itemModel)
		{
		}

		// Token: 0x06027449 RID: 160841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027449")]
		[Address(RVA = "0x2271050", Offset = "0x226FC50", VA = "0x182271050")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x0602744A RID: 160842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602744A")]
		[Address(RVA = "0x2271460", Offset = "0x2270060", VA = "0x182271460")]
		private void _RenderIcon(CopperItemModel itemModel)
		{
		}

		// Token: 0x0602744B RID: 160843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602744B")]
		[Address(RVA = "0x2271370", Offset = "0x226FF70", VA = "0x182271370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602744C RID: 160844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602744C")]
		[Address(RVA = "0x2271840", Offset = "0x2270440", VA = "0x182271840")]
		public ArchiveCopperItemView()
		{
		}

		// Token: 0x04037964 RID: 227684
		[Token(Token = "0x4037964")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color UNATTAIN_COLOR;

		// Token: 0x04037965 RID: 227685
		[Token(Token = "0x4037965")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color DEFAULT_COLOR;

		// Token: 0x04037966 RID: 227686
		[Token(Token = "0x4037966")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04037967 RID: 227687
		[Token(Token = "0x4037967")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _luckyIcon;

		// Token: 0x04037968 RID: 227688
		[Token(Token = "0x4037968")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleLock;

		// Token: 0x04037969 RID: 227689
		[Token(Token = "0x4037969")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x0403796A RID: 227690
		[Token(Token = "0x403796A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _selectedPanel;

		// Token: 0x0403796B RID: 227691
		[Token(Token = "0x403796B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _defaultSize;

		// Token: 0x0403796D RID: 227693
		[Token(Token = "0x403796D")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0403796E RID: 227694
		[Token(Token = "0x403796E")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedId;

		// Token: 0x0403796F RID: 227695
		[Token(Token = "0x403796F")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04037970 RID: 227696
		[Token(Token = "0x4037970")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04037971 RID: 227697
		[Token(Token = "0x4037971")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037972 RID: 227698
		[Token(Token = "0x4037972")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037973 RID: 227699
		[Token(Token = "0x4037973")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037974 RID: 227700
		[Token(Token = "0x4037974")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x04037975 RID: 227701
		[Token(Token = "0x4037975")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderIcon;

		// Token: 0x04037976 RID: 227702
		[Token(Token = "0x4037976")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037977 RID: 227703
		[Token(Token = "0x4037977")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
