using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040BA RID: 16570
	[Token(Token = "0x20040BA")]
	public class SandboxV2AdminMainState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06019A21 RID: 104993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A21")]
		[Address(RVA = "0x1286E20", Offset = "0x1285A20", VA = "0x181286E20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019A22 RID: 104994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A22")]
		[Address(RVA = "0x1287220", Offset = "0x1285E20", VA = "0x181287220", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019A23 RID: 104995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A23")]
		[Address(RVA = "0x1287280", Offset = "0x1285E80", VA = "0x181287280", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06019A24 RID: 104996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A24")]
		[Address(RVA = "0x1287410", Offset = "0x1286010", VA = "0x181287410", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06019A25 RID: 104997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A25")]
		[Address(RVA = "0x12889C0", Offset = "0x12875C0", VA = "0x1812889C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A26 RID: 104998 RVA: 0x0009EE68 File Offset: 0x0009D068
		[Token(Token = "0x6019A26")]
		[Address(RVA = "0x12869F0", Offset = "0x12855F0", VA = "0x1812869F0")]
		public bool CheckCurrentTabPanel(SandboxV2AdminMainTabPanel tabPanel)
		{
			return default(bool);
		}

		// Token: 0x06019A27 RID: 104999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A27")]
		public T GetTabPanelInitParam<T>(bool notNull) where T : class, ISandboxV2AdminMainTabPanelInitParam, new()
		{
			return null;
		}

		// Token: 0x06019A28 RID: 105000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A28")]
		[Address(RVA = "0x1287A70", Offset = "0x1286670", VA = "0x181287A70")]
		public void RefreshPanelActiveState()
		{
		}

		// Token: 0x06019A29 RID: 105001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A29")]
		[Address(RVA = "0x1287500", Offset = "0x1286100", VA = "0x181287500")]
		public void OpenCookDialog(SandboxV2CookFoodDialog.Options options)
		{
		}

		// Token: 0x06019A2A RID: 105002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A2A")]
		[Address(RVA = "0x12876D0", Offset = "0x12862D0", VA = "0x1812876D0")]
		public void OpenRecipeMasteryDialog(SandboxV2RecipeMasteryDialog.Options options)
		{
		}

		// Token: 0x06019A2B RID: 105003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A2B")]
		[Address(RVA = "0x12878A0", Offset = "0x12864A0", VA = "0x1812878A0")]
		public void OpenWorkbenchDialog(SandboxV2WorkbenchMakeDialog.Options options)
		{
		}

		// Token: 0x06019A2C RID: 105004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A2C")]
		[Address(RVA = "0x1286E80", Offset = "0x1285A80", VA = "0x181286E80")]
		public void HandleBack()
		{
		}

		// Token: 0x06019A2D RID: 105005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A2D")]
		[Address(RVA = "0x1288210", Offset = "0x1286E10", VA = "0x181288210")]
		public void SwitchPanel(SandboxV2AdminMainPanelType panelType)
		{
		}

		// Token: 0x06019A2E RID: 105006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A2E")]
		[Address(RVA = "0x1286B10", Offset = "0x1285710", VA = "0x181286B10")]
		public void DoPanelHideProcess(Action done)
		{
		}

		// Token: 0x06019A2F RID: 105007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A2F")]
		[Address(RVA = "0x1288380", Offset = "0x1286F80", VA = "0x181288380")]
		private SandboxV2AdminMainTabPanel _FindPanel(SandboxV2AdminMainPanelType pt)
		{
			return null;
		}

		// Token: 0x06019A30 RID: 105008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A30")]
		[Address(RVA = "0x1287ED0", Offset = "0x1286AD0", VA = "0x181287ED0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019A31 RID: 105009 RVA: 0x0009EE80 File Offset: 0x0009D080
		[Token(Token = "0x6019A31")]
		[Address(RVA = "0x1288310", Offset = "0x1286F10", VA = "0x181288310", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06019A32 RID: 105010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A32")]
		[Address(RVA = "0x1287B90", Offset = "0x1286790", VA = "0x181287B90", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06019A33 RID: 105011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A33")]
		[Address(RVA = "0x1286F30", Offset = "0x1285B30", VA = "0x181286F30", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06019A34 RID: 105012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A34")]
		[Address(RVA = "0x12884D0", Offset = "0x12870D0", VA = "0x1812884D0")]
		private void _HandleCookCallback(ValueBundle output)
		{
		}

		// Token: 0x06019A35 RID: 105013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A35")]
		[Address(RVA = "0x12885D0", Offset = "0x12871D0", VA = "0x1812885D0")]
		private void _HandleRecipeMasteryCallback(ValueBundle output)
		{
		}

		// Token: 0x06019A36 RID: 105014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A36")]
		[Address(RVA = "0x12888C0", Offset = "0x12874C0", VA = "0x1812888C0")]
		private void _HandleWorkbenchCallback(ValueBundle output)
		{
		}

		// Token: 0x06019A37 RID: 105015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A37")]
		[Address(RVA = "0x1289240", Offset = "0x1287E40", VA = "0x181289240")]
		private void _ResumeFromDialog()
		{
		}

		// Token: 0x06019A38 RID: 105016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A38")]
		[Address(RVA = "0x1287360", Offset = "0x1285F60", VA = "0x181287360", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019A39 RID: 105017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A39")]
		[Address(RVA = "0x1289040", Offset = "0x1287C40", VA = "0x181289040")]
		private void _OnOpenRacingInfo()
		{
		}

		// Token: 0x06019A3A RID: 105018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A3A")]
		[Address(RVA = "0x12893D0", Offset = "0x1287FD0", VA = "0x1812893D0")]
		private void _TutorialOnly_CheckSignalToRaise()
		{
		}

		// Token: 0x06019A3B RID: 105019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A3B")]
		[Address(RVA = "0x12895B0", Offset = "0x12881B0", VA = "0x1812895B0")]
		private IEnumerator _TutorialOnly_RaiseSignalWhenFinishTransiting(Action signalAction)
		{
			return null;
		}

		// Token: 0x06019A3C RID: 105020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A3C")]
		[Address(RVA = "0x12892F0", Offset = "0x1287EF0", VA = "0x1812892F0")]
		private void _StopCoroutineIfNeed()
		{
		}

		// Token: 0x06019A3D RID: 105021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A3D")]
		[Address(RVA = "0x12871C0", Offset = "0x1285DC0", VA = "0x1812871C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019A3E RID: 105022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A3E")]
		[Address(RVA = "0x1289680", Offset = "0x1288280", VA = "0x181289680")]
		public SandboxV2AdminMainState()
		{
		}

		// Token: 0x06019A40 RID: 105024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A40")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019A41 RID: 105025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A41")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06019A42 RID: 105026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A42")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019A43 RID: 105027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A43")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019A44 RID: 105028 RVA: 0x0009EE98 File Offset: 0x0009D098
		[Token(Token = "0x6019A44")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06019A45 RID: 105029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A45")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04020071 RID: 131185
		[Token(Token = "0x4020071")]
		[NonSerialized]
		public const int MSG_OPEN_RACING_INFO = 0;

		// Token: 0x04020072 RID: 131186
		[Token(Token = "0x4020072")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _tabPanelContainer;

		// Token: 0x04020073 RID: 131187
		[Token(Token = "0x4020073")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2AdminMainTabPanelDefinedList _definedTabPanels;

		// Token: 0x04020074 RID: 131188
		[Token(Token = "0x4020074")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2AdminMainViewDef[] _viewDefList;

		// Token: 0x04020075 RID: 131189
		[Token(Token = "0x4020075")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _singleMode;

		// Token: 0x04020076 RID: 131190
		[Token(Token = "0x4020076")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2AdminMainModelProperty m_prop;

		// Token: 0x04020077 RID: 131191
		[Token(Token = "0x4020077")]
		[FieldOffset(Offset = "0x98")]
		private List<SandboxV2AdminMainTabPanel> m_tabPanels;

		// Token: 0x04020078 RID: 131192
		[Token(Token = "0x4020078")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inHideProcess;

		// Token: 0x04020079 RID: 131193
		[Token(Token = "0x4020079")]
		[FieldOffset(Offset = "0xA4")]
		private int m_cookDialogInst;

		// Token: 0x0402007A RID: 131194
		[Token(Token = "0x402007A")]
		[FieldOffset(Offset = "0xA8")]
		private int m_recipeMasteryDialogInst;

		// Token: 0x0402007B RID: 131195
		[Token(Token = "0x402007B")]
		[FieldOffset(Offset = "0xAC")]
		private int m_workbenchMakeDialogInst;

		// Token: 0x0402007C RID: 131196
		[Token(Token = "0x402007C")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine m_tutorialRaisingCoroutine;

		// Token: 0x0402007D RID: 131197
		[Token(Token = "0x402007D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402007E RID: 131198
		[Token(Token = "0x402007E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402007F RID: 131199
		[Token(Token = "0x402007F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04020080 RID: 131200
		[Token(Token = "0x4020080")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020081 RID: 131201
		[Token(Token = "0x4020081")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020082 RID: 131202
		[Token(Token = "0x4020082")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckCurrentTabPanel;

		// Token: 0x04020083 RID: 131203
		[Token(Token = "0x4020083")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTabPanelInitParam;

		// Token: 0x04020084 RID: 131204
		[Token(Token = "0x4020084")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshPanelActiveState;

		// Token: 0x04020085 RID: 131205
		[Token(Token = "0x4020085")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OpenCookDialog;

		// Token: 0x04020086 RID: 131206
		[Token(Token = "0x4020086")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OpenRecipeMasteryDialog;

		// Token: 0x04020087 RID: 131207
		[Token(Token = "0x4020087")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OpenWorkbenchDialog;

		// Token: 0x04020088 RID: 131208
		[Token(Token = "0x4020088")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HandleBack;

		// Token: 0x04020089 RID: 131209
		[Token(Token = "0x4020089")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SwitchPanel;

		// Token: 0x0402008A RID: 131210
		[Token(Token = "0x402008A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoPanelHideProcess;

		// Token: 0x0402008B RID: 131211
		[Token(Token = "0x402008B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FindPanel;

		// Token: 0x0402008C RID: 131212
		[Token(Token = "0x402008C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402008D RID: 131213
		[Token(Token = "0x402008D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0402008E RID: 131214
		[Token(Token = "0x402008E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0402008F RID: 131215
		[Token(Token = "0x402008F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04020090 RID: 131216
		[Token(Token = "0x4020090")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleCookCallback;

		// Token: 0x04020091 RID: 131217
		[Token(Token = "0x4020091")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleRecipeMasteryCallback;

		// Token: 0x04020092 RID: 131218
		[Token(Token = "0x4020092")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleWorkbenchCallback;

		// Token: 0x04020093 RID: 131219
		[Token(Token = "0x4020093")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ResumeFromDialog;

		// Token: 0x04020094 RID: 131220
		[Token(Token = "0x4020094")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020095 RID: 131221
		[Token(Token = "0x4020095")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnOpenRacingInfo;

		// Token: 0x04020096 RID: 131222
		[Token(Token = "0x4020096")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TutorialOnly_CheckSignalToRaise;

		// Token: 0x04020097 RID: 131223
		[Token(Token = "0x4020097")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RaiseSignalWhenFinishTransiting;

		// Token: 0x04020098 RID: 131224
		[Token(Token = "0x4020098")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__StopCoroutineIfNeed;

		// Token: 0x04020099 RID: 131225
		[Token(Token = "0x4020099")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402009A RID: 131226
		[Token(Token = "0x402009A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
