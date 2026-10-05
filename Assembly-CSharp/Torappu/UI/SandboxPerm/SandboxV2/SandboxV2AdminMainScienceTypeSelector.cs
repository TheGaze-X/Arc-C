using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040D7 RID: 16599
	[Token(Token = "0x20040D7")]
	public class SandboxV2AdminMainScienceTypeSelector : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000087 RID: 135
		// (add) Token: 0x06019AD4 RID: 105172 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06019AD5 RID: 105173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000087")]
		public event Action<int> eSelectChanged
		{
			[Token(Token = "0x6019AD4")]
			[Address(RVA = "0x1281A30", Offset = "0x1280630", VA = "0x181281A30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6019AD5")]
			[Address(RVA = "0x1281B90", Offset = "0x1280790", VA = "0x181281B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06019AD6 RID: 105174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AD6")]
		[Address(RVA = "0x1281630", Offset = "0x1280230", VA = "0x181281630")]
		public void Init(IList<SandboxV2AdminMainScienceTypeItemData> typeList)
		{
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x06019AD7 RID: 105175 RVA: 0x0009F0D8 File Offset: 0x0009D2D8
		// (set) Token: 0x06019AD8 RID: 105176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D41")]
		public int selected
		{
			[Token(Token = "0x6019AD7")]
			[Address(RVA = "0x1281B30", Offset = "0x1280730", VA = "0x181281B30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019AD8")]
			[Address(RVA = "0x1281C90", Offset = "0x1280890", VA = "0x181281C90")]
			set
			{
			}
		}

		// Token: 0x06019AD9 RID: 105177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AD9")]
		[Address(RVA = "0x1281910", Offset = "0x1280510", VA = "0x181281910")]
		private void _SetSelect(int selectedIdx)
		{
		}

		// Token: 0x06019ADA RID: 105178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019ADA")]
		[Address(RVA = "0x12817F0", Offset = "0x12803F0", VA = "0x1812817F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019ADB RID: 105179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019ADB")]
		[Address(RVA = "0x12819D0", Offset = "0x12805D0", VA = "0x1812819D0")]
		public SandboxV2AdminMainScienceTypeSelector()
		{
		}

		// Token: 0x040201BD RID: 131517
		[Token(Token = "0x40201BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layout;

		// Token: 0x040201BE RID: 131518
		[Token(Token = "0x40201BE")]
		[FieldOffset(Offset = "0x20")]
		private SandboxV2AdminMainScienceTypeSelector.LayoutAdapter m_adapter;

		// Token: 0x040201BF RID: 131519
		[Token(Token = "0x40201BF")]
		[FieldOffset(Offset = "0x28")]
		private IList<SandboxV2AdminMainScienceTypeItemData> m_typeList;

		// Token: 0x040201C0 RID: 131520
		[Token(Token = "0x40201C0")]
		[FieldOffset(Offset = "0x30")]
		private int m_selected;

		// Token: 0x040201C2 RID: 131522
		[Token(Token = "0x40201C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eSelectChanged;

		// Token: 0x040201C3 RID: 131523
		[Token(Token = "0x40201C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eSelectChanged;

		// Token: 0x040201C4 RID: 131524
		[Token(Token = "0x40201C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040201C5 RID: 131525
		[Token(Token = "0x40201C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x040201C6 RID: 131526
		[Token(Token = "0x40201C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x040201C7 RID: 131527
		[Token(Token = "0x40201C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetSelect;

		// Token: 0x040201C8 RID: 131528
		[Token(Token = "0x40201C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040201C9 RID: 131529
		[Token(Token = "0x40201C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040D8 RID: 16600
		[Token(Token = "0x20040D8")]
		private class LayoutAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019ADC RID: 105180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019ADC")]
			[Address(RVA = "0x1271FC0", Offset = "0x1270BC0", VA = "0x181271FC0")]
			public LayoutAdapter(SandboxV2AdminMainScienceTypeSelector closure)
			{
			}

			// Token: 0x17003D42 RID: 15682
			// (get) Token: 0x06019ADD RID: 105181 RVA: 0x0009F0F0 File Offset: 0x0009D2F0
			[Token(Token = "0x17003D42")]
			public override int count
			{
				[Token(Token = "0x6019ADD")]
				[Address(RVA = "0x1272040", Offset = "0x1270C40", VA = "0x181272040", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019ADE RID: 105182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019ADE")]
			[Address(RVA = "0x1271AF0", Offset = "0x12706F0", VA = "0x181271AF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040201CA RID: 131530
			[Token(Token = "0x40201CA")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2AdminMainScienceTypeSelector m_closure;

			// Token: 0x040201CB RID: 131531
			[Token(Token = "0x40201CB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040201CC RID: 131532
			[Token(Token = "0x40201CC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040201CD RID: 131533
			[Token(Token = "0x40201CD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
