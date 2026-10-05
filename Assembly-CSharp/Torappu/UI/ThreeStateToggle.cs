using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C4 RID: 14788
	[Token(Token = "0x20039C4")]
	public class ThreeStateToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x060175CC RID: 95692 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060175CD RID: 95693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F2")]
		public Action<ThreeStateToggle.State> onToggle
		{
			[Token(Token = "0x60175CC")]
			[Address(RVA = "0xFB8FF0", Offset = "0xFB7BF0", VA = "0x180FB8FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60175CD")]
			[Address(RVA = "0xFB90B0", Offset = "0xFB7CB0", VA = "0x180FB90B0")]
			set
			{
			}
		}

		// Token: 0x060175CE RID: 95694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175CE")]
		[Address(RVA = "0xFB8D40", Offset = "0xFB7940", VA = "0x180FB8D40")]
		private void Awake()
		{
		}

		// Token: 0x060175CF RID: 95695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175CF")]
		[Address(RVA = "0xFB8DB0", Offset = "0xFB79B0", VA = "0x180FB8DB0")]
		public void Toggle()
		{
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x060175D0 RID: 95696 RVA: 0x000962B8 File Offset: 0x000944B8
		// (set) Token: 0x060175D1 RID: 95697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F3")]
		public ThreeStateToggle.State state
		{
			[Token(Token = "0x60175D0")]
			[Address(RVA = "0xFB9050", Offset = "0xFB7C50", VA = "0x180FB9050")]
			get
			{
				return ThreeStateToggle.State.UNSELECT;
			}
			[Token(Token = "0x60175D1")]
			[Address(RVA = "0xFB9130", Offset = "0xFB7D30", VA = "0x180FB9130")]
			set
			{
			}
		}

		// Token: 0x060175D2 RID: 95698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D2")]
		[Address(RVA = "0xFB8E50", Offset = "0xFB7A50", VA = "0x180FB8E50")]
		private void _ChangeState(ThreeStateToggle.State newState)
		{
		}

		// Token: 0x060175D3 RID: 95699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D3")]
		[Address(RVA = "0xFB8F90", Offset = "0xFB7B90", VA = "0x180FB8F90")]
		public ThreeStateToggle()
		{
		}

		// Token: 0x0401C360 RID: 115552
		[Token(Token = "0x401C360")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unselect;

		// Token: 0x0401C361 RID: 115553
		[Token(Token = "0x401C361")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _firstSelect;

		// Token: 0x0401C362 RID: 115554
		[Token(Token = "0x401C362")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _secondSelect;

		// Token: 0x0401C363 RID: 115555
		[Token(Token = "0x401C363")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _setWithAwake;

		// Token: 0x0401C364 RID: 115556
		[Token(Token = "0x401C364")]
		[FieldOffset(Offset = "0x34")]
		[Inspect]
		[ReadOnly]
		private ThreeStateToggle.State m_state;

		// Token: 0x0401C365 RID: 115557
		[Token(Token = "0x401C365")]
		[FieldOffset(Offset = "0x38")]
		private Action<ThreeStateToggle.State> m_stateToggleListener;

		// Token: 0x0401C366 RID: 115558
		[Token(Token = "0x401C366")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onToggle;

		// Token: 0x0401C367 RID: 115559
		[Token(Token = "0x401C367")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onToggle;

		// Token: 0x0401C368 RID: 115560
		[Token(Token = "0x401C368")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C369 RID: 115561
		[Token(Token = "0x401C369")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Toggle;

		// Token: 0x0401C36A RID: 115562
		[Token(Token = "0x401C36A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0401C36B RID: 115563
		[Token(Token = "0x401C36B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0401C36C RID: 115564
		[Token(Token = "0x401C36C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ChangeState;

		// Token: 0x0401C36D RID: 115565
		[Token(Token = "0x401C36D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039C5 RID: 14789
		[Token(Token = "0x20039C5")]
		public enum State
		{
			// Token: 0x0401C36F RID: 115567
			[Token(Token = "0x401C36F")]
			UNSELECT,
			// Token: 0x0401C370 RID: 115568
			[Token(Token = "0x401C370")]
			FIRST_SELECT,
			// Token: 0x0401C371 RID: 115569
			[Token(Token = "0x401C371")]
			SECOND_SELECT
		}
	}
}
