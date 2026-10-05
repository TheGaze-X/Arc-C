using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : BaseField<TValueType>.UxmlTraits where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000705")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000706")]
		public BaseFieldTraits()
		{
		}

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x0")]
		private TValueUxmlAttributeType m_Value;
	}
}
