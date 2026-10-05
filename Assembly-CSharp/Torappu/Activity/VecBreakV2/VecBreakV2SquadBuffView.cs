using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E8D RID: 28301
	[Token(Token = "0x2006E8D")]
	public class VecBreakV2SquadBuffView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x06028487 RID: 164999 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028488 RID: 165000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F2B")]
		public Action onDetailClick
		{
			[Token(Token = "0x6028487")]
			[Address(RVA = "0x23A7F80", Offset = "0x23A6B80", VA = "0x1823A7F80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028488")]
			[Address(RVA = "0x23A7FE0", Offset = "0x23A6BE0", VA = "0x1823A7FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028489 RID: 165001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028489")]
		[Address(RVA = "0x23A7AB0", Offset = "0x23A66B0", VA = "0x1823A7AB0")]
		public void Render(VecBreakV2SquadBuffViewModel viewModel)
		{
		}

		// Token: 0x0602848A RID: 165002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602848A")]
		[Address(RVA = "0x23A7DD0", Offset = "0x23A69D0", VA = "0x1823A7DD0")]
		private void _TriggerAVGIfNeed()
		{
		}

		// Token: 0x0602848B RID: 165003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602848B")]
		[Address(RVA = "0x23A79A0", Offset = "0x23A65A0", VA = "0x1823A79A0")]
		public void EventOnOpenDetail()
		{
		}

		// Token: 0x0602848C RID: 165004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602848C")]
		[Address(RVA = "0x23A7F20", Offset = "0x23A6B20", VA = "0x1823A7F20")]
		public VecBreakV2SquadBuffView()
		{
		}

		// Token: 0x040393FB RID: 234491
		[Token(Token = "0x40393FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _buffPanelGO;

		// Token: 0x040393FC RID: 234492
		[Token(Token = "0x40393FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x040393FD RID: 234493
		[Token(Token = "0x40393FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _btnEditBuff;

		// Token: 0x040393FE RID: 234494
		[Token(Token = "0x40393FE")]
		[FieldOffset(Offset = "0x30")]
		private VecBreakV2SquadBuffViewModel m_viewModel;

		// Token: 0x040393FF RID: 234495
		[Token(Token = "0x40393FF")]
		[FieldOffset(Offset = "0x38")]
		private VecBreakV2SquadBuffView.BuffListAdapter m_buffListAdapter;

		// Token: 0x04039401 RID: 234497
		[Token(Token = "0x4039401")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onDetailClick;

		// Token: 0x04039402 RID: 234498
		[Token(Token = "0x4039402")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onDetailClick;

		// Token: 0x04039403 RID: 234499
		[Token(Token = "0x4039403")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039404 RID: 234500
		[Token(Token = "0x4039404")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerAVGIfNeed;

		// Token: 0x04039405 RID: 234501
		[Token(Token = "0x4039405")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnOpenDetail;

		// Token: 0x04039406 RID: 234502
		[Token(Token = "0x4039406")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E8E RID: 28302
		[Token(Token = "0x2006E8E")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602848D RID: 165005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602848D")]
			[Address(RVA = "0x2396400", Offset = "0x2395000", VA = "0x182396400")]
			public BuffListAdapter(VecBreakV2SquadBuffView closure)
			{
			}

			// Token: 0x17005F2C RID: 24364
			// (get) Token: 0x0602848E RID: 165006 RVA: 0x000D1400 File Offset: 0x000CF600
			[Token(Token = "0x17005F2C")]
			public override int count
			{
				[Token(Token = "0x602848E")]
				[Address(RVA = "0x2396480", Offset = "0x2395080", VA = "0x182396480", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602848F RID: 165007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602848F")]
			[Address(RVA = "0x23960C0", Offset = "0x2394CC0", VA = "0x1823960C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039407 RID: 234503
			[Token(Token = "0x4039407")]
			[FieldOffset(Offset = "0x20")]
			private VecBreakV2SquadBuffView m_closure;

			// Token: 0x04039408 RID: 234504
			[Token(Token = "0x4039408")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039409 RID: 234505
			[Token(Token = "0x4039409")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403940A RID: 234506
			[Token(Token = "0x403940A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
