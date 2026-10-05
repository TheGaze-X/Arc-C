using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007923 RID: 31011
	[Token(Token = "0x2007923")]
	public class Act1ArcadeBadgeBookDetailProgressItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B819 RID: 178201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B819")]
		[Address(RVA = "0x2766E60", Offset = "0x2765A60", VA = "0x182766E60")]
		public void Render(Act1ArcadeBadgeBookItemViewModel item, bool selected, bool initShow)
		{
		}

		// Token: 0x0602B81A RID: 178202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B81A")]
		[Address(RVA = "0x2767000", Offset = "0x2765C00", VA = "0x182767000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B81B RID: 178203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B81B")]
		[Address(RVA = "0x27670D0", Offset = "0x2765CD0", VA = "0x1827670D0")]
		public Act1ArcadeBadgeBookDetailProgressItemView()
		{
		}

		// Token: 0x0403EE75 RID: 257653
		[Token(Token = "0x403EE75")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _itemPanel;

		// Token: 0x0403EE76 RID: 257654
		[Token(Token = "0x403EE76")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _splitPanel;

		// Token: 0x0403EE77 RID: 257655
		[Token(Token = "0x403EE77")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x0403EE78 RID: 257656
		[Token(Token = "0x403EE78")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403EE79 RID: 257657
		[Token(Token = "0x403EE79")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_selectedTween;

		// Token: 0x0403EE7A RID: 257658
		[Token(Token = "0x403EE7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EE7B RID: 257659
		[Token(Token = "0x403EE7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EE7C RID: 257660
		[Token(Token = "0x403EE7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
