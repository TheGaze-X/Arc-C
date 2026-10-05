using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004991 RID: 18833
	[Token(Token = "0x2004991")]
	public class MedalAdvanceCommonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C610 RID: 116240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C610")]
		[Address(RVA = "0x15E6930", Offset = "0x15E5530", VA = "0x1815E6930")]
		public void Render(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C611 RID: 116241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C611")]
		[Address(RVA = "0x15E69E0", Offset = "0x15E55E0", VA = "0x1815E69E0")]
		private static string _GenerateGetDesc(MedalCommonViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601C612 RID: 116242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C612")]
		[Address(RVA = "0x15E6C70", Offset = "0x15E5870", VA = "0x1815E6C70")]
		public MedalAdvanceCommonView()
		{
		}

		// Token: 0x0402529F RID: 152223
		[Token(Token = "0x402529F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _getState;

		// Token: 0x040252A0 RID: 152224
		[Token(Token = "0x40252A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252A1 RID: 152225
		[Token(Token = "0x40252A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateGetDesc;

		// Token: 0x040252A2 RID: 152226
		[Token(Token = "0x40252A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
