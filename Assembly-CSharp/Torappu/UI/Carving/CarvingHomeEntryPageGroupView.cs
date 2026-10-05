using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006023 RID: 24611
	[Token(Token = "0x2006023")]
	public class CarvingHomeEntryPageGroupView : DataBinder<CarvingHomeEntryProperty>, IHotfixable
	{
		// Token: 0x0602397C RID: 145788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602397C")]
		[Address(RVA = "0x1E3AE80", Offset = "0x1E39A80", VA = "0x181E3AE80", Slot = "7")]
		public override void OnValueChanged(CarvingHomeEntryProperty property)
		{
		}

		// Token: 0x0602397D RID: 145789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602397D")]
		[Address(RVA = "0x1E3B080", Offset = "0x1E39C80", VA = "0x181E3B080")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602397E RID: 145790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602397E")]
		[Address(RVA = "0x1E3B1A0", Offset = "0x1E39DA0", VA = "0x181E3B1A0")]
		public CarvingHomeEntryPageGroupView()
		{
		}

		// Token: 0x0403145C RID: 201820
		[Token(Token = "0x403145C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403145D RID: 201821
		[Token(Token = "0x403145D")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0403145E RID: 201822
		[Token(Token = "0x403145E")]
		[FieldOffset(Offset = "0x30")]
		private CarvingHomeEntryPageGroupView.Adapter m_adapter;

		// Token: 0x0403145F RID: 201823
		[Token(Token = "0x403145F")]
		[FieldOffset(Offset = "0x38")]
		private List<CarvingHomeEntryItemViewModel> m_cachedItemList;

		// Token: 0x04031460 RID: 201824
		[Token(Token = "0x4031460")]
		[FieldOffset(Offset = "0x40")]
		private string m_cacheFocusItemId;

		// Token: 0x04031461 RID: 201825
		[Token(Token = "0x4031461")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031462 RID: 201826
		[Token(Token = "0x4031462")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031463 RID: 201827
		[Token(Token = "0x4031463")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006024 RID: 24612
		[Token(Token = "0x2006024")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602397F RID: 145791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602397F")]
			[Address(RVA = "0x1E28E00", Offset = "0x1E27A00", VA = "0x181E28E00")]
			public Adapter(CarvingHomeEntryPageGroupView closure)
			{
			}

			// Token: 0x1700540A RID: 21514
			// (get) Token: 0x06023980 RID: 145792 RVA: 0x000C14B8 File Offset: 0x000BF6B8
			[Token(Token = "0x1700540A")]
			public override int count
			{
				[Token(Token = "0x6023980")]
				[Address(RVA = "0x1E28E80", Offset = "0x1E27A80", VA = "0x181E28E80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023981 RID: 145793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023981")]
			[Address(RVA = "0x1E28B30", Offset = "0x1E27730", VA = "0x181E28B30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031464 RID: 201828
			[Token(Token = "0x4031464")]
			[FieldOffset(Offset = "0x20")]
			private CarvingHomeEntryPageGroupView m_closure;

			// Token: 0x04031465 RID: 201829
			[Token(Token = "0x4031465")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031466 RID: 201830
			[Token(Token = "0x4031466")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031467 RID: 201831
			[Token(Token = "0x4031467")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
