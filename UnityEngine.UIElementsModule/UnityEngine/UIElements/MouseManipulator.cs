using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public abstract class MouseManipulator : Manipulator
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public List<ManipulatorActivationFilter> activators
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5A37C10", Offset = "0x5A36810", VA = "0x185A37C10")]
		protected MouseManipulator()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x5A379D0", Offset = "0x5A365D0", VA = "0x185A379D0")]
		protected bool CanStartManipulation(IMouseEvent e)
		{
			return default(bool);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x5A37BA0", Offset = "0x5A367A0", VA = "0x185A37BA0")]
		protected bool CanStopManipulation(IMouseEvent e)
		{
			return default(bool);
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		private ManipulatorActivationFilter m_currentActivator;
	}
}
