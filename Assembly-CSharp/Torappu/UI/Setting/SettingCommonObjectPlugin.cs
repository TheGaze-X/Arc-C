using System;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FF8 RID: 16376
	[Token(Token = "0x2003FF8")]
	public abstract class SettingCommonObjectPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x060195CB RID: 103883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C80")]
		protected SettingCommonObject.SettingCommomObjectPluginHandler handler
		{
			[Token(Token = "0x60195CB")]
			[Address(RVA = "0x12242E0", Offset = "0x1222EE0", VA = "0x1812242E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060195CC RID: 103884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195CC")]
		[Address(RVA = "0x1224200", Offset = "0x1222E00", VA = "0x181224200")]
		public void Init(SettingCommonObject.SettingCommomObjectPluginHandler handler)
		{
		}

		// Token: 0x060195CD RID: 103885
		[Token(Token = "0x60195CD")]
		public abstract void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL);

		// Token: 0x060195CE RID: 103886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195CE")]
		[Address(RVA = "0x1224280", Offset = "0x1222E80", VA = "0x181224280")]
		protected SettingCommonObjectPlugin()
		{
		}

		// Token: 0x0401F8D0 RID: 129232
		[Token(Token = "0x401F8D0")]
		[FieldOffset(Offset = "0x18")]
		private SettingCommonObject.SettingCommomObjectPluginHandler m_handler;

		// Token: 0x0401F8D1 RID: 129233
		[Token(Token = "0x401F8D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x0401F8D2 RID: 129234
		[Token(Token = "0x401F8D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F8D3 RID: 129235
		[Token(Token = "0x401F8D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
