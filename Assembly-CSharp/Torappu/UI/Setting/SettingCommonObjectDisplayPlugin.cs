using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FF7 RID: 16375
	[Token(Token = "0x2003FF7")]
	public class SettingCommonObjectDisplayPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x060195C8 RID: 103880 RVA: 0x0009DDA0 File Offset: 0x0009BFA0
		[Token(Token = "0x17003C7F")]
		public bool shouldDisplay
		{
			[Token(Token = "0x60195C8")]
			[Address(RVA = "0x1224180", Offset = "0x1222D80", VA = "0x181224180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060195C9 RID: 103881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195C9")]
		[Address(RVA = "0x1224040", Offset = "0x1222C40", VA = "0x181224040")]
		public void SetupDisplay()
		{
		}

		// Token: 0x060195CA RID: 103882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195CA")]
		[Address(RVA = "0x1224120", Offset = "0x1222D20", VA = "0x181224120")]
		public SettingCommonObjectDisplayPlugin()
		{
		}

		// Token: 0x0401F8CB RID: 129227
		[Token(Token = "0x401F8CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlSetting;

		// Token: 0x0401F8CC RID: 129228
		[Token(Token = "0x401F8CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SettingCommonObjectDisplayStatus _displayStatus;

		// Token: 0x0401F8CD RID: 129229
		[Token(Token = "0x401F8CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shouldDisplay;

		// Token: 0x0401F8CE RID: 129230
		[Token(Token = "0x401F8CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetupDisplay;

		// Token: 0x0401F8CF RID: 129231
		[Token(Token = "0x401F8CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
