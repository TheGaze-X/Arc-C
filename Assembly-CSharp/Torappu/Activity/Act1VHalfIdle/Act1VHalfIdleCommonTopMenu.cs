using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076B4 RID: 30388
	[Token(Token = "0x20076B4")]
	public class Act1VHalfIdleCommonTopMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006467 RID: 25703
		// (set) Token: 0x0602ABD7 RID: 175063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006467")]
		public Action onClicked
		{
			[Token(Token = "0x602ABD7")]
			[Address(RVA = "0x2685C40", Offset = "0x2684840", VA = "0x182685C40")]
			set
			{
			}
		}

		// Token: 0x17006468 RID: 25704
		// (set) Token: 0x0602ABD8 RID: 175064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006468")]
		public Action onGuideBookClicked
		{
			[Token(Token = "0x602ABD8")]
			[Address(RVA = "0x2685CC0", Offset = "0x26848C0", VA = "0x182685CC0")]
			set
			{
			}
		}

		// Token: 0x0602ABD9 RID: 175065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABD9")]
		[Address(RVA = "0x2685B20", Offset = "0x2684720", VA = "0x182685B20")]
		public void RenderTopMenu(Act1VHalfIdleCommonTopMenu.TopMenuConfig config)
		{
		}

		// Token: 0x0602ABDA RID: 175066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABDA")]
		[Address(RVA = "0x2685A40", Offset = "0x2684640", VA = "0x182685A40")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0602ABDB RID: 175067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABDB")]
		[Address(RVA = "0x2685AB0", Offset = "0x26846B0", VA = "0x182685AB0")]
		public void OnGuideBtnClicked()
		{
		}

		// Token: 0x0602ABDC RID: 175068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABDC")]
		[Address(RVA = "0x2685BE0", Offset = "0x26847E0", VA = "0x182685BE0")]
		public Act1VHalfIdleCommonTopMenu()
		{
		}

		// Token: 0x0403D940 RID: 252224
		[Token(Token = "0x403D940")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelIconSquad;

		// Token: 0x0403D941 RID: 252225
		[Token(Token = "0x403D941")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelIconDepot;

		// Token: 0x0403D942 RID: 252226
		[Token(Token = "0x403D942")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelIconDepotBuff;

		// Token: 0x0403D943 RID: 252227
		[Token(Token = "0x403D943")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelGuideBook;

		// Token: 0x0403D944 RID: 252228
		[Token(Token = "0x403D944")]
		[FieldOffset(Offset = "0x38")]
		private Action m_onClicked;

		// Token: 0x0403D945 RID: 252229
		[Token(Token = "0x403D945")]
		[FieldOffset(Offset = "0x40")]
		private Action m_onGuideBookClicked;

		// Token: 0x0403D946 RID: 252230
		[Token(Token = "0x403D946")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403D947 RID: 252231
		[Token(Token = "0x403D947")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGuideBookClicked;

		// Token: 0x0403D948 RID: 252232
		[Token(Token = "0x403D948")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderTopMenu;

		// Token: 0x0403D949 RID: 252233
		[Token(Token = "0x403D949")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0403D94A RID: 252234
		[Token(Token = "0x403D94A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGuideBtnClicked;

		// Token: 0x0403D94B RID: 252235
		[Token(Token = "0x403D94B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076B5 RID: 30389
		[Token(Token = "0x20076B5")]
		public enum TopMenuIconType
		{
			// Token: 0x0403D94D RID: 252237
			[Token(Token = "0x403D94D")]
			NONE,
			// Token: 0x0403D94E RID: 252238
			[Token(Token = "0x403D94E")]
			SQUAD,
			// Token: 0x0403D94F RID: 252239
			[Token(Token = "0x403D94F")]
			DEPOT,
			// Token: 0x0403D950 RID: 252240
			[Token(Token = "0x403D950")]
			DEPOT_BUFF
		}

		// Token: 0x020076B6 RID: 30390
		[Token(Token = "0x20076B6")]
		public struct TopMenuConfig
		{
			// Token: 0x0403D951 RID: 252241
			[Token(Token = "0x403D951")]
			[FieldOffset(Offset = "0x0")]
			public Act1VHalfIdleCommonTopMenu.TopMenuIconType iconType;

			// Token: 0x0403D952 RID: 252242
			[Token(Token = "0x403D952")]
			[FieldOffset(Offset = "0x4")]
			public bool showGuideBookBtn;
		}
	}
}
