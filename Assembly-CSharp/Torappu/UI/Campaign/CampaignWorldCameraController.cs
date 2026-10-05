using System;
using BitBenderGames;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060F1 RID: 24817
	[Token(Token = "0x20060F1")]
	public class CampaignWorldCameraController : MonoBehaviour, IHotfixable, IScrollNormalizedPosition
	{
		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x06023DE4 RID: 146916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054BF")]
		public ScrollWheelHandler handler
		{
			[Token(Token = "0x6023DE4")]
			[Address(RVA = "0x1E8A650", Offset = "0x1E89250", VA = "0x181E8A650")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x06023DE5 RID: 146917 RVA: 0x000C2478 File Offset: 0x000C0678
		[Token(Token = "0x170054C0")]
		public Vector2 position
		{
			[Token(Token = "0x6023DE5")]
			[Address(RVA = "0x1E8A6B0", Offset = "0x1E892B0", VA = "0x181E8A6B0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06023DE6 RID: 146918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DE6")]
		[Address(RVA = "0x1E8A100", Offset = "0x1E88D00", VA = "0x181E8A100")]
		public void InitIfNot()
		{
		}

		// Token: 0x06023DE7 RID: 146919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DE7")]
		[Address(RVA = "0x1E8A320", Offset = "0x1E88F20", VA = "0x181E8A320")]
		private void OnEnable()
		{
		}

		// Token: 0x06023DE8 RID: 146920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DE8")]
		[Address(RVA = "0x1E8A380", Offset = "0x1E88F80", VA = "0x181E8A380")]
		private void OnWheelTo(Vector2 delta)
		{
		}

		// Token: 0x06023DE9 RID: 146921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023DE9")]
		[Address(RVA = "0x1E89D70", Offset = "0x1E88970", VA = "0x181E89D70")]
		public Camera GetCamera()
		{
			return null;
		}

		// Token: 0x06023DEA RID: 146922 RVA: 0x000C2490 File Offset: 0x000C0690
		[Token(Token = "0x6023DEA")]
		[Address(RVA = "0x1E89DF0", Offset = "0x1E889F0", VA = "0x181E89DF0")]
		public Vector3 GetIntersectPointOnCanvas()
		{
			return default(Vector3);
		}

		// Token: 0x06023DEB RID: 146923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DEB")]
		[Address(RVA = "0x1E8A560", Offset = "0x1E89160", VA = "0x181E8A560")]
		private void Update()
		{
		}

		// Token: 0x06023DEC RID: 146924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DEC")]
		[Address(RVA = "0x1E8A490", Offset = "0x1E89090", VA = "0x181E8A490")]
		public void SetLock(CampaignWorldCameraController.LockSource lockSource, bool isLock)
		{
		}

		// Token: 0x06023DED RID: 146925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DED")]
		[Address(RVA = "0x1E897C0", Offset = "0x1E883C0", VA = "0x181E897C0")]
		public void Focus(CampaignWorldCameraController.FocusParam param)
		{
		}

		// Token: 0x06023DEE RID: 146926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DEE")]
		[Address(RVA = "0x1E8A5E0", Offset = "0x1E891E0", VA = "0x181E8A5E0")]
		public CampaignWorldCameraController()
		{
		}

		// Token: 0x04031C0A RID: 203786
		[Token(Token = "0x4031C0A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _targetCanvas;

		// Token: 0x04031C0B RID: 203787
		[Token(Token = "0x4031C0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MobileTouchCamera _touchCamera;

		// Token: 0x04031C0C RID: 203788
		[Token(Token = "0x4031C0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Unity Unit per second")]
		private float _focusSpeed;

		// Token: 0x04031C0D RID: 203789
		[Token(Token = "0x4031C0D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _focusMinDuration;

		// Token: 0x04031C0E RID: 203790
		[Token(Token = "0x4031C0E")]
		[FieldOffset(Offset = "0x30")]
		private ScrollWheelHandler m_handler;

		// Token: 0x04031C0F RID: 203791
		[Token(Token = "0x4031C0F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04031C10 RID: 203792
		[Token(Token = "0x4031C10")]
		[FieldOffset(Offset = "0x3C")]
		private int m_lock;

		// Token: 0x04031C11 RID: 203793
		[Token(Token = "0x4031C11")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tweener;

		// Token: 0x04031C12 RID: 203794
		[Token(Token = "0x4031C12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x04031C13 RID: 203795
		[Token(Token = "0x4031C13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x04031C14 RID: 203796
		[Token(Token = "0x4031C14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04031C15 RID: 203797
		[Token(Token = "0x4031C15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04031C16 RID: 203798
		[Token(Token = "0x4031C16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnWheelTo;

		// Token: 0x04031C17 RID: 203799
		[Token(Token = "0x4031C17")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCamera;

		// Token: 0x04031C18 RID: 203800
		[Token(Token = "0x4031C18")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetIntersectPointOnCanvas;

		// Token: 0x04031C19 RID: 203801
		[Token(Token = "0x4031C19")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04031C1A RID: 203802
		[Token(Token = "0x4031C1A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetLock;

		// Token: 0x04031C1B RID: 203803
		[Token(Token = "0x4031C1B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Focus;

		// Token: 0x04031C1C RID: 203804
		[Token(Token = "0x4031C1C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060F2 RID: 24818
		[Token(Token = "0x20060F2")]
		public class FocusParam
		{
			// Token: 0x06023DEF RID: 146927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023DEF")]
			[Address(RVA = "0x1E9B0A0", Offset = "0x1E99CA0", VA = "0x181E9B0A0")]
			public FocusParam()
			{
			}

			// Token: 0x04031C1D RID: 203805
			[Token(Token = "0x4031C1D")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 worldPosition;

			// Token: 0x04031C1E RID: 203806
			[Token(Token = "0x4031C1E")]
			[FieldOffset(Offset = "0x1C")]
			public bool useTween;

			// Token: 0x04031C1F RID: 203807
			[Token(Token = "0x4031C1F")]
			[FieldOffset(Offset = "0x20")]
			public Ease easeType;

			// Token: 0x04031C20 RID: 203808
			[Token(Token = "0x4031C20")]
			[FieldOffset(Offset = "0x28")]
			public Action onFinished;

			// Token: 0x04031C21 RID: 203809
			[Token(Token = "0x4031C21")]
			[FieldOffset(Offset = "0x30")]
			public bool overrideDuration;

			// Token: 0x04031C22 RID: 203810
			[Token(Token = "0x4031C22")]
			[FieldOffset(Offset = "0x34")]
			public float duration;
		}

		// Token: 0x020060F3 RID: 24819
		[Token(Token = "0x20060F3")]
		public enum LockSource
		{
			// Token: 0x04031C24 RID: 203812
			[Token(Token = "0x4031C24")]
			SELF = 1,
			// Token: 0x04031C25 RID: 203813
			[Token(Token = "0x4031C25")]
			PAGE,
			// Token: 0x04031C26 RID: 203814
			[Token(Token = "0x4031C26")]
			HOME_STATE = 4
		}
	}
}
