using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200545B RID: 21595
	[Token(Token = "0x200545B")]
	public abstract class RoguelikeSacrificePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FC95 RID: 130197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC95")]
		[Address(RVA = "0x19F7E40", Offset = "0x19F6A40", VA = "0x1819F7E40", Slot = "4")]
		public virtual RoguelikeSacrificeModelParamBuilder GetModelParamBuilder()
		{
			return null;
		}

		// Token: 0x0601FC96 RID: 130198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC96")]
		[Address(RVA = "0x19F7DB0", Offset = "0x19F69B0", VA = "0x1819F7DB0", Slot = "5")]
		public virtual RoguelikeSacrificeConfirmBehaviour GetConfirmBehaviour()
		{
			return null;
		}

		// Token: 0x0601FC97 RID: 130199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC97")]
		[Address(RVA = "0x19F7ED0", Offset = "0x19F6AD0", VA = "0x1819F7ED0")]
		protected RoguelikeSacrificePlugin()
		{
		}

		// Token: 0x0402AD3C RID: 175420
		[Token(Token = "0x402AD3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelParamBuilder;

		// Token: 0x0402AD3D RID: 175421
		[Token(Token = "0x402AD3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetConfirmBehaviour;

		// Token: 0x0402AD3E RID: 175422
		[Token(Token = "0x402AD3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
