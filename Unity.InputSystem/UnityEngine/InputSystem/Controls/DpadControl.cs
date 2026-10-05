using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	public class DpadControl : Vector2Control
	{
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058B")]
		[InputControl(bit = 0U, displayName = "Up")]
		[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = true)]
		[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = true)]
		public ButtonControl up
		{
			[Token(Token = "0x6001380")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001381")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058C")]
		[InputControl(bit = 1U, displayName = "Down")]
		public ButtonControl down
		{
			[Token(Token = "0x6001382")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001383")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058D")]
		[InputControl(bit = 2U, displayName = "Left")]
		public ButtonControl left
		{
			[Token(Token = "0x6001384")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x55FB9E0", Offset = "0x55FA5E0", VA = "0x1855FB9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058E")]
		[InputControl(bit = 3U, displayName = "Right")]
		public ButtonControl right
		{
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x55FC8A0", Offset = "0x55FB4A0", VA = "0x1855FC8A0")]
		public DpadControl()
		{
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x55FC120", Offset = "0x55FAD20", VA = "0x1855FC120", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x55FC2D0", Offset = "0x55FAED0", VA = "0x1855FC2D0", Slot = "17")]
		public unsafe override Vector2 ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Vector2);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x55FC590", Offset = "0x55FB190", VA = "0x1855FC590", Slot = "18")]
		public unsafe override void WriteValueIntoState(Vector2 value, void* statePtr)
		{
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x55FC250", Offset = "0x55FAE50", VA = "0x1855FC250")]
		public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true)
		{
			return default(Vector2);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x55FC230", Offset = "0x55FAE30", VA = "0x1855FC230")]
		public static Vector2 MakeDpadVector(float up, float down, float left, float right)
		{
			return default(Vector2);
		}

		// Token: 0x02000216 RID: 534
		[Token(Token = "0x2000216")]
		[InputControlLayout(hideInUI = true)]
		public class DpadAxisControl : AxisControl
		{
			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x0600138E RID: 5006 RVA: 0x0000A470 File Offset: 0x00008670
			// (set) Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700058F")]
			public int component
			{
				[Token(Token = "0x600138E")]
				[Address(RVA = "0x55FC100", Offset = "0x55FAD00", VA = "0x1855FC100")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600138F")]
				[Address(RVA = "0x55FC110", Offset = "0x55FAD10", VA = "0x1855FC110")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001390")]
			[Address(RVA = "0x55FBEA0", Offset = "0x55FAAA0", VA = "0x1855FBEA0", Slot = "13")]
			protected override void FinishSetup()
			{
			}

			// Token: 0x06001391 RID: 5009 RVA: 0x0000A488 File Offset: 0x00008688
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x55FBF20", Offset = "0x55FAB20", VA = "0x1855FBF20", Slot = "17")]
			public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
			{
				return 0f;
			}

			// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001392")]
			[Address(RVA = "0x55FC0F0", Offset = "0x55FACF0", VA = "0x1855FC0F0")]
			public DpadAxisControl()
			{
			}
		}

		// Token: 0x02000217 RID: 535
		[Token(Token = "0x2000217")]
		internal enum ButtonBits
		{
			// Token: 0x04000BAC RID: 2988
			[Token(Token = "0x4000BAC")]
			Up,
			// Token: 0x04000BAD RID: 2989
			[Token(Token = "0x4000BAD")]
			Down,
			// Token: 0x04000BAE RID: 2990
			[Token(Token = "0x4000BAE")]
			Left,
			// Token: 0x04000BAF RID: 2991
			[Token(Token = "0x4000BAF")]
			Right
		}
	}
}
