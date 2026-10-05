using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
	{
		// Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x5B2DE60", Offset = "0x5B2CA60", VA = "0x185B2DE60")]
		public UxmlIntAttributeDescription()
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x5B2DB70", Offset = "0x5B2C770", VA = "0x185B2DB70", Slot = "4")]
		public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return 0;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x5B2DCE0", Offset = "0x5B2C8E0", VA = "0x185B2DCE0")]
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value)
		{
			return default(bool);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x5B2DB30", Offset = "0x5B2C730", VA = "0x185B2DB30")]
		private static int ConvertValueToInt(string v, int defaultValue)
		{
			return 0;
		}
	}
}
