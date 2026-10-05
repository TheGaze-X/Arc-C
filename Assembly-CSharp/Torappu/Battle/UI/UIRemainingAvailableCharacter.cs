using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003391 RID: 13201
	[Token(Token = "0x2003391")]
	public class UIRemainingAvailableCharacter : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x060150C2 RID: 86210 RVA: 0x0008A288 File Offset: 0x00088488
		[Token(Token = "0x17003200")]
		public bool isActive
		{
			[Token(Token = "0x60150C2")]
			[Address(RVA = "0xD7A930", Offset = "0xD79530", VA = "0x180D7A930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003201 RID: 12801
		// (set) Token: 0x060150C3 RID: 86211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003201")]
		public int count
		{
			[Token(Token = "0x60150C3")]
			[Address(RVA = "0xD7A9A0", Offset = "0xD795A0", VA = "0x180D7A9A0")]
			set
			{
			}
		}

		// Token: 0x060150C4 RID: 86212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150C4")]
		[Address(RVA = "0xD7A6F0", Offset = "0xD792F0", VA = "0x180D7A6F0")]
		public void OnInit()
		{
		}

		// Token: 0x060150C5 RID: 86213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150C5")]
		[Address(RVA = "0xD7A7F0", Offset = "0xD793F0", VA = "0x180D7A7F0")]
		public void UpdateVisibility()
		{
		}

		// Token: 0x060150C6 RID: 86214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150C6")]
		[Address(RVA = "0xD7A8C0", Offset = "0xD794C0", VA = "0x180D7A8C0")]
		public UIRemainingAvailableCharacter()
		{
		}

		// Token: 0x040190DA RID: 102618
		[Token(Token = "0x40190DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _cntLabel;

		// Token: 0x040190DB RID: 102619
		[Token(Token = "0x40190DB")]
		[FieldOffset(Offset = "0x20")]
		private int m_count;

		// Token: 0x040190DC RID: 102620
		[Token(Token = "0x40190DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x040190DD RID: 102621
		[Token(Token = "0x40190DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_count;

		// Token: 0x040190DE RID: 102622
		[Token(Token = "0x40190DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040190DF RID: 102623
		[Token(Token = "0x40190DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateVisibility;

		// Token: 0x040190E0 RID: 102624
		[Token(Token = "0x40190E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
