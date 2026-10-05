using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053FE RID: 21502
	[Token(Token = "0x20053FE")]
	public class RoguelikeRewardSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x0601FA26 RID: 129574 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA27 RID: 129575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A1A")]
		public RoguelikeRewardStyle uiStyle
		{
			[Token(Token = "0x601FA26")]
			[Address(RVA = "0x195FEC0", Offset = "0x195EAC0", VA = "0x18195FEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FA27")]
			[Address(RVA = "0x195FF20", Offset = "0x195EB20", VA = "0x18195FF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601FA28 RID: 129576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA28")]
		[Address(RVA = "0x195FAD0", Offset = "0x195E6D0", VA = "0x18195FAD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FA29 RID: 129577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA29")]
		[Address(RVA = "0x195F980", Offset = "0x195E580", VA = "0x18195F980")]
		public void OnRender(List<RoguelikeSortItemViewStruct> itemList, bool showSeparator)
		{
		}

		// Token: 0x0601FA2A RID: 129578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA2A")]
		[Address(RVA = "0x195FE60", Offset = "0x195EA60", VA = "0x18195FE60")]
		public RoguelikeRewardSelectView()
		{
		}

		// Token: 0x0402AA07 RID: 174599
		[Token(Token = "0x402AA07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402AA08 RID: 174600
		[Token(Token = "0x402AA08")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _constContent;

		// Token: 0x0402AA09 RID: 174601
		[Token(Token = "0x402AA09")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _onClick;

		// Token: 0x0402AA0A RID: 174602
		[Token(Token = "0x402AA0A")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeRewardSelectView.Adapter m_adapter;

		// Token: 0x0402AA0B RID: 174603
		[Token(Token = "0x402AA0B")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeRewardSelectView.ConstAdapter m_constAdapter;

		// Token: 0x0402AA0D RID: 174605
		[Token(Token = "0x402AA0D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402AA0E RID: 174606
		[Token(Token = "0x402AA0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiStyle;

		// Token: 0x0402AA0F RID: 174607
		[Token(Token = "0x402AA0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_uiStyle;

		// Token: 0x0402AA10 RID: 174608
		[Token(Token = "0x402AA10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AA11 RID: 174609
		[Token(Token = "0x402AA11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402AA12 RID: 174610
		[Token(Token = "0x402AA12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053FF RID: 21503
		[Token(Token = "0x20053FF")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601FA2B RID: 129579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA2B")]
			[Address(RVA = "0x194ECE0", Offset = "0x194D8E0", VA = "0x18194ECE0")]
			public Adapter(RoguelikeRewardStyle style)
			{
			}

			// Token: 0x17004A1B RID: 18971
			// (get) Token: 0x0601FA2C RID: 129580 RVA: 0x000B2710 File Offset: 0x000B0910
			[Token(Token = "0x17004A1B")]
			public override int count
			{
				[Token(Token = "0x601FA2C")]
				[Address(RVA = "0x194EDB0", Offset = "0x194D9B0", VA = "0x18194EDB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FA2D RID: 129581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FA2D")]
			[Address(RVA = "0x194EA10", Offset = "0x194D610", VA = "0x18194EA10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402AA13 RID: 174611
			[Token(Token = "0x402AA13")]
			[FieldOffset(Offset = "0x20")]
			public UIIntEvent onClick;

			// Token: 0x0402AA14 RID: 174612
			[Token(Token = "0x402AA14")]
			[FieldOffset(Offset = "0x28")]
			public List<RoguelikeSortItemViewStruct> itemList;

			// Token: 0x0402AA15 RID: 174613
			[Token(Token = "0x402AA15")]
			[FieldOffset(Offset = "0x30")]
			public GameObject itemPrefab;

			// Token: 0x0402AA16 RID: 174614
			[Token(Token = "0x402AA16")]
			[FieldOffset(Offset = "0x38")]
			private RoguelikeRewardStyle m_style;

			// Token: 0x0402AA17 RID: 174615
			[Token(Token = "0x402AA17")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402AA18 RID: 174616
			[Token(Token = "0x402AA18")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402AA19 RID: 174617
			[Token(Token = "0x402AA19")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005400 RID: 21504
		[Token(Token = "0x2005400")]
		public class ConstAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004A1C RID: 18972
			// (get) Token: 0x0601FA2E RID: 129582 RVA: 0x000B2728 File Offset: 0x000B0928
			[Token(Token = "0x17004A1C")]
			public override int count
			{
				[Token(Token = "0x601FA2E")]
				[Address(RVA = "0x194EF80", Offset = "0x194DB80", VA = "0x18194EF80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FA2F RID: 129583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FA2F")]
			[Address(RVA = "0x194EE20", Offset = "0x194DA20", VA = "0x18194EE20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601FA30 RID: 129584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA30")]
			[Address(RVA = "0x194EF20", Offset = "0x194DB20", VA = "0x18194EF20")]
			public ConstAdapter()
			{
			}

			// Token: 0x0402AA1A RID: 174618
			[Token(Token = "0x402AA1A")]
			[FieldOffset(Offset = "0x20")]
			public int constCount;

			// Token: 0x0402AA1B RID: 174619
			[Token(Token = "0x402AA1B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402AA1C RID: 174620
			[Token(Token = "0x402AA1C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402AA1D RID: 174621
			[Token(Token = "0x402AA1D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
