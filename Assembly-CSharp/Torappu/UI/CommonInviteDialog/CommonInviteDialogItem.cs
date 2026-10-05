using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BA5 RID: 23461
	[Token(Token = "0x2005BA5")]
	public class CommonInviteDialogItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060220B3 RID: 139443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B3")]
		[Address(RVA = "0x1C90B70", Offset = "0x1C8F770", VA = "0x181C90B70")]
		public void Init(CommonInviteDialog.TextConfig textConfig)
		{
		}

		// Token: 0x060220B4 RID: 139444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B4")]
		[Address(RVA = "0x1C91130", Offset = "0x1C8FD30", VA = "0x181C91130")]
		public void Render(CommonInviteItemDataGroup data, CommonInviteShowType commonInviteShowType)
		{
		}

		// Token: 0x060220B5 RID: 139445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B5")]
		[Address(RVA = "0x1C90F90", Offset = "0x1C8FB90", VA = "0x181C90F90")]
		public void OnInviteClick()
		{
		}

		// Token: 0x060220B6 RID: 139446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B6")]
		[Address(RVA = "0x1C91090", Offset = "0x1C8FC90", VA = "0x181C91090")]
		public void OnInviteSent()
		{
		}

		// Token: 0x060220B7 RID: 139447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B7")]
		[Address(RVA = "0x1C90D90", Offset = "0x1C8F990", VA = "0x181C90D90")]
		public void OnAcceptInviteClick()
		{
		}

		// Token: 0x060220B8 RID: 139448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B8")]
		[Address(RVA = "0x1C90E90", Offset = "0x1C8FA90", VA = "0x181C90E90")]
		public void OnDenyInviteClick()
		{
		}

		// Token: 0x060220B9 RID: 139449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220B9")]
		[Address(RVA = "0x1C91280", Offset = "0x1C8FE80", VA = "0x181C91280")]
		public CommonInviteDialogItem()
		{
		}

		// Token: 0x0402EAC9 RID: 191177
		[Token(Token = "0x402EAC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonInviteDialogItem.Widget[] _widgets;

		// Token: 0x0402EACA RID: 191178
		[Token(Token = "0x402EACA")]
		[FieldOffset(Offset = "0x20")]
		private UICompDialogFinder m_dlgFinder;

		// Token: 0x0402EACB RID: 191179
		[Token(Token = "0x402EACB")]
		[FieldOffset(Offset = "0x30")]
		private CommonInviteItemDataGroup m_data;

		// Token: 0x0402EACC RID: 191180
		[Token(Token = "0x402EACC")]
		[FieldOffset(Offset = "0x38")]
		private CommonInviteDialog.TextConfig m_textConfig;

		// Token: 0x0402EACD RID: 191181
		[Token(Token = "0x402EACD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402EACE RID: 191182
		[Token(Token = "0x402EACE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EACF RID: 191183
		[Token(Token = "0x402EACF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInviteClick;

		// Token: 0x0402EAD0 RID: 191184
		[Token(Token = "0x402EAD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInviteSent;

		// Token: 0x0402EAD1 RID: 191185
		[Token(Token = "0x402EAD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAcceptInviteClick;

		// Token: 0x0402EAD2 RID: 191186
		[Token(Token = "0x402EAD2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDenyInviteClick;

		// Token: 0x0402EAD3 RID: 191187
		[Token(Token = "0x402EAD3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BA6 RID: 23462
		[Token(Token = "0x2005BA6")]
		public abstract class Widget : MonoBehaviour, IHotfixable
		{
			// Token: 0x060220BA RID: 139450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60220BA")]
			[Address(RVA = "0x1C9FD00", Offset = "0x1C9E900", VA = "0x181C9FD00")]
			protected ILoadAsset GetAssetLoader()
			{
				return null;
			}

			// Token: 0x060220BB RID: 139451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220BB")]
			[Address(RVA = "0x1C9FD70", Offset = "0x1C9E970", VA = "0x181C9FD70")]
			public void Init(CommonInviteDialogItem host, CommonInviteDialog.TextConfig textConfig)
			{
			}

			// Token: 0x060220BC RID: 139452
			[Token(Token = "0x60220BC")]
			protected abstract void OnInit();

			// Token: 0x060220BD RID: 139453
			[Token(Token = "0x60220BD")]
			public abstract void Render(CommonInviteItemDataGroup data, CommonInviteShowType commonInviteShowType);

			// Token: 0x060220BE RID: 139454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220BE")]
			[Address(RVA = "0x1C9FEB0", Offset = "0x1C9EAB0", VA = "0x181C9FEB0")]
			protected Widget()
			{
			}

			// Token: 0x0402EAD4 RID: 191188
			[Token(Token = "0x402EAD4")]
			[FieldOffset(Offset = "0x18")]
			private CommonInviteDialogItem m_host;

			// Token: 0x0402EAD5 RID: 191189
			[Token(Token = "0x402EAD5")]
			[FieldOffset(Offset = "0x20")]
			protected CommonInviteDialog.TextConfig textConfig;

			// Token: 0x0402EAD6 RID: 191190
			[Token(Token = "0x402EAD6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetAssetLoader;

			// Token: 0x0402EAD7 RID: 191191
			[Token(Token = "0x402EAD7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402EAD8 RID: 191192
			[Token(Token = "0x402EAD8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
