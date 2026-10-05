using System;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public class BaseInput : UIBehaviour
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EF")]
		public virtual string compositionString
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x5B841D0", Offset = "0x5B82DD0", VA = "0x185B841D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00004BF0 File Offset: 0x00002DF0
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F0")]
		public virtual IMECompositionMode imeCompositionMode
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x5B841E0", Offset = "0x5B82DE0", VA = "0x185B841E0", Slot = "18")]
			get
			{
				return IMECompositionMode.Auto;
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x5B84260", Offset = "0x5B82E60", VA = "0x185B84260", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00004C08 File Offset: 0x00002E08
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F1")]
		public virtual Vector2 compositionCursorPos
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x5B841C0", Offset = "0x5B82DC0", VA = "0x185B841C0", Slot = "20")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x5B84240", Offset = "0x5B82E40", VA = "0x185B84240", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x170001F2")]
		public virtual bool mousePresent
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x5A363E0", Offset = "0x5A34FE0", VA = "0x185A363E0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x5B84190", Offset = "0x5B82D90", VA = "0x185B84190", Slot = "23")]
		public virtual bool GetMouseButtonDown(int button)
		{
			return default(bool);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x5B841A0", Offset = "0x5B82DA0", VA = "0x185B841A0", Slot = "24")]
		public virtual bool GetMouseButtonUp(int button)
		{
			return default(bool);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x5B841B0", Offset = "0x5B82DB0", VA = "0x185B841B0", Slot = "25")]
		public virtual bool GetMouseButton(int button)
		{
			return default(bool);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x170001F3")]
		public virtual Vector2 mousePosition
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x5B841F0", Offset = "0x5B82DF0", VA = "0x185B841F0", Slot = "26")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x170001F4")]
		public virtual Vector2 mouseScrollDelta
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x5B84220", Offset = "0x5B82E20", VA = "0x185B84220", Slot = "27")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x170001F5")]
		public virtual bool touchSupported
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x5B84230", Offset = "0x5B82E30", VA = "0x185B84230", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x170001F6")]
		public virtual int touchCount
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x5A363F0", Offset = "0x5A34FF0", VA = "0x185A363F0", Slot = "29")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x5A36390", Offset = "0x5A34F90", VA = "0x185A36390", Slot = "30")]
		public virtual Touch GetTouch(int index)
		{
			return default(Touch);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x5B84180", Offset = "0x5B82D80", VA = "0x185B84180", Slot = "31")]
		public virtual float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x5A36380", Offset = "0x5A34F80", VA = "0x185A36380", Slot = "32")]
		public virtual bool GetButtonDown(string buttonName)
		{
			return default(bool);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BaseInput()
		{
		}
	}
}
