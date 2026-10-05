using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActArchive;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004108 RID: 16648
	[Token(Token = "0x2004108")]
	public class SandboxV2ArchiveAchievementTypeFilterView : MonoBehaviour, IArchiveAchievementListFilterView, IHotfixable
	{
		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x06019BDD RID: 105437 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019BDE RID: 105438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D62")]
		public Action<ArchiveAchievementListFilterViewModel.FilterType, string> onSelectionChange
		{
			[Token(Token = "0x6019BDD")]
			[Address(RVA = "0x1294D50", Offset = "0x1293950", VA = "0x181294D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019BDE")]
			[Address(RVA = "0x1294DB0", Offset = "0x12939B0", VA = "0x181294DB0", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019BDF RID: 105439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BDF")]
		[Address(RVA = "0x1294660", Offset = "0x1293260", VA = "0x181294660", Slot = "5")]
		public void Render(ArchiveAchievementModel viewModel)
		{
		}

		// Token: 0x06019BE0 RID: 105440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE0")]
		[Address(RVA = "0x1294AF0", Offset = "0x12936F0", VA = "0x181294AF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019BE1 RID: 105441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE1")]
		[Address(RVA = "0x1294C10", Offset = "0x1293810", VA = "0x181294C10")]
		private void _OnChangeType(string type)
		{
		}

		// Token: 0x06019BE2 RID: 105442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE2")]
		[Address(RVA = "0x1294CA0", Offset = "0x12938A0", VA = "0x181294CA0")]
		public SandboxV2ArchiveAchievementTypeFilterView()
		{
		}

		// Token: 0x040203FF RID: 132095
		[Token(Token = "0x40203FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020400 RID: 132096
		[Token(Token = "0x4020400")]
		[FieldOffset(Offset = "0x20")]
		private Action<ArchiveAchievementListFilterViewModel.FilterType, string> m_onChangeType;

		// Token: 0x04020401 RID: 132097
		[Token(Token = "0x4020401")]
		[FieldOffset(Offset = "0x28")]
		private List<SandboxV2ArchiveAchievementTypeFilterBtnView.Params> m_btnViewParams;

		// Token: 0x04020402 RID: 132098
		[Token(Token = "0x4020402")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2ArchiveAchievementTypeFilterView.Adapter m_adapter;

		// Token: 0x04020403 RID: 132099
		[Token(Token = "0x4020403")]
		[FieldOffset(Offset = "0x38")]
		private bool m_Inited;

		// Token: 0x04020405 RID: 132101
		[Token(Token = "0x4020405")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectionChange;

		// Token: 0x04020406 RID: 132102
		[Token(Token = "0x4020406")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectionChange;

		// Token: 0x04020407 RID: 132103
		[Token(Token = "0x4020407")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020408 RID: 132104
		[Token(Token = "0x4020408")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020409 RID: 132105
		[Token(Token = "0x4020409")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnChangeType;

		// Token: 0x0402040A RID: 132106
		[Token(Token = "0x402040A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004109 RID: 16649
		[Token(Token = "0x2004109")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06019BE3 RID: 105443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019BE3")]
			[Address(RVA = "0x128BC90", Offset = "0x128A890", VA = "0x18128BC90")]
			public Adapter(SandboxV2ArchiveAchievementTypeFilterView closure)
			{
			}

			// Token: 0x17003D63 RID: 15715
			// (get) Token: 0x06019BE4 RID: 105444 RVA: 0x0009F468 File Offset: 0x0009D668
			[Token(Token = "0x17003D63")]
			public override int count
			{
				[Token(Token = "0x6019BE4")]
				[Address(RVA = "0x128BEE0", Offset = "0x128AAE0", VA = "0x18128BEE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019BE5 RID: 105445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019BE5")]
			[Address(RVA = "0x128B7E0", Offset = "0x128A3E0", VA = "0x18128B7E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402040B RID: 132107
			[Token(Token = "0x402040B")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2ArchiveAchievementTypeFilterView m_closure;

			// Token: 0x0402040C RID: 132108
			[Token(Token = "0x402040C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402040D RID: 132109
			[Token(Token = "0x402040D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402040E RID: 132110
			[Token(Token = "0x402040E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
