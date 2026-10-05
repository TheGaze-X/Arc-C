using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	[Preserve]
	public class DeltaControl : Vector2Control
	{
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000587")]
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Up")]
		[Preserve]
		public AxisControl up
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001370")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000588")]
		[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Down")]
		[Preserve]
		public AxisControl down
		{
			[Token(Token = "0x6001371")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001372")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000589")]
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = true, displayName = "Left")]
		[Preserve]
		public AxisControl left
		{
			[Token(Token = "0x6001373")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001374")]
			[Address(RVA = "0x55FB9E0", Offset = "0x55FA5E0", VA = "0x1855FB9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058A")]
		[Preserve]
		[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = true, displayName = "Right")]
		public AxisControl right
		{
			[Token(Token = "0x6001375")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001376")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x55FB8B0", Offset = "0x55FA4B0", VA = "0x1855FB8B0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x55FB9C0", Offset = "0x55FA5C0", VA = "0x1855FB9C0")]
		public DeltaControl()
		{
		}
	}
}
