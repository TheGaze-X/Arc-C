using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005627 RID: 22055
	[Token(Token = "0x2005627")]
	public class RL05SpecialZoneNodeContainer : MonoBehaviour, IRoguelikeDungeonNodeView, IHotfixable
	{
		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x060205E5 RID: 132581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060205E6 RID: 132582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BBF")]
		public Action<RoguelikeDungeonNode> onClicked
		{
			[Token(Token = "0x60205E5")]
			[Address(RVA = "0x1A85A10", Offset = "0x1A84610", VA = "0x181A85A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60205E6")]
			[Address(RVA = "0x1A85AE0", Offset = "0x1A846E0", VA = "0x181A85AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x060205E7 RID: 132583 RVA: 0x000B5938 File Offset: 0x000B3B38
		// (set) Token: 0x060205E8 RID: 132584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC0")]
		public bool isOrigin
		{
			[Token(Token = "0x60205E7")]
			[Address(RVA = "0x1A859B0", Offset = "0x1A845B0", VA = "0x181A859B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60205E8")]
			[Address(RVA = "0x1A85A70", Offset = "0x1A84670", VA = "0x181A85A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060205E9 RID: 132585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205E9")]
		[Address(RVA = "0x1A85540", Offset = "0x1A84140", VA = "0x181A85540")]
		public void Render(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x060205EA RID: 132586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205EA")]
		[Address(RVA = "0x1A85200", Offset = "0x1A83E00", VA = "0x181A85200")]
		public RectTransform GetLinePointRectTransform(RL05SpecialZoneNodeConnector nodeConnector)
		{
			return null;
		}

		// Token: 0x060205EB RID: 132587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205EB")]
		[Address(RVA = "0x1A857D0", Offset = "0x1A843D0", VA = "0x181A857D0")]
		public void SetShow(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x060205EC RID: 132588 RVA: 0x000B5950 File Offset: 0x000B3B50
		[Token(Token = "0x60205EC")]
		[Address(RVA = "0x1A85440", Offset = "0x1A84040", VA = "0x181A85440", Slot = "4")]
		public Color GetSelectableColor()
		{
			return default(Color);
		}

		// Token: 0x060205ED RID: 132589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205ED")]
		[Address(RVA = "0x1A85350", Offset = "0x1A83F50", VA = "0x181A85350", Slot = "5")]
		public RectTransform GetRectTransform()
		{
			return null;
		}

		// Token: 0x060205EE RID: 132590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205EE")]
		[Address(RVA = "0x1A85950", Offset = "0x1A84550", VA = "0x181A85950")]
		public RL05SpecialZoneNodeContainer()
		{
		}

		// Token: 0x0402BD22 RID: 179490
		[Token(Token = "0x402BD22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05SpecialZoneNodeViewBase _normalNodePrefab;

		// Token: 0x0402BD23 RID: 179491
		[Token(Token = "0x402BD23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05SpecialZoneNodeViewBase _originNodePrefab;

		// Token: 0x0402BD24 RID: 179492
		[Token(Token = "0x402BD24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0402BD25 RID: 179493
		[Token(Token = "0x402BD25")]
		[FieldOffset(Offset = "0x38")]
		private RL05SpecialZoneNodeViewBase m_nodeView;

		// Token: 0x0402BD26 RID: 179494
		[Token(Token = "0x402BD26")]
		[FieldOffset(Offset = "0x40")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402BD29 RID: 179497
		[Token(Token = "0x402BD29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402BD2A RID: 179498
		[Token(Token = "0x402BD2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402BD2B RID: 179499
		[Token(Token = "0x402BD2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isOrigin;

		// Token: 0x0402BD2C RID: 179500
		[Token(Token = "0x402BD2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isOrigin;

		// Token: 0x0402BD2D RID: 179501
		[Token(Token = "0x402BD2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BD2E RID: 179502
		[Token(Token = "0x402BD2E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetLinePointRectTransform;

		// Token: 0x0402BD2F RID: 179503
		[Token(Token = "0x402BD2F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402BD30 RID: 179504
		[Token(Token = "0x402BD30")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSelectableColor;

		// Token: 0x0402BD31 RID: 179505
		[Token(Token = "0x402BD31")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetRectTransform;

		// Token: 0x0402BD32 RID: 179506
		[Token(Token = "0x402BD32")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
