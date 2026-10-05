using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C9 RID: 13257
	[Token(Token = "0x20033C9")]
	public class UIBattleSandboxV2ResItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015271 RID: 86641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015271")]
		[Address(RVA = "0xD9F9E0", Offset = "0xD9E5E0", VA = "0x180D9F9E0")]
		public void Render(int idx, UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06015272 RID: 86642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015272")]
		[Address(RVA = "0xD9FBD0", Offset = "0xD9E7D0", VA = "0x180D9FBD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015273 RID: 86643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015273")]
		[Address(RVA = "0xD9FD30", Offset = "0xD9E930", VA = "0x180D9FD30")]
		public UIBattleSandboxV2ResItem()
		{
		}

		// Token: 0x040193C5 RID: 103365
		[Token(Token = "0x40193C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCard;

		// Token: 0x040193C6 RID: 103366
		[Token(Token = "0x40193C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardRoot;

		// Token: 0x040193C7 RID: 103367
		[Token(Token = "0x40193C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _scale;

		// Token: 0x040193C8 RID: 103368
		[Token(Token = "0x40193C8")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_inited;

		// Token: 0x040193C9 RID: 103369
		[Token(Token = "0x40193C9")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x040193CA RID: 103370
		[Token(Token = "0x40193CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040193CB RID: 103371
		[Token(Token = "0x40193CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040193CC RID: 103372
		[Token(Token = "0x40193CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
