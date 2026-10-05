using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C61 RID: 27745
	[Token(Token = "0x2006C61")]
	public class ArchiveWrathListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x0602799E RID: 162206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602799F RID: 162207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D95")]
		public ArchiveWrathController controller
		{
			[Token(Token = "0x602799E")]
			[Address(RVA = "0x22C9290", Offset = "0x22C7E90", VA = "0x1822C9290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602799F")]
			[Address(RVA = "0x22C92F0", Offset = "0x22C7EF0", VA = "0x1822C92F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060279A0 RID: 162208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A0")]
		[Address(RVA = "0x22C8ED0", Offset = "0x22C7AD0", VA = "0x1822C8ED0")]
		public void Render(WrathTypeModel typeModel)
		{
		}

		// Token: 0x060279A1 RID: 162209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A1")]
		[Address(RVA = "0x22C8D70", Offset = "0x22C7970", VA = "0x1822C8D70")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060279A2 RID: 162210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A2")]
		[Address(RVA = "0x22C9150", Offset = "0x22C7D50", VA = "0x1822C9150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060279A3 RID: 162211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A3")]
		[Address(RVA = "0x22C9230", Offset = "0x22C7E30", VA = "0x1822C9230")]
		public ArchiveWrathListItemView()
		{
		}

		// Token: 0x040382A5 RID: 230053
		[Token(Token = "0x40382A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040382A6 RID: 230054
		[Token(Token = "0x40382A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _selectedPanel;

		// Token: 0x040382A7 RID: 230055
		[Token(Token = "0x40382A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x040382A9 RID: 230057
		[Token(Token = "0x40382A9")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x040382AA RID: 230058
		[Token(Token = "0x40382AA")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedId;

		// Token: 0x040382AB RID: 230059
		[Token(Token = "0x40382AB")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040382AC RID: 230060
		[Token(Token = "0x40382AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040382AD RID: 230061
		[Token(Token = "0x40382AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040382AE RID: 230062
		[Token(Token = "0x40382AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040382AF RID: 230063
		[Token(Token = "0x40382AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x040382B0 RID: 230064
		[Token(Token = "0x40382B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040382B1 RID: 230065
		[Token(Token = "0x40382B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
