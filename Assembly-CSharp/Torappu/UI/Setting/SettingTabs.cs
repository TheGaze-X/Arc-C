using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02004002 RID: 16386
	[Token(Token = "0x2004002")]
	public class SettingTabs : SettingCommonObject
	{
		// Token: 0x060195F8 RID: 103928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F8")]
		[Address(RVA = "0x12271A0", Offset = "0x1225DA0", VA = "0x1812271A0", Slot = "4")]
		protected override void RefreshState()
		{
		}

		// Token: 0x060195F9 RID: 103929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F9")]
		[Address(RVA = "0x1227740", Offset = "0x1226340", VA = "0x181227740", Slot = "5")]
		protected override void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195FA RID: 103930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195FA")]
		[Address(RVA = "0x1227560", Offset = "0x1226160", VA = "0x181227560", Slot = "6")]
		protected override void SetCommonObjectEnabled(bool enabled)
		{
		}

		// Token: 0x060195FB RID: 103931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195FB")]
		[Address(RVA = "0x1227970", Offset = "0x1226570", VA = "0x181227970")]
		private void _OnValueChanged(int settingValue)
		{
		}

		// Token: 0x060195FC RID: 103932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195FC")]
		[Address(RVA = "0x1227B90", Offset = "0x1226790", VA = "0x181227B90")]
		public SettingTabs()
		{
		}

		// Token: 0x060195FD RID: 103933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195FD")]
		[Address(RVA = "0x1223A20", Offset = "0x1222620", VA = "0x181223A20")]
		private void <>xLuaBaseProxy_RefreshState()
		{
		}

		// Token: 0x060195FE RID: 103934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195FE")]
		[Address(RVA = "0x1223A30", Offset = "0x1222630", VA = "0x181223A30")]
		private void <>xLuaBaseProxy_SetData(SettingConstVars.SettingType P0)
		{
		}

		// Token: 0x0401F91E RID: 129310
		[Token(Token = "0x401F91E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SettingTab _prefab;

		// Token: 0x0401F91F RID: 129311
		[Token(Token = "0x401F91F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _texts;

		// Token: 0x0401F920 RID: 129312
		[Token(Token = "0x401F920")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SettingTabs.Choice[] _choices;

		// Token: 0x0401F921 RID: 129313
		[Token(Token = "0x401F921")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _offset;

		// Token: 0x0401F922 RID: 129314
		[Token(Token = "0x401F922")]
		[FieldOffset(Offset = "0x60")]
		private List<SettingTab> m_tabs;

		// Token: 0x0401F923 RID: 129315
		[Token(Token = "0x401F923")]
		[FieldOffset(Offset = "0x68")]
		private int m_value;

		// Token: 0x0401F924 RID: 129316
		[Token(Token = "0x401F924")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x0401F925 RID: 129317
		[Token(Token = "0x401F925")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F926 RID: 129318
		[Token(Token = "0x401F926")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCommonObjectEnabled;

		// Token: 0x0401F927 RID: 129319
		[Token(Token = "0x401F927")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401F928 RID: 129320
		[Token(Token = "0x401F928")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004003 RID: 16387
		[Token(Token = "0x2004003")]
		[Serializable]
		private class Choice
		{
			// Token: 0x060195FF RID: 103935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60195FF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Choice()
			{
			}

			// Token: 0x0401F929 RID: 129321
			[Token(Token = "0x401F929")]
			[FieldOffset(Offset = "0x10")]
			public string text;

			// Token: 0x0401F92A RID: 129322
			[Token(Token = "0x401F92A")]
			[FieldOffset(Offset = "0x18")]
			public SettingPlatform platform;
		}
	}
}
