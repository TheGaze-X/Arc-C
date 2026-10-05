using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F67 RID: 28519
	[Token(Token = "0x2006F67")]
	public class ActMultiV3PhotoAvatarListAdapter : LoopScrollAdapter<ActMultiV3PhotoAvatarListAdapter.ViewHolder, ActMultiV3PhotoDetailViewModel>
	{
		// Token: 0x17005F74 RID: 24436
		// (set) Token: 0x060287DD RID: 165853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F74")]
		public int selectedIdx
		{
			[Token(Token = "0x60287DD")]
			[Address(RVA = "0x23CD890", Offset = "0x23CC490", VA = "0x1823CD890")]
			set
			{
			}
		}

		// Token: 0x060287DE RID: 165854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60287DE")]
		[Address(RVA = "0x23CD5F0", Offset = "0x23CC1F0", VA = "0x1823CD5F0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060287DF RID: 165855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287DF")]
		[Address(RVA = "0x23CD6A0", Offset = "0x23CC2A0", VA = "0x1823CD6A0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActMultiV3PhotoAvatarListAdapter.ViewHolder holder, ActMultiV3PhotoDetailViewModel data)
		{
		}

		// Token: 0x060287E0 RID: 165856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E0")]
		[Address(RVA = "0x23CD810", Offset = "0x23CC410", VA = "0x1823CD810")]
		public ActMultiV3PhotoAvatarListAdapter()
		{
		}

		// Token: 0x040399F7 RID: 236023
		[Token(Token = "0x40399F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _avatarObjPrefab;

		// Token: 0x040399F8 RID: 236024
		[Token(Token = "0x40399F8")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedSelectedIdx;

		// Token: 0x040399F9 RID: 236025
		[Token(Token = "0x40399F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_selectedIdx;

		// Token: 0x040399FA RID: 236026
		[Token(Token = "0x40399FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040399FB RID: 236027
		[Token(Token = "0x40399FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040399FC RID: 236028
		[Token(Token = "0x40399FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F68 RID: 28520
		[Token(Token = "0x2006F68")]
		public class ViewHolder
		{
			// Token: 0x060287E1 RID: 165857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287E1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040399FD RID: 236029
			[Token(Token = "0x40399FD")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3PhotoAvatarItem view;
		}
	}
}
