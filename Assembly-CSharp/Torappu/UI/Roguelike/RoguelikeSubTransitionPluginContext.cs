using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005247 RID: 21063
	[Token(Token = "0x2005247")]
	public class RoguelikeSubTransitionPluginContext : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F13B RID: 127291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F13B")]
		[Address(RVA = "0x18DB4A0", Offset = "0x18DA0A0", VA = "0x1818DB4A0")]
		public IList<RoguelikeTransitionView.ISubTransition> GeneSubTransitionList()
		{
			return null;
		}

		// Token: 0x0601F13C RID: 127292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F13C")]
		[Address(RVA = "0x18DB6A0", Offset = "0x18DA2A0", VA = "0x1818DB6A0")]
		public RoguelikeSubTransitionPluginContext()
		{
		}

		// Token: 0x04029ACF RID: 170703
		[Token(Token = "0x4029ACF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _subTransObjs;

		// Token: 0x04029AD0 RID: 170704
		[Token(Token = "0x4029AD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GeneSubTransitionList;

		// Token: 0x04029AD1 RID: 170705
		[Token(Token = "0x4029AD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
