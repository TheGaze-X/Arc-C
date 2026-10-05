using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class ScrollWheelHandler
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x17000176")]
		public bool isScrolling
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x5B93040", Offset = "0x5B91C40", VA = "0x185B93040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x5B92800", Offset = "0x5B91400", VA = "0x185B92800")]
		public bool CheckAvail()
		{
			return default(bool);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x5B92D00", Offset = "0x5B91900", VA = "0x185B92D00")]
		public bool SetHandler(WheelSorting sorting, Action<Vector2> handler, [Optional] IScrollTickHandler tickHandler)
		{
			return default(bool);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x5B92E30", Offset = "0x5B91A30", VA = "0x185B92E30")]
		public void TickIfInertia(float deltaTime)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x5B92850", Offset = "0x5B91450", VA = "0x185B92850")]
		public void OnBindListener(IWheelListener wheelListener)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x5B92F20", Offset = "0x5B91B20", VA = "0x185B92F20")]
		public void UnBindListener(IWheelListener wheelListener)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x5B92A50", Offset = "0x5B91650", VA = "0x185B92A50")]
		public void OnTriggerListener(IWheelListener listener, PointerEventData eventData)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x5B92FB0", Offset = "0x5B91BB0", VA = "0x185B92FB0")]
		public ScrollWheelHandler()
		{
		}

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_needScrollInertia;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IScrollTickHandler m_tickHandler;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IWheelListener> m_listeners;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<Vector2> m_handler;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WheelSorting m_currentWheelSetting;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject m_inst;
	}
}
