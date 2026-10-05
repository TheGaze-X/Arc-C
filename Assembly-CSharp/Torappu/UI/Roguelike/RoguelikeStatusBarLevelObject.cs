using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005315 RID: 21269
	[Token(Token = "0x2005315")]
	public class RoguelikeStatusBarLevelObject : RoguelikeMenuObject<RoguelikeMenuLevelViewModel>
	{
		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x0601F627 RID: 128551 RVA: 0x000B1B88 File Offset: 0x000AFD88
		[Token(Token = "0x17004993")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F627")]
			[Address(RVA = "0x191C500", Offset = "0x191B100", VA = "0x18191C500", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F628 RID: 128552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F628")]
		[Address(RVA = "0x191C2C0", Offset = "0x191AEC0", VA = "0x18191C2C0", Slot = "16")]
		public override void Render(RoguelikeMenuLevelViewModel viewModel)
		{
		}

		// Token: 0x0601F629 RID: 128553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F629")]
		[Address(RVA = "0x191C490", Offset = "0x191B090", VA = "0x18191C490")]
		public RoguelikeStatusBarLevelObject()
		{
		}

		// Token: 0x0402A2EA RID: 172778
		[Token(Token = "0x402A2EA")]
		private const string RICH_TEXT_EXP = "<color=#{2}>{0}</color>/{1}";

		// Token: 0x0402A2EB RID: 172779
		[Token(Token = "0x402A2EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0402A2EC RID: 172780
		[Token(Token = "0x402A2EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textExp;

		// Token: 0x0402A2ED RID: 172781
		[Token(Token = "0x402A2ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageExp;

		// Token: 0x0402A2EE RID: 172782
		[Token(Token = "0x402A2EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _gameObjectNextLevel;

		// Token: 0x0402A2EF RID: 172783
		[Token(Token = "0x402A2EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2F0 RID: 172784
		[Token(Token = "0x402A2F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2F1 RID: 172785
		[Token(Token = "0x402A2F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
