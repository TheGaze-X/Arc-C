using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BA9 RID: 23465
	[Token(Token = "0x2005BA9")]
	public class CommonInviteDialogListAdapter : LoopScrollAdapter<CommonInviteDialogListAdapter.Holder, CommonInviteItemDataGroup>
	{
		// Token: 0x060220C9 RID: 139465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C9")]
		[Address(RVA = "0x1C913F0", Offset = "0x1C8FFF0", VA = "0x181C913F0")]
		public void SetParams(CommonInviteShowType inviteShowType, CommonInviteDialog.TextConfig textConfig)
		{
		}

		// Token: 0x060220CA RID: 139466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220CA")]
		[Address(RVA = "0x1C91390", Offset = "0x1C8FF90", VA = "0x181C91390", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x060220CB RID: 139467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220CB")]
		[Address(RVA = "0x1C912E0", Offset = "0x1C8FEE0", VA = "0x181C912E0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060220CC RID: 139468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220CC")]
		[Address(RVA = "0x1C914F0", Offset = "0x1C900F0", VA = "0x181C914F0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CommonInviteDialogListAdapter.Holder holder, CommonInviteItemDataGroup data)
		{
		}

		// Token: 0x060220CD RID: 139469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220CD")]
		[Address(RVA = "0x1C919C0", Offset = "0x1C905C0", VA = "0x181C919C0")]
		public CommonInviteDialogListAdapter()
		{
		}

		// Token: 0x0402EAFA RID: 191226
		[Token(Token = "0x402EAFA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402EAFB RID: 191227
		[Token(Token = "0x402EAFB")]
		[FieldOffset(Offset = "0x60")]
		private CommonInviteShowType m_inviteShowType;

		// Token: 0x0402EAFC RID: 191228
		[Token(Token = "0x402EAFC")]
		[FieldOffset(Offset = "0x68")]
		private CommonInviteDialog.TextConfig m_textConfig;

		// Token: 0x0402EAFD RID: 191229
		[Token(Token = "0x402EAFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x0402EAFE RID: 191230
		[Token(Token = "0x402EAFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0402EAFF RID: 191231
		[Token(Token = "0x402EAFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402EB00 RID: 191232
		[Token(Token = "0x402EB00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402EB01 RID: 191233
		[Token(Token = "0x402EB01")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BAA RID: 23466
		[Token(Token = "0x2005BAA")]
		public class Holder
		{
			// Token: 0x060220CE RID: 139470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220CE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Holder()
			{
			}

			// Token: 0x0402EB02 RID: 191234
			[Token(Token = "0x402EB02")]
			[FieldOffset(Offset = "0x10")]
			public CommonInviteDialogItem itemView;
		}
	}
}
