using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x02007494 RID: 29844
	[Token(Token = "0x2007494")]
	public class Act29signDynFirstView : DataBinder<Act29signDynProperty>
	{
		// Token: 0x17006337 RID: 25399
		// (get) Token: 0x0602A16E RID: 172398 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A16F RID: 172399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006337")]
		public Func<string, Sprite> loadDynRewardSprite
		{
			[Token(Token = "0x602A16E")]
			[Address(RVA = "0x25B7700", Offset = "0x25B6300", VA = "0x1825B7700")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A16F")]
			[Address(RVA = "0x25B7840", Offset = "0x25B6440", VA = "0x1825B7840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006338 RID: 25400
		// (get) Token: 0x0602A170 RID: 172400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A171 RID: 172401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006338")]
		public Func<string, Sprite> loadInitDayChoiceSprite
		{
			[Token(Token = "0x602A170")]
			[Address(RVA = "0x25B7760", Offset = "0x25B6360", VA = "0x1825B7760")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A171")]
			[Address(RVA = "0x25B78C0", Offset = "0x25B64C0", VA = "0x1825B78C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006339 RID: 25401
		// (get) Token: 0x0602A172 RID: 172402 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A173 RID: 172403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006339")]
		public Action<int> choiceBtnAction
		{
			[Token(Token = "0x602A172")]
			[Address(RVA = "0x25B76A0", Offset = "0x25B62A0", VA = "0x1825B76A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A173")]
			[Address(RVA = "0x25B77C0", Offset = "0x25B63C0", VA = "0x1825B77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A174 RID: 172404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A174")]
		[Address(RVA = "0x25B7050", Offset = "0x25B5C50", VA = "0x1825B7050")]
		public void EventOnChoiceBtnClick(int btnIndex)
		{
		}

		// Token: 0x0602A175 RID: 172405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A175")]
		[Address(RVA = "0x25B7170", Offset = "0x25B5D70", VA = "0x1825B7170", Slot = "7")]
		public override void OnValueChanged(Act29signDynProperty property)
		{
		}

		// Token: 0x0602A176 RID: 172406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A176")]
		[Address(RVA = "0x25B7230", Offset = "0x25B5E30", VA = "0x1825B7230")]
		private void _InitIfNot(Act29signDynViewModel viewModel)
		{
		}

		// Token: 0x0602A177 RID: 172407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A177")]
		[Address(RVA = "0x25B7630", Offset = "0x25B6230", VA = "0x1825B7630")]
		public Act29signDynFirstView()
		{
		}

		// Token: 0x0403C6BC RID: 247484
		[Token(Token = "0x403C6BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403C6BD RID: 247485
		[Token(Token = "0x403C6BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image[] _initDayChoiceImages;

		// Token: 0x0403C6BE RID: 247486
		[Token(Token = "0x403C6BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image[] _dynRewardImages;

		// Token: 0x0403C6BF RID: 247487
		[Token(Token = "0x403C6BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _optionDescTexts;

		// Token: 0x0403C6C0 RID: 247488
		[Token(Token = "0x403C6C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _questionDescText;

		// Token: 0x0403C6C1 RID: 247489
		[Token(Token = "0x403C6C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _tipText;

		// Token: 0x0403C6C2 RID: 247490
		[Token(Token = "0x403C6C2")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0403C6C3 RID: 247491
		[Token(Token = "0x403C6C3")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403C6C4 RID: 247492
		[Token(Token = "0x403C6C4")]
		[FieldOffset(Offset = "0x59")]
		private bool m_lockChoice;

		// Token: 0x0403C6C8 RID: 247496
		[Token(Token = "0x403C6C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loadDynRewardSprite;

		// Token: 0x0403C6C9 RID: 247497
		[Token(Token = "0x403C6C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loadDynRewardSprite;

		// Token: 0x0403C6CA RID: 247498
		[Token(Token = "0x403C6CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_loadInitDayChoiceSprite;

		// Token: 0x0403C6CB RID: 247499
		[Token(Token = "0x403C6CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_loadInitDayChoiceSprite;

		// Token: 0x0403C6CC RID: 247500
		[Token(Token = "0x403C6CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_choiceBtnAction;

		// Token: 0x0403C6CD RID: 247501
		[Token(Token = "0x403C6CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_choiceBtnAction;

		// Token: 0x0403C6CE RID: 247502
		[Token(Token = "0x403C6CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnChoiceBtnClick;

		// Token: 0x0403C6CF RID: 247503
		[Token(Token = "0x403C6CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403C6D0 RID: 247504
		[Token(Token = "0x403C6D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C6D1 RID: 247505
		[Token(Token = "0x403C6D1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
