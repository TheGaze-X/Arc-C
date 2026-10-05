using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200753F RID: 30015
	[Token(Token = "0x200753F")]
	public class Act24sideActivityController : TemplateActivityController
	{
		// Token: 0x0602A480 RID: 173184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A480")]
		[Address(RVA = "0x25D9D40", Offset = "0x25D8940", VA = "0x1825D9D40", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602A481 RID: 173185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A481")]
		[Address(RVA = "0x25DA310", Offset = "0x25D8F10", VA = "0x1825DA310", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602A482 RID: 173186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A482")]
		[Address(RVA = "0x25DA100", Offset = "0x25D8D00", VA = "0x1825DA100")]
		public void NotifyBtnQuestClicked(string zoneId)
		{
		}

		// Token: 0x0602A483 RID: 173187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A483")]
		[Address(RVA = "0x25DAD30", Offset = "0x25D9930", VA = "0x1825DAD30")]
		private PlayerActivity.PlayerAct24SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602A484 RID: 173188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A484")]
		[Address(RVA = "0x25DA760", Offset = "0x25D9360", VA = "0x1825DA760")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602A485 RID: 173189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A485")]
		[Address(RVA = "0x25DA950", Offset = "0x25D9550", VA = "0x1825DA950")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602A486 RID: 173190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A486")]
		[Address(RVA = "0x25DA550", Offset = "0x25D9150", VA = "0x1825DA550")]
		private TemplateActivityFavorViewModel _GenFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602A487 RID: 173191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A487")]
		[Address(RVA = "0x25DA470", Offset = "0x25D9070", VA = "0x1825DA470")]
		private Act24sideEntryViewModel _GenButtonGroupViewModel()
		{
			return null;
		}

		// Token: 0x0602A488 RID: 173192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A488")]
		[Address(RVA = "0x25DA870", Offset = "0x25D9470", VA = "0x1825DA870")]
		private Act24sideStageMeldingViewModel _GenMeldingViewModel()
		{
			return null;
		}

		// Token: 0x0602A489 RID: 173193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A489")]
		[Address(RVA = "0x25DAE60", Offset = "0x25D9A60", VA = "0x1825DAE60")]
		public Act24sideActivityController()
		{
		}

		// Token: 0x0602A48A RID: 173194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A48A")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0403CCBF RID: 249023
		[Token(Token = "0x403CCBF")]
		[NonSerialized]
		public const string BUTTON_VIEWMODEL = "{0}_button_group";

		// Token: 0x0403CCC0 RID: 249024
		[Token(Token = "0x403CCC0")]
		[NonSerialized]
		public const string STAGE_MELDING = "{0}_stage_melding";

		// Token: 0x0403CCC1 RID: 249025
		[Token(Token = "0x403CCC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403CCC2 RID: 249026
		[Token(Token = "0x403CCC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403CCC3 RID: 249027
		[Token(Token = "0x403CCC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyBtnQuestClicked;

		// Token: 0x0403CCC4 RID: 249028
		[Token(Token = "0x403CCC4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403CCC5 RID: 249029
		[Token(Token = "0x403CCC5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403CCC6 RID: 249030
		[Token(Token = "0x403CCC6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403CCC7 RID: 249031
		[Token(Token = "0x403CCC7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenFavorStateViewModel;

		// Token: 0x0403CCC8 RID: 249032
		[Token(Token = "0x403CCC8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenButtonGroupViewModel;

		// Token: 0x0403CCC9 RID: 249033
		[Token(Token = "0x403CCC9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenMeldingViewModel;

		// Token: 0x0403CCCA RID: 249034
		[Token(Token = "0x403CCCA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
