using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052E6 RID: 21222
	[Token(Token = "0x20052E6")]
	public class RoguelikeFriendAssistListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x0601F4CC RID: 128204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F4CD RID: 128205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004972")]
		public Action<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData> onItemClick
		{
			[Token(Token = "0x601F4CC")]
			[Address(RVA = "0x1905B50", Offset = "0x1904750", VA = "0x181905B50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F4CD")]
			[Address(RVA = "0x1905BB0", Offset = "0x19047B0", VA = "0x181905BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F4CE RID: 128206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4CE")]
		[Address(RVA = "0x1905150", Offset = "0x1903D50", VA = "0x181905150")]
		public void Render(PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData friendAssistData, int population)
		{
		}

		// Token: 0x0601F4CF RID: 128207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4CF")]
		[Address(RVA = "0x1905980", Offset = "0x1904580", VA = "0x181905980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F4D0 RID: 128208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D0")]
		[Address(RVA = "0x1905070", Offset = "0x1903C70", VA = "0x181905070")]
		public void OnItemClick()
		{
		}

		// Token: 0x0601F4D1 RID: 128209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D1")]
		[Address(RVA = "0x1904D90", Offset = "0x1903990", VA = "0x181904D90")]
		public void OnDetailClick()
		{
		}

		// Token: 0x0601F4D2 RID: 128210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D2")]
		[Address(RVA = "0x1904F90", Offset = "0x1903B90", VA = "0x181904F90")]
		public void OnFriendAvatarClick()
		{
		}

		// Token: 0x0601F4D3 RID: 128211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4D3")]
		[Address(RVA = "0x1905AE0", Offset = "0x19046E0", VA = "0x181905AE0")]
		public RoguelikeFriendAssistListItemView()
		{
		}

		// Token: 0x0402A0B9 RID: 172217
		[Token(Token = "0x402A0B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0402A0BA RID: 172218
		[Token(Token = "0x402A0BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x0402A0BB RID: 172219
		[Token(Token = "0x402A0BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0402A0BC RID: 172220
		[Token(Token = "0x402A0BC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Char Info")]
		private UIAtlasImage _charPortrait;

		// Token: 0x0402A0BD RID: 172221
		[Token(Token = "0x402A0BD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Char Info")]
		private Text _charNameText;

		// Token: 0x0402A0BE RID: 172222
		[Token(Token = "0x402A0BE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Char Info")]
		private Text _charLevelText;

		// Token: 0x0402A0BF RID: 172223
		[Token(Token = "0x402A0BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Char Info")]
		private Image _potentialImg;

		// Token: 0x0402A0C0 RID: 172224
		[Token(Token = "0x402A0C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Char Info")]
		private Image _eliteImg;

		// Token: 0x0402A0C1 RID: 172225
		[Token(Token = "0x402A0C1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _friendLevelText;

		// Token: 0x0402A0C2 RID: 172226
		[Token(Token = "0x402A0C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelNoteObject;

		// Token: 0x0402A0C3 RID: 172227
		[Token(Token = "0x402A0C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelNameObject;

		// Token: 0x0402A0C4 RID: 172228
		[Token(Token = "0x402A0C4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _aliasText;

		// Token: 0x0402A0C5 RID: 172229
		[Token(Token = "0x402A0C5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _nickNameText;

		// Token: 0x0402A0C6 RID: 172230
		[Token(Token = "0x402A0C6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _nickNumText;

		// Token: 0x0402A0C7 RID: 172231
		[Token(Token = "0x402A0C7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _loginTimeText;

		// Token: 0x0402A0C8 RID: 172232
		[Token(Token = "0x402A0C8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _requestFriendObject;

		// Token: 0x0402A0C9 RID: 172233
		[Token(Token = "0x402A0C9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _requestSystemObject;

		// Token: 0x0402A0CA RID: 172234
		[Token(Token = "0x402A0CA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textPopulation;

		// Token: 0x0402A0CB RID: 172235
		[Token(Token = "0x402A0CB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorPopulationNormal;

		// Token: 0x0402A0CC RID: 172236
		[Token(Token = "0x402A0CC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorPopulationLack;

		// Token: 0x0402A0CD RID: 172237
		[Token(Token = "0x402A0CD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0402A0CE RID: 172238
		[Token(Token = "0x402A0CE")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button _clickBtn;

		// Token: 0x0402A0CF RID: 172239
		[Token(Token = "0x402A0CF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _starFriendBgMask;

		// Token: 0x0402A0D0 RID: 172240
		[Token(Token = "0x402A0D0")]
		[FieldOffset(Offset = "0xE0")]
		private PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData m_assistData;

		// Token: 0x0402A0D1 RID: 172241
		[Token(Token = "0x402A0D1")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isFriend;

		// Token: 0x0402A0D2 RID: 172242
		[Token(Token = "0x402A0D2")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_inited;

		// Token: 0x0402A0D3 RID: 172243
		[Token(Token = "0x402A0D3")]
		[FieldOffset(Offset = "0xF0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402A0D4 RID: 172244
		[Token(Token = "0x402A0D4")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_cachePopAvailFlag;

		// Token: 0x0402A0D5 RID: 172245
		[Token(Token = "0x402A0D5")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402A0D6 RID: 172246
		[Token(Token = "0x402A0D6")]
		[FieldOffset(Offset = "0x110")]
		private string m_cachedUid;

		// Token: 0x0402A0D8 RID: 172248
		[Token(Token = "0x402A0D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402A0D9 RID: 172249
		[Token(Token = "0x402A0D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402A0DA RID: 172250
		[Token(Token = "0x402A0DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A0DB RID: 172251
		[Token(Token = "0x402A0DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A0DC RID: 172252
		[Token(Token = "0x402A0DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0402A0DD RID: 172253
		[Token(Token = "0x402A0DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x0402A0DE RID: 172254
		[Token(Token = "0x402A0DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnFriendAvatarClick;

		// Token: 0x0402A0DF RID: 172255
		[Token(Token = "0x402A0DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
