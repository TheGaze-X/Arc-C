using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C35 RID: 15413
	[Token(Token = "0x2003C35")]
	public class UniEquipTalentContentItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060181A7 RID: 98727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181A7")]
		[Address(RVA = "0x109DE40", Offset = "0x109CA40", VA = "0x18109DE40")]
		public void Render(CharacterTalentViewModel viewModel)
		{
		}

		// Token: 0x060181A8 RID: 98728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181A8")]
		[Address(RVA = "0x109E040", Offset = "0x109CC40", VA = "0x18109E040")]
		public UniEquipTalentContentItem()
		{
		}

		// Token: 0x0401D44D RID: 119885
		[Token(Token = "0x401D44D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401D44E RID: 119886
		[Token(Token = "0x401D44E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommentedText _textContent;

		// Token: 0x0401D44F RID: 119887
		[Token(Token = "0x401D44F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterInfoTalentUnlockView _unlockView;

		// Token: 0x0401D450 RID: 119888
		[Token(Token = "0x401D450")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D451 RID: 119889
		[Token(Token = "0x401D451")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
