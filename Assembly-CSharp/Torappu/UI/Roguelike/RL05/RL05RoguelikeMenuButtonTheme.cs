using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200560B RID: 22027
	[Token(Token = "0x200560B")]
	public class RL05RoguelikeMenuButtonTheme : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x06020529 RID: 132393 RVA: 0x000B5638 File Offset: 0x000B3838
		[Token(Token = "0x17004BB4")]
		public RL05RoguelikeMenuButtonTheme.MenuButtonType menuButtonType
		{
			[Token(Token = "0x6020529")]
			[Address(RVA = "0x1A6F750", Offset = "0x1A6E350", VA = "0x181A6F750")]
			get
			{
				return RL05RoguelikeMenuButtonTheme.MenuButtonType.RECRUIT_COMMON;
			}
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x0602052A RID: 132394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BB5")]
		public GameObject menuButtonPanel
		{
			[Token(Token = "0x602052A")]
			[Address(RVA = "0x1A6F6F0", Offset = "0x1A6E2F0", VA = "0x181A6F6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602052B RID: 132395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602052B")]
		[Address(RVA = "0x1A6F690", Offset = "0x1A6E290", VA = "0x181A6F690")]
		public RL05RoguelikeMenuButtonTheme()
		{
		}

		// Token: 0x0402BBFA RID: 179194
		[Token(Token = "0x402BBFA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05RoguelikeMenuButtonTheme.MenuButtonType _menuButtonType;

		// Token: 0x0402BBFB RID: 179195
		[Token(Token = "0x402BBFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _menuButtonPanel;

		// Token: 0x0402BBFC RID: 179196
		[Token(Token = "0x402BBFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuButtonType;

		// Token: 0x0402BBFD RID: 179197
		[Token(Token = "0x402BBFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_menuButtonPanel;

		// Token: 0x0402BBFE RID: 179198
		[Token(Token = "0x402BBFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200560C RID: 22028
		[Token(Token = "0x200560C")]
		[Serializable]
		public enum MenuButtonType
		{
			// Token: 0x0402BC00 RID: 179200
			[Token(Token = "0x402BC00")]
			RECRUIT_COMMON,
			// Token: 0x0402BC01 RID: 179201
			[Token(Token = "0x402BC01")]
			RECRUIT_RL05,
			// Token: 0x0402BC02 RID: 179202
			[Token(Token = "0x402BC02")]
			GET_CANDLE_ONLY,
			// Token: 0x0402BC03 RID: 179203
			[Token(Token = "0x402BC03")]
			RECRUIT_AND_CANDLE,
			// Token: 0x0402BC04 RID: 179204
			[Token(Token = "0x402BC04")]
			UPGRADE_AND_CANDLE
		}
	}
}
