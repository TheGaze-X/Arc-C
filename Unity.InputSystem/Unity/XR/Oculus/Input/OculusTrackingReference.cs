using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.Oculus.Input
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class OculusTrackingReference : TrackedDevice
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		[InputControl(aliases = new string[]
		{
			"trackingReferenceTrackingState"
		})]
		public new IntegerControl trackingState
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		[InputControl(aliases = new string[]
		{
			"trackingReferenceIsTracked"
		})]
		public new ButtonControl isTracked
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x55DD3E0", Offset = "0x55DBFE0", VA = "0x1855DD3E0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x55CDA70", Offset = "0x55CC670", VA = "0x1855CDA70")]
		public OculusTrackingReference()
		{
		}
	}
}
