using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C83 RID: 19587
	[Token(Token = "0x2004C83")]
	public class OpenServerV2ChainLoginView : OpenServerV2FuncAbstractView
	{
		// Token: 0x0601D5DF RID: 120287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5DF")]
		[Address(RVA = "0x16EDC10", Offset = "0x16EC810", VA = "0x1816EDC10", Slot = "4")]
		public override void Render(OpenServerV2MainViewModel viewModel, bool isInit)
		{
		}

		// Token: 0x0601D5E0 RID: 120288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5E0")]
		[Address(RVA = "0x16EDE10", Offset = "0x16ECA10", VA = "0x1816EDE10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D5E1 RID: 120289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5E1")]
		[Address(RVA = "0x16EE150", Offset = "0x16ECD50", VA = "0x1816EE150")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x0601D5E2 RID: 120290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5E2")]
		[Address(RVA = "0x16EDFE0", Offset = "0x16ECBE0", VA = "0x1816EDFE0")]
		public void _OnCharClick(int index)
		{
		}

		// Token: 0x0601D5E3 RID: 120291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5E3")]
		[Address(RVA = "0x16EE250", Offset = "0x16ECE50", VA = "0x1816EE250")]
		public OpenServerV2ChainLoginView()
		{
		}

		// Token: 0x04026A5F RID: 158303
		[Token(Token = "0x4026A5F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04026A60 RID: 158304
		[Token(Token = "0x4026A60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemLayoutContent;

		// Token: 0x04026A61 RID: 158305
		[Token(Token = "0x4026A61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charLayoutContent;

		// Token: 0x04026A62 RID: 158306
		[Token(Token = "0x4026A62")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04026A63 RID: 158307
		[Token(Token = "0x4026A63")]
		[FieldOffset(Offset = "0x38")]
		private OpenServerV2ChainLoginViewModel m_viewModel;

		// Token: 0x04026A64 RID: 158308
		[Token(Token = "0x4026A64")]
		[FieldOffset(Offset = "0x40")]
		private OpenServerV2ChainLoginView.ChainLoginAdapter m_itemAdapter;

		// Token: 0x04026A65 RID: 158309
		[Token(Token = "0x4026A65")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026A66 RID: 158310
		[Token(Token = "0x4026A66")]
		[FieldOffset(Offset = "0x58")]
		private OpenServerV2ChainLoginView.CharBlockAdapter m_blockAdapter;

		// Token: 0x04026A67 RID: 158311
		[Token(Token = "0x4026A67")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04026A68 RID: 158312
		[Token(Token = "0x4026A68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026A69 RID: 158313
		[Token(Token = "0x4026A69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026A6A RID: 158314
		[Token(Token = "0x4026A6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04026A6B RID: 158315
		[Token(Token = "0x4026A6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCharClick;

		// Token: 0x04026A6C RID: 158316
		[Token(Token = "0x4026A6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C84 RID: 19588
		[Token(Token = "0x2004C84")]
		private class ChainLoginAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D5E4 RID: 120292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D5E4")]
			[Address(RVA = "0x16DDDB0", Offset = "0x16DC9B0", VA = "0x1816DDDB0")]
			public ChainLoginAdapter(OpenServerV2ChainLoginView closure)
			{
			}

			// Token: 0x170044EA RID: 17642
			// (get) Token: 0x0601D5E5 RID: 120293 RVA: 0x000AB438 File Offset: 0x000A9638
			[Token(Token = "0x170044EA")]
			public override int count
			{
				[Token(Token = "0x601D5E5")]
				[Address(RVA = "0x16DDE30", Offset = "0x16DCA30", VA = "0x1816DDE30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D5E6 RID: 120294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D5E6")]
			[Address(RVA = "0x16DDB50", Offset = "0x16DC750", VA = "0x1816DDB50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026A6D RID: 158317
			[Token(Token = "0x4026A6D")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerV2ChainLoginView m_closure;

			// Token: 0x04026A6E RID: 158318
			[Token(Token = "0x4026A6E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026A6F RID: 158319
			[Token(Token = "0x4026A6F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026A70 RID: 158320
			[Token(Token = "0x4026A70")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004C85 RID: 19589
		[Token(Token = "0x2004C85")]
		private class CharBlockAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D5E7 RID: 120295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D5E7")]
			[Address(RVA = "0x16DE300", Offset = "0x16DCF00", VA = "0x1816DE300")]
			public CharBlockAdapter(OpenServerV2ChainLoginView closure)
			{
			}

			// Token: 0x170044EB RID: 17643
			// (get) Token: 0x0601D5E8 RID: 120296 RVA: 0x000AB450 File Offset: 0x000A9650
			[Token(Token = "0x170044EB")]
			public override int count
			{
				[Token(Token = "0x601D5E8")]
				[Address(RVA = "0x16DE450", Offset = "0x16DD050", VA = "0x1816DE450", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D5E9 RID: 120297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D5E9")]
			[Address(RVA = "0x16DDF00", Offset = "0x16DCB00", VA = "0x1816DDF00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026A71 RID: 158321
			[Token(Token = "0x4026A71")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerV2ChainLoginView m_closure;

			// Token: 0x04026A72 RID: 158322
			[Token(Token = "0x4026A72")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026A73 RID: 158323
			[Token(Token = "0x4026A73")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026A74 RID: 158324
			[Token(Token = "0x4026A74")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
