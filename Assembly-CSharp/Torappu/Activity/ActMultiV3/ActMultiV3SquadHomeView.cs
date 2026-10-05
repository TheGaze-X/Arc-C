using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FD7 RID: 28631
	[Token(Token = "0x2006FD7")]
	public class ActMultiV3SquadHomeView : DataBinder<ActMultiV3SquadGroupProp>
	{
		// Token: 0x06028AB1 RID: 166577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AB1")]
		[Address(RVA = "0x23FA010", Offset = "0x23F8C10", VA = "0x1823FA010", Slot = "7")]
		public override void OnValueChanged(ActMultiV3SquadGroupProp property)
		{
		}

		// Token: 0x06028AB2 RID: 166578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AB2")]
		[Address(RVA = "0x23FA500", Offset = "0x23F9100", VA = "0x1823FA500")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028AB3 RID: 166579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AB3")]
		[Address(RVA = "0x23FA620", Offset = "0x23F9220", VA = "0x1823FA620")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x06028AB4 RID: 166580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AB4")]
		[Address(RVA = "0x23FA700", Offset = "0x23F9300", VA = "0x1823FA700")]
		public ActMultiV3SquadHomeView()
		{
		}

		// Token: 0x04039F00 RID: 237312
		[Token(Token = "0x4039F00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _tabList;

		// Token: 0x04039F01 RID: 237313
		[Token(Token = "0x4039F01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleLayoutGroup _charList;

		// Token: 0x04039F02 RID: 237314
		[Token(Token = "0x4039F02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3SquadClassColView _classColPrefab;

		// Token: 0x04039F03 RID: 237315
		[Token(Token = "0x4039F03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _classColWidth;

		// Token: 0x04039F04 RID: 237316
		[Token(Token = "0x4039F04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActMultiV3SquadCharColView _charColPrefab;

		// Token: 0x04039F05 RID: 237317
		[Token(Token = "0x4039F05")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _charColWidth;

		// Token: 0x04039F06 RID: 237318
		[Token(Token = "0x4039F06")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgEffectIcon;

		// Token: 0x04039F07 RID: 237319
		[Token(Token = "0x4039F07")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _btnSquadEffectGO;

		// Token: 0x04039F08 RID: 237320
		[Token(Token = "0x4039F08")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04039F09 RID: 237321
		[Token(Token = "0x4039F09")]
		[FieldOffset(Offset = "0x68")]
		private ActMultiV3SquadGroupModel m_squadGroupModel;

		// Token: 0x04039F0A RID: 237322
		[Token(Token = "0x4039F0A")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3SquadHomeView.TabListAdapter m_tabListAdapter;

		// Token: 0x04039F0B RID: 237323
		[Token(Token = "0x4039F0B")]
		[FieldOffset(Offset = "0x78")]
		private ActMultiV3SquadHomeView.CharListAdapter m_charListAdapter;

		// Token: 0x04039F0C RID: 237324
		[Token(Token = "0x4039F0C")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039F0D RID: 237325
		[Token(Token = "0x4039F0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039F0E RID: 237326
		[Token(Token = "0x4039F0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039F0F RID: 237327
		[Token(Token = "0x4039F0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04039F10 RID: 237328
		[Token(Token = "0x4039F10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FD8 RID: 28632
		[Token(Token = "0x2006FD8")]
		private class CharListAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06028AB5 RID: 166581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AB5")]
			[Address(RVA = "0x2402940", Offset = "0x2401540", VA = "0x182402940")]
			public CharListAdapter(ActMultiV3SquadHomeView closure)
			{
			}

			// Token: 0x06028AB6 RID: 166582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028AB6")]
			[Address(RVA = "0x2401F80", Offset = "0x2400B80", VA = "0x182401F80", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06028AB7 RID: 166583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AB7")]
			[Address(RVA = "0x24023C0", Offset = "0x2400FC0", VA = "0x1824023C0")]
			private void _AddColView(List<UIRecycleLayoutAdapter.IVirtualView> viewList, ActMultiV3PriClassModel priModel)
			{
			}

			// Token: 0x06028AB8 RID: 166584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AB8")]
			[Address(RVA = "0x24020E0", Offset = "0x2400CE0", VA = "0x1824020E0")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x04039F11 RID: 237329
			[Token(Token = "0x4039F11")]
			private const int CLASS_COL_CHAR_CNT = 6;

			// Token: 0x04039F12 RID: 237330
			[Token(Token = "0x4039F12")]
			private const int CHAR_COL_CHAR_CNT = 2;

			// Token: 0x04039F13 RID: 237331
			[Token(Token = "0x4039F13")]
			[FieldOffset(Offset = "0x18")]
			private ActMultiV3SquadHomeView m_closure;

			// Token: 0x04039F14 RID: 237332
			[Token(Token = "0x4039F14")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039F15 RID: 237333
			[Token(Token = "0x4039F15")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04039F16 RID: 237334
			[Token(Token = "0x4039F16")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__AddColView;

			// Token: 0x04039F17 RID: 237335
			[Token(Token = "0x4039F17")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;
		}

		// Token: 0x02006FD9 RID: 28633
		[Token(Token = "0x2006FD9")]
		private class TabListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028AB9 RID: 166585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AB9")]
			[Address(RVA = "0x2403FB0", Offset = "0x2402BB0", VA = "0x182403FB0")]
			public TabListAdapter(ActMultiV3SquadHomeView closure)
			{
			}

			// Token: 0x17006003 RID: 24579
			// (get) Token: 0x06028ABA RID: 166586 RVA: 0x000D29F0 File Offset: 0x000D0BF0
			[Token(Token = "0x17006003")]
			public override int count
			{
				[Token(Token = "0x6028ABA")]
				[Address(RVA = "0x2404030", Offset = "0x2402C30", VA = "0x182404030", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028ABB RID: 166587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028ABB")]
			[Address(RVA = "0x2403CE0", Offset = "0x24028E0", VA = "0x182403CE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039F18 RID: 237336
			[Token(Token = "0x4039F18")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3SquadHomeView m_closure;

			// Token: 0x04039F19 RID: 237337
			[Token(Token = "0x4039F19")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039F1A RID: 237338
			[Token(Token = "0x4039F1A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039F1B RID: 237339
			[Token(Token = "0x4039F1B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
