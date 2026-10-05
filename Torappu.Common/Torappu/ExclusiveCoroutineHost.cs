using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public class ExclusiveCoroutineHost : IDisposable, IHotfixable
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x54FCC50", Offset = "0x54FB850", VA = "0x1854FCC50")]
		public ExclusiveCoroutineHost(Func<MonoBehaviour> lazyHostGetter)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x54FC740", Offset = "0x54FB340", VA = "0x1854FC740")]
		public void ExclusiveCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x54FCA10", Offset = "0x54FB610", VA = "0x1854FCA10")]
		public void StopCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x54FCA90", Offset = "0x54FB690", VA = "0x1854FCA90")]
		public void StopCurrent()
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x54FC920", Offset = "0x54FB520", VA = "0x1854FC920")]
		public bool ForgetCurrent()
		{
			return default(bool);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x54FCB90", Offset = "0x54FB790", VA = "0x1854FCB90")]
		private void _StopCoroutineInternal(IEnumerator routine)
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x54FC620", Offset = "0x54FB220", VA = "0x1854FC620", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isDisposed;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x18")]
		private MonoBehaviour m_host;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x20")]
		private Func<MonoBehaviour> m_hostGetter;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x28")]
		private WeakReference m_routineRef;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate0 _c__Hotfix0_ctor;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate0 __Hotfix0_ExclusiveCoroutine;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_StopCoroutine;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StopCurrent;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_ForgetCurrent;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate0 __Hotfix0__StopCoroutineInternal;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;
	}
}
