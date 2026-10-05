using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public class PointerEventData : BaseEventData
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AC")]
		public GameObject pointerEnter
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AD")]
		public GameObject lastPress
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AE")]
		public GameObject rawPointerPress
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AF")]
		public GameObject pointerDrag
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B0")]
		public GameObject pointerClick
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B1")]
		public RaycastResult pointerCurrentRaycast
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x5B8F160", Offset = "0x5B8DD60", VA = "0x185B8F160")]
			[CompilerGenerated]
			get
			{
				return default(RaycastResult);
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x5B8F400", Offset = "0x5B8E000", VA = "0x185B8F400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00004830 File Offset: 0x00002A30
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B2")]
		public RaycastResult pointerPressRaycast
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x5B8F1A0", Offset = "0x5B8DDA0", VA = "0x185B8F1A0")]
			[CompilerGenerated]
			get
			{
				return default(RaycastResult);
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x5B8F440", Offset = "0x5B8E040", VA = "0x185B8F440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B3")]
		public bool eligibleForClick
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x2213A10", Offset = "0x2212610", VA = "0x182213A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x58E26D0", Offset = "0x58E12D0", VA = "0x1858E26D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00004860 File Offset: 0x00002A60
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B4")]
		public int pointerId
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x58E26C0", Offset = "0x58E12C0", VA = "0x1858E26C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x58E28E0", Offset = "0x58E14E0", VA = "0x1858E28E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00004878 File Offset: 0x00002A78
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B5")]
		public Vector2 position
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x5B8F1E0", Offset = "0x5B8DDE0", VA = "0x185B8F1E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x53B4110", Offset = "0x53B2D10", VA = "0x1853B4110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B6")]
		public Vector2 delta
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x5B8F080", Offset = "0x5B8DC80", VA = "0x185B8F080")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x538FBE0", Offset = "0x538E7E0", VA = "0x18538FBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000048A8 File Offset: 0x00002AA8
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B7")]
		public Vector2 pressPosition
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x5B8F2B0", Offset = "0x5B8DEB0", VA = "0x185B8F2B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x538FBC0", Offset = "0x538E7C0", VA = "0x18538FBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000048C0 File Offset: 0x00002AC0
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B8")]
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x5B8F380", Offset = "0x5B8DF80", VA = "0x185B8F380")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x5B8F5C0", Offset = "0x5B8E1C0", VA = "0x185B8F5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x000048D8 File Offset: 0x00002AD8
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B9")]
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x5B8F360", Offset = "0x5B8DF60", VA = "0x185B8F360")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x5B8F5A0", Offset = "0x5B8E1A0", VA = "0x185B8F5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x000048F0 File Offset: 0x00002AF0
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BA")]
		public float clickTime
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x5B8F070", Offset = "0x5B8DC70", VA = "0x185B8F070")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x5B8F3D0", Offset = "0x5B8DFD0", VA = "0x185B8F3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00004908 File Offset: 0x00002B08
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BB")]
		public int clickCount
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x5080700", Offset = "0x507F300", VA = "0x185080700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x5A39A30", Offset = "0x5A38630", VA = "0x185A39A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00004920 File Offset: 0x00002B20
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BC")]
		public Vector2 scrollDelta
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x5B8F320", Offset = "0x5B8DF20", VA = "0x185B8F320")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x5B8F560", Offset = "0x5B8E160", VA = "0x185B8F560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00004938 File Offset: 0x00002B38
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BD")]
		public bool useDragThreshold
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xEBB440", Offset = "0xEBA040", VA = "0x180EBB440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x5B8F590", Offset = "0x5B8E190", VA = "0x185B8F590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00004950 File Offset: 0x00002B50
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BE")]
		public bool dragging
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x5B8F0A0", Offset = "0x5B8DCA0", VA = "0x185B8F0A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x5B8F3E0", Offset = "0x5B8DFE0", VA = "0x185B8F3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00004968 File Offset: 0x00002B68
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BF")]
		public PointerEventData.InputButton button
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x5B8F060", Offset = "0x5B8DC60", VA = "0x185B8F060")]
			[CompilerGenerated]
			get
			{
				return PointerEventData.InputButton.Left;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x5B8F3C0", Offset = "0x5B8DFC0", VA = "0x185B8F3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00004980 File Offset: 0x00002B80
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C0")]
		public float pressure
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x5B8F2D0", Offset = "0x5B8DED0", VA = "0x185B8F2D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x5B8F520", Offset = "0x5B8E120", VA = "0x185B8F520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00004998 File Offset: 0x00002B98
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C1")]
		public float tangentialPressure
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x5B8F340", Offset = "0x5B8DF40", VA = "0x185B8F340")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x5B8F570", Offset = "0x5B8E170", VA = "0x185B8F570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x000049B0 File Offset: 0x00002BB0
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C2")]
		public float altitudeAngle
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x5B8F040", Offset = "0x5B8DC40", VA = "0x185B8F040")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x5B8F3A0", Offset = "0x5B8DFA0", VA = "0x185B8F3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x000049C8 File Offset: 0x00002BC8
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C3")]
		public float azimuthAngle
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x5B8F050", Offset = "0x5B8DC50", VA = "0x185B8F050")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x5B8F3B0", Offset = "0x5B8DFB0", VA = "0x185B8F3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x000049E0 File Offset: 0x00002BE0
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C4")]
		public float twist
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x5B8F350", Offset = "0x5B8DF50", VA = "0x185B8F350")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x5B8F580", Offset = "0x5B8E180", VA = "0x185B8F580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000049F8 File Offset: 0x00002BF8
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C5")]
		public Vector2 radius
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x5B8F300", Offset = "0x5B8DF00", VA = "0x185B8F300")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x5B8F540", Offset = "0x5B8E140", VA = "0x185B8F540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C6")]
		public Vector2 radiusVariance
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x5B8F2E0", Offset = "0x5B8DEE0", VA = "0x185B8F2E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x5B8F530", Offset = "0x5B8E130", VA = "0x185B8F530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C7")]
		public bool fullyExited
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x5A21EC0", Offset = "0x5A20AC0", VA = "0x185A21EC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x5B8F3F0", Offset = "0x5B8DFF0", VA = "0x185B8F3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00004A40 File Offset: 0x00002C40
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C8")]
		public bool reentered
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x5A214C0", Offset = "0x5A200C0", VA = "0x185A214C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x5B8F550", Offset = "0x5B8E150", VA = "0x185B8F550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x5B8EDD0", Offset = "0x5B8D9D0", VA = "0x185B8EDD0")]
		public PointerEventData(EventSystem eventSystem)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x5B8E730", Offset = "0x5B8D330", VA = "0x185B8E730")]
		public bool IsPointerMoving()
		{
			return default(bool);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x5B8E760", Offset = "0x5B8D360", VA = "0x185B8E760")]
		public bool IsScrolling()
		{
			return default(bool);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C9")]
		public Camera enterEventCamera
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x5B8F0B0", Offset = "0x5B8DCB0", VA = "0x185B8F0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CA")]
		public Camera pressEventCamera
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x5B8F200", Offset = "0x5B8DE00", VA = "0x185B8F200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CB")]
		public GameObject pointerPress
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x5B8F480", Offset = "0x5B8E080", VA = "0x185B8F480")]
			set
			{
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x5B8E790", Offset = "0x5B8D390", VA = "0x185B8E790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_PointerPress;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0xF0")]
		public List<GameObject> hovered;

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		public enum InputButton
		{
			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			Left,
			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			Right,
			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			Middle
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		public enum FramePressState
		{
			// Token: 0x0400032C RID: 812
			[Token(Token = "0x400032C")]
			Pressed,
			// Token: 0x0400032D RID: 813
			[Token(Token = "0x400032D")]
			Released,
			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			PressedAndReleased,
			// Token: 0x0400032F RID: 815
			[Token(Token = "0x400032F")]
			NotChanged
		}
	}
}
