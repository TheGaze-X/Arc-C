using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200755F RID: 30047
	[Token(Token = "0x200755F")]
	public class Act24sideBattleFinishMeldingDropInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700639D RID: 25501
		// (get) Token: 0x0602A4F6 RID: 173302 RVA: 0x000D7FE8 File Offset: 0x000D61E8
		// (set) Token: 0x0602A4F7 RID: 173303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700639D")]
		public bool rendering
		{
			[Token(Token = "0x602A4F6")]
			[Address(RVA = "0x25F40B0", Offset = "0x25F2CB0", VA = "0x1825F40B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A4F7")]
			[Address(RVA = "0x25F4110", Offset = "0x25F2D10", VA = "0x1825F4110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602A4F8 RID: 173304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4F8")]
		[Address(RVA = "0x25F3C30", Offset = "0x25F2830", VA = "0x1825F3C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A4F9 RID: 173305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4F9")]
		[Address(RVA = "0x25F3A10", Offset = "0x25F2610", VA = "0x1825F3A10")]
		public void Render(Act24sideBattleFinishMeldingDropViewModel viewModel)
		{
		}

		// Token: 0x0602A4FA RID: 173306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4FA")]
		[Address(RVA = "0x25F3F90", Offset = "0x25F2B90", VA = "0x1825F3F90")]
		private IEnumerator _RenderViewModel()
		{
			return null;
		}

		// Token: 0x0602A4FB RID: 173307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4FB")]
		[Address(RVA = "0x25F4040", Offset = "0x25F2C40", VA = "0x1825F4040")]
		public Act24sideBattleFinishMeldingDropInfoItemView()
		{
		}

		// Token: 0x0403CD60 RID: 249184
		[Token(Token = "0x403CD60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemGridFirst;

		// Token: 0x0403CD61 RID: 249185
		[Token(Token = "0x403CD61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemGridMeal;

		// Token: 0x0403CD62 RID: 249186
		[Token(Token = "0x403CD62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemGridNormal;

		// Token: 0x0403CD63 RID: 249187
		[Token(Token = "0x403CD63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _lineFirst;

		// Token: 0x0403CD64 RID: 249188
		[Token(Token = "0x403CD64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _lineMeal;

		// Token: 0x0403CD65 RID: 249189
		[Token(Token = "0x403CD65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _delayPerItem;

		// Token: 0x0403CD66 RID: 249190
		[Token(Token = "0x403CD66")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _lineFadeDuration;

		// Token: 0x0403CD67 RID: 249191
		[Token(Token = "0x403CD67")]
		[FieldOffset(Offset = "0x48")]
		private List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> m_dropItemsFirst;

		// Token: 0x0403CD68 RID: 249192
		[Token(Token = "0x403CD68")]
		[FieldOffset(Offset = "0x50")]
		private List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> m_dropItemsMeal;

		// Token: 0x0403CD69 RID: 249193
		[Token(Token = "0x403CD69")]
		[FieldOffset(Offset = "0x58")]
		private List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> m_dropItemsNormal;

		// Token: 0x0403CD6A RID: 249194
		[Token(Token = "0x403CD6A")]
		[FieldOffset(Offset = "0x60")]
		private Act24sideBattleFinishMeldingDropInfoItemView.ItemAdapter m_itemAdapterFirst;

		// Token: 0x0403CD6B RID: 249195
		[Token(Token = "0x403CD6B")]
		[FieldOffset(Offset = "0x68")]
		private Act24sideBattleFinishMeldingDropInfoItemView.ItemAdapter m_itemAdapterMeal;

		// Token: 0x0403CD6C RID: 249196
		[Token(Token = "0x403CD6C")]
		[FieldOffset(Offset = "0x70")]
		private Act24sideBattleFinishMeldingDropInfoItemView.ItemAdapter m_itemAdapterNormal;

		// Token: 0x0403CD6D RID: 249197
		[Token(Token = "0x403CD6D")]
		[FieldOffset(Offset = "0x78")]
		private Animator m_itemAnimatorFirst;

		// Token: 0x0403CD6E RID: 249198
		[Token(Token = "0x403CD6E")]
		[FieldOffset(Offset = "0x80")]
		private Animator m_itemAnimatorMeal;

		// Token: 0x0403CD6F RID: 249199
		[Token(Token = "0x403CD6F")]
		[FieldOffset(Offset = "0x88")]
		private Animator m_itemAnimatorNormal;

		// Token: 0x0403CD70 RID: 249200
		[Token(Token = "0x403CD70")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0403CD71 RID: 249201
		[Token(Token = "0x403CD71")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedActId;

		// Token: 0x0403CD73 RID: 249203
		[Token(Token = "0x403CD73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rendering;

		// Token: 0x0403CD74 RID: 249204
		[Token(Token = "0x403CD74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rendering;

		// Token: 0x0403CD75 RID: 249205
		[Token(Token = "0x403CD75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CD76 RID: 249206
		[Token(Token = "0x403CD76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CD77 RID: 249207
		[Token(Token = "0x403CD77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderViewModel;

		// Token: 0x0403CD78 RID: 249208
		[Token(Token = "0x403CD78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007560 RID: 30048
		[Token(Token = "0x2007560")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A4FC RID: 173308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A4FC")]
			[Address(RVA = "0x2603990", Offset = "0x2602590", VA = "0x182603990")]
			public ItemAdapter(Act24sideBattleFinishMeldingDropInfoItemView closure, List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> dropList, float delayPerItem)
			{
			}

			// Token: 0x0602A4FD RID: 173309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A4FD")]
			[Address(RVA = "0x2603680", Offset = "0x2602280", VA = "0x182603680", Slot = "7")]
			protected override void RecycleViews(List<GameObject> views)
			{
			}

			// Token: 0x1700639E RID: 25502
			// (get) Token: 0x0602A4FE RID: 173310 RVA: 0x000D8000 File Offset: 0x000D6200
			[Token(Token = "0x1700639E")]
			public override int count
			{
				[Token(Token = "0x602A4FE")]
				[Address(RVA = "0x2603A50", Offset = "0x2602650", VA = "0x182603A50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A4FF RID: 173311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A4FF")]
			[Address(RVA = "0x2603790", Offset = "0x2602390", VA = "0x182603790", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A500 RID: 173312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A500")]
			[Address(RVA = "0xF88970", Offset = "0xF87570", VA = "0x180F88970")]
			private void <>xLuaBaseProxy_RecycleViews(List<GameObject> P0)
			{
			}

			// Token: 0x0403CD79 RID: 249209
			[Token(Token = "0x403CD79")]
			[FieldOffset(Offset = "0x20")]
			private List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> m_viewModel;

			// Token: 0x0403CD7A RID: 249210
			[Token(Token = "0x403CD7A")]
			[FieldOffset(Offset = "0x28")]
			private float m_delayPerItem;

			// Token: 0x0403CD7B RID: 249211
			[Token(Token = "0x403CD7B")]
			[FieldOffset(Offset = "0x30")]
			private Act24sideBattleFinishMeldingDropInfoItemView m_closure;

			// Token: 0x0403CD7C RID: 249212
			[Token(Token = "0x403CD7C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CD7D RID: 249213
			[Token(Token = "0x403CD7D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RecycleViews;

			// Token: 0x0403CD7E RID: 249214
			[Token(Token = "0x403CD7E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CD7F RID: 249215
			[Token(Token = "0x403CD7F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
