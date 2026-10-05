using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A9 RID: 21673
	[Token(Token = "0x20054A9")]
	public class RoguelikeSelectCharTalentUnlockView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE2C RID: 130604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE2C")]
		[Address(RVA = "0x1A13970", Offset = "0x1A12570", VA = "0x181A13970")]
		public void InitText(TalentUnlockType unlockType, CharacterData.UnlockCondition unlockCondition)
		{
		}

		// Token: 0x0601FE2D RID: 130605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE2D")]
		[Address(RVA = "0x1A13D20", Offset = "0x1A12920", VA = "0x181A13D20")]
		public RoguelikeSelectCharTalentUnlockView()
		{
		}

		// Token: 0x0402B004 RID: 176132
		[Token(Token = "0x402B004")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detail;

		// Token: 0x0402B005 RID: 176133
		[Token(Token = "0x402B005")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402B006 RID: 176134
		[Token(Token = "0x402B006")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite[] _unlockIcon;

		// Token: 0x0402B007 RID: 176135
		[Token(Token = "0x402B007")]
		private const int NEW_ONE = 0;

		// Token: 0x0402B008 RID: 176136
		[Token(Token = "0x402B008")]
		private const int NEW_TWO = 1;

		// Token: 0x0402B009 RID: 176137
		[Token(Token = "0x402B009")]
		private const int UPDATE_ONE = 2;

		// Token: 0x0402B00A RID: 176138
		[Token(Token = "0x402B00A")]
		private const int UPDATE_TWO = 3;

		// Token: 0x0402B00B RID: 176139
		[Token(Token = "0x402B00B")]
		private const int LVL = 4;

		// Token: 0x0402B00C RID: 176140
		[Token(Token = "0x402B00C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitText;

		// Token: 0x0402B00D RID: 176141
		[Token(Token = "0x402B00D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
