using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.SafeArea.Core;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public class SafeAreaController : IHotfixable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		private static SafeAreaImpl impl
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x54EC620", Offset = "0x54EB220", VA = "0x1854EC620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x17000015")]
		public static bool isInited
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x54EC750", Offset = "0x54EB350", VA = "0x1854EC750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x54EB810", Offset = "0x54EA410", VA = "0x1854EB810")]
		public static void InitSafeRect(MonoBehaviour behavior, [Optional] Action onSuc)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x54EB530", Offset = "0x54EA130", VA = "0x1854EB530")]
		public static int GetDesiredPadding()
		{
			return 0;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x17000016")]
		public static SafeRect safeRect
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x54ECA00", Offset = "0x54EB600", VA = "0x1854ECA00")]
			get
			{
				return default(SafeRect);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x17000017")]
		public static int width
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x54ECAA0", Offset = "0x54EB6A0", VA = "0x1854ECAA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x17000018")]
		public static int height
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x54EC540", Offset = "0x54EB140", VA = "0x1854EC540")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x17000019")]
		public static float safeRectRatio
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x54EC7E0", Offset = "0x54EB3E0", VA = "0x1854EC7E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x54EB5E0", Offset = "0x54EA1E0", VA = "0x1854EB5E0")]
		public static Vector2 GetMaskPadding(CanvasScaler scaler)
		{
			return default(Vector2);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x54EB390", Offset = "0x54E9F90", VA = "0x1854EB390")]
		public static void ChangeSafePaddingConfig(int newSafePadding)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x54EBA30", Offset = "0x54EA630", VA = "0x1854EBA30")]
		public static void RegisterSafeAreaListener(ISafeAreaListener listener)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x54EBBB0", Offset = "0x54EA7B0", VA = "0x1854EBBB0")]
		public static void UnregisterSafeAreaListener(ISafeAreaListener listener)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x54EBC70", Offset = "0x54EA870", VA = "0x1854EBC70")]
		public static void UpdateScreenSize()
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x54EC030", Offset = "0x54EAC30", VA = "0x1854EC030")]
		private static IEnumerator _InitCorouine(Action onSuc)
		{
			return null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x54EC310", Offset = "0x54EAF10", VA = "0x1854EC310")]
		private static bool _TryGetSafePaddingFromConfig(out int padding)
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x54EBE20", Offset = "0x54EAA20", VA = "0x1854EBE20")]
		private static SafeRect _CacheAndFixSafeRect(int desiredPadding, int screenW, int screenH)
		{
			return default(SafeRect);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x54EC100", Offset = "0x54EAD00", VA = "0x1854EC100")]
		private static void _NotifySafeRectUpdated(SafeRect safeRect)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x54EC4C0", Offset = "0x54EB0C0", VA = "0x1854EC4C0")]
		public SafeAreaController()
		{
		}

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		public const int MAX_NOTCH_PADDING = 130;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		private const float MIN_PAD_RATIO = 1.7777778f;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		private const string SAFE_PADDING_PREF_KEY = "SafeAreaController_safe_padding";

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SafeAreaImpl s_impl;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static SafeRect s_safeRect;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool s_isInited;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private static bool s_isIniting;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<ISafeAreaListener> s_safeRectListeners;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int s_cachedScreenWidth;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int s_cachedScreenHeight;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static int s_desiredPadValue;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate7 __Hotfix0_get_impl;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate8 __Hotfix0_get_isInited;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate0 __Hotfix0_InitSafeRect;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate9 __Hotfix0_GetDesiredPadding;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate10 __Hotfix0_get_safeRect;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate9 __Hotfix0_get_width;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate9 __Hotfix0_get_height;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate11 __Hotfix0_get_safeRectRatio;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate12 __Hotfix0_GetMaskPadding;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate13 __Hotfix0_ChangeSafePaddingConfig;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate1 __Hotfix0_RegisterSafeAreaListener;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate1 __Hotfix0_UnregisterSafeAreaListener;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate14 __Hotfix0_UpdateScreenSize;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate15 __Hotfix0__InitCorouine;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate16 __Hotfix0__TryGetSafePaddingFromConfig;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate17 __Hotfix0__CacheAndFixSafeRect;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate18 __Hotfix0__NotifySafeRectUpdated;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
