using System;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FF3 RID: 16371
	[Token(Token = "0x2003FF3")]
	public class DynEntranceSettingPlugin : SettingCommonObjectPlugin
	{
		// Token: 0x060195BF RID: 103871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195BF")]
		[Address(RVA = "0x12137A0", Offset = "0x12123A0", VA = "0x1812137A0", Slot = "4")]
		public override void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195C0 RID: 103872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195C0")]
		[Address(RVA = "0x12139A0", Offset = "0x12125A0", VA = "0x1812139A0")]
		public DynEntranceSettingPlugin()
		{
		}

		// Token: 0x0401F8BA RID: 129210
		[Token(Token = "0x401F8BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401F8BB RID: 129211
		[Token(Token = "0x401F8BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F8BC RID: 129212
		[Token(Token = "0x401F8BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
