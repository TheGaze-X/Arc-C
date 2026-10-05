using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public class IntegerControl : InputControl<int>
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x5606DE0", Offset = "0x56059E0", VA = "0x185606DE0")]
		public IntegerControl()
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x5606CA0", Offset = "0x56058A0", VA = "0x185606CA0", Slot = "17")]
		public unsafe override int ReadUnprocessedValueFromState(void* statePtr)
		{
			return 0;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x5606D40", Offset = "0x5605940", VA = "0x185606D40", Slot = "18")]
		public unsafe override void WriteValueIntoState(int value, void* statePtr)
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x5606BC0", Offset = "0x56057C0", VA = "0x185606BC0", Slot = "15")]
		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
