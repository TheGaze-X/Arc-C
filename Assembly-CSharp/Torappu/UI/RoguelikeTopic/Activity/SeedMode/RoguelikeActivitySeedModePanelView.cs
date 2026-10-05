using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046A4 RID: 18084
	[Token(Token = "0x20046A4")]
	public class RoguelikeActivitySeedModePanelView : DataBinder<RoguelikeActivitySeedModePanelProperty>
	{
		// Token: 0x0601B6F5 RID: 112373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F5")]
		[Address(RVA = "0x14D7190", Offset = "0x14D5D90", VA = "0x1814D7190", Slot = "7")]
		public override void OnValueChanged(RoguelikeActivitySeedModePanelProperty property)
		{
		}

		// Token: 0x0601B6F6 RID: 112374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F6")]
		[Address(RVA = "0x14D70B0", Offset = "0x14D5CB0", VA = "0x1814D70B0")]
		public void OnClickInputSeed()
		{
		}

		// Token: 0x0601B6F7 RID: 112375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F7")]
		[Address(RVA = "0x14D6FD0", Offset = "0x14D5BD0", VA = "0x1814D6FD0")]
		public void OnClickDisableSeed()
		{
		}

		// Token: 0x0601B6F8 RID: 112376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F8")]
		[Address(RVA = "0x14D7040", Offset = "0x14D5C40", VA = "0x1814D7040")]
		public void OnClickEnableSeedGrade()
		{
		}

		// Token: 0x0601B6F9 RID: 112377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F9")]
		[Address(RVA = "0x14D7120", Offset = "0x14D5D20", VA = "0x1814D7120")]
		public void OnClickOpenSelectSeedDialog()
		{
		}

		// Token: 0x0601B6FA RID: 112378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6FA")]
		[Address(RVA = "0x14D7630", Offset = "0x14D6230", VA = "0x1814D7630")]
		public RoguelikeActivitySeedModePanelView()
		{
		}

		// Token: 0x040237E8 RID: 145384
		[Token(Token = "0x40237E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _notEnableTitle;

		// Token: 0x040237E9 RID: 145385
		[Token(Token = "0x40237E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _enableTitle;

		// Token: 0x040237EA RID: 145386
		[Token(Token = "0x40237EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _playingTitle;

		// Token: 0x040237EB RID: 145387
		[Token(Token = "0x40237EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _inputSeedGroup;

		// Token: 0x040237EC RID: 145388
		[Token(Token = "0x40237EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _displaySeedGroup;

		// Token: 0x040237ED RID: 145389
		[Token(Token = "0x40237ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _seedStr;

		// Token: 0x040237EE RID: 145390
		[Token(Token = "0x40237EE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _playingDisableSeedText;

		// Token: 0x040237EF RID: 145391
		[Token(Token = "0x40237EF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _disableSeedBtnObj;

		// Token: 0x040237F0 RID: 145392
		[Token(Token = "0x40237F0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _gradeGroup;

		// Token: 0x040237F1 RID: 145393
		[Token(Token = "0x40237F1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _gradeName;

		// Token: 0x040237F2 RID: 145394
		[Token(Token = "0x40237F2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _gradeNum;

		// Token: 0x040237F3 RID: 145395
		[Token(Token = "0x40237F3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _setGradeBtnObj;

		// Token: 0x040237F4 RID: 145396
		[Token(Token = "0x40237F4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _setGradeBtnDisableObj;

		// Token: 0x040237F5 RID: 145397
		[Token(Token = "0x40237F5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _hasSetGradeBtnText;

		// Token: 0x040237F6 RID: 145398
		[Token(Token = "0x40237F6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _gradeLockBtnText;

		// Token: 0x040237F7 RID: 145399
		[Token(Token = "0x40237F7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _seedTips;

		// Token: 0x040237F8 RID: 145400
		[Token(Token = "0x40237F8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _timeTxt;

		// Token: 0x040237F9 RID: 145401
		[Token(Token = "0x40237F9")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action onClickInputSeed;

		// Token: 0x040237FA RID: 145402
		[Token(Token = "0x40237FA")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public Action onClickDisableSeed;

		// Token: 0x040237FB RID: 145403
		[Token(Token = "0x40237FB")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public Action onClickEnableSeedGrade;

		// Token: 0x040237FC RID: 145404
		[Token(Token = "0x40237FC")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public Action onClickOpenSelectSeedDialog;

		// Token: 0x040237FD RID: 145405
		[Token(Token = "0x40237FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040237FE RID: 145406
		[Token(Token = "0x40237FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickInputSeed;

		// Token: 0x040237FF RID: 145407
		[Token(Token = "0x40237FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickDisableSeed;

		// Token: 0x04023800 RID: 145408
		[Token(Token = "0x4023800")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickEnableSeedGrade;

		// Token: 0x04023801 RID: 145409
		[Token(Token = "0x4023801")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickOpenSelectSeedDialog;

		// Token: 0x04023802 RID: 145410
		[Token(Token = "0x4023802")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
