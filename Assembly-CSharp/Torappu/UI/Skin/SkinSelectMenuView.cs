using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EE5 RID: 16101
	[Token(Token = "0x2003EE5")]
	public class SkinSelectMenuView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F9C RID: 102300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F9C")]
		[Address(RVA = "0x119F280", Offset = "0x119DE80", VA = "0x18119F280")]
		public void NotifyDataChanged(CharUISkinStruct skinStruct)
		{
		}

		// Token: 0x06018F9D RID: 102301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F9D")]
		[Address(RVA = "0x119F3C0", Offset = "0x119DFC0", VA = "0x18119F3C0")]
		public SkinSelectMenuView()
		{
		}

		// Token: 0x0401ED97 RID: 126359
		[Token(Token = "0x401ED97")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _spDynIllustSwitchBtnObj;

		// Token: 0x0401ED98 RID: 126360
		[Token(Token = "0x401ED98")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _spSwitchLoopNormalObj;

		// Token: 0x0401ED99 RID: 126361
		[Token(Token = "0x401ED99")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _spSwitchLoopSpObj;

		// Token: 0x0401ED9A RID: 126362
		[Token(Token = "0x401ED9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyDataChanged;

		// Token: 0x0401ED9B RID: 126363
		[Token(Token = "0x401ED9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
