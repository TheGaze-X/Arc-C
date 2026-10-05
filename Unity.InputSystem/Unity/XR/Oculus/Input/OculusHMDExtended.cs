using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.Oculus.Input
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[InputControlLayout(displayName = "Oculus Headset (w/ on-headset controls)", hideInUI = true)]
	public class OculusHMDExtended : OculusHMD
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		[InputControl]
		public ButtonControl back
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x55DCAF0", Offset = "0x55DB6F0", VA = "0x1855DCAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x55DCB10", Offset = "0x55DB710", VA = "0x1855DCB10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		[InputControl]
		public Vector2Control touchpad
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x55DCB00", Offset = "0x55DB700", VA = "0x1855DCB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x55DCB20", Offset = "0x55DB720", VA = "0x1855DCB20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x55DCA40", Offset = "0x55DB640", VA = "0x1855DCA40", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public OculusHMDExtended()
		{
		}
	}
}
