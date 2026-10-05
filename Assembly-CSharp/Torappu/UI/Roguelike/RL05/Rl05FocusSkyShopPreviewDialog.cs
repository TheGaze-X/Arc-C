using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055D4 RID: 21972
	[Token(Token = "0x20055D4")]
	public class Rl05FocusSkyShopPreviewDialog : UICompDialog<Rl05FocusSkyShopPreviewDialog.InputParam>
	{
		// Token: 0x06020413 RID: 132115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020413")]
		[Address(RVA = "0x1A71E00", Offset = "0x1A70A00", VA = "0x181A71E00", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06020414 RID: 132116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020414")]
		[Address(RVA = "0x1A71F30", Offset = "0x1A70B30", VA = "0x181A71F30", Slot = "18")]
		protected override void OnRender(Rl05FocusSkyShopPreviewDialog.InputParam input)
		{
		}

		// Token: 0x06020415 RID: 132117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020415")]
		[Address(RVA = "0x1A71D40", Offset = "0x1A70940", VA = "0x181A71D40")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x06020416 RID: 132118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020416")]
		[Address(RVA = "0x1A71FF0", Offset = "0x1A70BF0", VA = "0x181A71FF0")]
		public Rl05FocusSkyShopPreviewDialog()
		{
		}

		// Token: 0x06020417 RID: 132119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020417")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402BA22 RID: 178722
		[Token(Token = "0x402BA22")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402BA23 RID: 178723
		[Token(Token = "0x402BA23")]
		[FieldOffset(Offset = "0x78")]
		private Rl05FocusSkyShopPreviewDialog.SkyShopGoodAdapter m_skyShopGoodAdapter;

		// Token: 0x0402BA24 RID: 178724
		[Token(Token = "0x402BA24")]
		[FieldOffset(Offset = "0x80")]
		private Rl05FocusSkyShopPreviewDialog.InputParam m_cachedInputParam;

		// Token: 0x0402BA25 RID: 178725
		[Token(Token = "0x402BA25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402BA26 RID: 178726
		[Token(Token = "0x402BA26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402BA27 RID: 178727
		[Token(Token = "0x402BA27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0402BA28 RID: 178728
		[Token(Token = "0x402BA28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055D5 RID: 21973
		[Token(Token = "0x20055D5")]
		public class InputParam
		{
			// Token: 0x06020418 RID: 132120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020418")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InputParam()
			{
			}

			// Token: 0x0402BA29 RID: 178729
			[Token(Token = "0x402BA29")]
			[FieldOffset(Offset = "0x10")]
			public List<RoguelikeTopicItemModel> shopItems;

			// Token: 0x0402BA2A RID: 178730
			[Token(Token = "0x402BA2A")]
			[FieldOffset(Offset = "0x18")]
			public string topicId;
		}

		// Token: 0x020055D6 RID: 21974
		[Token(Token = "0x20055D6")]
		public class SkyShopGoodAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020419 RID: 132121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020419")]
			[Address(RVA = "0x1A72910", Offset = "0x1A71510", VA = "0x181A72910")]
			public SkyShopGoodAdapter(Rl05FocusSkyShopPreviewDialog closure)
			{
			}

			// Token: 0x17004B9B RID: 19355
			// (get) Token: 0x0602041A RID: 132122 RVA: 0x000B5110 File Offset: 0x000B3310
			[Token(Token = "0x17004B9B")]
			public override int count
			{
				[Token(Token = "0x602041A")]
				[Address(RVA = "0x1A72990", Offset = "0x1A71590", VA = "0x181A72990", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602041B RID: 132123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602041B")]
			[Address(RVA = "0x1A72660", Offset = "0x1A71260", VA = "0x181A72660", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402BA2B RID: 178731
			[Token(Token = "0x402BA2B")]
			[FieldOffset(Offset = "0x20")]
			private Rl05FocusSkyShopPreviewDialog m_closure;

			// Token: 0x0402BA2C RID: 178732
			[Token(Token = "0x402BA2C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BA2D RID: 178733
			[Token(Token = "0x402BA2D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402BA2E RID: 178734
			[Token(Token = "0x402BA2E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
