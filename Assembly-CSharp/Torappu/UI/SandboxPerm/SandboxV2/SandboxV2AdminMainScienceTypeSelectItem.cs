using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040D6 RID: 16598
	[Token(Token = "0x20040D6")]
	public class SandboxV2AdminMainScienceTypeSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000086 RID: 134
		// (add) Token: 0x06019ACF RID: 105167 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06019AD0 RID: 105168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000086")]
		public event Action<int> eClick
		{
			[Token(Token = "0x6019ACF")]
			[Address(RVA = "0x1280620", Offset = "0x127F220", VA = "0x181280620")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6019AD0")]
			[Address(RVA = "0x1280720", Offset = "0x127F320", VA = "0x181280720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06019AD1 RID: 105169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AD1")]
		[Address(RVA = "0x12803A0", Offset = "0x127EFA0", VA = "0x1812803A0")]
		public void Render(int idx, SandboxV2AdminMainScienceTypeItemData data, int selected)
		{
		}

		// Token: 0x06019AD2 RID: 105170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AD2")]
		[Address(RVA = "0x1280320", Offset = "0x127EF20", VA = "0x181280320")]
		public void EventOnClick()
		{
		}

		// Token: 0x06019AD3 RID: 105171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AD3")]
		[Address(RVA = "0x12805C0", Offset = "0x127F1C0", VA = "0x1812805C0")]
		public SandboxV2AdminMainScienceTypeSelectItem()
		{
		}

		// Token: 0x040201AD RID: 131501
		[Token(Token = "0x40201AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040201AE RID: 131502
		[Token(Token = "0x40201AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x040201AF RID: 131503
		[Token(Token = "0x40201AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _progress;

		// Token: 0x040201B0 RID: 131504
		[Token(Token = "0x40201B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _selectedProgress;

		// Token: 0x040201B1 RID: 131505
		[Token(Token = "0x40201B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x040201B2 RID: 131506
		[Token(Token = "0x40201B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lockPart;

		// Token: 0x040201B3 RID: 131507
		[Token(Token = "0x40201B3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _splitPart;

		// Token: 0x040201B4 RID: 131508
		[Token(Token = "0x40201B4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btn;

		// Token: 0x040201B5 RID: 131509
		[Token(Token = "0x40201B5")]
		[FieldOffset(Offset = "0x58")]
		private int m_idx;

		// Token: 0x040201B6 RID: 131510
		[Token(Token = "0x40201B6")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_isLocked;

		// Token: 0x040201B8 RID: 131512
		[Token(Token = "0x40201B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eClick;

		// Token: 0x040201B9 RID: 131513
		[Token(Token = "0x40201B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eClick;

		// Token: 0x040201BA RID: 131514
		[Token(Token = "0x40201BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040201BB RID: 131515
		[Token(Token = "0x40201BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x040201BC RID: 131516
		[Token(Token = "0x40201BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
