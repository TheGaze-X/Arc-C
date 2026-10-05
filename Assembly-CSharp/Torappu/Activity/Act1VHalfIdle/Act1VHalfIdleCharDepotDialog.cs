using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007747 RID: 30535
	[Token(Token = "0x2007747")]
	public class Act1VHalfIdleCharDepotDialog : UICompDialog<Act1VHalfIdleCharDepotDialog.Option>
	{
		// Token: 0x0602AE4B RID: 175691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE4B")]
		[Address(RVA = "0x26AD310", Offset = "0x26ABF10", VA = "0x1826AD310")]
		private void _InitIfNot(Act1VHalfIdleCharDepotDialog.Option input)
		{
		}

		// Token: 0x0602AE4C RID: 175692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE4C")]
		[Address(RVA = "0x26AD020", Offset = "0x26ABC20", VA = "0x1826AD020", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleCharDepotDialog.Option input)
		{
		}

		// Token: 0x0602AE4D RID: 175693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE4D")]
		[Address(RVA = "0x26AD0F0", Offset = "0x26ABCF0", VA = "0x1826AD0F0", Slot = "12")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AE4E RID: 175694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE4E")]
		[Address(RVA = "0x26ADD40", Offset = "0x26AC940", VA = "0x1826ADD40")]
		private void _UpdateTrack(string actId)
		{
		}

		// Token: 0x0602AE4F RID: 175695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE4F")]
		[Address(RVA = "0x26ADE50", Offset = "0x26ACA50", VA = "0x1826ADE50")]
		private void _UpdateView(bool forceCollectChars = false, bool forceResetTopShow = false, bool needFocus = false, int focusCharInstId = -1)
		{
		}

		// Token: 0x0602AE50 RID: 175696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE50")]
		[Address(RVA = "0x26ADB30", Offset = "0x26AC730", VA = "0x1826ADB30")]
		private void _UpdateAssistCount()
		{
		}

		// Token: 0x0602AE51 RID: 175697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE51")]
		[Address(RVA = "0x26AD770", Offset = "0x26AC370", VA = "0x1826AD770")]
		private void _OnCharCardClicked(Act1VHalfIdleCharDepotCard.Options options)
		{
		}

		// Token: 0x0602AE52 RID: 175698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE52")]
		[Address(RVA = "0x26AD230", Offset = "0x26ABE30", VA = "0x1826AD230")]
		private void _EventOnSetSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x0602AE53 RID: 175699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE53")]
		[Address(RVA = "0x26AD180", Offset = "0x26ABD80", VA = "0x1826AD180")]
		private void _EventOnSetFilter(UICharacterProfessionFilterHolder.FilterParam filter)
		{
		}

		// Token: 0x0602AE54 RID: 175700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE54")]
		[Address(RVA = "0x26ACF80", Offset = "0x26ABB80", VA = "0x1826ACF80")]
		public void EventOnClickBuff()
		{
		}

		// Token: 0x0602AE55 RID: 175701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE55")]
		[Address(RVA = "0x26ACEE0", Offset = "0x26ABAE0", VA = "0x1826ACEE0")]
		public void EventOnClickAssist()
		{
		}

		// Token: 0x0602AE56 RID: 175702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE56")]
		[Address(RVA = "0x26ADA30", Offset = "0x26AC630", VA = "0x1826ADA30")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x0602AE57 RID: 175703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE57")]
		[Address(RVA = "0x26AE150", Offset = "0x26ACD50", VA = "0x1826AE150")]
		public Act1VHalfIdleCharDepotDialog()
		{
		}

		// Token: 0x0602AE58 RID: 175704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE58")]
		[Address(RVA = "0x2149FE0", Offset = "0x2148BE0", VA = "0x182149FE0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403DD8B RID: 253323
		[Token(Token = "0x403DD8B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleCharDepotCharsHolderView _charsHolderView;

		// Token: 0x0403DD8C RID: 253324
		[Token(Token = "0x403DD8C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Avt1VHalfIdleCharDepotShuffleView _charDepotShuffleView;

		// Token: 0x0403DD8D RID: 253325
		[Token(Token = "0x403DD8D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIActTrackPoint _buffTrack;

		// Token: 0x0403DD8E RID: 253326
		[Token(Token = "0x403DD8E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _curAssistNum;

		// Token: 0x0403DD8F RID: 253327
		[Token(Token = "0x403DD8F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _maxAssistNum;

		// Token: 0x0403DD90 RID: 253328
		[Token(Token = "0x403DD90")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _btnAssist;

		// Token: 0x0403DD91 RID: 253329
		[Token(Token = "0x403DD91")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _btnCharBuff;

		// Token: 0x0403DD92 RID: 253330
		[Token(Token = "0x403DD92")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0403DD93 RID: 253331
		[Token(Token = "0x403DD93")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DD94 RID: 253332
		[Token(Token = "0x403DD94")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedActId;

		// Token: 0x0403DD95 RID: 253333
		[Token(Token = "0x403DD95")]
		[FieldOffset(Offset = "0xC8")]
		private int m_focusCharInstId;

		// Token: 0x0403DD96 RID: 253334
		[Token(Token = "0x403DD96")]
		[FieldOffset(Offset = "0xD0")]
		private CommonCharSelectShuffleDefaultViewModel m_filterViewModel;

		// Token: 0x0403DD97 RID: 253335
		[Token(Token = "0x403DD97")]
		[FieldOffset(Offset = "0xD8")]
		private TrackPointViewProperty m_buffTrack;

		// Token: 0x0403DD98 RID: 253336
		[Token(Token = "0x403DD98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DD99 RID: 253337
		[Token(Token = "0x403DD99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403DD9A RID: 253338
		[Token(Token = "0x403DD9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403DD9B RID: 253339
		[Token(Token = "0x403DD9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTrack;

		// Token: 0x0403DD9C RID: 253340
		[Token(Token = "0x403DD9C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0403DD9D RID: 253341
		[Token(Token = "0x403DD9D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateAssistCount;

		// Token: 0x0403DD9E RID: 253342
		[Token(Token = "0x403DD9E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x0403DD9F RID: 253343
		[Token(Token = "0x403DD9F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnSetSortType;

		// Token: 0x0403DDA0 RID: 253344
		[Token(Token = "0x403DDA0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnSetFilter;

		// Token: 0x0403DDA1 RID: 253345
		[Token(Token = "0x403DDA1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnClickBuff;

		// Token: 0x0403DDA2 RID: 253346
		[Token(Token = "0x403DDA2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnClickAssist;

		// Token: 0x0403DDA3 RID: 253347
		[Token(Token = "0x403DDA3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x0403DDA4 RID: 253348
		[Token(Token = "0x403DDA4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007748 RID: 30536
		[Token(Token = "0x2007748")]
		public class Option : IHotfixable
		{
			// Token: 0x0602AE59 RID: 175705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE59")]
			[Address(RVA = "0x26C26C0", Offset = "0x26C12C0", VA = "0x1826C26C0")]
			public Option()
			{
			}

			// Token: 0x0403DDA5 RID: 253349
			[Token(Token = "0x403DDA5")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403DDA6 RID: 253350
			[Token(Token = "0x403DDA6")]
			[FieldOffset(Offset = "0x18")]
			public string pageName;

			// Token: 0x0403DDA7 RID: 253351
			[Token(Token = "0x403DDA7")]
			[FieldOffset(Offset = "0x20")]
			public CharacterSortType sortType;

			// Token: 0x0403DDA8 RID: 253352
			[Token(Token = "0x403DDA8")]
			[FieldOffset(Offset = "0x28")]
			public CharacterProfessionFilterParam filterParam;

			// Token: 0x0403DDA9 RID: 253353
			[Token(Token = "0x403DDA9")]
			[FieldOffset(Offset = "0x38")]
			public int focusCharInstId;

			// Token: 0x0403DDAA RID: 253354
			[Token(Token = "0x403DDAA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007749 RID: 30537
		[Token(Token = "0x2007749")]
		private class BuffTrackModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x0602AE5A RID: 175706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE5A")]
			[Address(RVA = "0x26C23C0", Offset = "0x26C0FC0", VA = "0x1826C23C0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17006499 RID: 25753
			// (get) Token: 0x0602AE5B RID: 175707 RVA: 0x000DA5C8 File Offset: 0x000D87C8
			[Token(Token = "0x17006499")]
			public bool isShow
			{
				[Token(Token = "0x602AE5B")]
				[Address(RVA = "0x26C2550", Offset = "0x26C1150", VA = "0x1826C2550", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AE5C RID: 175708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE5C")]
			[Address(RVA = "0x26C24A0", Offset = "0x26C10A0", VA = "0x1826C24A0")]
			public BuffTrackModel()
			{
			}

			// Token: 0x0403DDAB RID: 253355
			[Token(Token = "0x403DDAB")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403DDAC RID: 253356
			[Token(Token = "0x403DDAC")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<int, List<Act1VHalfIdleCharAvatarViewModel>> m_profMap;

			// Token: 0x0403DDAD RID: 253357
			[Token(Token = "0x403DDAD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DDAE RID: 253358
			[Token(Token = "0x403DDAE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DDAF RID: 253359
			[Token(Token = "0x403DDAF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200774A RID: 30538
			[Token(Token = "0x200774A")]
			public class Param
			{
				// Token: 0x0602AE5D RID: 175709 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AE5D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DDB0 RID: 253360
				[Token(Token = "0x403DDB0")]
				[FieldOffset(Offset = "0x10")]
				public string actId;
			}
		}
	}
}
