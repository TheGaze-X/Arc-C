using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005491 RID: 21649
	[Token(Token = "0x2005491")]
	public class RoguelikeCharCardDecoRoot : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x0601FDBA RID: 130490 RVA: 0x000B38E0 File Offset: 0x000B1AE0
		[Token(Token = "0x17004AB4")]
		public RoguelikeCharCardDecoPanelPluginBase.DecoLayer decoLayer
		{
			[Token(Token = "0x601FDBA")]
			[Address(RVA = "0x19E79B0", Offset = "0x19E65B0", VA = "0x1819E79B0")]
			get
			{
				return RoguelikeCharCardDecoPanelPluginBase.DecoLayer.NONE;
			}
		}

		// Token: 0x0601FDBB RID: 130491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDBB")]
		[Address(RVA = "0x19E7550", Offset = "0x19E6150", VA = "0x1819E7550")]
		public void ClearDeco()
		{
		}

		// Token: 0x0601FDBC RID: 130492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDBC")]
		[Address(RVA = "0x19E7630", Offset = "0x19E6230", VA = "0x1819E7630")]
		public void InstantiateDeco(RoguelikeCharCardDecoPanelPluginBase decoAsset, RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDBD RID: 130493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDBD")]
		[Address(RVA = "0x19E7770", Offset = "0x19E6370", VA = "0x1819E7770")]
		public void RenderAllDeco(RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput)
		{
		}

		// Token: 0x0601FDBE RID: 130494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDBE")]
		[Address(RVA = "0x19E78D0", Offset = "0x19E64D0", VA = "0x1819E78D0")]
		public RoguelikeCharCardDecoRoot()
		{
		}

		// Token: 0x0402AEAA RID: 175786
		[Token(Token = "0x402AEAA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeCharCardDecoPanelPluginBase.DecoLayer _decoLayer;

		// Token: 0x0402AEAB RID: 175787
		[Token(Token = "0x402AEAB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _decoRoot;

		// Token: 0x0402AEAC RID: 175788
		[Token(Token = "0x402AEAC")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeCharCardDecoPanelPluginBase> m_cachedDecos;

		// Token: 0x0402AEAD RID: 175789
		[Token(Token = "0x402AEAD")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public string cachedTopicId;

		// Token: 0x0402AEAE RID: 175790
		[Token(Token = "0x402AEAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decoLayer;

		// Token: 0x0402AEAF RID: 175791
		[Token(Token = "0x402AEAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearDeco;

		// Token: 0x0402AEB0 RID: 175792
		[Token(Token = "0x402AEB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InstantiateDeco;

		// Token: 0x0402AEB1 RID: 175793
		[Token(Token = "0x402AEB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderAllDeco;

		// Token: 0x0402AEB2 RID: 175794
		[Token(Token = "0x402AEB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
