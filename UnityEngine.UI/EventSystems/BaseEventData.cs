using System;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class BaseEventData : AbstractEventData
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		public BaseEventData(EventSystem eventSystem)
		{
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		public BaseInputModule currentInputModule
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x4DF2DF0", Offset = "0x4DF19F0", VA = "0x184DF2DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AB")]
		public GameObject selectedObject
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x4DF2EE0", Offset = "0x4DF1AE0", VA = "0x184DF2EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x5B82BE0", Offset = "0x5B817E0", VA = "0x185B82BE0")]
			set
			{
			}
		}

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x18")]
		private readonly EventSystem m_EventSystem;
	}
}
