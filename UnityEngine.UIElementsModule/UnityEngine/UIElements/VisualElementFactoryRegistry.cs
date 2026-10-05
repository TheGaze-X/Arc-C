using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	internal class VisualElementFactoryRegistry
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000484")]
		internal static Dictionary<string, List<IUxmlFactory>> factories
		{
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x5B30F90", Offset = "0x5B2FB90", VA = "0x185B30F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x5B308A0", Offset = "0x5B2F4A0", VA = "0x185B308A0")]
		protected static void RegisterFactory(IUxmlFactory factory)
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x5B30F20", Offset = "0x5B2FB20", VA = "0x185B30F20")]
		internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
		{
			return default(bool);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x5B2F890", Offset = "0x5B2E490", VA = "0x185B2F890")]
		private static void RegisterEngineFactories()
		{
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x5B30C30", Offset = "0x5B2F830", VA = "0x185B30C30")]
		internal static void RegisterUserFactories()
		{
		}

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<IUxmlFactory>> s_Factories;
	}
}
