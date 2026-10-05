using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005265 RID: 21093
	[Token(Token = "0x2005265")]
	public class RoguelikeDungeonZoneView : RoguelikeDungeonZoneViewBase
	{
		// Token: 0x0601F1E9 RID: 127465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1E9")]
		[Address(RVA = "0x18D5D10", Offset = "0x18D4910", VA = "0x1818D5D10", Slot = "8")]
		protected override void OnInit(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F1EA RID: 127466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1EA")]
		[Address(RVA = "0x18D5E60", Offset = "0x18D4A60", VA = "0x1818D5E60", Slot = "10")]
		protected override void OnSetShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601F1EB RID: 127467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1EB")]
		[Address(RVA = "0x18D5C20", Offset = "0x18D4820", VA = "0x1818D5C20", Slot = "13")]
		public override IRoguelikeDungeonNodeView GetViewByNode(RoguelikeDungeonNode node)
		{
			return null;
		}

		// Token: 0x0601F1EC RID: 127468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1EC")]
		[Address(RVA = "0x18D55D0", Offset = "0x18D41D0", VA = "0x1818D55D0", Slot = "11")]
		protected override void CreateZone()
		{
		}

		// Token: 0x0601F1ED RID: 127469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1ED")]
		[Address(RVA = "0x18D60A0", Offset = "0x18D4CA0", VA = "0x1818D60A0", Slot = "12")]
		protected override void RenderZone()
		{
		}

		// Token: 0x0601F1EE RID: 127470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1EE")]
		[Address(RVA = "0x18D5470", Offset = "0x18D4070", VA = "0x1818D5470", Slot = "14")]
		public override void CleanNodeEffect()
		{
		}

		// Token: 0x0601F1EF RID: 127471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1EF")]
		[Address(RVA = "0x18D67C0", Offset = "0x18D53C0", VA = "0x1818D67C0")]
		private RoguelikeDungeonNodeView _LoadDungeonNodePrefabWithTopicId(string topicId)
		{
			return null;
		}

		// Token: 0x0601F1F0 RID: 127472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1F0")]
		[Address(RVA = "0x18D6910", Offset = "0x18D5510", VA = "0x1818D6910")]
		private void _PlayCursorAnimation()
		{
		}

		// Token: 0x0601F1F1 RID: 127473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1F1")]
		[Address(RVA = "0x18D6E30", Offset = "0x18D5A30", VA = "0x1818D6E30")]
		public RoguelikeDungeonZoneView()
		{
		}

		// Token: 0x04029C0F RID: 171023
		[Token(Token = "0x4029C0F")]
		private const float TWEEN_DURATION = 0.1f;

		// Token: 0x04029C10 RID: 171024
		[Token(Token = "0x4029C10")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _layerPrefab;

		// Token: 0x04029C11 RID: 171025
		[Token(Token = "0x4029C11")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _layerContainer;

		// Token: 0x04029C12 RID: 171026
		[Token(Token = "0x4029C12")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Cursor")]
		private RectTransform _panelCursor;

		// Token: 0x04029C13 RID: 171027
		[Token(Token = "0x4029C13")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Cursor")]
		private float _cursorTweenDuration;

		// Token: 0x04029C14 RID: 171028
		[Token(Token = "0x4029C14")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Group("Cursor")]
		private float _cursorTweenDistance;

		// Token: 0x04029C15 RID: 171029
		[Token(Token = "0x4029C15")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeFocusNodeView _focusNodeView;

		// Token: 0x04029C16 RID: 171030
		[Token(Token = "0x4029C16")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04029C17 RID: 171031
		[Token(Token = "0x4029C17")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _localTrans;

		// Token: 0x04029C18 RID: 171032
		[Token(Token = "0x4029C18")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, RoguelikeDungeonNodeView> m_views;

		// Token: 0x04029C19 RID: 171033
		[Token(Token = "0x4029C19")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_cursorTweener;

		// Token: 0x04029C1A RID: 171034
		[Token(Token = "0x4029C1A")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeDungeonZoneView.ShowSwitchTween m_showSwitchTween;

		// Token: 0x04029C1B RID: 171035
		[Token(Token = "0x4029C1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04029C1C RID: 171036
		[Token(Token = "0x4029C1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetShow;

		// Token: 0x04029C1D RID: 171037
		[Token(Token = "0x4029C1D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetViewByNode;

		// Token: 0x04029C1E RID: 171038
		[Token(Token = "0x4029C1E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateZone;

		// Token: 0x04029C1F RID: 171039
		[Token(Token = "0x4029C1F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderZone;

		// Token: 0x04029C20 RID: 171040
		[Token(Token = "0x4029C20")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CleanNodeEffect;

		// Token: 0x04029C21 RID: 171041
		[Token(Token = "0x4029C21")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadDungeonNodePrefabWithTopicId;

		// Token: 0x04029C22 RID: 171042
		[Token(Token = "0x4029C22")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayCursorAnimation;

		// Token: 0x04029C23 RID: 171043
		[Token(Token = "0x4029C23")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005266 RID: 21094
		[Token(Token = "0x2005266")]
		public class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0601F1F4 RID: 127476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F1F4")]
			[Address(RVA = "0x18DBF40", Offset = "0x18DAB40", VA = "0x1818DBF40")]
			public ShowSwitchTween(RoguelikeDungeonZoneView closure)
			{
			}

			// Token: 0x0601F1F5 RID: 127477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F1F5")]
			[Address(RVA = "0x18DB8A0", Offset = "0x18DA4A0", VA = "0x1818DB8A0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F1F6 RID: 127478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F1F6")]
			[Address(RVA = "0x18DBC10", Offset = "0x18DA810", VA = "0x1818DBC10", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F1F7 RID: 127479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F1F7")]
			[Address(RVA = "0x18DBD70", Offset = "0x18DA970", VA = "0x1818DBD70", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F1F8 RID: 127480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F1F8")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04029C24 RID: 171044
			[Token(Token = "0x4029C24")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeDungeonZoneView m_closure;

			// Token: 0x04029C25 RID: 171045
			[Token(Token = "0x4029C25")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029C26 RID: 171046
			[Token(Token = "0x4029C26")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04029C27 RID: 171047
			[Token(Token = "0x4029C27")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04029C28 RID: 171048
			[Token(Token = "0x4029C28")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
