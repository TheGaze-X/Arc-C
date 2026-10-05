using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070CA RID: 28874
	[Token(Token = "0x20070CA")]
	public class Act1BossRushMissionInfoHolder : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x06029085 RID: 168069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029085")]
		[Address(RVA = "0x246ABD0", Offset = "0x24697D0", VA = "0x18246ABD0")]
		private void _RefreshView(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029086 RID: 168070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029086")]
		[Address(RVA = "0x246AB50", Offset = "0x2469750", VA = "0x18246AB50", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029087 RID: 168071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029087")]
		[Address(RVA = "0x246AAE0", Offset = "0x24696E0", VA = "0x18246AAE0")]
		public void EventClaimAllMissionClick()
		{
		}

		// Token: 0x06029088 RID: 168072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029088")]
		[Address(RVA = "0x246ADA0", Offset = "0x24699A0", VA = "0x18246ADA0")]
		public Act1BossRushMissionInfoHolder()
		{
		}

		// Token: 0x0403A931 RID: 239921
		[Token(Token = "0x403A931")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403A932 RID: 239922
		[Token(Token = "0x403A932")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objCanClaimAll;

		// Token: 0x0403A933 RID: 239923
		[Token(Token = "0x403A933")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCantClaimAll;

		// Token: 0x0403A934 RID: 239924
		[Token(Token = "0x403A934")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action onClaimAllMissionClick;

		// Token: 0x0403A935 RID: 239925
		[Token(Token = "0x403A935")]
		private const string COLOR_PROGRESS = "<color=#FF9C00>{0}</color><color=#FFFFFF>/{1}</color>";

		// Token: 0x0403A936 RID: 239926
		[Token(Token = "0x403A936")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0403A937 RID: 239927
		[Token(Token = "0x403A937")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403A938 RID: 239928
		[Token(Token = "0x403A938")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventClaimAllMissionClick;

		// Token: 0x0403A939 RID: 239929
		[Token(Token = "0x403A939")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
