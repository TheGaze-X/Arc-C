using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200259C RID: 9628
	[Token(Token = "0x200259C")]
	public class KeepInBattleLoaderRoot : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600F82C RID: 63532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82C")]
		[Address(RVA = "0x70F6B0", Offset = "0x70E2B0", VA = "0x18070F6B0")]
		private void Start()
		{
		}

		// Token: 0x0600F82D RID: 63533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82D")]
		[Address(RVA = "0x70F600", Offset = "0x70E200", VA = "0x18070F600")]
		private void OnEnable()
		{
		}

		// Token: 0x0600F82E RID: 63534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82E")]
		[Address(RVA = "0x70F550", Offset = "0x70E150", VA = "0x18070F550")]
		private void OnDisable()
		{
		}

		// Token: 0x0600F82F RID: 63535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82F")]
		[Address(RVA = "0x70FB20", Offset = "0x70E720", VA = "0x18070FB20")]
		private void _OnSceneUnloaded(Scene theUnloadScene)
		{
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F830")]
		[Address(RVA = "0x70F9D0", Offset = "0x70E5D0", VA = "0x18070F9D0")]
		private void _DisableAdditionalEventSystem()
		{
		}

		// Token: 0x0600F831 RID: 63537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F831")]
		[Address(RVA = "0x70F920", Offset = "0x70E520", VA = "0x18070F920")]
		private IEnumerator _BindToDisposerCoroutine()
		{
			return null;
		}

		// Token: 0x0600F832 RID: 63538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F832")]
		[Address(RVA = "0x70FC50", Offset = "0x70E850", VA = "0x18070FC50")]
		public KeepInBattleLoaderRoot()
		{
		}

		// Token: 0x040113CB RID: 70603
		[Token(Token = "0x40113CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040113CC RID: 70604
		[Token(Token = "0x40113CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x040113CD RID: 70605
		[Token(Token = "0x40113CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x040113CE RID: 70606
		[Token(Token = "0x40113CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSceneUnloaded;

		// Token: 0x040113CF RID: 70607
		[Token(Token = "0x40113CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DisableAdditionalEventSystem;

		// Token: 0x040113D0 RID: 70608
		[Token(Token = "0x40113D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BindToDisposerCoroutine;

		// Token: 0x040113D1 RID: 70609
		[Token(Token = "0x40113D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
