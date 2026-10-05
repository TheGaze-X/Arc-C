using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005577 RID: 21879
	[Token(Token = "0x2005577")]
	public class RL05ClassicEndingTopView : RoguelikeClassicEndingTopView
	{
		// Token: 0x17004B71 RID: 19313
		// (set) Token: 0x06020270 RID: 131696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B71")]
		public override Action onShowReport
		{
			[Token(Token = "0x6020270")]
			[Address(RVA = "0x1A35CB0", Offset = "0x1A348B0", VA = "0x181A35CB0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x06020271 RID: 131697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B72")]
		protected override string showAnimName
		{
			[Token(Token = "0x6020271")]
			[Address(RVA = "0x1A35C40", Offset = "0x1A34840", VA = "0x181A35C40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020272 RID: 131698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020272")]
		[Address(RVA = "0x1A35630", Offset = "0x1A34230", VA = "0x181A35630", Slot = "6")]
		protected override void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020273 RID: 131699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020273")]
		[Address(RVA = "0x1A35970", Offset = "0x1A34570", VA = "0x181A35970")]
		private void _RenderDifficultIcon(RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020274 RID: 131700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020274")]
		[Address(RVA = "0x1A35890", Offset = "0x1A34490", VA = "0x181A35890")]
		private string _GetFailEndingIconName(RoguelikeClassicEndingViewModel endingViewModel)
		{
			return null;
		}

		// Token: 0x06020275 RID: 131701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020275")]
		[Address(RVA = "0x1A357A0", Offset = "0x1A343A0", VA = "0x181A357A0")]
		private string _GetEndingIconName(RoguelikeClassicEndingViewModel endingViewModel)
		{
			return null;
		}

		// Token: 0x06020276 RID: 131702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020276")]
		[Address(RVA = "0x1A355C0", Offset = "0x1A341C0", VA = "0x181A355C0")]
		public void OnShowReportClicked()
		{
		}

		// Token: 0x06020277 RID: 131703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020277")]
		[Address(RVA = "0x1A35BE0", Offset = "0x1A347E0", VA = "0x181A35BE0")]
		public RL05ClassicEndingTopView()
		{
		}

		// Token: 0x0402B6DC RID: 177884
		[Token(Token = "0x402B6DC")]
		private const string SHOW_ANIM_NAME = "anim_in";

		// Token: 0x0402B6DD RID: 177885
		[Token(Token = "0x402B6DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _failTitleId;

		// Token: 0x0402B6DE RID: 177886
		[Token(Token = "0x402B6DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _failIconId;

		// Token: 0x0402B6DF RID: 177887
		[Token(Token = "0x402B6DF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402B6E0 RID: 177888
		[Token(Token = "0x402B6E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _titleIcon;

		// Token: 0x0402B6E1 RID: 177889
		[Token(Token = "0x402B6E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlSuccess;

		// Token: 0x0402B6E2 RID: 177890
		[Token(Token = "0x402B6E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlFailed;

		// Token: 0x0402B6E3 RID: 177891
		[Token(Token = "0x402B6E3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _successGlow;

		// Token: 0x0402B6E4 RID: 177892
		[Token(Token = "0x402B6E4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _failGlow;

		// Token: 0x0402B6E5 RID: 177893
		[Token(Token = "0x402B6E5")]
		[FieldOffset(Offset = "0x78")]
		private Action m_onShowReport;

		// Token: 0x0402B6E6 RID: 177894
		[Token(Token = "0x402B6E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onShowReport;

		// Token: 0x0402B6E7 RID: 177895
		[Token(Token = "0x402B6E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showAnimName;

		// Token: 0x0402B6E8 RID: 177896
		[Token(Token = "0x402B6E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B6E9 RID: 177897
		[Token(Token = "0x402B6E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDifficultIcon;

		// Token: 0x0402B6EA RID: 177898
		[Token(Token = "0x402B6EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetFailEndingIconName;

		// Token: 0x0402B6EB RID: 177899
		[Token(Token = "0x402B6EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetEndingIconName;

		// Token: 0x0402B6EC RID: 177900
		[Token(Token = "0x402B6EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnShowReportClicked;

		// Token: 0x0402B6ED RID: 177901
		[Token(Token = "0x402B6ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
