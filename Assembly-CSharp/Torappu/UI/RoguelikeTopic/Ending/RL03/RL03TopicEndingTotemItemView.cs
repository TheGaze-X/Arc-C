using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.RL03;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending.RL03
{
	// Token: 0x02004691 RID: 18065
	[Token(Token = "0x2004691")]
	public class RL03TopicEndingTotemItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6AF RID: 112303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6AF")]
		[Address(RVA = "0x14ABF90", Offset = "0x14AAB90", VA = "0x1814ABF90")]
		public void Render(RL03TotemViewModel viewModel, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601B6B0 RID: 112304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6B0")]
		[Address(RVA = "0x14AC1E0", Offset = "0x14AADE0", VA = "0x1814AC1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B6B1 RID: 112305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6B1")]
		[Address(RVA = "0x14AC2E0", Offset = "0x14AAEE0", VA = "0x1814AC2E0")]
		public RL03TopicEndingTotemItemView()
		{
		}

		// Token: 0x04023771 RID: 145265
		[Token(Token = "0x4023771")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL03TotemItemView _totemPrefab;

		// Token: 0x04023772 RID: 145266
		[Token(Token = "0x4023772")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _totemContainer;

		// Token: 0x04023773 RID: 145267
		[Token(Token = "0x4023773")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x04023774 RID: 145268
		[Token(Token = "0x4023774")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04023775 RID: 145269
		[Token(Token = "0x4023775")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _totemScale;

		// Token: 0x04023776 RID: 145270
		[Token(Token = "0x4023776")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x04023777 RID: 145271
		[Token(Token = "0x4023777")]
		[FieldOffset(Offset = "0x40")]
		private RL03TotemItemView m_view;

		// Token: 0x04023778 RID: 145272
		[Token(Token = "0x4023778")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023779 RID: 145273
		[Token(Token = "0x4023779")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402377A RID: 145274
		[Token(Token = "0x402377A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
