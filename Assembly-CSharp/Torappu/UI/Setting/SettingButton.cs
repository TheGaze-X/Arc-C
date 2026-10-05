using System;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FF9 RID: 16377
	[Token(Token = "0x2003FF9")]
	public class SettingButton : SettingCommonObject
	{
		// Token: 0x060195CF RID: 103887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195CF")]
		[Address(RVA = "0x1223690", Offset = "0x1222290", VA = "0x181223690", Slot = "4")]
		protected override void RefreshState()
		{
		}

		// Token: 0x060195D0 RID: 103888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D0")]
		[Address(RVA = "0x1223840", Offset = "0x1222440", VA = "0x181223840", Slot = "5")]
		protected override void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195D1 RID: 103889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D1")]
		[Address(RVA = "0x1223790", Offset = "0x1222390", VA = "0x181223790", Slot = "6")]
		protected override void SetCommonObjectEnabled(bool enabled)
		{
		}

		// Token: 0x060195D2 RID: 103890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D2")]
		[Address(RVA = "0x1223A40", Offset = "0x1222640", VA = "0x181223A40")]
		private void _OnClick()
		{
		}

		// Token: 0x060195D3 RID: 103891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D3")]
		[Address(RVA = "0x1223B20", Offset = "0x1222720", VA = "0x181223B20")]
		public SettingButton()
		{
		}

		// Token: 0x060195D4 RID: 103892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D4")]
		[Address(RVA = "0x1223A20", Offset = "0x1222620", VA = "0x181223A20")]
		private void <>xLuaBaseProxy_RefreshState()
		{
		}

		// Token: 0x060195D5 RID: 103893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195D5")]
		[Address(RVA = "0x1223A30", Offset = "0x1222630", VA = "0x181223A30")]
		private void <>xLuaBaseProxy_SetData(SettingConstVars.SettingType P0)
		{
		}

		// Token: 0x0401F8D4 RID: 129236
		[Token(Token = "0x401F8D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _button;

		// Token: 0x0401F8D5 RID: 129237
		[Token(Token = "0x401F8D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0401F8D6 RID: 129238
		[Token(Token = "0x401F8D6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _reverse;

		// Token: 0x0401F8D7 RID: 129239
		[Token(Token = "0x401F8D7")]
		[FieldOffset(Offset = "0x51")]
		private bool m_value;

		// Token: 0x0401F8D8 RID: 129240
		[Token(Token = "0x401F8D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x0401F8D9 RID: 129241
		[Token(Token = "0x401F8D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F8DA RID: 129242
		[Token(Token = "0x401F8DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCommonObjectEnabled;

		// Token: 0x0401F8DB RID: 129243
		[Token(Token = "0x401F8DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0401F8DC RID: 129244
		[Token(Token = "0x401F8DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
