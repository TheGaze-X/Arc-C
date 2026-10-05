using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.Oculus.Input
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[InputControlLayout(displayName = "Oculus Remote", hideInUI = true)]
	public class OculusRemote : InputDevice
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		[InputControl]
		public ButtonControl back
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		[InputControl]
		public ButtonControl start
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		[InputControl]
		public Vector2Control touchpad
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x55DCF00", Offset = "0x55DBB00", VA = "0x1855DCF00", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public OculusRemote()
		{
		}
	}
}
