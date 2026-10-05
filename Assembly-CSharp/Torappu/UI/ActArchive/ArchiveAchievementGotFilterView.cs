using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF0 RID: 27376
	[Token(Token = "0x2006AF0")]
	public class ArchiveAchievementGotFilterView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x0602724D RID: 160333 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602724E RID: 160334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C85")]
		public Action<ArchiveAchievementListGotFilterViewModel.GotType> onGotTypeChanged
		{
			[Token(Token = "0x602724D")]
			[Address(RVA = "0x224FAD0", Offset = "0x224E6D0", VA = "0x18224FAD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602724E")]
			[Address(RVA = "0x224FB30", Offset = "0x224E730", VA = "0x18224FB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602724F RID: 160335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602724F")]
		[Address(RVA = "0x224F800", Offset = "0x224E400", VA = "0x18224F800")]
		public void Render(ArchiveAchievementModel viewModel)
		{
		}

		// Token: 0x06027250 RID: 160336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027250")]
		[Address(RVA = "0x224F6E0", Offset = "0x224E2E0", VA = "0x18224F6E0")]
		public void EventOnClickAll()
		{
		}

		// Token: 0x06027251 RID: 160337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027251")]
		[Address(RVA = "0x224F740", Offset = "0x224E340", VA = "0x18224F740")]
		public void EventOnClickGot()
		{
		}

		// Token: 0x06027252 RID: 160338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027252")]
		[Address(RVA = "0x224F7A0", Offset = "0x224E3A0", VA = "0x18224F7A0")]
		public void EventOnClickNotGot()
		{
		}

		// Token: 0x06027253 RID: 160339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027253")]
		[Address(RVA = "0x224F950", Offset = "0x224E550", VA = "0x18224F950")]
		private void _OnChangeSelection(ArchiveAchievementListGotFilterViewModel.GotType type)
		{
		}

		// Token: 0x06027254 RID: 160340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027254")]
		[Address(RVA = "0x224FA70", Offset = "0x224E670", VA = "0x18224FA70")]
		public ArchiveAchievementGotFilterView()
		{
		}

		// Token: 0x04037600 RID: 226816
		[Token(Token = "0x4037600")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArchiveAchievementGotFilterBtnView[] _btnViews;

		// Token: 0x04037602 RID: 226818
		[Token(Token = "0x4037602")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onGotTypeChanged;

		// Token: 0x04037603 RID: 226819
		[Token(Token = "0x4037603")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGotTypeChanged;

		// Token: 0x04037604 RID: 226820
		[Token(Token = "0x4037604")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037605 RID: 226821
		[Token(Token = "0x4037605")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickAll;

		// Token: 0x04037606 RID: 226822
		[Token(Token = "0x4037606")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClickGot;

		// Token: 0x04037607 RID: 226823
		[Token(Token = "0x4037607")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickNotGot;

		// Token: 0x04037608 RID: 226824
		[Token(Token = "0x4037608")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnChangeSelection;

		// Token: 0x04037609 RID: 226825
		[Token(Token = "0x4037609")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
