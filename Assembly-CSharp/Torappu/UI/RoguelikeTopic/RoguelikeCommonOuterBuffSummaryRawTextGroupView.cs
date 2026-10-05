using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004511 RID: 17681
	[Token(Token = "0x2004511")]
	public class RoguelikeCommonOuterBuffSummaryRawTextGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF8B RID: 110475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF8B")]
		[Address(RVA = "0x1422370", Offset = "0x1420F70", VA = "0x181422370")]
		public void Render(string topicId, RoguelikeCommonOuterBuffSummaryRawTextGroupItemModel viewModel, bool hasBack)
		{
		}

		// Token: 0x0601AF8C RID: 110476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF8C")]
		[Address(RVA = "0x14226A0", Offset = "0x14212A0", VA = "0x1814226A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF8D RID: 110477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF8D")]
		[Address(RVA = "0x14227F0", Offset = "0x14213F0", VA = "0x1814227F0")]
		public RoguelikeCommonOuterBuffSummaryRawTextGroupView()
		{
		}

		// Token: 0x040229FA RID: 141818
		[Token(Token = "0x40229FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040229FB RID: 141819
		[Token(Token = "0x40229FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _back;

		// Token: 0x040229FC RID: 141820
		[Token(Token = "0x40229FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040229FD RID: 141821
		[Token(Token = "0x40229FD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _inactiveSummaryAlpha;

		// Token: 0x040229FE RID: 141822
		[Token(Token = "0x40229FE")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x040229FF RID: 141823
		[Token(Token = "0x40229FF")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022A00 RID: 141824
		[Token(Token = "0x4022A00")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeCommonOuterBuffSummaryRawTextGroupView.RawTextAdapter m_adapter;

		// Token: 0x04022A01 RID: 141825
		[Token(Token = "0x4022A01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022A02 RID: 141826
		[Token(Token = "0x4022A02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022A03 RID: 141827
		[Token(Token = "0x4022A03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004512 RID: 17682
		[Token(Token = "0x2004512")]
		private class RawTextAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0601AF8E RID: 110478 RVA: 0x000A3C20 File Offset: 0x000A1E20
			[Token(Token = "0x17004007")]
			public override int count
			{
				[Token(Token = "0x601AF8E")]
				[Address(RVA = "0x14187F0", Offset = "0x14173F0", VA = "0x1814187F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF8F RID: 110479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF8F")]
			[Address(RVA = "0x1417FA0", Offset = "0x1416BA0", VA = "0x181417FA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF90 RID: 110480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF90")]
			[Address(RVA = "0x14185F0", Offset = "0x14171F0", VA = "0x1814185F0")]
			public RawTextAdapter()
			{
			}

			// Token: 0x04022A04 RID: 141828
			[Token(Token = "0x4022A04")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikeCommonOuterBuffSummaryRawTextItemModel> datas;

			// Token: 0x04022A05 RID: 141829
			[Token(Token = "0x4022A05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022A06 RID: 141830
			[Token(Token = "0x4022A06")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022A07 RID: 141831
			[Token(Token = "0x4022A07")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
