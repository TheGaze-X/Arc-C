using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200774C RID: 30540
	[Token(Token = "0x200774C")]
	public class Act1VHalfidlePlotBackpackCardItemAdapter : LoopScrollAdapter<Act1VHalfidlePlotBackpackCardItemAdapter.ViewHolder, Act1VHalfidlePlotViewModel>
	{
		// Token: 0x1700649A RID: 25754
		// (get) Token: 0x0602AE61 RID: 175713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AE62 RID: 175714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700649A")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x602AE61")]
			[Address(RVA = "0x26B7E90", Offset = "0x26B6A90", VA = "0x1826B7E90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AE62")]
			[Address(RVA = "0x26B7FD0", Offset = "0x26B6BD0", VA = "0x1826B7FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700649B RID: 25755
		// (get) Token: 0x0602AE63 RID: 175715 RVA: 0x000DA5E0 File Offset: 0x000D87E0
		// (set) Token: 0x0602AE64 RID: 175716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700649B")]
		public bool showTrackpoint
		{
			[Token(Token = "0x602AE63")]
			[Address(RVA = "0x26B7EF0", Offset = "0x26B6AF0", VA = "0x1826B7EF0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x602AE64")]
			[Address(RVA = "0x26B8050", Offset = "0x26B6C50", VA = "0x1826B8050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700649C RID: 25756
		// (set) Token: 0x0602AE65 RID: 175717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700649C")]
		public string actId
		{
			[Token(Token = "0x602AE65")]
			[Address(RVA = "0x26B7F50", Offset = "0x26B6B50", VA = "0x1826B7F50")]
			set
			{
			}
		}

		// Token: 0x0602AE66 RID: 175718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE66")]
		[Address(RVA = "0x26B7B60", Offset = "0x26B6760", VA = "0x1826B7B60", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act1VHalfidlePlotBackpackCardItemAdapter.ViewHolder holder, Act1VHalfidlePlotViewModel data)
		{
		}

		// Token: 0x0602AE67 RID: 175719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE67")]
		[Address(RVA = "0x26B7A30", Offset = "0x26B6630", VA = "0x1826B7A30", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602AE68 RID: 175720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE68")]
		[Address(RVA = "0x26B7E20", Offset = "0x26B6A20", VA = "0x1826B7E20")]
		public Act1VHalfidlePlotBackpackCardItemAdapter()
		{
		}

		// Token: 0x0403DDB7 RID: 253367
		[Token(Token = "0x403DDB7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act1VHalfidlePlotCardItemView _prefab;

		// Token: 0x0403DDBA RID: 253370
		[Token(Token = "0x403DDBA")]
		[FieldOffset(Offset = "0x70")]
		private string m_actId;

		// Token: 0x0403DDBB RID: 253371
		[Token(Token = "0x403DDBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403DDBC RID: 253372
		[Token(Token = "0x403DDBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403DDBD RID: 253373
		[Token(Token = "0x403DDBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showTrackpoint;

		// Token: 0x0403DDBE RID: 253374
		[Token(Token = "0x403DDBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showTrackpoint;

		// Token: 0x0403DDBF RID: 253375
		[Token(Token = "0x403DDBF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403DDC0 RID: 253376
		[Token(Token = "0x403DDC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403DDC1 RID: 253377
		[Token(Token = "0x403DDC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403DDC2 RID: 253378
		[Token(Token = "0x403DDC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200774D RID: 30541
		[Token(Token = "0x200774D")]
		public class ViewHolder
		{
			// Token: 0x0602AE69 RID: 175721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE69")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403DDC3 RID: 253379
			[Token(Token = "0x403DDC3")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfidlePlotCardItemView item;
		}
	}
}
