using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047D1 RID: 18385
	[Token(Token = "0x20047D1")]
	public class PlayerAvatarGroupListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BD38 RID: 113976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD38")]
		[Address(RVA = "0x15287F0", Offset = "0x15273F0", VA = "0x1815287F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD39 RID: 113977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD39")]
		[Address(RVA = "0x15285A0", Offset = "0x15271A0", VA = "0x1815285A0")]
		public void Render(List<PlayerAvatarGroupViewModel> viewModelList)
		{
		}

		// Token: 0x0601BD3A RID: 113978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD3A")]
		[Address(RVA = "0x1528920", Offset = "0x1527520", VA = "0x181528920")]
		public PlayerAvatarGroupListView()
		{
		}

		// Token: 0x0402434F RID: 148303
		[Token(Token = "0x402434F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04024350 RID: 148304
		[Token(Token = "0x4024350")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIPlayerAvatarEvent _clickAvatarEvent;

		// Token: 0x04024351 RID: 148305
		[Token(Token = "0x4024351")]
		[FieldOffset(Offset = "0x28")]
		private PlayerAvatarGroupListView.PlayerAvatarGroupListAdapter m_adapter;

		// Token: 0x04024352 RID: 148306
		[Token(Token = "0x4024352")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04024353 RID: 148307
		[Token(Token = "0x4024353")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024354 RID: 148308
		[Token(Token = "0x4024354")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024355 RID: 148309
		[Token(Token = "0x4024355")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047D2 RID: 18386
		[Token(Token = "0x20047D2")]
		private class PlayerAvatarGroupListAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17004229 RID: 16937
			// (get) Token: 0x0601BD3B RID: 113979 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601BD3C RID: 113980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004229")]
			public List<PlayerAvatarGroupViewModel> viewModelList
			{
				[Token(Token = "0x601BD3B")]
				[Address(RVA = "0x15284C0", Offset = "0x15270C0", VA = "0x1815284C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601BD3C")]
				[Address(RVA = "0x1528520", Offset = "0x1527120", VA = "0x181528520")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700422A RID: 16938
			// (get) Token: 0x0601BD3D RID: 113981 RVA: 0x000A6638 File Offset: 0x000A4838
			[Token(Token = "0x1700422A")]
			public override int count
			{
				[Token(Token = "0x601BD3D")]
				[Address(RVA = "0x1528400", Offset = "0x1527000", VA = "0x181528400", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BD3E RID: 113982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BD3E")]
			[Address(RVA = "0x15281A0", Offset = "0x1526DA0", VA = "0x1815281A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601BD3F RID: 113983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BD3F")]
			[Address(RVA = "0x15283A0", Offset = "0x1526FA0", VA = "0x1815283A0")]
			public PlayerAvatarGroupListAdapter()
			{
			}

			// Token: 0x04024357 RID: 148311
			[Token(Token = "0x4024357")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public UIPlayerAvatarEvent clickEvent;

			// Token: 0x04024358 RID: 148312
			[Token(Token = "0x4024358")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_viewModelList;

			// Token: 0x04024359 RID: 148313
			[Token(Token = "0x4024359")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_viewModelList;

			// Token: 0x0402435A RID: 148314
			[Token(Token = "0x402435A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402435B RID: 148315
			[Token(Token = "0x402435B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402435C RID: 148316
			[Token(Token = "0x402435C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
