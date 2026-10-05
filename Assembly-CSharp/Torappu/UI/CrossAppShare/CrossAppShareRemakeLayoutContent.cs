using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F1 RID: 22769
	[Token(Token = "0x20058F1")]
	public class CrossAppShareRemakeLayoutContent : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021322 RID: 135970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021322")]
		[Address(RVA = "0x1B778F0", Offset = "0x1B764F0", VA = "0x181B778F0")]
		public void ApplyContent(CrossAppShareLayoutContentModel layoutContentModel, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021323 RID: 135971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021323")]
		[Address(RVA = "0x1B77C70", Offset = "0x1B76870", VA = "0x181B77C70")]
		private CrossAppShareRemakeBaseLayoutElement _GetElementByKey(string key)
		{
			return null;
		}

		// Token: 0x06021324 RID: 135972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021324")]
		[Address(RVA = "0x1B77DE0", Offset = "0x1B769E0", VA = "0x181B77DE0")]
		public CrossAppShareRemakeLayoutContent()
		{
		}

		// Token: 0x0402D37D RID: 185213
		[Token(Token = "0x402D37D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CrossAppShareRemakeBaseLayoutElement> _elements;

		// Token: 0x0402D37E RID: 185214
		[Token(Token = "0x402D37E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyContent;

		// Token: 0x0402D37F RID: 185215
		[Token(Token = "0x402D37F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetElementByKey;

		// Token: 0x0402D380 RID: 185216
		[Token(Token = "0x402D380")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
