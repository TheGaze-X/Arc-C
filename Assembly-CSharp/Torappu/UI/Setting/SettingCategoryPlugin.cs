using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FFB RID: 16379
	[Token(Token = "0x2003FFB")]
	public abstract class SettingCategoryPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060195DB RID: 103899
		[Token(Token = "0x60195DB")]
		public abstract void Init(SettingCategory category, Action<SettingCategory> onClicked);

		// Token: 0x060195DC RID: 103900
		[Token(Token = "0x60195DC")]
		public abstract void ApplyState(bool isSelected);

		// Token: 0x060195DD RID: 103901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195DD")]
		[Address(RVA = "0x1223F90", Offset = "0x1222B90", VA = "0x181223F90")]
		protected SettingCategoryPlugin()
		{
		}

		// Token: 0x0401F8E8 RID: 129256
		[Token(Token = "0x401F8E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
