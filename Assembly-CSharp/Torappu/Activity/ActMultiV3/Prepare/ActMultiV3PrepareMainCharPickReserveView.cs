using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007059 RID: 28761
	[Token(Token = "0x2007059")]
	public class ActMultiV3PrepareMainCharPickReserveView : DataBinder<ActMultiV3PrepareMainCharPickPanelViewModelProperty>
	{
		// Token: 0x06028D7C RID: 167292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D7C")]
		[Address(RVA = "0x2437AE0", Offset = "0x24366E0", VA = "0x182437AE0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainCharPickPanelViewModelProperty property)
		{
		}

		// Token: 0x06028D7D RID: 167293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D7D")]
		[Address(RVA = "0x2437DE0", Offset = "0x24369E0", VA = "0x182437DE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028D7E RID: 167294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D7E")]
		[Address(RVA = "0x2437EF0", Offset = "0x2436AF0", VA = "0x182437EF0")]
		public ActMultiV3PrepareMainCharPickReserveView()
		{
		}

		// Token: 0x0403A416 RID: 238614
		[Token(Token = "0x403A416")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateFadeSwitcher _switcher;

		// Token: 0x0403A417 RID: 238615
		[Token(Token = "0x403A417")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0403A418 RID: 238616
		[Token(Token = "0x403A418")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyFlag;

		// Token: 0x0403A419 RID: 238617
		[Token(Token = "0x403A419")]
		[FieldOffset(Offset = "0x38")]
		private ActMultiV3PrepareMainCharPickReserveView.Adapter m_listAdapter;

		// Token: 0x0403A41A RID: 238618
		[Token(Token = "0x403A41A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A41B RID: 238619
		[Token(Token = "0x403A41B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A41C RID: 238620
		[Token(Token = "0x403A41C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200705A RID: 28762
		[Token(Token = "0x200705A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700608F RID: 24719
			// (get) Token: 0x06028D7F RID: 167295 RVA: 0x000D33B0 File Offset: 0x000D15B0
			[Token(Token = "0x1700608F")]
			public override int count
			{
				[Token(Token = "0x6028D7F")]
				[Address(RVA = "0x24477F0", Offset = "0x24463F0", VA = "0x1824477F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028D80 RID: 167296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028D80")]
			[Address(RVA = "0x2447470", Offset = "0x2446070", VA = "0x182447470", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028D81 RID: 167297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D81")]
			[Address(RVA = "0x2447790", Offset = "0x2446390", VA = "0x182447790")]
			public Adapter()
			{
			}

			// Token: 0x0403A41D RID: 238621
			[Token(Token = "0x403A41D")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3PrepareMainCharCardModel> charList;

			// Token: 0x0403A41E RID: 238622
			[Token(Token = "0x403A41E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A41F RID: 238623
			[Token(Token = "0x403A41F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403A420 RID: 238624
			[Token(Token = "0x403A420")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
