using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A09 RID: 23049
	[Token(Token = "0x2005A09")]
	public class CrisisStageSeasonWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021953 RID: 137555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021953")]
		[Address(RVA = "0x1C0C6C0", Offset = "0x1C0B2C0", VA = "0x181C0C6C0")]
		public CrisisStageSeasonWidget()
		{
		}

		// Token: 0x0402DE49 RID: 187977
		[Token(Token = "0x402DE49")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string seasonId;

		// Token: 0x0402DE4A RID: 187978
		[Token(Token = "0x402DE4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
