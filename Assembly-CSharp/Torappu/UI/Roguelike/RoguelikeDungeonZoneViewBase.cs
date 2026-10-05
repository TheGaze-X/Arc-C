using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005267 RID: 21095
	[Token(Token = "0x2005267")]
	public abstract class RoguelikeDungeonZoneViewBase : DataBinder<RoguelikeDungeonZoneViewProperty>
	{
		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x0601F1F9 RID: 127481 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F1FA RID: 127482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048E7")]
		public Action<RoguelikeDungeonNode, Bounds> onNodeClicked
		{
			[Token(Token = "0x601F1F9")]
			[Address(RVA = "0x18D5270", Offset = "0x18D3E70", VA = "0x1818D5270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F1FA")]
			[Address(RVA = "0x18D5350", Offset = "0x18D3F50", VA = "0x1818D5350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x0601F1FB RID: 127483 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F1FC RID: 127484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048E8")]
		public Action<RoguelikeOnDungeonZoneCreatedArgs> onZoneCreated
		{
			[Token(Token = "0x601F1FB")]
			[Address(RVA = "0x18D52E0", Offset = "0x18D3EE0", VA = "0x1818D52E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F1FC")]
			[Address(RVA = "0x18D53E0", Offset = "0x18D3FE0", VA = "0x1818D53E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F1FD RID: 127485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1FD")]
		[Address(RVA = "0x18D41F0", Offset = "0x18D2DF0", VA = "0x1818D41F0")]
		public void Init(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F1FE RID: 127486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1FE")]
		[Address(RVA = "0x18D3F70", Offset = "0x18D2B70", VA = "0x1818D3F70")]
		public void DestroyView(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F1FF RID: 127487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1FF")]
		[Address(RVA = "0x18D48D0", Offset = "0x18D34D0", VA = "0x1818D48D0")]
		public void SetShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601F200 RID: 127488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F200")]
		[Address(RVA = "0x18D4490", Offset = "0x18D3090", VA = "0x1818D4490", Slot = "7")]
		public override void OnValueChanged(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x0601F201 RID: 127489
		[Token(Token = "0x601F201")]
		protected abstract void OnInit(RoguelikeDungeonController controller);

		// Token: 0x0601F202 RID: 127490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F202")]
		[Address(RVA = "0x18D45F0", Offset = "0x18D31F0", VA = "0x1818D45F0", Slot = "9")]
		protected virtual void OnViewDestroy(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F203 RID: 127491
		[Token(Token = "0x601F203")]
		protected abstract void OnSetShow(bool isShow, bool fastMode);

		// Token: 0x0601F204 RID: 127492
		[Token(Token = "0x601F204")]
		protected abstract void CreateZone();

		// Token: 0x0601F205 RID: 127493
		[Token(Token = "0x601F205")]
		protected abstract void RenderZone();

		// Token: 0x0601F206 RID: 127494
		[Token(Token = "0x601F206")]
		public abstract IRoguelikeDungeonNodeView GetViewByNode(RoguelikeDungeonNode node);

		// Token: 0x0601F207 RID: 127495
		[Token(Token = "0x601F207")]
		public abstract void CleanNodeEffect();

		// Token: 0x0601F208 RID: 127496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F208")]
		[Address(RVA = "0x18D4670", Offset = "0x18D3270", VA = "0x1818D4670", Slot = "15")]
		protected virtual void RenderBackground()
		{
		}

		// Token: 0x0601F209 RID: 127497 RVA: 0x000B0FD0 File Offset: 0x000AF1D0
		[Token(Token = "0x601F209")]
		[Address(RVA = "0x18D3DF0", Offset = "0x18D29F0", VA = "0x1818D3DF0", Slot = "16")]
		protected virtual bool CheckIfNeedRenderZone()
		{
			return default(bool);
		}

		// Token: 0x0601F20A RID: 127498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F20A")]
		[Address(RVA = "0x18D4E00", Offset = "0x18D3A00", VA = "0x1818D4E00")]
		private void _OnBeforeStateTransition(object arg)
		{
		}

		// Token: 0x0601F20B RID: 127499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F20B")]
		[Address(RVA = "0x18D4C20", Offset = "0x18D3820", VA = "0x1818D4C20")]
		private void _EventOnStateResume(object arg)
		{
		}

		// Token: 0x0601F20C RID: 127500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F20C")]
		[Address(RVA = "0x18D49D0", Offset = "0x18D35D0", VA = "0x1818D49D0")]
		private void _EventOnStatePause(object arg)
		{
		}

		// Token: 0x0601F20D RID: 127501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F20D")]
		[Address(RVA = "0x18D51A0", Offset = "0x18D3DA0", VA = "0x1818D51A0")]
		protected RoguelikeDungeonZoneViewBase()
		{
		}

		// Token: 0x04029C29 RID: 171049
		[Token(Token = "0x4029C29")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] ENABLE_STATES;

		// Token: 0x04029C2A RID: 171050
		[Token(Token = "0x4029C2A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly PlayerRoguelikePlayerEventType[] NO_RENDER_PENDING_EVENTS;

		// Token: 0x04029C2B RID: 171051
		[Token(Token = "0x4029C2B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image _imageBackground;

		// Token: 0x04029C2C RID: 171052
		[Token(Token = "0x4029C2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected CanvasGroup _canvasBkgBlur;

		// Token: 0x04029C2D RID: 171053
		[Token(Token = "0x4029C2D")]
		[FieldOffset(Offset = "0x30")]
		protected RoguelikeDungeonZoneViewBase.StateTransitionParam m_currTransParam;

		// Token: 0x04029C2E RID: 171054
		[Token(Token = "0x4029C2E")]
		[FieldOffset(Offset = "0x38")]
		private StateEngine m_bindStateEngine;

		// Token: 0x04029C2F RID: 171055
		[Token(Token = "0x4029C2F")]
		[FieldOffset(Offset = "0x40")]
		protected RoguelikeDungeonZoneViewModel m_cacheModel;

		// Token: 0x04029C30 RID: 171056
		[Token(Token = "0x4029C30")]
		[FieldOffset(Offset = "0x48")]
		protected bool m_isShow;

		// Token: 0x04029C31 RID: 171057
		[Token(Token = "0x4029C31")]
		[FieldOffset(Offset = "0x49")]
		private bool m_hasPendingRenderEvent;

		// Token: 0x04029C34 RID: 171060
		[Token(Token = "0x4029C34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onNodeClicked;

		// Token: 0x04029C35 RID: 171061
		[Token(Token = "0x4029C35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onNodeClicked;

		// Token: 0x04029C36 RID: 171062
		[Token(Token = "0x4029C36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onZoneCreated;

		// Token: 0x04029C37 RID: 171063
		[Token(Token = "0x4029C37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onZoneCreated;

		// Token: 0x04029C38 RID: 171064
		[Token(Token = "0x4029C38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029C39 RID: 171065
		[Token(Token = "0x4029C39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DestroyView;

		// Token: 0x04029C3A RID: 171066
		[Token(Token = "0x4029C3A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x04029C3B RID: 171067
		[Token(Token = "0x4029C3B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029C3C RID: 171068
		[Token(Token = "0x4029C3C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnViewDestroy;

		// Token: 0x04029C3D RID: 171069
		[Token(Token = "0x4029C3D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RenderBackground;

		// Token: 0x04029C3E RID: 171070
		[Token(Token = "0x4029C3E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRenderZone;

		// Token: 0x04029C3F RID: 171071
		[Token(Token = "0x4029C3F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBeforeStateTransition;

		// Token: 0x04029C40 RID: 171072
		[Token(Token = "0x4029C40")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnStateResume;

		// Token: 0x04029C41 RID: 171073
		[Token(Token = "0x4029C41")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnStatePause;

		// Token: 0x04029C42 RID: 171074
		[Token(Token = "0x4029C42")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005268 RID: 21096
		[Token(Token = "0x2005268")]
		public class StateTransitionParam
		{
			// Token: 0x0601F20F RID: 127503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F20F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateTransitionParam()
			{
			}

			// Token: 0x04029C43 RID: 171075
			[Token(Token = "0x4029C43")]
			[FieldOffset(Offset = "0x10")]
			public bool transitionIn;

			// Token: 0x04029C44 RID: 171076
			[Token(Token = "0x4029C44")]
			[FieldOffset(Offset = "0x18")]
			public Type transitionDestType;
		}
	}
}
