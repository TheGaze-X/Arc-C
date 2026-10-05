using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005502 RID: 21762
	[Token(Token = "0x2005502")]
	public class RoguelikeShopGoodsLoopAdapter : LoopScrollAdapter<RoguelikeShopGoodsLoopAdapter.ViewHolder, RoguelikeGoodsViewModel>
	{
		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x06020025 RID: 131109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020026 RID: 131110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B14")]
		public RoguelikeShopLineupControllerBindings controllerBindings
		{
			[Token(Token = "0x6020025")]
			[Address(RVA = "0x1A22D80", Offset = "0x1A21980", VA = "0x181A22D80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020026")]
			[Address(RVA = "0x1A22DE0", Offset = "0x1A219E0", VA = "0x181A22DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020027 RID: 131111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020027")]
		[Address(RVA = "0x1A22050", Offset = "0x1A20C50", VA = "0x181A22050", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06020028 RID: 131112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020028")]
		[Address(RVA = "0x1A22680", Offset = "0x1A21280", VA = "0x181A22680", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeShopGoodsLoopAdapter.ViewHolder holder, RoguelikeGoodsViewModel data)
		{
		}

		// Token: 0x06020029 RID: 131113 RVA: 0x000B4360 File Offset: 0x000B2560
		[Token(Token = "0x6020029")]
		[Address(RVA = "0x1A22130", Offset = "0x1A20D30", VA = "0x181A22130")]
		public float PlaySwitch(bool isShow, bool fastMode)
		{
			return 0f;
		}

		// Token: 0x0602002A RID: 131114 RVA: 0x000B4378 File Offset: 0x000B2578
		[Token(Token = "0x602002A")]
		[Address(RVA = "0x1A22B40", Offset = "0x1A21740", VA = "0x181A22B40")]
		private float _GetProgress()
		{
			return 0f;
		}

		// Token: 0x0602002B RID: 131115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602002B")]
		[Address(RVA = "0x1A22CA0", Offset = "0x1A218A0", VA = "0x181A22CA0")]
		private void _SetProgress(float progress)
		{
		}

		// Token: 0x0602002C RID: 131116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602002C")]
		[Address(RVA = "0x1A22BA0", Offset = "0x1A217A0", VA = "0x181A22BA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602002D RID: 131117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602002D")]
		[Address(RVA = "0x1A22D10", Offset = "0x1A21910", VA = "0x181A22D10")]
		public RoguelikeShopGoodsLoopAdapter()
		{
		}

		// Token: 0x0402B359 RID: 176985
		[Token(Token = "0x402B359")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeGoodsObjView _goodsPrefab;

		// Token: 0x0402B35A RID: 176986
		[Token(Token = "0x402B35A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _maxTweenTime;

		// Token: 0x0402B35B RID: 176987
		[Token(Token = "0x402B35B")]
		[FieldOffset(Offset = "0x64")]
		private bool m_hasInited;

		// Token: 0x0402B35C RID: 176988
		[Token(Token = "0x402B35C")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeShopGoodsLoopAdapter.SwitchPlayHandler m_switchPlayHandler;

		// Token: 0x0402B35D RID: 176989
		[Token(Token = "0x402B35D")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isShow;

		// Token: 0x0402B35E RID: 176990
		[Token(Token = "0x402B35E")]
		[FieldOffset(Offset = "0x71")]
		private bool m_fastMode;

		// Token: 0x0402B35F RID: 176991
		[Token(Token = "0x402B35F")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_playTween;

		// Token: 0x0402B360 RID: 176992
		[Token(Token = "0x402B360")]
		[FieldOffset(Offset = "0x80")]
		private float m_progress;

		// Token: 0x0402B361 RID: 176993
		[Token(Token = "0x402B361")]
		[FieldOffset(Offset = "0x84")]
		private float m_offset;

		// Token: 0x0402B362 RID: 176994
		[Token(Token = "0x402B362")]
		[FieldOffset(Offset = "0x88")]
		private float m_range;

		// Token: 0x0402B363 RID: 176995
		[Token(Token = "0x402B363")]
		[FieldOffset(Offset = "0x8C")]
		private float m_fixItemDuration;

		// Token: 0x0402B365 RID: 176997
		[Token(Token = "0x402B365")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controllerBindings;

		// Token: 0x0402B366 RID: 176998
		[Token(Token = "0x402B366")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controllerBindings;

		// Token: 0x0402B367 RID: 176999
		[Token(Token = "0x402B367")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402B368 RID: 177000
		[Token(Token = "0x402B368")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402B369 RID: 177001
		[Token(Token = "0x402B369")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlaySwitch;

		// Token: 0x0402B36A RID: 177002
		[Token(Token = "0x402B36A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetProgress;

		// Token: 0x0402B36B RID: 177003
		[Token(Token = "0x402B36B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetProgress;

		// Token: 0x0402B36C RID: 177004
		[Token(Token = "0x402B36C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B36D RID: 177005
		[Token(Token = "0x402B36D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005503 RID: 21763
		[Token(Token = "0x2005503")]
		public class ViewHolder
		{
			// Token: 0x0602002E RID: 131118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602002E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402B36E RID: 177006
			[Token(Token = "0x402B36E")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeGoodsObjView view;
		}

		// Token: 0x02005504 RID: 21764
		[Token(Token = "0x2005504")]
		public class SwitchPlayHandler : IHotfixable
		{
			// Token: 0x17004B15 RID: 19221
			// (get) Token: 0x0602002F RID: 131119 RVA: 0x000B4390 File Offset: 0x000B2590
			[Token(Token = "0x17004B15")]
			public bool isShow
			{
				[Token(Token = "0x602002F")]
				[Address(RVA = "0x1A2F470", Offset = "0x1A2E070", VA = "0x181A2F470")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B16 RID: 19222
			// (get) Token: 0x06020030 RID: 131120 RVA: 0x000B43A8 File Offset: 0x000B25A8
			[Token(Token = "0x17004B16")]
			public bool fastMode
			{
				[Token(Token = "0x6020030")]
				[Address(RVA = "0x1A2F300", Offset = "0x1A2DF00", VA = "0x181A2F300")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B17 RID: 19223
			// (get) Token: 0x06020031 RID: 131121 RVA: 0x000B43C0 File Offset: 0x000B25C0
			[Token(Token = "0x17004B17")]
			public float fixedDuration
			{
				[Token(Token = "0x6020031")]
				[Address(RVA = "0x1A2F3B0", Offset = "0x1A2DFB0", VA = "0x181A2F3B0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06020032 RID: 131122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020032")]
			[Address(RVA = "0x1A2F280", Offset = "0x1A2DE80", VA = "0x181A2F280")]
			public SwitchPlayHandler(RoguelikeShopGoodsLoopAdapter closure)
			{
			}

			// Token: 0x06020033 RID: 131123 RVA: 0x000B43D8 File Offset: 0x000B25D8
			[Token(Token = "0x6020033")]
			[Address(RVA = "0x1A2F120", Offset = "0x1A2DD20", VA = "0x181A2F120")]
			public float GetProgressOfIndex(int index)
			{
				return 0f;
			}

			// Token: 0x0402B36F RID: 177007
			[Token(Token = "0x402B36F")]
			[FieldOffset(Offset = "0x10")]
			private readonly RoguelikeShopGoodsLoopAdapter m_closure;

			// Token: 0x0402B370 RID: 177008
			[Token(Token = "0x402B370")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0402B371 RID: 177009
			[Token(Token = "0x402B371")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_fastMode;

			// Token: 0x0402B372 RID: 177010
			[Token(Token = "0x402B372")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_fixedDuration;

			// Token: 0x0402B373 RID: 177011
			[Token(Token = "0x402B373")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B374 RID: 177012
			[Token(Token = "0x402B374")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetProgressOfIndex;
		}
	}
}
