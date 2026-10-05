using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003902 RID: 14594
	[Token(Token = "0x2003902")]
	public class UISimpleRecycleLayoutAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0601712D RID: 94509 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601712E RID: 94510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700371E")]
		public IList<UISimpleRecycleLayoutItemViewModel> dataSet
		{
			[Token(Token = "0x601712D")]
			[Address(RVA = "0xF7F080", Offset = "0xF7DC80", VA = "0x180F7F080")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601712E")]
			[Address(RVA = "0xF7F0E0", Offset = "0xF7DCE0", VA = "0x180F7F0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601712F RID: 94511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601712F")]
		[Address(RVA = "0xF7ECF0", Offset = "0xF7D8F0", VA = "0x180F7ECF0")]
		public UISimpleRecycleLayoutAdapter(IList<UISimpleRecycleLayoutItemView> prefabList)
		{
		}

		// Token: 0x06017130 RID: 94512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017130")]
		[Address(RVA = "0xF7E860", Offset = "0xF7D460", VA = "0x180F7E860", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06017131 RID: 94513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017131")]
		[Address(RVA = "0xF7EC30", Offset = "0xF7D830", VA = "0x180F7EC30")]
		public void NotifyRebuild()
		{
		}

		// Token: 0x0401BD84 RID: 114052
		[Token(Token = "0x401BD84")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, UISimpleRecycleLayoutItemView> m_prefabDict;

		// Token: 0x0401BD86 RID: 114054
		[Token(Token = "0x401BD86")]
		[FieldOffset(Offset = "0x28")]
		public ValueBundle value;

		// Token: 0x0401BD87 RID: 114055
		[Token(Token = "0x401BD87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataSet;

		// Token: 0x0401BD88 RID: 114056
		[Token(Token = "0x401BD88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dataSet;

		// Token: 0x0401BD89 RID: 114057
		[Token(Token = "0x401BD89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401BD8A RID: 114058
		[Token(Token = "0x401BD8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0401BD8B RID: 114059
		[Token(Token = "0x401BD8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyRebuild;
	}
}
