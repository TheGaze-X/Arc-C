using System;
using BitBenderGames;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005414 RID: 21524
	[Token(Token = "0x2005414")]
	public class RoguelikeCameraController : PageSingleComponent
	{
		// Token: 0x0601FA8A RID: 129674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA8A")]
		[Address(RVA = "0x1951320", Offset = "0x194FF20", VA = "0x181951320")]
		private void _EventOnDungeonZoneInit(object arg)
		{
		}

		// Token: 0x0601FA8B RID: 129675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA8B")]
		[Address(RVA = "0x1951220", Offset = "0x194FE20", VA = "0x181951220")]
		private void _EventOnDungeonNodeClick(object arg)
		{
		}

		// Token: 0x0601FA8C RID: 129676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA8C")]
		[Address(RVA = "0x1951120", Offset = "0x194FD20", VA = "0x181951120")]
		private void _EventOnDungeonBackClick(object arg)
		{
		}

		// Token: 0x0601FA8D RID: 129677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA8D")]
		[Address(RVA = "0x19509D0", Offset = "0x194F5D0", VA = "0x1819509D0")]
		public void Init(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601FA8E RID: 129678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA8E")]
		[Address(RVA = "0x1951090", Offset = "0x194FC90", VA = "0x181951090")]
		public void SetOverrideCameraConfig(RoguelikeCameraController.RoguelikeCameraConfig cameraConfig)
		{
		}

		// Token: 0x0601FA8F RID: 129679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA8F")]
		[Address(RVA = "0x1950FC0", Offset = "0x194FBC0", VA = "0x181950FC0")]
		public void SetLock(RoguelikeCameraController.LockSource lockSource, bool isLock)
		{
		}

		// Token: 0x0601FA90 RID: 129680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA90")]
		[Address(RVA = "0x1950EA0", Offset = "0x194FAA0", VA = "0x181950EA0")]
		public void SetCameraBounds(Bounds worldBounds)
		{
		}

		// Token: 0x0601FA91 RID: 129681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA91")]
		[Address(RVA = "0x1951560", Offset = "0x1950160", VA = "0x181951560")]
		private void _FocusByDelta(Vector2 delta)
		{
		}

		// Token: 0x0601FA92 RID: 129682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA92")]
		[Address(RVA = "0x1950610", Offset = "0x194F210", VA = "0x181950610")]
		public void Focus(float xPos, bool useTween = true)
		{
		}

		// Token: 0x0601FA93 RID: 129683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA93")]
		[Address(RVA = "0x19517E0", Offset = "0x19503E0", VA = "0x1819517E0")]
		private void _TweenToDeltaX(float deltaX, bool useTween)
		{
		}

		// Token: 0x0601FA94 RID: 129684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA94")]
		[Address(RVA = "0x19503C0", Offset = "0x194EFC0", VA = "0x1819503C0")]
		public void Focus(Bounds worldBounds, bool useTween = true)
		{
		}

		// Token: 0x0601FA95 RID: 129685 RVA: 0x000B2A28 File Offset: 0x000B0C28
		[Token(Token = "0x601FA95")]
		[Address(RVA = "0x19507E0", Offset = "0x194F3E0", VA = "0x1819507E0")]
		public Vector2 GetScreenPointByWorldPos(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x0601FA96 RID: 129686 RVA: 0x000B2A40 File Offset: 0x000B0C40
		[Token(Token = "0x601FA96")]
		[Address(RVA = "0x19508C0", Offset = "0x194F4C0", VA = "0x1819508C0")]
		public Vector3 GetScreenPointToWorld(RectTransform rect, Vector2 screenPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0601FA97 RID: 129687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA97")]
		[Address(RVA = "0x1951690", Offset = "0x1950290", VA = "0x181951690")]
		private void _ResetZoom()
		{
		}

		// Token: 0x0601FA98 RID: 129688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA98")]
		[Address(RVA = "0x1951B50", Offset = "0x1950750", VA = "0x181951B50")]
		public RoguelikeCameraController()
		{
		}

		// Token: 0x0402AAF2 RID: 174834
		[Token(Token = "0x402AAF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MobileTouchCamera _touchCamera;

		// Token: 0x0402AAF3 RID: 174835
		[Token(Token = "0x402AAF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TorappuTouchInputController _touchInputController;

		// Token: 0x0402AAF4 RID: 174836
		[Token(Token = "0x402AAF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rootRect;

		// Token: 0x0402AAF5 RID: 174837
		[Token(Token = "0x402AAF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _boundMargin;

		// Token: 0x0402AAF6 RID: 174838
		[Token(Token = "0x402AAF6")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _focusBoundLeft;

		// Token: 0x0402AAF7 RID: 174839
		[Token(Token = "0x402AAF7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _focusBoundRight;

		// Token: 0x0402AAF8 RID: 174840
		[Token(Token = "0x402AAF8")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Ease _focusEasyType;

		// Token: 0x0402AAF9 RID: 174841
		[Token(Token = "0x402AAF9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Unity Unit per second")]
		private float _focusSpeed;

		// Token: 0x0402AAFA RID: 174842
		[Token(Token = "0x402AAFA")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _focusMinDuration;

		// Token: 0x0402AAFB RID: 174843
		[Token(Token = "0x402AAFB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scrollDelta;

		// Token: 0x0402AAFC RID: 174844
		[Token(Token = "0x402AAFC")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tweener;

		// Token: 0x0402AAFD RID: 174845
		[Token(Token = "0x402AAFD")]
		[FieldOffset(Offset = "0x60")]
		private int m_lock;

		// Token: 0x0402AAFE RID: 174846
		[Token(Token = "0x402AAFE")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeCameraController.RoguelikeCameraConfig m_defaultCameraConfig;

		// Token: 0x0402AAFF RID: 174847
		[Token(Token = "0x402AAFF")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCameraController.RoguelikeCameraConfig m_validCameraConfig;

		// Token: 0x0402AB00 RID: 174848
		[Token(Token = "0x402AB00")]
		[FieldOffset(Offset = "0x78")]
		private ScrollWheelHandler m_scrollWheelHandler;

		// Token: 0x0402AB01 RID: 174849
		[Token(Token = "0x402AB01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EventOnDungeonZoneInit;

		// Token: 0x0402AB02 RID: 174850
		[Token(Token = "0x402AB02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnDungeonNodeClick;

		// Token: 0x0402AB03 RID: 174851
		[Token(Token = "0x402AB03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnDungeonBackClick;

		// Token: 0x0402AB04 RID: 174852
		[Token(Token = "0x402AB04")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402AB05 RID: 174853
		[Token(Token = "0x402AB05")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetOverrideCameraConfig;

		// Token: 0x0402AB06 RID: 174854
		[Token(Token = "0x402AB06")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetLock;

		// Token: 0x0402AB07 RID: 174855
		[Token(Token = "0x402AB07")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetCameraBounds;

		// Token: 0x0402AB08 RID: 174856
		[Token(Token = "0x402AB08")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusByDelta;

		// Token: 0x0402AB09 RID: 174857
		[Token(Token = "0x402AB09")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Focus;

		// Token: 0x0402AB0A RID: 174858
		[Token(Token = "0x402AB0A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TweenToDeltaX;

		// Token: 0x0402AB0B RID: 174859
		[Token(Token = "0x402AB0B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix1_Focus;

		// Token: 0x0402AB0C RID: 174860
		[Token(Token = "0x402AB0C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetScreenPointByWorldPos;

		// Token: 0x0402AB0D RID: 174861
		[Token(Token = "0x402AB0D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetScreenPointToWorld;

		// Token: 0x0402AB0E RID: 174862
		[Token(Token = "0x402AB0E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetZoom;

		// Token: 0x0402AB0F RID: 174863
		[Token(Token = "0x402AB0F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005415 RID: 21525
		[Token(Token = "0x2005415")]
		public enum LockSource
		{
			// Token: 0x0402AB11 RID: 174865
			[Token(Token = "0x402AB11")]
			DUNGEON_PAGE = 1,
			// Token: 0x0402AB12 RID: 174866
			[Token(Token = "0x402AB12")]
			DUNGEON_STATE,
			// Token: 0x0402AB13 RID: 174867
			[Token(Token = "0x402AB13")]
			DIALOG_POPUP = 4,
			// Token: 0x0402AB14 RID: 174868
			[Token(Token = "0x402AB14")]
			SP_ZONE = 8
		}

		// Token: 0x02005416 RID: 21526
		[Token(Token = "0x2005416")]
		public class RoguelikeCameraConfig : IHotfixable
		{
			// Token: 0x0601FA9B RID: 129691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA9B")]
			[Address(RVA = "0x1950360", Offset = "0x194EF60", VA = "0x181950360")]
			public RoguelikeCameraConfig()
			{
			}

			// Token: 0x0402AB15 RID: 174869
			[Token(Token = "0x402AB15")]
			[FieldOffset(Offset = "0x10")]
			public float boundMargin;

			// Token: 0x0402AB16 RID: 174870
			[Token(Token = "0x402AB16")]
			[FieldOffset(Offset = "0x14")]
			public float focusBoundLeft;

			// Token: 0x0402AB17 RID: 174871
			[Token(Token = "0x402AB17")]
			[FieldOffset(Offset = "0x18")]
			public float focusBoundRight;

			// Token: 0x0402AB18 RID: 174872
			[Token(Token = "0x402AB18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
