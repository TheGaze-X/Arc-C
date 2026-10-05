using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[InputControlLayout(commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, isGenericTypeOfDevice = true, displayName = "XR Controller")]
	public class XRController : TrackedDevice
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700030B")]
		public static XRController leftHand
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x56B5580", Offset = "0x56B4180", VA = "0x1856B5580")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700030C")]
		public static XRController rightHand
		{
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x56B5620", Offset = "0x56B4220", VA = "0x1856B5620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x56B5450", Offset = "0x56B4050", VA = "0x1856B5450", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x55CDA70", Offset = "0x55CC670", VA = "0x1855CDA70")]
		public XRController()
		{
		}
	}
}
