using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A3 RID: 25251
	[Token(Token = "0x20062A3")]
	public class AutoChessBattleReadyPanelGroupHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602466F RID: 149103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602466F")]
		[Address(RVA = "0x1F29920", Offset = "0x1F28520", VA = "0x181F29920")]
		public RectTransform[] GetPlayerCardsContainer()
		{
			return null;
		}

		// Token: 0x06024670 RID: 149104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024670")]
		[Address(RVA = "0x1F29820", Offset = "0x1F28420", VA = "0x181F29820")]
		public RectTransform GetPlayerCard(int index)
		{
			return null;
		}

		// Token: 0x06024671 RID: 149105 RVA: 0x000C41B8 File Offset: 0x000C23B8
		[Token(Token = "0x6024671")]
		[Address(RVA = "0x1F298B0", Offset = "0x1F284B0", VA = "0x181F298B0")]
		public int GetPlayerCardsContainerCount()
		{
			return 0;
		}

		// Token: 0x06024672 RID: 149106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024672")]
		[Address(RVA = "0x1F29980", Offset = "0x1F28580", VA = "0x181F29980")]
		public AutoChessBattleReadyPanelGroupHolder()
		{
		}

		// Token: 0x04032A77 RID: 207479
		[Token(Token = "0x4032A77")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform[] _playerCardsContainer;

		// Token: 0x04032A78 RID: 207480
		[Token(Token = "0x4032A78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPlayerCardsContainer;

		// Token: 0x04032A79 RID: 207481
		[Token(Token = "0x4032A79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerCard;

		// Token: 0x04032A7A RID: 207482
		[Token(Token = "0x4032A7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayerCardsContainerCount;

		// Token: 0x04032A7B RID: 207483
		[Token(Token = "0x4032A7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
