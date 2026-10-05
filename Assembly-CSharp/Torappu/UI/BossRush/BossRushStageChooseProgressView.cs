using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061AD RID: 25005
	[Token(Token = "0x20061AD")]
	public class BossRushStageChooseProgressView : DataBinder<BossRushStageChooseProperty>, IHotfixable
	{
		// Token: 0x0602415C RID: 147804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602415C")]
		[Address(RVA = "0x1EC37F0", Offset = "0x1EC23F0", VA = "0x181EC37F0", Slot = "7")]
		public override void OnValueChanged(BossRushStageChooseProperty property)
		{
		}

		// Token: 0x0602415D RID: 147805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602415D")]
		[Address(RVA = "0x1EC39C0", Offset = "0x1EC25C0", VA = "0x181EC39C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602415E RID: 147806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602415E")]
		[Address(RVA = "0x1EC3AE0", Offset = "0x1EC26E0", VA = "0x181EC3AE0")]
		public BossRushStageChooseProgressView()
		{
		}

		// Token: 0x0403225B RID: 205403
		[Token(Token = "0x403225B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _progressContent;

		// Token: 0x0403225C RID: 205404
		[Token(Token = "0x403225C")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0403225D RID: 205405
		[Token(Token = "0x403225D")]
		[FieldOffset(Offset = "0x2C")]
		private int m_cachedCompleteCount;

		// Token: 0x0403225E RID: 205406
		[Token(Token = "0x403225E")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedNormalStageCount;

		// Token: 0x0403225F RID: 205407
		[Token(Token = "0x403225F")]
		[FieldOffset(Offset = "0x38")]
		private BossRushStageChooseProgressView.Adapter m_adapter;

		// Token: 0x04032260 RID: 205408
		[Token(Token = "0x4032260")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032261 RID: 205409
		[Token(Token = "0x4032261")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032262 RID: 205410
		[Token(Token = "0x4032262")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061AE RID: 25006
		[Token(Token = "0x20061AE")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602415F RID: 147807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602415F")]
			[Address(RVA = "0x1EB4300", Offset = "0x1EB2F00", VA = "0x181EB4300")]
			public Adapter(BossRushStageChooseProgressView closure)
			{
			}

			// Token: 0x17005525 RID: 21797
			// (get) Token: 0x06024160 RID: 147808 RVA: 0x000C3180 File Offset: 0x000C1380
			[Token(Token = "0x17005525")]
			public override int count
			{
				[Token(Token = "0x6024160")]
				[Address(RVA = "0x1EB4500", Offset = "0x1EB3100", VA = "0x181EB4500", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024161 RID: 147809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024161")]
			[Address(RVA = "0x1EB4170", Offset = "0x1EB2D70", VA = "0x181EB4170", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032263 RID: 205411
			[Token(Token = "0x4032263")]
			[FieldOffset(Offset = "0x20")]
			private BossRushStageChooseProgressView m_closure;

			// Token: 0x04032264 RID: 205412
			[Token(Token = "0x4032264")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032265 RID: 205413
			[Token(Token = "0x4032265")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032266 RID: 205414
			[Token(Token = "0x4032266")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
