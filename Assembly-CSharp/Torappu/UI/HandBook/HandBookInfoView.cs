using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200669C RID: 26268
	[Token(Token = "0x200669C")]
	public class HandBookInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x06025BAF RID: 154543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025BB0 RID: 154544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005963")]
		public Action<string> onAvgItemClick
		{
			[Token(Token = "0x6025BAF")]
			[Address(RVA = "0x20AE520", Offset = "0x20AD120", VA = "0x1820AE520")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025BB0")]
			[Address(RVA = "0x20AE5F0", Offset = "0x20AD1F0", VA = "0x1820AE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x06025BB1 RID: 154545 RVA: 0x000C8D90 File Offset: 0x000C6F90
		// (set) Token: 0x06025BB2 RID: 154546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005964")]
		public bool isFast
		{
			[Token(Token = "0x6025BB1")]
			[Address(RVA = "0x20AE4C0", Offset = "0x20AD0C0", VA = "0x1820AE4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025BB2")]
			[Address(RVA = "0x20AE580", Offset = "0x20AD180", VA = "0x1820AE580")]
			set
			{
			}
		}

		// Token: 0x06025BB3 RID: 154547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025BB3")]
		[Address(RVA = "0x20ADB50", Offset = "0x20AC750", VA = "0x1820ADB50")]
		private HandBookButtonTab _GetButtonByIndex(int index)
		{
			return null;
		}

		// Token: 0x06025BB4 RID: 154548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BB4")]
		[Address(RVA = "0x20ADE90", Offset = "0x20ACA90", VA = "0x1820ADE90")]
		private void _InitButtonState()
		{
		}

		// Token: 0x06025BB5 RID: 154549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BB5")]
		[Address(RVA = "0x20ABB40", Offset = "0x20AA740", VA = "0x1820ABB40")]
		public void OnClick(int stateID)
		{
		}

		// Token: 0x06025BB6 RID: 154550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BB6")]
		[Address(RVA = "0x20AC130", Offset = "0x20AAD30", VA = "0x1820AC130")]
		public void RenderCurrentBarId()
		{
		}

		// Token: 0x06025BB7 RID: 154551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BB7")]
		[Address(RVA = "0x20ABDB0", Offset = "0x20AA9B0", VA = "0x1820ABDB0")]
		public void OnRewardClick(int index)
		{
		}

		// Token: 0x06025BB8 RID: 154552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BB8")]
		[Address(RVA = "0x20AB120", Offset = "0x20A9D20", VA = "0x1820AB120")]
		public void ApplyData()
		{
		}

		// Token: 0x06025BB9 RID: 154553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BB9")]
		[Address(RVA = "0x20ABF70", Offset = "0x20AAB70", VA = "0x1820ABF70")]
		public void RefreshVoiceLang()
		{
		}

		// Token: 0x06025BBA RID: 154554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BBA")]
		[Address(RVA = "0x20AB8B0", Offset = "0x20AA4B0", VA = "0x1820AB8B0")]
		public void OnAudioPlay(int id)
		{
		}

		// Token: 0x06025BBB RID: 154555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BBB")]
		[Address(RVA = "0x20ABD30", Offset = "0x20AA930", VA = "0x1820ABD30")]
		public void OnEventCancelButton()
		{
		}

		// Token: 0x06025BBC RID: 154556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BBC")]
		[Address(RVA = "0x20AD740", Offset = "0x20AC340", VA = "0x1820AD740")]
		public void UpdateProfessionIcon()
		{
		}

		// Token: 0x06025BBD RID: 154557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025BBD")]
		[Address(RVA = "0x20ADCB0", Offset = "0x20AC8B0", VA = "0x1820ADCB0")]
		private Sprite _GetProfessionSprite(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x06025BBE RID: 154558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BBE")]
		[Address(RVA = "0x20AE0F0", Offset = "0x20ACCF0", VA = "0x1820AE0F0")]
		private void _OnAvgItemClicked(string storyId)
		{
		}

		// Token: 0x06025BBF RID: 154559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BBF")]
		[Address(RVA = "0x20AE210", Offset = "0x20ACE10", VA = "0x1820AE210")]
		private void _RefreshVoiceBarStatus()
		{
		}

		// Token: 0x06025BC0 RID: 154560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC0")]
		[Address(RVA = "0x20AE300", Offset = "0x20ACF00", VA = "0x1820AE300")]
		public HandBookInfoView()
		{
		}

		// Token: 0x04035042 RID: 217154
		[Token(Token = "0x4035042")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04035043 RID: 217155
		[Token(Token = "0x4035043")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nickText;

		// Token: 0x04035044 RID: 217156
		[Token(Token = "0x4035044")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _drawerName;

		// Token: 0x04035045 RID: 217157
		[Token(Token = "0x4035045")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _soundName;

		// Token: 0x04035046 RID: 217158
		[Token(Token = "0x4035046")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _professionIcon;

		// Token: 0x04035047 RID: 217159
		[Token(Token = "0x4035047")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HandBookInfoStateBean _stateBean;

		// Token: 0x04035048 RID: 217160
		[Token(Token = "0x4035048")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _scrollView;

		// Token: 0x04035049 RID: 217161
		[Token(Token = "0x4035049")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator _scrollAnim;

		// Token: 0x0403504A RID: 217162
		[Token(Token = "0x403504A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _lockedText;

		// Token: 0x0403504B RID: 217163
		[Token(Token = "0x403504B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HandbookInfoTextView _infoText;

		// Token: 0x0403504C RID: 217164
		[Token(Token = "0x403504C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HandBookInfoAudioView _infoAudio;

		// Token: 0x0403504D RID: 217165
		[Token(Token = "0x403504D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookAvgGroupView _infoAvg;

		// Token: 0x0403504E RID: 217166
		[Token(Token = "0x403504E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HandbookLockedView _infoLocked;

		// Token: 0x0403504F RID: 217167
		[Token(Token = "0x403504F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HandBookButtonTab[] _buttons;

		// Token: 0x04035050 RID: 217168
		[Token(Token = "0x4035050")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private HandBookButtonTab[] _npcLockedButtons;

		// Token: 0x04035051 RID: 217169
		[Token(Token = "0x4035051")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _campImage;

		// Token: 0x04035052 RID: 217170
		[Token(Token = "0x4035052")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _soundCrossObj;

		// Token: 0x04035053 RID: 217171
		[Token(Token = "0x4035053")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _soundHotSpotObj;

		// Token: 0x04035054 RID: 217172
		[Token(Token = "0x4035054")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _soundUnDownloadMaskObj;

		// Token: 0x04035055 RID: 217173
		[Token(Token = "0x4035055")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _designerObj;

		// Token: 0x04035056 RID: 217174
		[Token(Token = "0x4035056")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _designerHotSpotObj;

		// Token: 0x04035057 RID: 217175
		[Token(Token = "0x4035057")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UnityEvent _onClickEvent;

		// Token: 0x04035058 RID: 217176
		[Token(Token = "0x4035058")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIStringEvent _onClickGroup;

		// Token: 0x04035059 RID: 217177
		[Token(Token = "0x4035059")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UnityEvent _onLockEvent;

		// Token: 0x0403505B RID: 217179
		[Token(Token = "0x403505B")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isFast;

		// Token: 0x0403505C RID: 217180
		[Token(Token = "0x403505C")]
		[FieldOffset(Offset = "0xE4")]
		private int m_barID;

		// Token: 0x0403505D RID: 217181
		[Token(Token = "0x403505D")]
		private const int NPCLOCKEDBUTTONINDEX = 1;

		// Token: 0x0403505E RID: 217182
		[Token(Token = "0x403505E")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_npcAudioHideButtonFlag;

		// Token: 0x0403505F RID: 217183
		[Token(Token = "0x403505F")]
		[FieldOffset(Offset = "0xF0")]
		private List<GameObject> m_objList;

		// Token: 0x04035060 RID: 217184
		[Token(Token = "0x4035060")]
		[FieldOffset(Offset = "0xF8")]
		private List<HandbookLockedView> m_lockedList;

		// Token: 0x04035061 RID: 217185
		[Token(Token = "0x4035061")]
		[FieldOffset(Offset = "0x100")]
		private List<HandBookInfoAudioView> m_audioList;

		// Token: 0x04035062 RID: 217186
		[Token(Token = "0x4035062")]
		[FieldOffset(Offset = "0x108")]
		private List<HandBookAvgGroupView> m_avgList;

		// Token: 0x04035063 RID: 217187
		[Token(Token = "0x4035063")]
		[FieldOffset(Offset = "0x110")]
		private ProfessionSpriteHub m_professionHub;

		// Token: 0x04035064 RID: 217188
		[Token(Token = "0x4035064")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035065 RID: 217189
		[Token(Token = "0x4035065")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onAvgItemClick;

		// Token: 0x04035066 RID: 217190
		[Token(Token = "0x4035066")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onAvgItemClick;

		// Token: 0x04035067 RID: 217191
		[Token(Token = "0x4035067")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFast;

		// Token: 0x04035068 RID: 217192
		[Token(Token = "0x4035068")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isFast;

		// Token: 0x04035069 RID: 217193
		[Token(Token = "0x4035069")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetButtonByIndex;

		// Token: 0x0403506A RID: 217194
		[Token(Token = "0x403506A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitButtonState;

		// Token: 0x0403506B RID: 217195
		[Token(Token = "0x403506B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403506C RID: 217196
		[Token(Token = "0x403506C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderCurrentBarId;

		// Token: 0x0403506D RID: 217197
		[Token(Token = "0x403506D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x0403506E RID: 217198
		[Token(Token = "0x403506E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403506F RID: 217199
		[Token(Token = "0x403506F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshVoiceLang;

		// Token: 0x04035070 RID: 217200
		[Token(Token = "0x4035070")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnAudioPlay;

		// Token: 0x04035071 RID: 217201
		[Token(Token = "0x4035071")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEventCancelButton;

		// Token: 0x04035072 RID: 217202
		[Token(Token = "0x4035072")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateProfessionIcon;

		// Token: 0x04035073 RID: 217203
		[Token(Token = "0x4035073")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetProfessionSprite;

		// Token: 0x04035074 RID: 217204
		[Token(Token = "0x4035074")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnAvgItemClicked;

		// Token: 0x04035075 RID: 217205
		[Token(Token = "0x4035075")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshVoiceBarStatus;

		// Token: 0x04035076 RID: 217206
		[Token(Token = "0x4035076")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
