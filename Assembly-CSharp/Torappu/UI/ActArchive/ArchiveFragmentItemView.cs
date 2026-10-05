using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B8B RID: 27531
	[Token(Token = "0x2006B8B")]
	public class ArchiveFragmentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x0602753D RID: 161085 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602753E RID: 161086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE4")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602753D")]
			[Address(RVA = "0x22823E0", Offset = "0x2280FE0", VA = "0x1822823E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602753E")]
			[Address(RVA = "0x2282440", Offset = "0x2281040", VA = "0x182282440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602753F RID: 161087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602753F")]
		[Address(RVA = "0x2282010", Offset = "0x2280C10", VA = "0x182282010")]
		public void Render(FragmentItemModel viewModel, bool showFadeAnim, string selectedItemId)
		{
		}

		// Token: 0x06027540 RID: 161088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027540")]
		[Address(RVA = "0x2281F00", Offset = "0x2280B00", VA = "0x182281F00")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x06027541 RID: 161089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027541")]
		[Address(RVA = "0x2282290", Offset = "0x2280E90", VA = "0x182282290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027542 RID: 161090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027542")]
		[Address(RVA = "0x2282380", Offset = "0x2280F80", VA = "0x182282380")]
		public ArchiveFragmentItemView()
		{
		}

		// Token: 0x04037B5C RID: 228188
		[Token(Token = "0x4037B5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04037B5D RID: 228189
		[Token(Token = "0x4037B5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnattained;

		// Token: 0x04037B5E RID: 228190
		[Token(Token = "0x4037B5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x04037B5F RID: 228191
		[Token(Token = "0x4037B5F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04037B60 RID: 228192
		[Token(Token = "0x4037B60")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroupSelected;

		// Token: 0x04037B61 RID: 228193
		[Token(Token = "0x4037B61")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x04037B63 RID: 228195
		[Token(Token = "0x4037B63")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04037B64 RID: 228196
		[Token(Token = "0x4037B64")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04037B65 RID: 228197
		[Token(Token = "0x4037B65")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedItemId;

		// Token: 0x04037B66 RID: 228198
		[Token(Token = "0x4037B66")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04037B67 RID: 228199
		[Token(Token = "0x4037B67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04037B68 RID: 228200
		[Token(Token = "0x4037B68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04037B69 RID: 228201
		[Token(Token = "0x4037B69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037B6A RID: 228202
		[Token(Token = "0x4037B6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x04037B6B RID: 228203
		[Token(Token = "0x4037B6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037B6C RID: 228204
		[Token(Token = "0x4037B6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
