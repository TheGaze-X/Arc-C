using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	public class StickControl : Vector2Control
	{
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000596")]
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Up")]
		[InputControl(name = "y", minValue = -1f, maxValue = 1f, layout = "Axis", processors = "axisDeadzone")]
		[InputControl(name = "x", minValue = -1f, maxValue = 1f, layout = "Axis", processors = "axisDeadzone")]
		public ButtonControl up
		{
			[Token(Token = "0x60013A9")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000597")]
		[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Down")]
		public ButtonControl down
		{
			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013AC")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000598")]
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = true, displayName = "Left")]
		public ButtonControl left
		{
			[Token(Token = "0x60013AD")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013AE")]
			[Address(RVA = "0x55FB9E0", Offset = "0x55FA5E0", VA = "0x1855FB9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = true, displayName = "Right")]
		public ButtonControl right
		{
			[Token(Token = "0x60013AF")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013B0")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x560CB30", Offset = "0x560B730", VA = "0x18560CB30", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x55FB9C0", Offset = "0x55FA5C0", VA = "0x1855FB9C0")]
		public StickControl()
		{
		}
	}
}
