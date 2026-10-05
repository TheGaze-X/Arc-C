using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004125 RID: 16677
	[Token(Token = "0x2004125")]
	public class SandboxV2ItemCardTest : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C41 RID: 105537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C41")]
		[Address(RVA = "0x12B3670", Offset = "0x12B2270", VA = "0x1812B3670")]
		private void Start()
		{
		}

		// Token: 0x06019C42 RID: 105538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C42")]
		[Address(RVA = "0x12B43D0", Offset = "0x12B2FD0", VA = "0x1812B43D0")]
		public SandboxV2ItemCardTest()
		{
		}

		// Token: 0x040204F0 RID: 132336
		[Token(Token = "0x40204F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x040204F1 RID: 132337
		[Token(Token = "0x40204F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040204F2 RID: 132338
		[Token(Token = "0x40204F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040204F3 RID: 132339
		[Token(Token = "0x40204F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
