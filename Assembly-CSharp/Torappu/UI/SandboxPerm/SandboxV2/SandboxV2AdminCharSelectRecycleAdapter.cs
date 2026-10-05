using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004049 RID: 16457
	[Token(Token = "0x2004049")]
	public class SandboxV2AdminCharSelectRecycleAdapter : LoopScrollAdapter<SandboxV2AdminCharSelectViewHolder, SandboxV2CharViewModel>
	{
		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x06019753 RID: 104275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C97")]
		public new LoopScrollRect scrollRect
		{
			[Token(Token = "0x6019753")]
			[Address(RVA = "0x122AE00", Offset = "0x1229A00", VA = "0x18122AE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019754 RID: 104276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019754")]
		[Address(RVA = "0x122ABE0", Offset = "0x12297E0", VA = "0x18122ABE0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2AdminCharSelectViewHolder holder, SandboxV2CharViewModel data)
		{
		}

		// Token: 0x06019755 RID: 104277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019755")]
		[Address(RVA = "0x122AB20", Offset = "0x1229720", VA = "0x18122AB20", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06019756 RID: 104278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019756")]
		[Address(RVA = "0x122AD90", Offset = "0x1229990", VA = "0x18122AD90")]
		public SandboxV2AdminCharSelectRecycleAdapter()
		{
		}

		// Token: 0x0401FB49 RID: 129865
		[Token(Token = "0x401FB49")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LoopScrollRect _scrollRect;

		// Token: 0x0401FB4A RID: 129866
		[Token(Token = "0x401FB4A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2AdminCharSelectAbstractRightItemView _itemView;

		// Token: 0x0401FB4B RID: 129867
		[Token(Token = "0x401FB4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scrollRect;

		// Token: 0x0401FB4C RID: 129868
		[Token(Token = "0x401FB4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401FB4D RID: 129869
		[Token(Token = "0x401FB4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401FB4E RID: 129870
		[Token(Token = "0x401FB4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
