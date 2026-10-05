using System;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02004000 RID: 16384
	[Token(Token = "0x2004000")]
	public class SettingSlider : SettingCommonObject
	{
		// Token: 0x060195EB RID: 103915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195EB")]
		[Address(RVA = "0x1226610", Offset = "0x1225210", VA = "0x181226610", Slot = "4")]
		protected override void RefreshState()
		{
		}

		// Token: 0x060195EC RID: 103916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195EC")]
		[Address(RVA = "0x12267A0", Offset = "0x12253A0", VA = "0x1812267A0", Slot = "5")]
		protected override void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195ED RID: 103917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195ED")]
		[Address(RVA = "0x1226AD0", Offset = "0x12256D0", VA = "0x181226AD0")]
		private void _SetData()
		{
		}

		// Token: 0x060195EE RID: 103918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195EE")]
		[Address(RVA = "0x1226720", Offset = "0x1225320", VA = "0x181226720", Slot = "6")]
		protected override void SetCommonObjectEnabled(bool enabled)
		{
		}

		// Token: 0x060195EF RID: 103919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195EF")]
		[Address(RVA = "0x1226990", Offset = "0x1225590", VA = "0x181226990")]
		private void _OnValueChanged(float settingValue)
		{
		}

		// Token: 0x060195F0 RID: 103920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F0")]
		[Address(RVA = "0x1226CA0", Offset = "0x12258A0", VA = "0x181226CA0")]
		public SettingSlider()
		{
		}

		// Token: 0x060195F1 RID: 103921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F1")]
		[Address(RVA = "0x1223A20", Offset = "0x1222620", VA = "0x181223A20")]
		private void <>xLuaBaseProxy_RefreshState()
		{
		}

		// Token: 0x060195F2 RID: 103922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F2")]
		[Address(RVA = "0x1223A30", Offset = "0x1222630", VA = "0x181223A30")]
		private void <>xLuaBaseProxy_SetData(SettingConstVars.SettingType P0)
		{
		}

		// Token: 0x0401F906 RID: 129286
		[Token(Token = "0x401F906")]
		[FieldOffset(Offset = "0x40")]
		private float m_value;

		// Token: 0x0401F907 RID: 129287
		[Token(Token = "0x401F907")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _dataMax;

		// Token: 0x0401F908 RID: 129288
		[Token(Token = "0x401F908")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _dataMin;

		// Token: 0x0401F909 RID: 129289
		[Token(Token = "0x401F909")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _valueText;

		// Token: 0x0401F90A RID: 129290
		[Token(Token = "0x401F90A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x0401F90B RID: 129291
		[Token(Token = "0x401F90B")]
		[FieldOffset(Offset = "0x60")]
		private int m_valueToInt;

		// Token: 0x0401F90C RID: 129292
		[Token(Token = "0x401F90C")]
		[FieldOffset(Offset = "0x64")]
		private bool m_initFlag;

		// Token: 0x0401F90D RID: 129293
		[Token(Token = "0x401F90D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x0401F90E RID: 129294
		[Token(Token = "0x401F90E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F90F RID: 129295
		[Token(Token = "0x401F90F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x0401F910 RID: 129296
		[Token(Token = "0x401F910")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCommonObjectEnabled;

		// Token: 0x0401F911 RID: 129297
		[Token(Token = "0x401F911")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401F912 RID: 129298
		[Token(Token = "0x401F912")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
