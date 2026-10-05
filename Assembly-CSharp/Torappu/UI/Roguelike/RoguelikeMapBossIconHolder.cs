using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200551C RID: 21788
	[Token(Token = "0x200551C")]
	public class RoguelikeMapBossIconHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060200BD RID: 131261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200BD")]
		[Address(RVA = "0x1A1E4E0", Offset = "0x1A1D0E0", VA = "0x181A1E4E0")]
		public Sprite GetIcon(string iconName)
		{
			return null;
		}

		// Token: 0x060200BE RID: 131262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200BE")]
		[Address(RVA = "0x1A1E790", Offset = "0x1A1D390", VA = "0x181A1E790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060200BF RID: 131263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200BF")]
		[Address(RVA = "0x1A1E930", Offset = "0x1A1D530", VA = "0x181A1E930")]
		public RoguelikeMapBossIconHolder()
		{
		}

		// Token: 0x0402B453 RID: 177235
		[Token(Token = "0x402B453")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeMapBossIconHolder.IconData[] _bossIconList;

		// Token: 0x0402B454 RID: 177236
		[Token(Token = "0x402B454")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Sprite> m_iconDict;

		// Token: 0x0402B455 RID: 177237
		[Token(Token = "0x402B455")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInit;

		// Token: 0x0402B456 RID: 177238
		[Token(Token = "0x402B456")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIcon;

		// Token: 0x0402B457 RID: 177239
		[Token(Token = "0x402B457")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B458 RID: 177240
		[Token(Token = "0x402B458")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200551D RID: 21789
		[Token(Token = "0x200551D")]
		[Serializable]
		public struct IconData
		{
			// Token: 0x0402B459 RID: 177241
			[Token(Token = "0x402B459")]
			[FieldOffset(Offset = "0x0")]
			public string iconName;

			// Token: 0x0402B45A RID: 177242
			[Token(Token = "0x402B45A")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;
		}
	}
}
