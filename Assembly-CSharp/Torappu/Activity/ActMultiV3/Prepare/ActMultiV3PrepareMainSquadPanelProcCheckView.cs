using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007070 RID: 28784
	[Token(Token = "0x2007070")]
	public class ActMultiV3PrepareMainSquadPanelProcCheckView : ActMultiV3PrepareMainSquadPanelProcViewBase
	{
		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x06028E18 RID: 167448 RVA: 0x000D3770 File Offset: 0x000D1970
		[Token(Token = "0x170060AB")]
		public override ActMultiV3PrepareMainSquadProc procType
		{
			[Token(Token = "0x6028E18")]
			[Address(RVA = "0x2459530", Offset = "0x2458130", VA = "0x182459530", Slot = "9")]
			get
			{
				return ActMultiV3PrepareMainSquadProc.NONE;
			}
		}

		// Token: 0x06028E19 RID: 167449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E19")]
		[Address(RVA = "0x24590D0", Offset = "0x2457CD0", VA = "0x1824590D0", Slot = "10")]
		protected override void OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel model)
		{
		}

		// Token: 0x06028E1A RID: 167450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E1A")]
		[Address(RVA = "0x24593C0", Offset = "0x2457FC0", VA = "0x1824593C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028E1B RID: 167451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E1B")]
		[Address(RVA = "0x2459000", Offset = "0x2457C00", VA = "0x182459000")]
		public void EventOnReady()
		{
		}

		// Token: 0x06028E1C RID: 167452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E1C")]
		[Address(RVA = "0x2458F30", Offset = "0x2457B30", VA = "0x182458F30")]
		public void EventOnCancel()
		{
		}

		// Token: 0x06028E1D RID: 167453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E1D")]
		[Address(RVA = "0x24594D0", Offset = "0x24580D0", VA = "0x1824594D0")]
		public ActMultiV3PrepareMainSquadPanelProcCheckView()
		{
		}

		// Token: 0x06028E1E RID: 167454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E1E")]
		[Address(RVA = "0x2459360", Offset = "0x2457F60", VA = "0x182459360")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel P0)
		{
		}

		// Token: 0x0403A4F4 RID: 238836
		[Token(Token = "0x403A4F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PrefabMark _invertTips;

		// Token: 0x0403A4F5 RID: 238837
		[Token(Token = "0x403A4F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _waitingTips;

		// Token: 0x0403A4F6 RID: 238838
		[Token(Token = "0x403A4F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _partnerSquad;

		// Token: 0x0403A4F7 RID: 238839
		[Token(Token = "0x403A4F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _mySquad;

		// Token: 0x0403A4F8 RID: 238840
		[Token(Token = "0x403A4F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _btnPrepare;

		// Token: 0x0403A4F9 RID: 238841
		[Token(Token = "0x403A4F9")]
		[FieldOffset(Offset = "0x68")]
		private ActMultiV3PrepareMainSquadPanelProcCheckView.SquadAdapter m_mySquadAdapter;

		// Token: 0x0403A4FA RID: 238842
		[Token(Token = "0x403A4FA")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3PrepareMainSquadPanelProcCheckView.SquadAdapter m_partnerSquadAdapter;

		// Token: 0x0403A4FB RID: 238843
		[Token(Token = "0x403A4FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_procType;

		// Token: 0x0403A4FC RID: 238844
		[Token(Token = "0x403A4FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A4FD RID: 238845
		[Token(Token = "0x403A4FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A4FE RID: 238846
		[Token(Token = "0x403A4FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnReady;

		// Token: 0x0403A4FF RID: 238847
		[Token(Token = "0x403A4FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCancel;

		// Token: 0x0403A500 RID: 238848
		[Token(Token = "0x403A500")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007071 RID: 28785
		[Token(Token = "0x2007071")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170060AC RID: 24748
			// (get) Token: 0x06028E1F RID: 167455 RVA: 0x000D3788 File Offset: 0x000D1988
			[Token(Token = "0x170060AC")]
			public override int count
			{
				[Token(Token = "0x6028E1F")]
				[Address(RVA = "0x2462510", Offset = "0x2461110", VA = "0x182462510", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028E20 RID: 167456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028E20")]
			[Address(RVA = "0x24622E0", Offset = "0x2460EE0", VA = "0x1824622E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028E21 RID: 167457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028E21")]
			[Address(RVA = "0x2462450", Offset = "0x2461050", VA = "0x182462450")]
			public SquadAdapter()
			{
			}

			// Token: 0x0403A501 RID: 238849
			[Token(Token = "0x403A501")]
			[FieldOffset(Offset = "0x20")]
			public IList<ActMultiV3PrepareMainCharCardModel> squad;

			// Token: 0x0403A502 RID: 238850
			[Token(Token = "0x403A502")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A503 RID: 238851
			[Token(Token = "0x403A503")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403A504 RID: 238852
			[Token(Token = "0x403A504")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
