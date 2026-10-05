using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044B7 RID: 17591
	[Token(Token = "0x20044B7")]
	public class RoguelikeTopicChallengeModeView : RoguelikeTopicSubView
	{
		// Token: 0x0601ADE2 RID: 110050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE2")]
		[Address(RVA = "0x1406700", Offset = "0x1405300", VA = "0x181406700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ADE3 RID: 110051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE3")]
		[Address(RVA = "0x14060F0", Offset = "0x1404CF0", VA = "0x1814060F0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601ADE4 RID: 110052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE4")]
		[Address(RVA = "0x1407110", Offset = "0x1405D10", VA = "0x181407110")]
		private void _Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601ADE5 RID: 110053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ADE5")]
		[Address(RVA = "0x1407080", Offset = "0x1405C80", VA = "0x181407080")]
		private static Sprite _LoadExploringChallengeThumbnail(string topicId, string challengeId)
		{
			return null;
		}

		// Token: 0x0601ADE6 RID: 110054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE6")]
		[Address(RVA = "0x1406080", Offset = "0x1404C80", VA = "0x181406080")]
		public void EventOnPreChallenge()
		{
		}

		// Token: 0x0601ADE7 RID: 110055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE7")]
		[Address(RVA = "0x1406010", Offset = "0x1404C10", VA = "0x181406010")]
		public void EventOnNextChallenge()
		{
		}

		// Token: 0x0601ADE8 RID: 110056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE8")]
		[Address(RVA = "0x1406670", Offset = "0x1405270", VA = "0x181406670")]
		private void _EventOnOpenRewardDetail()
		{
		}

		// Token: 0x0601ADE9 RID: 110057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE9")]
		[Address(RVA = "0x1406530", Offset = "0x1405130", VA = "0x181406530")]
		private void _EventChanllengeBeginChange(int selectIdx)
		{
		}

		// Token: 0x0601ADEA RID: 110058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADEA")]
		[Address(RVA = "0x1406280", Offset = "0x1404E80", VA = "0x181406280")]
		private void _EventChallengeGroupSwitch(float perPageSwitchDur)
		{
		}

		// Token: 0x0601ADEB RID: 110059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ADEB")]
		[Address(RVA = "0x1407BB0", Offset = "0x14067B0", VA = "0x181407BB0")]
		private IEnumerator _SwitchToPage(int switchPageCount, float perPageSwitchDur)
		{
			return null;
		}

		// Token: 0x0601ADEC RID: 110060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADEC")]
		[Address(RVA = "0x1407AF0", Offset = "0x14066F0", VA = "0x181407AF0")]
		private void _StopPageSwitchCoroutine()
		{
		}

		// Token: 0x0601ADED RID: 110061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADED")]
		[Address(RVA = "0x1407C90", Offset = "0x1406890", VA = "0x181407C90")]
		public RoguelikeTopicChallengeModeView()
		{
		}

		// Token: 0x0601ADEE RID: 110062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADEE")]
		[Address(RVA = "0x1406270", Offset = "0x1404E70", VA = "0x181406270")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x040226CA RID: 141002
		[Token(Token = "0x40226CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x040226CB RID: 141003
		[Token(Token = "0x40226CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlNormal;

		// Token: 0x040226CC RID: 141004
		[Token(Token = "0x40226CC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlExploring;

		// Token: 0x040226CD RID: 141005
		[Token(Token = "0x40226CD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _transLogoHolder;

		// Token: 0x040226CE RID: 141006
		[Token(Token = "0x40226CE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _transCompleteProgressHolder;

		// Token: 0x040226CF RID: 141007
		[Token(Token = "0x40226CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Normal")]
		private RectTransform _toggleGroupHolder;

		// Token: 0x040226D0 RID: 141008
		[Token(Token = "0x40226D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Normal")]
		private LoopPagePicker _picker;

		// Token: 0x040226D1 RID: 141009
		[Token(Token = "0x40226D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Normal")]
		private RectTransform _challengeGroupHolder;

		// Token: 0x040226D2 RID: 141010
		[Token(Token = "0x40226D2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Exploring")]
		private Image _imgExploringChallenge;

		// Token: 0x040226D3 RID: 141011
		[Token(Token = "0x40226D3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Exploring")]
		private Text _textExploringChallengeName;

		// Token: 0x040226D4 RID: 141012
		[Token(Token = "0x40226D4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Exploring")]
		private Text _textExploringChallengeDesc;

		// Token: 0x040226D5 RID: 141013
		[Token(Token = "0x40226D5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Exploring")]
		private UIAtlasImage _imgExploringDeco;

		// Token: 0x040226D6 RID: 141014
		[Token(Token = "0x40226D6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Exploring")]
		private UIAtlasImage _imgExploringChallengePrefix;

		// Token: 0x040226D7 RID: 141015
		[Token(Token = "0x40226D7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _infoHolder;

		// Token: 0x040226D8 RID: 141016
		[Token(Token = "0x40226D8")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeTopicChallengePluginContext m_pluginContext;

		// Token: 0x040226D9 RID: 141017
		[Token(Token = "0x40226D9")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_pageSwitchCoroutine;

		// Token: 0x040226DA RID: 141018
		[Token(Token = "0x40226DA")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeTopicModeViewModel m_cachedModel;

		// Token: 0x040226DB RID: 141019
		[Token(Token = "0x40226DB")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedChallengeId;

		// Token: 0x040226DC RID: 141020
		[Token(Token = "0x40226DC")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTopicId;

		// Token: 0x040226DD RID: 141021
		[Token(Token = "0x40226DD")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeTopicChallengeModeView.PickerDataSource m_pickerData;

		// Token: 0x040226DE RID: 141022
		[Token(Token = "0x40226DE")]
		[FieldOffset(Offset = "0xC8")]
		private RoguelikeTopicChallengeToggleGroup m_toggleGroup;

		// Token: 0x040226DF RID: 141023
		[Token(Token = "0x40226DF")]
		[FieldOffset(Offset = "0xD0")]
		private RoguelikeTopicChallengeProgress m_completeProgress;

		// Token: 0x040226E0 RID: 141024
		[Token(Token = "0x40226E0")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeTopicChallengeGroup m_challengeGroup;

		// Token: 0x040226E1 RID: 141025
		[Token(Token = "0x40226E1")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeTopicChallengeModeInfoViewBase m_infoView;

		// Token: 0x040226E2 RID: 141026
		[Token(Token = "0x40226E2")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x040226E3 RID: 141027
		[Token(Token = "0x40226E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040226E4 RID: 141028
		[Token(Token = "0x40226E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040226E5 RID: 141029
		[Token(Token = "0x40226E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040226E6 RID: 141030
		[Token(Token = "0x40226E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadExploringChallengeThumbnail;

		// Token: 0x040226E7 RID: 141031
		[Token(Token = "0x40226E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnPreChallenge;

		// Token: 0x040226E8 RID: 141032
		[Token(Token = "0x40226E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnNextChallenge;

		// Token: 0x040226E9 RID: 141033
		[Token(Token = "0x40226E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnOpenRewardDetail;

		// Token: 0x040226EA RID: 141034
		[Token(Token = "0x40226EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventChanllengeBeginChange;

		// Token: 0x040226EB RID: 141035
		[Token(Token = "0x40226EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventChallengeGroupSwitch;

		// Token: 0x040226EC RID: 141036
		[Token(Token = "0x40226EC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SwitchToPage;

		// Token: 0x040226ED RID: 141037
		[Token(Token = "0x40226ED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StopPageSwitchCoroutine;

		// Token: 0x040226EE RID: 141038
		[Token(Token = "0x40226EE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044B8 RID: 17592
		[Token(Token = "0x20044B8")]
		private class PickerDataSource : LoopPagePicker.IDataSource, IHotfixable
		{
			// Token: 0x0601ADEF RID: 110063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADEF")]
			[Address(RVA = "0x1401E20", Offset = "0x1400A20", VA = "0x181401E20")]
			public PickerDataSource(RoguelikeTopicChallengeModeViewModel model, RoguelikeTopicChallengeCard pageViewPrefab, RoguelikeTopicChallengeModelStyle style)
			{
			}

			// Token: 0x17003FC5 RID: 16325
			// (get) Token: 0x0601ADF0 RID: 110064 RVA: 0x000A3830 File Offset: 0x000A1A30
			[Token(Token = "0x17003FC5")]
			public int pageCount
			{
				[Token(Token = "0x601ADF0")]
				[Address(RVA = "0x1401EE0", Offset = "0x1400AE0", VA = "0x181401EE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ADF1 RID: 110065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ADF1")]
			[Address(RVA = "0x1401AF0", Offset = "0x14006F0", VA = "0x181401AF0", Slot = "6")]
			public LoopPagePicker.IPageView CreatePage(Transform root)
			{
				return null;
			}

			// Token: 0x0601ADF2 RID: 110066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADF2")]
			[Address(RVA = "0x1401BA0", Offset = "0x14007A0", VA = "0x181401BA0", Slot = "5")]
			public void FlushData(LoopPagePicker.IPageView page, int pageIdx)
			{
			}

			// Token: 0x0601ADF3 RID: 110067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ADF3")]
			[Address(RVA = "0x1401D60", Offset = "0x1400960", VA = "0x181401D60")]
			public string GetChallenge(int idx)
			{
				return null;
			}

			// Token: 0x040226EF RID: 141039
			[Token(Token = "0x40226EF")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeTopicChallengeModeViewModel m_model;

			// Token: 0x040226F0 RID: 141040
			[Token(Token = "0x40226F0")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeTopicChallengeCard m_pageViewPrefab;

			// Token: 0x040226F1 RID: 141041
			[Token(Token = "0x40226F1")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicChallengeModelStyle m_style;

			// Token: 0x040226F2 RID: 141042
			[Token(Token = "0x40226F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040226F3 RID: 141043
			[Token(Token = "0x40226F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_pageCount;

			// Token: 0x040226F4 RID: 141044
			[Token(Token = "0x40226F4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CreatePage;

			// Token: 0x040226F5 RID: 141045
			[Token(Token = "0x40226F5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FlushData;

			// Token: 0x040226F6 RID: 141046
			[Token(Token = "0x40226F6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetChallenge;
		}
	}
}
