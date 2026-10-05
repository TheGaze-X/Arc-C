using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class YoSDKCallBack : MonoBehaviour
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		private YoSDKCallBack()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public static YoSDKCallBack Instance
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x5BF9AE0", Offset = "0x5BF86E0", VA = "0x185BF9AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x5BF88B0", Offset = "0x5BF74B0", VA = "0x185BF88B0")]
		public void Init()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5BF8610", Offset = "0x5BF7210", VA = "0x185BF8610")]
		public string CallBack(string strJson)
		{
			return null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x5BF9540", Offset = "0x5BF8140", VA = "0x185BF9540")]
		private void Update()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		private T ParseJson<T>(string strJson) where T : new()
		{
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x5BF8A40", Offset = "0x5BF7640", VA = "0x185BF8A40")]
		public void OnInitNotify(string jsonRet)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5BF8B20", Offset = "0x5BF7720", VA = "0x185BF8B20")]
		public void OnLoginNotify(string jsonRet)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x5BF8B90", Offset = "0x5BF7790", VA = "0x185BF8B90")]
		public void OnLogoutNotify(string jsonRet)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5BF8C00", Offset = "0x5BF7800", VA = "0x185BF8C00")]
		public void OnPayNotify(string jsonRet)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5BF93F0", Offset = "0x5BF7FF0", VA = "0x185BF93F0")]
		public void OnSystemShareNotify(string jsonRet)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5BF88F0", Offset = "0x5BF74F0", VA = "0x185BF88F0")]
		public void OnClearSdkCacheNotify(string jsonRet)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x5BF8960", Offset = "0x5BF7560", VA = "0x185BF8960")]
		public void OnDeleteAccountNotify(string jsonRet)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5BF8CE0", Offset = "0x5BF78E0", VA = "0x185BF8CE0")]
		public void OnQuerySkuDetailsNotify(string jsonRet)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void OnRebornAccountNotify(string jsonRet)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5BF94D0", Offset = "0x5BF80D0", VA = "0x185BF94D0")]
		public void OnUserSurveyNotify(string jsonRet)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5BF9380", Offset = "0x5BF7F80", VA = "0x185BF9380")]
		public void OnSwitchAreaServerNotify(string jsonRet)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5BF92A0", Offset = "0x5BF7EA0", VA = "0x185BF92A0")]
		public void OnQueryTextLegalityNotify(string jsonRet)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5BF8C70", Offset = "0x5BF7870", VA = "0x185BF8C70")]
		public void OnPushMsgReceivedNotify(string jsonRet)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5BF9460", Offset = "0x5BF8060", VA = "0x185BF9460")]
		public void OnUniversalLinkNotify(string jsonRet)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5BF89D0", Offset = "0x5BF75D0", VA = "0x185BF89D0")]
		public void OnFetchDeviceTrackingIDNotify(string jsonRet)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5BF8AB0", Offset = "0x5BF76B0", VA = "0x185BF8AB0")]
		public void OnLocalNotificationBuildNotify(string jsonRet)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5BF9310", Offset = "0x5BF7F10", VA = "0x185BF9310")]
		public void OnSetBrithNotify(string jsonRet)
		{
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x0")]
		private static YoSDKCallBack m_instance;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x8")]
		private static object queueLock;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x10")]
		private static Queue<string> resultQueue;
	}
}
