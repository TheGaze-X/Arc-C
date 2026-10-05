using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052DE RID: 21214
	[Token(Token = "0x20052DE")]
	public class RoguelikeFriendAssistDetailState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0601F4A4 RID: 128164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F4A4")]
		[Address(RVA = "0x19027B0", Offset = "0x19013B0", VA = "0x1819027B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F4A5 RID: 128165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A5")]
		[Address(RVA = "0x1902A40", Offset = "0x1901640", VA = "0x181902A40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F4A6 RID: 128166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A6")]
		[Address(RVA = "0x1903070", Offset = "0x1901C70", VA = "0x181903070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F4A7 RID: 128167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A7")]
		[Address(RVA = "0x1903EE0", Offset = "0x1902AE0", VA = "0x181903EE0")]
		private void _WrapperDismiss()
		{
		}

		// Token: 0x0601F4A8 RID: 128168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A8")]
		[Address(RVA = "0x1903590", Offset = "0x1902190", VA = "0x181903590")]
		private void _SendFriendRequest(Action onComplete)
		{
		}

		// Token: 0x0601F4A9 RID: 128169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A9")]
		[Address(RVA = "0x19038A0", Offset = "0x19024A0", VA = "0x1819038A0")]
		private void _SendRecruitCharRequest(Action onComplete)
		{
		}

		// Token: 0x0601F4AA RID: 128170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4AA")]
		[Address(RVA = "0x1903500", Offset = "0x1902100", VA = "0x181903500")]
		private void _RemoveToInitState()
		{
		}

		// Token: 0x0601F4AB RID: 128171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4AB")]
		[Address(RVA = "0x1903C70", Offset = "0x1902870", VA = "0x181903C70")]
		private void _UpdateGacha()
		{
		}

		// Token: 0x0601F4AC RID: 128172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4AC")]
		[Address(RVA = "0x1902810", Offset = "0x1901410", VA = "0x181902810")]
		public void OnAlreadyRequestClick()
		{
		}

		// Token: 0x0601F4AD RID: 128173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4AD")]
		[Address(RVA = "0x1902D10", Offset = "0x1901910", VA = "0x181902D10")]
		public void OnFriendRequestClick()
		{
		}

		// Token: 0x0601F4AE RID: 128174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4AE")]
		[Address(RVA = "0x1902E70", Offset = "0x1901A70", VA = "0x181902E70")]
		public void OnRecruitCharClick()
		{
		}

		// Token: 0x0601F4AF RID: 128175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4AF")]
		[Address(RVA = "0x19028A0", Offset = "0x19014A0", VA = "0x1819028A0")]
		public void OnBtnCharShow()
		{
		}

		// Token: 0x0601F4B0 RID: 128176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4B0")]
		[Address(RVA = "0x1902DC0", Offset = "0x19019C0", VA = "0x181902DC0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601F4B1 RID: 128177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4B1")]
		[Address(RVA = "0x19031A0", Offset = "0x1901DA0", VA = "0x1819031A0")]
		private void _OnFriendAvatarClick(string uid)
		{
		}

		// Token: 0x0601F4B2 RID: 128178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4B2")]
		[Address(RVA = "0x19033D0", Offset = "0x1901FD0", VA = "0x1819033D0")]
		private void _OpenFriendNameCard(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x0601F4B3 RID: 128179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4B3")]
		[Address(RVA = "0x1903F60", Offset = "0x1902B60", VA = "0x181903F60")]
		public RoguelikeFriendAssistDetailState()
		{
		}

		// Token: 0x0601F4B6 RID: 128182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4B6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402A078 RID: 172152
		[Token(Token = "0x402A078")]
		[NonSerialized]
		public const int ON_FRIEND_AVATAR_CLICK = 0;

		// Token: 0x0402A079 RID: 172153
		[Token(Token = "0x402A079")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402A07A RID: 172154
		[Token(Token = "0x402A07A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeFriendAssistDetailView _view;

		// Token: 0x0402A07B RID: 172155
		[Token(Token = "0x402A07B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0402A07C RID: 172156
		[Token(Token = "0x402A07C")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402A07D RID: 172157
		[Token(Token = "0x402A07D")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeFriendAssistDetailState.MenuAdapter m_menuAdapter;

		// Token: 0x0402A07E RID: 172158
		[Token(Token = "0x402A07E")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeFriendAssistDetailStateBean m_stateBean;

		// Token: 0x0402A07F RID: 172159
		[Token(Token = "0x402A07F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A080 RID: 172160
		[Token(Token = "0x402A080")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A081 RID: 172161
		[Token(Token = "0x402A081")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A082 RID: 172162
		[Token(Token = "0x402A082")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__WrapperDismiss;

		// Token: 0x0402A083 RID: 172163
		[Token(Token = "0x402A083")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendFriendRequest;

		// Token: 0x0402A084 RID: 172164
		[Token(Token = "0x402A084")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendRecruitCharRequest;

		// Token: 0x0402A085 RID: 172165
		[Token(Token = "0x402A085")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RemoveToInitState;

		// Token: 0x0402A086 RID: 172166
		[Token(Token = "0x402A086")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateGacha;

		// Token: 0x0402A087 RID: 172167
		[Token(Token = "0x402A087")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnAlreadyRequestClick;

		// Token: 0x0402A088 RID: 172168
		[Token(Token = "0x402A088")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFriendRequestClick;

		// Token: 0x0402A089 RID: 172169
		[Token(Token = "0x402A089")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRecruitCharClick;

		// Token: 0x0402A08A RID: 172170
		[Token(Token = "0x402A08A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnCharShow;

		// Token: 0x0402A08B RID: 172171
		[Token(Token = "0x402A08B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402A08C RID: 172172
		[Token(Token = "0x402A08C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnFriendAvatarClick;

		// Token: 0x0402A08D RID: 172173
		[Token(Token = "0x402A08D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenFriendNameCard;

		// Token: 0x0402A08E RID: 172174
		[Token(Token = "0x402A08E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052DF RID: 21215
		[Token(Token = "0x20052DF")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x1700496C RID: 18796
			// (get) Token: 0x0601F4B7 RID: 128183 RVA: 0x000B16C0 File Offset: 0x000AF8C0
			[Token(Token = "0x1700496C")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F4B7")]
				[Address(RVA = "0x18F3520", Offset = "0x18F2120", VA = "0x1818F3520", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601F4B8 RID: 128184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F4B8")]
			[Address(RVA = "0x18F3370", Offset = "0x18F1F70", VA = "0x1818F3370")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601F4B9 RID: 128185 RVA: 0x000B16D8 File Offset: 0x000AF8D8
			[Token(Token = "0x601F4B9")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402A08F RID: 172175
			[Token(Token = "0x402A08F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402A090 RID: 172176
			[Token(Token = "0x402A090")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
