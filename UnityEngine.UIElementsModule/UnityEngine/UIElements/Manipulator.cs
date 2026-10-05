using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public abstract class Manipulator : IManipulator
	{
		// Token: 0x0600015E RID: 350
		[Token(Token = "0x600015E")]
		protected abstract void RegisterCallbacksOnTarget();

		// Token: 0x0600015F RID: 351
		[Token(Token = "0x600015F")]
		protected abstract void UnregisterCallbacksFromTarget();

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public VisualElement target
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x5A37440", Offset = "0x5A36040", VA = "0x185A37440", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Manipulator()
		{
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x10")]
		private VisualElement m_Target;
	}
}
