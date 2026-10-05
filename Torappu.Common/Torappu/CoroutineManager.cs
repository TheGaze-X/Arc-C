using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class CoroutineManager : LazySingleton<CoroutineManager>, IDisposable
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x54DB960", Offset = "0x54DA560", VA = "0x1854DB960")]
		private CoroutineManager(MonoBehaviour host)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x54DB3A0", Offset = "0x54D9FA0", VA = "0x1854DB3A0")]
		public static void CreateInstance(MonoBehaviour host)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x54DB5B0", Offset = "0x54DA1B0", VA = "0x1854DB5B0")]
		public static void StartCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x54DB720", Offset = "0x54DA320", VA = "0x1854DB720")]
		public static void StopCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x54DB670", Offset = "0x54DA270", VA = "0x1854DB670")]
		public static void StopCoroutineNested(IEnumerator routine)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x54DB4E0", Offset = "0x54DA0E0", VA = "0x1854DB4E0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x54DB7E0", Offset = "0x54DA3E0", VA = "0x1854DB7E0")]
		private static MonoBehaviour _CheckHost()
		{
			return null;
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private MonoBehaviour m_host;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate0 _c__Hotfix0_ctor;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_CreateInstance;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StartCoroutine;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StopCoroutine;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StopCoroutineNested;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate2 __Hotfix0__CheckHost;
	}
}
