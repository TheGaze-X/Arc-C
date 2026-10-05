using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ChooseChar;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EAF RID: 24239
	[Token(Token = "0x2005EAF")]
	public class ItemRepoSelectCharRowComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x060231AD RID: 143789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231AD")]
		[Address(RVA = "0x1D9FD50", Offset = "0x1D9E950", VA = "0x181D9FD50")]
		private void _Render(ItemRepoSelectCharRowComp.ViewModel model)
		{
		}

		// Token: 0x060231AE RID: 143790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231AE")]
		[Address(RVA = "0x1D9FC30", Offset = "0x1D9E830", VA = "0x181D9FC30")]
		private void _InitIfNot(ItemRepoSelectCharRowComp.ViewModel model)
		{
		}

		// Token: 0x060231AF RID: 143791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231AF")]
		[Address(RVA = "0x1D9FFB0", Offset = "0x1D9EBB0", VA = "0x181D9FFB0")]
		public ItemRepoSelectCharRowComp()
		{
		}

		// Token: 0x04030615 RID: 198165
		[Token(Token = "0x4030615")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _baseHeight;

		// Token: 0x04030616 RID: 198166
		[Token(Token = "0x4030616")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _ownTagHeight;

		// Token: 0x04030617 RID: 198167
		[Token(Token = "0x4030617")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _potentialTagHeight;

		// Token: 0x04030618 RID: 198168
		[Token(Token = "0x4030618")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charContent;

		// Token: 0x04030619 RID: 198169
		[Token(Token = "0x4030619")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _ownedPanel;

		// Token: 0x0403061A RID: 198170
		[Token(Token = "0x403061A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _notOwnedPanel;

		// Token: 0x0403061B RID: 198171
		[Token(Token = "0x403061B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _standardPanel;

		// Token: 0x0403061C RID: 198172
		[Token(Token = "0x403061C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _classicPanel;

		// Token: 0x0403061D RID: 198173
		[Token(Token = "0x403061D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0403061E RID: 198174
		[Token(Token = "0x403061E")]
		[FieldOffset(Offset = "0x58")]
		private ItemRepoChooseCharAdapter m_adapter;

		// Token: 0x0403061F RID: 198175
		[Token(Token = "0x403061F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04030620 RID: 198176
		[Token(Token = "0x4030620")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030621 RID: 198177
		[Token(Token = "0x4030621")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EB0 RID: 24240
		[Token(Token = "0x2005EB0")]
		public enum OwnTag
		{
			// Token: 0x04030623 RID: 198179
			[Token(Token = "0x4030623")]
			NONE,
			// Token: 0x04030624 RID: 198180
			[Token(Token = "0x4030624")]
			OWNED,
			// Token: 0x04030625 RID: 198181
			[Token(Token = "0x4030625")]
			NOT_OWNED
		}

		// Token: 0x02005EB1 RID: 24241
		[Token(Token = "0x2005EB1")]
		public enum PotentialTag
		{
			// Token: 0x04030627 RID: 198183
			[Token(Token = "0x4030627")]
			NONE,
			// Token: 0x04030628 RID: 198184
			[Token(Token = "0x4030628")]
			STANDARD,
			// Token: 0x04030629 RID: 198185
			[Token(Token = "0x4030629")]
			CLASSIC
		}

		// Token: 0x02005EB2 RID: 24242
		[Token(Token = "0x2005EB2")]
		public class ViewModel
		{
			// Token: 0x060231B0 RID: 143792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60231B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x0403062A RID: 198186
			[Token(Token = "0x403062A")]
			[FieldOffset(Offset = "0x10")]
			public ItemRepoSelectCharRowComp prefab;

			// Token: 0x0403062B RID: 198187
			[Token(Token = "0x403062B")]
			[FieldOffset(Offset = "0x18")]
			public bool clickable;

			// Token: 0x0403062C RID: 198188
			[Token(Token = "0x403062C")]
			[FieldOffset(Offset = "0x1C")]
			public ItemRepoSelectCharRowComp.OwnTag ownTag;

			// Token: 0x0403062D RID: 198189
			[Token(Token = "0x403062D")]
			[FieldOffset(Offset = "0x20")]
			public ItemRepoSelectCharRowComp.PotentialTag potentialTag;

			// Token: 0x0403062E RID: 198190
			[Token(Token = "0x403062E")]
			[FieldOffset(Offset = "0x28")]
			public List<ItemRepoChooseCharViewModel.ChooseCharItem> chars;

			// Token: 0x0403062F RID: 198191
			[Token(Token = "0x403062F")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> onCharItemClick;

			// Token: 0x04030630 RID: 198192
			[Token(Token = "0x4030630")]
			[FieldOffset(Offset = "0x38")]
			public CommonSingleChooseCharGroupView.AbstractViewBuilder viewBuilder;
		}

		// Token: 0x02005EB3 RID: 24243
		[Token(Token = "0x2005EB3")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ItemRepoSelectCharRowComp>
		{
			// Token: 0x060231B1 RID: 143793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60231B1")]
			[Address(RVA = "0x1DA64B0", Offset = "0x1DA50B0", VA = "0x181DA64B0")]
			public VirtualView(ItemRepoSelectCharRowComp.ViewModel model)
			{
			}

			// Token: 0x060231B2 RID: 143794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60231B2")]
			[Address(RVA = "0x1DA63C0", Offset = "0x1DA4FC0", VA = "0x181DA63C0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x060231B3 RID: 143795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60231B3")]
			[Address(RVA = "0x1DA6450", Offset = "0x1DA5050", VA = "0x181DA6450", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060231B4 RID: 143796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60231B4")]
			[Address(RVA = "0x1DA62F0", Offset = "0x1DA4EF0", VA = "0x181DA62F0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060231B5 RID: 143797 RVA: 0x000BFF28 File Offset: 0x000BE128
			[Token(Token = "0x60231B5")]
			[Address(RVA = "0x1DA6360", Offset = "0x1DA4F60", VA = "0x181DA6360", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04030631 RID: 198193
			[Token(Token = "0x4030631")]
			[FieldOffset(Offset = "0x20")]
			private readonly ItemRepoSelectCharRowComp.ViewModel m_model;

			// Token: 0x04030632 RID: 198194
			[Token(Token = "0x4030632")]
			[FieldOffset(Offset = "0x28")]
			private readonly float m_height;

			// Token: 0x04030633 RID: 198195
			[Token(Token = "0x4030633")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030634 RID: 198196
			[Token(Token = "0x4030634")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04030635 RID: 198197
			[Token(Token = "0x4030635")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04030636 RID: 198198
			[Token(Token = "0x4030636")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04030637 RID: 198199
			[Token(Token = "0x4030637")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
