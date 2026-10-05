using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	public class MobileTouchPickable : MonoBehaviour
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B3")]
		public Transform PickableTransform
		{
			[Token(Token = "0x6004B0C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B0D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0002CD78 File Offset: 0x0002AF78
		[Token(Token = "0x170001B4")]
		public Vector2 LocalSnapOffset
		{
			[Token(Token = "0x6004B0E")]
			[Address(RVA = "0x168B8C0", Offset = "0x168A4C0", VA = "0x18168B8C0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x1692BC0", Offset = "0x16917C0", VA = "0x181692BC0")]
		public void Awake()
		{
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x1692ED0", Offset = "0x1691AD0", VA = "0x181692ED0")]
		public MobileTouchPickable()
		{
		}

		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x0")]
		private static MobileTouchCamera mobileTouchCam;

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Optional. This value only needs to be set in case the collider of the pickable item is not on the root object of the pickable item.")]
		private Transform pickableTransform;

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("When snapping is enabled, this value defines a position offset that is added to the center of the object when dragging. Note that this value is added on top of the snapOffset defined in the MobilePickingController. When a top-down camera is used, these 2 values are applied to the X/Z position.")]
		private Vector2 localSnapOffset;
	}
}
