using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064ED RID: 25837
	[Token(Token = "0x20064ED")]
	public class AutoChessBattlePlayerStatusPanel : AutoChessBattleUIPanelBase, IAutoChessBattleChatListener
	{
		// Token: 0x06025215 RID: 152085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025215")]
		[Address(RVA = "0x2014D30", Offset = "0x2013930", VA = "0x182014D30", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x06025216 RID: 152086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025216")]
		[Address(RVA = "0x2015390", Offset = "0x2013F90", VA = "0x182015390")]
		private void _DisableEmojiBtnForAWhile()
		{
		}

		// Token: 0x06025217 RID: 152087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025217")]
		[Address(RVA = "0x20146B0", Offset = "0x20132B0", VA = "0x1820146B0", Slot = "8")]
		public void OnRevChat(object arg)
		{
		}

		// Token: 0x06025218 RID: 152088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025218")]
		[Address(RVA = "0x2015540", Offset = "0x2014140", VA = "0x182015540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025219 RID: 152089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025219")]
		[Address(RVA = "0x20156E0", Offset = "0x20142E0", VA = "0x1820156E0")]
		private void _OpenEmojiPanel()
		{
		}

		// Token: 0x0602521A RID: 152090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602521A")]
		[Address(RVA = "0x2014620", Offset = "0x2013220", VA = "0x182014620")]
		public void EventOnOpenEmoji()
		{
		}

		// Token: 0x0602521B RID: 152091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602521B")]
		[Address(RVA = "0x20158A0", Offset = "0x20144A0", VA = "0x1820158A0")]
		public AutoChessBattlePlayerStatusPanel()
		{
		}

		// Token: 0x040340D7 RID: 213207
		[Token(Token = "0x40340D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _playerList;

		// Token: 0x040340D8 RID: 213208
		[Token(Token = "0x40340D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040340D9 RID: 213209
		[Token(Token = "0x40340D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x040340DA RID: 213210
		[Token(Token = "0x40340DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _emojiBtnNode;

		// Token: 0x040340DB RID: 213211
		[Token(Token = "0x40340DB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIButton _emojiBtn;

		// Token: 0x040340DC RID: 213212
		[Token(Token = "0x40340DC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessEmojiController _emojiController;

		// Token: 0x040340DD RID: 213213
		[Token(Token = "0x40340DD")]
		[FieldOffset(Offset = "0x50")]
		private string m_actId;

		// Token: 0x040340DE RID: 213214
		[Token(Token = "0x40340DE")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessBattlePlayerStatusGroupModel m_playerGroupModel;

		// Token: 0x040340DF RID: 213215
		[Token(Token = "0x40340DF")]
		[FieldOffset(Offset = "0x60")]
		private AutoChessBattlePlayerStatusPanel.PlayerListAdapter m_listAdapter;

		// Token: 0x040340E0 RID: 213216
		[Token(Token = "0x40340E0")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x040340E1 RID: 213217
		[Token(Token = "0x40340E1")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x040340E2 RID: 213218
		[Token(Token = "0x40340E2")]
		[FieldOffset(Offset = "0x78")]
		private ExclusiveSelectionGroup m_playerExclusiveGrp;

		// Token: 0x040340E3 RID: 213219
		[Token(Token = "0x40340E3")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040340E4 RID: 213220
		[Token(Token = "0x40340E4")]
		[FieldOffset(Offset = "0x90")]
		private int m_emojiRecoverTimer;

		// Token: 0x040340E5 RID: 213221
		[Token(Token = "0x40340E5")]
		[FieldOffset(Offset = "0x94")]
		private SeqNumSource.Checker m_emojiOpenChecker;

		// Token: 0x040340E6 RID: 213222
		[Token(Token = "0x40340E6")]
		[FieldOffset(Offset = "0x9C")]
		private SeqNumSource.Checker m_emojiReqChecker;

		// Token: 0x040340E7 RID: 213223
		[Token(Token = "0x40340E7")]
		[FieldOffset(Offset = "0xA4")]
		private AutoChessGameStateType m_preState;

		// Token: 0x040340E8 RID: 213224
		[Token(Token = "0x40340E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040340E9 RID: 213225
		[Token(Token = "0x40340E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DisableEmojiBtnForAWhile;

		// Token: 0x040340EA RID: 213226
		[Token(Token = "0x40340EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRevChat;

		// Token: 0x040340EB RID: 213227
		[Token(Token = "0x40340EB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040340EC RID: 213228
		[Token(Token = "0x40340EC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenEmojiPanel;

		// Token: 0x040340ED RID: 213229
		[Token(Token = "0x40340ED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnOpenEmoji;

		// Token: 0x040340EE RID: 213230
		[Token(Token = "0x40340EE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064EE RID: 25838
		[Token(Token = "0x20064EE")]
		private class PlayerListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602521D RID: 152093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602521D")]
			[Address(RVA = "0x2025E00", Offset = "0x2024A00", VA = "0x182025E00")]
			public PlayerListAdapter(AutoChessBattlePlayerStatusPanel closure)
			{
			}

			// Token: 0x170057A1 RID: 22433
			// (get) Token: 0x0602521E RID: 152094 RVA: 0x000C6A38 File Offset: 0x000C4C38
			[Token(Token = "0x170057A1")]
			public override int count
			{
				[Token(Token = "0x602521E")]
				[Address(RVA = "0x2025E80", Offset = "0x2024A80", VA = "0x182025E80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602521F RID: 152095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602521F")]
			[Address(RVA = "0x2025B90", Offset = "0x2024790", VA = "0x182025B90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040340EF RID: 213231
			[Token(Token = "0x40340EF")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessBattlePlayerStatusPanel m_closure;

			// Token: 0x040340F0 RID: 213232
			[Token(Token = "0x40340F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040340F1 RID: 213233
			[Token(Token = "0x40340F1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040340F2 RID: 213234
			[Token(Token = "0x40340F2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
