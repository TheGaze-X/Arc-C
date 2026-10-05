using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : struct, IConvertible
	{
		// Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AC")]
		public UxmlEnumAttributeDescription()
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011AD")]
		public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x60011AE")]
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value)
		{
			return default(bool);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011AF")]
		private static U ConvertValueToEnum<U>(string v, U defaultValue)
		{
			return null;
		}
	}
}
