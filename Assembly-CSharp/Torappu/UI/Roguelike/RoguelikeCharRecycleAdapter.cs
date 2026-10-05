using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005498 RID: 21656
	[Token(Token = "0x2005498")]
	public class RoguelikeCharRecycleAdapter : LoopScrollAdapter<RoguelikeCharRecycleAdapter.ViewHolder, RoguelikeCharCardViewModel>
	{
		// Token: 0x0601FDEA RID: 130538 RVA: 0x000B3A18 File Offset: 0x000B1C18
		[Token(Token = "0x601FDEA")]
		[Address(RVA = "0x19F0CE0", Offset = "0x19EF8E0", VA = "0x1819F0CE0")]
		private int _GetSelectInstIndex(int instId)
		{
			return 0;
		}

		// Token: 0x0601FDEB RID: 130539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FDEB")]
		[Address(RVA = "0x19F07F0", Offset = "0x19EF3F0", VA = "0x1819F07F0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601FDEC RID: 130540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDEC")]
		[Address(RVA = "0x19F08B0", Offset = "0x19EF4B0", VA = "0x1819F08B0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeCharRecycleAdapter.ViewHolder holder, RoguelikeCharCardViewModel data)
		{
		}

		// Token: 0x0601FDED RID: 130541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDED")]
		[Address(RVA = "0x19F0C70", Offset = "0x19EF870", VA = "0x1819F0C70")]
		private void Update()
		{
		}

		// Token: 0x0601FDEE RID: 130542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDEE")]
		[Address(RVA = "0x19F0DC0", Offset = "0x19EF9C0", VA = "0x1819F0DC0")]
		public RoguelikeCharRecycleAdapter()
		{
		}

		// Token: 0x0402AF22 RID: 175906
		[Token(Token = "0x402AF22")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeCommonCharHolder _holderPrefab;

		// Token: 0x0402AF23 RID: 175907
		[Token(Token = "0x402AF23")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIIntEvent _charClick;

		// Token: 0x0402AF24 RID: 175908
		[Token(Token = "0x402AF24")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIIntStringEvent _charSkillClick;

		// Token: 0x0402AF25 RID: 175909
		[Token(Token = "0x402AF25")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private uint _asyncCostPerFrame;

		// Token: 0x0402AF26 RID: 175910
		[Token(Token = "0x402AF26")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public List<int> selectInstIdList;

		// Token: 0x0402AF27 RID: 175911
		[Token(Token = "0x402AF27")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public RoguelikeCharSelectStateBean.ShowConfig showConfig;

		// Token: 0x0402AF28 RID: 175912
		[Token(Token = "0x402AF28")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public string topicId;

		// Token: 0x0402AF29 RID: 175913
		[Token(Token = "0x402AF29")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public bool isSingle;

		// Token: 0x0402AF2A RID: 175914
		[Token(Token = "0x402AF2A")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public List<IRoguelikeCharCardPlugin> plugins;

		// Token: 0x0402AF2B RID: 175915
		[Token(Token = "0x402AF2B")]
		[FieldOffset(Offset = "0xA0")]
		private AsyncGameObjectLoader m_viewLoader;

		// Token: 0x0402AF2C RID: 175916
		[Token(Token = "0x402AF2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSelectInstIndex;

		// Token: 0x0402AF2D RID: 175917
		[Token(Token = "0x402AF2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402AF2E RID: 175918
		[Token(Token = "0x402AF2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402AF2F RID: 175919
		[Token(Token = "0x402AF2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402AF30 RID: 175920
		[Token(Token = "0x402AF30")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005499 RID: 21657
		[Token(Token = "0x2005499")]
		public class ViewHolder
		{
			// Token: 0x0601FDEF RID: 130543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FDEF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402AF31 RID: 175921
			[Token(Token = "0x402AF31")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeCommonCharHolder charHolder;
		}
	}
}
