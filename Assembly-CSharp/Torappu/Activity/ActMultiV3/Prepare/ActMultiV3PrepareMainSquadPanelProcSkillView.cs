using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007075 RID: 28789
	[Token(Token = "0x2007075")]
	public class ActMultiV3PrepareMainSquadPanelProcSkillView : ActMultiV3PrepareMainSquadPanelProcViewBase
	{
		// Token: 0x170060B0 RID: 24752
		// (get) Token: 0x06028E30 RID: 167472 RVA: 0x000D37E8 File Offset: 0x000D19E8
		[Token(Token = "0x170060B0")]
		public override ActMultiV3PrepareMainSquadProc procType
		{
			[Token(Token = "0x6028E30")]
			[Address(RVA = "0x245A980", Offset = "0x2459580", VA = "0x18245A980", Slot = "9")]
			get
			{
				return ActMultiV3PrepareMainSquadProc.NONE;
			}
		}

		// Token: 0x06028E31 RID: 167473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E31")]
		[Address(RVA = "0x245A200", Offset = "0x2458E00", VA = "0x18245A200", Slot = "10")]
		protected override void OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel model)
		{
		}

		// Token: 0x06028E32 RID: 167474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E32")]
		[Address(RVA = "0x245A740", Offset = "0x2459340", VA = "0x18245A740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028E33 RID: 167475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E33")]
		[Address(RVA = "0x245A080", Offset = "0x2458C80", VA = "0x18245A080")]
		public void EventOnNext()
		{
		}

		// Token: 0x06028E34 RID: 167476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E34")]
		[Address(RVA = "0x245A140", Offset = "0x2458D40", VA = "0x18245A140")]
		public void EventOnSwitchShowSkill()
		{
		}

		// Token: 0x06028E35 RID: 167477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E35")]
		[Address(RVA = "0x245A640", Offset = "0x2459240", VA = "0x18245A640")]
		private void _EventOnSetSelectedSkill(int instId, string skillId)
		{
		}

		// Token: 0x06028E36 RID: 167478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E36")]
		[Address(RVA = "0x245A540", Offset = "0x2459140", VA = "0x18245A540")]
		private void _EventOnSetSelectedModule(int instId, string moduleId)
		{
		}

		// Token: 0x06028E37 RID: 167479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E37")]
		[Address(RVA = "0x245A920", Offset = "0x2459520", VA = "0x18245A920")]
		public ActMultiV3PrepareMainSquadPanelProcSkillView()
		{
		}

		// Token: 0x06028E38 RID: 167480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E38")]
		[Address(RVA = "0x2459360", Offset = "0x2457F60", VA = "0x182459360")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel P0)
		{
		}

		// Token: 0x0403A525 RID: 238885
		[Token(Token = "0x403A525")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _tabSwitchAnim;

		// Token: 0x0403A526 RID: 238886
		[Token(Token = "0x403A526")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PrefabMark _invertTips;

		// Token: 0x0403A527 RID: 238887
		[Token(Token = "0x403A527")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _charCardContent;

		// Token: 0x0403A528 RID: 238888
		[Token(Token = "0x403A528")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect _cardScrollRect;

		// Token: 0x0403A529 RID: 238889
		[Token(Token = "0x403A529")]
		[FieldOffset(Offset = "0x68")]
		private List<ActMultiV3PrepareMainSkillAndModuleCharCardModel> m_cachedCardModels;

		// Token: 0x0403A52A RID: 238890
		[Token(Token = "0x403A52A")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0403A52B RID: 238891
		[Token(Token = "0x403A52B")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_tabSwitchTween;

		// Token: 0x0403A52C RID: 238892
		[Token(Token = "0x403A52C")]
		[FieldOffset(Offset = "0x80")]
		private bool m_cachedShowSkill;

		// Token: 0x0403A52D RID: 238893
		[Token(Token = "0x403A52D")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedSeqNum;

		// Token: 0x0403A52E RID: 238894
		[Token(Token = "0x403A52E")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3PrepareMainSquadPanelProcSkillView.CharCardAdapter m_adapter;

		// Token: 0x0403A52F RID: 238895
		[Token(Token = "0x403A52F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_procType;

		// Token: 0x0403A530 RID: 238896
		[Token(Token = "0x403A530")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A531 RID: 238897
		[Token(Token = "0x403A531")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A532 RID: 238898
		[Token(Token = "0x403A532")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNext;

		// Token: 0x0403A533 RID: 238899
		[Token(Token = "0x403A533")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnSwitchShowSkill;

		// Token: 0x0403A534 RID: 238900
		[Token(Token = "0x403A534")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnSetSelectedSkill;

		// Token: 0x0403A535 RID: 238901
		[Token(Token = "0x403A535")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnSetSelectedModule;

		// Token: 0x0403A536 RID: 238902
		[Token(Token = "0x403A536")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007076 RID: 28790
		[Token(Token = "0x2007076")]
		private class CharCardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028E39 RID: 167481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028E39")]
			[Address(RVA = "0x2461D00", Offset = "0x2460900", VA = "0x182461D00")]
			public CharCardAdapter(ActMultiV3PrepareMainSquadPanelProcSkillView closure)
			{
			}

			// Token: 0x170060B1 RID: 24753
			// (get) Token: 0x06028E3A RID: 167482 RVA: 0x000D3800 File Offset: 0x000D1A00
			[Token(Token = "0x170060B1")]
			public override int count
			{
				[Token(Token = "0x6028E3A")]
				[Address(RVA = "0x2461D80", Offset = "0x2460980", VA = "0x182461D80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028E3B RID: 167483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028E3B")]
			[Address(RVA = "0x2461A50", Offset = "0x2460650", VA = "0x182461A50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403A537 RID: 238903
			[Token(Token = "0x403A537")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3PrepareMainSquadPanelProcSkillView m_closure;

			// Token: 0x0403A538 RID: 238904
			[Token(Token = "0x403A538")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A539 RID: 238905
			[Token(Token = "0x403A539")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A53A RID: 238906
			[Token(Token = "0x403A53A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
