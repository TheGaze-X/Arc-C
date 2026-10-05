using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200792E RID: 31022
	[Token(Token = "0x200792E")]
	public class Act1ArcadeBadgeBookItemTailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x0602B864 RID: 178276 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B865 RID: 178277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065FB")]
		public ScrollRect parentScroll
		{
			[Token(Token = "0x602B864")]
			[Address(RVA = "0x276AD60", Offset = "0x2769960", VA = "0x18276AD60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B865")]
			[Address(RVA = "0x276ADC0", Offset = "0x27699C0", VA = "0x18276ADC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B866 RID: 178278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B866")]
		[Address(RVA = "0x276A780", Offset = "0x2769380", VA = "0x18276A780")]
		public void Render(string actId, Act1ArcadeBadgeBookItemViewModel model)
		{
		}

		// Token: 0x0602B867 RID: 178279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B867")]
		[Address(RVA = "0x276AB50", Offset = "0x2769750", VA = "0x18276AB50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B868 RID: 178280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B868")]
		[Address(RVA = "0x276AD00", Offset = "0x2769900", VA = "0x18276AD00")]
		public Act1ArcadeBadgeBookItemTailView()
		{
		}

		// Token: 0x0403EF05 RID: 257797
		[Token(Token = "0x403EF05")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0403EF06 RID: 257798
		[Token(Token = "0x403EF06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buffRangeDescText;

		// Token: 0x0403EF07 RID: 257799
		[Token(Token = "0x403EF07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _tierContent;

		// Token: 0x0403EF08 RID: 257800
		[Token(Token = "0x403EF08")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0403EF09 RID: 257801
		[Token(Token = "0x403EF09")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403EF0A RID: 257802
		[Token(Token = "0x403EF0A")]
		[FieldOffset(Offset = "0x40")]
		private Act1ArcadeBadgeBookItemTailView.Adapter m_adapter;

		// Token: 0x0403EF0C RID: 257804
		[Token(Token = "0x403EF0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_parentScroll;

		// Token: 0x0403EF0D RID: 257805
		[Token(Token = "0x403EF0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_parentScroll;

		// Token: 0x0403EF0E RID: 257806
		[Token(Token = "0x403EF0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EF0F RID: 257807
		[Token(Token = "0x403EF0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EF10 RID: 257808
		[Token(Token = "0x403EF10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200792F RID: 31023
		[Token(Token = "0x200792F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170065FC RID: 26108
			// (get) Token: 0x0602B869 RID: 178281 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B86A RID: 178282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065FC")]
			public string actId
			{
				[Token(Token = "0x602B869")]
				[Address(RVA = "0x277A180", Offset = "0x2778D80", VA = "0x18277A180")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B86A")]
				[Address(RVA = "0x277A760", Offset = "0x2779360", VA = "0x18277A760")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065FD RID: 26109
			// (get) Token: 0x0602B86B RID: 178283 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B86C RID: 178284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065FD")]
			public IList<Act1ArcadeBadgeBookItemTierViewModel> source
			{
				[Token(Token = "0x602B86B")]
				[Address(RVA = "0x277A680", Offset = "0x2779280", VA = "0x18277A680")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B86C")]
				[Address(RVA = "0x277AAB0", Offset = "0x27796B0", VA = "0x18277AAB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065FE RID: 26110
			// (get) Token: 0x0602B86D RID: 178285 RVA: 0x000DC5A8 File Offset: 0x000DA7A8
			[Token(Token = "0x170065FE")]
			public override int count
			{
				[Token(Token = "0x602B86D")]
				[Address(RVA = "0x277A1E0", Offset = "0x2778DE0", VA = "0x18277A1E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B86E RID: 178286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B86E")]
			[Address(RVA = "0x2779DD0", Offset = "0x27789D0", VA = "0x182779DD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B86F RID: 178287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B86F")]
			[Address(RVA = "0x277A0C0", Offset = "0x2778CC0", VA = "0x18277A0C0")]
			public Adapter()
			{
			}

			// Token: 0x0403EF13 RID: 257811
			[Token(Token = "0x403EF13")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_actId;

			// Token: 0x0403EF14 RID: 257812
			[Token(Token = "0x403EF14")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_actId;

			// Token: 0x0403EF15 RID: 257813
			[Token(Token = "0x403EF15")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_source;

			// Token: 0x0403EF16 RID: 257814
			[Token(Token = "0x403EF16")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_source;

			// Token: 0x0403EF17 RID: 257815
			[Token(Token = "0x403EF17")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403EF18 RID: 257816
			[Token(Token = "0x403EF18")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403EF19 RID: 257817
			[Token(Token = "0x403EF19")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
