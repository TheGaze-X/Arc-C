using System;
using Il2CppDummyDll;
using Torappu.Mission;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A4 RID: 18596
	[Token(Token = "0x20048A4")]
	public class MissionPage : StateEnginePage, IValueMsgReceiver, IDialogMgrHolder
	{
		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x0601C0F3 RID: 114931 RVA: 0x000A7178 File Offset: 0x000A5378
		[Token(Token = "0x1700429F")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x601C0F3")]
			[Address(RVA = "0x156C750", Offset = "0x156B350", VA = "0x18156C750", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x0601C0F4 RID: 114932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042A0")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601C0F4")]
			[Address(RVA = "0x156C7B0", Offset = "0x156B3B0", VA = "0x18156C7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C0F5 RID: 114933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C0F5")]
		[Address(RVA = "0x156BA50", Offset = "0x156A650", VA = "0x18156BA50", Slot = "30")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0601C0F6 RID: 114934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0F6")]
		[Address(RVA = "0x156BF30", Offset = "0x156AB30", VA = "0x18156BF30", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601C0F7 RID: 114935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0F7")]
		[Address(RVA = "0x156BAB0", Offset = "0x156A6B0", VA = "0x18156BAB0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601C0F8 RID: 114936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0F8")]
		[Address(RVA = "0x156C5C0", Offset = "0x156B1C0", VA = "0x18156C5C0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0601C0F9 RID: 114937 RVA: 0x000A7190 File Offset: 0x000A5390
		[Token(Token = "0x601C0F9")]
		[Address(RVA = "0x156C4F0", Offset = "0x156B0F0", VA = "0x18156C4F0")]
		private MissionPageType? _LoadInitMissionPageType(DataBundle dataBundle)
		{
			return null;
		}

		// Token: 0x0601C0FA RID: 114938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0FA")]
		[Address(RVA = "0x156BBA0", Offset = "0x156A7A0", VA = "0x18156BBA0", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C0FB RID: 114939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0FB")]
		[Address(RVA = "0x156C1B0", Offset = "0x156ADB0", VA = "0x18156C1B0")]
		private void _EventOnOpenCharShowPage(string charId)
		{
		}

		// Token: 0x0601C0FC RID: 114940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0FC")]
		[Address(RVA = "0x156C3F0", Offset = "0x156AFF0", VA = "0x18156C3F0")]
		private void _EventOnOpenGuideRewardPreview()
		{
		}

		// Token: 0x0601C0FD RID: 114941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0FD")]
		[Address(RVA = "0x156C2F0", Offset = "0x156AEF0", VA = "0x18156C2F0")]
		private void _EventOnOpenFullOpenDialog()
		{
		}

		// Token: 0x0601C0FE RID: 114942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C0FE")]
		[Address(RVA = "0x156B9A0", Offset = "0x156A5A0", VA = "0x18156B9A0")]
		public static DataBundle DataBundleToMissionPage(MissionPageType missionType)
		{
			return null;
		}

		// Token: 0x0601C0FF RID: 114943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0FF")]
		[Address(RVA = "0x156C6F0", Offset = "0x156B2F0", VA = "0x18156C6F0")]
		public MissionPage()
		{
		}

		// Token: 0x0601C101 RID: 114945 RVA: 0x000A71A8 File Offset: 0x000A53A8
		[Token(Token = "0x601C101")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x0601C102 RID: 114946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C102")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601C103 RID: 114947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C103")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04024A56 RID: 150102
		[Token(Token = "0x4024A56")]
		[NonSerialized]
		public const int MSG_OPEN_GUIDE_REWARD_PREVIEW = 1;

		// Token: 0x04024A57 RID: 150103
		[Token(Token = "0x4024A57")]
		[NonSerialized]
		public const int MSG_OPEN_CHAR_SHOW_PAGE = 2;

		// Token: 0x04024A58 RID: 150104
		[Token(Token = "0x4024A58")]
		[NonSerialized]
		public const int MSG_OPEN_FULL_OPEN_DLG = 3;

		// Token: 0x04024A59 RID: 150105
		[Token(Token = "0x4024A59")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04024A5A RID: 150106
		[Token(Token = "0x4024A5A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private MissionState _defaultState;

		// Token: 0x04024A5B RID: 150107
		[Token(Token = "0x4024A5B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04024A5C RID: 150108
		[Token(Token = "0x4024A5C")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04024A5D RID: 150109
		[Token(Token = "0x4024A5D")]
		[FieldOffset(Offset = "0x110")]
		private DataBundle m_dataBundleCache;

		// Token: 0x04024A5E RID: 150110
		[Token(Token = "0x4024A5E")]
		[FieldOffset(Offset = "0x118")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04024A5F RID: 150111
		[Token(Token = "0x4024A5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x04024A60 RID: 150112
		[Token(Token = "0x4024A60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04024A61 RID: 150113
		[Token(Token = "0x4024A61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x04024A62 RID: 150114
		[Token(Token = "0x4024A62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04024A63 RID: 150115
		[Token(Token = "0x4024A63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04024A64 RID: 150116
		[Token(Token = "0x4024A64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x04024A65 RID: 150117
		[Token(Token = "0x4024A65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadInitMissionPageType;

		// Token: 0x04024A66 RID: 150118
		[Token(Token = "0x4024A66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04024A67 RID: 150119
		[Token(Token = "0x4024A67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnOpenCharShowPage;

		// Token: 0x04024A68 RID: 150120
		[Token(Token = "0x4024A68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnOpenGuideRewardPreview;

		// Token: 0x04024A69 RID: 150121
		[Token(Token = "0x4024A69")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnOpenFullOpenDialog;

		// Token: 0x04024A6A RID: 150122
		[Token(Token = "0x4024A6A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DataBundleToMissionPage;

		// Token: 0x04024A6B RID: 150123
		[Token(Token = "0x4024A6B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
