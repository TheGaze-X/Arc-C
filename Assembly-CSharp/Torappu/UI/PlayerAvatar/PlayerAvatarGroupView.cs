using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047D3 RID: 18387
	[Token(Token = "0x20047D3")]
	public class PlayerAvatarGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BD40 RID: 113984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD40")]
		[Address(RVA = "0x1528D20", Offset = "0x1527920", VA = "0x181528D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD41 RID: 113985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD41")]
		[Address(RVA = "0x1528AE0", Offset = "0x15276E0", VA = "0x181528AE0")]
		public void Render(PlayerAvatarGroupViewModel viewModel)
		{
		}

		// Token: 0x0601BD42 RID: 113986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD42")]
		[Address(RVA = "0x1528E30", Offset = "0x1527A30", VA = "0x181528E30")]
		public PlayerAvatarGroupView()
		{
		}

		// Token: 0x0402435D RID: 148317
		[Token(Token = "0x402435D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402435E RID: 148318
		[Token(Token = "0x402435E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402435F RID: 148319
		[Token(Token = "0x402435F")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public UIPlayerAvatarEvent clickEvent;

		// Token: 0x04024360 RID: 148320
		[Token(Token = "0x4024360")]
		[FieldOffset(Offset = "0x30")]
		private PlayerAvatarGroupViewModel m_viewModel;

		// Token: 0x04024361 RID: 148321
		[Token(Token = "0x4024361")]
		[FieldOffset(Offset = "0x38")]
		private PlayerAvatarGroupView.AvatarAdapter m_adapter;

		// Token: 0x04024362 RID: 148322
		[Token(Token = "0x4024362")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04024363 RID: 148323
		[Token(Token = "0x4024363")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024364 RID: 148324
		[Token(Token = "0x4024364")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024365 RID: 148325
		[Token(Token = "0x4024365")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047D4 RID: 18388
		[Token(Token = "0x20047D4")]
		private class AvatarAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700422B RID: 16939
			// (get) Token: 0x0601BD43 RID: 113987 RVA: 0x000A6650 File Offset: 0x000A4850
			[Token(Token = "0x1700422B")]
			public override int count
			{
				[Token(Token = "0x601BD43")]
				[Address(RVA = "0x1521440", Offset = "0x1520040", VA = "0x181521440", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BD44 RID: 113988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BD44")]
			[Address(RVA = "0x1521140", Offset = "0x151FD40", VA = "0x181521140", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601BD45 RID: 113989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BD45")]
			[Address(RVA = "0x15213E0", Offset = "0x151FFE0", VA = "0x1815213E0")]
			public AvatarAdapter()
			{
			}

			// Token: 0x04024366 RID: 148326
			[Token(Token = "0x4024366")]
			[FieldOffset(Offset = "0x20")]
			public List<PlayerAvatarItemViewModel> viewModelList;

			// Token: 0x04024367 RID: 148327
			[Token(Token = "0x4024367")]
			[FieldOffset(Offset = "0x28")]
			public UIPlayerAvatarEvent clickEvent;

			// Token: 0x04024368 RID: 148328
			[Token(Token = "0x4024368")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024369 RID: 148329
			[Token(Token = "0x4024369")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402436A RID: 148330
			[Token(Token = "0x402436A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
