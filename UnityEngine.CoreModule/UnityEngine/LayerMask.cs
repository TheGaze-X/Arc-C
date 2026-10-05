using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[NativeHeader("Runtime/BaseClasses/BitField.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[NativeClass("BitField", "struct BitField;")]
	public struct LayerMask
	{
		// Token: 0x060009A8 RID: 2472 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x595F820", Offset = "0x595E420", VA = "0x18595F820")]
		public static implicit operator int(LayerMask mask)
		{
			return 0;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x595F820", Offset = "0x595E420", VA = "0x18595F820")]
		public static implicit operator LayerMask(int intVal)
		{
			return default(LayerMask);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00005BF8 File Offset: 0x00003DF8
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		public int value
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x060009AC RID: 2476
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x595F7E0", Offset = "0x595E3E0", VA = "0x18595F7E0")]
		[NativeMethod("StringToLayer")]
		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		[MethodImpl(4096)]
		public static extern int NameToLayer(string layerName);

		// Token: 0x060009AD RID: 2477 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x595F700", Offset = "0x595E300", VA = "0x18595F700")]
		public static int GetMask(params string[] layerNames)
		{
			return 0;
		}

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("m_Bits")]
		private int m_Mask;
	}
}
