using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace U8.SDK
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public class U8SDKCallback : MonoBehaviour
	{
		// Token: 0x0600028C RID: 652 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4A232F0", Offset = "0x4A21EF0", VA = "0x184A232F0")]
		public static U8SDKCallback InitCallback()
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4A23A10", Offset = "0x4A22610", VA = "0x184A23A10")]
		public void OnInitSuc(string extConfigs)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x4A23960", Offset = "0x4A22560", VA = "0x184A23960")]
		public void OnInitFail(string info)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4A23B70", Offset = "0x4A22770", VA = "0x184A23B70")]
		public void OnLoginSuc(string extension)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x4A23AC0", Offset = "0x4A226C0", VA = "0x184A23AC0")]
		public void OnLoginFail(string info)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4A23C20", Offset = "0x4A22820", VA = "0x184A23C20")]
		public void OnLogout(string info)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4A23FF0", Offset = "0x4A22BF0", VA = "0x184A23FF0")]
		public void OnSwitchAccount()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4A23E00", Offset = "0x4A22A00", VA = "0x184A23E00")]
		public void OnPaySuc(string jsonData)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4A23CD0", Offset = "0x4A228D0", VA = "0x184A23CD0")]
		public void OnPayFail(string failMsg)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4A23F30", Offset = "0x4A22B30", VA = "0x184A23F30")]
		public void OnSDKError(string jsonData)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4A235E0", Offset = "0x4A221E0", VA = "0x184A235E0")]
		public void OnExtraInfo(string jsonData)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4A24140", Offset = "0x4A22D40", VA = "0x184A24140")]
		private IEnumerator _onLogoutNextFrameCoroutine()
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000298")]
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, [Optional] T defVal)
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public U8SDKCallback()
		{
		}

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static U8SDKCallback m_instance;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object m_lock;
	}
}
