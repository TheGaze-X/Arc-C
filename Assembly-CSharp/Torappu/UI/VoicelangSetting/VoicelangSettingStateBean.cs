using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BAB RID: 15275
	[Token(Token = "0x2003BAB")]
	public class VoicelangSettingStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06017EDA RID: 98010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EDA")]
		[Address(RVA = "0x1071300", Offset = "0x106FF00", VA = "0x181071300")]
		public void LoadData()
		{
		}

		// Token: 0x06017EDB RID: 98011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EDB")]
		[Address(RVA = "0x10727B0", Offset = "0x10713B0", VA = "0x1810727B0")]
		public void OnPowerSelect(bool isAll, string powerId)
		{
		}

		// Token: 0x06017EDC RID: 98012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EDC")]
		[Address(RVA = "0x1072E60", Offset = "0x1071A60", VA = "0x181072E60")]
		public void OnTypeTabSelect(bool isAll, VoiceLangGroupType type)
		{
		}

		// Token: 0x06017EDD RID: 98013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EDD")]
		[Address(RVA = "0x1072460", Offset = "0x1071060", VA = "0x181072460")]
		public void OnCardSelect(string wordKey)
		{
		}

		// Token: 0x06017EDE RID: 98014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EDE")]
		[Address(RVA = "0x10722F0", Offset = "0x1070EF0", VA = "0x1810722F0")]
		public void OnBatchSelect()
		{
		}

		// Token: 0x06017EDF RID: 98015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EDF")]
		[Address(RVA = "0x1072AD0", Offset = "0x10716D0", VA = "0x181072AD0")]
		public void OnSwitchLangTypeSuccess()
		{
		}

		// Token: 0x06017EE0 RID: 98016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EE0")]
		[Address(RVA = "0x10729C0", Offset = "0x10715C0", VA = "0x1810729C0")]
		public void OnSwitchLangTypeCancel()
		{
		}

		// Token: 0x06017EE1 RID: 98017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EE1")]
		[Address(RVA = "0x1072CB0", Offset = "0x10718B0", VA = "0x181072CB0")]
		public void OnSwitchLangType(VoiceLangType type)
		{
		}

		// Token: 0x06017EE2 RID: 98018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EE2")]
		[Address(RVA = "0x10731A0", Offset = "0x1071DA0", VA = "0x1810731A0")]
		public VoicelangSettingStateBean()
		{
		}

		// Token: 0x0401CF04 RID: 118532
		[Token(Token = "0x401CF04")]
		[FieldOffset(Offset = "0x10")]
		public VoicelangCardGroupViewProperty cardGroupProperty;

		// Token: 0x0401CF05 RID: 118533
		[Token(Token = "0x401CF05")]
		[FieldOffset(Offset = "0x18")]
		public VoicelangPowerGroupViewProperty powerGroupProperty;

		// Token: 0x0401CF06 RID: 118534
		[Token(Token = "0x401CF06")]
		[FieldOffset(Offset = "0x20")]
		public VoicelangSettingConfirmViewProperty settingConfirmProperty;

		// Token: 0x0401CF07 RID: 118535
		[Token(Token = "0x401CF07")]
		[FieldOffset(Offset = "0x28")]
		public VoicelangTypeSelectGroupViewProperty typeGroupProperty;

		// Token: 0x0401CF08 RID: 118536
		[Token(Token = "0x401CF08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401CF09 RID: 118537
		[Token(Token = "0x401CF09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPowerSelect;

		// Token: 0x0401CF0A RID: 118538
		[Token(Token = "0x401CF0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTypeTabSelect;

		// Token: 0x0401CF0B RID: 118539
		[Token(Token = "0x401CF0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCardSelect;

		// Token: 0x0401CF0C RID: 118540
		[Token(Token = "0x401CF0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBatchSelect;

		// Token: 0x0401CF0D RID: 118541
		[Token(Token = "0x401CF0D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSwitchLangTypeSuccess;

		// Token: 0x0401CF0E RID: 118542
		[Token(Token = "0x401CF0E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSwitchLangTypeCancel;

		// Token: 0x0401CF0F RID: 118543
		[Token(Token = "0x401CF0F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSwitchLangType;

		// Token: 0x0401CF10 RID: 118544
		[Token(Token = "0x401CF10")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
