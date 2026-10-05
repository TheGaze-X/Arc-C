using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006379 RID: 25465
	[Token(Token = "0x2006379")]
	public class AutoChessShopLevelSkillAndModuleEditItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024BCF RID: 150479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BCF")]
		[Address(RVA = "0x1F9F8A0", Offset = "0x1F9E4A0", VA = "0x181F9F8A0")]
		public void Render(AutoChessMultiCharSkillEquipEditItemViewModel model)
		{
		}

		// Token: 0x06024BD0 RID: 150480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BD0")]
		[Address(RVA = "0x1F9FB30", Offset = "0x1F9E730", VA = "0x181F9FB30")]
		public void SetDragHandler(IDragHandler handler)
		{
		}

		// Token: 0x06024BD1 RID: 150481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BD1")]
		[Address(RVA = "0x1F9FC30", Offset = "0x1F9E830", VA = "0x181F9FC30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024BD2 RID: 150482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BD2")]
		[Address(RVA = "0x1FA0080", Offset = "0x1F9EC80", VA = "0x181FA0080")]
		private void _OnSelectSkill(string chessId, int chessLv, string skillId)
		{
		}

		// Token: 0x06024BD3 RID: 150483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BD3")]
		[Address(RVA = "0x1F9FEC0", Offset = "0x1F9EAC0", VA = "0x181F9FEC0")]
		private void _OnSelectModule(string chessId, int chessLv, string moduleId)
		{
		}

		// Token: 0x06024BD4 RID: 150484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BD4")]
		[Address(RVA = "0x1F9FBB0", Offset = "0x1F9E7B0", VA = "0x181F9FBB0")]
		private void _EventOnPostLayout()
		{
		}

		// Token: 0x06024BD5 RID: 150485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BD5")]
		[Address(RVA = "0x1FA0240", Offset = "0x1F9EE40", VA = "0x181FA0240")]
		public AutoChessShopLevelSkillAndModuleEditItemView()
		{
		}

		// Token: 0x0403350B RID: 210187
		[Token(Token = "0x403350B")]
		private const int SLOT_COUNT = 3;

		// Token: 0x0403350C RID: 210188
		[Token(Token = "0x403350C")]
		private const int UPPER_MODULE_INDEX = 0;

		// Token: 0x0403350D RID: 210189
		[Token(Token = "0x403350D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Skill Select")]
		private SimpleLayoutContent _contentSkill;

		// Token: 0x0403350E RID: 210190
		[Token(Token = "0x403350E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Skill Select")]
		private GameObject _objSkillPanel;

		// Token: 0x0403350F RID: 210191
		[Token(Token = "0x403350F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Module Select")]
		private SimpleLayoutContent _contentModule;

		// Token: 0x04033510 RID: 210192
		[Token(Token = "0x4033510")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Module Select")]
		private GameObject _objModulePanel;

		// Token: 0x04033511 RID: 210193
		[Token(Token = "0x4033511")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Module Select")]
		private UIWrappedScrollRect _scrollRectModule;

		// Token: 0x04033512 RID: 210194
		[Token(Token = "0x4033512")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Module Select")]
		private UILayoutDimensionListener _dimensionListenerModule;

		// Token: 0x04033513 RID: 210195
		[Token(Token = "0x4033513")]
		[FieldOffset(Offset = "0x48")]
		private List<AutoChessMultiCharSkillEquipEditItemViewModel.EquipItemViewModel> m_cachedEquips;

		// Token: 0x04033514 RID: 210196
		[Token(Token = "0x4033514")]
		[FieldOffset(Offset = "0x50")]
		private List<SkillItemViewModel> m_cachedSkills;

		// Token: 0x04033515 RID: 210197
		[Token(Token = "0x4033515")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedSelectedEquipId;

		// Token: 0x04033516 RID: 210198
		[Token(Token = "0x4033516")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedSelectedSkillId;

		// Token: 0x04033517 RID: 210199
		[Token(Token = "0x4033517")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedChessId;

		// Token: 0x04033518 RID: 210200
		[Token(Token = "0x4033518")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedChessLv;

		// Token: 0x04033519 RID: 210201
		[Token(Token = "0x4033519")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403351A RID: 210202
		[Token(Token = "0x403351A")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessShopLevelSkillAndModuleEditItemView.ModuleListAdapter m_moduleAdapter;

		// Token: 0x0403351B RID: 210203
		[Token(Token = "0x403351B")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessShopLevelSkillAndModuleEditItemView.SkillListAdapter m_skillAdapter;

		// Token: 0x0403351C RID: 210204
		[Token(Token = "0x403351C")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0403351D RID: 210205
		[Token(Token = "0x403351D")]
		[FieldOffset(Offset = "0x9C")]
		private int m_cachedSelectedModuleIndex;

		// Token: 0x0403351E RID: 210206
		[Token(Token = "0x403351E")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403351F RID: 210207
		[Token(Token = "0x403351F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033520 RID: 210208
		[Token(Token = "0x4033520")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetDragHandler;

		// Token: 0x04033521 RID: 210209
		[Token(Token = "0x4033521")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033522 RID: 210210
		[Token(Token = "0x4033522")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSelectSkill;

		// Token: 0x04033523 RID: 210211
		[Token(Token = "0x4033523")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSelectModule;

		// Token: 0x04033524 RID: 210212
		[Token(Token = "0x4033524")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnPostLayout;

		// Token: 0x04033525 RID: 210213
		[Token(Token = "0x4033525")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200637A RID: 25466
		[Token(Token = "0x200637A")]
		public class AutoChessShopLevelSkillEditItemMsgParam
		{
			// Token: 0x06024BD6 RID: 150486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BD6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessShopLevelSkillEditItemMsgParam()
			{
			}

			// Token: 0x04033526 RID: 210214
			[Token(Token = "0x4033526")]
			[FieldOffset(Offset = "0x10")]
			public int chessLv;

			// Token: 0x04033527 RID: 210215
			[Token(Token = "0x4033527")]
			[FieldOffset(Offset = "0x18")]
			public string chessId;

			// Token: 0x04033528 RID: 210216
			[Token(Token = "0x4033528")]
			[FieldOffset(Offset = "0x20")]
			public string selectSkillId;
		}

		// Token: 0x0200637B RID: 25467
		[Token(Token = "0x200637B")]
		public class AutoChessShopLevelModuleEditItemMsgParam
		{
			// Token: 0x06024BD7 RID: 150487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BD7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessShopLevelModuleEditItemMsgParam()
			{
			}

			// Token: 0x04033529 RID: 210217
			[Token(Token = "0x4033529")]
			[FieldOffset(Offset = "0x10")]
			public int chessLv;

			// Token: 0x0403352A RID: 210218
			[Token(Token = "0x403352A")]
			[FieldOffset(Offset = "0x18")]
			public string chessId;

			// Token: 0x0403352B RID: 210219
			[Token(Token = "0x403352B")]
			[FieldOffset(Offset = "0x20")]
			public string selectModuleId;
		}

		// Token: 0x0200637C RID: 25468
		[Token(Token = "0x200637C")]
		private class ModuleListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024BD8 RID: 150488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BD8")]
			[Address(RVA = "0x1FACE80", Offset = "0x1FABA80", VA = "0x181FACE80")]
			public ModuleListAdapter(AutoChessShopLevelSkillAndModuleEditItemView closure)
			{
			}

			// Token: 0x170056BD RID: 22205
			// (get) Token: 0x06024BD9 RID: 150489 RVA: 0x000C5598 File Offset: 0x000C3798
			[Token(Token = "0x170056BD")]
			public override int count
			{
				[Token(Token = "0x6024BD9")]
				[Address(RVA = "0x1FACF00", Offset = "0x1FABB00", VA = "0x181FACF00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024BDA RID: 150490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024BDA")]
			[Address(RVA = "0x1FACBC0", Offset = "0x1FAB7C0", VA = "0x181FACBC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403352C RID: 210220
			[Token(Token = "0x403352C")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopLevelSkillAndModuleEditItemView m_closure;

			// Token: 0x0403352D RID: 210221
			[Token(Token = "0x403352D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403352E RID: 210222
			[Token(Token = "0x403352E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403352F RID: 210223
			[Token(Token = "0x403352F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200637D RID: 25469
		[Token(Token = "0x200637D")]
		private class SkillListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024BDB RID: 150491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BDB")]
			[Address(RVA = "0x1FAD270", Offset = "0x1FABE70", VA = "0x181FAD270")]
			public SkillListAdapter(AutoChessShopLevelSkillAndModuleEditItemView closure)
			{
			}

			// Token: 0x170056BE RID: 22206
			// (get) Token: 0x06024BDC RID: 150492 RVA: 0x000C55B0 File Offset: 0x000C37B0
			[Token(Token = "0x170056BE")]
			public override int count
			{
				[Token(Token = "0x6024BDC")]
				[Address(RVA = "0x1FAD2F0", Offset = "0x1FABEF0", VA = "0x181FAD2F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024BDD RID: 150493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024BDD")]
			[Address(RVA = "0x1FACFC0", Offset = "0x1FABBC0", VA = "0x181FACFC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04033530 RID: 210224
			[Token(Token = "0x4033530")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopLevelSkillAndModuleEditItemView m_closure;

			// Token: 0x04033531 RID: 210225
			[Token(Token = "0x4033531")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033532 RID: 210226
			[Token(Token = "0x4033532")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033533 RID: 210227
			[Token(Token = "0x4033533")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
