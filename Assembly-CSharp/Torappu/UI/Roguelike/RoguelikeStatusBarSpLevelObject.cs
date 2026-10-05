using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005317 RID: 21271
	[Token(Token = "0x2005317")]
	public class RoguelikeStatusBarSpLevelObject : RoguelikeMenuObject<RoguelikeMenuLevelViewModel>
	{
		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x0601F62D RID: 128557 RVA: 0x000B1BB8 File Offset: 0x000AFDB8
		[Token(Token = "0x17004995")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F62D")]
			[Address(RVA = "0x191D060", Offset = "0x191BC60", VA = "0x18191D060", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F62E RID: 128558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F62E")]
		[Address(RVA = "0x191CDE0", Offset = "0x191B9E0", VA = "0x18191CDE0", Slot = "16")]
		public override void Render(RoguelikeMenuLevelViewModel viewModel)
		{
		}

		// Token: 0x0601F62F RID: 128559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F62F")]
		[Address(RVA = "0x191CFF0", Offset = "0x191BBF0", VA = "0x18191CFF0")]
		public RoguelikeStatusBarSpLevelObject()
		{
		}

		// Token: 0x0402A2F7 RID: 172791
		[Token(Token = "0x402A2F7")]
		private const string RICH_TEXT_EXP = "<color=#{2}>{0}</color>/{1}";

		// Token: 0x0402A2F8 RID: 172792
		[Token(Token = "0x402A2F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0402A2F9 RID: 172793
		[Token(Token = "0x402A2F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textExp;

		// Token: 0x0402A2FA RID: 172794
		[Token(Token = "0x402A2FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageExp;

		// Token: 0x0402A2FB RID: 172795
		[Token(Token = "0x402A2FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _gameObjectNextLevel;

		// Token: 0x0402A2FC RID: 172796
		[Token(Token = "0x402A2FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorCurExpText;

		// Token: 0x0402A2FD RID: 172797
		[Token(Token = "0x402A2FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2FE RID: 172798
		[Token(Token = "0x402A2FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2FF RID: 172799
		[Token(Token = "0x402A2FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
