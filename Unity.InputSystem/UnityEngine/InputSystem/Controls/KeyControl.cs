using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public class KeyControl : ButtonControl
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0000A4D0 File Offset: 0x000086D0
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000590")]
		public Key keyCode
		{
			[Token(Token = "0x6001397")]
			[Address(RVA = "0x5080A10", Offset = "0x507F610", VA = "0x185080A10")]
			[CompilerGenerated]
			get
			{
				return Key.None;
			}
			[Token(Token = "0x6001398")]
			[Address(RVA = "0x560AC40", Offset = "0x5609840", VA = "0x18560AC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x17000591")]
		public int scanCode
		{
			[Token(Token = "0x6001399")]
			[Address(RVA = "0x560AC20", Offset = "0x5609820", VA = "0x18560AC20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x560AA00", Offset = "0x5609600", VA = "0x18560AA00", Slot = "14")]
		protected override void RefreshConfiguration()
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x55FBD40", Offset = "0x55FA940", VA = "0x1855FBD40")]
		public KeyControl()
		{
		}

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x13C")]
		private int m_ScanCode;
	}
}
