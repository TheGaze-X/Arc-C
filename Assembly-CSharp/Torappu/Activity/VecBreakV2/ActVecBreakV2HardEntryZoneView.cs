using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E39 RID: 28217
	[Token(Token = "0x2006E39")]
	public class ActVecBreakV2HardEntryZoneView : ActVecBreakV2EntryZoneView
	{
		// Token: 0x06028294 RID: 164500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028294")]
		[Address(RVA = "0x2375390", Offset = "0x2373F90", VA = "0x182375390", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06028295 RID: 164501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028295")]
		[Address(RVA = "0x2375300", Offset = "0x2373F00", VA = "0x182375300")]
		public void EventOnBtnHardZoneClick()
		{
		}

		// Token: 0x06028296 RID: 164502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028296")]
		[Address(RVA = "0x2375540", Offset = "0x2374140", VA = "0x182375540")]
		public ActVecBreakV2HardEntryZoneView()
		{
		}

		// Token: 0x06028297 RID: 164503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028297")]
		[Address(RVA = "0x2375530", Offset = "0x2374130", VA = "0x182375530")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0403908A RID: 233610
		[Token(Token = "0x403908A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _stageList;

		// Token: 0x0403908B RID: 233611
		[Token(Token = "0x403908B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _newTrackPointGO;

		// Token: 0x0403908C RID: 233612
		[Token(Token = "0x403908C")]
		[FieldOffset(Offset = "0x68")]
		private ActVecBreakV2HardEntryZoneView.StageListAdapter m_stageListAdapter;

		// Token: 0x0403908D RID: 233613
		[Token(Token = "0x403908D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403908E RID: 233614
		[Token(Token = "0x403908E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnHardZoneClick;

		// Token: 0x0403908F RID: 233615
		[Token(Token = "0x403908F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E3A RID: 28218
		[Token(Token = "0x2006E3A")]
		private class StageListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028298 RID: 164504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028298")]
			[Address(RVA = "0x2388290", Offset = "0x2386E90", VA = "0x182388290")]
			public StageListAdapter(ActVecBreakV2HardEntryZoneView closure)
			{
			}

			// Token: 0x17005EEE RID: 24302
			// (get) Token: 0x06028299 RID: 164505 RVA: 0x000D0CB0 File Offset: 0x000CEEB0
			[Token(Token = "0x17005EEE")]
			public override int count
			{
				[Token(Token = "0x6028299")]
				[Address(RVA = "0x2388310", Offset = "0x2386F10", VA = "0x182388310", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602829A RID: 164506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602829A")]
			[Address(RVA = "0x23880D0", Offset = "0x2386CD0", VA = "0x1823880D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039090 RID: 233616
			[Token(Token = "0x4039090")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2HardEntryZoneView m_closure;

			// Token: 0x04039091 RID: 233617
			[Token(Token = "0x4039091")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039092 RID: 233618
			[Token(Token = "0x4039092")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039093 RID: 233619
			[Token(Token = "0x4039093")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
