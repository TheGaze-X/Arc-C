using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C22 RID: 15394
	[Token(Token = "0x2003C22")]
	public class UniEquipDescView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018153 RID: 98643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018153")]
		[Address(RVA = "0x1086F10", Offset = "0x1085B10", VA = "0x181086F10")]
		public void Render(UniEquipSelectList viewModel)
		{
		}

		// Token: 0x06018154 RID: 98644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018154")]
		[Address(RVA = "0x1087490", Offset = "0x1086090", VA = "0x181087490")]
		public UniEquipDescView()
		{
		}

		// Token: 0x0401D362 RID: 119650
		[Token(Token = "0x401D362")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommentedText _textPart1;

		// Token: 0x0401D363 RID: 119651
		[Token(Token = "0x401D363")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommentedText _typeText;

		// Token: 0x0401D364 RID: 119652
		[Token(Token = "0x401D364")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterAttackRangeDeltaWidget _deltaWidget;

		// Token: 0x0401D365 RID: 119653
		[Token(Token = "0x401D365")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0401D366 RID: 119654
		[Token(Token = "0x401D366")]
		[FieldOffset(Offset = "0x38")]
		private string param;

		// Token: 0x0401D367 RID: 119655
		[Token(Token = "0x401D367")]
		[FieldOffset(Offset = "0x40")]
		private string m_cacheShiningActive;

		// Token: 0x0401D368 RID: 119656
		[Token(Token = "0x401D368")]
		[FieldOffset(Offset = "0x48")]
		private bool m_animInited;

		// Token: 0x0401D369 RID: 119657
		[Token(Token = "0x401D369")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D36A RID: 119658
		[Token(Token = "0x401D36A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
