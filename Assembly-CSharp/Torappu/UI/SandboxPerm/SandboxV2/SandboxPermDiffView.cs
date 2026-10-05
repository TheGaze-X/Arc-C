using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200401E RID: 16414
	[Token(Token = "0x200401E")]
	public class SandboxPermDiffView : DataBinder<SandboxPermDiffGroupProperty>
	{
		// Token: 0x06019694 RID: 104084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019694")]
		[Address(RVA = "0x1216760", Offset = "0x1215360", VA = "0x181216760", Slot = "7")]
		public override void OnValueChanged(SandboxPermDiffGroupProperty property)
		{
		}

		// Token: 0x06019695 RID: 104085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019695")]
		[Address(RVA = "0x1216920", Offset = "0x1215520", VA = "0x181216920")]
		public SandboxPermDiffView()
		{
		}

		// Token: 0x0401F9DD RID: 129501
		[Token(Token = "0x401F9DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401F9DE RID: 129502
		[Token(Token = "0x401F9DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _tipText;

		// Token: 0x0401F9DF RID: 129503
		[Token(Token = "0x401F9DF")]
		[FieldOffset(Offset = "0x30")]
		private SandboxPermDiffView.Adapter m_adapter;

		// Token: 0x0401F9E0 RID: 129504
		[Token(Token = "0x401F9E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F9E1 RID: 129505
		[Token(Token = "0x401F9E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200401F RID: 16415
		[Token(Token = "0x200401F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C91 RID: 15505
			// (get) Token: 0x06019696 RID: 104086 RVA: 0x0009DF68 File Offset: 0x0009C168
			[Token(Token = "0x17003C91")]
			public override int count
			{
				[Token(Token = "0x6019696")]
				[Address(RVA = "0x1212C60", Offset = "0x1211860", VA = "0x181212C60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019697 RID: 104087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019697")]
			[Address(RVA = "0x1212670", Offset = "0x1211270", VA = "0x181212670", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019698 RID: 104088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019698")]
			[Address(RVA = "0x1212B80", Offset = "0x1211780", VA = "0x181212B80")]
			public Adapter()
			{
			}

			// Token: 0x0401F9E2 RID: 129506
			[Token(Token = "0x401F9E2")]
			[FieldOffset(Offset = "0x20")]
			public List<SandboxPermDiffViewModel> viewModel;

			// Token: 0x0401F9E3 RID: 129507
			[Token(Token = "0x401F9E3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F9E4 RID: 129508
			[Token(Token = "0x401F9E4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F9E5 RID: 129509
			[Token(Token = "0x401F9E5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
