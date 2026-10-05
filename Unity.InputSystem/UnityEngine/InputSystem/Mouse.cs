using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	[InputControlLayout(stateType = typeof(MouseState), isGenericTypeOfDevice = true)]
	public class Mouse : Pointer, IInputStateCallbackReceiver
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		public DeltaControl scroll
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		public ButtonControl leftButton
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025D")]
		public ButtonControl middleButton
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025E")]
		public ButtonControl rightButton
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025F")]
		public ButtonControl backButton
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		public ButtonControl forwardButton
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000261")]
		public IntegerControl clickCount
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000262")]
		public new static Mouse current
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x564D1A0", Offset = "0x564BDA0", VA = "0x18564D1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x564D1E0", Offset = "0x564BDE0", VA = "0x18564D1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x564CE60", Offset = "0x564BA60", VA = "0x18564CE60", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x564CF00", Offset = "0x564BB00", VA = "0x18564CF00", Slot = "18")]
		protected override void OnAdded()
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x564D020", Offset = "0x564BC20", VA = "0x18564D020", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x564D130", Offset = "0x564BD30", VA = "0x18564D130")]
		public void WarpCursorPosition(Vector2 position)
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x564CC70", Offset = "0x564B870", VA = "0x18564CC70", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x564CF80", Offset = "0x564BB80", VA = "0x18564CF80")]
		protected new void OnNextUpdate()
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x564D0B0", Offset = "0x564BCB0", VA = "0x18564D0B0")]
		protected new void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x564CF80", Offset = "0x564BB80", VA = "0x18564CF80", Slot = "22")]
		private void OnNextUpdate()
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x564D0B0", Offset = "0x564BCB0", VA = "0x18564D0B0", Slot = "23")]
		private void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public Mouse()
		{
		}

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x8")]
		internal static Mouse s_PlatformMouseDevice;
	}
}
