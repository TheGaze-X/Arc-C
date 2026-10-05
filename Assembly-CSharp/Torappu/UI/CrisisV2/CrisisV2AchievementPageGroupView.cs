using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200598B RID: 22923
	[Token(Token = "0x200598B")]
	public class CrisisV2AchievementPageGroupView : DataBinder<CrisisV2AchievementProperty>, IHotfixable
	{
		// Token: 0x060216BA RID: 136890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216BA")]
		[Address(RVA = "0x1BBBED0", Offset = "0x1BBAAD0", VA = "0x181BBBED0", Slot = "7")]
		public override void OnValueChanged(CrisisV2AchievementProperty property)
		{
		}

		// Token: 0x060216BB RID: 136891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216BB")]
		[Address(RVA = "0x1BBC0E0", Offset = "0x1BBACE0", VA = "0x181BBC0E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060216BC RID: 136892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216BC")]
		[Address(RVA = "0x1BBC200", Offset = "0x1BBAE00", VA = "0x181BBC200")]
		public CrisisV2AchievementPageGroupView()
		{
		}

		// Token: 0x0402D960 RID: 186720
		[Token(Token = "0x402D960")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402D961 RID: 186721
		[Token(Token = "0x402D961")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402D962 RID: 186722
		[Token(Token = "0x402D962")]
		[FieldOffset(Offset = "0x2C")]
		private int m_cachedTotalCount;

		// Token: 0x0402D963 RID: 186723
		[Token(Token = "0x402D963")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedSelectedIndex;

		// Token: 0x0402D964 RID: 186724
		[Token(Token = "0x402D964")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2AchievementPageGroupView.Adapter m_adapter;

		// Token: 0x0402D965 RID: 186725
		[Token(Token = "0x402D965")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402D966 RID: 186726
		[Token(Token = "0x402D966")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D967 RID: 186727
		[Token(Token = "0x402D967")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200598C RID: 22924
		[Token(Token = "0x200598C")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060216BD RID: 136893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60216BD")]
			[Address(RVA = "0x1BBB8E0", Offset = "0x1BBA4E0", VA = "0x181BBB8E0")]
			public Adapter(CrisisV2AchievementPageGroupView closure)
			{
			}

			// Token: 0x17004E9E RID: 20126
			// (get) Token: 0x060216BE RID: 136894 RVA: 0x000BA3D8 File Offset: 0x000B85D8
			[Token(Token = "0x17004E9E")]
			public override int count
			{
				[Token(Token = "0x60216BE")]
				[Address(RVA = "0x1BBB9E0", Offset = "0x1BBA5E0", VA = "0x181BBB9E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060216BF RID: 136895 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60216BF")]
			[Address(RVA = "0x1BBB6F0", Offset = "0x1BBA2F0", VA = "0x181BBB6F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402D968 RID: 186728
			[Token(Token = "0x402D968")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2AchievementPageGroupView m_closure;

			// Token: 0x0402D969 RID: 186729
			[Token(Token = "0x402D969")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402D96A RID: 186730
			[Token(Token = "0x402D96A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402D96B RID: 186731
			[Token(Token = "0x402D96B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
