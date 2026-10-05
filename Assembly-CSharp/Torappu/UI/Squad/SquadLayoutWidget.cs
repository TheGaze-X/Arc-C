using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E34 RID: 15924
	[Token(Token = "0x2003E34")]
	public class SquadLayoutWidget : DataBinder<SquadLayoutProperty>
	{
		// Token: 0x06018BF7 RID: 101367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BF7")]
		[Address(RVA = "0x1149060", Offset = "0x1147C60", VA = "0x181149060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018BF8 RID: 101368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BF8")]
		[Address(RVA = "0x1148D50", Offset = "0x1147950", VA = "0x181148D50", Slot = "7")]
		public override void OnValueChanged(SquadLayoutProperty property)
		{
		}

		// Token: 0x06018BF9 RID: 101369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BF9")]
		[Address(RVA = "0x1148FB0", Offset = "0x1147BB0", VA = "0x181148FB0")]
		private IEnumerator UpdateLayout(RectTransform rect)
		{
			return null;
		}

		// Token: 0x06018BFA RID: 101370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BFA")]
		[Address(RVA = "0x11490F0", Offset = "0x1147CF0", VA = "0x1811490F0")]
		public SquadLayoutWidget()
		{
		}

		// Token: 0x0401E672 RID: 124530
		[Token(Token = "0x401E672")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _btnStartBattle;

		// Token: 0x0401E673 RID: 124531
		[Token(Token = "0x401E673")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnAssistFriend;

		// Token: 0x0401E674 RID: 124532
		[Token(Token = "0x401E674")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _squadGrid;

		// Token: 0x0401E675 RID: 124533
		[Token(Token = "0x401E675")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _middleGrid;

		// Token: 0x0401E676 RID: 124534
		[Token(Token = "0x401E676")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Add some padding to squad group when \"start battle\" button not active")]
		private int _addSquadPadding;

		// Token: 0x0401E677 RID: 124535
		[Token(Token = "0x401E677")]
		[FieldOffset(Offset = "0x44")]
		private int m_squadPaddingRaw;

		// Token: 0x0401E678 RID: 124536
		[Token(Token = "0x401E678")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401E679 RID: 124537
		[Token(Token = "0x401E679")]
		[FieldOffset(Offset = "0x49")]
		private bool m_showPaddingCache;

		// Token: 0x0401E67A RID: 124538
		[Token(Token = "0x401E67A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E67B RID: 124539
		[Token(Token = "0x401E67B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E67C RID: 124540
		[Token(Token = "0x401E67C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateLayout;

		// Token: 0x0401E67D RID: 124541
		[Token(Token = "0x401E67D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
