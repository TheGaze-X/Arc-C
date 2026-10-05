using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007040 RID: 28736
	[Token(Token = "0x2007040")]
	public class ActMultiV3PrepareMainSkillAndModuleCharCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x06028CB0 RID: 167088 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CB1 RID: 167089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006066")]
		public Action<int, string> onSelectSkillEvent
		{
			[Token(Token = "0x6028CB0")]
			[Address(RVA = "0x243DDC0", Offset = "0x243C9C0", VA = "0x18243DDC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028CB1")]
			[Address(RVA = "0x243DEA0", Offset = "0x243CAA0", VA = "0x18243DEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x06028CB2 RID: 167090 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CB3 RID: 167091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006067")]
		public Action<int, string> onSelectModuleEvent
		{
			[Token(Token = "0x6028CB2")]
			[Address(RVA = "0x243DD60", Offset = "0x243C960", VA = "0x18243DD60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028CB3")]
			[Address(RVA = "0x243DE20", Offset = "0x243CA20", VA = "0x18243DE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028CB4 RID: 167092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CB4")]
		[Address(RVA = "0x243D200", Offset = "0x243BE00", VA = "0x18243D200")]
		public void Render(ActMultiV3PrepareMainSkillAndModuleCharCardModel model, bool showSkill, int seqNum)
		{
		}

		// Token: 0x06028CB5 RID: 167093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CB5")]
		[Address(RVA = "0x243D320", Offset = "0x243BF20", VA = "0x18243D320")]
		public void SetDragHandler(IDragHandler handler)
		{
		}

		// Token: 0x06028CB6 RID: 167094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CB6")]
		[Address(RVA = "0x243D420", Offset = "0x243C020", VA = "0x18243D420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028CB7 RID: 167095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CB7")]
		[Address(RVA = "0x243D900", Offset = "0x243C500", VA = "0x18243D900")]
		private void _RenderSkillAndModule(ActMultiV3PrepareMainSkillAndModuleCharCardModel model, bool showSkill, bool needRebuildModule)
		{
		}

		// Token: 0x06028CB8 RID: 167096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CB8")]
		[Address(RVA = "0x243D800", Offset = "0x243C400", VA = "0x18243D800")]
		private void _OnSelectSkill(int instId, string skillId)
		{
		}

		// Token: 0x06028CB9 RID: 167097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CB9")]
		[Address(RVA = "0x243D700", Offset = "0x243C300", VA = "0x18243D700")]
		private void _OnSelectModule(int instId, string moduleId)
		{
		}

		// Token: 0x06028CBA RID: 167098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CBA")]
		[Address(RVA = "0x243D3A0", Offset = "0x243BFA0", VA = "0x18243D3A0")]
		private void _EventOnPostLayout()
		{
		}

		// Token: 0x06028CBB RID: 167099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CBB")]
		[Address(RVA = "0x243DC50", Offset = "0x243C850", VA = "0x18243DC50")]
		public ActMultiV3PrepareMainSkillAndModuleCharCard()
		{
		}

		// Token: 0x0403A2AC RID: 238252
		[Token(Token = "0x403A2AC")]
		private const int EMPTY_INST_ID = -1;

		// Token: 0x0403A2AD RID: 238253
		[Token(Token = "0x403A2AD")]
		private const int SLOT_COUNT = 3;

		// Token: 0x0403A2AE RID: 238254
		[Token(Token = "0x403A2AE")]
		private const int UPPER_MODULE_INDEX = 0;

		// Token: 0x0403A2AF RID: 238255
		[Token(Token = "0x403A2AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Char Part")]
		private ActMultiV3CharCardBase _cardPrefab;

		// Token: 0x0403A2B0 RID: 238256
		[Token(Token = "0x403A2B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Char Part")]
		private Transform _container;

		// Token: 0x0403A2B1 RID: 238257
		[Token(Token = "0x403A2B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Skill Select")]
		private SimpleLayoutContent _contentSkill;

		// Token: 0x0403A2B2 RID: 238258
		[Token(Token = "0x403A2B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Skill Select")]
		private GameObject _objSkillPanel;

		// Token: 0x0403A2B3 RID: 238259
		[Token(Token = "0x403A2B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Module Select")]
		private SimpleLayoutContent _contentModule;

		// Token: 0x0403A2B4 RID: 238260
		[Token(Token = "0x403A2B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Module Select")]
		private GameObject _objModulePanel;

		// Token: 0x0403A2B5 RID: 238261
		[Token(Token = "0x403A2B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Module Select")]
		private UIWrappedScrollRect _scrollRectModule;

		// Token: 0x0403A2B6 RID: 238262
		[Token(Token = "0x403A2B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Module Select")]
		private UILayoutDimensionListener _dimensionListenerModule;

		// Token: 0x0403A2B7 RID: 238263
		[Token(Token = "0x403A2B7")]
		[FieldOffset(Offset = "0x58")]
		private ActMultiV3CharCardBase m_card;

		// Token: 0x0403A2B8 RID: 238264
		[Token(Token = "0x403A2B8")]
		[FieldOffset(Offset = "0x60")]
		private List<ActMultiV3PrepareMainSkillAndModuleCharCardModel.EquipItemViewModel> m_cachedEquips;

		// Token: 0x0403A2B9 RID: 238265
		[Token(Token = "0x403A2B9")]
		[FieldOffset(Offset = "0x68")]
		private List<SkillItemViewModel> m_cachedSkills;

		// Token: 0x0403A2BA RID: 238266
		[Token(Token = "0x403A2BA")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedSelectedEquipId;

		// Token: 0x0403A2BB RID: 238267
		[Token(Token = "0x403A2BB")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedSelectedSkillId;

		// Token: 0x0403A2BC RID: 238268
		[Token(Token = "0x403A2BC")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedInstId;

		// Token: 0x0403A2BD RID: 238269
		[Token(Token = "0x403A2BD")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403A2BE RID: 238270
		[Token(Token = "0x403A2BE")]
		[FieldOffset(Offset = "0x98")]
		private ActMultiV3PrepareMainSkillAndModuleCharCard.ModuleListAdapter m_moduleAdapter;

		// Token: 0x0403A2BF RID: 238271
		[Token(Token = "0x403A2BF")]
		[FieldOffset(Offset = "0xA0")]
		private ActMultiV3PrepareMainSkillAndModuleCharCard.SkillListAdapter m_skillAdapter;

		// Token: 0x0403A2C0 RID: 238272
		[Token(Token = "0x403A2C0")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x0403A2C1 RID: 238273
		[Token(Token = "0x403A2C1")]
		[FieldOffset(Offset = "0xAC")]
		private int m_cachedSeqNum;

		// Token: 0x0403A2C2 RID: 238274
		[Token(Token = "0x403A2C2")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedSelectedModuleIndex;

		// Token: 0x0403A2C5 RID: 238277
		[Token(Token = "0x403A2C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectSkillEvent;

		// Token: 0x0403A2C6 RID: 238278
		[Token(Token = "0x403A2C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectSkillEvent;

		// Token: 0x0403A2C7 RID: 238279
		[Token(Token = "0x403A2C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSelectModuleEvent;

		// Token: 0x0403A2C8 RID: 238280
		[Token(Token = "0x403A2C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSelectModuleEvent;

		// Token: 0x0403A2C9 RID: 238281
		[Token(Token = "0x403A2C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A2CA RID: 238282
		[Token(Token = "0x403A2CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetDragHandler;

		// Token: 0x0403A2CB RID: 238283
		[Token(Token = "0x403A2CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A2CC RID: 238284
		[Token(Token = "0x403A2CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderSkillAndModule;

		// Token: 0x0403A2CD RID: 238285
		[Token(Token = "0x403A2CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnSelectSkill;

		// Token: 0x0403A2CE RID: 238286
		[Token(Token = "0x403A2CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSelectModule;

		// Token: 0x0403A2CF RID: 238287
		[Token(Token = "0x403A2CF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnPostLayout;

		// Token: 0x0403A2D0 RID: 238288
		[Token(Token = "0x403A2D0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007041 RID: 28737
		[Token(Token = "0x2007041")]
		private class ModuleListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028CBC RID: 167100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028CBC")]
			[Address(RVA = "0x2447E70", Offset = "0x2446A70", VA = "0x182447E70")]
			public ModuleListAdapter(ActMultiV3PrepareMainSkillAndModuleCharCard closure)
			{
			}

			// Token: 0x17006068 RID: 24680
			// (get) Token: 0x06028CBD RID: 167101 RVA: 0x000D3068 File Offset: 0x000D1268
			[Token(Token = "0x17006068")]
			public override int count
			{
				[Token(Token = "0x6028CBD")]
				[Address(RVA = "0x2447EF0", Offset = "0x2446AF0", VA = "0x182447EF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028CBE RID: 167102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028CBE")]
			[Address(RVA = "0x2447BB0", Offset = "0x24467B0", VA = "0x182447BB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403A2D1 RID: 238289
			[Token(Token = "0x403A2D1")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3PrepareMainSkillAndModuleCharCard m_closure;

			// Token: 0x0403A2D2 RID: 238290
			[Token(Token = "0x403A2D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A2D3 RID: 238291
			[Token(Token = "0x403A2D3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A2D4 RID: 238292
			[Token(Token = "0x403A2D4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007042 RID: 28738
		[Token(Token = "0x2007042")]
		private class SkillListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028CBF RID: 167103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028CBF")]
			[Address(RVA = "0x2448850", Offset = "0x2447450", VA = "0x182448850")]
			public SkillListAdapter(ActMultiV3PrepareMainSkillAndModuleCharCard closure)
			{
			}

			// Token: 0x17006069 RID: 24681
			// (get) Token: 0x06028CC0 RID: 167104 RVA: 0x000D3080 File Offset: 0x000D1280
			[Token(Token = "0x17006069")]
			public override int count
			{
				[Token(Token = "0x6028CC0")]
				[Address(RVA = "0x24488D0", Offset = "0x24474D0", VA = "0x1824488D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028CC1 RID: 167105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028CC1")]
			[Address(RVA = "0x24485A0", Offset = "0x24471A0", VA = "0x1824485A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403A2D5 RID: 238293
			[Token(Token = "0x403A2D5")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3PrepareMainSkillAndModuleCharCard m_closure;

			// Token: 0x0403A2D6 RID: 238294
			[Token(Token = "0x403A2D6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A2D7 RID: 238295
			[Token(Token = "0x403A2D7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A2D8 RID: 238296
			[Token(Token = "0x403A2D8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
