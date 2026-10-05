using System;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FF2 RID: 16370
	[Token(Token = "0x2003FF2")]
	public class DynEntranceLoginSettingPlugin : SettingCommonObjectPlugin
	{
		// Token: 0x060195BD RID: 103869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195BD")]
		[Address(RVA = "0x1213490", Offset = "0x1212090", VA = "0x181213490", Slot = "4")]
		public override void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195BE RID: 103870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195BE")]
		[Address(RVA = "0x1213700", Offset = "0x1212300", VA = "0x181213700")]
		public DynEntranceLoginSettingPlugin()
		{
		}

		// Token: 0x0401F8B7 RID: 129207
		[Token(Token = "0x401F8B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401F8B8 RID: 129208
		[Token(Token = "0x401F8B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F8B9 RID: 129209
		[Token(Token = "0x401F8B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
