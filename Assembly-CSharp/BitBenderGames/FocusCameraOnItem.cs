using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	[RequireComponent(typeof(MobileTouchCamera))]
	public class FocusCameraOnItem : MonoBehaviourWrapped
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BA")]
		private MobileTouchCamera MobileTouchCamera
		{
			[Token(Token = "0x6004B1C")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B1D")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		// (set) Token: 0x06004B1F RID: 19231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BB")]
		public float TransitionDuration
		{
			[Token(Token = "0x6004B1E")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004B1F")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			set
			{
			}
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x1680DC0", Offset = "0x167F9C0", VA = "0x181680DC0")]
		public void Awake()
		{
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x1681530", Offset = "0x1680130", VA = "0x181681530")]
		public void LateUpdate()
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x1681780", Offset = "0x1680380", VA = "0x181681780")]
		private void UpdateTransform()
		{
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x1681690", Offset = "0x1680290", VA = "0x181681690")]
		public void OnPickItem(RaycastHit hitInfo)
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x1681660", Offset = "0x1680260", VA = "0x181681660")]
		public void OnPickItem2D(RaycastHit2D hitInfo2D)
		{
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x16816C0", Offset = "0x16802C0", VA = "0x1816816C0")]
		public void OnPickableTransformSelected(Transform pickableTransform)
		{
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x1681220", Offset = "0x167FE20", VA = "0x181681220")]
		public void FocusCameraOnTransform(Transform targetTransform)
		{
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x1680E10", Offset = "0x167FA10", VA = "0x181680E10")]
		public void FocusCameraOnTransform(Vector3 targetPosition)
		{
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x1680E10", Offset = "0x167FA10", VA = "0x181680E10")]
		public void FocusCameraOnTarget(Vector3 targetPosition)
		{
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x1681320", Offset = "0x167FF20", VA = "0x181681320")]
		private float GetTiltFromRotation(Quaternion camRotation)
		{
			return 0f;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x1680EA0", Offset = "0x167FAA0", VA = "0x181680EA0")]
		private void FocusCameraOnTarget(Vector3 targetPosition, Quaternion targetRotation, float targetZoom)
		{
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x16816D0", Offset = "0x16802D0", VA = "0x1816816D0")]
		private void SetTransform(Vector3 newPosition, Quaternion newRotation, float newZoom)
		{
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x1681990", Offset = "0x1680590", VA = "0x181681990")]
		public FocusCameraOnItem()
		{
		}

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float transitionDuration;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve transitionCurve;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 posTransitionStart;

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 posTransitionEnd;

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion rotTransitionStart;

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x68")]
		private Quaternion rotTransitionEnd;

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x78")]
		private float zoomTransitionStart;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x7C")]
		private float zoomTransitionEnd;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x80")]
		private float timeTransitionStart;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x84")]
		private bool isTransitionStarted;
	}
}
