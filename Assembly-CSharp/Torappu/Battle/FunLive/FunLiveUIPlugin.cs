using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x02002694 RID: 9876
	[Token(Token = "0x2002694")]
	public class FunLiveUIPlugin : UIController.Plugin
	{
		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x06010217 RID: 66071 RVA: 0x000625C8 File Offset: 0x000607C8
		[Token(Token = "0x17002325")]
		public int PhotoTotalCnt
		{
			[Token(Token = "0x6010217")]
			[Address(RVA = "0x7EB800", Offset = "0x7EA400", VA = "0x1807EB800")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06010218 RID: 66072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010218")]
		[Address(RVA = "0x7EAE80", Offset = "0x7E9A80", VA = "0x1807EAE80", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06010219 RID: 66073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010219")]
		[Address(RVA = "0x7EB040", Offset = "0x7E9C40", VA = "0x1807EB040", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601021A RID: 66074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601021A")]
		[Address(RVA = "0x7EADC0", Offset = "0x7E99C0", VA = "0x1807EADC0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x0601021B RID: 66075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601021B")]
		[Address(RVA = "0x7EB460", Offset = "0x7EA060", VA = "0x1807EB460", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x0601021C RID: 66076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601021C")]
		[Address(RVA = "0x7EB2F0", Offset = "0x7E9EF0", VA = "0x1807EB2F0", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x0601021D RID: 66077 RVA: 0x000625E0 File Offset: 0x000607E0
		[Token(Token = "0x601021D")]
		[Address(RVA = "0x7EACE0", Offset = "0x7E98E0", VA = "0x1807EACE0", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601021E RID: 66078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601021E")]
		[Address(RVA = "0x7EB550", Offset = "0x7EA150", VA = "0x1807EB550")]
		private void _HookUITopBar()
		{
		}

		// Token: 0x0601021F RID: 66079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601021F")]
		[Address(RVA = "0x7EB1C0", Offset = "0x7E9DC0", VA = "0x1807EB1C0")]
		public void OnPhotoLibraryButtonClicked()
		{
		}

		// Token: 0x06010220 RID: 66080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010220")]
		[Address(RVA = "0x7EAAA0", Offset = "0x7E96A0", VA = "0x1807EAAA0")]
		public void CloseSystemMenuPanel()
		{
		}

		// Token: 0x06010221 RID: 66081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010221")]
		[Address(RVA = "0x7EA9F0", Offset = "0x7E95F0", VA = "0x1807EA9F0")]
		public void ClosePhotoLibraryPanel()
		{
		}

		// Token: 0x06010222 RID: 66082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010222")]
		[Address(RVA = "0x7EAB50", Offset = "0x7E9750", VA = "0x1807EAB50")]
		public void FinishGameDirectly()
		{
		}

		// Token: 0x06010223 RID: 66083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010223")]
		[Address(RVA = "0x7EAC00", Offset = "0x7E9800", VA = "0x1807EAC00")]
		public void FinishGameWhenTimeOut()
		{
		}

		// Token: 0x06010224 RID: 66084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010224")]
		[Address(RVA = "0x7EB760", Offset = "0x7EA360", VA = "0x1807EB760")]
		public FunLiveUIPlugin()
		{
		}

		// Token: 0x06010226 RID: 66086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010226")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06010227 RID: 66087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010227")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06010228 RID: 66088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010228")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06010229 RID: 66089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010229")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0601022A RID: 66090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601022A")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x0601022B RID: 66091 RVA: 0x000625F8 File Offset: 0x000607F8
		[Token(Token = "0x601022B")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x04011F9D RID: 73629
		[Token(Token = "0x4011F9D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_SYSTEM_MENU;

		// Token: 0x04011F9E RID: 73630
		[Token(Token = "0x4011F9E")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIStateEnum UI_STATE_PHOTO_LIBRARY;

		// Token: 0x04011F9F RID: 73631
		[Token(Token = "0x4011F9F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIStateEnum UI_STATE_ACCOMPLISHED;

		// Token: 0x04011FA0 RID: 73632
		[Token(Token = "0x4011FA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("TopBar")]
		private FunLiveUIBattleTopBar _funliveTopbarStatus;

		// Token: 0x04011FA1 RID: 73633
		[Token(Token = "0x4011FA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("AccomplishedPanel")]
		private Transform _battleAccomplishedPanel;

		// Token: 0x04011FA2 RID: 73634
		[Token(Token = "0x4011FA2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIBattleBlurPanel _blurPanel;

		// Token: 0x04011FA3 RID: 73635
		[Token(Token = "0x4011FA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04011FA4 RID: 73636
		[Token(Token = "0x4011FA4")]
		[FieldOffset(Offset = "0x48")]
		private FunLiveUIBattleTopBar m_curTopbarStatus;

		// Token: 0x04011FA5 RID: 73637
		[Token(Token = "0x4011FA5")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.FunLiveGameMode m_gameMode;

		// Token: 0x04011FA6 RID: 73638
		[Token(Token = "0x4011FA6")]
		[FieldOffset(Offset = "0x58")]
		private int m_photoTotalCnt;

		// Token: 0x04011FA7 RID: 73639
		[Token(Token = "0x4011FA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_PhotoTotalCnt;

		// Token: 0x04011FA8 RID: 73640
		[Token(Token = "0x4011FA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04011FA9 RID: 73641
		[Token(Token = "0x4011FA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04011FAA RID: 73642
		[Token(Token = "0x4011FAA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04011FAB RID: 73643
		[Token(Token = "0x4011FAB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04011FAC RID: 73644
		[Token(Token = "0x4011FAC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04011FAD RID: 73645
		[Token(Token = "0x4011FAD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x04011FAE RID: 73646
		[Token(Token = "0x4011FAE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HookUITopBar;

		// Token: 0x04011FAF RID: 73647
		[Token(Token = "0x4011FAF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPhotoLibraryButtonClicked;

		// Token: 0x04011FB0 RID: 73648
		[Token(Token = "0x4011FB0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CloseSystemMenuPanel;

		// Token: 0x04011FB1 RID: 73649
		[Token(Token = "0x4011FB1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ClosePhotoLibraryPanel;

		// Token: 0x04011FB2 RID: 73650
		[Token(Token = "0x4011FB2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FinishGameDirectly;

		// Token: 0x04011FB3 RID: 73651
		[Token(Token = "0x4011FB3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_FinishGameWhenTimeOut;

		// Token: 0x04011FB4 RID: 73652
		[Token(Token = "0x4011FB4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
