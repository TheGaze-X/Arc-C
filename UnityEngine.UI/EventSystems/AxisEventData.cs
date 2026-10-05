using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public class AxisEventData : BaseEventData
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x000047D0 File Offset: 0x000029D0
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A7")]
		public Vector2 moveVector
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x168B8C0", Offset = "0x168A4C0", VA = "0x18168B8C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000047E8 File Offset: 0x000029E8
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A8")]
		public MoveDirection moveDir
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return MoveDirection.Left;
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x5B82B60", Offset = "0x5B81760", VA = "0x185B82B60")]
		public AxisEventData(EventSystem eventSystem)
		{
		}
	}
}
