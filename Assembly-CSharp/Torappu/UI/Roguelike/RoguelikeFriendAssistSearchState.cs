using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052E7 RID: 21223
	[Token(Token = "0x20052E7")]
	public class RoguelikeFriendAssistSearchState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601F4D4 RID: 128212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F4D4")]
		[Address(RVA = "0x1907090", Offset = "0x1905C90", VA = "0x181907090", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F4D5 RID: 128213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D5")]
		[Address(RVA = "0x1907240", Offset = "0x1905E40", VA = "0x181907240", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F4D6 RID: 128214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D6")]
		[Address(RVA = "0x19077B0", Offset = "0x19063B0", VA = "0x1819077B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F4D7 RID: 128215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F4D7")]
		[Address(RVA = "0x1907830", Offset = "0x1906430", VA = "0x181907830", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601F4D8 RID: 128216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D8")]
		[Address(RVA = "0x1908200", Offset = "0x1906E00", VA = "0x181908200")]
		private void _RegisterToDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x0601F4D9 RID: 128217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D9")]
		[Address(RVA = "0x1907A90", Offset = "0x1906690", VA = "0x181907A90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F4DA RID: 128218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4DA")]
		[Address(RVA = "0x1908820", Offset = "0x1907420", VA = "0x181908820")]
		private void _WrapperDismiss()
		{
		}

		// Token: 0x0601F4DB RID: 128219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4DB")]
		[Address(RVA = "0x19086A0", Offset = "0x19072A0", VA = "0x1819086A0")]
		private void _UpdateProp()
		{
		}

		// Token: 0x0601F4DC RID: 128220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4DC")]
		[Address(RVA = "0x19083B0", Offset = "0x1906FB0", VA = "0x1819083B0")]
		private void _SendGetAssistListRequest(string index, ProfessionCategory profession, Action onComplete)
		{
		}

		// Token: 0x0601F4DD RID: 128221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F4DD")]
		[Address(RVA = "0x1908770", Offset = "0x1907370", VA = "0x181908770")]
		private IEnumerator _WaitForRefreshCountDown()
		{
			return null;
		}

		// Token: 0x0601F4DE RID: 128222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4DE")]
		[Address(RVA = "0x19070F0", Offset = "0x1905CF0", VA = "0x1819070F0")]
		public void OnBtnRefresh()
		{
		}

		// Token: 0x0601F4DF RID: 128223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4DF")]
		[Address(RVA = "0x1907C70", Offset = "0x1906870", VA = "0x181907C70")]
		private void _OnAssistItemClick(PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData assistData)
		{
		}

		// Token: 0x0601F4E0 RID: 128224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E0")]
		[Address(RVA = "0x1907570", Offset = "0x1906170", VA = "0x181907570", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601F4E1 RID: 128225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E1")]
		[Address(RVA = "0x1907D20", Offset = "0x1906920", VA = "0x181907D20")]
		private void _OnFriendAvatarClick(string uid)
		{
		}

		// Token: 0x0601F4E2 RID: 128226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E2")]
		[Address(RVA = "0x19080D0", Offset = "0x1906CD0", VA = "0x1819080D0")]
		private void _OpenFriendNameCard(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x0601F4E3 RID: 128227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E3")]
		[Address(RVA = "0x1907F50", Offset = "0x1906B50", VA = "0x181907F50")]
		private void _OnStarFriendTabClick(long intVal)
		{
		}

		// Token: 0x0601F4E4 RID: 128228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E4")]
		[Address(RVA = "0x19088A0", Offset = "0x19074A0", VA = "0x1819088A0")]
		public RoguelikeFriendAssistSearchState()
		{
		}

		// Token: 0x0601F4E6 RID: 128230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F4E7 RID: 128231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4E7")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F4E8 RID: 128232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F4E8")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402A0E0 RID: 172256
		[Token(Token = "0x402A0E0")]
		[NonSerialized]
		public const int ON_FRIEND_AVATAR_CLICK = 0;

		// Token: 0x0402A0E1 RID: 172257
		[Token(Token = "0x402A0E1")]
		[NonSerialized]
		public const int ON_STAR_FRIEND_TAB_CLICK = 1;

		// Token: 0x0402A0E2 RID: 172258
		[Token(Token = "0x402A0E2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402A0E3 RID: 172259
		[Token(Token = "0x402A0E3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeFriendAssistSearchView _view;

		// Token: 0x0402A0E4 RID: 172260
		[Token(Token = "0x402A0E4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _btnRefreshToggle;

		// Token: 0x0402A0E5 RID: 172261
		[Token(Token = "0x402A0E5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textCountDown;

		// Token: 0x0402A0E6 RID: 172262
		[Token(Token = "0x402A0E6")]
		private const int COUNT_DOWN_SEC = 3;

		// Token: 0x0402A0E7 RID: 172263
		[Token(Token = "0x402A0E7")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeFriendAssistSearchStateBean m_stateBean;

		// Token: 0x0402A0E8 RID: 172264
		[Token(Token = "0x402A0E8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0402A0E9 RID: 172265
		[Token(Token = "0x402A0E9")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402A0EA RID: 172266
		[Token(Token = "0x402A0EA")]
		[FieldOffset(Offset = "0xA8")]
		private string m_topicId;

		// Token: 0x0402A0EB RID: 172267
		[Token(Token = "0x402A0EB")]
		[FieldOffset(Offset = "0xB0")]
		private PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData m_cacheAssistData;

		// Token: 0x0402A0EC RID: 172268
		[Token(Token = "0x402A0EC")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x0402A0ED RID: 172269
		[Token(Token = "0x402A0ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A0EE RID: 172270
		[Token(Token = "0x402A0EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A0EF RID: 172271
		[Token(Token = "0x402A0EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402A0F0 RID: 172272
		[Token(Token = "0x402A0F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402A0F1 RID: 172273
		[Token(Token = "0x402A0F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterToDetailState;

		// Token: 0x0402A0F2 RID: 172274
		[Token(Token = "0x402A0F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A0F3 RID: 172275
		[Token(Token = "0x402A0F3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__WrapperDismiss;

		// Token: 0x0402A0F4 RID: 172276
		[Token(Token = "0x402A0F4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateProp;

		// Token: 0x0402A0F5 RID: 172277
		[Token(Token = "0x402A0F5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendGetAssistListRequest;

		// Token: 0x0402A0F6 RID: 172278
		[Token(Token = "0x402A0F6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__WaitForRefreshCountDown;

		// Token: 0x0402A0F7 RID: 172279
		[Token(Token = "0x402A0F7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnRefresh;

		// Token: 0x0402A0F8 RID: 172280
		[Token(Token = "0x402A0F8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnAssistItemClick;

		// Token: 0x0402A0F9 RID: 172281
		[Token(Token = "0x402A0F9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402A0FA RID: 172282
		[Token(Token = "0x402A0FA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnFriendAvatarClick;

		// Token: 0x0402A0FB RID: 172283
		[Token(Token = "0x402A0FB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenFriendNameCard;

		// Token: 0x0402A0FC RID: 172284
		[Token(Token = "0x402A0FC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnStarFriendTabClick;

		// Token: 0x0402A0FD RID: 172285
		[Token(Token = "0x402A0FD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
