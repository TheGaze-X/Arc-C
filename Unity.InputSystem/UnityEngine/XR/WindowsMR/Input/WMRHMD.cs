using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace UnityEngine.XR.WindowsMR.Input
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[InputControlLayout(displayName = "Windows MR Headset", hideInUI = true)]
	public class WMRHMD : XRHMD
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		[InputControl]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[]
		{
			"HeadPosition"
		})]
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[]
		{
			"HeadRotation"
		})]
		public ButtonControl userPresence
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x55E4A00", Offset = "0x55E3600", VA = "0x1855E4A00", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public WMRHMD()
		{
		}
	}
}
