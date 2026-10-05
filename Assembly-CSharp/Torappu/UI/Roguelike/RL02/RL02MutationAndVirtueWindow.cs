using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005794 RID: 22420
	[Token(Token = "0x2005794")]
	public class RL02MutationAndVirtueWindow : RoguelikeMenuWindow<RL02MutationAndVirtueViewModel>
	{
		// Token: 0x06020CC8 RID: 134344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CC8")]
		[Address(RVA = "0x1B253A0", Offset = "0x1B23FA0", VA = "0x181B253A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x06020CC9 RID: 134345 RVA: 0x000B7570 File Offset: 0x000B5770
		[Token(Token = "0x17004CE3")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020CC9")]
			[Address(RVA = "0x1B255E0", Offset = "0x1B241E0", VA = "0x181B255E0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020CCA RID: 134346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CCA")]
		[Address(RVA = "0x1B251E0", Offset = "0x1B23DE0", VA = "0x181B251E0", Slot = "10")]
		public override void Render(RL02MutationAndVirtueViewModel viewModel)
		{
		}

		// Token: 0x06020CCB RID: 134347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CCB")]
		[Address(RVA = "0x1B25570", Offset = "0x1B24170", VA = "0x181B25570")]
		public RL02MutationAndVirtueWindow()
		{
		}

		// Token: 0x0402C8F9 RID: 182521
		[Token(Token = "0x402C8F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _mutationGroup;

		// Token: 0x0402C8FA RID: 182522
		[Token(Token = "0x402C8FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _virtueGroup;

		// Token: 0x0402C8FB RID: 182523
		[Token(Token = "0x402C8FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _mutationTitle;

		// Token: 0x0402C8FC RID: 182524
		[Token(Token = "0x402C8FC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _virtueTitle;

		// Token: 0x0402C8FD RID: 182525
		[Token(Token = "0x402C8FD")]
		[FieldOffset(Offset = "0x48")]
		private RL02MutationAndVirtueViewModel m_cachedModel;

		// Token: 0x0402C8FE RID: 182526
		[Token(Token = "0x402C8FE")]
		[FieldOffset(Offset = "0x50")]
		private RL02MutationAndVirtueWindow.MutationAdapter m_mutationAdapter;

		// Token: 0x0402C8FF RID: 182527
		[Token(Token = "0x402C8FF")]
		[FieldOffset(Offset = "0x58")]
		private RL02MutationAndVirtueWindow.VirtueAdapter m_virtueAdapter;

		// Token: 0x0402C900 RID: 182528
		[Token(Token = "0x402C900")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0402C901 RID: 182529
		[Token(Token = "0x402C901")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C902 RID: 182530
		[Token(Token = "0x402C902")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402C903 RID: 182531
		[Token(Token = "0x402C903")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C904 RID: 182532
		[Token(Token = "0x402C904")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005795 RID: 22421
		[Token(Token = "0x2005795")]
		private class MutationAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020CCC RID: 134348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CCC")]
			[Address(RVA = "0x1B191F0", Offset = "0x1B17DF0", VA = "0x181B191F0")]
			public MutationAdapter(RL02MutationAndVirtueWindow closure)
			{
			}

			// Token: 0x17004CE4 RID: 19684
			// (get) Token: 0x06020CCD RID: 134349 RVA: 0x000B7588 File Offset: 0x000B5788
			[Token(Token = "0x17004CE4")]
			public override int count
			{
				[Token(Token = "0x6020CCD")]
				[Address(RVA = "0x1B19270", Offset = "0x1B17E70", VA = "0x181B19270", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020CCE RID: 134350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020CCE")]
			[Address(RVA = "0x1B19030", Offset = "0x1B17C30", VA = "0x181B19030", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C905 RID: 182533
			[Token(Token = "0x402C905")]
			[FieldOffset(Offset = "0x20")]
			private RL02MutationAndVirtueWindow m_closure;

			// Token: 0x0402C906 RID: 182534
			[Token(Token = "0x402C906")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C907 RID: 182535
			[Token(Token = "0x402C907")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C908 RID: 182536
			[Token(Token = "0x402C908")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005796 RID: 22422
		[Token(Token = "0x2005796")]
		private class VirtueAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020CCF RID: 134351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CCF")]
			[Address(RVA = "0x1B2D7F0", Offset = "0x1B2C3F0", VA = "0x181B2D7F0")]
			public VirtueAdapter(RL02MutationAndVirtueWindow closure)
			{
			}

			// Token: 0x17004CE5 RID: 19685
			// (get) Token: 0x06020CD0 RID: 134352 RVA: 0x000B75A0 File Offset: 0x000B57A0
			[Token(Token = "0x17004CE5")]
			public override int count
			{
				[Token(Token = "0x6020CD0")]
				[Address(RVA = "0x1B2D870", Offset = "0x1B2C470", VA = "0x181B2D870", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020CD1 RID: 134353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020CD1")]
			[Address(RVA = "0x1B2D5E0", Offset = "0x1B2C1E0", VA = "0x181B2D5E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C909 RID: 182537
			[Token(Token = "0x402C909")]
			[FieldOffset(Offset = "0x20")]
			private RL02MutationAndVirtueWindow m_closure;

			// Token: 0x0402C90A RID: 182538
			[Token(Token = "0x402C90A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C90B RID: 182539
			[Token(Token = "0x402C90B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C90C RID: 182540
			[Token(Token = "0x402C90C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
