using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public class ExtendedPointerEventData : PointerEventData
	{
		// Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x56B9D80", Offset = "0x56B8980", VA = "0x1856B9D80")]
		public ExtendedPointerEventData(EventSystem eventSystem)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035C")]
		public InputControl control
		{
			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035D")]
		public InputDevice device
		{
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000064E0 File Offset: 0x000046E0
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035E")]
		public int touchId
		{
			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x56B9DA0", Offset = "0x56B89A0", VA = "0x1856B9DA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x56B9E00", Offset = "0x56B8A00", VA = "0x1856B9E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000064F8 File Offset: 0x000046F8
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		public UIPointerType pointerType
		{
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x56B9D90", Offset = "0x56B8990", VA = "0x1856B9D90")]
			[CompilerGenerated]
			get
			{
				return UIPointerType.None;
			}
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x56B9DF0", Offset = "0x56B89F0", VA = "0x1856B9DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		public int uiToolkitPointerId
		{
			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x56B9DE0", Offset = "0x56B89E0", VA = "0x1856B9DE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x56B9E40", Offset = "0x56B8A40", VA = "0x1856B9E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00006528 File Offset: 0x00004728
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public Vector3 trackedDevicePosition
		{
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x56B9DC0", Offset = "0x56B89C0", VA = "0x1856B9DC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x56B9E20", Offset = "0x56B8A20", VA = "0x1856B9E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public Quaternion trackedDeviceOrientation
		{
			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x56B9DB0", Offset = "0x56B89B0", VA = "0x1856B9DB0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x56B9E10", Offset = "0x56B8A10", VA = "0x1856B9E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x56B98A0", Offset = "0x56B84A0", VA = "0x1856B98A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x56B9390", Offset = "0x56B7F90", VA = "0x1856B9390")]
		internal static int MakePointerIdForTouch(int deviceId, int touchId)
		{
			return 0;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x3B13DD0", Offset = "0x3B129D0", VA = "0x183B13DD0")]
		internal static int TouchIdFromPointerId(int pointerId)
		{
			return 0;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x56B93A0", Offset = "0x56B7FA0", VA = "0x1856B93A0")]
		internal void ReadDeviceState()
		{
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x56B8FC0", Offset = "0x56B7BC0", VA = "0x1856B8FC0")]
		private static int GetPenPointerId(Pen pen)
		{
			return 0;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x56B91F0", Offset = "0x56B7DF0", VA = "0x1856B91F0")]
		private static int GetTouchPointerId(TouchControl touchControl)
		{
			return 0;
		}
	}
}
