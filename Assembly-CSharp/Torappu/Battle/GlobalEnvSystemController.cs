using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022B1 RID: 8881
	[Token(Token = "0x20022B1")]
	public class GlobalEnvSystemController : IHotfixable, IDisposable
	{
		// Token: 0x0600DF34 RID: 57140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF34")]
		[Address(RVA = "0x36579C0", Offset = "0x36565C0", VA = "0x1836579C0")]
		public void InitIfNot(Func<string, GlobalEnvSystem> envSysLoader)
		{
		}

		// Token: 0x0600DF35 RID: 57141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF35")]
		[Address(RVA = "0x3657400", Offset = "0x3656000", VA = "0x183657400")]
		public void CreateAndInitGlobalEnvSystem(IList<GlobalEnvSystemData> globalEnvSystemData)
		{
		}

		// Token: 0x0600DF36 RID: 57142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF36")]
		[Address(RVA = "0x3657A40", Offset = "0x3656640", VA = "0x183657A40")]
		public void PostInit()
		{
		}

		// Token: 0x0600DF37 RID: 57143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF37")]
		[Address(RVA = "0x3657D90", Offset = "0x3656990", VA = "0x183657D90")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x0600DF38 RID: 57144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF38")]
		[Address(RVA = "0x3657BC0", Offset = "0x36567C0", VA = "0x183657BC0")]
		public void RemoveAll()
		{
		}

		// Token: 0x0600DF39 RID: 57145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF39")]
		[Address(RVA = "0x3657610", Offset = "0x3656210", VA = "0x183657610", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600DF3A RID: 57146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF3A")]
		[Address(RVA = "0x36576A0", Offset = "0x36562A0", VA = "0x1836576A0")]
		public GlobalEnvSystem GetEnvSystemByKey(string key, bool tryRuntimeLoad = false, [Optional] Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x0600DF3B RID: 57147 RVA: 0x000511B0 File Offset: 0x0004F3B0
		[Token(Token = "0x600DF3B")]
		[Address(RVA = "0x3658310", Offset = "0x3656F10", VA = "0x183658310")]
		public bool TryGetEnvSystemByKey(string key, out GlobalEnvSystem envSystem)
		{
			return default(bool);
		}

		// Token: 0x0600DF3C RID: 57148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF3C")]
		public T GetEnvSystemManager<T>() where T : GlobalEnvSystem.EnvManager
		{
			return null;
		}

		// Token: 0x0600DF3D RID: 57149 RVA: 0x000511C8 File Offset: 0x0004F3C8
		[Token(Token = "0x600DF3D")]
		public bool TryGetEnvSystemManagerByKey<T>(string key, out T manager) where T : GlobalEnvSystem.EnvManager
		{
			return default(bool);
		}

		// Token: 0x0600DF3E RID: 57150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF3E")]
		public T GetEnvSystemManagerByKey<T>(string key, bool allowRuntimeLoad = false) where T : GlobalEnvSystem.EnvManager
		{
			return null;
		}

		// Token: 0x0600DF3F RID: 57151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF3F")]
		[Address(RVA = "0x3658550", Offset = "0x3657150", VA = "0x183658550")]
		private GlobalEnvSystem _RuntimeCreateAndInitGlobalEnvSystem(string prefabKey, Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x0600DF40 RID: 57152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF40")]
		[Address(RVA = "0x36583C0", Offset = "0x3656FC0", VA = "0x1836583C0")]
		private GlobalEnvSystem _CreateAndInitGlobalEnvSystem(GlobalEnvSystemData envSystemData)
		{
			return null;
		}

		// Token: 0x0600DF41 RID: 57153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF41")]
		[Address(RVA = "0x36586C0", Offset = "0x36572C0", VA = "0x1836586C0")]
		public GlobalEnvSystemController()
		{
		}

		// Token: 0x0400F268 RID: 62056
		[Token(Token = "0x400F268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, GlobalEnvSystem> m_globalEnvSystems;

		// Token: 0x0400F269 RID: 62057
		[Token(Token = "0x400F269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<GlobalEnvSystem> m_globalEnvSystemsTickList;

		// Token: 0x0400F26A RID: 62058
		[Token(Token = "0x400F26A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<string, GlobalEnvSystem> m_envSystemLoader;

		// Token: 0x0400F26B RID: 62059
		[Token(Token = "0x400F26B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0400F26C RID: 62060
		[Token(Token = "0x400F26C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0400F26D RID: 62061
		[Token(Token = "0x400F26D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateAndInitGlobalEnvSystem;

		// Token: 0x0400F26E RID: 62062
		[Token(Token = "0x400F26E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PostInit;

		// Token: 0x0400F26F RID: 62063
		[Token(Token = "0x400F26F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0400F270 RID: 62064
		[Token(Token = "0x400F270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RemoveAll;

		// Token: 0x0400F271 RID: 62065
		[Token(Token = "0x400F271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400F272 RID: 62066
		[Token(Token = "0x400F272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEnvSystemByKey;

		// Token: 0x0400F273 RID: 62067
		[Token(Token = "0x400F273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetEnvSystemByKey;

		// Token: 0x0400F274 RID: 62068
		[Token(Token = "0x400F274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEnvSystemManager;

		// Token: 0x0400F275 RID: 62069
		[Token(Token = "0x400F275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetEnvSystemManagerByKey;

		// Token: 0x0400F276 RID: 62070
		[Token(Token = "0x400F276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetEnvSystemManagerByKey;

		// Token: 0x0400F277 RID: 62071
		[Token(Token = "0x400F277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RuntimeCreateAndInitGlobalEnvSystem;

		// Token: 0x0400F278 RID: 62072
		[Token(Token = "0x400F278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateAndInitGlobalEnvSystem;

		// Token: 0x0400F279 RID: 62073
		[Token(Token = "0x400F279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
