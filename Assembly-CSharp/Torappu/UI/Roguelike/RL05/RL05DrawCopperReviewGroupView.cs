using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005589 RID: 21897
	[Token(Token = "0x2005589")]
	public class RL05DrawCopperReviewGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060202B0 RID: 131760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202B0")]
		[Address(RVA = "0x1A4F9B0", Offset = "0x1A4E5B0", VA = "0x181A4F9B0")]
		public void Render(ILoadAsset assetLoader, string topicId, List<RoguelikePlayerCopperItemViewModel> copperList, int begin, bool isFirst)
		{
		}

		// Token: 0x060202B1 RID: 131761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202B1")]
		[Address(RVA = "0x1A4FDE0", Offset = "0x1A4E9E0", VA = "0x181A4FDE0")]
		public RL05DrawCopperReviewGroupView()
		{
		}

		// Token: 0x0402B765 RID: 178021
		[Token(Token = "0x402B765")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] _cellHooks;

		// Token: 0x0402B766 RID: 178022
		[Token(Token = "0x402B766")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scale;

		// Token: 0x0402B767 RID: 178023
		[Token(Token = "0x402B767")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeAbstractCopperItemCard[] m_items;

		// Token: 0x0402B768 RID: 178024
		[Token(Token = "0x402B768")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B769 RID: 178025
		[Token(Token = "0x402B769")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
