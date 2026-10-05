using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BA7 RID: 23463
	[Token(Token = "0x2005BA7")]
	public class CommonInviteDialogItemDefaultWidget : CommonInviteDialogItem.Widget, IHotfixable
	{
		// Token: 0x060220BF RID: 139455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220BF")]
		[Address(RVA = "0x1C8FD70", Offset = "0x1C8E970", VA = "0x181C8FD70", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060220C0 RID: 139456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C0")]
		[Address(RVA = "0x1C90000", Offset = "0x1C8EC00", VA = "0x181C90000", Slot = "5")]
		public override void Render(CommonInviteItemDataGroup data, CommonInviteShowType commonInviteShowType)
		{
		}

		// Token: 0x060220C1 RID: 139457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C1")]
		[Address(RVA = "0x1C90250", Offset = "0x1C8EE50", VA = "0x181C90250")]
		private void _RenderCommonPart(CommonInviteDialogItemData data)
		{
		}

		// Token: 0x060220C2 RID: 139458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C2")]
		[Address(RVA = "0x1C90790", Offset = "0x1C8F390", VA = "0x181C90790")]
		private void _RenderInvitePart(CommonInviteShowType commonInviteShowType, long lastInviteTs, int inviteCd)
		{
		}

		// Token: 0x060220C3 RID: 139459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C3")]
		[Address(RVA = "0x1C908B0", Offset = "0x1C8F4B0", VA = "0x181C908B0")]
		private void _RenderNameCardSkin(string skinId, int tmpl)
		{
		}

		// Token: 0x060220C4 RID: 139460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C4")]
		[Address(RVA = "0x1C909F0", Offset = "0x1C8F5F0", VA = "0x181C909F0")]
		private void _RenderSortMarks(CommonInviteSortInfo sortInfo)
		{
		}

		// Token: 0x060220C5 RID: 139461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220C5")]
		[Address(RVA = "0x1C90AC0", Offset = "0x1C8F6C0", VA = "0x181C90AC0")]
		public CommonInviteDialogItemDefaultWidget()
		{
		}

		// Token: 0x0402EAD9 RID: 191193
		[Token(Token = "0x402EAD9")]
		private const int DEFAULT_SUPPLY_NUM = 3;

		// Token: 0x0402EADA RID: 191194
		[Token(Token = "0x402EADA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _level;

		// Token: 0x0402EADB RID: 191195
		[Token(Token = "0x402EADB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0402EADC RID: 191196
		[Token(Token = "0x402EADC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x0402EADD RID: 191197
		[Token(Token = "0x402EADD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _iconStar;

		// Token: 0x0402EADE RID: 191198
		[Token(Token = "0x402EADE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402EADF RID: 191199
		[Token(Token = "0x402EADF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _aliasName;

		// Token: 0x0402EAE0 RID: 191200
		[Token(Token = "0x402EAE0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _onlineTime;

		// Token: 0x0402EAE1 RID: 191201
		[Token(Token = "0x402EAE1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TwoStateToggle _onlineState;

		// Token: 0x0402EAE2 RID: 191202
		[Token(Token = "0x402EAE2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _panelInvite;

		// Token: 0x0402EAE3 RID: 191203
		[Token(Token = "0x402EAE3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _panelInviteCoolDown;

		// Token: 0x0402EAE4 RID: 191204
		[Token(Token = "0x402EAE4")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _panelInvited;

		// Token: 0x0402EAE5 RID: 191205
		[Token(Token = "0x402EAE5")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _panelRecent;

		// Token: 0x0402EAE6 RID: 191206
		[Token(Token = "0x402EAE6")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _panelAlreadyIn;

		// Token: 0x0402EAE7 RID: 191207
		[Token(Token = "0x402EAE7")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private SimpleLayoutContent _assistContent;

		// Token: 0x0402EAE8 RID: 191208
		[Token(Token = "0x402EAE8")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0402EAE9 RID: 191209
		[Token(Token = "0x402EAE9")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textInRoom;

		// Token: 0x0402EAEA RID: 191210
		[Token(Token = "0x402EAEA")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textRecent;

		// Token: 0x0402EAEB RID: 191211
		[Token(Token = "0x402EAEB")]
		[FieldOffset(Offset = "0x118")]
		private CommonInviteDialogItemDefaultWidget.Adapter m_assistAdapter;

		// Token: 0x0402EAEC RID: 191212
		[Token(Token = "0x402EAEC")]
		[FieldOffset(Offset = "0x120")]
		private PlayerAvatarView m_avatar;

		// Token: 0x0402EAED RID: 191213
		[Token(Token = "0x402EAED")]
		[FieldOffset(Offset = "0x128")]
		private FriendDataWithNameCard m_friendData;

		// Token: 0x0402EAEE RID: 191214
		[Token(Token = "0x402EAEE")]
		[FieldOffset(Offset = "0x130")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402EAEF RID: 191215
		[Token(Token = "0x402EAEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402EAF0 RID: 191216
		[Token(Token = "0x402EAF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EAF1 RID: 191217
		[Token(Token = "0x402EAF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCommonPart;

		// Token: 0x0402EAF2 RID: 191218
		[Token(Token = "0x402EAF2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderInvitePart;

		// Token: 0x0402EAF3 RID: 191219
		[Token(Token = "0x402EAF3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderNameCardSkin;

		// Token: 0x0402EAF4 RID: 191220
		[Token(Token = "0x402EAF4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSortMarks;

		// Token: 0x0402EAF5 RID: 191221
		[Token(Token = "0x402EAF5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BA8 RID: 23464
		[Token(Token = "0x2005BA8")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060220C6 RID: 139462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220C6")]
			[Address(RVA = "0x1C85350", Offset = "0x1C83F50", VA = "0x181C85350")]
			public Adapter(CommonInviteDialogItemDefaultWidget closure)
			{
			}

			// Token: 0x17004FB4 RID: 20404
			// (get) Token: 0x060220C7 RID: 139463 RVA: 0x000BC3B8 File Offset: 0x000BA5B8
			[Token(Token = "0x17004FB4")]
			public override int count
			{
				[Token(Token = "0x60220C7")]
				[Address(RVA = "0x1C853D0", Offset = "0x1C83FD0", VA = "0x181C853D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060220C8 RID: 139464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60220C8")]
			[Address(RVA = "0x1C85170", Offset = "0x1C83D70", VA = "0x181C85170", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EAF6 RID: 191222
			[Token(Token = "0x402EAF6")]
			[FieldOffset(Offset = "0x20")]
			private CommonInviteDialogItemDefaultWidget m_closure;

			// Token: 0x0402EAF7 RID: 191223
			[Token(Token = "0x402EAF7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EAF8 RID: 191224
			[Token(Token = "0x402EAF8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EAF9 RID: 191225
			[Token(Token = "0x402EAF9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
