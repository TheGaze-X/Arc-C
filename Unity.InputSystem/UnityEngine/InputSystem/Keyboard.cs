using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = true)]
	public class Keyboard : InputDevice, ITextInputReceiver
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000D")]
		public event Action<char> onTextInput
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x564ADF0", Offset = "0x56499F0", VA = "0x18564ADF0")]
			add
			{
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x564CBC0", Offset = "0x564B7C0", VA = "0x18564CBC0")]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		public event Action<IMECompositionString> onIMECompositionChange
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x564AD00", Offset = "0x5649900", VA = "0x18564AD00")]
			add
			{
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x564CB70", Offset = "0x564B770", VA = "0x18564CB70")]
			remove
			{
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x564AC90", Offset = "0x5649890", VA = "0x18564AC90")]
		public void SetIMEEnabled(bool enabled)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x564AC20", Offset = "0x5649820", VA = "0x18564AC20")]
		public void SetIMECursorPosition(Vector2 position)
		{
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DD")]
		public string keyboardLayout
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x564BB90", Offset = "0x564A790", VA = "0x18564BB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			protected set
			{
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DE")]
		public AnyKeyControl anyKey
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DF")]
		public KeyControl spaceKey
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x564C8F0", Offset = "0x564B4F0", VA = "0x18564C8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E0")]
		public KeyControl enterKey
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x564B5D0", Offset = "0x564A1D0", VA = "0x18564B5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E1")]
		public KeyControl tabKey
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x564C970", Offset = "0x564B570", VA = "0x18564C970")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E2")]
		public KeyControl backquoteKey
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x564B010", Offset = "0x5649C10", VA = "0x18564B010")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E3")]
		public KeyControl quoteKey
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x564C5F0", Offset = "0x564B1F0", VA = "0x18564C5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E4")]
		public KeyControl semicolonKey
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x564C870", Offset = "0x564B470", VA = "0x18564C870")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E5")]
		public KeyControl commaKey
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x564B150", Offset = "0x5649D50", VA = "0x18564B150")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E6")]
		public KeyControl periodKey
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x564C530", Offset = "0x564B130", VA = "0x18564C530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E7")]
		public KeyControl slashKey
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x564C8B0", Offset = "0x564B4B0", VA = "0x18564C8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E8")]
		public KeyControl backslashKey
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x564B050", Offset = "0x5649C50", VA = "0x18564B050")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E9")]
		public KeyControl leftBracketKey
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x564BCB0", Offset = "0x564A8B0", VA = "0x18564BCB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EA")]
		public KeyControl rightBracketKey
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x564C730", Offset = "0x564B330", VA = "0x18564C730")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EB")]
		public KeyControl minusKey
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x564BDB0", Offset = "0x564A9B0", VA = "0x18564BDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EC")]
		public KeyControl equalsKey
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x564B610", Offset = "0x564A210", VA = "0x18564B610")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001ED")]
		public KeyControl aKey
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x564AF30", Offset = "0x5649B30", VA = "0x18564AF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EE")]
		public KeyControl bKey
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x564AFD0", Offset = "0x5649BD0", VA = "0x18564AFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EF")]
		public KeyControl cKey
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x564B0D0", Offset = "0x5649CD0", VA = "0x18564B0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F0")]
		public KeyControl dKey
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x564B210", Offset = "0x5649E10", VA = "0x18564B210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F1")]
		public KeyControl eKey
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x564B550", Offset = "0x564A150", VA = "0x18564B550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F2")]
		public KeyControl fKey
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x564B990", Offset = "0x564A590", VA = "0x18564B990")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F3")]
		public KeyControl gKey
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x564B9D0", Offset = "0x564A5D0", VA = "0x18564B9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F4")]
		public KeyControl hKey
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x564BA10", Offset = "0x564A610", VA = "0x18564BA10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F5")]
		public KeyControl iKey
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x564BA90", Offset = "0x564A690", VA = "0x18564BA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F6")]
		public KeyControl jKey
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x564BB10", Offset = "0x564A710", VA = "0x18564BB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F7")]
		public KeyControl kKey
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x564BB50", Offset = "0x564A750", VA = "0x18564BB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F8")]
		public KeyControl lKey
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x564BBB0", Offset = "0x564A7B0", VA = "0x18564BBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F9")]
		public KeyControl mKey
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x564BD70", Offset = "0x564A970", VA = "0x18564BD70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FA")]
		public KeyControl nKey
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x564BDF0", Offset = "0x564A9F0", VA = "0x18564BDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FB")]
		public KeyControl oKey
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x564C2B0", Offset = "0x564AEB0", VA = "0x18564C2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FC")]
		public KeyControl pKey
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x564C430", Offset = "0x564B030", VA = "0x18564C430")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FD")]
		public KeyControl qKey
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x564C5B0", Offset = "0x564B1B0", VA = "0x18564C5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FE")]
		public KeyControl rKey
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x564C630", Offset = "0x564B230", VA = "0x18564C630")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FF")]
		public KeyControl sKey
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x564C7F0", Offset = "0x564B3F0", VA = "0x18564C7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000200")]
		public KeyControl tKey
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x564C930", Offset = "0x564B530", VA = "0x18564C930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000201")]
		public KeyControl uKey
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x564C9B0", Offset = "0x564B5B0", VA = "0x18564C9B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000202")]
		public KeyControl vKey
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x564CA30", Offset = "0x564B630", VA = "0x18564CA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000203")]
		public KeyControl wKey
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x564CA70", Offset = "0x564B670", VA = "0x18564CA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000204")]
		public KeyControl xKey
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x564CAB0", Offset = "0x564B6B0", VA = "0x18564CAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000205")]
		public KeyControl yKey
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x564CAF0", Offset = "0x564B6F0", VA = "0x18564CAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000206")]
		public KeyControl zKey
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x564CB30", Offset = "0x564B730", VA = "0x18564CB30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000207")]
		public KeyControl digit1Key
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x564B2D0", Offset = "0x5649ED0", VA = "0x18564B2D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000208")]
		public KeyControl digit2Key
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x564B310", Offset = "0x5649F10", VA = "0x18564B310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000209")]
		public KeyControl digit3Key
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x564B350", Offset = "0x5649F50", VA = "0x18564B350")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020A")]
		public KeyControl digit4Key
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x564B390", Offset = "0x5649F90", VA = "0x18564B390")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020B")]
		public KeyControl digit5Key
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x564B3D0", Offset = "0x5649FD0", VA = "0x18564B3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020C")]
		public KeyControl digit6Key
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x564B410", Offset = "0x564A010", VA = "0x18564B410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020D")]
		public KeyControl digit7Key
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x564B450", Offset = "0x564A050", VA = "0x18564B450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020E")]
		public KeyControl digit8Key
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x564B490", Offset = "0x564A090", VA = "0x18564B490")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020F")]
		public KeyControl digit9Key
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x564B4D0", Offset = "0x564A0D0", VA = "0x18564B4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000210")]
		public KeyControl digit0Key
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x564B290", Offset = "0x5649E90", VA = "0x18564B290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000211")]
		public KeyControl leftShiftKey
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x564BD30", Offset = "0x564A930", VA = "0x18564BD30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000212")]
		public KeyControl rightShiftKey
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x564C7B0", Offset = "0x564B3B0", VA = "0x18564C7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000213")]
		public KeyControl leftAltKey
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x564BBF0", Offset = "0x564A7F0", VA = "0x18564BBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000214")]
		public KeyControl rightAltKey
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x564C670", Offset = "0x564B270", VA = "0x18564C670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000215")]
		public KeyControl leftCtrlKey
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x564BCF0", Offset = "0x564A8F0", VA = "0x18564BCF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000216")]
		public KeyControl rightCtrlKey
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x564C770", Offset = "0x564B370", VA = "0x18564C770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000217")]
		public KeyControl leftMetaKey
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x564BC30", Offset = "0x564A830", VA = "0x18564BC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000218")]
		public KeyControl rightMetaKey
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x564C6B0", Offset = "0x564B2B0", VA = "0x18564C6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000219")]
		public KeyControl leftWindowsKey
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x564BC30", Offset = "0x564A830", VA = "0x18564BC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021A")]
		public KeyControl rightWindowsKey
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x564C6B0", Offset = "0x564B2B0", VA = "0x18564C6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021B")]
		public KeyControl leftAppleKey
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x564BC30", Offset = "0x564A830", VA = "0x18564BC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021C")]
		public KeyControl rightAppleKey
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x564C6B0", Offset = "0x564B2B0", VA = "0x18564C6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021D")]
		public KeyControl leftCommandKey
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x564BC30", Offset = "0x564A830", VA = "0x18564BC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021E")]
		public KeyControl rightCommandKey
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x564C6B0", Offset = "0x564B2B0", VA = "0x18564C6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021F")]
		public KeyControl contextMenuKey
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x564B190", Offset = "0x5649D90", VA = "0x18564B190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000220")]
		public KeyControl escapeKey
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x564B650", Offset = "0x564A250", VA = "0x18564B650")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000221")]
		public KeyControl leftArrowKey
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x564BC70", Offset = "0x564A870", VA = "0x18564BC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000222")]
		public KeyControl rightArrowKey
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x564C6F0", Offset = "0x564B2F0", VA = "0x18564C6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000223")]
		public KeyControl upArrowKey
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x564C9F0", Offset = "0x564B5F0", VA = "0x18564C9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000224")]
		public KeyControl downArrowKey
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x564B510", Offset = "0x564A110", VA = "0x18564B510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000225")]
		public KeyControl backspaceKey
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x564B090", Offset = "0x5649C90", VA = "0x18564B090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000226")]
		public KeyControl pageDownKey
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x564C470", Offset = "0x564B070", VA = "0x18564C470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000227")]
		public KeyControl pageUpKey
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x564C4B0", Offset = "0x564B0B0", VA = "0x18564C4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000228")]
		public KeyControl homeKey
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x564BA50", Offset = "0x564A650", VA = "0x18564BA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000229")]
		public KeyControl endKey
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x564B590", Offset = "0x564A190", VA = "0x18564B590")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022A")]
		public KeyControl insertKey
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x564BAD0", Offset = "0x564A6D0", VA = "0x18564BAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022B")]
		public KeyControl deleteKey
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x564B250", Offset = "0x5649E50", VA = "0x18564B250")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022C")]
		public KeyControl capsLockKey
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x564B110", Offset = "0x5649D10", VA = "0x18564B110")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022D")]
		public KeyControl scrollLockKey
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x564C830", Offset = "0x564B430", VA = "0x18564C830")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022E")]
		public KeyControl numLockKey
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x564BE30", Offset = "0x564AA30", VA = "0x18564BE30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022F")]
		public KeyControl printScreenKey
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x564C570", Offset = "0x564B170", VA = "0x18564C570")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000230")]
		public KeyControl pauseKey
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x564C4F0", Offset = "0x564B0F0", VA = "0x18564C4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000231")]
		public KeyControl numpadEnterKey
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x564C130", Offset = "0x564AD30", VA = "0x18564C130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000232")]
		public KeyControl numpadDivideKey
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x564C0F0", Offset = "0x564ACF0", VA = "0x18564C0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000233")]
		public KeyControl numpadMultiplyKey
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x564C1F0", Offset = "0x564ADF0", VA = "0x18564C1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000234")]
		public KeyControl numpadMinusKey
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x564C1B0", Offset = "0x564ADB0", VA = "0x18564C1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000235")]
		public KeyControl numpadPlusKey
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x564C270", Offset = "0x564AE70", VA = "0x18564C270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000236")]
		public KeyControl numpadPeriodKey
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x564C230", Offset = "0x564AE30", VA = "0x18564C230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000237")]
		public KeyControl numpadEqualsKey
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x564C170", Offset = "0x564AD70", VA = "0x18564C170")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000238")]
		public KeyControl numpad0Key
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x564BE70", Offset = "0x564AA70", VA = "0x18564BE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000239")]
		public KeyControl numpad1Key
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x564BEB0", Offset = "0x564AAB0", VA = "0x18564BEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023A")]
		public KeyControl numpad2Key
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x564BEF0", Offset = "0x564AAF0", VA = "0x18564BEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023B")]
		public KeyControl numpad3Key
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x564BF30", Offset = "0x564AB30", VA = "0x18564BF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023C")]
		public KeyControl numpad4Key
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x564BF70", Offset = "0x564AB70", VA = "0x18564BF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023D")]
		public KeyControl numpad5Key
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x564BFB0", Offset = "0x564ABB0", VA = "0x18564BFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023E")]
		public KeyControl numpad6Key
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x564BFF0", Offset = "0x564ABF0", VA = "0x18564BFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023F")]
		public KeyControl numpad7Key
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x564C030", Offset = "0x564AC30", VA = "0x18564C030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000240")]
		public KeyControl numpad8Key
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x564C070", Offset = "0x564AC70", VA = "0x18564C070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000241")]
		public KeyControl numpad9Key
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x564C0B0", Offset = "0x564ACB0", VA = "0x18564C0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000242")]
		public KeyControl f1Key
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x564B750", Offset = "0x564A350", VA = "0x18564B750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000243")]
		public KeyControl f2Key
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x564B790", Offset = "0x564A390", VA = "0x18564B790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000244")]
		public KeyControl f3Key
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x564B7D0", Offset = "0x564A3D0", VA = "0x18564B7D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000245")]
		public KeyControl f4Key
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x564B810", Offset = "0x564A410", VA = "0x18564B810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000246")]
		public KeyControl f5Key
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x564B850", Offset = "0x564A450", VA = "0x18564B850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000247")]
		public KeyControl f6Key
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x564B890", Offset = "0x564A490", VA = "0x18564B890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000248")]
		public KeyControl f7Key
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x564B8D0", Offset = "0x564A4D0", VA = "0x18564B8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000249")]
		public KeyControl f8Key
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x564B910", Offset = "0x564A510", VA = "0x18564B910")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024A")]
		public KeyControl f9Key
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x564B950", Offset = "0x564A550", VA = "0x18564B950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024B")]
		public KeyControl f10Key
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x564B690", Offset = "0x564A290", VA = "0x18564B690")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024C")]
		public KeyControl f11Key
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x564B6D0", Offset = "0x564A2D0", VA = "0x18564B6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024D")]
		public KeyControl f12Key
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x564B710", Offset = "0x564A310", VA = "0x18564B710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024E")]
		public KeyControl oem1Key
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x564C2F0", Offset = "0x564AEF0", VA = "0x18564C2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024F")]
		public KeyControl oem2Key
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x564C330", Offset = "0x564AF30", VA = "0x18564C330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000250")]
		public KeyControl oem3Key
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x564C370", Offset = "0x564AF70", VA = "0x18564C370")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000251")]
		public KeyControl oem4Key
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000252")]
		public KeyControl oem5Key
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x564C3F0", Offset = "0x564AFF0", VA = "0x18564C3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public ButtonControl shiftKey
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000254")]
		public ButtonControl ctrlKey
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000255")]
		public ButtonControl altKey
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x560D490", Offset = "0x560C090", VA = "0x18560D490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000256")]
		public ButtonControl imeSelected
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		[Token(Token = "0x17000257")]
		public KeyControl this[Key key]
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x564AEE0", Offset = "0x5649AE0", VA = "0x18564AEE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x17000258")]
		public ReadOnlyArray<KeyControl> allKeys
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x564AF70", Offset = "0x5649B70", VA = "0x18564AF70")]
			get
			{
				return default(ReadOnlyArray<KeyControl>);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000259")]
		public static Keyboard current
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x564B1D0", Offset = "0x5649DD0", VA = "0x18564B1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x564CC10", Offset = "0x564B810", VA = "0x18564CC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x564A880", Offset = "0x5649480", VA = "0x18564A880", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x564A9F0", Offset = "0x56495F0", VA = "0x18564A9F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x5647B50", Offset = "0x5646750", VA = "0x185647B50", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x564AB10", Offset = "0x5649710", VA = "0x18564AB10", Slot = "14")]
		protected override void RefreshConfiguration()
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x564AA80", Offset = "0x5649680", VA = "0x18564AA80", Slot = "22")]
		public void OnTextInput(char character)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x5647A30", Offset = "0x5646630", VA = "0x185647A30")]
		public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName)
		{
			return null;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x564A8E0", Offset = "0x56494E0", VA = "0x18564A8E0", Slot = "23")]
		public void OnIMECompositionChanged(IMECompositionString compositionString)
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025A")]
		protected KeyControl[] keys
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			set
			{
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public Keyboard()
		{
		}

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		public const int KeyCount = 110;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x198")]
		private InlinedArray<Action<char>> m_TextInputListeners;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x1B0")]
		private string m_KeyboardLayoutName;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x1B8")]
		private KeyControl[] m_Keys;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x1C0")]
		private InlinedArray<Action<IMECompositionString>> m_ImeCompositionListeners;
	}
}
