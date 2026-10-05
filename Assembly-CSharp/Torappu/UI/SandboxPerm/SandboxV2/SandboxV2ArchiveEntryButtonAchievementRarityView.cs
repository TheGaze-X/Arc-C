using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200410B RID: 16651
	[Token(Token = "0x200410B")]
	public class SandboxV2ArchiveEntryButtonAchievementRarityView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019BE8 RID: 105448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE8")]
		[Address(RVA = "0x1294FE0", Offset = "0x1293BE0", VA = "0x181294FE0")]
		public void Render(Dictionary<int, int> rarityCountDict)
		{
		}

		// Token: 0x06019BE9 RID: 105449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE9")]
		[Address(RVA = "0x12950C0", Offset = "0x1293CC0", VA = "0x1812950C0")]
		public SandboxV2ArchiveEntryButtonAchievementRarityView()
		{
		}

		// Token: 0x04020412 RID: 132114
		[Token(Token = "0x4020412")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _raritySortId;

		// Token: 0x04020413 RID: 132115
		[Token(Token = "0x4020413")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04020414 RID: 132116
		[Token(Token = "0x4020414")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020415 RID: 132117
		[Token(Token = "0x4020415")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
