using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	[RequireComponent(typeof(RawImage))]
	public class AsyncImageRenderer : MonoBehaviour, IHotfixable
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x554AC80", Offset = "0x5549880", VA = "0x18554AC80")]
		private void OnValidate()
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x554B2E0", Offset = "0x5549EE0", VA = "0x18554B2E0")]
		private void _SetInit()
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x554ADC0", Offset = "0x55499C0", VA = "0x18554ADC0")]
		public void SetDefaultImage(Texture2D defaultImg)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x554AE50", Offset = "0x5549A50", VA = "0x18554AE50")]
		public void SetImage(WebTextureLoader.KeyOption keyOption, string url, [Optional] Action onTexLoaded)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x554B0F0", Offset = "0x5549CF0", VA = "0x18554B0F0")]
		private void _ReleaseSprite()
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x554AC20", Offset = "0x5549820", VA = "0x18554AC20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x554B3C0", Offset = "0x5549FC0", VA = "0x18554B3C0")]
		public AsyncImageRenderer()
		{
		}

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImage _rawImage;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D _defaultImg;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WebTextureLoader.KeyOption m_imageKey;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_imageUrl;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action m_onTexLoaded;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnValidate;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0__SetInit;

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_SetDefaultImage;

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate207 __Hotfix0_SetImage;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ReleaseSprite;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnDestroy;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
