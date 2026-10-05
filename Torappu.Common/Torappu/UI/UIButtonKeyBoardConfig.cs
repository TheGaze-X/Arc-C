using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class UIButtonKeyBoardConfig : MonoBehaviour, IHotfixable
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x553A6C0", Offset = "0x55392C0", VA = "0x18553A6C0")]
		public KeyBoardVirtualButtonConfig GetButtonConfig()
		{
			return null;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x553A8E0", Offset = "0x55394E0", VA = "0x18553A8E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x553A820", Offset = "0x5539420", VA = "0x18553A820")]
		private string _GetStringOrEmpty(string key)
		{
			return null;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x553A9F0", Offset = "0x55395F0", VA = "0x18553A9F0")]
		public UIButtonKeyBoardConfig()
		{
		}

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		private const string KEY_GROUP_ID = "groupId";

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		private const string KEY_FUNC_ID = "funcId";

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FlexibleValueList _kv;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x28")]
		private KeyBoardVirtualButtonConfig m_cacheConfig;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate150 __Hotfix0_GetButtonConfig;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0__InitIfNot;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate3 __Hotfix0__GetStringOrEmpty;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
