using System;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003407 RID: 13319
	[Token(Token = "0x2003407")]
	public class UICooperateBattleEmoticonController : EmoticonPagerPanelBaseController
	{
		// Token: 0x0601548A RID: 87178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601548A")]
		[Address(RVA = "0xDAECE0", Offset = "0xDAD8E0", VA = "0x180DAECE0")]
		public void InitIfNot(bool activeEmoticon, bool isFootballMode)
		{
		}

		// Token: 0x0601548B RID: 87179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601548B")]
		[Address(RVA = "0xDAF400", Offset = "0xDAE000", VA = "0x180DAF400")]
		public void UpdateEmojiCtrl(FP deltaTime)
		{
		}

		// Token: 0x0601548C RID: 87180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601548C")]
		[Address(RVA = "0xDAF100", Offset = "0xDADD00", VA = "0x180DAF100")]
		public void ShowInBattleEmoticonPanel()
		{
		}

		// Token: 0x0601548D RID: 87181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601548D")]
		[Address(RVA = "0xDAFE00", Offset = "0xDAEA00", VA = "0x180DAFE00")]
		private void _ShowInBattlePopEmojiItem(PopEmojiItemInputParam popParam, string emojiId, string themeId)
		{
		}

		// Token: 0x0601548E RID: 87182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601548E")]
		[Address(RVA = "0xDAF7E0", Offset = "0xDAE3E0", VA = "0x180DAF7E0", Slot = "8")]
		protected override void _OnSendEmoji(string themeId, string emojiItem)
		{
		}

		// Token: 0x0601548F RID: 87183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601548F")]
		[Address(RVA = "0xDAF980", Offset = "0xDAE580", VA = "0x180DAF980")]
		private void _SendInBattleEmojiRequest(string themeId, string emojiItem)
		{
		}

		// Token: 0x06015490 RID: 87184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015490")]
		[Address(RVA = "0xDAF6A0", Offset = "0xDAE2A0", VA = "0x180DAF6A0")]
		private void _OnReceiveEmojiMsg(object arg)
		{
		}

		// Token: 0x06015491 RID: 87185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015491")]
		[Address(RVA = "0xDAF620", Offset = "0xDAE220", VA = "0x180DAF620", Slot = "10")]
		protected override void _OnClosePanel()
		{
		}

		// Token: 0x06015492 RID: 87186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015492")]
		[Address(RVA = "0xDAFC50", Offset = "0xDAE850", VA = "0x180DAFC50")]
		private void _ShowEmojiPanelBtn()
		{
		}

		// Token: 0x06015493 RID: 87187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015493")]
		[Address(RVA = "0xDAF530", Offset = "0xDAE130", VA = "0x180DAF530")]
		private void _HideEmojiPanelBtn(float cd)
		{
		}

		// Token: 0x06015494 RID: 87188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015494")]
		[Address(RVA = "0xDAFEE0", Offset = "0xDAEAE0", VA = "0x180DAFEE0")]
		public UICooperateBattleEmoticonController()
		{
		}

		// Token: 0x06015495 RID: 87189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015495")]
		[Address(RVA = "0xDAF3F0", Offset = "0xDADFF0", VA = "0x180DAF3F0")]
		private void <>xLuaBaseProxy__OnClosePanel()
		{
		}

		// Token: 0x040196CB RID: 104139
		[Token(Token = "0x40196CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICooperateBattleEmoticonPanelBtn _emoticonTriggerBtn;

		// Token: 0x040196CC RID: 104140
		[Token(Token = "0x40196CC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _predelay;

		// Token: 0x040196CD RID: 104141
		[Token(Token = "0x40196CD")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _sendingEmojiCD;

		// Token: 0x040196CE RID: 104142
		[Token(Token = "0x40196CE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _emojiBtnShowCD;

		// Token: 0x040196CF RID: 104143
		[Token(Token = "0x40196CF")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector2 _selfPopEmojiOffset;

		// Token: 0x040196D0 RID: 104144
		[Token(Token = "0x40196D0")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Vector2 _matePopEmojiOffset;

		// Token: 0x040196D1 RID: 104145
		[Token(Token = "0x40196D1")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector2 _matePopEmojiOffsetFootball;

		// Token: 0x040196D2 RID: 104146
		[Token(Token = "0x40196D2")]
		[FieldOffset(Offset = "0x94")]
		private bool m_isInited;

		// Token: 0x040196D3 RID: 104147
		[Token(Token = "0x40196D3")]
		[FieldOffset(Offset = "0x95")]
		private bool m_isActive;

		// Token: 0x040196D4 RID: 104148
		[Token(Token = "0x40196D4")]
		[FieldOffset(Offset = "0x98")]
		private CooperateUIPlugin m_plugin;

		// Token: 0x040196D5 RID: 104149
		[Token(Token = "0x40196D5")]
		[FieldOffset(Offset = "0xA0")]
		private PeriodicTimer m_emojiCDTimer;

		// Token: 0x040196D6 RID: 104150
		[Token(Token = "0x40196D6")]
		[FieldOffset(Offset = "0xA8")]
		private PeriodicTimer m_emojiBtnShowTimer;

		// Token: 0x040196D7 RID: 104151
		[Token(Token = "0x40196D7")]
		[FieldOffset(Offset = "0xB0")]
		private PopEmojiItemInputParam m_selfPopEmojiParam;

		// Token: 0x040196D8 RID: 104152
		[Token(Token = "0x40196D8")]
		[FieldOffset(Offset = "0xB8")]
		private PopEmojiItemInputParam m_matePopEmojiParam;

		// Token: 0x040196D9 RID: 104153
		[Token(Token = "0x40196D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x040196DA RID: 104154
		[Token(Token = "0x40196DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateEmojiCtrl;

		// Token: 0x040196DB RID: 104155
		[Token(Token = "0x40196DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowInBattleEmoticonPanel;

		// Token: 0x040196DC RID: 104156
		[Token(Token = "0x40196DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowInBattlePopEmojiItem;

		// Token: 0x040196DD RID: 104157
		[Token(Token = "0x40196DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSendEmoji;

		// Token: 0x040196DE RID: 104158
		[Token(Token = "0x40196DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendInBattleEmojiRequest;

		// Token: 0x040196DF RID: 104159
		[Token(Token = "0x40196DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnReceiveEmojiMsg;

		// Token: 0x040196E0 RID: 104160
		[Token(Token = "0x40196E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClosePanel;

		// Token: 0x040196E1 RID: 104161
		[Token(Token = "0x40196E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowEmojiPanelBtn;

		// Token: 0x040196E2 RID: 104162
		[Token(Token = "0x40196E2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HideEmojiPanelBtn;

		// Token: 0x040196E3 RID: 104163
		[Token(Token = "0x40196E3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
