using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A3A RID: 27194
	[Token(Token = "0x2006A3A")]
	public class Main10ZoneRecordCommonView : DataBinder<Main10ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x06026DDC RID: 159196 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026DDD RID: 159197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BB1")]
		public Main10ZoneRecordController controller
		{
			[Token(Token = "0x6026DDC")]
			[Address(RVA = "0x21EC500", Offset = "0x21EB100", VA = "0x1821EC500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026DDD")]
			[Address(RVA = "0x21EC560", Offset = "0x21EB160", VA = "0x1821EC560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026DDE RID: 159198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DDE")]
		[Address(RVA = "0x21EA920", Offset = "0x21E9520", VA = "0x1821EA920")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x06026DDF RID: 159199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DDF")]
		[Address(RVA = "0x21EB070", Offset = "0x21E9C70", VA = "0x1821EB070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026DE0 RID: 159200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026DE0")]
		[Address(RVA = "0x21EAF60", Offset = "0x21E9B60", VA = "0x1821EAF60")]
		private AnimationSwitchTween _EnsureUnlockSwitch()
		{
			return null;
		}

		// Token: 0x06026DE1 RID: 159201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE1")]
		[Address(RVA = "0x21EAF00", Offset = "0x21E9B00", VA = "0x1821EAF00")]
		private void _EnsureUnlockItemStatus()
		{
		}

		// Token: 0x06026DE2 RID: 159202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026DE2")]
		[Address(RVA = "0x21EADF0", Offset = "0x21E99F0", VA = "0x1821EADF0")]
		private AnimationSwitchTween _EnsurePicOnlySwitch()
		{
			return null;
		}

		// Token: 0x06026DE3 RID: 159203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE3")]
		[Address(RVA = "0x21EA9A0", Offset = "0x21E95A0", VA = "0x1821EA9A0", Slot = "7")]
		public override void OnValueChanged(Main10ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026DE4 RID: 159204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE4")]
		[Address(RVA = "0x21EAD20", Offset = "0x21E9920", VA = "0x1821EAD20")]
		public void PlayUnlockTips()
		{
		}

		// Token: 0x06026DE5 RID: 159205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE5")]
		[Address(RVA = "0x21EA8A0", Offset = "0x21E94A0", VA = "0x1821EA8A0")]
		public void HideUnlockTips()
		{
		}

		// Token: 0x06026DE6 RID: 159206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE6")]
		[Address(RVA = "0x21EA6E0", Offset = "0x21E92E0", VA = "0x1821EA6E0")]
		public void EventOnUnlockedPicSwitch()
		{
		}

		// Token: 0x06026DE7 RID: 159207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE7")]
		[Address(RVA = "0x21EB4F0", Offset = "0x21EA0F0", VA = "0x1821EB4F0")]
		private void _RenderContent()
		{
		}

		// Token: 0x06026DE8 RID: 159208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE8")]
		[Address(RVA = "0x21EB2F0", Offset = "0x21E9EF0", VA = "0x1821EB2F0")]
		private void _OnContentEvent(string recordId)
		{
		}

		// Token: 0x06026DE9 RID: 159209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DE9")]
		[Address(RVA = "0x21EBFA0", Offset = "0x21EABA0", VA = "0x1821EBFA0")]
		private void _Render(ZoneRecordGroupViewModel viewModel)
		{
		}

		// Token: 0x06026DEA RID: 159210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DEA")]
		[Address(RVA = "0x21EB380", Offset = "0x21E9F80", VA = "0x1821EB380")]
		private void _RefreshBtnStatus()
		{
		}

		// Token: 0x06026DEB RID: 159211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DEB")]
		[Address(RVA = "0x21EBA20", Offset = "0x21EA620", VA = "0x1821EBA20")]
		private void _RenderNotePart()
		{
		}

		// Token: 0x06026DEC RID: 159212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DEC")]
		[Address(RVA = "0x21EBDF0", Offset = "0x21EA9F0", VA = "0x1821EBDF0")]
		private void _RenderNoteReward()
		{
		}

		// Token: 0x06026DED RID: 159213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DED")]
		[Address(RVA = "0x21EB680", Offset = "0x21EA280", VA = "0x1821EB680")]
		private void _RenderCoverPart()
		{
		}

		// Token: 0x06026DEE RID: 159214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DEE")]
		[Address(RVA = "0x21EBE70", Offset = "0x21EAA70", VA = "0x1821EBE70")]
		private void _RenderRewardStatus(ZoneRecordGroupViewModel viewModel)
		{
		}

		// Token: 0x06026DEF RID: 159215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DEF")]
		[Address(RVA = "0x21EB8F0", Offset = "0x21EA4F0", VA = "0x1821EB8F0")]
		private void _RenderDiffRewards(Text cntText, ZoneRecordGroupViewModel.DiffRewardStatus status)
		{
		}

		// Token: 0x06026DF0 RID: 159216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DF0")]
		[Address(RVA = "0x21EB200", Offset = "0x21E9E00", VA = "0x1821EB200")]
		private void _InitNote()
		{
		}

		// Token: 0x06026DF1 RID: 159217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DF1")]
		[Address(RVA = "0x21EC280", Offset = "0x21EAE80", VA = "0x1821EC280")]
		private void _TryLoadPic(Image img, ZoneRecordRewardViewModel viewModel)
		{
		}

		// Token: 0x06026DF2 RID: 159218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026DF2")]
		[Address(RVA = "0x21EC370", Offset = "0x21EAF70", VA = "0x1821EC370")]
		private GameObject _TryLoadToughPicPrefab(string prefabName)
		{
			return null;
		}

		// Token: 0x06026DF3 RID: 159219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DF3")]
		[Address(RVA = "0x21EC490", Offset = "0x21EB090", VA = "0x1821EC490")]
		public Main10ZoneRecordCommonView()
		{
		}

		// Token: 0x04036F45 RID: 225093
		[Token(Token = "0x4036F45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04036F46 RID: 225094
		[Token(Token = "0x4036F46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _coverPanel;

		// Token: 0x04036F47 RID: 225095
		[Token(Token = "0x4036F47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imgCoverUnlocked;

		// Token: 0x04036F48 RID: 225096
		[Token(Token = "0x4036F48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _normalCount;

		// Token: 0x04036F49 RID: 225097
		[Token(Token = "0x4036F49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _easyCount;

		// Token: 0x04036F4A RID: 225098
		[Token(Token = "0x4036F4A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _toughCount;

		// Token: 0x04036F4B RID: 225099
		[Token(Token = "0x4036F4B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _noteTitle;

		// Token: 0x04036F4C RID: 225100
		[Token(Token = "0x4036F4C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _noteDesc;

		// Token: 0x04036F4D RID: 225101
		[Token(Token = "0x4036F4D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _notePanel;

		// Token: 0x04036F4E RID: 225102
		[Token(Token = "0x4036F4E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _imgNoteUnlocked;

		// Token: 0x04036F4F RID: 225103
		[Token(Token = "0x4036F4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _blankDesc;

		// Token: 0x04036F50 RID: 225104
		[Token(Token = "0x4036F50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgEasyPic;

		// Token: 0x04036F51 RID: 225105
		[Token(Token = "0x4036F51")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgNormalPic;

		// Token: 0x04036F52 RID: 225106
		[Token(Token = "0x4036F52")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _imgToughContainer;

		// Token: 0x04036F53 RID: 225107
		[Token(Token = "0x4036F53")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _btnNext;

		// Token: 0x04036F54 RID: 225108
		[Token(Token = "0x4036F54")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _btnPrev;

		// Token: 0x04036F55 RID: 225109
		[Token(Token = "0x4036F55")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _btnNormalNote;

		// Token: 0x04036F56 RID: 225110
		[Token(Token = "0x4036F56")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _btnToughNote;

		// Token: 0x04036F57 RID: 225111
		[Token(Token = "0x4036F57")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _rectRewardPartParent;

		// Token: 0x04036F58 RID: 225112
		[Token(Token = "0x4036F58")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ZoneRecordRewardContentView _rewardContentPrefab;

		// Token: 0x04036F59 RID: 225113
		[Token(Token = "0x4036F59")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _unlockTips;

		// Token: 0x04036F5A RID: 225114
		[Token(Token = "0x4036F5A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _picWithTipsSwitchAnim;

		// Token: 0x04036F5B RID: 225115
		[Token(Token = "0x4036F5B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _onlyPicSwitchAnim;

		// Token: 0x04036F5C RID: 225116
		[Token(Token = "0x4036F5C")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public Action<string> eventOnContentClick;

		// Token: 0x04036F5D RID: 225117
		[Token(Token = "0x4036F5D")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public Action onClaimAllRewardClick;

		// Token: 0x04036F5E RID: 225118
		[Token(Token = "0x4036F5E")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isInited;

		// Token: 0x04036F5F RID: 225119
		[Token(Token = "0x4036F5F")]
		[FieldOffset(Offset = "0x100")]
		private Main10ZoneRecordGroupViewModel m_cachedViewModel;

		// Token: 0x04036F60 RID: 225120
		[Token(Token = "0x4036F60")]
		[FieldOffset(Offset = "0x108")]
		private UIPage m_page;

		// Token: 0x04036F61 RID: 225121
		[Token(Token = "0x4036F61")]
		[FieldOffset(Offset = "0x110")]
		private AnimationSwitchTween m_unlockSwitch;

		// Token: 0x04036F62 RID: 225122
		[Token(Token = "0x4036F62")]
		[FieldOffset(Offset = "0x118")]
		private AnimationSwitchTween m_picSwitch;

		// Token: 0x04036F63 RID: 225123
		[Token(Token = "0x4036F63")]
		[FieldOffset(Offset = "0x120")]
		private ZoneRecordRewardContentView m_rewardContentView;

		// Token: 0x04036F65 RID: 225125
		[Token(Token = "0x4036F65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04036F66 RID: 225126
		[Token(Token = "0x4036F66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04036F67 RID: 225127
		[Token(Token = "0x4036F67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04036F68 RID: 225128
		[Token(Token = "0x4036F68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036F69 RID: 225129
		[Token(Token = "0x4036F69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureUnlockSwitch;

		// Token: 0x04036F6A RID: 225130
		[Token(Token = "0x4036F6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureUnlockItemStatus;

		// Token: 0x04036F6B RID: 225131
		[Token(Token = "0x4036F6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsurePicOnlySwitch;

		// Token: 0x04036F6C RID: 225132
		[Token(Token = "0x4036F6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036F6D RID: 225133
		[Token(Token = "0x4036F6D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PlayUnlockTips;

		// Token: 0x04036F6E RID: 225134
		[Token(Token = "0x4036F6E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideUnlockTips;

		// Token: 0x04036F6F RID: 225135
		[Token(Token = "0x4036F6F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnUnlockedPicSwitch;

		// Token: 0x04036F70 RID: 225136
		[Token(Token = "0x4036F70")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x04036F71 RID: 225137
		[Token(Token = "0x4036F71")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnContentEvent;

		// Token: 0x04036F72 RID: 225138
		[Token(Token = "0x4036F72")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04036F73 RID: 225139
		[Token(Token = "0x4036F73")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshBtnStatus;

		// Token: 0x04036F74 RID: 225140
		[Token(Token = "0x4036F74")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderNotePart;

		// Token: 0x04036F75 RID: 225141
		[Token(Token = "0x4036F75")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderNoteReward;

		// Token: 0x04036F76 RID: 225142
		[Token(Token = "0x4036F76")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RenderCoverPart;

		// Token: 0x04036F77 RID: 225143
		[Token(Token = "0x4036F77")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RenderRewardStatus;

		// Token: 0x04036F78 RID: 225144
		[Token(Token = "0x4036F78")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RenderDiffRewards;

		// Token: 0x04036F79 RID: 225145
		[Token(Token = "0x4036F79")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitNote;

		// Token: 0x04036F7A RID: 225146
		[Token(Token = "0x4036F7A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryLoadPic;

		// Token: 0x04036F7B RID: 225147
		[Token(Token = "0x4036F7B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryLoadToughPicPrefab;

		// Token: 0x04036F7C RID: 225148
		[Token(Token = "0x4036F7C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A3B RID: 27195
		[Token(Token = "0x2006A3B")]
		private class ZoneRecordContentAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005BB2 RID: 23474
			// (get) Token: 0x06026DF4 RID: 159220 RVA: 0x000CC8D0 File Offset: 0x000CAAD0
			[Token(Token = "0x17005BB2")]
			public override int count
			{
				[Token(Token = "0x6026DF4")]
				[Address(RVA = "0x21FE130", Offset = "0x21FCD30", VA = "0x1821FE130", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026DF5 RID: 159221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026DF5")]
			[Address(RVA = "0x21FDF20", Offset = "0x21FCB20", VA = "0x1821FDF20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026DF6 RID: 159222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026DF6")]
			[Address(RVA = "0x21FE0D0", Offset = "0x21FCCD0", VA = "0x1821FE0D0")]
			public ZoneRecordContentAdapter()
			{
			}

			// Token: 0x04036F7D RID: 225149
			[Token(Token = "0x4036F7D")]
			[FieldOffset(Offset = "0x20")]
			public List<ZoneRecordViewModel> recordList;

			// Token: 0x04036F7E RID: 225150
			[Token(Token = "0x4036F7E")]
			[FieldOffset(Offset = "0x28")]
			public Action<string> clickAction;

			// Token: 0x04036F7F RID: 225151
			[Token(Token = "0x4036F7F")]
			[FieldOffset(Offset = "0x30")]
			public string selectedRecordId;

			// Token: 0x04036F80 RID: 225152
			[Token(Token = "0x4036F80")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036F81 RID: 225153
			[Token(Token = "0x4036F81")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04036F82 RID: 225154
			[Token(Token = "0x4036F82")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
