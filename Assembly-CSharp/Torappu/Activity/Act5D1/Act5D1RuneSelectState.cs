using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007243 RID: 29251
	[Token(Token = "0x2007243")]
	public class Act5D1RuneSelectState : PopupFloatState
	{
		// Token: 0x0602972F RID: 169775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602972F")]
		[Address(RVA = "0x24CA760", Offset = "0x24C9360", VA = "0x1824CA760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029730 RID: 169776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029730")]
		[Address(RVA = "0x24CA400", Offset = "0x24C9000", VA = "0x1824CA400", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029731 RID: 169777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029731")]
		[Address(RVA = "0x24CA310", Offset = "0x24C8F10", VA = "0x1824CA310", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029732 RID: 169778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029732")]
		[Address(RVA = "0x24CA290", Offset = "0x24C8E90", VA = "0x1824CA290", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029733 RID: 169779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029733")]
		[Address(RVA = "0x24C9C40", Offset = "0x24C8840", VA = "0x1824C9C40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029734 RID: 169780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029734")]
		[Address(RVA = "0x24C9CA0", Offset = "0x24C88A0", VA = "0x1824C9CA0")]
		public void OnClick(string runeId)
		{
		}

		// Token: 0x06029735 RID: 169781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029735")]
		[Address(RVA = "0x24CA970", Offset = "0x24C9570", VA = "0x1824CA970")]
		public Act5D1RuneSelectState()
		{
		}

		// Token: 0x06029738 RID: 169784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029738")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029739 RID: 169785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029739")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602973A RID: 169786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602973A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B37F RID: 242559
		[Token(Token = "0x403B37F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _point1;

		// Token: 0x0403B380 RID: 242560
		[Token(Token = "0x403B380")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _point2;

		// Token: 0x0403B381 RID: 242561
		[Token(Token = "0x403B381")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act5D1ResourceBar _resourceBar;

		// Token: 0x0403B382 RID: 242562
		[Token(Token = "0x403B382")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403B383 RID: 242563
		[Token(Token = "0x403B383")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Act5D1RuneStageStateBean _stateBean;

		// Token: 0x0403B384 RID: 242564
		[Token(Token = "0x403B384")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ScrollRectSoftMask _softMask;

		// Token: 0x0403B385 RID: 242565
		[Token(Token = "0x403B385")]
		[FieldOffset(Offset = "0xA0")]
		private Act5D1RuneSelectState.Adapter m_adapter;

		// Token: 0x0403B386 RID: 242566
		[Token(Token = "0x403B386")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInit;

		// Token: 0x0403B387 RID: 242567
		[Token(Token = "0x403B387")]
		[FieldOffset(Offset = "0xB0")]
		private string m_stageId;

		// Token: 0x0403B388 RID: 242568
		[Token(Token = "0x403B388")]
		[FieldOffset(Offset = "0xB8")]
		private string m_runeId;

		// Token: 0x0403B389 RID: 242569
		[Token(Token = "0x403B389")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B38A RID: 242570
		[Token(Token = "0x403B38A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B38B RID: 242571
		[Token(Token = "0x403B38B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B38C RID: 242572
		[Token(Token = "0x403B38C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B38D RID: 242573
		[Token(Token = "0x403B38D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B38E RID: 242574
		[Token(Token = "0x403B38E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B38F RID: 242575
		[Token(Token = "0x403B38F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007244 RID: 29252
		[Token(Token = "0x2007244")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17006229 RID: 25129
			// (get) Token: 0x0602973B RID: 169787 RVA: 0x000D5BA0 File Offset: 0x000D3DA0
			[Token(Token = "0x17006229")]
			public override int count
			{
				[Token(Token = "0x602973B")]
				[Address(RVA = "0x24D3950", Offset = "0x24D2550", VA = "0x1824D3950", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602973C RID: 169788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602973C")]
			[Address(RVA = "0x24D37B0", Offset = "0x24D23B0", VA = "0x1824D37B0")]
			public Adapter()
			{
			}

			// Token: 0x0602973D RID: 169789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602973D")]
			[Address(RVA = "0x24D33E0", Offset = "0x24D1FE0", VA = "0x1824D33E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B390 RID: 242576
			[Token(Token = "0x403B390")]
			[FieldOffset(Offset = "0x20")]
			public RuneClassify classify;

			// Token: 0x0403B391 RID: 242577
			[Token(Token = "0x403B391")]
			[FieldOffset(Offset = "0x28")]
			public List<RuneInfo> infoList;

			// Token: 0x0403B392 RID: 242578
			[Token(Token = "0x403B392")]
			[FieldOffset(Offset = "0x30")]
			public UIStringEvent onClickEvent;

			// Token: 0x0403B393 RID: 242579
			[Token(Token = "0x403B393")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B394 RID: 242580
			[Token(Token = "0x403B394")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B395 RID: 242581
			[Token(Token = "0x403B395")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
