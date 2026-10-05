using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x02005902 RID: 22786
	[Token(Token = "0x2005902")]
	public class CrossAppShareStartLayoutContent : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021350 RID: 136016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021350")]
		[Address(RVA = "0x1B79000", Offset = "0x1B77C00", VA = "0x181B79000")]
		public CrossAppShareLayoutContentModel GetChildRemakeModels()
		{
			return null;
		}

		// Token: 0x06021351 RID: 136017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021351")]
		[Address(RVA = "0x1B792F0", Offset = "0x1B77EF0", VA = "0x181B792F0")]
		public CrossAppShareStartLayoutContent()
		{
		}

		// Token: 0x0402D3B8 RID: 185272
		[Token(Token = "0x402D3B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChildRemakeModels;

		// Token: 0x0402D3B9 RID: 185273
		[Token(Token = "0x402D3B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
