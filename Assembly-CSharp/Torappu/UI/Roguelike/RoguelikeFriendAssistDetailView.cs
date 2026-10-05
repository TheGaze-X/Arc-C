using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052E5 RID: 21221
	[Token(Token = "0x20052E5")]
	public class RoguelikeFriendAssistDetailView : DataBinder<RoguelikeFriendAssistDetailProp>
	{
		// Token: 0x0601F4C7 RID: 128199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4C7")]
		[Address(RVA = "0x19041B0", Offset = "0x1902DB0", VA = "0x1819041B0", Slot = "7")]
		public override void OnValueChanged(RoguelikeFriendAssistDetailProp property)
		{
		}

		// Token: 0x0601F4C8 RID: 128200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4C8")]
		[Address(RVA = "0x1904B90", Offset = "0x1903790", VA = "0x181904B90")]
		public void ToggleRequestFriend()
		{
		}

		// Token: 0x0601F4C9 RID: 128201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4C9")]
		[Address(RVA = "0x19040D0", Offset = "0x1902CD0", VA = "0x1819040D0")]
		public void OnFriendAvatarClick()
		{
		}

		// Token: 0x0601F4CA RID: 128202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4CA")]
		[Address(RVA = "0x1904C00", Offset = "0x1903800", VA = "0x181904C00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F4CB RID: 128203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4CB")]
		[Address(RVA = "0x1904D20", Offset = "0x1903920", VA = "0x181904D20")]
		public RoguelikeFriendAssistDetailView()
		{
		}

		// Token: 0x0402A099 RID: 172185
		[Token(Token = "0x402A099")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Player Info")]
		private RectTransform _avatarContainer;

		// Token: 0x0402A09A RID: 172186
		[Token(Token = "0x402A09A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Player Info")]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x0402A09B RID: 172187
		[Token(Token = "0x402A09B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Player Info")]
		private Text _textPlayerLv;

		// Token: 0x0402A09C RID: 172188
		[Token(Token = "0x402A09C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Player Info")]
		private Text _textPlayerName;

		// Token: 0x0402A09D RID: 172189
		[Token(Token = "0x402A09D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Player Info")]
		private Text _textPlayerNameNum;

		// Token: 0x0402A09E RID: 172190
		[Token(Token = "0x402A09E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Char Info")]
		private Image _imgProfession;

		// Token: 0x0402A09F RID: 172191
		[Token(Token = "0x402A09F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Char Info")]
		private Image _imgRarity;

		// Token: 0x0402A0A0 RID: 172192
		[Token(Token = "0x402A0A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Char Info")]
		private Text _textCharName;

		// Token: 0x0402A0A1 RID: 172193
		[Token(Token = "0x402A0A1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Char Info")]
		private Image _imgRecruitElite;

		// Token: 0x0402A0A2 RID: 172194
		[Token(Token = "0x402A0A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Char Info")]
		private Image _imgOrigElite;

		// Token: 0x0402A0A3 RID: 172195
		[Token(Token = "0x402A0A3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Char Info")]
		private Text _textRecruitLv;

		// Token: 0x0402A0A4 RID: 172196
		[Token(Token = "0x402A0A4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Char Info")]
		private Text _textOrigLv;

		// Token: 0x0402A0A5 RID: 172197
		[Token(Token = "0x402A0A5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Char Info")]
		private Text _textPopulation;

		// Token: 0x0402A0A6 RID: 172198
		[Token(Token = "0x402A0A6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Char Info")]
		private Color _colorEliteLimit;

		// Token: 0x0402A0A7 RID: 172199
		[Token(Token = "0x402A0A7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Char Info")]
		private Color _colorEliteNormal;

		// Token: 0x0402A0A8 RID: 172200
		[Token(Token = "0x402A0A8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Char Info")]
		private TwoStateToggle _toggleOnlineState;

		// Token: 0x0402A0A9 RID: 172201
		[Token(Token = "0x402A0A9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Char Info")]
		private Text _textLoginTime;

		// Token: 0x0402A0AA RID: 172202
		[Token(Token = "0x402A0AA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Char Info")]
		private GameObject _requestFriendGo;

		// Token: 0x0402A0AB RID: 172203
		[Token(Token = "0x402A0AB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Char Info")]
		private TwoStateToggle _toggleRequestFriend;

		// Token: 0x0402A0AC RID: 172204
		[Token(Token = "0x402A0AC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _illustParent;

		// Token: 0x0402A0AD RID: 172205
		[Token(Token = "0x402A0AD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RoguelikePopBarView _popBarView;

		// Token: 0x0402A0AE RID: 172206
		[Token(Token = "0x402A0AE")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_inited;

		// Token: 0x0402A0AF RID: 172207
		[Token(Token = "0x402A0AF")]
		[FieldOffset(Offset = "0xE0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402A0B0 RID: 172208
		[Token(Token = "0x402A0B0")]
		[FieldOffset(Offset = "0xE8")]
		private UICharacterIllust m_cacheIllustView;

		// Token: 0x0402A0B1 RID: 172209
		[Token(Token = "0x402A0B1")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A0B2 RID: 172210
		[Token(Token = "0x402A0B2")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402A0B3 RID: 172211
		[Token(Token = "0x402A0B3")]
		[FieldOffset(Offset = "0x110")]
		private string m_cachedUid;

		// Token: 0x0402A0B4 RID: 172212
		[Token(Token = "0x402A0B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402A0B5 RID: 172213
		[Token(Token = "0x402A0B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToggleRequestFriend;

		// Token: 0x0402A0B6 RID: 172214
		[Token(Token = "0x402A0B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFriendAvatarClick;

		// Token: 0x0402A0B7 RID: 172215
		[Token(Token = "0x402A0B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A0B8 RID: 172216
		[Token(Token = "0x402A0B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
