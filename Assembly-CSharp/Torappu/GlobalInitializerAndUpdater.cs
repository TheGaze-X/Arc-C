using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	public class GlobalInitializerAndUpdater : SingletonMonoBehaviour<GlobalInitializerAndUpdater>, ISingletonNotAutoCreate
	{
		// Token: 0x06004EB6 RID: 20150 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		[Token(Token = "0x6004EB6")]
		[Address(RVA = "0x1887450", Offset = "0x1886050", VA = "0x181887450")]
		public bool IsInited()
		{
			return default(bool);
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB7")]
		[Address(RVA = "0x1887680", Offset = "0x1886280", VA = "0x181887680")]
		public static IEnumerator WaitForInitCoroutine([Optional] Action nextStep)
		{
			return null;
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB8")]
		[Address(RVA = "0x1887330", Offset = "0x1885F30", VA = "0x181887330")]
		public static void InvokeWhenInitReadyBeforeWaitingCoroutines(Action action)
		{
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB9")]
		[Address(RVA = "0x1886F30", Offset = "0x1885B30", VA = "0x181886F30", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBA")]
		[Address(RVA = "0x18875C0", Offset = "0x18861C0", VA = "0x1818875C0")]
		private void Update()
		{
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBB")]
		[Address(RVA = "0x18874C0", Offset = "0x18860C0", VA = "0x1818874C0")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBC")]
		[Address(RVA = "0x1887810", Offset = "0x1886410", VA = "0x181887810")]
		private void _DoInitInAwake()
		{
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x1888770", Offset = "0x1887370", VA = "0x181888770")]
		private static void _SetInstanceToBaseAssemblies(GlobalInitializerAndUpdater inst)
		{
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x1888600", Offset = "0x1887200", VA = "0x181888600")]
		private static void _RegisterGlobalListeners()
		{
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x1888710", Offset = "0x1887310", VA = "0x181888710")]
		private static void _SetGraphicTierByPlatform()
		{
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC0")]
		[Address(RVA = "0x18882A0", Offset = "0x1886EA0", VA = "0x1818882A0")]
		private static void _LoadInitialAssetsImpl(bool isInitLoad)
		{
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC1")]
		[Address(RVA = "0x1887540", Offset = "0x1886140", VA = "0x181887540")]
		public static void ReloadInitialAssets()
		{
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x1887190", Offset = "0x1885D90", VA = "0x181887190")]
		public IEnumerator DoReloadAllMainAssets(GameFlowController.Options options)
		{
			return null;
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0x1887740", Offset = "0x1886340", VA = "0x181887740")]
		public IEnumerator WaitForSceneResReady(string targetScene)
		{
			return null;
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0x1887D20", Offset = "0x1886920", VA = "0x181887D20")]
		private static IEnumerator _ForceUnloadAllAssetsEvenUsed()
		{
			return null;
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x1888680", Offset = "0x1887280", VA = "0x181888680")]
		private static void _ReloadRuntimeModulesAfterUnloadAll()
		{
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x1887280", Offset = "0x1885E80", VA = "0x181887280")]
		public static IEnumerator ForceUnloadAllEvenUsedAndReloadRuntimeModules()
		{
			return null;
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x1887DD0", Offset = "0x18869D0", VA = "0x181887DD0")]
		private void _InitAPPDefaultCulture()
		{
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x1888B30", Offset = "0x1887730", VA = "0x181888B30")]
		private Coroutine _StartCorotuine(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x1888CA0", Offset = "0x18878A0", VA = "0x181888CA0")]
		public GlobalInitializerAndUpdater()
		{
		}

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] ASYNC_LOADING_SCENES;

		// Token: 0x040012E3 RID: 4835
		[Token(Token = "0x40012E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isInited;

		// Token: 0x040012E4 RID: 4836
		[Token(Token = "0x40012E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Action> m_actionsWhenInited;

		// Token: 0x040012E5 RID: 4837
		[Token(Token = "0x40012E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsInited;

		// Token: 0x040012E6 RID: 4838
		[Token(Token = "0x40012E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WaitForInitCoroutine;

		// Token: 0x040012E7 RID: 4839
		[Token(Token = "0x40012E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InvokeWhenInitReadyBeforeWaitingCoroutines;

		// Token: 0x040012E8 RID: 4840
		[Token(Token = "0x40012E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040012E9 RID: 4841
		[Token(Token = "0x40012E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040012EA RID: 4842
		[Token(Token = "0x40012EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnApplicationQuit;

		// Token: 0x040012EB RID: 4843
		[Token(Token = "0x40012EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoInitInAwake;

		// Token: 0x040012EC RID: 4844
		[Token(Token = "0x40012EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetInstanceToBaseAssemblies;

		// Token: 0x040012ED RID: 4845
		[Token(Token = "0x40012ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RegisterGlobalListeners;

		// Token: 0x040012EE RID: 4846
		[Token(Token = "0x40012EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetGraphicTierByPlatform;

		// Token: 0x040012EF RID: 4847
		[Token(Token = "0x40012EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadInitialAssetsImpl;

		// Token: 0x040012F0 RID: 4848
		[Token(Token = "0x40012F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ReloadInitialAssets;

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoReloadAllMainAssets;

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_WaitForSceneResReady;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ForceUnloadAllAssetsEvenUsed;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ReloadRuntimeModulesAfterUnloadAll;

		// Token: 0x040012F5 RID: 4853
		[Token(Token = "0x40012F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ForceUnloadAllEvenUsedAndReloadRuntimeModules;

		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitAPPDefaultCulture;

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__StartCorotuine;

		// Token: 0x040012F8 RID: 4856
		[Token(Token = "0x40012F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
