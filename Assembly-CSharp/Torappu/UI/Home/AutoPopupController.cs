using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B34 RID: 19252
	[Token(Token = "0x2004B34")]
	public class AutoPopupController
	{
		// Token: 0x0601CFF4 RID: 118772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF4")]
		[Address(RVA = "0x1667220", Offset = "0x1665E20", VA = "0x181667220")]
		public void Clear()
		{
		}

		// Token: 0x0601CFF5 RID: 118773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF5")]
		[Address(RVA = "0x1667290", Offset = "0x1665E90", VA = "0x181667290")]
		public void Reset(Func<AutoPopupItem, bool> popupHandler)
		{
		}

		// Token: 0x0601CFF6 RID: 118774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF6")]
		[Address(RVA = "0x1667180", Offset = "0x1665D80", VA = "0x181667180")]
		public void AddEvent(AutoPopupType type, [Optional] object param)
		{
		}

		// Token: 0x0601CFF7 RID: 118775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF7")]
		[Address(RVA = "0x1667280", Offset = "0x1665E80", VA = "0x181667280")]
		public void InitialTrigger()
		{
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x0601CFF8 RID: 118776 RVA: 0x000A9F98 File Offset: 0x000A8198
		[Token(Token = "0x17004439")]
		public bool isActive
		{
			[Token(Token = "0x601CFF8")]
			[Address(RVA = "0x1667800", Offset = "0x1666400", VA = "0x181667800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601CFF9 RID: 118777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF9")]
		[Address(RVA = "0x1667280", Offset = "0x1665E80", VA = "0x181667280")]
		public void OnStateResume()
		{
		}

		// Token: 0x0601CFFA RID: 118778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFFA")]
		[Address(RVA = "0x1667490", Offset = "0x1666090", VA = "0x181667490")]
		private void _TriggerResume()
		{
		}

		// Token: 0x0601CFFB RID: 118779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFFB")]
		[Address(RVA = "0x1667680", Offset = "0x1666280", VA = "0x181667680")]
		private void _TryTriggerNextPopup(HomePage homePage)
		{
		}

		// Token: 0x0601CFFC RID: 118780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFFC")]
		[Address(RVA = "0x1667300", Offset = "0x1665F00", VA = "0x181667300")]
		private IEnumerator _TriggerPopupCoroutine(HomePage homePage, Queue<AutoPopupItem> items)
		{
			return null;
		}

		// Token: 0x0601CFFD RID: 118781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFFD")]
		[Address(RVA = "0x16673B0", Offset = "0x1665FB0", VA = "0x1816673B0")]
		private void _TriggerPopupWithItems(Queue<AutoPopupItem> items)
		{
		}

		// Token: 0x0601CFFE RID: 118782 RVA: 0x000A9FB0 File Offset: 0x000A81B0
		[Token(Token = "0x601CFFE")]
		[Address(RVA = "0x1667450", Offset = "0x1666050", VA = "0x181667450")]
		private bool _TriggerPopup(AutoPopupItem popup)
		{
			return default(bool);
		}

		// Token: 0x0601CFFF RID: 118783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFFF")]
		[Address(RVA = "0x1667770", Offset = "0x1666370", VA = "0x181667770")]
		public AutoPopupController()
		{
		}

		// Token: 0x04026092 RID: 155794
		[Token(Token = "0x4026092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Func<AutoPopupItem, bool> m_popupHandler;

		// Token: 0x04026093 RID: 155795
		[Token(Token = "0x4026093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isTriggering;

		// Token: 0x04026094 RID: 155796
		[Token(Token = "0x4026094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<AutoPopupItem> m_items;
	}
}
