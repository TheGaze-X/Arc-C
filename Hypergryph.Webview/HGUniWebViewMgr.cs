using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.SDK
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class HGUniWebViewMgr : MonoBehaviour
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4A2E230", Offset = "0x4A2CE30", VA = "0x184A2E230")]
		public static void InitIfNot(HGUniWebViewMgr.Adapter adapter)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4A2E420", Offset = "0x4A2D020", VA = "0x184A2E420")]
		public static bool IsInited()
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4A2E530", Offset = "0x4A2D130", VA = "0x184A2E530")]
		public static void IsNew(string type)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4A2E4C0", Offset = "0x4A2D0C0", VA = "0x184A2E4C0")]
		public static void IsNewByCache(string type)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4A2E840", Offset = "0x4A2D440", VA = "0x184A2E840")]
		public static void LoadWebview(string type, UserData userData)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4A2E6F0", Offset = "0x4A2D2F0", VA = "0x184A2E6F0")]
		public static void LoadWebview(string type, UserData userData, UrlParams urlParams)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4A2E1D0", Offset = "0x4A2CDD0", VA = "0x184A2E1D0")]
		public static void CloseWebview()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4A2ED70", Offset = "0x4A2D970", VA = "0x184A2ED70")]
		public static void ToastInsideWebview(int level, string message)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4A2EBF0", Offset = "0x4A2D7F0", VA = "0x184A2EBF0")]
		public static void PreloadWebview(string type)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4A2E0D0", Offset = "0x4A2CCD0", VA = "0x184A2E0D0")]
		public static bool CheckPreloadStatus()
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4A2E5A0", Offset = "0x4A2D1A0", VA = "0x184A2E5A0")]
		public static void LoadMiniWebview(string url, UserData userData, MiniWebCustomStyle customStyle)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4A2EC60", Offset = "0x4A2D860", VA = "0x184A2EC60")]
		private void Start()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4A2E9B0", Offset = "0x4A2D5B0", VA = "0x184A2E9B0")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4A2EA30", Offset = "0x4A2D630", VA = "0x184A2EA30")]
		public void OnExtraInfo(string jsonData)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HGUniWebViewMgr()
		{
		}

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		public const string CALLBACK_GO_NAME = "(hgwebview_callback)";

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		private static HGUniWebViewMgr s_instance;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isInited;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x8")]
		private static HGUniWebViewMgr.Adapter s_adapter;

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public abstract class Adapter
		{
			// Token: 0x06000038 RID: 56
			[Token(Token = "0x6000038")]
			public abstract string GetSDKEnv();

			// Token: 0x06000039 RID: 57
			[Token(Token = "0x6000039")]
			public abstract string UserDataToJSON(UserData userData);

			// Token: 0x0600003A RID: 58
			[Token(Token = "0x600003A")]
			public abstract CallbackRet JSONToCallbackRet(string jsonStr);

			// Token: 0x0600003B RID: 59
			[Token(Token = "0x600003B")]
			public abstract string UrlParamsToJson(UrlParams urlParams);

			// Token: 0x0600003C RID: 60
			[Token(Token = "0x600003C")]
			public abstract string CustomStyleToJson(MiniWebCustomStyle customStyle);

			// Token: 0x0600003D RID: 61
			[Token(Token = "0x600003D")]
			public abstract void OnExtraInfo(CallbackCode code, CallbackMsg msg);

			// Token: 0x0600003E RID: 62
			[Token(Token = "0x600003E")]
			public abstract void OnManagerInitFinished();

			// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected Adapter()
			{
			}
		}
	}
}
