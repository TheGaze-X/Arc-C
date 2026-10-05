using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200471F RID: 18207
	[Token(Token = "0x200471F")]
	public class RecruitSpecialGachaUpCharListGroupView : DataBinder<RecruitSpecialGachaUpCharListProperty>, IHotfixable
	{
		// Token: 0x0601B989 RID: 113033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B989")]
		[Address(RVA = "0x14E9D60", Offset = "0x14E8960", VA = "0x1814E9D60", Slot = "7")]
		public override void OnValueChanged(RecruitSpecialGachaUpCharListProperty property)
		{
		}

		// Token: 0x0601B98A RID: 113034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B98A")]
		[Address(RVA = "0x14E9F80", Offset = "0x14E8B80", VA = "0x1814E9F80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B98B RID: 113035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B98B")]
		[Address(RVA = "0x14EA0A0", Offset = "0x14E8CA0", VA = "0x1814EA0A0")]
		public RecruitSpecialGachaUpCharListGroupView()
		{
		}

		// Token: 0x04023C18 RID: 146456
		[Token(Token = "0x4023C18")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RarityRank _rarityRank;

		// Token: 0x04023C19 RID: 146457
		[Token(Token = "0x4023C19")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04023C1A RID: 146458
		[Token(Token = "0x4023C1A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04023C1B RID: 146459
		[Token(Token = "0x4023C1B")]
		[FieldOffset(Offset = "0x38")]
		private List<RecruitSpecialGachaUpCharCardViewModel> m_cachedCharList;

		// Token: 0x04023C1C RID: 146460
		[Token(Token = "0x4023C1C")]
		[FieldOffset(Offset = "0x40")]
		private RecruitSpecialGachaUpCharListGroupView.Adapter m_adapter;

		// Token: 0x04023C1D RID: 146461
		[Token(Token = "0x4023C1D")]
		[FieldOffset(Offset = "0x48")]
		private Color m_colorTheme;

		// Token: 0x04023C1E RID: 146462
		[Token(Token = "0x4023C1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023C1F RID: 146463
		[Token(Token = "0x4023C1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023C20 RID: 146464
		[Token(Token = "0x4023C20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004720 RID: 18208
		[Token(Token = "0x2004720")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601B98C RID: 113036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B98C")]
			[Address(RVA = "0x14D92D0", Offset = "0x14D7ED0", VA = "0x1814D92D0")]
			public Adapter(RecruitSpecialGachaUpCharListGroupView closure)
			{
			}

			// Token: 0x170041AC RID: 16812
			// (get) Token: 0x0601B98D RID: 113037 RVA: 0x000A5A50 File Offset: 0x000A3C50
			[Token(Token = "0x170041AC")]
			public override int count
			{
				[Token(Token = "0x601B98D")]
				[Address(RVA = "0x14D9350", Offset = "0x14D7F50", VA = "0x1814D9350", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B98E RID: 113038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B98E")]
			[Address(RVA = "0x14D9110", Offset = "0x14D7D10", VA = "0x1814D9110", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023C21 RID: 146465
			[Token(Token = "0x4023C21")]
			[FieldOffset(Offset = "0x20")]
			private RecruitSpecialGachaUpCharListGroupView m_closure;

			// Token: 0x04023C22 RID: 146466
			[Token(Token = "0x4023C22")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023C23 RID: 146467
			[Token(Token = "0x4023C23")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023C24 RID: 146468
			[Token(Token = "0x4023C24")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
