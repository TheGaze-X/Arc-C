using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = true)]
	public class Pointer : InputDevice, IInputStateCallbackReceiver
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026E")]
		public Vector2Control position
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026F")]
		public DeltaControl delta
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000270")]
		public Vector2Control radius
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000271")]
		public AxisControl pressure
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x560D490", Offset = "0x560C090", VA = "0x18560D490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public ButtonControl press
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000273")]
		public IntegerControl displayIndex
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		public static Pointer current
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x564DB10", Offset = "0x564C710", VA = "0x18564DB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x564DB50", Offset = "0x564C750", VA = "0x18564DB50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x564D920", Offset = "0x564C520", VA = "0x18564D920", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x564DA10", Offset = "0x564C610", VA = "0x18564DA10", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x564D780", Offset = "0x564C380", VA = "0x18564D780", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x564D980", Offset = "0x564C580", VA = "0x18564D980")]
		protected void OnNextUpdate()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x564DAA0", Offset = "0x564C6A0", VA = "0x18564DAA0")]
		protected void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x564DB00", Offset = "0x564C700", VA = "0x18564DB00", Slot = "22")]
		private void OnNextUpdate()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x564DAA0", Offset = "0x564C6A0", VA = "0x18564DAA0", Slot = "23")]
		private void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
		private bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return default(bool);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public Pointer()
		{
		}
	}
}
