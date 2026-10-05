using System;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public abstract class AbstractEventData
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x13A5FA0", Offset = "0x13A4BA0", VA = "0x1813A5FA0", Slot = "4")]
		public virtual void Reset()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000663")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0", Slot = "5")]
		public virtual void Use()
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x170001A9")]
		public virtual bool used
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractEventData()
		{
		}

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_Used;
	}
}
