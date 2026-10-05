using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004390 RID: 17296
	[Token(Token = "0x2004390")]
	public class SandboxV2RiftEntryParamItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A8EE RID: 108782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8EE")]
		[Address(RVA = "0x13B3C00", Offset = "0x13B2800", VA = "0x1813B3C00")]
		public void Render(SandboxV2RiftEntryViewModel.RiftParam param)
		{
		}

		// Token: 0x0601A8EF RID: 108783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8EF")]
		[Address(RVA = "0x13B3DB0", Offset = "0x13B29B0", VA = "0x1813B3DB0")]
		public SandboxV2RiftEntryParamItem()
		{
		}

		// Token: 0x04021CFF RID: 138495
		[Token(Token = "0x4021CFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _paramIcon;

		// Token: 0x04021D00 RID: 138496
		[Token(Token = "0x4021D00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _paramBk;

		// Token: 0x04021D01 RID: 138497
		[Token(Token = "0x4021D01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _paramDesc;

		// Token: 0x04021D02 RID: 138498
		[Token(Token = "0x4021D02")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021D03 RID: 138499
		[Token(Token = "0x4021D03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021D04 RID: 138500
		[Token(Token = "0x4021D04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
