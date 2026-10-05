using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A0 RID: 25248
	[Token(Token = "0x20062A0")]
	public class AutoChessBattleMultiBossPreparePanelHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024667 RID: 149095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024667")]
		[Address(RVA = "0x1F29250", Offset = "0x1F27E50", VA = "0x181F29250")]
		public RectTransform[] GetPlayerCardsContainer()
		{
			return null;
		}

		// Token: 0x06024668 RID: 149096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024668")]
		[Address(RVA = "0x1F29150", Offset = "0x1F27D50", VA = "0x181F29150")]
		public RectTransform GetPlayerCard(int index)
		{
			return null;
		}

		// Token: 0x06024669 RID: 149097 RVA: 0x000C41A0 File Offset: 0x000C23A0
		[Token(Token = "0x6024669")]
		[Address(RVA = "0x1F291E0", Offset = "0x1F27DE0", VA = "0x181F291E0")]
		public int GetPlayerCardsContainerCount()
		{
			return 0;
		}

		// Token: 0x0602466A RID: 149098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602466A")]
		[Address(RVA = "0x1F290F0", Offset = "0x1F27CF0", VA = "0x181F290F0")]
		public Text GetBossCurrentHpLb()
		{
			return null;
		}

		// Token: 0x0602466B RID: 149099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602466B")]
		[Address(RVA = "0x1F292B0", Offset = "0x1F27EB0", VA = "0x181F292B0")]
		public AutoChessBattleMultiBossPreparePanelHolder()
		{
		}

		// Token: 0x04032A62 RID: 207458
		[Token(Token = "0x4032A62")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform[] _playerCardsContainer;

		// Token: 0x04032A63 RID: 207459
		[Token(Token = "0x4032A63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textBossHp;

		// Token: 0x04032A64 RID: 207460
		[Token(Token = "0x4032A64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPlayerCardsContainer;

		// Token: 0x04032A65 RID: 207461
		[Token(Token = "0x4032A65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerCard;

		// Token: 0x04032A66 RID: 207462
		[Token(Token = "0x4032A66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayerCardsContainerCount;

		// Token: 0x04032A67 RID: 207463
		[Token(Token = "0x4032A67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBossCurrentHpLb;

		// Token: 0x04032A68 RID: 207464
		[Token(Token = "0x4032A68")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
