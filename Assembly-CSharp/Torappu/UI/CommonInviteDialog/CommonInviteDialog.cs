using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using UnityEngine;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005B95 RID: 23445
	[Token(Token = "0x2005B95")]
	public class CommonInviteDialog : UICompDialog<CommonInviteDialog.Input>, IValueMsgReceiver
	{
		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x0602205F RID: 139359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FA4")]
		public CommonInviteDialog.Plugin plugin
		{
			[Token(Token = "0x602205F")]
			[Address(RVA = "0x1C958F0", Offset = "0x1C944F0", VA = "0x181C958F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022060 RID: 139360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022060")]
		[Address(RVA = "0x1C930D0", Offset = "0x1C91CD0", VA = "0x181C930D0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06022061 RID: 139361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022061")]
		[Address(RVA = "0x1C936E0", Offset = "0x1C922E0", VA = "0x181C936E0", Slot = "18")]
		protected override void OnRender(CommonInviteDialog.Input input)
		{
		}

		// Token: 0x06022062 RID: 139362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022062")]
		[Address(RVA = "0x1C94150", Offset = "0x1C92D50", VA = "0x181C94150")]
		private void _InitPluginsAndHandlers(CommonInviteDialog.Input input)
		{
		}

		// Token: 0x06022063 RID: 139363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022063")]
		[Address(RVA = "0x1C93E90", Offset = "0x1C92A90", VA = "0x181C93E90")]
		private void _InitCache(CommonInviteDialog.Input input)
		{
		}

		// Token: 0x06022064 RID: 139364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022064")]
		[Address(RVA = "0x1C93190", Offset = "0x1C91D90", VA = "0x181C93190", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022065 RID: 139365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022065")]
		[Address(RVA = "0x1C93050", Offset = "0x1C91C50", VA = "0x181C93050")]
		public void OnBackClick()
		{
		}

		// Token: 0x06022066 RID: 139366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022066")]
		[Address(RVA = "0x1C95690", Offset = "0x1C94290", VA = "0x181C95690")]
		private void _Toast(CommonInviteDialog.ResultToastType type)
		{
		}

		// Token: 0x06022067 RID: 139367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022067")]
		[Address(RVA = "0x1C94A50", Offset = "0x1C93650", VA = "0x181C94A50")]
		private void _OnConfirm([Optional] List<string> msg)
		{
		}

		// Token: 0x06022068 RID: 139368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022068")]
		[Address(RVA = "0x1C954F0", Offset = "0x1C940F0", VA = "0x181C954F0")]
		private void _RefreshToggle(bool showToast = false)
		{
		}

		// Token: 0x06022069 RID: 139369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022069")]
		[Address(RVA = "0x1C95350", Offset = "0x1C93F50", VA = "0x181C95350")]
		private void _RefreshList()
		{
		}

		// Token: 0x0602206A RID: 139370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602206A")]
		[Address(RVA = "0x1C93CB0", Offset = "0x1C928B0", VA = "0x181C93CB0")]
		private void _GetFriendList()
		{
		}

		// Token: 0x0602206B RID: 139371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602206B")]
		[Address(RVA = "0x1C94CA0", Offset = "0x1C938A0", VA = "0x181C94CA0")]
		private void _OnInviteSuccess(string uid)
		{
		}

		// Token: 0x0602206C RID: 139372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602206C")]
		[Address(RVA = "0x1C952A0", Offset = "0x1C93EA0", VA = "0x181C952A0")]
		private void _ProcessInvite(bool isAccept, List<string> msg, bool isSuccess)
		{
		}

		// Token: 0x0602206D RID: 139373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602206D")]
		[Address(RVA = "0x1C93AA0", Offset = "0x1C926A0", VA = "0x181C93AA0")]
		private List<string> _GeneratePageIds()
		{
			return null;
		}

		// Token: 0x0602206E RID: 139374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602206E")]
		[Address(RVA = "0x1C939B0", Offset = "0x1C925B0", VA = "0x181C939B0")]
		private void _ApplyFriendList(ListDict<string, CommonInviteSortInfo> friendIds)
		{
		}

		// Token: 0x0602206F RID: 139375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602206F")]
		[Address(RVA = "0x1C938B0", Offset = "0x1C924B0", VA = "0x181C938B0")]
		private void _AppendItemData(List<CommonInviteItemDataGroup> data)
		{
		}

		// Token: 0x06022070 RID: 139376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022070")]
		[Address(RVA = "0x1C94B60", Offset = "0x1C93760", VA = "0x181C94B60")]
		private void _OnInviteClicked(string uid)
		{
		}

		// Token: 0x06022071 RID: 139377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022071")]
		[Address(RVA = "0x1C94780", Offset = "0x1C93380", VA = "0x181C94780")]
		private void _OnAcceptInvite(string uid)
		{
		}

		// Token: 0x06022072 RID: 139378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022072")]
		[Address(RVA = "0x1C95000", Offset = "0x1C93C00", VA = "0x181C95000")]
		private void _OnRejectInvite(string uid)
		{
		}

		// Token: 0x06022073 RID: 139379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022073")]
		[Address(RVA = "0x1C94EE0", Offset = "0x1C93AE0", VA = "0x181C94EE0")]
		private void _OnInvitedSetting()
		{
		}

		// Token: 0x06022074 RID: 139380 RVA: 0x000BC298 File Offset: 0x000BA498
		[Token(Token = "0x6022074")]
		[Address(RVA = "0x1C92FA0", Offset = "0x1C91BA0", VA = "0x181C92FA0")]
		public bool CheckPlayerExcluded(string uid)
		{
			return default(bool);
		}

		// Token: 0x06022075 RID: 139381 RVA: 0x000BC2B0 File Offset: 0x000BA4B0
		[Token(Token = "0x6022075")]
		[Address(RVA = "0x1C92A90", Offset = "0x1C91690", VA = "0x181C92A90")]
		public static bool BuildDefaultInviteDialog(CommonInviteDialog.DefaultBuildParams buildParams, out int instId)
		{
			return default(bool);
		}

		// Token: 0x06022076 RID: 139382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022076")]
		[Address(RVA = "0x1C95760", Offset = "0x1C94360", VA = "0x181C95760")]
		public CommonInviteDialog()
		{
		}

		// Token: 0x06022077 RID: 139383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022077")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402EA2E RID: 191022
		[Token(Token = "0x402EA2E")]
		private const int NUM_PER_PAGE = 20;

		// Token: 0x0402EA2F RID: 191023
		[Token(Token = "0x402EA2F")]
		private const int DEFAULT_INVITE_COOL_DOWN = 60;

		// Token: 0x0402EA30 RID: 191024
		[Token(Token = "0x402EA30")]
		private const int SERVICE_STABLE_LOCK_SORT_INFO = 0;

		// Token: 0x0402EA31 RID: 191025
		[Token(Token = "0x402EA31")]
		private const int SERVICE_STABLE_LOCK_FRIEND_LIST = 1;

		// Token: 0x0402EA32 RID: 191026
		[Token(Token = "0x402EA32")]
		private const int SERVICE_STABLE_LOCK_INVITE = 2;

		// Token: 0x0402EA33 RID: 191027
		[Token(Token = "0x402EA33")]
		private const int SERVICE_STABLE_LOCK_PROCESS_INVITED = 3;

		// Token: 0x0402EA34 RID: 191028
		[Token(Token = "0x402EA34")]
		private const int SERVICE_STABLE_LOCK_INVITED_SETTING = 4;

		// Token: 0x0402EA35 RID: 191029
		[Token(Token = "0x402EA35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CommonInviteDialogView _dialogView;

		// Token: 0x0402EA36 RID: 191030
		[Token(Token = "0x402EA36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggleBinder _stateToggle;

		// Token: 0x0402EA37 RID: 191031
		[Token(Token = "0x402EA37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CommonInviteDialogProp m_prop;

		// Token: 0x0402EA38 RID: 191032
		[Token(Token = "0x402EA38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BoolProperty m_isAcceptInviteProp;

		// Token: 0x0402EA39 RID: 191033
		[Token(Token = "0x402EA39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CommonInviteDialog.IInviteServiceHandler m_sortInfoHandler;

		// Token: 0x0402EA3A RID: 191034
		[Token(Token = "0x402EA3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CommonInviteDialog.IInviteServiceHandler m_invitedRefreshHandler;

		// Token: 0x0402EA3B RID: 191035
		[Token(Token = "0x402EA3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CommonInviteDialog.IInviteServiceHandler m_friendListHandler;

		// Token: 0x0402EA3C RID: 191036
		[Token(Token = "0x402EA3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CommonInviteDialog.IInviteServiceHandler m_inviteHandler;

		// Token: 0x0402EA3D RID: 191037
		[Token(Token = "0x402EA3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CommonInviteDialog.IInviteServiceHandler m_processInviteHandler;

		// Token: 0x0402EA3E RID: 191038
		[Token(Token = "0x402EA3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CommonInviteDialog.IInviteServiceHandler m_invitedSettingHandler;

		// Token: 0x0402EA3F RID: 191039
		[Token(Token = "0x402EA3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CommonInviteDialog.Plugin m_plugin;

		// Token: 0x0402EA40 RID: 191040
		[Token(Token = "0x402EA40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private CommonInviteDialog.Input m_input;

		// Token: 0x0402EA41 RID: 191041
		[Token(Token = "0x402EA41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ListSet<string> m_excludePlayers;

		// Token: 0x0402EA42 RID: 191042
		[Token(Token = "0x402EA42")]
		[NonSerialized]
		public const int ON_INVITE_CLICK = 0;

		// Token: 0x0402EA43 RID: 191043
		[Token(Token = "0x402EA43")]
		[NonSerialized]
		public const int ON_INVITED_ACCEPT_CLICK = 1;

		// Token: 0x0402EA44 RID: 191044
		[Token(Token = "0x402EA44")]
		[NonSerialized]
		public const int ON_INVITED_REJECT_CLICK = 2;

		// Token: 0x0402EA45 RID: 191045
		[Token(Token = "0x402EA45")]
		[NonSerialized]
		public const int ON_GET_FRIEND_LIST = 3;

		// Token: 0x0402EA46 RID: 191046
		[Token(Token = "0x402EA46")]
		[NonSerialized]
		public const int ON_INVITED_SETTING = 4;

		// Token: 0x0402EA47 RID: 191047
		[Token(Token = "0x402EA47")]
		[NonSerialized]
		public const int ON_REFRESH = 5;

		// Token: 0x0402EA48 RID: 191048
		[Token(Token = "0x402EA48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0402EA49 RID: 191049
		[Token(Token = "0x402EA49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402EA4A RID: 191050
		[Token(Token = "0x402EA4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402EA4B RID: 191051
		[Token(Token = "0x402EA4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitPluginsAndHandlers;

		// Token: 0x0402EA4C RID: 191052
		[Token(Token = "0x402EA4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitCache;

		// Token: 0x0402EA4D RID: 191053
		[Token(Token = "0x402EA4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402EA4E RID: 191054
		[Token(Token = "0x402EA4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0402EA4F RID: 191055
		[Token(Token = "0x402EA4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Toast;

		// Token: 0x0402EA50 RID: 191056
		[Token(Token = "0x402EA50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnConfirm;

		// Token: 0x0402EA51 RID: 191057
		[Token(Token = "0x402EA51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshToggle;

		// Token: 0x0402EA52 RID: 191058
		[Token(Token = "0x402EA52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshList;

		// Token: 0x0402EA53 RID: 191059
		[Token(Token = "0x402EA53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetFriendList;

		// Token: 0x0402EA54 RID: 191060
		[Token(Token = "0x402EA54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnInviteSuccess;

		// Token: 0x0402EA55 RID: 191061
		[Token(Token = "0x402EA55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessInvite;

		// Token: 0x0402EA56 RID: 191062
		[Token(Token = "0x402EA56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GeneratePageIds;

		// Token: 0x0402EA57 RID: 191063
		[Token(Token = "0x402EA57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ApplyFriendList;

		// Token: 0x0402EA58 RID: 191064
		[Token(Token = "0x402EA58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AppendItemData;

		// Token: 0x0402EA59 RID: 191065
		[Token(Token = "0x402EA59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnInviteClicked;

		// Token: 0x0402EA5A RID: 191066
		[Token(Token = "0x402EA5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnAcceptInvite;

		// Token: 0x0402EA5B RID: 191067
		[Token(Token = "0x402EA5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnRejectInvite;

		// Token: 0x0402EA5C RID: 191068
		[Token(Token = "0x402EA5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnInvitedSetting;

		// Token: 0x0402EA5D RID: 191069
		[Token(Token = "0x402EA5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckPlayerExcluded;

		// Token: 0x0402EA5E RID: 191070
		[Token(Token = "0x402EA5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_BuildDefaultInviteDialog;

		// Token: 0x0402EA5F RID: 191071
		[Token(Token = "0x402EA5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B96 RID: 23446
		[Token(Token = "0x2005B96")]
		public enum ResultToastType
		{
			// Token: 0x0402EA61 RID: 191073
			[Token(Token = "0x402EA61")]
			TOO_FAST,
			// Token: 0x0402EA62 RID: 191074
			[Token(Token = "0x402EA62")]
			INVITE_FULL,
			// Token: 0x0402EA63 RID: 191075
			[Token(Token = "0x402EA63")]
			INVITE_INVALID
		}

		// Token: 0x02005B97 RID: 23447
		[Token(Token = "0x2005B97")]
		public struct TextConfig
		{
			// Token: 0x0402EA64 RID: 191076
			[Token(Token = "0x402EA64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string tooFastToast;

			// Token: 0x0402EA65 RID: 191077
			[Token(Token = "0x402EA65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string inviteFullToast;

			// Token: 0x0402EA66 RID: 191078
			[Token(Token = "0x402EA66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string inviteInvalidToast;

			// Token: 0x0402EA67 RID: 191079
			[Token(Token = "0x402EA67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string inviteSendToast;

			// Token: 0x0402EA68 RID: 191080
			[Token(Token = "0x402EA68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string afterInviteSendToast;

			// Token: 0x0402EA69 RID: 191081
			[Token(Token = "0x402EA69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string startReceiveInviteToast;

			// Token: 0x0402EA6A RID: 191082
			[Token(Token = "0x402EA6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string stopReceiveInviteToast;

			// Token: 0x0402EA6B RID: 191083
			[Token(Token = "0x402EA6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string inviteTitle;

			// Token: 0x0402EA6C RID: 191084
			[Token(Token = "0x402EA6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string receiveTitle;

			// Token: 0x0402EA6D RID: 191085
			[Token(Token = "0x402EA6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string receiveSetting;

			// Token: 0x0402EA6E RID: 191086
			[Token(Token = "0x402EA6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string inviteEmpty;

			// Token: 0x0402EA6F RID: 191087
			[Token(Token = "0x402EA6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string receiveEmpty;

			// Token: 0x0402EA70 RID: 191088
			[Token(Token = "0x402EA70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string alreadyInRoom;

			// Token: 0x0402EA71 RID: 191089
			[Token(Token = "0x402EA71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string recentMate;
		}

		// Token: 0x02005B98 RID: 23448
		[Token(Token = "0x2005B98")]
		public class Input
		{
			// Token: 0x06022078 RID: 139384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022078")]
			[Address(RVA = "0x1C96EA0", Offset = "0x1C95AA0", VA = "0x181C96EA0")]
			public Input()
			{
			}

			// Token: 0x0402EA72 RID: 191090
			[Token(Token = "0x402EA72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string targetId;

			// Token: 0x0402EA73 RID: 191091
			[Token(Token = "0x402EA73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerInviteType targetType;

			// Token: 0x0402EA74 RID: 191092
			[Token(Token = "0x402EA74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public CommonInviteShowType inviteShowType;

			// Token: 0x0402EA75 RID: 191093
			[Token(Token = "0x402EA75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, long> invitedCache;

			// Token: 0x0402EA76 RID: 191094
			[Token(Token = "0x402EA76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool useAutoInvitedCache;

			// Token: 0x0402EA77 RID: 191095
			[Token(Token = "0x402EA77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int inviteSendCooldown;

			// Token: 0x0402EA78 RID: 191096
			[Token(Token = "0x402EA78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CommonInviteDialog.TextConfig textConfig;

			// Token: 0x0402EA79 RID: 191097
			[Token(Token = "0x402EA79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public string[] excludePlayers;

			// Token: 0x0402EA7A RID: 191098
			[Token(Token = "0x402EA7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Type pluginType;
		}

		// Token: 0x02005B99 RID: 23449
		[Token(Token = "0x2005B99")]
		public class Output
		{
			// Token: 0x06022079 RID: 139385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022079")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x0402EA7B RID: 191099
			[Token(Token = "0x402EA7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> msg;
		}

		// Token: 0x02005B9A RID: 23450
		[Token(Token = "0x2005B9A")]
		public abstract class Plugin : IHotfixable
		{
			// Token: 0x17004FA5 RID: 20389
			// (get) Token: 0x0602207A RID: 139386 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602207B RID: 139387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FA5")]
			public CommonInviteDialog hostDlg
			{
				[Token(Token = "0x602207A")]
				[Address(RVA = "0x1C98220", Offset = "0x1C96E20", VA = "0x181C98220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602207B")]
				[Address(RVA = "0x1C98350", Offset = "0x1C96F50", VA = "0x181C98350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004FA6 RID: 20390
			// (get) Token: 0x0602207C RID: 139388 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602207D RID: 139389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FA6")]
			public CommonInviteDialog.Input input
			{
				[Token(Token = "0x602207C")]
				[Address(RVA = "0x1C98280", Offset = "0x1C96E80", VA = "0x181C98280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602207D")]
				[Address(RVA = "0x1C983D0", Offset = "0x1C96FD0", VA = "0x181C983D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004FA7 RID: 20391
			// (get) Token: 0x0602207E RID: 139390 RVA: 0x000BC2C8 File Offset: 0x000BA4C8
			// (set) Token: 0x0602207F RID: 139391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FA7")]
			public long curTime
			{
				[Token(Token = "0x602207E")]
				[Address(RVA = "0x1C981C0", Offset = "0x1C96DC0", VA = "0x181C981C0")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x602207F")]
				[Address(RVA = "0x1C982E0", Offset = "0x1C96EE0", VA = "0x181C982E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06022080 RID: 139392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022080")]
			[Address(RVA = "0x1C97D30", Offset = "0x1C96930", VA = "0x181C97D30")]
			public void Init(CommonInviteDialog dialog, CommonInviteDialog.Input input)
			{
			}

			// Token: 0x06022081 RID: 139393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022081")]
			[Address(RVA = "0x1C98020", Offset = "0x1C96C20", VA = "0x181C98020", Slot = "4")]
			protected virtual void OnInit()
			{
			}

			// Token: 0x06022082 RID: 139394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022082")]
			[Address(RVA = "0x1C97F40", Offset = "0x1C96B40", VA = "0x181C97F40")]
			public void NotifyCurTimeUpdated()
			{
			}

			// Token: 0x06022083 RID: 139395
			[Token(Token = "0x6022083")]
			public abstract CommonInviteSortInfo.CustomImpl HandleFriendCustomSortInfo(FriendSortViewModel respModel);

			// Token: 0x06022084 RID: 139396
			[Token(Token = "0x6022084")]
			public abstract CommonInviteSortInfo.CustomImpl HandleInviteCustomSortInfo(PlayerInviteInfo inviteInfo);

			// Token: 0x06022085 RID: 139397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022085")]
			[Address(RVA = "0x1C97980", Offset = "0x1C96580", VA = "0x181C97980", Slot = "7")]
			public virtual Comparison<CommonInviteSortInfo> DefineSortInfoComparison()
			{
				return null;
			}

			// Token: 0x06022086 RID: 139398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022086")]
			[Address(RVA = "0x1C97890", Offset = "0x1C96490", VA = "0x181C97890", Slot = "8")]
			public virtual List<string> DefineFriendSortInfoKeys()
			{
				return null;
			}

			// Token: 0x06022087 RID: 139399 RVA: 0x000BC2E0 File Offset: 0x000BA4E0
			[Token(Token = "0x6022087")]
			[Address(RVA = "0x1C97C70", Offset = "0x1C96870", VA = "0x181C97C70", Slot = "9")]
			public virtual ValueBundle HandleFriendNameCardExtraData(FriendDataWithNameCard friendData)
			{
				return default(ValueBundle);
			}

			// Token: 0x06022088 RID: 139400 RVA: 0x000BC2F8 File Offset: 0x000BA4F8
			[Token(Token = "0x6022088")]
			[Address(RVA = "0x1C98080", Offset = "0x1C96C80", VA = "0x181C98080")]
			public bool ValidateFriendLastOnlineStatus(FriendUtil.OnlineStatus onlineStatus)
			{
				return default(bool);
			}

			// Token: 0x06022089 RID: 139401 RVA: 0x000BC310 File Offset: 0x000BA510
			[Token(Token = "0x6022089")]
			[Address(RVA = "0x1C97770", Offset = "0x1C96370", VA = "0x181C97770")]
			public bool CheckAlreadyInRoom(bool isInRoom, long expireTs)
			{
				return default(bool);
			}

			// Token: 0x0602208A RID: 139402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602208A")]
			[Address(RVA = "0x1C97620", Offset = "0x1C96220", VA = "0x181C97620")]
			public static void AddServiceSortKeyActivity(ref List<string> keys, string actId, string actType)
			{
			}

			// Token: 0x0602208B RID: 139403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602208B")]
			[Address(RVA = "0x1C98160", Offset = "0x1C96D60", VA = "0x181C98160")]
			protected Plugin()
			{
			}

			// Token: 0x0402EA7F RID: 191103
			[Token(Token = "0x402EA7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hostDlg;

			// Token: 0x0402EA80 RID: 191104
			[Token(Token = "0x402EA80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_hostDlg;

			// Token: 0x0402EA81 RID: 191105
			[Token(Token = "0x402EA81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_input;

			// Token: 0x0402EA82 RID: 191106
			[Token(Token = "0x402EA82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_input;

			// Token: 0x0402EA83 RID: 191107
			[Token(Token = "0x402EA83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_curTime;

			// Token: 0x0402EA84 RID: 191108
			[Token(Token = "0x402EA84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_curTime;

			// Token: 0x0402EA85 RID: 191109
			[Token(Token = "0x402EA85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402EA86 RID: 191110
			[Token(Token = "0x402EA86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x0402EA87 RID: 191111
			[Token(Token = "0x402EA87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_NotifyCurTimeUpdated;

			// Token: 0x0402EA88 RID: 191112
			[Token(Token = "0x402EA88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_DefineSortInfoComparison;

			// Token: 0x0402EA89 RID: 191113
			[Token(Token = "0x402EA89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_DefineFriendSortInfoKeys;

			// Token: 0x0402EA8A RID: 191114
			[Token(Token = "0x402EA8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_HandleFriendNameCardExtraData;

			// Token: 0x0402EA8B RID: 191115
			[Token(Token = "0x402EA8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_ValidateFriendLastOnlineStatus;

			// Token: 0x0402EA8C RID: 191116
			[Token(Token = "0x402EA8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CheckAlreadyInRoom;

			// Token: 0x0402EA8D RID: 191117
			[Token(Token = "0x402EA8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_AddServiceSortKeyActivity;

			// Token: 0x0402EA8E RID: 191118
			[Token(Token = "0x402EA8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005B9B RID: 23451
		[Token(Token = "0x2005B9B")]
		public interface IInviteServiceHandler : UICompDialogMgr.DialogBase.IServiceHandler, IHotfixable
		{
			// Token: 0x0602208C RID: 139404
			[Token(Token = "0x602208C")]
			void InitHandler(CommonInviteDialog.Input input, CommonInviteDialog host);
		}

		// Token: 0x02005B9C RID: 23452
		[Token(Token = "0x2005B9C")]
		public abstract class DlgServiceHandler<TRequest, TResponse> : UICompDialogMgr.DialogBase.ServiceHandler<TRequest, TResponse>, CommonInviteDialog.IInviteServiceHandler, UICompDialogMgr.DialogBase.IServiceHandler, IHotfixable where TResponse : PlayerDeltaResponse
		{
			// Token: 0x17004FA8 RID: 20392
			// (get) Token: 0x0602208D RID: 139405 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602208E RID: 139406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FA8")]
			public string inviteId
			{
				[Token(Token = "0x602208D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602208E")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004FA9 RID: 20393
			// (get) Token: 0x0602208F RID: 139407 RVA: 0x000BC328 File Offset: 0x000BA528
			// (set) Token: 0x06022090 RID: 139408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FA9")]
			public PlayerInviteType inviteType
			{
				[Token(Token = "0x602208F")]
				[CompilerGenerated]
				get
				{
					return PlayerInviteType.ACTIVITY;
				}
				[Token(Token = "0x6022090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004FAA RID: 20394
			// (get) Token: 0x06022091 RID: 139409 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022092 RID: 139410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FAA")]
			private protected CommonInviteDialog hostDlg
			{
				[Token(Token = "0x6022091")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6022092")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06022093 RID: 139411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022093")]
			public void InitHandler(CommonInviteDialog.Input input, CommonInviteDialog host)
			{
			}

			// Token: 0x06022094 RID: 139412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022094")]
			protected DlgServiceHandler()
			{
			}

			// Token: 0x0402EA92 RID: 191122
			[Token(Token = "0x402EA92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_inviteId;

			// Token: 0x0402EA93 RID: 191123
			[Token(Token = "0x402EA93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_inviteId;

			// Token: 0x0402EA94 RID: 191124
			[Token(Token = "0x402EA94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_inviteType;

			// Token: 0x0402EA95 RID: 191125
			[Token(Token = "0x402EA95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_inviteType;

			// Token: 0x0402EA96 RID: 191126
			[Token(Token = "0x402EA96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hostDlg;

			// Token: 0x0402EA97 RID: 191127
			[Token(Token = "0x402EA97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_hostDlg;

			// Token: 0x0402EA98 RID: 191128
			[Token(Token = "0x402EA98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitHandler;

			// Token: 0x0402EA99 RID: 191129
			[Token(Token = "0x402EA99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005B9D RID: 23453
		[Token(Token = "0x2005B9D")]
		public abstract class SortInfoHandler<TRequest, TResponse> : CommonInviteDialog.DlgServiceHandler<TRequest, TResponse> where TResponse : PlayerDeltaResponse
		{
			// Token: 0x06022095 RID: 139413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022095")]
			protected sealed override TRequest GetRequest(ValueBundle param)
			{
				return null;
			}

			// Token: 0x17004FAB RID: 20395
			// (get) Token: 0x06022096 RID: 139414 RVA: 0x000BC340 File Offset: 0x000BA540
			[Token(Token = "0x17004FAB")]
			protected override int serviceLockSignal
			{
				[Token(Token = "0x6022096")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022097 RID: 139415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022097")]
			protected sealed override void OnServiceSuccess(TResponse response)
			{
			}

			// Token: 0x06022098 RID: 139416
			[Token(Token = "0x6022098")]
			protected abstract TRequest GetSortInfoRequest();

			// Token: 0x06022099 RID: 139417
			[Token(Token = "0x6022099")]
			protected abstract List<CommonInviteSortInfo> GenerateFriendIdList(TResponse response);

			// Token: 0x0602209A RID: 139418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602209A")]
			protected SortInfoHandler()
			{
			}

			// Token: 0x0402EA9A RID: 191130
			[Token(Token = "0x402EA9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Comparison<CommonInviteSortInfo> m_comparison;

			// Token: 0x0402EA9B RID: 191131
			[Token(Token = "0x402EA9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetRequest;

			// Token: 0x0402EA9C RID: 191132
			[Token(Token = "0x402EA9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_serviceLockSignal;

			// Token: 0x0402EA9D RID: 191133
			[Token(Token = "0x402EA9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnServiceSuccess;

			// Token: 0x0402EA9E RID: 191134
			[Token(Token = "0x402EA9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005B9E RID: 23454
		[Token(Token = "0x2005B9E")]
		public class FriendListHandler : CommonInviteDialog.DlgServiceHandler<GetFriendListRequest, GetFriendListResponse>
		{
			// Token: 0x17004FAC RID: 20396
			// (get) Token: 0x0602209B RID: 139419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004FAC")]
			public sealed override string serviceCode
			{
				[Token(Token = "0x602209B")]
				[Address(RVA = "0x1C96CF0", Offset = "0x1C958F0", VA = "0x181C96CF0", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004FAD RID: 20397
			// (get) Token: 0x0602209C RID: 139420 RVA: 0x000BC358 File Offset: 0x000BA558
			[Token(Token = "0x17004FAD")]
			protected override int serviceLockSignal
			{
				[Token(Token = "0x602209C")]
				[Address(RVA = "0x1C96D60", Offset = "0x1C95960", VA = "0x181C96D60", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602209D RID: 139421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602209D")]
			[Address(RVA = "0x1C96570", Offset = "0x1C95170", VA = "0x181C96570", Slot = "7")]
			protected override GetFriendListRequest GetRequest(ValueBundle param)
			{
				return null;
			}

			// Token: 0x0602209E RID: 139422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602209E")]
			[Address(RVA = "0x1C96660", Offset = "0x1C95260", VA = "0x181C96660", Slot = "8")]
			protected sealed override void OnServiceSuccess(GetFriendListResponse response)
			{
			}

			// Token: 0x0602209F RID: 139423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602209F")]
			[Address(RVA = "0x1C967F0", Offset = "0x1C953F0", VA = "0x181C967F0")]
			private List<CommonInviteItemDataGroup> _GenerateListData(GetFriendListResponse response)
			{
				return null;
			}

			// Token: 0x060220A0 RID: 139424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220A0")]
			[Address(RVA = "0x1C96C80", Offset = "0x1C95880", VA = "0x181C96C80")]
			public FriendListHandler()
			{
			}

			// Token: 0x0402EA9F RID: 191135
			[Token(Token = "0x402EA9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0402EAA0 RID: 191136
			[Token(Token = "0x402EAA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceLockSignal;

			// Token: 0x0402EAA1 RID: 191137
			[Token(Token = "0x402EAA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetRequest;

			// Token: 0x0402EAA2 RID: 191138
			[Token(Token = "0x402EAA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnServiceSuccess;

			// Token: 0x0402EAA3 RID: 191139
			[Token(Token = "0x402EAA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GenerateListData;

			// Token: 0x0402EAA4 RID: 191140
			[Token(Token = "0x402EAA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005B9F RID: 23455
		[Token(Token = "0x2005B9F")]
		public class InviteHandler : CommonInviteDialog.DlgServiceHandler<InviteRequest, InviteResponse>
		{
			// Token: 0x17004FAE RID: 20398
			// (get) Token: 0x060220A1 RID: 139425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004FAE")]
			public override string serviceCode
			{
				[Token(Token = "0x60220A1")]
				[Address(RVA = "0x1C97230", Offset = "0x1C95E30", VA = "0x181C97230", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004FAF RID: 20399
			// (get) Token: 0x060220A2 RID: 139426 RVA: 0x000BC370 File Offset: 0x000BA570
			[Token(Token = "0x17004FAF")]
			protected override int serviceLockSignal
			{
				[Token(Token = "0x60220A2")]
				[Address(RVA = "0x1C972A0", Offset = "0x1C95EA0", VA = "0x181C972A0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060220A3 RID: 139427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60220A3")]
			[Address(RVA = "0x1C96EB0", Offset = "0x1C95AB0", VA = "0x181C96EB0", Slot = "7")]
			protected sealed override InviteRequest GetRequest(ValueBundle param)
			{
				return null;
			}

			// Token: 0x060220A4 RID: 139428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220A4")]
			[Address(RVA = "0x1C96FE0", Offset = "0x1C95BE0", VA = "0x181C96FE0", Slot = "8")]
			protected sealed override void OnServiceSuccess(InviteResponse response)
			{
			}

			// Token: 0x060220A5 RID: 139429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220A5")]
			[Address(RVA = "0x1C971C0", Offset = "0x1C95DC0", VA = "0x181C971C0")]
			public InviteHandler()
			{
			}

			// Token: 0x0402EAA5 RID: 191141
			[Token(Token = "0x402EAA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string m_cachedUid;

			// Token: 0x0402EAA6 RID: 191142
			[Token(Token = "0x402EAA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0402EAA7 RID: 191143
			[Token(Token = "0x402EAA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceLockSignal;

			// Token: 0x0402EAA8 RID: 191144
			[Token(Token = "0x402EAA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetRequest;

			// Token: 0x0402EAA9 RID: 191145
			[Token(Token = "0x402EAA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnServiceSuccess;

			// Token: 0x0402EAAA RID: 191146
			[Token(Token = "0x402EAAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005BA0 RID: 23456
		[Token(Token = "0x2005BA0")]
		public class ProcessInviteServiceParam
		{
			// Token: 0x060220A6 RID: 139430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220A6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProcessInviteServiceParam()
			{
			}

			// Token: 0x0402EAAB RID: 191147
			[Token(Token = "0x402EAAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0402EAAC RID: 191148
			[Token(Token = "0x402EAAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int idx;

			// Token: 0x0402EAAD RID: 191149
			[Token(Token = "0x402EAAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> msg;

			// Token: 0x0402EAAE RID: 191150
			[Token(Token = "0x402EAAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isAccept;
		}

		// Token: 0x02005BA1 RID: 23457
		[Token(Token = "0x2005BA1")]
		public class ProcessInviteHandler : CommonInviteDialog.DlgServiceHandler<ProcessInviteRequest, ProcessInviteResponse>
		{
			// Token: 0x17004FB0 RID: 20400
			// (get) Token: 0x060220A7 RID: 139431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004FB0")]
			public override string serviceCode
			{
				[Token(Token = "0x60220A7")]
				[Address(RVA = "0x1C98960", Offset = "0x1C97560", VA = "0x181C98960", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004FB1 RID: 20401
			// (get) Token: 0x060220A8 RID: 139432 RVA: 0x000BC388 File Offset: 0x000BA588
			[Token(Token = "0x17004FB1")]
			protected override int serviceLockSignal
			{
				[Token(Token = "0x60220A8")]
				[Address(RVA = "0x1C989D0", Offset = "0x1C975D0", VA = "0x181C989D0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060220A9 RID: 139433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60220A9")]
			[Address(RVA = "0x1C98450", Offset = "0x1C97050", VA = "0x181C98450", Slot = "7")]
			protected sealed override ProcessInviteRequest GetRequest(ValueBundle param)
			{
				return null;
			}

			// Token: 0x060220AA RID: 139434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220AA")]
			[Address(RVA = "0x1C986C0", Offset = "0x1C972C0", VA = "0x181C986C0", Slot = "8")]
			protected sealed override void OnServiceSuccess(ProcessInviteResponse response)
			{
			}

			// Token: 0x060220AB RID: 139435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220AB")]
			[Address(RVA = "0x1C988F0", Offset = "0x1C974F0", VA = "0x181C988F0")]
			public ProcessInviteHandler()
			{
			}

			// Token: 0x0402EAAF RID: 191151
			[Token(Token = "0x402EAAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CommonInviteDialog.ProcessInviteServiceParam m_cachedParam;

			// Token: 0x0402EAB0 RID: 191152
			[Token(Token = "0x402EAB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0402EAB1 RID: 191153
			[Token(Token = "0x402EAB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceLockSignal;

			// Token: 0x0402EAB2 RID: 191154
			[Token(Token = "0x402EAB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetRequest;

			// Token: 0x0402EAB3 RID: 191155
			[Token(Token = "0x402EAB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnServiceSuccess;

			// Token: 0x0402EAB4 RID: 191156
			[Token(Token = "0x402EAB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005BA2 RID: 23458
		[Token(Token = "0x2005BA2")]
		public class InvitedSettingHandler : CommonInviteDialog.DlgServiceHandler<InvitedSettingRequest, InvitedSettingResponse>
		{
			// Token: 0x17004FB2 RID: 20402
			// (get) Token: 0x060220AC RID: 139436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004FB2")]
			public override string serviceCode
			{
				[Token(Token = "0x60220AC")]
				[Address(RVA = "0x1C97550", Offset = "0x1C96150", VA = "0x181C97550", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004FB3 RID: 20403
			// (get) Token: 0x060220AD RID: 139437 RVA: 0x000BC3A0 File Offset: 0x000BA5A0
			[Token(Token = "0x17004FB3")]
			protected override int serviceLockSignal
			{
				[Token(Token = "0x60220AD")]
				[Address(RVA = "0x1C975C0", Offset = "0x1C961C0", VA = "0x181C975C0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060220AE RID: 139438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60220AE")]
			[Address(RVA = "0x1C97300", Offset = "0x1C95F00", VA = "0x181C97300", Slot = "7")]
			protected sealed override InvitedSettingRequest GetRequest(ValueBundle param)
			{
				return null;
			}

			// Token: 0x060220AF RID: 139439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220AF")]
			[Address(RVA = "0x1C97410", Offset = "0x1C96010", VA = "0x181C97410", Slot = "8")]
			protected override void OnServiceSuccess(InvitedSettingResponse response)
			{
			}

			// Token: 0x060220B0 RID: 139440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60220B0")]
			[Address(RVA = "0x1C974E0", Offset = "0x1C960E0", VA = "0x181C974E0")]
			public InvitedSettingHandler()
			{
			}

			// Token: 0x0402EAB5 RID: 191157
			[Token(Token = "0x402EAB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0402EAB6 RID: 191158
			[Token(Token = "0x402EAB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceLockSignal;

			// Token: 0x0402EAB7 RID: 191159
			[Token(Token = "0x402EAB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetRequest;

			// Token: 0x0402EAB8 RID: 191160
			[Token(Token = "0x402EAB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnServiceSuccess;

			// Token: 0x0402EAB9 RID: 191161
			[Token(Token = "0x402EAB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005BA3 RID: 23459
		[Token(Token = "0x2005BA3")]
		public struct DefaultBuildParams
		{
			// Token: 0x0402EABA RID: 191162
			[Token(Token = "0x402EABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UICompDialogMgr dialogMgr;

			// Token: 0x0402EABB RID: 191163
			[Token(Token = "0x402EABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string targetId;

			// Token: 0x0402EABC RID: 191164
			[Token(Token = "0x402EABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerInviteType targetType;

			// Token: 0x0402EABD RID: 191165
			[Token(Token = "0x402EABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public CommonInviteShowType showType;

			// Token: 0x0402EABE RID: 191166
			[Token(Token = "0x402EABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type pluginType;

			// Token: 0x0402EABF RID: 191167
			[Token(Token = "0x402EABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int invitationSendCd;

			// Token: 0x0402EAC0 RID: 191168
			[Token(Token = "0x402EAC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Dictionary<string, long> invitedCache;

			// Token: 0x0402EAC1 RID: 191169
			[Token(Token = "0x402EAC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] excludePlayers;
		}
	}
}
